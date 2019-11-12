using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
    public class clsDaoPerson:clsDao
    {/*
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();

            con.Open();

            String sql = "Select * from Person";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();

            dt.Load(reader);

            con.Close();

            return dt;
        }*/

        public void insertSOMETHING(string a, int b)
        {
            //    DataTable td = new DataTable();
            SqlCommand cmd = new SqlCommand();

            con.Open();
            cmd.CommandText = "insertCabecera2";
            cmd.CommandType = CommandType.StoredProcedure;//configuramos el procedimiento que usaremos
            cmd.Connection = con;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@fecha";
            param.SqlDbType = SqlDbType.DateTime;
            param.Value = a;

            cmd.Parameters.Add(param);

            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "@proveedor_id";
            param2.SqlDbType = SqlDbType.Int;
            param2.Value = b;

            cmd.Parameters.Add(param2);

            SqlDataReader reader = cmd.ExecuteReader();
            con.Close();
        }


        }
}
