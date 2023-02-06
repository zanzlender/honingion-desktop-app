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
    
    public partial class Korisnici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Korisnici()
        {
            this.Godisnji_odmori = new HashSet<Godisnji_odmori>();
            this.Godisnji_odmori1 = new HashSet<Godisnji_odmori>();
            this.Slobodni_dani = new HashSet<Slobodni_dani>();
            this.Zapisnici_skladista = new HashSet<Zapisnici_skladista>();
        }
    
        public int id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string oib { get; set; }
        public string email { get; set; }
        public string kontaktBroj { get; set; }
        public string adresa { get; set; }
        public int prebivaliste { get; set; }
        public int uloga { get; set; }
        public int korisnickiRacun { get; set; }
        public int odjel { get; set; }
        public Nullable<int> poduzece { get; set; }
    
        public virtual Gradovi Gradovi { get; set; }
        public virtual Korisnicki_racuni Korisnicki_racuni { get; set; }
        public virtual Odjeli Odjeli { get; set; }
        public virtual Poduzeca Poduzeca { get; set; }
        public virtual Vrste_korisnika Vrste_korisnika { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Godisnji_odmori> Godisnji_odmori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Godisnji_odmori> Godisnji_odmori1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Slobodni_dani> Slobodni_dani { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zapisnici_skladista> Zapisnici_skladista { get; set; }
    }
}