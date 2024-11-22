using System.ComponentModel.DataAnnotations.Schema;

namespace SS05.TheoryDF8.Models
{
    [Table("Category")]
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
