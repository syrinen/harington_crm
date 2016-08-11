using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain
{
    public class Experience
    {
        [Key]
        public int ExperienceID { set; get; }
        public String Company { set; get; }

        [Column(TypeName = "DateTime2")]
        public DateTime BeginDate { set; get; }

        [Column(TypeName = "DateTime2")]
        public DateTime EndDate { set; get; }
        public String JobTitle { set; get; }
        public String JobDescription { set; get; }
    }
}
