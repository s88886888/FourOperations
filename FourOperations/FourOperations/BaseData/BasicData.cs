namespace ConsoleApp2
{
    public abstract  class BasicData : IBasicData
    {
        public int BasicDataA { get; set; }
        public int BasicDataB { get; set; }
        protected string Theme { get; set; }//题目
        protected int Answer { get; set; }//答案
        protected  string FFF { get; set; } = "=";

        protected readonly string[] ArrayTheme = new string[10];//题目集合
        protected readonly string[] ArrayAnswer = new string[10];//答案集合

        public abstract void RandomNumber();

        public abstract void AddThemeCount();

        public abstract void SubThemeCount();

        public abstract void AddTheme();

        public abstract string  SubTheme();
    }
}
