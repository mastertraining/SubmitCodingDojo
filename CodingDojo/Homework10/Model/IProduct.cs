namespace Homework10.Model
{
    public interface IProduct
    {
        string SKU { get; set; }
        string Name { get; set; }
        double Price { get; set; }
    }
}
