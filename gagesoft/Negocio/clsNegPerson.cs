using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Negocio
{
   

    public class clsNegPerson
    {
        clsDaoPerson daoperson = new clsDaoPerson();
        /*
        public DataTable GetAll()
        {

            return daoperson.GetAll();
        }*/
        public void insertSOMETHING(string a, string b, string c, string d, string e, string f, string g, int i)
        {
            daoperson.insertSOMETHING(a, b,c,d,e,f,g,i);
        }
        public void insertcars(string pl, string des, string pro, int tp) {
            daoperson.insertcars(pl,des, pro,tp);
            }
        public void insertParkings(int usid, string nl, string ubi, float tari, int luga, float sao, int ca)
        {
            daoperson.insertParkings(usid, nl, ubi, tari, luga, sao,ca);

        }

        public int IniciarSesion(string AliasUsuario, string Contraseña)
        {
            return daoperson.IniciarSesion(AliasUsuario,Contraseña);
             
        }
        public DataTable GetAllcars()
        {
            return daoperson.GetAllcars();
        }

        public DataTable findcars(String pa)
        {
            return daoperson.findcars(pa);
        }
        

    }
}
