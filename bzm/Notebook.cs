using System;
using System.Collections.Generic;
using System.Text;

namespace bzm
{
    class Notebook
    {
        //do while  先循环后判断    

        // Hastable 键值集合  ArryList 集合  List泛型
        //键值对集合 Dictionary
        ////string i = "dsa";
        ////string p = "qwqw";
        ////Console.WriteLine("dsaqwqw".Replace("sa","jym")); /*截取  Substring(1,3)*/    //Replace   替换   Randem 随机数  ||或 &&于  while 循环
        //params 关键字  定义数组用  一位数组
        // 把字符串变成字符用 tochararray 
        //interface 接口关键字

        //循环  switch  （）{case }  in 在  is  判断是否匹配
        //switch (变量)
        //{
        //  w  case '条件一': 要执行的代码 break;
        //    case '条件二': 要执行的代码 break;

        //    default: 要执行的代码 break;
        //}


        //foreach(类型 变量 in 数组名)


        ////yield  is是判断 as是转换

        //internal 在当前项目使用
        //static关键字 静态方法
        //虚方法 virtual 可以被子类重新写一遍  override 
        //抽象方法 abstract 抽象方法是没有方法体的
        // protercted  受保护的 在当前类或着在子类中调用
        // partial 部分类 使用同一个类
        //sealed  密封类   不能是父类可以是子类



        // ：base 用于引用父类的构造函数
        //形参（parameter，方法签名里的参数） vs 实参（argument，实际传递进来的参数）
        //break; 退出循环
        //int randem = new Random().Next(100);
        //Console.WriteLine(randem);

        //Console.ReadKey();


        //                            委托  delegate（关键字） 
        //                            上下关联
        //                        Action<int> ai = (x) => { Console.WriteLine("+"); };

        //  Func<int,int>有返回值的方法   Action：没有返回值的方法




        //                                      Linq语法

        /*   var man = new[]
            {
                   new{name="李药师",age="19",sex="男"},
                   new{name="王铁柱",age="19",sex="女"},                   创建匿名数组
                   new{name="巢昱清",age="19",sex="女"},
                   new{name="张德培",age="24",sex="男"},
               };
               */

        //排序
        // var<变量> = from<项目> in <数据源> where<表达式> orderby<表达式>    使用这个descending 倒序排列

        //Contains 关键字  包含什么什么   StartsWith

        // var jym = from j in man group j by j.sex;  数组分类  最后用2个foreach循环出来
        /* into y
                       select new {    查询指定属性有多少
                           da = y.Key, asd = y.Count()  */
    };
}

