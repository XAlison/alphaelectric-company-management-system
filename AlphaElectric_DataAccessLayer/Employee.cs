//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlphaElectric_DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }
        public string Passport { get; set; }
        public System.DateTime JoinDate { get; set; }
        public string Address { get; set; }
        public int DesignationID { get; set; }
    
        public virtual Designation Designation { get; set; }
    }
}
