using FoodNetwork.Data.DBContext;
using FoodNetwork.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace GenerateDBSchema
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //working
            var wdc = new WindowsAuthenticationConnectionStringBuilder();
            string connectionString = ConfigurationManager.ConnectionStrings["FoodNetworkConnection"].ConnectionString;
            using (var db = new FoodNetworkDatabaseContext(connectionString))
            {
                Database.SetInitializer(new DropCreateDatabaseAlways<FoodNetworkDatabaseContext>());
                db.TestEntitys.Add(new TestEntity()
                {
                    //CreatedBy = "me",
                    //CreatedDate = DateTime.Now,
                    //ModifiedBy = "you",
                    //ModifiedDate = DateTime.Now,
                    Name = "bhuvan",
                    LastName = "Bhargav"
                });
                db.SaveChanges();

                foreach (var blog in db.TestEntitys)
                {
                    Console.WriteLine(blog.Name);
                }
            }

            //test


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}