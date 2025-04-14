using AngularApp1.Server.DTO;
using AngularApp1.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngularApp1.Server.DataServices
{
    public class DataServices : Interfaces.IDataService
    {

        private readonly MyDbContext _context;

        public DataServices(MyDbContext context)
        {
            _context = context;



        }




        public List<Product> GetAllProducts()
        {

            var get = _context.Products.ToList();

            return get;






        }

        public Product getproductbyid(int id)
        {

            var gets = _context.Products.Find(id);
            return gets;


        }


        public bool AddProduct(ProductRequestDTO product)
        {


            var newProduct = new Product
            {
                Name = product.Name,
                Describtion = product.Describtion
            };

            _context.Products.Add(newProduct);
            _context.SaveChanges();
            return true;

        }



        public bool deleteproduct(int id)
        {
            var remove = _context.Products.Find(id);

            if (remove == null)
            {

                return false;

            }
            _context.Products.Remove(remove);
            _context.SaveChanges();

            return true;


        }


        public bool editproduct(int id, ProductRequestDTO newproduct)
        {

            var edit = _context.Products.Find(id);

            if (edit == null)
            {
                return false;
            }

            edit.Name = newproduct.Name;
            edit.Describtion = newproduct.Describtion;
            _context.SaveChanges();
            return true;
        }


    }
}


