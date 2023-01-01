using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_pages.Data;
using Razor_pages.Model;

namespace Razor_pages.Pages.Category
{
    public class RCategoryModel : PageModel
    {
        private readonly RApplicationDbContext context;

        public  List<RCategory> categoryList { get; set; }

        public RCategoryModel(RApplicationDbContext context)
        {
            this.context = context;
        }

        public void OnGet()
        {
            categoryList = context.RCategory.ToList();
        }
    }
}
