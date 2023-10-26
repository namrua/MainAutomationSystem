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
    
    public partial class EmailParameter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmailParameter()
        {
            this.EmailTemplateParameters = new HashSet<EmailTemplateParameter>();
        }
    
        public long EmailParameterId { get; set; }
        public string Name { get; set; }
        public AutomationSystem.Base.Contract.Enums.EmailParameterTypeEnum EmailParameterTypeId { get; set; }
        public string Description { get; set; }
        public string TestValue { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<System.DateTime> Changed { get; set; }
        public bool Deleted { get; set; }
    
        public virtual EmailParameterType EmailParameterType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmailTemplateParameter> EmailTemplateParameters { get; set; }
    }
}