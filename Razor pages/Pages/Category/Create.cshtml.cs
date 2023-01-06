using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_pages.Model;

namespace Razor_pages.Pages.Category
{
    public class CreateModel : PageModel
    {
        public RCategory category { get; set; } 

        public void OnGet()
        {
        }
    }
}
