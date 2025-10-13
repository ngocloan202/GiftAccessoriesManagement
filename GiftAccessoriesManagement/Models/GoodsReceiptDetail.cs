using System.ComponentModel.DataAnnotations.Schema;

namespace GiftAccessoriesManagement.Models
{
    public class GoodsReceiptDetail
    {
        public int GoodsReceiptDetailId { get; set; }
        public int ProductID { get; set; }
        public int ReceiptID { get; set; }
        public int QuantityReceived { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ImportPrice { get; set; }
    }
}
