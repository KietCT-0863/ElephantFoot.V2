using System;
using System.Collections.Generic;

namespace ElephantFoot.DAL.Entities;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public DateOnly? PublishedDate { get; set; }

    public decimal? Price { get; set; }

    public int? PublisherId { get; set; }

    public string? ImageUrl { get; set; }

    public virtual Publisher? Publisher { get; set; }

    public virtual ICollection<Author> Authors { get; set; } = new List<Author>();

    public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
}
