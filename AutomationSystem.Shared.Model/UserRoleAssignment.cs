//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutomationSystem.Shared.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserRoleAssignment
    {
        public long UserRoleAssignmentId { get; set; }
        public int UserId { get; set; }
        public AutomationSystem.Base.Contract.Enums.UserRoleTypeEnum UserRoleTypeId { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<System.DateTime> Changed { get; set; }
        public bool Deleted { get; set; }
    
        public virtual User User { get; set; }
        public virtual UserRoleType UserRoleType { get; set; }
    }
}
