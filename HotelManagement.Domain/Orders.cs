using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace HotelManagement.Domain
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public int MenuId { get; set; }//menu table 
        public int TableId { get; set; }

   
    }
}
