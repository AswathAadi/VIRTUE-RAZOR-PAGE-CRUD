using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_pages.Data;
using Razor_pages.Model;
using System.ComponentModel.DataAnnotations;

namespace Razor_pages.Pages.Category
{
    public class EditModel : PageModel
    {
        private readonly RApplicationDbContext context;

        public EditModel(RApplicationDbContext context)
        {
            this.context = context;
        }

        public RCategory Category { get; set; } 

        public void OnGet(int id)
        {
            Category = context.RCategory.Find(id);
        }

        public async Task<IActionResult> OnPost(RCategory category)
        {

            if (ModelState.IsValid)
            {
                context.RCategory.Update(category);
                await context.SaveChangesAsync();

                return RedirectToPage("RCategory");
            }

            return Page();
        }
    }
}
