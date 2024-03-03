namespace KidKinder.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                {
                    BranchId = c.Int(nullable: false, identity: true),
                    BranchName = c.String(),
                })
                .PrimaryKey(t => t.BranchId);

        }

        public override void Down()
        {
            DropTable("dbo.Branches");
        }
    }
}
