using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.Data;
using WebApplication3.Model;

namespace WebApplication3.Pages
{
    public class CreateProductModel : PageModel
    {
        public Product Product { get; set; }
        private readonly AppDbContext _context;
        public CreateProductModel(AppDbContext context)
        { 
            _context = context;
        }
        public void OnGet()
        {
            Product= new Product();
        }
    }
}
