﻿using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace SS05.TheoryDF8.Models
{
    public class BookManagementContext:DbContext
    {
        public BookManagementContext(DbContextOptions<BookManagementContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publishers> Publishers { get; set; }
    }
}
