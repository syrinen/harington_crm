using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.App_Start;

namespace WebApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {        

        public ActionResult Index()
        {
            if(User.IsInRole(Roles.GetRoleName(Roles.Role.Admin)))
            {
                return AdminIndex();
            }
            else if (User.IsInRole(Roles.GetRoleName(Roles.Role.Profile)))
            {
                var profile = WebApp.BLL.ProfileHelper.FindByEmail(User.Identity.Name);            
                if(!WebApp.BLL.ProfileHelper.IsProfileCompleted(profile))
                {                    
                    return RedirectToAction("Edit", "Profile", new {id=profile.Id});                    
                }

                return ProfileIndex(profile);
            }
            else if (User.IsInRole(Roles.GetRoleName(Roles.Role.Manager)))
            {
                return ManagerIndex();
            }

            return View();
        }

        private ActionResult AdminIndex()
        {
            return View("_AdminIndex");
        }

        private ActionResult ProfileIndex(DAL.Domain.Profile profile)
        {
            return View("_ProfileIndex", profile);
        }        

        private ActionResult ManagerIndex()
        {
            return View("_ManagerIndex");
        }        
    }    
}