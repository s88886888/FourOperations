
using System;
using System.Collections.Generic;
using System.Xml;

namespace ConsoleApp2
{
    public abstract class BasicData : IBasicData
    {
        public double BasicDataA { get; set; }
        public double BasicDataB { get; set; }
        public double BasicDataC { get; set; }
        public double BasicDataD { get; set; }
        public int LsitNumA { get; set; }
        public int LsitNumB { get; set; }
        public int LsitNumC { get; set; }
        public string Theme { get; set; }//题目
        public double Answer { get; set; }//答案
        protected string FFF { get; set; } = "=";

        public List<string> CCC = new List<string> { "+", "-", "*", "/" };

        public List<string> tempTheme = new List<string>();
        public List<string> tempAnswer = new List<string>();

        public readonly List<string> ArrayTheme = new List<string>();//题目集合
        public readonly List<string> ArrayAnswer = new List<string>();//答案集合

        //读取xml 文本 的题目和答案
        public List<string> vsArrayTheme = new List<string>();
        public List<string> vsArrayAnswer = new List<string>();

        public abstract void RandomNumber();

        public abstract void AddThemeCount();

        public abstract void SubThemeCount();

        public abstract void AddTheme();

        public abstract void SubTheme();

        public void OutPutTxt(string result)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create("..\\..\\..\\", settings))
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
        /// 输出10道题目和答案Date
        /// </summary>
        /// <param name="Array1"></param>
        /// <param name="Array2"></param>
        public void Show(string[] Array1, string[] Array2)
        {
            for (int i = 0; i < Array1.Length; i++)
            {
                Console.Write(Array1[i]);
                Console.WriteLine("=" + Array2[i]);
            }
        }
    }
}
