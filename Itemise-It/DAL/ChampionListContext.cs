using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using RiotApi.Net.RestClient.Dto.LolStaticData.Champion;
using RiotApi.Net.RestClient.Dto.LolStaticData.Generic;
namespace Itemise_It.DAL
{
    public class ChampionListContext : DbContext
    {
        public DbSet<ChampionListDto> ChampionList { get; set; }
        public DbSet<ChampionDto> Champion { get; set; }
        public DbSet<ChampionSpellDto> ChampionSpell { get; set; }
        public DbSet<PassiveDto> ChampionPassive { get; set; }

        public ChampionListContext() : base("ChampionListContext")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}