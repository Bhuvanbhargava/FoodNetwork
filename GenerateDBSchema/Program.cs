using FoodNetwork.Data.DBContext;
using FoodNetwork.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateDBSchema
{
    internal class Program
    {
         static void Main(string[] args)
        {
            var connection = new WindowsAuthenticationConnectionStringBuilder();
            using (var db = new FoodNetworkDatabaseContext(connection.FoodNetworkConnectionString))
            {
                
                var blog = new TestEntity 
                { 
                    CreatedBy = "ME",
                    CreatedDate = DateTime.Now,
                    ModifiedBy = "You",
                    ModifiedDate = DateTime.Now,
                    Name = "Bhuavn" 
                };
                db.TestEntitys.Add(blog);
                db.SaveChanges();
             
                //var blog = new Blog { Name = name };
                //db.Blogs.Add(blog);
                //db.SaveChanges();

                // Display all Blogs from the database 
                //var query = from b in db.Blogs
                //            orderby b.Name
                //            select b;

                //Console.WriteLine("All blogs in the database:");
                //foreach (var item in query)
                //{
                //    Console.WriteLine(item.Name);
                //}

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            } 
        }               
        
    }  
        
   
}