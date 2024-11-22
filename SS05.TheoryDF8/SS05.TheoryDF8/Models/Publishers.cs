using System.ComponentModel.DataAnnotations.Schema;

namespace SS05.TheoryDF8.Models
{
    [Table("Publishers")]
    public class Publishers
    {
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
