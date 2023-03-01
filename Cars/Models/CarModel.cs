namespace Cars.Models;

public class CarModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool Active { get; set; }

    public int BrandId { get; set; }
    public CarBrand Brand { get; set; }
}