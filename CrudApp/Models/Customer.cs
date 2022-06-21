using System.ComponentModel.DataAnnotations;

namespace CrudApp.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerJob { get; set; }
    }
}
