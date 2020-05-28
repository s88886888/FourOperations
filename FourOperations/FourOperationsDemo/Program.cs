
using ConsoleApp2.Base;
using ConsoleApp2.Themeup;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FourOperations
{
    class Program
    {

        static void Main(string[] args)
        {

            FourTheme fourTheme = new FourTheme();
            fourTheme.AddThemeCount();
            fourTheme.AddOutPutTxt();

        }
    }
}
