using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseNet.Data.Entittes
{
    [Table("tblOrders")]
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        [ForeignKey("Status")]
        public int StutusId { get; set; }
        public virtual OrderStatus Status { get; set; }
        [ForeignKey("Users")]
        public int UserID { get; set; }
        public virtual User Users { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
