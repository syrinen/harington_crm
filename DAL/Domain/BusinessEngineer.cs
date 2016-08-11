using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain
{
    [Table("BusinessEngineer")]
    public class BusinessEngineer : GenericUser
    {
        public BusinessEngineer(string email) : base(email) { IsManager = false; }

        // A flag to tell if this person is a manager
        public bool IsManager { set; get; }
    }
}
