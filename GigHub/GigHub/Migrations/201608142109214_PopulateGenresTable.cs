namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into genres (id, name) values (1, 'jazz')");
            Sql("insert into genres (id, name) values (2, 'blues')");
            Sql("insert into genres (id, name) values (3, 'rock')");
            Sql("insert into genres (id, name) values (4, 'country')");
        }
        
        public override void Down()
        {
            Sql("delete from genres where id in (1, 2, 3, 4)");
        }
    }
}
