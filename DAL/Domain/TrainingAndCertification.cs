using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain
{
    public class TrainingAndCertification
    {
        [Key]
        public int Id { set; get; }
        public string Name { set; get; }

        [Column(TypeName = "DateTime2")]
        public DateTime Year { set; get; }

        public string Description { set; get; }
    }
}
