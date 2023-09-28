using ClinicService.Models;
using Microsoft.Data.Sqlite;

namespace ClinicService.Services.Impl
{
    public class PetRepository : IPetRepository
    {

        private const string connectionString = "Data Source = clinic.db;";

        public int Create(Pet item)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO pets(ClientId, Name, Birthday) VALUES(@CleintId, @Name, @Birthday)";
                command.Parameters.AddWithValue("@CleintId", item.ClientId);
                command.Parameters.AddWithValue("@Name", item.Name);
                command.Parameters.AddWithValue("@Birthday", item.Birthday.Ticks);
                command.Prepare();
            }
        }

        public int Update(Pet item)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = "UPDATE pets SET PetId = @PetId, ClientId = @ClientId, Name = @Name, Birthday = @Birthday";
                command.Parameters.AddWithValue("@PetId", item.PetId);
                command.Parameters.AddWithValue("@ClientId", item.ClientId);
                command.Parameters.AddWithValue("@Name", item.Name);
                command.Parameters.AddWithValue("@Birthday", item.Birthday.Ticks);
                command.Prepare();
                return command.ExecuteNonQuery();
            }
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pet> GetAll()
        {
            throw new NotImplementedException();
        }

        public Pet GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
