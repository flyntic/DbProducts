using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.Data;
using WebApplication3.Model;
using static System.Reflection.Metadata.BlobBuilder;

namespace WebApplication3.Pages
{
    public class EditProductModel : PageModel
    {   public Product Product { get; set; }
        private readonly AppDbContext _context;
        public EditProductModel(AppDbContext context)
        {
            _context = context;
            
        }
        public void OnGet(int id)
        {
           Product = _context.Products.ToList()[id];
        }
    }
}
