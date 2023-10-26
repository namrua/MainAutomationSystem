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
    
    public partial class ContactList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContactList()
        {
            this.ContactListItems = new HashSet<ContactListItem>();
        }
    
        public long ContactListId { get; set; }
        public long ProfileId { get; set; }
        public int OwnerId { get; set; }
        public bool IsNotified { get; set; }
        public Nullable<System.DateTime> Notified { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<System.DateTime> Changed { get; set; }
        public bool Deleted { get; set; }
        public Nullable<long> SenderId { get; set; }
    
        public virtual Profile Profile { get; set; }
        public virtual Person Sender { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactListItem> ContactListItems { get; set; }
    }
}
