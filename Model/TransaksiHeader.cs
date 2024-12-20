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
    
    public partial class TransaksiHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransaksiHeader()
        {
            this.TransaksiDetails = new HashSet<TransaksiDetail>();
        }
    
        public int id { get; set; }
        public int akunID { get; set; }
        public System.DateTime tanggalTransaksi { get; set; }
        public int jadwalPenerbanganID { get; set; }
        public int jumlahPenumpang { get; set; }
        public double totalHarga { get; set; }
        public Nullable<int> kodePromoID { get; set; }
    
        public virtual JadwalPenerbangan JadwalPenerbangan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransaksiDetail> TransaksiDetails { get; set; }
    }
}
