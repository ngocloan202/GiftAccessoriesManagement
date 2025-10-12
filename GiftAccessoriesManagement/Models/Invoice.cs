using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GiftAccessoriesManagement.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }

        [Required, MaxLength(30)]
        public string? InvoiceCode { get; set; } // INV2025300123

        [Column(TypeName = "date")]
        public DateTime InvoiceDate { get; set; }

        public int InvoiceType { get; set; } // 0: Sale, 1: Return
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual Employee? Employee { get; set; }

        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; } = new List<InvoiceDetail>();
    }
}
