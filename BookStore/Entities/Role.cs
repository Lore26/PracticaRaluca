using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Entities
{
    public class Role
    {
        [Key]
        public int id { get; set; }
        [Required]
        public int role_name { get; set; }
        public virtual ICollection<User> Users { get; set; } = new List<User>();
    }
}