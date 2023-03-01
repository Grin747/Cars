using Cars.DataAccess.IRepos;
using Cars.Models;
using Dapper;

namespace Cars.DataAccess.Repos;

public class CarModelRepo : ICarModelRepo
{
    private readonly DapperContext _context;
    private readonly ILogger<CarModelRepo> _logger;

    public CarModelRepo(DapperContext context, ILogger<CarModelRepo> logger)
    {
        _context = context;
        _logger = logger;
    }

    public IList<CarModel> Get(int? brandId = null)
    {
        if (brandId != null)
        {
            var sql = "select * from models where brand_id = @Id";
            using var db = _context.CreateConnection();
            return db.Query<CarModel>(sql, new { Id = brandId }).ToList();
        }
        else
        {
            var sql = "select * from models";
            using var db = _context.CreateConnection();
            return db.Query<CarModel>(sql).ToList();
        }
    }

    public void Add(CarModel entity)
    {
        var sql = "insert into models (title, active, brand_id) values (@Title, @Active, @BrandId)";
        using var db = _context.CreateConnection();
        var rows = db.Execute(sql, entity);
        _logger.LogInformation("{Rows} row(s) inserted into models", rows);
    }

    public void Update(CarModel entity)
    {
        var sql = "update models set title = @Title, active = @Active, brand_id = @BrandId where id = @Id";
        using var db = _context.CreateConnection();
        var rows = db.Execute(sql, entity);
        _logger.LogInformation("{Rows} row(s) updated in models", rows);
    }

    public void Delete(int id)
    {
        var sql = "delete from models where id = @Id";
        using var db = _context.CreateConnection();
        var rows = db.Execute(sql, new { Id = id });
        _logger.LogInformation("{Rows} row(s) deleted from models", rows);
    }
}