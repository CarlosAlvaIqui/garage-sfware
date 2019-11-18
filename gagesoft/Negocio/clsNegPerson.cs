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
        public void insertSOMETHING(string a, string b, string c, string d, string e, int f, int g, string h, float i)
        {
            daoperson.insertSOMETHING(a, b,c,d,e,f,g,h,i);
        }

    }
}
