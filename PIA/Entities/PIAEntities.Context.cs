﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PIA.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PIAEntities : DbContext
    {
        public PIAEntities()
            : base("name=PIAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Caracteristicas> Caracteristicas { get; set; }
        public virtual DbSet<CaracteristicasPropiedad> CaracteristicasPropiedad { get; set; }
        public virtual DbSet<Estados> Estados { get; set; }
        public virtual DbSet<ImagenesPropiedad> ImagenesPropiedad { get; set; }
        public virtual DbSet<Municipios> Municipios { get; set; }
        public virtual DbSet<Operaciones> Operaciones { get; set; }
        public virtual DbSet<Publicaciones> Publicaciones { get; set; }
        public virtual DbSet<TiposInmueble> TiposInmueble { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Propiedades> Propiedades { get; set; }
        public virtual DbSet<Ubicaciones> Ubicaciones { get; set; }
    }
}
