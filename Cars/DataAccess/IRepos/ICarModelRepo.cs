using Cars.Models;

namespace Cars.DataAccess.IRepos;

public interface ICarModelRepo
{
    IList<CarModel> Get(int? brandId = null);
    void Add(CarModel entity);
    void Update(CarModel entity);
    void Delete(int id);
}