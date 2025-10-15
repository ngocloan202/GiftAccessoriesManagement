using System.ComponentModel.DataAnnotations;

namespace GiftAccessoriesManagement.Models
{
    public enum Sex
    {
        Male,
        Female
    }

    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required, MaxLength(30)]
        public string? EmployeeCode { get; set; }

        [Required, MaxLength(255)]
        public string? EmployeeName { get; set; }

        public Sex? Sex { get; set; }

        [Required, MaxLength(10)]
        public string? PhoneNumber { get; set; }

        [Required, MaxLength(255)]
        public string? Address { get; set; }

        //public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
        //public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
        //public virtual ICollection<GoodsReceipt> GoodsReceipts { get; set; } = new List<GoodsReceipt>();
    }
}
