using System.ComponentModel.DataAnnotations;
using System.Data;

namespace BookStore.Entities
{
    public class User
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public string full_name { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }

        public string account_status { get; set; }
        public virtual ICollection<Favorite_Book> Favorite_Books { get; set; } = new List<Favorite_Book>();

        public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();

        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

        public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
    }
}