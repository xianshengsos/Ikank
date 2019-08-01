using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repoistory
{
 public   class BlogToKeywords
    {
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public int KeywordId { get; set; }
        public Keyword Keyword { get; set; }
    }
}
