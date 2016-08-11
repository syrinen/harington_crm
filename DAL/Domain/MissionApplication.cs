using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain
{
    [Table("ProfileOfferLink")]
    public class MissionApplication
    {
        [Key]
        public int ApplicationID { set; get; }
        public virtual Profile Profile { set; get; }
        public virtual Mission Mission { set; get; }             
        public virtual HumanResouce Recruiter { set; get; }
        public virtual ICollection<InterviewSheet> Sheets { set; get; }
    }
}
