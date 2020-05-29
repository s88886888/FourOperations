using System;
using System.Data;
using System.IO;
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
        /// <summary>
        /// 生成随机数，为题目赋值
        /// </summary>
        public override void RandomNumber()
        {
            BasicDataA = random.Next(1, 150);
            BasicDataB = random.Next(1, 150);
            BasicDataC = random.Next(1, 150);
            LsitNumA = random.Next(0, 4);
            LsitNumB = random.Next(0, 4);

        }
        /// <summary>
        /// 生成一道乘法题目
        /// </summary>

        public void MultiplyTheme()
        {

            try
            {
                RandomNumber();
                if (BasicDataA > 150 && BasicDataB > 150)
                {
                    throw (new CustomExcepsion("A>100 &&B>100"));
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
                if (BasicDataA > 150 && BasicDataB > 150)
                {

                    throw (new CustomExcepsion("A>150 &&B>150"));
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
        /// 生成混合运算一道  A？B？C？ ？号是运算符 
        /// </summary>
        public void HybridOperation()
        {
            RandomNumber();
            if (BasicDataA > 150 && BasicDataB > 150 && BasicDataC > 150)
            {
                throw (new CustomExcepsion("A>150 &&B>150&&C > 150"));
            }
            if (BasicDataB == 0 || BasicDataA == 0)
            {
                HybridOperation();
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
                    MultiplyTheme();
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
                var threeTheme = new ThreeTheme();
                threeTheme.MultiplyTheme();
                ArrayDate(ShowTheme, ShowAnswer, i, threeTheme);
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
                var threeTheme = new ThreeTheme();
                threeTheme.DivisionTheme();
                ArrayDate(ShowTheme, ShowAnswer, i, threeTheme);
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
                if (BasicDataA > 150 && BasicDataB > 150)
                {
                    throw new Exception("A>150 并且 B>150");
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
                if (BasicDataA > 150 && BasicDataB > 150)
                {
                    throw new Exception("A>150 并且 B>150");
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
        //调用此方法生成10题 混合运算 A？B？C？ ？号是运算符 
        public void HybridOperationCount()
        {
            for (int i = 0; i < ShowTheme.Length; i++)
            {
                var threeTheme = new ThreeTheme();
                threeTheme.HybridOperation();
                ArrayDate(ShowTheme, ShowAnswer, i, threeTheme);
            }
            Show(ShowTheme, ShowAnswer);
        }
        /// <summary>
        /// 交换变量值
        /// </summary>
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
        /// 打印生成的10道题目Add
        /// </summary>
        public void AddOutPutTxt()
        {
            string result = @"..\\..\\..\\打印文件三年级加法题目.txt";//保存文件路径
            ThreeTheme threeTheme = new ThreeTheme();
            OutPutTxt(result);
            AddOutPutXml(threeTheme);
        }
        /// <summary>
        /// 打印生成的10道题目Sub
        /// </summary>
        public void SubOutPutTxt()
        {
            string result = @"..\\..\\..\\打印文件三年级减法题目.txt";//保存文件路径
            ThreeTheme threeTheme = new ThreeTheme();
            OutPutTxt(result);
            SubOutPutXml(threeTheme);
        }

        public void MultiplyAndDivisionThemeOutPutTxt()
        {
            string result = @"..\\..\\..\\打印文件三年级混合运算题目.txt";//保存文件路径
            ThreeTheme threeTheme = new ThreeTheme();
            OutPutTxt(result);
            MultiplyAndDivisionThemeOutPutXml(threeTheme);
        }

        /// <summary>
        /// 封装打印数据
        /// </summary>
        /// <param name="result"></param>
        /// <param name="oneTheme"></param>
        /// <summary>
        /// 读取打印成txt的加法文件
        /// </summary>
        public void AddReaderTxt()
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"..\\..\\..\\打印文三年级减法题目.txt"))
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
                using (StreamReader sr = new StreamReader(@"..\\..\\..\\打印文件三年级加法题目.txt"))
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
        /// <param name="threeTheme"></param>
        public void AddOutPutXml(ThreeTheme threeTheme)
        {
            string fileName = "打印文件三年级加法题目.xml";
            OutPutXml(fileName);
        }
        /// <summary>
        /// 同步Sub打印xml
        /// </summary>
        /// <param name="oneTheme"></param>
        public void SubOutPutXml(ThreeTheme threeTheme)
        {
            string fileName = "打印文件三年级减法题目.xml";
            OutPutXml(fileName);
        }
        /// <summary>
        /// 打印出混合运算
        /// </summary>
        /// <param name="threeTheme"></param>
        public void MultiplyAndDivisionThemeOutPutXml(ThreeTheme threeTheme)
        {
            string fileName = "打印三年级混合运算题目.xml";
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
            using (XmlReader reader = XmlReader.Create("打印文件三年级加法题目.xml"))
            {
                ReaderXML(reader);
            }
        }
        public void SubReaderXML()
        {

            using (XmlReader reader = XmlReader.Create("打印文件三年级减法题目.xml"))
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

