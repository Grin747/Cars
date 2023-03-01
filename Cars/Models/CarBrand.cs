namespace Cars.Models;

public class CarBrand
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool Active { get; set; }

    public ICollection<CarModel> Models { get; set; } = new List<CarModel>();
}