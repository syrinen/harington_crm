using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{    
    public class Consultant
    {
        public Consultant()
        {
            this.Experiences = new LinkedList<Experience>();
            this.Educations = new LinkedList<Education>();
            this.Skills = new LinkedList<Skill>();
            this.Tools = new LinkedList<Tool>();
        }

        [DisplayName("First Name")]
        public String FirstName { set; get; }

        [DisplayName("Last Name")]
        public String LastName { set; get; }

        [DisplayName("ICN/Passeport")]
        public String Identification { set; get; }

        [DisplayName("Phone")]
        public String PhoneNumber { set; get; }

        [DisplayName("E-mail")]
        public String Email { set; get; }

        [DisplayName("Gender")]
        public Gender Gender { set; get; }

        [DisplayName("Marital Status")]
        public MaritalStatus MaritalStatus { set; get; }
        
        public String Nationality { set; get; }

        [DataType(DataType.Date)]
        public DateTime Birthday { set; get; }

        public String Address { set; get; }

        [DisplayName("Upload Photo")]
        public String PhotoFile { set; get; }

        [DisplayName("Upload CV")]
        public String CvFile { set; get; }

        public LinkedList<Experience> Experiences { set; get; }
        public LinkedList<Education> Educations { set; get; }
        public LinkedList<Skill> Skills { set; get; }
        public LinkedList<Tool> Tools { set; get; }
    }
}