using System;
using System.Collections.Generic;

namespace ElephantFoot.DAL.Entities;

public partial class Publisher
{
    public int PublisherId { get; set; }

    public string PublisherName { get; set; } = null!;

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? ImageUrl { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
