//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CentroDeCorreos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblUsuarioSynergia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUsuarioSynergia()
        {
            this.tblCorreosElectronicosPruebas = new HashSet<tblCorreosElectronicosPruebas>();
            this.tblUsuarioSynergiaRelCatFranquicia = new HashSet<tblUsuarioSynergiaRelCatFranquicia>();
        }
    
        public long id { get; set; }
        public long idFranquicia { get; set; }
        public string pop3server { get; set; }
        public string pop3user { get; set; }
        public string pop3pwd { get; set; }
        public bool Administrador { get; set; }
        public bool Modifica { get; set; }
        public bool Restringido { get; set; }
        public string C800 { get; set; }
        public bool Estatus { get; set; }
        public string idTemporal { get; set; }
        public string nombre { get; set; }
        public Nullable<long> idUsuarioIntranet { get; set; }
        public Nullable<long> idMobileInfo { get; set; }
        public long idPuesto { get; set; }
        public int Orden { get; set; }
        public string Iniciales { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCorreosElectronicosPruebas> tblCorreosElectronicosPruebas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUsuarioSynergiaRelCatFranquicia> tblUsuarioSynergiaRelCatFranquicia { get; set; }
    }
}
