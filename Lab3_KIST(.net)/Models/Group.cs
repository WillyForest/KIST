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
    
    public partial class Group
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Group()
        {
            this.Teach_Plan = new HashSet<Teach_Plan>();
        }
    
        public int Group_ID { get; set; }
        public Nullable<int> Speciality_ID { get; set; }
        public string Group_code { get; set; }
        public Nullable<System.DateTime> Group_creat_date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Teach_Plan> Teach_Plan { get; set; }
        public virtual Speciality Speciality { get; set; }
    }
}