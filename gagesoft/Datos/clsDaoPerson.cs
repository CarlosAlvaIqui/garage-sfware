﻿using System;
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
            cmd.CommandText = "findautos";
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

            String sql = "Select * from automoviles";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();

            dt.Load(reader);

            con.Close();

            return dt;
        }

        public void GetNameEstacionamiento()
        {

            con.Open();

            String sql = "Select parkinLot_id,nombre_local from parkinLotd";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();


            con.Close();

        }

        public void getnani_id(int idus)
        {

            con.Open();
            String sql = "Select * from usuarios WHERE usuarios_id =" + idus;
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader reader = cmd.ExecuteReader();
            con.Close();
        }
        public class NombreEntiedad
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
        }
        public string getus(int idus)
        {

            con.Open();

            String sql = "Select username from usuarios where usuarios_id = "+ idus + ";";
            SqlCommand cmd = new SqlCommand(sql, con);

            var result = (cmd.ExecuteScalar());
            string x = Convert.ToString(result);


            con.Close();

            return x;
        }
        
        public string tipousuario(int idus)
        {

            con.Open();

            String sql = "SELECT tipo_name FROM tipo_user INNER JOIN usuarios ON tipo_user.tipoUser_id = usuarios.tipoUser_id where usuarios.usuarios_id ="+ idus + ";";
            SqlCommand cmd = new SqlCommand(sql, con);

            var result = (cmd.ExecuteScalar());
            string x = Convert.ToString(result);


            con.Close();

            return x;
        }
        /*
        public  NombreEntiedad GetById(int usId)
        {
            NombreEntiedad entity = null;

            
               con.Open();

                string sql = "SELECT username FROM usuarios WHERE usuarios_id =" + usId;

                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    entity  = new NombreEntiedad();
                    entity.Nombre = Convert.ToString(reader["username"]);
                }
            
            con.Close();
            return entity;
        }
        */
        /*
        public List<NombreEntiedad> GetNameus(int iduser)
        {
            List<NombreEntiedad> result = new List<NombreEntiedad>();

         
                con.Open();
            string sql = "SELECT username FROM usuarios WHERE usuarios_id =" + Convert.ToInt32(iduser) ;
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                NombreEntiedad item = new NombreEntiedad();
                
                item.Nombre = Convert.ToString(reader["username"]);

                result.Add(item);
            }
            con.Close();
            return result;

        }*/

        public void insertParkings(int usid,string nl, string ubi, float tari, int luga, float sao, int ca)
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.CommandText = "createParkingt";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;


            SqlParameter param = new SqlParameter();
            param.ParameterName = "@usuarios_id";
            param.SqlDbType = SqlDbType.Int;
            param.Value = usid;

            cmd.Parameters.Add(param);

            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "@nombre_local";
            param2.SqlDbType = SqlDbType.NVarChar;
            param2.Value = nl;

            cmd.Parameters.Add(param2);

            SqlParameter param3 = new SqlParameter();
            param3.ParameterName = "@ubicacion";
            param3.SqlDbType = SqlDbType.NVarChar;
            param3.Value = ubi;

            cmd.Parameters.Add(param3);

            SqlParameter param4 = new SqlParameter();
            param4.ParameterName = "@cobroHora";
            param4.SqlDbType = SqlDbType.Float;
            param4.Value = tari;

            cmd.Parameters.Add(param4);

            SqlParameter param5 = new SqlParameter();
            param5.ParameterName = "@lugares";
            param5.SqlDbType = SqlDbType.Int;
            param5.Value = luga;

            cmd.Parameters.Add(param5);

            SqlParameter param6 = new SqlParameter();
            param6.ParameterName = "@saldo";
            param6.SqlDbType = SqlDbType.Float;
            param6.Value = sao;

            cmd.Parameters.Add(param6);

            SqlParameter param7 = new SqlParameter();
            param7.ParameterName = "@coches_actuales";
            param7.SqlDbType = SqlDbType.Int;
            param7.Value = ca;

            cmd.Parameters.Add(param7);

            SqlDataReader reader = cmd.ExecuteReader();

            con.Close();
        }                       

        public void insertcars(string pl, string des, string pro, int tp)
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.CommandText = "registrarautos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;


            SqlParameter param = new SqlParameter();
            param.ParameterName = "@placa";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = pl;

            cmd.Parameters.Add(param);

            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "@descripcion";
            param2.SqlDbType = SqlDbType.NVarChar;
            param2.Value = des;

            cmd.Parameters.Add(param2);

            SqlParameter param3 = new SqlParameter();
            param3.ParameterName = "@propietario";
            param3.SqlDbType = SqlDbType.NVarChar;
            param3.Value = pro;

            cmd.Parameters.Add(param3);

            SqlParameter param4 = new SqlParameter();
            param4.ParameterName = "@tipo_carro_id";
            param4.SqlDbType = SqlDbType.Int;
            param4.Value = tp;

            cmd.Parameters.Add(param4);

            SqlDataReader reader = cmd.ExecuteReader();

            con.Close();
        }
  
        public int IniciarSesion(string AliasUsuario, string Contraseña)
        {
            SqlCommand cmd = new SqlCommand();

            con.Open();

            cmd.CommandText = "LOGEO";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.Add(new SqlParameter("@username", AliasUsuario));
            cmd.Parameters.Add(new SqlParameter("@password", Contraseña));

            var result = (cmd.ExecuteScalar());
            int x = Convert.ToInt32(result);
            con.Close();

            return x;   


        }
        public void insertSOMETHING(string a, string b, string c, string d, string e,string f,string g, int i)
        {
            //    DataTable td = new DataTable();
            SqlCommand cmd = new SqlCommand();
            //1@usuario,2@contraseña,3@ubicacion,4@nombre_estaciona,5@nombre,6@dni,7@celular,8@tipo,9@cobro_hora
            //usuario, contraseña, nombre, apellido, email, direccion, cargo, tipo
            con.Open();
            cmd.CommandText = "createuserempo";
            cmd.CommandType = CommandType.StoredProcedure;//configuramos el procedimiento que usaremos
            cmd.Connection = con;

     

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@nombre";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = a;

            cmd.Parameters.Add(param);

            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@apellidos";
            param1.SqlDbType = SqlDbType.NVarChar;
            param1.Value = b;

            cmd.Parameters.Add(param1);

            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "@email";
            param2.SqlDbType = SqlDbType.NVarChar;
            param2.Value = c;

            cmd.Parameters.Add(param2);

            SqlParameter param3 = new SqlParameter();
            param3.ParameterName = "@direccion";
            param3.SqlDbType = SqlDbType.NVarChar;
            param3.Value = d;

            cmd.Parameters.Add(param3);

            SqlParameter param4 = new SqlParameter();
            param4.ParameterName = "@cargo";
            param4.SqlDbType = SqlDbType.NVarChar;
            param4.Value = e;

            cmd.Parameters.Add(param4);


            SqlParameter param5 = new SqlParameter();
            param5.ParameterName = "@username";
            param5.SqlDbType = SqlDbType.NVarChar;
            param5.Value = f;

            cmd.Parameters.Add(param5);

            SqlParameter param6 = new SqlParameter();
            param6.ParameterName = "@password";
            param6.SqlDbType = SqlDbType.NVarChar;
            param6.Value = g;

            cmd.Parameters.Add(param6);

  

            SqlParameter param8 = new SqlParameter();
            param8.ParameterName = "@tipoUser_id";
            param8.SqlDbType = SqlDbType.Int;
            param8.Value = i;

            cmd.Parameters.Add(param8);
            
            SqlDataReader reader = cmd.ExecuteReader();

            con.Close();
        }


   
        /*
         * 
         *
         *
         */
    }
}
