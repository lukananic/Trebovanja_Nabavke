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
    
    public partial class DatumiOdobravanjaTrebovanje
    {
        public Nullable<System.DateTime> DatumOdobravanjaNivoa1 { get; set; }
        public Nullable<System.DateTime> DatumOdobravanjaNivoa3 { get; set; }
        public int TrebovnajeId { get; set; }
        public Nullable<System.DateTime> DatumOdobravanjaNivoa2 { get; set; }
    
        public virtual Trebovanje Trebovanje { get; set; }
    }
}
