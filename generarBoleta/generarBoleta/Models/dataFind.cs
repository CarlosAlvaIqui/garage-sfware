using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace generarBoleta.Models
{
    public class dataFind
    {
        public int? boleta_id { get; set; }
        public String propietario { get; set; }
        public String descripcion { get; set; }
        public int? parkingLot_id { get; set; }
        public String placa { get; set; }
        public DateTime? inicioHora { get; set; }
        public DateTime? finalHora { get; set; }
        public double? total { get; set; }
        public int? tipo_carro_id { get; set; }
    }
}