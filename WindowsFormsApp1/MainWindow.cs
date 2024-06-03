using System;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp1.data;
using WindowsFormsApp1.manager;
using MessageBox = System.Windows.Forms.MessageBox;
namespace WindowsFormsApp1
{
    public partial class MainWindow : Form
    {
        public string[] filtrerData = {
            "id","nombre","extension"
        };

        Models currentModel;
        DatabaseManager datamanager;
        public MainWindow()
        {
            InitializeComponent();
            Filters.Items.AddRange(filtrerData);
            Filters.SelectedIndex = 0;

        }

        private void UpdateGrid()
        {
            datamanager = new DatabaseManager(
                DatabaseManager.ConnectionStringUser[0],
                DatabaseManager.ConnectionStringUser[1],
                DatabaseManager.ConnectionStringUser[2],
                DatabaseManager.ConnectionStringUser[3]
                );
            datamanager.PopulateDataGridView(DataGridView);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            UpdateGrid();
        }
        private void RestartData()
        {
            NameModel.Clear();
            extModel.Clear();
            DescriptionModel.Clear();
            DateModel.Text = DateTime.Today.ToString();
            SizeModel.Clear();
            userControl11.ChangeModel(null);
        }

        private void UpdateCurrentDataModel(Models currentModel)
        {
            NameModel.Text = currentModel.Name;
            extModel.Text = currentModel.Ext;
            DescriptionModel.Text = currentModel.Description;
            DateModel.Text = currentModel.Date.ToString();
            SizeModel.Text = currentModel.Size;
            userControl11.ChangeModel(Core.Convert3models(currentModel));
        }
        private void UpdateModel_Click(object sender, EventArgs e)
        {
            if (currentModel is null)
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "ID no válido",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RestartData();
            }
            else
            {
                UpdateModel form = new UpdateModel(currentModel);
                form.ShowDialog();
                currentModel = datamanager.GetModelById(int.Parse(SearchText.Text));
                UpdateCurrentDataModel(currentModel);
                UpdateGrid();
            }
        }

        private void InsertModel_Click(object sender, EventArgs e)
        {
            AddModel form = new AddModel();
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateGrid();
            }

        }

        private void SaveModel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Desea guardar el archivo?", 
                "Guardar Archivo", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            // Si el usuario selecciona "Sí"
            if (result == DialogResult.Yes)
            {
                // Crear y configurar el SaveFileDialog
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "3ds files (*.3ds)|*.3ds|stl files (*.stl)|*.stl|obj files (*.obj)|*.obj",
                    Title = "Guardar archivo como"
                };

                // Mostrar el SaveFileDialog y obtener el resultado
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    string filePath = saveFileDialog.FileName;
                    using (MemoryStream stream = new MemoryStream())
                    {
                        File.WriteAllBytes(filePath, currentModel.DataBytes);
                    }

                    MessageBox.Show(
                        "Archivo guardado en: " + filePath, 
                        "Archivo Guardado", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                }
            }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            switch (Filters.SelectedIndex)
            {
                case 0:

                    currentModel = datamanager.GetModelById(int.Parse(SearchText.Text));
                    if (currentModel is null)
                    {
                        MessageBox.Show(
                            "Por favor, ingrese un ID válido.", 
                            "ID no válido",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        RestartData();
                    }
                    else
                    {
                        currentModel.id = int.Parse(SearchText.Text);
                        UpdateCurrentDataModel(currentModel);
                    }

                    ; break;
                case 1:

                    ; break;
                case 2:
                    ; break;
            }
        }

        private void DeleteModel_Click(object sender, EventArgs e)
        {
            if (Filters.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Por favor, seleccione un filtro.", 
                    "Filtro no válido", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "¿Está seguro de que desea borrar el modelo?", 
                "Confirmar eliminación", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                switch (Filters.SelectedIndex)
                {
                    case 0:
                        if (int.TryParse(SearchText.Text, out int id))
                        {
                            datamanager.DeleteModelById(id);
                            MessageBox.Show(
                                "Modelo borrado exitosamente.", 
                                "Éxito", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(
                                "Por favor, ingrese un ID válido.",
                                "ID no válido", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning);
                        }
                        break;

                    case 1:
                        datamanager.DeleteModelByName(SearchText.Text);
                        MessageBox.Show(
                            "Modelo borrado exitosamente.", 
                            "Éxito", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
                        break;

                    default:
                        MessageBox.Show(
                            "El filtro seleccionado no es válido.", 
                            "Filtro no válido", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Warning);
                        break;
                }
                RestartData();
                UpdateGrid();
            }
        }
    }
}
