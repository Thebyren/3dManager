using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.manager;
namespace WindowsFormsApp1.data
{

    public class DatabaseManager
    {
        private readonly string connectionString;

        public DatabaseManager(string server, string database, string username, string password)
        {
            connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";
        }

        public void InsertModelData(string Name, string Description, string Ext, string Size, byte[] DataBytes)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string insertMetadataQuery = "INSERT INTO ModelMetadata " +
                    "(name, description, extension, Size) VALUES (@Name, @Description, @Extension, @Size);";
                string insertDataQuery = "INSERT INTO ModelData (model_id, data) VALUES (@ModelId, @Data);";

                connection.Open();
                using (MySqlCommand command = new MySqlCommand(insertMetadataQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@Description", Description);
                    command.Parameters.AddWithValue("@Size", Size);
                    command.Parameters.AddWithValue("@Extension", Ext);
                    command.ExecuteNonQuery();
                }

                long lastInsertedId;
                using (MySqlCommand command = new MySqlCommand("SELECT LAST_INSERT_ID();", connection))
                {
                    lastInsertedId = Convert.ToInt64(command.ExecuteScalar());
                }

                using (MySqlCommand command = new MySqlCommand(insertDataQuery, connection))
                {
                    command.Parameters.AddWithValue("@ModelId", lastInsertedId);
                    command.Parameters.AddWithValue("@Data", DataBytes);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteModelById(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string deleteMetadataQuery = "DELETE FROM ModelMetadata WHERE id = @Id;";
                string deleteDataQuery = "DELETE FROM ModelData WHERE model_id = @ModelId;";

                connection.Open();
                using (MySqlCommand command = new MySqlCommand(deleteDataQuery, connection))
                {
                    command.Parameters.AddWithValue("@ModelId", id);
                    command.ExecuteNonQuery();
                }

                using (MySqlCommand command = new MySqlCommand(deleteMetadataQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void PopulateDataGridView(DataGridView dataGridView)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string selectQuery = "SELECT id, name, description,size, created_at, extension FROM ModelMetadata;";

                connection.Open();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }
            }
        }


        public Models GetModelById(int id)
        {
            Models model = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string selectQuery = "SELECT m.name, m.description, m.created_at, m.extension, d.data " +
                                     "FROM ModelMetadata m " +
                                     "INNER JOIN ModelData d ON m.id = d.model_id " +
                                     "WHERE m.id = @Id;";

                connection.Open();
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string name = reader.GetString(0);
                            string description = reader.GetString(1);
                            DateTime date = reader.GetDateTime(2);
                            string extension = reader.GetString(3);
                            byte[] data = (byte[])reader.GetValue(4);

                            model = new Models(
                                name,
                                description,
                                date,
                                ByteConverter.ConvertBytesToReadableSize(data.Length),
                                extension,
                                data);
                        }
                    }
                }
            }

            return model;
        }


        public void DeleteModelByName(string name)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string deleteMetadataQuery = "DELETE FROM ModelMetadata WHERE name = @Name;";
                string deleteDataQuery = "DELETE FROM ModelData WHERE model_id IN (SELECT id FROM ModelMetadata WHERE name = @Name);";

                connection.Open();
                using (MySqlCommand command = new MySqlCommand(deleteDataQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.ExecuteNonQuery();
                }

                using (MySqlCommand command = new MySqlCommand(deleteMetadataQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateModel(Models model)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string updateMetadataQuery = "UPDATE ModelMetadata SET name = @Name, description = @Description, " +
                    "created_at = @Date, extension = @Extension, size = @Size WHERE id = @Id;";
                string updateDataQuery = "UPDATE ModelData SET data = @Data WHERE model_id = @ModelId;";

                connection.Open();
                using (MySqlCommand command = new MySqlCommand(updateMetadataQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", model.Name);
                    command.Parameters.AddWithValue("@Description", model.Description);
                    command.Parameters.AddWithValue("@Date", model.Date);
                    command.Parameters.AddWithValue("@Size", model.Size);  // Asegúrate de que el nombre del parámetro sea coherente
                    command.Parameters.AddWithValue("@Extension", model.Ext);
                    command.Parameters.AddWithValue("@Id", model.id);
                    command.ExecuteNonQuery();
                }

                using (MySqlCommand command = new MySqlCommand(updateDataQuery, connection))
                {
                    command.Parameters.AddWithValue("@Data", model.DataBytes);
                    command.Parameters.AddWithValue("@ModelId", model.id);
                    command.ExecuteNonQuery();
                }
            }
        }


    }

}