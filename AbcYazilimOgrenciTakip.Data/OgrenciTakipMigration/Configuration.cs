using System.Data.Entity.Migrations;

// generic tipleri bi araştır

namespace AbcYazilimOgrenciTakip.Data.Contexts.OgrenciTakipMigration
{
    public class Configuration : DbMigrationsConfiguration<OgrenciTakipContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; // migration işlerini otomatik yap
            AutomaticMigrationDataLossAllowed = true; // migration sırasında veri kaybı olursa devam et
        }
    }
}
