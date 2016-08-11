using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALContext : DbContext
    {
        public DALContext() : base("name=ERP_DB")
        {

        }

        // nothing is done with this yet
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<DAL.Domain.Mission> Missions { get; set; }
        public DbSet<DAL.Domain.Profile> Profiles { get; set; }
        public DbSet<DAL.Domain.BusinessEngineer> BusinessEngineers { get; set; }
        public DbSet<DAL.Domain.HumanResouce> HumanResources { get; set; }        

        public DbSet<DAL.Domain.MissionApplication> MissionsApplications { get; set; }

        
    }
}
