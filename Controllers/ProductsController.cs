using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Re_Store.Data;
using Re_Store.Entities;

namespace Re_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext db;
        public ProductsController(StoreContext db)
        {
            this.db = db;
        }
        
        [HttpGet]
        public ActionResult<List<Product>> GetProducts()
        {
            var products = db.Products.ToList();
            return products;
        }
        
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }
        
    }
}
