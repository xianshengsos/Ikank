﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repoistory
{
  public  class SuggestRepository
    {
        private SQLContext _sqlContext;
        public SuggestRepository()
        {
            _sqlContext = new SQLContext();
        }
        public Suggest Save(Suggest suggest,int authorId)
        {
            suggest.Author = _sqlContext._users.Where(u => u.Id == authorId).SingleOrDefault();
            _sqlContext.Suggests.Add(suggest);
            _sqlContext.SaveChanges();
            return suggest;
        }
    }
}
