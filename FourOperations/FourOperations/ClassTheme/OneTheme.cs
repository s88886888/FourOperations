using ConsoleApp2.Themeup;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace ConsoleApp2.Base
{
    public class OneTheme : BasicData
    {

        private readonly Random random = new Random();
        readonly string[] ShowTheme = new string[10];
        readonly string[] ShowAnswer = new string[10];

        public readonly List<string> tempAnswer = new List<string>();//用户输出的答案
        public readonly List<string> tempTheme = new List<string>();//错的题目
        public readonly List<string> tempThemelist = new List<string>();
        /// <summary>
        /// 一年级出题范围：20以内加减
        /// </summary>
        public OneTheme()
        {

        }
        /// <summary>
        /// 随机生成两位数0-20的范围
        /// </summary>
        public override void RandomNumber()
        {
            BasicDataA = random.Next(0, 20);
            BasicDataB = random.Next(0, 20);
        }
        /// <summary>
        /// 调用此方法，生成一道加法题目
        /// </summary>
        /// <returns></returns>
        public override void AddTheme()
        {
            try
            {
                RandomNumber();
                if (BasicDataA > 20 && BasicDataB > 20)
                {
                    throw new Exception("A>20 并且 B>20");
                }
                else
                {
                    Theme = BasicDataA + "+" + BasicDataB;
                    Answer = BasicDataA + BasicDataB;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// 调用此方法，生成一道减法题目
        /// </summary>
        /// <returns></returns>
        public override void SubTheme()
        {
            RandomNumber();
            try
            {
                if (BasicDataA > 20 && BasicDataB > 20)
                {
                    throw new Exception("A>20 并且 B>20");
                }
                else
                {
                    if (BasicDataA > BasicDataB)
                    {
                        Theme = BasicDataA + "-" + BasicDataB;
                        Answer = BasicDataA - BasicDataB;
                    }
                    else
                    {
                        BasicDataA += BasicDataB;
                        BasicDataB = BasicDataA - BasicDataB;
                        BasicDataA -= BasicDataB;
                        Theme = BasicDataA + "-" + BasicDataB;
                        Answer = BasicDataA - BasicDataB;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        ///      ///调用此方法一次出10题加法题目
        /// </summary>
        public override void AddThemeCount()
        {

            for (int i = 0; i < ShowTheme.Length; i++)
            {
                var oneTheme = new OneTheme();
                oneTheme.AddTheme();
                ArrayDate(ShowTheme, ShowAnswer, i, oneTheme);
            }
            Show(ShowTheme, ShowAnswer);
        }
        /// <summary>
        ///  //调用此方法一次出10题减法题目
        /// </summary>
        public override void SubThemeCount()
        {
            for (int i = 0; i < ShowTheme.Length; i++)
            {
                var oneTheme = new OneTheme();
                oneTheme.SubTheme();
                ArrayDate(ShowTheme, ShowAnswer, i, oneTheme);
            }
            Show(ShowTheme, ShowAnswer);
        }

        /// <summary>
        /// 用来装10道题目Data
        /// </summary>
        /// <param name="ShowTheme"></param>
        /// <param name="ShowAnswer"></param>
        /// <param name="i"></param>
        /// <param name="oneTheme"></param>的数据
        private void ArrayDate(string[] ShowTheme, string[] ShowAnswer, int i, OneTheme oneTheme)
        {
            ShowTheme[i] = oneTheme.Theme;
            ShowAnswer[i] = oneTheme.Answer.ToString();
            ArrayTheme.Add(oneTheme.Theme);
            ArrayAnswer.Add(oneTheme.Answer.ToString());
        }
        /// <summary>
        /// 打印生成的10道题目Add
        /// </summary>
        public void AddOutPutTxt()
        {
            string result = "..\\..\\..\\Add.txt";//保存文件路径
            OneTheme FourTheme = new OneTheme();
            OutPutTxt(result);
            AddOutPutXml(FourTheme);
        }
        /// <summary>
        /// 打印生成的10道题目Sub
        /// </summary>
        public void SubOutPutTxt()
        {
            string result = "..\\..\\..\\打印文件一年级减法题目.txt";//保存文件路径
            FourTheme FourTheme = new FourTheme();
            OutPutTxt(result);
            SubOutPutXml(FourTheme);
        }
        /// <summary>
        /// 读取打印成txt的加法文件
        /// </summary>
        public void AddReaderTxt()
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"..\\..\\..\\打印文件一年级加法题目.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch
            {
                throw new Exception("没有这个文件");
            }
        }
        /// <summary>
        /// 读取打印成txt的减法文件
        /// </summary>
        public void SubReaderTxt()
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"..\\..\\..\\打印文件一年级减法题目.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch
            {
                throw new Exception("没有这个文件");
            }
        }
        /// <summary>
        /// 同步Add打印xml
        /// </summary>
        /// <param name="FourTheme"></param>
        public void AddOutPutXml(OneTheme fourTheme)
        {
            string fileName = "打印文件一年级加法题目.xml";
            OutPutXml(fileName);
        }
        /// <summary>
        /// 同步Sub打印xml
        /// </summary>
        /// <param name="oneTheme"></param>
        public void SubOutPutXml(FourTheme FourTheme)
        {
            string fileName = "打印文件一年级减法题目.xml";
            OutPutXml(fileName);
        }
        /// <summary>
        /// 打印Xml的数据
        /// </summary>
        /// <param name="oneTheme"></param>
        /// <param name="fileName"></param>

        /// <summary>
        /// 读取加法XML文件
        /// </summary>
        public void AddReaderXML()
        {
            using (XmlReader reader = XmlReader.Create("打印文件一年级加法题目.xml"))
            {
                ReaderXML(reader);
            }
        }
        public void SubReaderXML()
        {

            using (XmlReader reader = XmlReader.Create("打印文件一年级减法题目.xml"))
            {
                ReaderXML(reader);
            }
        }

        private void ReaderXML(XmlReader reader)
        {
            while (!reader.EOF)
            {
                if (reader.MoveToContent() == XmlNodeType.Element && reader.Name == "Theme")
                {
                    vsArrayTheme.Add(reader.ReadElementContentAsString());
                    if (reader.MoveToContent() == XmlNodeType.Element && reader.Name == "Answer")
                    {
                        vsArrayAnswer.Add(reader.ReadElementContentAsString());
                    }
                }
                else
                {
                    reader.Read();
                }
            }
        }


        /// <summary>
        /// 错题打印txt
        /// </summary>
        /// <param name="list"></param>
        public void ErrorsText()
        {

            for (int i = 0; i < ArrayTheme.Count - 1; i++)
            {
                if (tempAnswer[i] != ArrayAnswer[i])
                {
                    //return null;
                    tempTheme.Add(ArrayTheme[i]);
                    tempThemelist.Add(ArrayAnswer[i]);
                }
            }
            string result = "..\\..\\..\\错题打印.txt";
            FileStream fs = new FileStream(result, FileMode.OpenOrCreate);
            StreamWriter wr = new StreamWriter(fs);
            for (int i = 0; i < tempTheme.Count; i++)
            {
                wr.WriteLine(tempTheme[i] + FFF + tempThemelist[i]);
            }
            wr.Flush();
            fs.Close();

            Console.WriteLine("打印成功");
        }
    }
}
