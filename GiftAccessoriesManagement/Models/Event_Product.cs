using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GiftAccessoriesManagement.Models
{
    public class Event_Product
    {
        [Key, Column(Order = 0)]
        public int EventId { get; set; }

        [Key, Column(Order = 1)]
        public int ProductId { get; set; }

        public virtual Event? Event { get; set; }
        public virtual Product? Product { get; set; }

    }
}
