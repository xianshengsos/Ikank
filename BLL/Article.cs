﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
   public  class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public User Author { get; set; }
        public string DiscriminatorType { get; set; }
    }
}
