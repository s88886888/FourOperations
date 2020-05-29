using ConsoleApp2.Base;
using ConsoleApp2.Themeup;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;

namespace FourOperationsTest
{
    [TestClass]
    public class TwoClass
    {
        [TestMethod]

        public void ADDTheme()
        {
            TwoTheme twoTheme = new TwoTheme();
            twoTheme.AddTheme();
            double a = twoTheme.BasicDataA;
            double b = twoTheme.BasicDataB;
            Assert.IsTrue(a + b == twoTheme.Answer);
        }
        [TestMethod]
        public void SubTheme()
        {
            TwoTheme twoTheme = new TwoTheme();
            twoTheme.SubOutPutTxt();
            double a = twoTheme.BasicDataA;
            double b = twoTheme.BasicDataB;
            Assert.IsTrue(a - b == twoTheme.Answer);
        }

    }
}
