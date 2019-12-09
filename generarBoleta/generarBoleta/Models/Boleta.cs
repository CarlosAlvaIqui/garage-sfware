using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace generarBoleta.Models
{
    public class Boleta
    {
        public int boleta_id { get; set; }
        public int parkingLot_id { get; set; }
        public int usuarios_id { get; set; }
        public int carros_id { get; set; }
        public String inicioHora { get; set; }
        public String finalHora { get; set; }
        public float monto { get; set; }
        public float total { get; set; }
    }
}