
namespace Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1; 
            product.Name = "Test";
            product.Description = "Test";
          
            ProductToJson(product);
           JsonToProduct(product);

        }
        public static void ProductToJson(Product product)
        {
            string path = "C:\\Users\\Admin\\Desktop\\data.dat";
            using Stream stream = new FileStream(path, FileMode.Create);

            ToJsonFormatter toJsonFormatter = new ToJsonFormatter();
            ToJsonFormatter.Serialize(stream, product);

          
        }
        public static string JsonToProduct( Product product)
        {

            string path = "C:\\Users\\Admin\\Desktop\\data.dat";
            Stream stream = new FileStream(path, FileMode.Open);
            JsonToProduct jsonToProduct = new JsonToProduct();
            Product product = (Product)jsonToProduct.Deserialize(stream);


            return product;

        }



         
    }
}
