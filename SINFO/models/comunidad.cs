//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class comunidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public comunidad()
        {
            this.seguimiento = new HashSet<seguimiento>();
            this.inseminacionporcina = new HashSet<inseminacionporcina>();
            this.inseminacionBovina = new HashSet<inseminacionBovina>();
        }
    
        public int idcomunidad { get; set; }
        public string nombrecomunidad { get; set; }
        public Nullable<int> idmunicipio2 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<seguimiento> seguimiento { get; set; }
        public virtual municipios municipios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inseminacionporcina> inseminacionporcina { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inseminacionBovina> inseminacionBovina { get; set; }
    }
}
