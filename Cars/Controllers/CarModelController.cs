using Cars.DataAccess.IRepos;
using Cars.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cars.Controllers;

public class CarModelController : Controller
{
    private readonly ICarModelRepo _modelRepo;
    private readonly ICarBrandRepo _brandRepo;

    public CarModelController(ICarModelRepo modelRepo, ICarBrandRepo brandRepo)
    {
        _modelRepo = modelRepo;
        _brandRepo = brandRepo;
    }

    [HttpGet]
    public IActionResult Index(int? brandId = null)
    {
        if (brandId == null)
        {
            return View(_brandRepo.Get(true));
        }

        var brands = _brandRepo.Get();
        var brand = brands.FirstOrDefault(x => x.Id == brandId);

        if (brand == null)
        {
            return View(brands);
        }
        
        var models = _modelRepo.Get(brandId);
        brand.Models = models;
        foreach (var model in models)
        {
            model.Brand = brand;
        }

        return View(brands);
    }

    [HttpPost]
    public IActionResult Update(CarModel model)
    {
        _modelRepo.Update(model);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public IActionResult Add(CarModel model)
    {
        _modelRepo.Add(model);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        _modelRepo.Delete(id);
        return RedirectToAction(nameof(Index));
    }
}