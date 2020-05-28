using ConsoleApp2.Base;

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Xml;

namespace ConsoleApp2.Themeup
{
    public class FourTheme : BasicData
    {
        readonly Random random = new Random();
        readonly string[] ShowTheme = new string[10];
        readonly string[] ShowAnswer = new string[10];

        /// <summary>
        /// 三年级.100以内的加减乘除,有负数，混合运算,例如3*10-5
        /// </summary>
        public FourTheme()
        {

        }
        /// <summary>
        /// 生成随机数，为题目赋值
        /// </summary>
        public override void RandomNumber()
        {
            BasicDataA = random.Next(-10, 200);
            BasicDataB = random.Next(-10, 200);
            BasicDataC = random.Next(-10, 200);
            BasicDataD = random.Next(-10, 200);
            LsitNumA = random.Next(0, 4);
            LsitNumB = random.Next(0, 4);
            LsitNumC = random.Next(0, 4);
        }
        /// <summary>
        /// 生成一道乘法题目
        /// </summary>

        public void MultiplyTheme()
        {

            try
            {
                RandomNumber();
                if (BasicDataA > 200 && BasicDataB > 200)
                {
                    throw (new CustomExcepsion("A>200 &&B>200"));
                }

                else
                {
                    Theme = $"{BasicDataA}{CCC[2]}{BasicDataB}";
                    Answer = BasicDataA * BasicDataB;
                    if (Answer > 1000 || Answer < -100)
                    {
                        MultiplyTheme();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// 生成一道除法题目
        /// </summary>
        public void DivisionTheme()
        {
            RandomNumber();
            try
            {
                if (BasicDataA > 200 && BasicDataB > 100)
                {

                    throw (new CustomExcepsion("A>200 &&B>200"));
                }
                else
                {
                    //分子大于分母
                    if (BasicDataA > BasicDataB)
                    {
                        Theme = $"{BasicDataA}{CCC[3]}{BasicDataB}";
                        Answer = Math.Round(BasicDataA / BasicDataB, 2);
                    }
                    else
                    {
                        //如果大于，两极反转                   
                        ChangeNumber();
                        Theme = $"{BasicDataA}{CCC[3]}{BasicDataB}";
                        Answer = Math.Round(BasicDataA / BasicDataB, 2);

                        if (Answer < -10 || Answer == 0)
                        {
                            DivisionTheme();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// 生成混合运算  A？B？C？
        /// </summary>
        public void HybridOperationTheme()
        {

            RandomNumber();
            if (BasicDataA > 200 && BasicDataB > 100)
            {
                throw (new CustomExcepsion("A>200 &&B>200"));
            }
            if (BasicDataB == 0 || BasicDataA == 0)
            {
                HybridOperationTheme();
            }
            else
            {
                bool num = true;
                string number = null;
                DataTable table = new DataTable();
                if (LsitNumA == 3 || LsitNumA == 4)
                {
                    Theme = $"{BasicDataA}{CCC[LsitNumA]}({BasicDataB}{CCC[LsitNumB]}{BasicDataC})".ToString();
                    number = Convert.ToDouble(table.Compute(Theme, null)).ToString("0.000");
                    Answer = Convert.ToDouble(number);
                    num = false;
                }
                if (LsitNumA == 0 || LsitNumA == 1)
                {
                    Theme = $"({BasicDataA}{CCC[LsitNumA]}{BasicDataB}){CCC[LsitNumB]}{BasicDataC}".ToString();
                    number = Convert.ToDouble(table.Compute(Theme, null)).ToString("0.000"); ;
                    Answer = Convert.ToDouble(number);
                    num = false;
                }
                if (num == true)
                {
                    Theme = $"{BasicDataA}{CCC[LsitNumA]}{BasicDataB}{CCC[LsitNumB]}{BasicDataC}".ToString();
                    number = Convert.ToDouble(table.Compute(Theme, null)).ToString("0.000"); ;
                    Answer = Convert.ToDouble(number);
                }
                if (Answer > 10000 || Answer < -100)
                {
                    HybridOperationTheme();
                }
            }
        }

        /// <summary>
        /// 核心代码：生成一道四则运算题目
        /// </summary>
        public void FourOperationsTheme()
        {
            RandomNumber();
            if (BasicDataA > 200 && BasicDataB > 200)
            {
                throw (new CustomExcepsion("A>200 &&B>200"));
            }
            if (BasicDataB == 0 || BasicDataA == 0)
            {
                FourOperationsTheme();
            }
            else
            {
                bool num = true;
                string number = null;
                DataTable table = new DataTable();
                if (LsitNumB == 3 || LsitNumB == 4)
                {
                    Theme = $"({BasicDataA}{CCC[LsitNumA]}{BasicDataB}){CCC[LsitNumB]}({BasicDataC}{CCC[LsitNumC]}{BasicDataD})".ToString();
                    number = Convert.ToDouble(table.Compute(Theme, null)).ToString("0.000");
                    Answer = Convert.ToDouble(number);
                    num = false;
                }
                if (LsitNumA == 4 || LsitNumA == 3 && num == true)
                {
                    Theme = $"{BasicDataA}{CCC[LsitNumA]}({BasicDataB}{CCC[LsitNumB]}{BasicDataC}){CCC[LsitNumC]}{BasicDataD}".ToString();
                    number = Convert.ToDouble(table.Compute(Theme, null)).ToString("0.000"); ;
                    Answer = Convert.ToDouble(number);
                    num = false;
                }
                if (LsitNumC == 4 || LsitNumA == 3 && num == true)
                {
                    Theme = $"{BasicDataA}{CCC[LsitNumA]}({BasicDataB}{CCC[LsitNumB]}({BasicDataC}{CCC[LsitNumC]}{BasicDataD})".ToString();
                    number = Convert.ToDouble(table.Compute(Theme, null)).ToString("0.000"); ;
                    Answer = Convert.ToDouble(number);
                }
                if (num == true)
                {
                    Theme = $"{BasicDataA}{CCC[LsitNumA]}{BasicDataB}{CCC[LsitNumB]}{BasicDataC}{CCC[LsitNumC]}{BasicDataD}".ToString();
                    number = Convert.ToDouble(table.Compute(Theme, null)).ToString("0.000"); ;
                    Answer = Convert.ToDouble(number);
                }
                if (Answer > 10000 || Answer < -100)
                {
                    FourOperationsTheme();
                }
            }
        }
        /// <summary>
        /// 生成十条乘法题目
        /// </summary>
        /// 
        public void MultiplyThemeCount()
        {
            for (int i = 0; i < ShowTheme.Length; i++)
            {
                var fourTheme = new FourTheme();
                fourTheme.MultiplyTheme();
                ArrayDate(ShowTheme, ShowAnswer, i, fourTheme);
            }
            Show(ShowTheme, ShowAnswer);
        }
        /// <summary>
        /// 生成十条除法题目
        /// </summary>
        public void DivisionThemeCount()
        {
            for (int i = 0; i < ShowTheme.Length; i++)
            {
                var fourTheme = new FourTheme();
                fourTheme.DivisionTheme();
                ArrayDate(ShowTheme, ShowAnswer, i, fourTheme);
            }
            Show(ShowTheme, ShowAnswer);
        }
        /// <summary>
        /// 生成一道加法题目
        /// </summary>
        public override void AddTheme()
        {
            try
            {
                RandomNumber();
                if (BasicDataA > 200 && BasicDataB > 200)
                {
                    throw new Exception("A>200 并且 B>200");
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
                if (BasicDataA > 200 && BasicDataB > 200)
                {
                    throw new Exception("A>200 并且 B>200");
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
                        ChangeNumber();
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
        /// 调用此方法生成10道四则运算
        /// </summary>
        public void FourOperationsThemeCount()
        {
            for (int i = 0; i < ShowTheme.Length; i++)
            {
                var fourTheme = new FourTheme();
                fourTheme.FourOperationsTheme();
                ArrayDate(ShowTheme, ShowAnswer, i, fourTheme);
            }
            Show(ShowTheme, ShowAnswer);
        }
        /// <summary>
        ///调用此方法生成10题 混合运算 A？B？C？ ？号是运算符 
        /// </summary>
        public void HybridOperationThemeCount()
        {
            for (int i = 0; i < ShowTheme.Length; i++)
            {
                var fourTheme = new FourTheme();
                fourTheme.HybridOperationTheme();
                ArrayDate(ShowTheme, ShowAnswer, i, fourTheme);
            }
            Show(ShowTheme, ShowAnswer);
        }
        /// <summary>
        /// 交换变量值
        /// </summary>
        /// 
        private void ChangeNumber()
        {
            BasicDataA += BasicDataB;
            BasicDataB = BasicDataA - BasicDataB;
            BasicDataA -= BasicDataB;
        }

        /// <summary>
        ///      ///调用此方法一次出10题加法题目
        /// </summary>
        public override void AddThemeCount()
        {

            for (int i = 0; i < ShowTheme.Length; i++)
            {
                var fourTheme = new FourTheme();
                fourTheme.AddTheme();
                ArrayDate(ShowTheme, ShowAnswer, i, fourTheme);
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
                var fourTheme = new FourTheme();
                fourTheme.SubTheme();
                ArrayDate(ShowTheme, ShowAnswer, i, fourTheme);
            }
            Show(ShowTheme, ShowAnswer);
        }

        /// <summary>
        /// 用来装10道题目Data
        /// </summary>
        /// <param name="ShowTheme"></param>
        /// <param name="ShowAnswer"></param>
        /// <param name="i"></param>
        /// <param name="fourTheme"></param>的数据
        private void ArrayDate(string[] ShowTheme, string[] ShowAnswer, int i, FourTheme fourTheme)
        {
            ShowTheme[i] = fourTheme.Theme;
            ShowAnswer[i] = fourTheme.Answer.ToString();
            ArrayTheme.Add(fourTheme.Theme);
            ArrayAnswer.Add(fourTheme.Answer.ToString());
        }

        /// <summary>
        /// 输出10道题目和答案Date
        /// </summary>
        /// <param name="Array1"></param>
        /// <param name="Array2"></param>
        private static void Show(string[] Array1, string[] Array2)
        {
            for (int i = 0; i < Array1.Length; i++)
            {
                Console.Write(Array1[i]);
                Console.WriteLine("=" + Array2[i]);
            }
        }
        /// <summary>
        /// 打印生成的10道题目Add
        /// </summary>
        public void AddOutPutTxt()
        {
            string result = @"..\\..\\..\\打印四年级加法题目.txt";//保存文件路径
            FourTheme fourTheme = new FourTheme();
            OutPutTxt(result);
            AddOutPutXml(fourTheme);
        }


        public void MultiplyOutPutTxt()
        {
            string result = @"..\\..\\..\\打印四年级乘法题目.txt";//保存文件路径
            FourTheme fourTheme = new FourTheme();
            OutPutTxt(result);
            MultiplyOutPutXml(fourTheme);
        }
        public void DivisionOutPutTxt()
        {
            string result = @"..\\..\\..\\打印四年级除法题目.txt";//保存文件路径
            FourTheme fourTheme = new FourTheme();
            OutPutTxt(result);
            DivisionOutPutXml(fourTheme);
        }
        /// <summary>
        /// 打印生成的10道题目Sub
        /// </summary>
        public void SubOutPutTxt()
        {
            string result = @"..\\..\\..\\打印四年级减法题目.txt";//保存文件路径
            FourTheme fourTheme = new FourTheme();
            OutPutTxt(result);
            SubOutPutXml(fourTheme);
        }

        public void HybridOperationThemeOutPutTxt()
        {
            string result = @"..\\..\\..\\打印四年级混合运算题目.txt";//保存文件路径
            FourTheme fourTheme = new FourTheme();
            OutPutTxt(result);
            HybridOperationThemeOutPutXml(fourTheme);
        }
        public void FourOperationsThemeOutPutTxt()
        {
            string result = @"..\\..\\..\\打印四年级四则运算题目.txt";//保存文件路径
            FourTheme fourTheme = new FourTheme();
            OutPutTxt(result);
            HybridOperationThemeOutPutXml(fourTheme);
        }

        /// <summary>
        /// 封装打印数据
        /// </summary>
        /// <param name="result"></param>
        /// <param name="oneTheme"></param>
        private void OutPutTxt(string result)
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
                using (StreamReader sr = new StreamReader(@"..\\..\\..\\打印四年级加法题目.txt"))
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
                using (StreamReader sr = new StreamReader(@"..\\..\\..\\打印四年级减法题目.txt"))
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
        public void AddOutPutXml(FourTheme fourTheme)
        {
            string fileName = "打印四年级加法题目.xml";
            OutPutXml(fileName);
        }
        /// <summary>
        /// 同步Sub打印xml
        /// </summary>
        /// <param name="fourTheme"></param>
        /// 

        public void MultiplyOutPutXml(FourTheme fourTheme)
        {
            string fileName = "打印四年级乘法题目.xml";
            OutPutXml(fileName);
        }
        public void DivisionOutPutXml(FourTheme fourTheme)
        {
            string fileName = "打印四年级除法题目.xml";
            OutPutXml(fileName);
        }
        public void SubOutPutXml(FourTheme fourTheme)
        {
            string fileName = "打印四年级减法题目.xml";
            OutPutXml(fileName);
        }
        /// <summary>
        /// 打印出混合运算
        /// </summary>
        /// <param name="FourTheme"></param>
        public void HybridOperationThemeOutPutXml(FourTheme fourTheme)
        {
            string fileName = "打印四年级混合运算题目.xml";
            OutPutXml(fileName);
        }

        public void FourOperationsThemeOutPutXml(FourTheme fourTheme)
        {
            string fileName = "打印四年级四则运算题目.xml";
            OutPutXml(fileName);
        }
        /// <summary>
        /// 打印Xml的数据
        /// </summary>
        /// <param name="oneTheme"></param>
        /// <param name="fileName"></param>
        private void OutPutXml(string fileName)
        {
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true
            };
            using (XmlWriter writer = XmlWriter.Create("..\\..\\..\\" + fileName, settings))
            {
                writer.WriteStartElement("Create");
                for (int i = 0; i < ArrayTheme.Count; i++)
                {
                    writer.WriteElementString("Theme", ArrayTheme[i]);
                    writer.WriteElementString("Answer", ArrayAnswer[i]);
                }
                writer.WriteEndElement();
            }
            Console.WriteLine("xml同步写入成功");
        }

        /// <summary>
        /// 读取加法XML文件
        /// </summary>
        public void AddReaderXML()
        {
            using (XmlReader reader = XmlReader.Create("打印四年级加法题目.xml"))
            {
                ReaderXML(reader);
            }
        }
        public void SubReaderXML()
        {

            using (XmlReader reader = XmlReader.Create("打印四年级减法题目.xml"))
            {
                ReaderXML(reader);
            }
        }

        /// <summary>
        /// 封装 读取xml的数据
        /// </summary>
        /// <param name="reader"></param>
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

