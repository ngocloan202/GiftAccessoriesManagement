using System.ComponentModel.DataAnnotations;

namespace GiftAccessoriesManagement.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required, MaxLength(255)]
        public string? CategoryName { get; set; }
    }
}
