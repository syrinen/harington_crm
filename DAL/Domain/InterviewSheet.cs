using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain
{
    public class InterviewSheet
    {
        [Key]
        public int SheetID { set; get; }        
        public InterviewState State { set; get; }
        public String Notes { set; get; }
        
        public virtual GenericUser Interviewer { set; get; }
    }
}
