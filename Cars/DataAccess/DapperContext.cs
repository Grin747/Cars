using System.Data;
using Microsoft.Data.SqlClient;
using Npgsql;

namespace Cars.DataAccess
{
	public class DapperContext
	{
		private readonly IConfiguration _configuration;

		public DapperContext(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public IDbConnection CreateConnection()
			=> new NpgsqlConnection(_configuration.GetConnectionString("PgConnection"));

		public IDbConnection CreateMasterConnection()
			=> new NpgsqlConnection(_configuration.GetConnectionString("MasterConnection"));
	}
}
