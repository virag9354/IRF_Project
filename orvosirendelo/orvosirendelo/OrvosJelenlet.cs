//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace orvosirendelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orvosjelenlet
    {
        public int OrvosjelenletSK { get; set; }
        public Nullable<int> OrvosFK { get; set; }
        public Nullable<System.DateTime> Datum { get; set; }
        public Nullable<int> IdoFK { get; set; }
    
        public virtual Ido Ido { get; set; }
        public virtual Orvosok Orvosok { get; set; }
    }
}
