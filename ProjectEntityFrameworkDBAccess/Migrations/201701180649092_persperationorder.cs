namespace ProjectEntityFrameworkDBAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class persperationorder : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PersperationOrder",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderNo = c.String(),
                        PatientId = c.String(),
                        PatientName = c.String(),
                        HisDoctorId = c.String(),
                        HisDoctorName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PersperationOrder");
        }
    }
}
