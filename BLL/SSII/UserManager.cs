using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.SSII
{
    public class UserManager
    {
        public static void CreateCandidate(string email)
        {
            using (var profileDAO = new DAL.Dao.ProfileDAO()) 
            {
                DAL.Domain.Profile profile = new DAL.Domain.Profile { Email = email };
                profileDAO.Add(profile);
                profileDAO.SaveChanges();
            }            
        }
    }
}
