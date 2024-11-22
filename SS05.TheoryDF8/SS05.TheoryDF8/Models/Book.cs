using System.ComponentModel.DataAnnotations.Schema;

namespace SS05.TheoryDF8.Models
{
    [Table("Book")]
    public class Book
    {
        public string BookId { get; set; }
        public string Name { get; set; }
        public int? CategoryID { get; set; }
        public int? PublisherId { get; set; }
        public Category Category { get; set; }
        public Publishers Publishers { get; set; }
    }
}
