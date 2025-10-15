using System.ComponentModel.DataAnnotations;

namespace GiftAccessoriesManagement.Models
{
    public class GoodsReceipt
    {
        [Key]
        public int GoodsReceiptId { get; set; }
        [Required, MaxLength(30)]
        public string ReceiptCode { get; set; } = string.Empty;
        public DateTime ReceiptDate { get; set; }
        public string? Note { get; set; }
        public int EmployeeId { get; set; }

        //public virtual Employee? Employee { get; set; }
    }
}
