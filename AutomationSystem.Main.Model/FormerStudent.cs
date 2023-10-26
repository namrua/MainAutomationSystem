//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutomationSystem.Main.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class FormerStudent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FormerStudent()
        {
            this.ClassRegistrations = new HashSet<ClassRegistration>();
            this.ContactListItems = new HashSet<ContactListItem>();
        }
    
        public long FormerStudentId { get; set; }
        public long AddressId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public long FormerClassId { get; set; }
        public Nullable<bool> IsTemporary { get; set; }
        public int OwnerId { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<System.DateTime> Changed { get; set; }
        public bool Deleted { get; set; }
    
        public virtual Address Address { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassRegistration> ClassRegistrations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactListItem> ContactListItems { get; set; }
        public virtual FormerClass FormerClass { get; set; }
    }
}
