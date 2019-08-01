using BLL.Repoistory;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
  public  class Keyword
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<BlogToKeywords> Blogs { get; set; }
    }
}
