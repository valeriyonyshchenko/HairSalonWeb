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
    
    public partial class IncomeMaterial
    {
        public int IncomeMaterialId { get; set; }
        public int IncomeMaterialHeadId { get; set; }
        public int IncomeMaterialBodyId { get; set; }
    
        public virtual IncomeMaterialBody IncomeMaterialBody { get; set; }
        public virtual IncomeMaterialHead IncomeMaterialHead { get; set; }
    }
}