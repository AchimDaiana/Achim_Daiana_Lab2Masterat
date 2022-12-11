namespace Achim_Daiana_Lab2Masterat.Models
{
    public class City
    {
        public int ID { get; set; }
        public string CityName { get; set; }
        public ICollection<Customer>? Customers { get; set; }
    }
}
