using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SafeGuard.Pages
{
    public class GetLocation : PageModel
    {
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
            
            HttpClient httpClient = new HttpClient();  
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Put, "http://yoursitehere/");  
            requestMessage.Headers.Add("username", Location.UserName);  
            requestMessage.Headers.Add("latitude", Location.Latitude);  
            requestMessage.Headers.Add("longitude", Location.Longitude);
            requestMessage.Headers.Add("user_choice", Location.UserChoice);  
            HttpResponseMessage response = await httpClient.SendAsync(requestMessage);
            return RedirectToPage("./Index");
        }
    }
}