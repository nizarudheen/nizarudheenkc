using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Inventory.Classes
{
   public class Db
    {
       public static bool a;
       public SqlConnection cn()
       {


           SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SYS15\Documents\TestDb.mdf;Integrated Security=True;Connect Timeout=30");

           try
           {
               if (!a)
               {
                   con.Open();
               }
               else
               {

               }
           }
           catch
           {

           }


           return con;
       }
    }
}
