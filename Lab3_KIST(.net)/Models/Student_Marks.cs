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
    
    public partial class Student_Marks
    {
        public int Student_ID { get; set; }
        public Nullable<int> Teach_plan_ID { get; set; }
        public Nullable<int> Mark_ID { get; set; }
    
        public virtual SMark SMark { get; set; }
        public virtual Teach_Plan Teach_Plan { get; set; }
    }
}