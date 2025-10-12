using System.ComponentModel.DataAnnotations.Schema;

namespace GiftAccessoriesManagement.Models
{
    public class GoodsReceiptDetail
    {
        public int GoddsReceiptDetailId { get; set; }
        public int BatchId { get; set; }
        public int GoodsReceiptId { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }

        public Batch BatchId { get; set; }
        public GoodsReceipt GoodsReceiptID { get; set; }

    }
}
