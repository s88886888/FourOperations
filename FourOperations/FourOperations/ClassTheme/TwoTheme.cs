
using System;
using System.IO;
using System.Xml;

namespace ConsoleApp2.Themeup
{
    public class TwoTheme : BasicData
    {
        private readonly Random random = new Random();
        readonly string[] ShowTheme = new string[10];
        readonly string[] ShowAnswer = new string[10];
        /// <summary>
        /// 二年级出题范围：20以内加减
        /// </summary>
        public TwoTheme()
        {

        }
        /// <summary>
        /// 随机生成两位数0-20的范围
        /// </summary>
        public override void RandomNumber()
        {
            BasicDataA = random.Next(0, 100);
            BasicDataB = random.Next(0, 100);
        }
        /// <summary>
        /// 调用此方法，生成加法题目
        /// </summary>
        /// <returns></returns>
        public override void AddTheme()
        {
            try
            {
                RandomNumber();
                if (BasicDataA > 100 && BasicDataB > 100)
                {
                    throw new Exception("A>100 并且 B>100");
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
        /// 调用此方法生成减法题目
        /// </summary>
        /// <returns></returns>
        public override void SubTheme()
        {
            RandomNumber();
            try
            {
                if (BasicDataA > 100 && BasicDataB > 100)
                {
                    throw new Exception("A>100 并且 B>100");
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
                        //两变量转化
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
        ///      ///调用此方法出10题加法题目
        /// </summary>
        public override void AddThemeCount()
        {
            for (int i = 0; i < ShowTheme.Length; i++)
            {
                var twoTheme = new TwoTheme();
                twoTheme.AddTheme();
                ArrayDate(ShowTheme, ShowAnswer, i, twoTheme);
            }
            Show(ShowTheme, ShowTheme);
        }
        /// <summary>
        ///  //调用此方法二次出10题减法题目
        /// </summary>
        public override void SubThemeCount()
        {
            for (int i = 0; i < ShowTheme.Length; i++)
            {
                var twoTheme = new TwoTheme();
                twoTheme.SubTheme();
                ArrayDate(ShowTheme, ShowTheme, i, twoTheme);
            }
            Show(ShowTheme, ShowTheme);
        }

        /// <summary>
        /// 用来装10道题目Data
        /// </summary>
        /// <param name="ShowTheme"></param>
        /// <param name="ShowAnswer"></param>
        /// <param name="i"></param>
        /// <param name="oneTheme"></param>的数据
        private void ArrayDate(string[] ShowTheme, string[] ShowAnswer, int i, TwoTheme twoTheme)
        {
            ShowTheme[i] = twoTheme.Theme;
            ShowAnswer[i] = twoTheme.Answer.ToString();
            ArrayTheme.Add(twoTheme.Theme);
            ArrayAnswer.Add(twoTheme.Answer.ToString());
        }
        /// <summary>
        /// 打印生成的10道题目Add
        /// </summary>
        public void AddOutPutTxt()
        {
            string result = @"..\\..\\..\\打印文件二年级加法题目.txt";//保存文件路径
            TwoTheme twoTheme = new TwoTheme();
            OutPutTxt(result, twoTheme);
            AddOutPutXml(twoTheme);
        }
        /// <summary>
        /// 打印生成的10道题目Sub
        /// </summary>
        public void SubOutPutTxt()
        {
            string result = @"..\\..\\..\\打印文件二年级减法题目.txt";//保存文件路径
            TwoTheme twoTheme = new TwoTheme();
            OutPutTxt(result, twoTheme);
            SubOutPutXml(twoTheme);
        }

        /// <summary>
        /// 封装打印数据
        /// </summary>
        /// <param name="result"></param>
        /// <param name="oneTheme"></param>
        private void OutPutTxt(string result, TwoTheme twoTheme)
        {
            FileStream fs = new FileStream(result, FileMode.OpenOrCreate);
            StreamWriter wr = new StreamWriter(fs);
            for (int i = 0; i < ArrayTheme.Count; i++)
            {
                wr.WriteLine(ArrayTheme[i] + FFF + ArrayAnswer[i]);
            }
            wr.Flush();
            fs.Close();
        }


        /// <summary>
        /// 读取打印成txt的加法文件
        /// </summary>
        public void AddReaderTxt()
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"..\\..\\..\\打印文件二年级加法题目.txt"))
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
                using (StreamReader sr = new StreamReader(@"..\\..\\..\\打印文件二年级减法题目.txt"))
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
        /// <param name="oneTheme"></param>
        public void AddOutPutXml(TwoTheme twoTheme)
        {
            string fileName = "打印文件二年级加法题目.xml";
            OutPutXml(fileName);
        }
        /// <summary>
        /// 同步Sub打印xml
        /// </summary>
        /// <param name="oneTheme"></param>
        public void SubOutPutXml(TwoTheme twoTheme)
        {
            string fileName = "打印文件二年级减法题目.xml";
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
            using (XmlReader reader = XmlReader.Create("打印文件二年级加法题目.xml"))
            {
                ReaderXML(reader);
            }
        }
        public void SubReaderXML()
        {

            using (XmlReader reader = XmlReader.Create("打印文件二年级减法题目.xml"))
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
    }
}
