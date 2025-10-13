using System.ComponentModel.DataAnnotations;

namespace GiftAccessoriesManagement.Models
{
    public class GoodsReceiptDetail
    {
        [Key]
        public int GoodsReceiptDetailId { get; set; }
        public int GoodsReceiptId { get; set; }
        public int ProductId { get; set; }
        public int QuantityReceived { get; set; }
        public decimal ImportPrice { get; set; }
        //public virtual GoodsReceipt? GoodsReceipt { get; set; }
        public virtual Product? Product { get; set; }
    }
}
