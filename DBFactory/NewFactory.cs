
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
            _suggestService.Publish("jjjjjjjj", "",RegisterFactory.Zhangshan.Id);
               
        }
    }
}
