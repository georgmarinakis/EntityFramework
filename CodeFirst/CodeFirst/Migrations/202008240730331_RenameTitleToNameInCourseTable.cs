namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTitleToNameInCourseTable : DbMigration
    {
        public override void Up()
        {
            // First Solution
            // RenameColumn("dbo.Courses", "Title", "Name");

            // Second Solution
            AddColumn("dbo.Courses", "Name", c => c.String(nullable: false));
            Sql("UPDATE Courses SET Name = Title");
            DropColumn("dbo.Courses", "Title");
        }
        
        public override void Down()
        {
            // Second Solution
            AddColumn("dbo.Courses", "Title", c => c.String(nullable: false));
            Sql("UPDATE Courses SET Title = Name");
            DropColumn("dbo.Courses", "Name");
        }
    }
}
