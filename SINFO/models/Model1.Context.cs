﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SINFO.models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class sinfoEntities : DbContext
    {
        public sinfoEntities()
            : base("name=sinfoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<comunidad> comunidad { get; set; }
        public virtual DbSet<estrategia> estrategia { get; set; }
        public virtual DbSet<institucion> institucion { get; set; }
        public virtual DbSet<municipios> municipios { get; set; }
        public virtual DbSet<seguimiento> seguimiento { get; set; }
        public virtual DbSet<tipos_de_actividades> tipos_de_actividades { get; set; }
    
        public virtual ObjectResult<ListarDatosSeguimientos_Result> ListarDatosSeguimientos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListarDatosSeguimientos_Result>("ListarDatosSeguimientos");
        }
    
        public virtual ObjectResult<ListarDatosSeguimientoss_Result> ListarDatosSeguimientoss()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListarDatosSeguimientoss_Result>("ListarDatosSeguimientoss");
        }
    }
}
