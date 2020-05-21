using ConsoleApp2;
using ConsoleApp2.Base;
using ConsoleApp2.Themeup;
using System;
using System.Collections.Generic;
using System.Text;

namespace FourOperationsDemo.BaseDate
{
    public class IBasicTheme : BasicData
    {
        private readonly IAddandSubTheme _addandSubTheme;

        private readonly IMultiplyAndDivisionTheme _multiplyAndDivisionTheme;

        public IBasicTheme (IAddandSubTheme addandSubTheme, IMultiplyAndDivisionTheme multiplyAndDivisionTheme)
        {
            _addandSubTheme = addandSubTheme;
            _multiplyAndDivisionTheme = multiplyAndDivisionTheme;
        }
        public IBasicTheme()
        {

        }
        public void AddandSubTheme()
        {
            _addandSubTheme.AddTheme();
            _addandSubTheme.SubTheme();
        }
        public void MultiplyAndDivisionTheme()
        {
            _multiplyAndDivisionTheme.Multiply();
            _multiplyAndDivisionTheme.Division();
        }
    }
}
