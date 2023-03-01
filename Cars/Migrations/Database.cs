using Cars.DataAccess;
using Dapper;

namespace Cars.Migrations
{
	public class Database
	{
		private readonly DapperContext _context;
		private readonly ILogger<Database> _logger;

		public Database(DapperContext context, ILogger<Database> logger)
		{
			_context = context;
			_logger = logger;
		}

		public void CreateDatabase(string dbName)
		{
			var query = "SELECT datname FROM pg_database WHERE datname = @name";
			var parameters = new DynamicParameters();
			parameters.Add("name", dbName);

			using var connection = _context.CreateMasterConnection();
			var records = connection.Query(query, parameters);
			
			if (!records.Any())
				connection.Execute($"create database {dbName}");
		}
	}
}
