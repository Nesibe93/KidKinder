namespace KidKinder.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AboutLists",
                c => new
                {
                    AboutListId = c.Int(nullable: false, identity: true),
                    Description = c.String(),
                })
                .PrimaryKey(t => t.AboutListId);

            CreateTable(
                "dbo.Abouts",
                c => new
                {
                    AboutId = c.Int(nullable: false, identity: true),
                    BigImageUrl = c.String(),
                    Header = c.String(),
                    Title = c.String(),
                    Description = c.String(),
                    SmallImageUrl = c.String(),
                })
                .PrimaryKey(t => t.AboutId);

            CreateTable(
                "dbo.Addresses",
                c => new
                {
                    AddressId = c.Int(nullable: false, identity: true),
                    Description = c.String(),
                    AddressDetail = c.String(),
                    Email = c.String(),
                    Phone = c.String(),
                    OpeningHours = c.String(),
                })
                .PrimaryKey(t => t.AddressId);

            CreateTable(
                "dbo.BookASeats",
                c => new
                {
                    BookASeatId = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Email = c.String(),
                    ClassCategory = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.BookASeatId);

            CreateTable(
                "dbo.ClassRooms",
                c => new
                {
                    ClassRoomId = c.Int(nullable: false, identity: true),
                    Title = c.String(),
                    Description = c.String(),
                    AgeofKids = c.String(),
                    TotalSeats = c.Byte(nullable: false),
                    ClassTime = c.String(),
                    Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    ImageUrl = c.String(),
                })
                .PrimaryKey(t => t.ClassRoomId);

            CreateTable(
                "dbo.Communications",
                c => new
                {
                    CommunicationId = c.Int(nullable: false, identity: true),
                    Description = c.String(),
                    Address = c.String(),
                    Email = c.String(),
                    Phone = c.String(),
                })
                .PrimaryKey(t => t.CommunicationId);

            CreateTable(
                "dbo.Contacts",
                c => new
                {
                    ContactID = c.Int(nullable: false, identity: true),
                    NameSurname = c.String(),
                    Email = c.String(),
                    Subject = c.String(),
                    Message = c.String(),
                    SendDate = c.DateTime(nullable: false),
                    IsRead = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.ContactID);

            CreateTable(
                "dbo.Features",
                c => new
                {
                    FeatureId = c.Int(nullable: false, identity: true),
                    Title = c.String(),
                    Header = c.String(),
                    Description = c.String(),
                    ImageUrl = c.String(),
                })
                .PrimaryKey(t => t.FeatureId);

            CreateTable(
                "dbo.MailSubscribes",
                c => new
                {
                    MailSubscribeId = c.Int(nullable: false, identity: true),
                    NameSurname = c.String(),
                    Email = c.String(),
                })
                .PrimaryKey(t => t.MailSubscribeId);

            CreateTable(
                "dbo.Notifications",
                c => new
                {
                    NotificationId = c.Int(nullable: false, identity: true),
                    Title = c.String(),
                    ImageUrl = c.String(),
                    Description = c.String(),
                    NotificationDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.NotificationId);

            CreateTable(
                "dbo.Services",
                c => new
                {
                    ServiceId = c.Int(nullable: false, identity: true),
                    Title = c.String(),
                    Description = c.String(),
                    IconUrl = c.String(),
                })
                .PrimaryKey(t => t.ServiceId);

            CreateTable(
                "dbo.SocialMedias",
                c => new
                {
                    SocialMediaId = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Url = c.String(),
                })
                .PrimaryKey(t => t.SocialMediaId);

            CreateTable(
                "dbo.Teachers",
                c => new
                {
                    TeacherId = c.Int(nullable: false, identity: true),
                    NameSurname = c.String(),
                    Title = c.String(),
                    ImageUrl = c.String(),
                })
                .PrimaryKey(t => t.TeacherId);

            CreateTable(
                "dbo.Testimonials",
                c => new
                {
                    TestimonialId = c.Int(nullable: false, identity: true),
                    ImageUrl = c.String(),
                    NameSurname = c.String(),
                    Title = c.String(),
                    Comment = c.String(),
                })
                .PrimaryKey(t => t.TestimonialId);

        }

        public override void Down()
        {
            DropTable("dbo.Testimonials");
            DropTable("dbo.Teachers");
            DropTable("dbo.SocialMedias");
            DropTable("dbo.Services");
            DropTable("dbo.Notifications");
            DropTable("dbo.MailSubscribes");
            DropTable("dbo.Features");
            DropTable("dbo.Contacts");
            DropTable("dbo.Communications");
            DropTable("dbo.ClassRooms");
            DropTable("dbo.BookASeats");
            DropTable("dbo.Addresses");
            DropTable("dbo.Abouts");
            DropTable("dbo.AboutLists");
        }
    }
}
