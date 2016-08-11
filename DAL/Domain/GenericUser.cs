using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain
{
    public abstract class GenericUser
    {
        public GenericUser()
        {           
        }

        public GenericUser(string email)
        {
            Email = email;
            FirstName = "";
            LastName = "";
            PhoneNumber = "";
            Gender = GenderType.Undef;
            Contract = ContractType.Undef;
            Nationality = "";
            Address = "";            
        }

        [Key]
        public int Id { set; get; }

        [Index(IsUnique = true)]
        [StringLength(450)]
        public String Email { set; get; }

        public String FirstName { set; get; }
        public String LastName { set; get; }
        public String PhoneNumber { set; get; }

        [Column(TypeName= "DateTime2")]
        public DateTime Birthday { set; get; }

        public GenderType Gender { set; get; }
        public String Address { set; get; }
        public String Nationality { set; get; }        
        public ContractType Contract { set; get; }
    }
}
