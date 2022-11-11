using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Web;

namespace signup.Models
{
    public class studentviewmodel
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public int  RollNumber { get; set; }

        public int AcademicYear { get; set; }
        public int Semester { get; set; }

        public float SSLCPercentage { get; set; }

      
        public byte[] SSLCMarksheet{ get; set; }
        public float HSLCPercentage { get; set; }
      
        public byte[] HSLCMarksheet { get; set; }
        public float CGPA { get; set; }
       public bool ActiveBacklogs { get; set; }
        public double PhoneNumber { get; set; }
         public string PersonalEmail { get; set; }
        public string Address { get; set; }
      
        public byte[] Resumeupload { get; set; }
     
        public byte[] Photoupload { get; set; }
    }
}