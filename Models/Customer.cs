namespace Achim_Daiana_Lab2Masterat.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string? Name { get; set; }
        public string? Adress { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
