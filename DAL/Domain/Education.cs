using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain
{
    public class Education
    {
        [Key]
        public int EducationID { set; get; }
        public String Institution { set; get;}
        public String Degree { set; get; }

        [Column(TypeName = "DateTime2")]
        public DateTime Year { set; get; }
    }
}
