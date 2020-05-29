using ConsoleApp2.Base;
using ConsoleApp2.Themeup;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;

namespace FourOperationsTest
{
    [TestClass]
    public class FourClassTest
    {
        [TestMethod]

        public void ADDTheme()
        {
            FourTheme fourTheme = new FourTheme();
            fourTheme.AddTheme();
            double a = fourTheme.BasicDataA;
            double b = fourTheme.BasicDataB;
            Assert.IsTrue(a + b == fourTheme.Answer);
        }



    }
}
