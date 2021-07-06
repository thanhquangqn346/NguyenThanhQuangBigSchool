namespace NguyenThanhQuangBigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmptyMigration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Courses", newName: "Coures");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Coures", newName: "Courses");
        }
    }
}
