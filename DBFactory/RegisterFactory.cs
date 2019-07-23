using BLL;
using Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBFactory
{
  internal  class RegisterFactory
    {
        internal static User Zhangshan, Wangwu;
        private static UserService _suggestService;
        static RegisterFactory()
        {
            _suggestService = new UserService();
        }
        internal static void Create()
        {
            Zhangshan = _suggestService.Register("张三", Helper.PASSWORD);
            Wangwu = _suggestService.Register("王五", Helper.PASSWORD);
        }
    }
}
