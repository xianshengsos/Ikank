
using BLL;
using Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBFactory
{
  internal  class NewFactory
    {
      
        private static SuggestService _suggestService;
        static NewFactory()
        {
            _suggestService = new SuggestService();
        }
        internal static void Create()
        {
            _suggestService.Publish("蒋先生", "文章文章文章文章",RegisterFactory.Zhangshan.Id);
               
        }
    }
}
