//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HairSalonWeb.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class MaterialType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MaterialType()
        {
            this.IncomeMaterialBody = new HashSet<IncomeMaterialBody>();
        }
    
        public int MaterialTypeId { get; set; }
        public string Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncomeMaterialBody> IncomeMaterialBody { get; set; }
    }
}
