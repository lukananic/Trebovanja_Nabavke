//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrebovanjaNarudzbe.Models.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NabavkaVezna
    {
        public int NabavkaVeznaId { get; set; }
        public int NabavkaId { get; set; }
        public string Opis { get; set; }
        public int Kolicina { get; set; }
        public Nullable<decimal> Cijena { get; set; }
        public string Dobavljac { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<int> ArtiklId { get; set; }
    
        public virtual Nabavke Nabavke { get; set; }
    }
}
