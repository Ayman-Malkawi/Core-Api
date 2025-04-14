using AngularApp1.Server.DTO;
using AngularApp1.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AngularApp1.Server.Interfaces.IDataService _serv;

        public ProductController(AngularApp1.Server.Interfaces.IDataService serv)
        {


            _serv = serv;


        }



        [HttpGet("GetAllProducts")]
        public IActionResult GetAllProducts()
        {

            var get = _serv.GetAllProducts();


            return Ok(get);



        }


        [HttpGet("GetProductById/{id}")]

        public IActionResult GetProductById(int id)
        {
            var got = _serv.getproductbyid(id);
            return Ok(got);


        }

        [HttpPost("AddProduct")]

        public IActionResult AddProduct(ProductRequestDTO product)
        {
            if (product == null)
            {
                return BadRequest();

            }

            var add = _serv.AddProduct(product);


            if (add)
            {

                return Ok();

            }
            else
            {
                return BadRequest();
            }




        }


        [HttpDelete("DeleteProduct/{id}")]


        public IActionResult DeleteProduct(int id) { 
        var del = _serv.deleteproduct(id);
        
         if (del)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }



        }


        [HttpPut("UpdateProduct/{id}")]


        public IActionResult UpdateProduct(int id, ProductRequestDTO product)
        {
            var editt = _serv.editproduct(id, product);


            if (editt)
            {

                return Ok();
            }else
            {


                return NotFound();
            }

        }
    }
}
