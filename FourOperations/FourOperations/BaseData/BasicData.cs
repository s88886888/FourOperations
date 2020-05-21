namespace ConsoleApp2
{
    public abstract  class BasicData : IBasicData
    {
        public int BasicDataA { get; set; } 
        public int BasicDataB { get; set; }
        public string Theme { get; set; }//题目
        public int Answer { get; set; }//答案
        public string FFF { get; private set; } = "=";

        public readonly string[] ArrayTheme = new string[10];//题目集合
        public readonly string[] ArrayAnswer = new string[10];//答案集合

        public abstract void AddThemeCount();

        public abstract void SubThemeCount();

        public abstract void AddTheme();

        public abstract void SubTheme();
    }
}
