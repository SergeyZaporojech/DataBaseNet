using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseNet.Data.Entittes
{
    [Table("tblOrderItem")]
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        [Precision(10,2)]
        public decimal PriceBuy { get; set; }
        public int Count { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
