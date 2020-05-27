
using ConsoleApp2.Base;
using ConsoleApp2.Themeup;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FourOperations
{
    class Program
    {

        static void Main(string[] args)
        {

            ///四年级混合四则算法异常
            //FourThemeUp fourThemeUp = new FourThemeUp();
            //fourThemeUp.MultiplyAndDivision();
            //Console.WriteLine(fourThemeUp.Four);
            //Console.WriteLine(fourThemeUp.doublea);
            //三年级
            //ThreeTheme threeThemeup = new ThreeTheme();
            //threeThemeup.MultiplyAndDivision();
            //Console.WriteLine(threeThemeup.Multiplys);
            //Console.WriteLine(threeThemeup.DM);
            //一年级
            //OneTheme oneTheme = new OneTheme();
            ////加法
            //oneTheme.AddThemeCount();
            //Console.WriteLine(oneTheme.AddThemeCount());
            ////for (int i = 0; i < oneTheme.AddThemeCount().Length; i++)
            ////{
            ////    writer.WriteLine((strinsg)oneTheme.AddThemeCount());//换行
            ////    //writer.WriteLine((string)oneTheme.SubThemeCount());//换行
            ////}
            //Console.WriteLine("-----------------------------------------------------------------------------------");
            ////减法
            //oneTheme.SubThemeCount();
            ////打印文本
            //FileStream fs = new FileStream(result, FileMode.Append);
            //FileStream fs = new FileStream(result, FileMode.Append);
            //StreamWriter writer = null;
            //writer = new StreamWriter(fs);
            //string result = @"D:\打印文件.txt";//保存文件路径
            //FileStream fs = new FileStream(result, FileMode.Append);//创建新文件
            ////第一个是路径，
            ////第二个是确定当文件存在时，是覆盖掉还是将数据追加到文件中，true是将数据追加到已存在文件中，false是覆盖已存在的文件。
            ////第三个参数是要使用的字符编码，一般是使用默认的。
            ////StreamWriter writer = new StreamWriter(result, false, Encoding.Default);
            ////writer.Flush();
            //StreamWriter writer = null;
            //writer = new StreamWriter(fs);
            ////for (int i = 0; i < 10; i++)
            ////{
            //writer.WriteLine(oneTheme.AddThemeCount());
            ////}
            //writer.Close();
            //string result1 = @"D:\Git\测试文件.txt";
            //FileStream fs = new FileStream(result1, FileMode.Append);//创建新文件
            //StreamWriter wr = null;//写入内容
            //wr = new StreamWriter(fs);
            //wr.WriteLine("测试！");
            //wr.Close();
            //oneTheme.AddThemeCount();



            //OneTheme oneTheme = new OneTheme();
            //oneTheme.AddThemeCount();
            //oneTheme.AddOutPutTxt();


            //oneTheme1.AddThemeCount();
            //Console.WriteLine("---------------------------------------");
            //oneTheme1.SubThemeCount();
            //onetheme.SubThemeCount();
            //onetheme.SubOutPutTxt();
            //onetheme.SubOutPutXml(onetheme);
            //oneTheme.AddThemeCount();
            //oneTheme.SubOutPutXml(oneTheme);
            //oneTheme.AddReaderXML();
            //oneTheme.SubThemeCount();
            //oneTheme.SubOutPutTxt();
            //oneTheme.AddOutPutTxt();
            //oneTheme.AddReaderXML();
            //oneTheme.AddThemeCount();
            //oneTheme.AddOutPutTxt();

            //TwoTheme twoTheme = new TwoTheme();
            //twoTheme.AddThemeCount();
            //twoTheme.AddOutPutTxt();

            ThreeTheme threeTheme = new ThreeTheme();
            threeTheme.MultiplyAndDivisionThemeCount();


            //threeTheme.MultiplyAndDivisionTheme();
            //Console.WriteLine(threeTheme.Theme);
            //Console.WriteLine(threeTheme.Answer.ToString());
            //threeTheme.DivisionTheme();

            //threeTheme.MultiplyAndDivisionThemeCount();

            //ThreeTheme three = new ThreeTheme();
            //oneTheme.SubThemeCount();
            //oneTheme.SubOutPutTxt();
            //three.DivisionThemeCount();



            //List<string> temp = new List<string>();
            ////temp = Console.ReadLine();            
            //temp.Add("19");
            //temp.Add("35");
            //temp.Add("14");
            //temp.Add("55");
            //temp.Add("22");
            //temp.Add("3");
            //temp.Add("25");
            //temp.Add("10");
            //temp.Add("1");
            //temp.Add("25");

            //oneTheme.ErrorsText(temp);



            //OneTheme oneTheme = new OneTheme();
            //oneTheme.AddThemeCount();
            //for (int i = 0; i < oneTheme.ArrayTheme.Count; i++)
            //{
            //    string a = Console.ReadLine();
            //    oneTheme.tempAnswer.Add(a);
            //}
            //oneTheme.ErrorsText();
        }
    }
}
