using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string conString = "Server=.;Database=SomeDataBase;Trusted_Connection=true";
            var clientsDb = new ClientRepository(conString);
            clientsDb.Create(new Client { Name = "Murod", Balance = 350 });
            var clients = clientsDb.GetClients();
            foreach (var item in clients)
                System.Console.WriteLine($"ID : {item.Id} | Name : {item.Name} | Balance : {item.Balance}");
            System.Console.WriteLine();
            var client = clientsDb.Get(clients.First().Id);
            client.Name = "Orzu";
            client.Balance = 50;
            clientsDb.Update(client);
            foreach (var item in clientsDb.GetClients())
                System.Console.WriteLine($"ID : {item.Id} | Name : {item.Name} | Balance : {item.Balance}");
            System.Console.WriteLine();
            clientsDb.Delete(client.Id);
            foreach (var item in clientsDb.GetClients())
                System.Console.WriteLine($"ID : {item.Id} | Name : {item.Name} | Balance : {item.Balance}");
        }
    }
}