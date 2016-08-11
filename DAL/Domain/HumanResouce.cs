using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain
{
    [Table("HumanResources")]
    public class HumanResouce: GenericUser
    {
        public HumanResouce(string email) : base(email) { IsManager = false; }

        // A flag to tell if this person is a manager
        public bool IsManager { set; get; }
    }
}
