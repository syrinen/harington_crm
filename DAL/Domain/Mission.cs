using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain
{
    public class Mission
    {
        public Mission()
        {
            CreationDate = DateTime.Now;
            State = MissionState.Vacant;
        }


        [Key]
        public int MissionID { set; get; }        
        public String Title { set; get; }
        public String Description { set; get; }

        public String Company { set; get; }
        public String Location { set; get; }        
        
        public EmploymentType Timing { set; get; }

        public String Experience { set; get; }
        [DataType(DataType.Date)]
        public DateTime CreationDate { set; get; }

        [DataType(DataType.Date)]
        public DateTime StartingDate { set; get; }

        public int Duration { set; get; }

        public MissionState State { set; get; }

        public virtual ICollection<Skill> RequiredSkills { set; get; }        
    }    
}
