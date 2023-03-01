using Cars.Models;

namespace Cars.DataAccess.IRepos;

public interface ICarBrandRepo
{
    CarBrand? Get(int id, bool fetch = false);
    IList<CarBrand> Get(bool fetch = false);
    void Add(CarBrand entity);
    void Update(CarBrand entity);
    void Delete(int id);
}