using FluentMigrator;

namespace DapperMigrations.Migrations
{
	[Migration(202302280001)]
	public class InitialTables_202302280001 : Migration
	{
		public override void Down()
		{
			Delete.Table("brands");
			Delete.Table("models");
		}

		public override void Up()
		{
			Create.Table("brands")
				.WithColumn("id").AsInt32().NotNullable().PrimaryKey().Identity()
				.WithColumn("title").AsString(50).NotNullable()
				.WithColumn("active").AsBoolean().NotNullable();
			
			Create.Table("models")
				.WithColumn("id").AsInt32().NotNullable().PrimaryKey().Identity()
				.WithColumn("title").AsString(50).NotNullable()
				.WithColumn("active").AsBoolean().NotNullable()
				.WithColumn("brand_id").AsInt32().NotNullable().ForeignKey("brands", "id");
		}
	}
}
