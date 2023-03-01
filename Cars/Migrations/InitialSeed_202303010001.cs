using Cars.Models;
using FluentMigrator;

namespace DapperMigrations.Migrations
{
	[Migration(202303010001)]
	public class InitialSeed_202303010001 : Migration
	{
		public override void Down()
		{
			Delete.FromTable("brands")
				.Row(new
				{
					id = 0,
					active = true,
					title = "BMW"
				})
				.Row(new
				{
					id = 1,
					active = true,
					title = "KIA"
				})
				.Row(new
				{
					id = 2,
					active = true,
					title = "LADA"
				})
				.Row(new
				{
					id = 3,
					active = true,
					title = "JAC"
				})
				.Row(new
				{
					id = 4,
					active = true,
					title = "Fiat"
				})
				.Row(new
				{
					id = 5,
					active = true,
					title = "Mazda"
				})
				.Row(new
				{
					id = 6,
					active = true,
					title = "Porshe"
				})
				.Row(new
				{
					id = 7,
					active = true,
					title = "Dodge"
				})
				.Row(new
				{
					id = 8,
					active = true,
					title = "Ford"
				});

			Delete.FromTable("models")
				.Row(new
				{
					id = 0,
					brand_id = 0,
					active = true,
					title = "X5"
				})
				.Row(new
				{
					id = 1,
					brand_id = 0,
					active = true,
					title = "M3"
				})
				.Row(new
				{
					id = 2,
					brand_id = 0,
					active = true,
					title = "iX"
				})
				.Row(new
				{
					id = 3,
					brand_id = 1,
					active = true,
					title = "Rio"
				})
				.Row(new
				{
					id = 4,
					brand_id = 1,
					active = true,
					title = "Stinger"
				})
				.Row(new
				{
					id = 5,
					brand_id = 1,
					active = true,
					title = "K5"
				})
				.Row(new
				{
					id = 6,
					brand_id = 2,
					active = true,
					title = "Kalina"
				})
				.Row(new
				{
					id = 7,
					brand_id = 2,
					active = true,
					title = "Granta"
				})
				.Row(new
				{
					id = 8,
					brand_id = 2,
					active = true,
					title = "Vesta"
				})
				.Row(new
				{
					id = 9,
					brand_id = 3,
					active = true,
					title = "S3"
				})
				.Row(new
				{
					id = 10,
					brand_id = 3,
					active = true,
					title = "T6"
				})
				.Row(new
				{
					id = 11,
					brand_id = 3,
					active = true,
					title = "JS6"
				})
				.Row(new
				{
					id = 12,
					brand_id = 4,
					active = true,
					title = "Egea"
				})
				.Row(new
				{
					id = 13,
					brand_id = 4,
					active = true,
					title = "Punto"
				})
				.Row(new
				{
					id = 14,
					brand_id = 4,
					active = true,
					title = "Bravo"
				})
				.Row(new
				{
					id = 15,
					brand_id = 5,
					active = true,
					title = "MX5"
				})
				.Row(new
				{
					id = 16,
					brand_id = 5,
					active = true,
					title = "CX7"
				})
				.Row(new
				{
					id = 17,
					brand_id = 5,
					active = true,
					title = "RX8"
				})
				.Row(new
				{
					id = 18,
					brand_id = 6,
					active = true,
					title = "911"
				})
				.Row(new
				{
					id = 19,
					brand_id = 6,
					active = true,
					title = "Cayman"
				})
				.Row(new
				{
					id = 20,
					brand_id = 6,
					active = true,
					title = "Boxter"
				})
				.Row(new
				{
					id = 21,
					brand_id = 7,
					active = true,
					title = "Charger"
				})
				.Row(new
				{
					id = 22,
					brand_id = 7,
					active = true,
					title = "Challenger"
				})
				.Row(new
				{
					id = 23,
					brand_id = 7,
					active = true,
					title = "Viper"
				})
				.Row(new
				{
					id = 24,
					brand_id = 8,
					active = true,
					title = "Mustang"
				})
				.Row(new
				{
					id = 25,
					brand_id = 8,
					active = true,
					title = "GT"
				})
				.Row(new
				{
					id = 26,
					brand_id = 8,
					active = true,
					title = "Focus"
				});
		}

		public override void Up()
		{
			Insert.IntoTable("brands")
				.Row(new
				{
					id = 0,
					active = true,
					title = "BMW"
				})
				.Row(new
				{
					id = 1,
					active = true,
					title = "KIA"
				})
				.Row(new
				{
					id = 2,
					active = true,
					title = "LADA"
				})
				.Row(new
				{
					id = 3,
					active = true,
					title = "JAC"
				})
				.Row(new
				{
					id = 4,
					active = true,
					title = "Fiat"
				})
				.Row(new
				{
					id = 5,
					active = true,
					title = "Mazda"
				})
				.Row(new
				{
					id = 6,
					active = true,
					title = "Porshe"
				})
				.Row(new
				{
					id = 7,
					active = true,
					title = "Dodge"
				})
				.Row(new
				{
					id = 8,
					active = true,
					title = "Ford"
				});

			Insert.IntoTable("models")
				.Row(new
				{
					id = 0,
					brand_id = 0,
					active = true,
					title = "X5"
				})
				.Row(new
				{
					id = 1,
					brand_id = 0,
					active = true,
					title = "M3"
				})
				.Row(new
				{
					id = 2,
					brand_id = 0,
					active = true,
					title = "iX"
				})
				.Row(new
				{
					id = 3,
					brand_id = 1,
					active = true,
					title = "Rio"
				})
				.Row(new
				{
					id = 4,
					brand_id = 1,
					active = true,
					title = "Stinger"
				})
				.Row(new
				{
					id = 5,
					brand_id = 1,
					active = true,
					title = "K5"
				})
				.Row(new
				{
					id = 6,
					brand_id = 2,
					active = true,
					title = "Kalina"
				})
				.Row(new
				{
					id = 7,
					brand_id = 2,
					active = true,
					title = "Granta"
				})
				.Row(new
				{
					id = 8,
					brand_id = 2,
					active = true,
					title = "Vesta"
				})
				.Row(new
				{
					id = 9,
					brand_id = 3,
					active = true,
					title = "S3"
				})
				.Row(new
				{
					id = 10,
					brand_id = 3,
					active = true,
					title = "T6"
				})
				.Row(new
				{
					id = 11,
					brand_id = 3,
					active = true,
					title = "JS6"
				})
				.Row(new
				{
					id = 12,
					brand_id = 4,
					active = true,
					title = "Egea"
				})
				.Row(new
				{
					id = 13,
					brand_id = 4,
					active = true,
					title = "Punto"
				})
				.Row(new
				{
					id = 14,
					brand_id = 4,
					active = true,
					title = "Bravo"
				})
				.Row(new
				{
					id = 15,
					brand_id = 5,
					active = true,
					title = "MX5"
				})
				.Row(new
				{
					id = 16,
					brand_id = 5,
					active = true,
					title = "CX7"
				})
				.Row(new
				{
					id = 17,
					brand_id = 5,
					active = true,
					title = "RX8"
				})
				.Row(new
				{
					id = 18,
					brand_id = 6,
					active = true,
					title = "911"
				})
				.Row(new
				{
					id = 19,
					brand_id = 6,
					active = true,
					title = "Cayman"
				})
				.Row(new
				{
					id = 20,
					brand_id = 6,
					active = true,
					title = "Boxter"
				})
				.Row(new
				{
					id = 21,
					brand_id = 7,
					active = true,
					title = "Charger"
				})
				.Row(new
				{
					id = 22,
					brand_id = 7,
					active = true,
					title = "Challenger"
				})
				.Row(new
				{
					id = 23,
					brand_id = 7,
					active = true,
					title = "Viper"
				})
				.Row(new
				{
					id = 24,
					brand_id = 8,
					active = true,
					title = "Mustang"
				})
				.Row(new
				{
					id = 25,
					brand_id = 8,
					active = true,
					title = "GT"
				})
				.Row(new
				{
					id = 26,
					brand_id = 8,
					active = true,
					title = "Focus"
				});
		}
	}
}
