using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
    public class clsDao
    {
        public SqlConnection con;
        public clsDao()
        {
            string str = "Server=DESKTOP-FPS8BOT\\SQLEXPRESS2017;DataBase=db_garagesoft;Integrated Security=true;";
            con = new SqlConnection(str);
        }
    }
}
