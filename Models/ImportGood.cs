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
    
    public partial class ImportGood
    {
        public ImportGood()
        {
            this.DetailImportGoods = new HashSet<DetailImportGood>();
        }
    
        public string IdIm { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
        public string IdSu { get; set; }
    
        public virtual ICollection<DetailImportGood> DetailImportGoods { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
