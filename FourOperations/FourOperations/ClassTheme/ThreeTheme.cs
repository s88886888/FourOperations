
using FourOperations.ClassTheme;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq.Expressions;
using System.Text;
using System.Xml;

namespace ConsoleApp2.Themeup
{
    public class ThreeTheme : BasicData
    {
        readonly Random random = new Random();
        readonly string[] ShowTheme = new string[10];
        readonly string[] ShowAnswer = new string[10];

        /// <summary>
        /// 三年级.100以内的加减乘除,有负数，混合运算,例如3*10-5
        /// </summary>
        public ThreeTheme()
        {

        }
        public override void RandomNumber()
        {
            BasicDataA = random.Next(-10, 100);
            BasicDataB = random.Next(-10, 100);
            BasicDataC = random.Next(-10, 100);
            LsitNumA = random.Next(0, 3);
            LsitNumB = random.Next(0, 3);
        }

        /// <summary>
        /// 生成一道乘法题目
        /// </summary>

        public void Multiply()
        {

            try
            {
                RandomNumber();
                if (BasicDataA > 100 && BasicDataB > 100 && BasicDataC > 100 || BasicDataA < -10 && BasicDataB < -10 && BasicDataC < -10)
                {
                    throw (new CustomExcepsion("A>100 &&B>100"));
                }

                else
                {
                    Theme = $"{BasicDataA}{CCC[2]}{BasicDataB}";

                    Answer = BasicDataA * BasicDataB;
                    if (Answer > 1000 || Answer < -100)
                    {
                        Multiply();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Division()
        {

            try
            {
                RandomNumber();
                if (BasicDataA > 100 && BasicDataB > 100 && BasicDataC > 100 || BasicDataA < -10 && BasicDataB < -10 && BasicDataC < -10)
                {
                    throw (new CustomExcepsion("A>100 &&B>100"));
                }

                else
                {
                    Theme = $"{BasicDataA}{CCC[3]}{BasicDataB}";
                    Answer = BasicDataA / BasicDataB;
                    if (Answer > 100 || Answer < -100)
                    {
                        Division();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void MultiplyAndDivision()
        {
            //try
            //{
            //Multiply();
            //while (Answer >= 10000 || Answer <= -100)
            //{
            //    Multiply();
            //}
            //string a = Theme;
            //double Num1 = Answer;
            //Division();
            //while (threeTheme.Answer >= 10000 || threeTheme.Answer <= -100)
            //{
            //    Division();
            //}
            //Themea = a + Theme;
            //double Num2 = Answer;
            //Answer = Convert.ToInt32(Num1 + Num2);


            RandomNumber();
            if (BasicDataA > 100 && BasicDataB > 100)
            {
                throw (new CustomExcepsion("A>100 &&B>100"));
            }

            else
            {
                DataTable table = new DataTable();
                Theme = $"{BasicDataA}{CCC[LsitNumA]}({BasicDataB}{CCC[LsitNumB]}{BasicDataC})".ToString();
                Answer = Convert.ToInt32(table.Compute(Theme, ""));
            }
            //}
            //catch
            //{
            //    throw new Exception("混合运算异常");
            //}
        }

        private void NewMethod()
        {
            if (LsitNumA == 0 && LsitNumB == 0)
            {
                Theme = "BasicDataA + BasicDataB +BasicDataC";
                Answer = BasicDataA + BasicDataB + BasicDataC;
            }
            if (LsitNumA == 1 && LsitNumB == 1)
            {
                Theme = "BasicDataA - BasicDataB -BasicDataC";
                Answer = BasicDataA + BasicDataB + BasicDataC;
            }
            if (LsitNumA == 2 && LsitNumB == 2)
            {
                Theme = "BasicDataA * BasicDataB *BasicDataC";
                Answer = BasicDataA + BasicDataB + BasicDataC;
            }
            if (LsitNumA == 3 && LsitNumB == 3)
            {
                Theme = "BasicDataA / BasicDataB /BasicDataC";
                Answer = BasicDataA / BasicDataB / BasicDataC;
            }
        }

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
                var threeTheme = new ThreeTheme();
                threeTheme.AddTheme();
                ArrayDate(ShowTheme, ShowAnswer, i, threeTheme);
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
                var threeTheme = new ThreeTheme();
                threeTheme.SubTheme();
                ArrayDate(ShowTheme, ShowAnswer, i, threeTheme);
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
        private void ArrayDate(string[] ShowTheme, string[] ShowAnswer, int i, ThreeTheme oneTheme)
        {
            ShowTheme[i] = oneTheme.Theme;
            ShowAnswer[i] = oneTheme.Answer.ToString();
            ArrayTheme.Add(oneTheme.Theme);
            ArrayAnswer.Add(oneTheme.Answer.ToString());
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
            string result = @"D:\打印文件Add.txt";//保存文件路径
            TwoTheme twoTheme = new TwoTheme();
            OutPutTxt(result);
            AddOutPutXml(twoTheme);
        }
        /// <summary>
        /// 打印生成的10道题目Sub
        /// </summary>
        public void SubOutPutTxt()
        {
            string result = @"D:\打印文件Sub.txt";//保存文件路径
            TwoTheme twoTheme = new TwoTheme();
            OutPutTxt(result);
            SubOutPutXml(twoTheme);
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
                using (StreamReader sr = new StreamReader(@"D:\打印文件Add.txt"))
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
                using (StreamReader sr = new StreamReader(@"D:\打印文件Sub.txt"))
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
        /// <param name="twoTheme"></param>
        public void AddOutPutXml(TwoTheme twoTheme)
        {
            string fileName = "打印文件Add.xml";
            OutPutXml(fileName);
        }
        /// <summary>
        /// 同步Sub打印xml
        /// </summary>
        /// <param name="oneTheme"></param>
        public void SubOutPutXml(TwoTheme twoTheme)
        {
            string fileName = "打印文件Sub.xml";
            OutPutXml(fileName);
        }
        /// <summary>
        /// 打印Xml的数据
        /// </summary>
        /// <param name="oneTheme"></param>
        /// <param name="fileName"></param>
        private void OutPutXml(string fileName)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
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
            using (XmlReader reader = XmlReader.Create("..\\..\\..\\打印文件Add.xml"))
            {
                ReaderXML(reader);
            }
        }
        public void SubReaderXML()
        {

            using (XmlReader reader = XmlReader.Create("..\\..\\..\\打印文件Sub.xml"))
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

