//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PerfectlyMadeInc.WebEx.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Event
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Event()
        {
            this.IntegrationStates = new HashSet<IntegrationState>();
        }
    
        public long EventId { get; set; }
        public long AccountId { get; set; }
        public Nullable<long> ProgramId { get; set; }
        public Nullable<AutomationSystem.Base.Contract.Enums.EntityTypeEnum> EntityTypeId { get; set; }
        public Nullable<long> EntityId { get; set; }
        public string Name { get; set; }
        public long SessionId { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<System.DateTime> Changed { get; set; }
        public bool Deleted { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Program Program { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IntegrationState> IntegrationStates { get; set; }
    }
}
