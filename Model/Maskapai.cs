//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BromoAirlineDesktop.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Maskapai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Maskapai()
        {
            this.JadwalPenerbangans = new HashSet<JadwalPenerbangan>();
        }
    
        public int id { get; set; }
        public string nama { get; set; }
        public string perusahaan { get; set; }
        public int jumlahKru { get; set; }
        public string deskripsi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JadwalPenerbangan> JadwalPenerbangans { get; set; }
    }
}
