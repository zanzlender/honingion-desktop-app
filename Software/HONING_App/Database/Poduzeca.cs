//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HONING_App.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Poduzeca
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Poduzeca()
        {
            this.Korisnici = new HashSet<Korisnici>();
            this.Odjeli = new HashSet<Odjeli>();
            this.Materijali_i_sirovine = new HashSet<Materijali_i_sirovine>();
            this.Poslovni_partneri = new HashSet<Poslovni_partneri>();
            this.Proizvodi = new HashSet<Proizvodi>();
        }
    
        public int id { get; set; }
        public string naziv { get; set; }
        public string oib { get; set; }
        public string voditelj { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Korisnici> Korisnici { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Odjeli> Odjeli { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Materijali_i_sirovine> Materijali_i_sirovine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Poslovni_partneri> Poslovni_partneri { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proizvodi> Proizvodi { get; set; }
    }
}