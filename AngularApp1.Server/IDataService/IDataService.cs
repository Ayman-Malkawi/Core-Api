using AngularApp1.Server.DTO;
using AngularApp1.Server.Models;

namespace AngularApp1.Server.Interfaces
{
    public interface IDataService
    {
        List<Product> GetAllProducts();
        Product getproductbyid(int id);
        bool AddProduct(ProductRequestDTO product);

        public bool deleteproduct(int id);
        public bool editproduct(int id, ProductRequestDTO newproduct);
    }
}
