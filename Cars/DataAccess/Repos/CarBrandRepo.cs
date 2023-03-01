using Cars.DataAccess.IRepos;
using Cars.Models;
using Dapper;

namespace Cars.DataAccess.Repos;

public class CarBrandRepo : ICarBrandRepo
{
    private readonly DapperContext _context;
    private readonly ILogger<CarBrandRepo> _logger;

    public CarBrandRepo(DapperContext context, ILogger<CarBrandRepo> logger)
    {
        _context = context;
        _logger = logger;
    }

    public CarBrand? Get(int id, bool fetch = false)
    {
        var sql = "select * from brands where id = @Id";
        using var db = _context.CreateConnection();
        var brand = db.QueryFirst<CarBrand>(sql, new { Id = id });

        if (fetch && brand != null)
        {
            sql = "select * from models where brand_id = @Id";
            var models = db.Query<CarModel>(sql, new { Id = id }).ToList();
            models.ForEach(x => x.Brand = brand);
            brand.Models = models;
        }

        return brand;
    }

    public IList<CarBrand> Get(bool fetch = false)
    {
        if (!fetch)
        {
            var sql = "select * from brands";
            using var db = _context.CreateConnection();
            return db.Query<CarBrand>(sql).ToList();
        }
        else
        {
            var sql = "select * from brands b left join models m on b.Id = m.brand_id";
            using var db = _context.CreateConnection();
            var brandDict = new Dictionary<int, CarBrand>();
            return db.Query<CarBrand, CarModel, CarBrand>(sql, (brand, model) =>
            {
                if (!brandDict.TryGetValue(brand.Id, out var currentBrand))
                {
                    currentBrand = brand;
                    brandDict.Add(currentBrand.Id, currentBrand);
                }

                if (model != null)
                {
                    model.Brand = currentBrand;
                    currentBrand.Models.Add(model);
                }

                return currentBrand;
            }).ToList();
        }
    }

    public void Add(CarBrand entity)
    {
        var sql = "insert into brands (title, active) values (@Title, @Active)";
        using var db = _context.CreateConnection();
        var rows = db.Execute(sql, entity);
        _logger.LogInformation("{Rows} row(s) inserted into brands", rows);
    }

    public void Update(CarBrand entity)
    {
        var sql = "update brands set title = @Title, active = @Active where id = @Id";
        using var db = _context.CreateConnection();
        var rows = db.Execute(sql, entity);
        _logger.LogInformation("{Rows} row(s) updated in brands", rows);
    }

    public void Delete(int id)
    {
        var sql = "delete from brands where id = @Id";
        using var db = _context.CreateConnection();
        var rows = db.Execute(sql, new { Id = id });
        _logger.LogInformation("{Rows} row(s) deleted from brands", rows);
    }
}