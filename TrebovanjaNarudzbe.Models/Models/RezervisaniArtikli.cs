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
    
    public partial class RezervisaniArtikli
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RezervisaniArtikli()
        {
            this.TrebovanjeVeznas = new HashSet<TrebovanjeVezna>();
        }
    
        public int ArtikalId { get; set; }
        public int TrenutnaKolicina { get; set; }
        public int RezervisanaKolicina { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrebovanjeVezna> TrebovanjeVeznas { get; set; }
    }
}
