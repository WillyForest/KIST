//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab3_KIST_.net_.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cafedra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cafedra()
        {
            this.Specialities = new HashSet<Speciality>();
        }
    
        public int Cafedra_ID { get; set; }
        public Nullable<int> Faculty_ID { get; set; }
        public string Cafedra_name { get; set; }
        public string Cafedra_shifr { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Speciality> Specialities { get; set; }
        public virtual Faculty Faculty { get; set; }
    }
}
