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
    
    public partial class Orvosok
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orvosok()
        {
            this.Idoponts = new HashSet<Idopont>();
            this.Orvosjelenlets = new HashSet<Orvosjelenlet>();
        }
    
        public int OrvosSK { get; set; }
        public string OrvosNev { get; set; }
        public Nullable<int> OrvosfajtaFK { get; set; }
        public string Jelszo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Idopont> Idoponts { get; set; }
        public virtual Orvosfajtak Orvosfajtak { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orvosjelenlet> Orvosjelenlets { get; set; }
    }
}
