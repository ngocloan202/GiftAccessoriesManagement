using System.ComponentModel.DataAnnotations;

namespace GiftAccessoriesManagement.Models
{
    public class Account
    {
        [Key]
        public int AcountId { get; set; }
        [Required, MaxLength(10)]
        public string PhoneNumber { get; set; }
        [Required, MaxLength(50)]
        public string Password { get; set; }
        public Role Role { get; set; }
        public int Status { get; set; }

        public virtual Customer? Customer { get; set; }

        //public virtual Employee? Employee { get; set; }
    }
        public enum Role { 
            Manage,
            Employee,
            Customer 
        }
 }
