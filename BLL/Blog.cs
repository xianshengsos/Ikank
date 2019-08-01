﻿using BLL.Repoistory;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
public  class Blog:Article
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        
        public IList<BlogToKeywords> keywords { get; set; }
        public IList<Post> Posts { get; set; }
    }
}
