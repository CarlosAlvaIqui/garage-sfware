//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace generarBoleta
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuarios()
        {
            this.boleta = new HashSet<boleta>();
            this.parkingLot = new HashSet<parkingLot>();
        }
    
        public int usuarios_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Nullable<int> empleado_id { get; set; }
        public Nullable<int> tipoUser_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<boleta> boleta { get; set; }
        public virtual empleados empleados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<parkingLot> parkingLot { get; set; }
        public virtual tipo_user tipo_user { get; set; }
    }
}