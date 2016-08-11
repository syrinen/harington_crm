using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using WebApp.Models;
using WebApp.App_Start;

namespace WebApp.BLL
{
    public class ProfileHelper
    {
        public static bool IsProfileCompleted(DAL.Domain.Profile profile)
        {
            if (profile.FirstName == "" ||
                profile.LastName == "" ||
                profile.Gender == DAL.Domain.GenderType.Undef)
                return false;

            var techSkills = profile.Skills.Where(skill => skill.Category == DAL.Domain.SkillCategory.Technical).ToList();
            if (techSkills.Count == 0 ||
                profile.Educations.Count == 0)
                return false;

            return true;
        }

        public static DAL.Domain.Profile FindByEmail(string email)
        {
            using (var profileDao = new DAL.Dao.ProfileDAO())
            {
                return profileDao.FindBy(x => x.Email == email);
            }
        }

        public static DAL.Domain.Profile FindById(int id)
        {
            using (var profileDao = new DAL.Dao.ProfileDAO())
            {
                return profileDao.FindBy(x => x.Id == id);
            }
        }

        public static void CreateProfile(ApplicationUserManager userMgr, ApplicationUser user)
        {
            userMgr.AddToRole(user.Id, Roles.GetRoleName(Roles.Role.Profile));
            using (var profileDAO = new DAL.Dao.ProfileDAO())
            {
                DAL.Domain.Profile profile = new DAL.Domain.Profile(user.Email);
                profileDAO.Add(profile);
                profileDAO.SaveChanges();
            }
        }
    }
}