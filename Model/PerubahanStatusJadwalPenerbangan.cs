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
    
    public partial class PerubahanStatusJadwalPenerbangan
    {
        public int id { get; set; }
        public int jadwalPenerbanganID { get; set; }
        public int statusPenerbanganID { get; set; }
        public System.DateTime waktuPerubahanTerjadi { get; set; }
        public Nullable<int> perkiraanDurasiDelay { get; set; }
    
        public virtual JadwalPenerbangan JadwalPenerbangan { get; set; }
        public virtual StatusPenerbangan StatusPenerbangan { get; set; }
    }
}
