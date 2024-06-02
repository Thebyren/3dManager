using HelixToolkit.Wpf;
using System;
using System.IO;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Media3D;
namespace WpfControlLibrary4
{
    public partial class UserControl1 : UserControl
    {
        string fullPath="";

        public UserControl1()
        {
            InitializeComponent();
            fullPath="../../../WpfControlLibrary4/assets/cube.obj" ;
        }
        public void Load3dModel(Model3DGroup model3d)
        {
            Material outsideMaterial = MaterialHelper.CreateMaterial(Colors.Red, 0.1);
            Material insideMaterial = MaterialHelper.CreateMaterial(Colors.Blue, 0.8);

            if (model3d == null)
            {
                var importer = new HelixToolkit.Wpf.ObjReader
                {
                    DefaultMaterial = outsideMaterial // Material predeterminado para la parte delantera del modelo
                };

                using (var stream = File.OpenRead(fullPath))
                {
                    model3d = importer.Read(stream);
                }
            }

            // Aplicar material para la parte trasera del modelo
            foreach (var childModel in model3d.Children)
            {
                if (childModel is GeometryModel3D geometryModel)
                {
                    geometryModel.Material = insideMaterial;
                    geometryModel.BackMaterial = outsideMaterial;
                }
            }

            ChangeModel(model3d);
        }
        public void ChangeModel(Model3DGroup model3d)
        {

            helixViewport.Children.Clear();
            ModelVisual3D modelVisual = new ModelVisual3D
            {
                Content = model3d
            };
            helixViewport.Children.Add(new DefaultLights());
            helixViewport.Children.Add(modelVisual);

        }
        private void helixViewport_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            Load3dModel(null);
        }

    }
}
