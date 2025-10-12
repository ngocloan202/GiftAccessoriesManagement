using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GiftAccessoriesManagement.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required, MaxLength(30)]
        public string? ProductCode { get; set; }

        [Required, MaxLength(255)]
        public string? ProductName { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public string? Description { get; set; }
        public int? StockQuantity { get; set; }
        public string? Image { get; set; }

        public int CategoryId { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; } = new List<InvoiceDetail>();
        public virtual ICollection<GoodsReceiptDetail> GoodsReceiptDetails { get; set; } = new List<GoodsReceiptDetail>();
        public virtual ICollection<EventProduct> EventProducts { get; set; } = new List<EventProduct>();
    }
}
