using System;

namespace ConsoleApp2
{
     interface IBasicData
    {
         int BasicDataA { get; }
         int BasicDataB { get; }

        void AddThemeCount();

        void SubThemeCount();
        void AddTheme();

        void SubTheme();


    }
}
