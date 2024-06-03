using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using WindowsFormsApp1.data;
using WindowsFormsApp1.manager;
using WpfControlLibrary4;
namespace WindowsFormsApp1
{
    public partial class AddModel : Form
    {
        string filePath;
        string ext;
        manager.Models DataModel;
        public AddModel()
        {
            InitializeComponent();
        }

        private void AddModel_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            DatabaseManager dbManager = new DatabaseManager(
                DatabaseManager.ConnectionStringUser[0],
                DatabaseManager.ConnectionStringUser[1],
                DatabaseManager.ConnectionStringUser[2],
                DatabaseManager.ConnectionStringUser[3]);
            if (DataModel != null)
            {
                dbManager.InsertModelData(DataModel.Name, DataModel.Description, DataModel.Ext, DataModel.Size, DataModel.DataBytes);
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }

        private void Addmodel2insert_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "3ds files (*.3ds)|*.3ds|stl files (*.stl)|*.stl|obj files (*.obj)|*.obj";
                openFileDialog.FilterIndex = 3;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
                DataModel = new Models(tbName.Text, rbDescription.Text, DateTime.Now);
                ext = Path.GetExtension(filePath);
                DataModel.Ext = ext;
                DataModel.DataBytes = Core.ReadFile(filePath);
                DataModel.Size = ByteConverter.ConvertBytesToReadableSize(DataModel.DataBytes.Length);
                Model3DGroup currentModel;
                switch (DataModel.Ext.ToLower())
                {
                    case ".obj":
                        currentModel = Visor3D.Byte2obj(DataModel.DataBytes);
                        break;
                    case ".stl":
                        currentModel = Visor3D.Byte2stl(DataModel.DataBytes);
                        break;
                    case ".3ds":
                        currentModel = Visor3D.Byte2studio3d(DataModel.DataBytes);
                        break;
                    default:
                        throw new NotSupportedException("tipo de archivo no soportado.");
                }

                if (currentModel is null)
                {
                    this.Close();
                }
                userControl11.ChangeModel(currentModel);

            }
        }

    }
}
