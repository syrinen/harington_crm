using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.App_Start
{
    public abstract class Roles
    {
        public enum Role
        {
            Admin,
            Manager,
            HR,
            BI,
            Profile
        }

        public static Array GetRoles()
        {
            return Enum.GetValues(typeof(Role));
        }

        public static string GetRoleName(Role role)
        {
            return Enum.GetName(typeof(Role), role);
        }

        public static Role Parse(string roleName)
        {
            return (Role)Enum.Parse(typeof(Role), roleName, false);
        }     
    }    
}