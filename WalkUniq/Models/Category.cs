using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WalkUniq.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required] // not null
        [DisplayName("Category Name")]
        public required string Name { get; set; }
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
