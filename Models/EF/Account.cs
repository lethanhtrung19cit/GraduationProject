//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GraduationProject.Models.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        public Account()
        {
            this.Customers = new HashSet<Customer>();
        }
    
        public string Email { get; set; }
        public string PassWord { get; set; }
        public Nullable<byte> Role { get; set; }
    
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
