using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticeProblem_2.Models
{
   [Table("Orders")]
    public class Orders
    {
        [Key]
        public int OId { get; set; }
        public string OName { get; set; }
        public string COrder {  get; set; }
        public string OAddress {  get; set; }

    }
}
