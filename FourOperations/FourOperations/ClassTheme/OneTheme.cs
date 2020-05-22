using System;
using System.IO;
using System.Xml;

namespace ConsoleApp2.Base
{
    public class OneTheme : BasicData
    {
        private readonly Random random = new Random();
        /// <summary>
        /// 一年级出题范围：20以内加减
        /// </summary>
        public OneTheme()
        {

        }
        /// <summary>
        /// 随机生成两位数0-20的范围
        /// </summary>
        public void Randomnum()
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
                Randomnum();
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
            Randomnum();
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
            string[] Array1 = new string[10];
            string[] Array2 = new string[10];
            for (int i = 0; i < Array1.Length; i++)
            {
                var oneTheme = new OneTheme();
                oneTheme.AddTheme();
                ArrayDate(Array1, Array2, i, oneTheme);
            }
            Show(Array1, Array2);
        }
        /// <summary>
        ///  //调用此方法一次出10题减法题目
        /// </summary>
        public override void SubThemeCount()
        {
            string[] Array1 = new string[10];
            string[] Array2 = new string[10];
            for (int i = 0; i < Array1.Length; i++)
            {
                var oneTheme = new OneTheme();
                oneTheme.SubTheme();
                ArrayDate(Array1, Array2, i, oneTheme);
            }
            Show(Array1, Array2);
        }

        /// <summary>
        /// 用来装10道题目Data
        /// </summary>
        /// <param name="Array1"></param>
        /// <param name="Array2"></param>
        /// <param name="i"></param>
        /// <param name="oneTheme"></param>的数据
        private void ArrayDate(string[] Array1, string[] Array2, int i, OneTheme oneTheme)
        {
            Array1[i] = oneTheme.Theme;
            Array2[i] = oneTheme.Answer.ToString();
            ArrayTheme[i] = oneTheme.Theme;
            ArrayAnswer[i] = oneTheme.Answer.ToString();
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
                Console.WriteLine(Array1[i]);
            }
            Console.WriteLine("----------答案-------------");
            for (int i = 0; i < Array2.Length; i++)
            {
                Console.WriteLine(Array2[i]);
            }
        }


        /// <summary>
        /// 输出10题目 加法文件
        /// </summary>
        public void AddOutPutTxt()
        {
            string result = @"D:\打印文件Add.txt";//保存文件路径
            OneTheme oneTheme = new OneTheme();
            oneTheme.AddThemeCount();
            OutPutTxt(result, oneTheme);
        }



        /// <summary>
        /// 输出减法文件
        /// </summary>
        public void SubOutPutTxt()
        {
            string result = @"D:\打印文件Sub.txt";//保存文件路径
            OneTheme oneTheme = new OneTheme();
            oneTheme.SubThemeCount();
            OutPutTxt(result, oneTheme);
        }

        /// <summary>
        /// 封装打印数据
        /// </summary>
        /// <param name="result"></param>
        /// <param name="oneTheme"></param>
        private void OutPutTxt(string result, OneTheme oneTheme)
        {
            FileStream fs = new FileStream(result, FileMode.OpenOrCreate);
            StreamWriter wr = new StreamWriter(fs);
            for (int i = 0; i < ArrayTheme.Length; i++)
            {
                wr.WriteLine(oneTheme.ArrayTheme[i] + FFF + oneTheme.ArrayAnswer[i]);
            }
            wr.Flush();
            fs.Close();
        }



        public void ReaderTxt()
        {
            using (StreamReader sr = new StreamReader(@"D:\打印文件Add.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            using (StreamReader sr = new StreamReader(@"D:\打印文件Sub.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }


        }

        public void WriteXMLAdd(string fileName)
        {
            var oneTheme = new OneTheme();
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create("..\\..\\..\\" + fileName, settings))
            {
                writer.WriteStartElement("生成题目");//开始写入标记
                                                 //writer.WriteElementString("题目", oneTheme.AddThemeCount());
                oneTheme.AddThemeCount();
                for (int i = 0; i < ArrayTheme.Length; i++)
                {
                    writer.WriteElementString("题目", oneTheme.ArrayTheme[i]);
                }
                writer.WriteEndElement();
            }
            Console.WriteLine("写入成功");
        }

    }
}
