//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace signup.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class studenttbl
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public int Roll_Number { get; set; }
        public int Academic_Year { get; set; }
        public int Semester { get; set; }
        public double SSLC_Percantage { get; set; }
        public byte[] SSLC_Marksheet { get; set; }
        public double HSLC_Percenatge { get; set; }
        public byte[] HSLC_Marksheet { get; set; }
        public double CGPA { get; set; }
        public bool Active_Blacklogs { get; set; }
        public double Phone_Number { get; set; }
        public string personal_Email { get; set; }
        public string Address { get; set; }
        public byte[] Resume_Upload { get; set; }
        public byte[] Photo_Upload { get; set; }
    }
}