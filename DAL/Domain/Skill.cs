using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain
{
    public enum SkillCategory
    {
        Technical,
        Tool,
        Language,
        Training,
        Certification,
        Other
    }

    public class Skill
    {
        [Key]
        public int Id { set; get; }
        public String Name { set; get; }
        public SkillCategory Category { set; get; }
        public ExpertiseLevel Expertise { set; get; }
        public String Description { set; get; }        
    }    
}
