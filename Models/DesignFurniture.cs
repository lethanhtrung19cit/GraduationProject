//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GraduationProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DesignFurniture
    {
        public DesignFurniture()
        {
            this.SubImgDesigns = new HashSet<SubImgDesign>();
        }
    
        public int IdDe { get; set; }
        public string NameDe { get; set; }
        public string NameProject { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public string ImageDe { get; set; }
        public string Content { get; set; }
    
        public virtual ICollection<SubImgDesign> SubImgDesigns { get; set; }
    }
}