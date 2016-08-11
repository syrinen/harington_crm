using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain
{
    [Table("Profile")]
    public class Profile : GenericUser
    {
        public Profile() : base() { }

        public  Profile(string email) : base(email)
        {
            Type = ProfileType.Undef;           
        }

        public ProfileType Type { set; get; }

        public virtual ICollection<Experience> Experiences { set; get; }
        public virtual ICollection<Education> Educations { set; get; }
        public virtual ICollection<Skill> Skills { set; get; }
        public virtual ICollection<TrainingAndCertification> TrainingsAndCerts { set; get; }

        // If current profile is assgined to a mission this property should return a non null value
        public virtual Mission Mission { set; get; }
        
    }
}
