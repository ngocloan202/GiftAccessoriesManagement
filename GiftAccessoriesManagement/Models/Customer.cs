using System.ComponentModel.DataAnnotations;

namespace GiftAccessoriesManagement.Models
{
    public class Customer
    {
        [Key]
        public string CustomerId { get; set; }
        [Required, MaxLength(30)]
        public string CustomerCode { get; set; }
        [Required, MaxLength(50)]
        public string? FullName { get; set; }
        public Sex Sex { get; set; }
        [Required, MaxLength(255)]
        public string? Address { get; set; }
        [Required, MaxLength(100)]
        public string Email { get; set; }
        [Required, MaxLength(10)]
        public string PhoneNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        //public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
        public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
    }
    public enum Sex
    {
        Male,
        Female
    }
}
