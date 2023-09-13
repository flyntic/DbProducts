using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.Model;

namespace WebApplication3.Pages
{
    public class IndexModel : PageModel
    {
       
        public List<Product> Products { get; set; }
        private readonly AppDbContext _context;
        
        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Products = //new List<Product> { new Product { Id = 1, } };
                _context.Products.ToList();
        }

        public IActionResult OnPostEdit(int? id)
        {

            return RedirectToPage("/EditProduct", new { id });
            //Book book = _context.Books.Where(c => c.Id == id).FirstOrDefault();
            //return RedirectToPage("/EditBook", 
            //    new { book.Name, book.Author,book.Price,book.PageCount });
        }

        public async Task<IActionResult> OnGetDeleteAsync(int? id)
        {
            var product = await _context.Products.Where(x => x.Id == id).FirstOrDefaultAsync();
            _context.Products.Remove(product);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}