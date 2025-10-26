using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Postolache_Elena_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string AuthorName { get; set; }
        public ICollection<Book>? Books { get; set; } //navigation property
    }
}