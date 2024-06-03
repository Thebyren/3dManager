using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using WindowsFormsApp1.data;
using WindowsFormsApp1.manager;
using WpfControlLibrary4;

namespace WindowsFormsApp1
{
    public partial class UpdateModel : Form
    {
        public Models UpdatedModelData;
        public string filePath;
        public UpdateModel(Models modelo)
        {
            InitializeComponent();
            UpdatedModelData = modelo;
            FillData(modelo);
        }
        public void readData()
        {
            UpdatedModelData.Name = name.Text;
            UpdatedModelData.Description = description.Text;
            UpdatedModelData.Date = date.Value;
        }
        public void FillData(Models modelo)
        {
            name.Text = modelo.Name;
            ext.Text = modelo.Ext;
            description.Text = modelo.Description;
            date.Value = modelo.Date;
            size.Text = modelo.Size;
            userControl11.ChangeModel(Core.Convert3models(modelo));
        }

        private void Addmodel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "3ds files (*.3ds)|*.3ds|stl files (*.stl)|*.stl|obj files (*.obj)|*.obj";
                openFileDialog.FilterIndex = 3;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() != DialogResult.OK) return; // Exit if no file was selected

                filePath = openFileDialog.FileName;


                UpdatedModelData.Ext = Path.GetExtension(filePath);
                UpdatedModelData.DataBytes = Core.ReadFile(filePath);
                UpdatedModelData.Size = ByteConverter.ConvertBytesToReadableSize(UpdatedModelData.DataBytes.Length);
                Model3DGroup currentModel;
                switch (UpdatedModelData.Ext.ToLower())
                {
                    case ".obj":
                        currentModel = Visor3D.Byte2obj(UpdatedModelData.DataBytes);
                        break;
                    case ".stl":
                        currentModel = Visor3D.Byte2stl(UpdatedModelData.DataBytes);
                        break;
                    case ".3ds":
                        currentModel = Visor3D.Byte2studio3d(UpdatedModelData.DataBytes);
                        break;
                    default:
                        throw new NotSupportedException("File type not supported.");
                }


                if (currentModel == null)
                {
                    this.Close();
                }

                userControl11.ChangeModel(currentModel);
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            DatabaseManager manager = new DatabaseManager(
                DatabaseManager.ConnectionStringUser[0],
                DatabaseManager.ConnectionStringUser[1],
                DatabaseManager.ConnectionStringUser[2],
                DatabaseManager.ConnectionStringUser[3]);
            readData();
            manager.UpdateModel(UpdatedModelData);
            this.Close();
        }

        private void updateModel_Load(object sender, EventArgs e)
        {
            if (UpdatedModelData == null)
            {
                Console.WriteLine("UpdatedModelData is null");
                return;
            }

        }

        private void UpdateModel_Shown(object sender, EventArgs e)
        {
        }

        private void UpdateModel_Enter(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("si esto no lo arregla no se que lo hara");
            userControl11.ChangeModel(Core.Convert3models(UpdatedModelData));
        }
    }
}
