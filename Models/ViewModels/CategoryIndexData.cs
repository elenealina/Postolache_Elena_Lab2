using System.Collections.Generic;
using Postolache_Elena_Lab2.Models;

namespace Postolache_Elena_Lab2.Models.ViewModels
{
    public class CategoryIndexData
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
