using Cars.DataAccess.IRepos;
using Cars.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cars.Controllers;

public class CarBrandController : Controller
{
    private readonly ICarBrandRepo _brandRepo;

    public CarBrandController(ICarBrandRepo brandRepo)
    {
        _brandRepo = brandRepo;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(_brandRepo.Get());
    }

    [HttpPost]
    public IActionResult Update(CarBrand brand)
    {
        _brandRepo.Update(brand);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public IActionResult Add(CarBrand brand)
    {
        _brandRepo.Add(brand);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        _brandRepo.Delete(id);
        return RedirectToAction(nameof(Index));
    }
}