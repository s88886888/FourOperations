using System.Collections.Generic;

namespace ConsoleApp2
{
    public abstract  class BasicData : IBasicData
    {
        public int BasicDataA { get; set; }
        public int BasicDataB { get; set; }
        protected string Theme { get; set; }//题目
        protected int Answer { get; set; }//答案
        protected  string FFF { get; set; } = "=";

        protected readonly List<string> ArrayTheme = new List<string>();//题目集合
        protected readonly List<string> ArrayAnswer = new List<string>();//答案集合

        //读取xml 文本 的题目和答案
        protected List<string> vsArrayTheme = new List<string>();
        protected List<string> vsArrayAnswer = new List<string>();

        public abstract void RandomNumber();

        public abstract void AddThemeCount();

        public abstract void SubThemeCount();

        public abstract void AddTheme();

        public abstract void SubTheme();
    }
}
