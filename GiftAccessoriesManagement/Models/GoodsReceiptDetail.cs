using System.ComponentModel.DataAnnotations;

namespace GiftAccessoriesManagement.Models
{
    public class GoodsReceiptDetail
    {
        public int GoodsReceiptDetailId { get; set; }
        [Required, MaxLength(30)]
        public int GoodsReceiptId { get; set; }
        public int ProductId { get; set; }
        public int QuantityReceived { get; set; }
        public decimal ImportPrice { get; set; }
        //public virtual GoodsReceipt? GoodsReceipt { get; set; }
        public virtual Product? Product { get; set; }
    }
}
