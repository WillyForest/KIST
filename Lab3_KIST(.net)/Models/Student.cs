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
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.Contracts = new HashSet<Contract>();
            this.Student_Group = new HashSet<Student_Group>();
        }
    
        public int Student_ID { get; set; }
        public Nullable<int> Finance_ID { get; set; }
        public Nullable<int> Status_ID { get; set; }
        public Nullable<int> Diploma_ID { get; set; }
        public Nullable<int> Specializ_ID { get; set; }
        public Nullable<int> Book_no { get; set; }
        public string Note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual SDiploma SDiploma { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Group> Student_Group { get; set; }
    }
}
