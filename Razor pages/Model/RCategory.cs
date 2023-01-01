using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Razor_pages.Model
{
    public class RCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;


        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display order should be in the range of 1 to 100!!")]
        public int DisplayOrder { get; set; }
    }
}
