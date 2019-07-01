using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            string dp = "System.Data.SqlClient";
            string cnStr = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Sales;Integrated Security=True";
            
            DbProviderFactory df = DbProviderFactories.GetFactory(dp);
            
            using (DbConnection cn = df.CreateConnection())
            {
                Console.WriteLine("DbConnection");
                cn.ConnectionString = cnStr;
                cn.Open();
                
                DbCommand cmd = df.CreateCommand();
                Console.WriteLine("DbCommand");
                cmd.Connection = cn;
                cmd.CommandText = "Create table gruppa(Id int, Name nvarchar(50))";
                
                using (DbDataReader dr = cmd.ExecuteReader())
                {
                    Console.WriteLine("DbDataReader");
                }
                Console.ReadLine();
            }
        }
    }
}