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
        public DataTable findcars(String pa)
        {
            DataTable td = new DataTable();

            con.Open();
                
            String Fristplaca = pa;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "findcars";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = con;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@placa";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = Fristplaca;

            cmd.Parameters.Add(param);

            SqlDataReader reader = cmd.ExecuteReader();

            td.Load(reader);



            con.Close();
            return td;
        }

        public DataTable GetAllcars()
        {
            DataTable dt = new DataTable();

            con.Open();

            String sql = "Select * from tabla_carros";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();

            dt.Load(reader);

            con.Close();

            return dt;
        }

        public void insertcars(string pl, string ti, string des)
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.CommandText = "registarcarros";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;


            SqlParameter param = new SqlParameter();
            param.ParameterName = "@placa";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = pl;

            cmd.Parameters.Add(param);

            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "@tipo";
            param2.SqlDbType = SqlDbType.NVarChar;
            param2.Value = ti;

            cmd.Parameters.Add(param2);

            SqlParameter param3 = new SqlParameter();
            param3.ParameterName = "@descripcion";
            param3.SqlDbType = SqlDbType.NVarChar;
            param3.Value = des;

            cmd.Parameters.Add(param3);


            SqlDataReader reader = cmd.ExecuteReader();

            con.Close();
        }

        public void insertSOMETHING(string a, string b, string c, string d, string e,int f,int g,string h, float i)
        {
            //    DataTable td = new DataTable();
            SqlCommand cmd = new SqlCommand();
            //1@usuario,2@contraseña,3@ubicacion,4@nombre_estaciona,5@nombre,6@dni,7@celular,8@tipo,9@cobro_hora
            con.Open();
            cmd.CommandText = "createuserempo";
            cmd.CommandType = CommandType.StoredProcedure;//configuramos el procedimiento que usaremos
            cmd.Connection = con;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@usuario";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = a;

            cmd.Parameters.Add(param);



            SqlDataReader reader = cmd.ExecuteReader();
            con.Close();
        }


        }
}
