using System.ComponentModel.DataAnnotations;

namespace GiftAccessoriesManagement.Models
{
    public class GoodsReceipt
    {
        [Key]
        public int ReceiptId { get; set; }
        [Required, MaxLength(30)]
        public int ReceiptCode { get; set; }
        public DateTime ReceiptDate { get; set; }
        [Required, MaxLength(255)]
        public string? SupplierName { get; set; }
        public string? Note { get; set; }
        public int EmployeeId { get; set; }

        //public virtual Employee? Employee { get; set; }
        //public virtual ICollection<GoodsReceiptDetail> GoodsReceiptDetails { get; set; } = new List<GoodsReceiptDetail>();
    }
}
