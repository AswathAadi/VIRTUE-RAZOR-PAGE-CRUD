using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_pages.Data;
using Razor_pages.Model;
using System.ComponentModel.DataAnnotations;

namespace Razor_pages.Pages.Category
{
    public class CreateModel : PageModel
    {
        private readonly RApplicationDbContext context;

        public CreateModel(RApplicationDbContext context)
        {
            this.context = context;
        }

        public RCategory Category { get; set; } 

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(RCategory category)
        {
            if (category == null)
            {
                throw new ValidationException();
            }

            await context.AddAsync(category);
            context.SaveChangesAsync();

            return RedirectToPage("RCategory");
        }
    }
}
