﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace boleta
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_gagesoftv2Entities1 : DbContext
    {
        public db_gagesoftv2Entities1()
            : base("name=db_gagesoftv2Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<boleta> boleta { get; set; }
        public virtual DbSet<carros> carros { get; set; }
        public virtual DbSet<empleados> empleados { get; set; }
        public virtual DbSet<parkingLot> parkingLot { get; set; }
        public virtual DbSet<tipo_user> tipo_user { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }
    }
}