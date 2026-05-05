using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Lab1ApiCLI.Models;
using Lab1ApiCLI.Data;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    //private readonly AppDbContext _context;

    //public ProductController(AppDbContext context)
    //{
      //  _context = context;
    //}

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
    {
            return  Ok(new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 10.99m },
                new Product { Id = 2, Name = "Product 2", Price = 19.99m },
                new Product { Id = 3, Name = "Product 3", Price = 5.49m }
            });
        //return await _context.Products.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Product>> CreateProduct(Product product)
    {
        // _context.Products.Add(product);
        // await _context.SaveChangesAsync();

        return Ok(product);
    }
}