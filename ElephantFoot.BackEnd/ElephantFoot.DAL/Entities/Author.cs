using System;
using System.Collections.Generic;

namespace ElephantFoot.DAL.Entities;

public partial class Author
{
    public int AuthorId { get; set; }

    public string AuthorName { get; set; } = null!;

    public string? Email { get; set; }

    public string? ImageUrl { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
