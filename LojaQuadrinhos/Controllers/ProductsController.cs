using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaQuadrinhos.Contexts;
using LojaQuadrinhos.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LojaQuadrinhos.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly ShopContext _context;
        public ProductsController(ShopContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Get(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        [AllowAnonymous] //por enquanto, dps só adm
        [HttpPut]
        public async Task<ActionResult> Create(Product product)
        {
            if (product == null) return BadRequest("Objeto nulo!");

            _context.Add(product);
            await _context.SaveChangesAsync();

            return Ok();
        }

    }
}
