﻿namespace baitap1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Coulumn_Student_Address : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "Address");
        }
    }
}
