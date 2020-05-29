using ConsoleApp2.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;

namespace FourOperationsTest
{
    [TestClass]
    public class OneClassTest
    {
        [TestMethod]

        public void ADDTheme()
        {
            OneTheme oneTheme = new OneTheme();
            oneTheme.AddTheme();
            double a = oneTheme.BasicDataA;
            double b = oneTheme.BasicDataB;
            Assert.IsTrue(a + b == oneTheme.Answer);
        }
        [TestMethod]
        public void SubTheme()
        {
            OneTheme oneTheme = new OneTheme();
            oneTheme.SubOutPutTxt();
            double a = oneTheme.BasicDataA;
            double b = oneTheme.BasicDataB;
            Assert.IsTrue(a - b == oneTheme.Answer);
        }
     
    }
}
