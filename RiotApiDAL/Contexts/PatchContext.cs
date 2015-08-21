using System.Data.Entity;
using RiotApi.Net.RestClient.Dto.LolStaticData.Champion;
using System.Configuration;
using RiotApiDAL.Static;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System;
using RiotApiDAL.Static.Champion;
using System.Collections.Generic;
using RiotApiDAL.Contexts;

namespace RiotApiDAL.Contexts
{
    public class PatchContext : DbContext
    {
        public DbSet<Patch> PatchList { get; set; }

        public PatchContext() : base(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString)
        {
            this.Configuration.LazyLoadingEnabled = true;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
        public static bool PatchExists(string version)
        {
            if (GetPatch(version) != null) return true;
            else return false;
        }
        public static Patch GetPatch(string version)
        {
            var context = new PatchContext();
            var retVal = context.PatchList.Where(p => p.version == version).FirstOrDefault();
            if (retVal == null)
            {
                return null;
            }
            else return retVal;
        }
        
    }
}