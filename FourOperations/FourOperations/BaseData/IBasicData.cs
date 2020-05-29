using ConsoleApp2.Themeup;
using NPOI.SS.Formula.Functions;
using System;

namespace ConsoleApp2
{
     interface IBasicData
    {
        double BasicDataA { get; }
        double BasicDataB { get; }

        void AddThemeCount();

        void SubThemeCount();
        void AddTheme();

        void SubTheme();
        void OutPutTxt(string result);
    }
}
