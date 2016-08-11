using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApp.Models;

namespace WebApp.App_Start
{
    public class IdentityInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));
            var roleManager = new RoleManager<ApplicationRole>(new RoleStore<ApplicationRole>(context));

            // Create Application roles            
            foreach(Roles.Role role in Roles.GetRoles())
            {                
                var roleName = Roles.GetRoleName(role);
                if (!roleManager.RoleExists(roleName))
                {
                    roleManager.Create(new ApplicationRole(roleName));
                }
            }            

            // Create default admin user
            var adminUser = new ApplicationUser { UserName = "admin@mail.com", Email = "admin@mail.com" };           
            var result = userManager.Create(adminUser, "AdminPass_1");
            if(result.Succeeded)
            {
                userManager.AddToRole(adminUser.Id, Roles.GetRoleName(Roles.Role.Admin));
            }

            base.Seed(context);
        }
    }
}