using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace generarBoleta.Models
{
    public class ParkingLot
    {
        public int parkingLot_id { get; set; }
        public int usuarios_id { get; set; }
        public String nombre_local { get; set; }
        public String ubicacion { get; set; }
        public float cobroHora { get; set; }
        public float lugares { get; set; }
        public float saldo { get; set; }
        public float coches_actuales { get; set; }
    }
}