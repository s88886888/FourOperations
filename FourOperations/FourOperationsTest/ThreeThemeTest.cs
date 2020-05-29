using ConsoleApp2.Base;
using ConsoleApp2.Themeup;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using Xunit.Sdk;

namespace FourOperationsTest
{
    [TestClass]
    public class ThreeClassTest
    {
        [TestMethod]

        public void ADDTheme()
        {
            ThreeTheme threeTheme = new ThreeTheme();
            threeTheme.AddTheme();
            double a = threeTheme.BasicDataA;
            double b = threeTheme.BasicDataB;
            Assert.IsTrue(a + b == threeTheme.Answer);
        }
        [TestMethod]
        public void SubTheme()
        {
            ThreeTheme threeTheme = new ThreeTheme();
            threeTheme.SubTheme();
            double a = threeTheme.BasicDataA;
            double b = threeTheme.BasicDataB;
            Assert.IsTrue(a - b == threeTheme.Answer);
        }
        [TestMethod]
        public void MultiplyTheme()
        {
            ThreeTheme threeTheme = new ThreeTheme();
            threeTheme.MultiplyTheme();
            double a = threeTheme.BasicDataA;
            double b = threeTheme.BasicDataB;
            Assert.IsTrue(a * b == threeTheme.Answer);
        }
        [TestMethod]
        public void DivisionTheme()
        {
            ThreeTheme threeTheme = new ThreeTheme();
            threeTheme.DivisionTheme();
            double a = threeTheme.BasicDataA;
            double b = threeTheme.BasicDataB;
            Assert.IsTrue(a / b == threeTheme.Answer);
        }
        [TestMethod]
        public void HybridOperation()
        {
            ThreeTheme threeTheme = new ThreeTheme();
            threeTheme.HybridOperation();
            var table = new DataTable();
            Assert.IsTrue(Convert.ToString(threeTheme.Answer) == Convert.ToString(table.Compute(threeTheme.Theme, null)));
        }



    }
}
