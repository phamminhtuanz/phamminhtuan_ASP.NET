using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection.Metadata.Ecma335;

namespace SS03.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenresId { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Sumary { get; set; }
        // danh sách các cuốn sách ( nhớ using System.Collections.Generic)
        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book() {
                    Id = 1,
                    Title = "Rồng Nhỏ",
                    AuthorId = 1,
                    GenresId = 1,
                    Image = "/Images/anh1.jpg",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 250
                    },
                new Book() {
                    Id = 2,
                    Title = "Dragoll",
                    AuthorId = 1,
                    GenresId = 1,
                    Image = "/Images/anh2.jpg",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 250
                    },
                new Book() {
                    Id = 3,
                    Title = "Naruto",
                    AuthorId = 1,
                    GenresId = 1,
                    Image = "/Images/anh3.jpg",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 250
                    },
                new Book() {
                    Id = 4,
                    Title = "One Piece",
                    AuthorId = 1,
                    GenresId = 1,
                    Image = "/Images/anh4.jpg",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 250
                    },
                };
            return books;
        }
        public Book GetBookById(int id)
        {
            Book book = this.GetBookList().FirstOrDefault(b => b.Id == id);
            return book;
        }
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>()
        {
            new SelectListItem {Value="1",Text="Nam Cao"},
            new SelectListItem {Value="2",Text="Ngô Tất Tố" },
            new SelectListItem {Value="3",Text="Adamkhoom" },
            new SelectListItem {Value="4",Text="Nguyễn Văn An" }
        };
        public List<SelectListItem> Genres { get; } = new List<SelectListItem>()
        {
            new SelectListItem {Value="1",Text="Truyện Tranh" },
            new SelectListItem {Value="2",Text="Văn học đương đại" },
            new SelectListItem {Value="3",Text="Truyện Cười" },
            new SelectListItem {Value="4",Text="FIFA Online 4" }
        };
    }
}
