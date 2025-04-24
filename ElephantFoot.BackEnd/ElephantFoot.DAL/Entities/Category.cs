using System;
using System.Collections.Generic;

namespace ElephantFoot.DAL.Entities;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? ImageUrl { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
