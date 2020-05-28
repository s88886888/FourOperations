
using ConsoleApp2.Base;
using ConsoleApp2.Themeup;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace FourOperations
{
    class Program
    {

        static void Main(string[] args)
        {

            //FourTheme fourTheme = new FourTheme();
            //加法
            //fourTheme.AddThemeCount();
            //fourTheme.AddOutPutTxt();
            //减法
            //fourTheme.SubThemeCount();
            //fourTheme.SubOutPutTxt();
            //乘法
            //fourTheme.MultiplyThemeCount();
            //fourTheme.MultiplyOutPutTxt();




            //OneTheme oneTheme = new OneTheme();
            //oneTheme.AddThemeCount();
            //Console.WriteLine("0");


            //TwoTheme twoTheme = new TwoTheme();
            //twoTheme.AddThemeCount();
            //Console.WriteLine("1");



            ThreeTheme threeTheme = new ThreeTheme();
            threeTheme.DivisionThemeCount();


            //FourTheme fourTheme = new FourTheme();
            //fourTheme.AddThemeCount();
            //Console.WriteLine("3");
        }
    }
}
