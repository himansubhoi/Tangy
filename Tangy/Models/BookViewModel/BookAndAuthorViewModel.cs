using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tangy.Models.BookViewModel
{
    public class BookAndAuthorViewModel
    {
        public Book Book { get; set; }
        public IEnumerable<Author> AuthorList { get; set; }
    }
}
