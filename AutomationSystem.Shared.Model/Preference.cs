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
    
    public partial class Preference
    {
        public long PreferenceId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<System.DateTime> Changed { get; set; }
        public bool Deleted { get; set; }
    }
}
