using System.ComponentModel.DataAnnotations;

namespace BookStore.Entities
{
    public class Author
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public string author_name { get; set; }
        public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    }
}