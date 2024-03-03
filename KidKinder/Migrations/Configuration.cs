namespace KidKinder.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<KidKinder.Context.KidKinderContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        //migrations ve db yi komple silip yeniden mig eklemek lazım 

        protected override void Seed(KidKinder.Context.KidKinderContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
