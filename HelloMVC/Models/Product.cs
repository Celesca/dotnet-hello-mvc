namespace HelloMVC.Models
{
    public class Product
    {
        public Product()
        {

        }
        public Product(int productID, string name, float price)
        {
            ProductID = productID;
            ProductName = name;
            ProductPrice = price;
        }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }
    }
}
