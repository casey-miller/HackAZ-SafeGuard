using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SafeGuard.Pages
{
    public class GetLocation : PageModel
    {

        private readonly Data.LocationDbContext _context;

        public GetLocation(Data.LocationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {

        }
        [BindProperty]
        public Models.Location Location { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Location.Add(Location);
            await _context.SaveChangesAsync();
            return RedirectToPage("./GetLocation");
        }
    }
}