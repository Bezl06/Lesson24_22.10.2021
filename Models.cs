using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;
using Dapper;

namespace MyApp
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
    }
    public interface IClientRepository
    {
        void Create(Client client);
        void Delete(int id);
        Client Get(int id);
        List<Client> GetClients();
        void Update(Client client);
    }
    public class ClientRepository : IClientRepository
    {
        private string conString;
        public ClientRepository(string connectionString)
        {
            conString = connectionString;
        }
        public void Create(Client client)
        {
            using var sqlConnection = new SqlConnection(conString);
            sqlConnection.Execute("insert into Clients values(@Name,@Balance)", client);
        }

        public void Delete(int id)
        {
            using var sqlConnection = new SqlConnection(conString);
            sqlConnection.Execute("delete from Clients where Id=@id", new { id });
        }

        public Client Get(int id)
        {
            using var sqlConnection = new SqlConnection(conString);
            return sqlConnection.Query<Client>("select * from Clients where Id=@id", new { id }).FirstOrDefault();
        }

        public List<Client> GetClients()
        {
            using var sqlConnection = new SqlConnection(conString);
            return sqlConnection.Query<Client>("select * from Clients").ToList();
        }

        public void Update(Client client)
        {
            using var sqlConnection = new SqlConnection(conString);
            sqlConnection.Execute("update Clients set Name=@Name, Balance=@Balance where Id=@Id", client);
        }
    }
}