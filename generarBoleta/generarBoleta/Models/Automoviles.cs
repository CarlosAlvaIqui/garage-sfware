using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace generarBoleta.Models
{
    public class Automoviles
    {
     
        public int carros_id { get; set; }
        public String placa { get; set; }
        public String descripcion { get; set; }
        public String propietario { get; set; }
        public Tipo_automoviles tipo_carro { get; set; }
        
    }
}