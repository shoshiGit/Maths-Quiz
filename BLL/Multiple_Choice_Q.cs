//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BLL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Multiple_Choice_Q
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Multiple_Choice_Q()
        {
            this.Multiple_Choice_A = new HashSet<Multiple_Choice_A>();
        }
    
        public int Question_Id { get; set; }
        public string Question { get; set; }
        public Nullable<int> Correct_Ans { get; set; }
        public Nullable<int> Percent { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Multiple_Choice_A> Multiple_Choice_A { get; set; }
    }
}
