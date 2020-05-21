
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text;

namespace ConsoleApp2.Themeup
{
    public class ThreeTheme
    {
        readonly Random random = new Random();

        public string Multiplys { get; private set; }
        public string Divisions { get; private set; }
        public double DM { get; set; }
        public int C { get; set; }
        public int BasicDataA { get; }
        public int BasicDataB { get; }

        readonly List<string> list1 = new List<string> { "+", "-", "×", "÷" };

        /// <summary>
        /// 三年级.100以内的加减乘除,有负数，混合运算,例如3*10-5
        /// </summary>
        public ThreeTheme()
        {
            BasicDataA = random.Next(-100, 100);
            BasicDataB = random.Next(-100, 100);
            C = random.Next(0, 3);
        }


        public string Multiply()
        {
            try
            {

                if (BasicDataA > 200 && BasicDataB > 200)
                {
                    throw (new CustomExcepsion("A>200 &&B>200"));
                }

                else
                {
                    Multiplys = BasicDataA + "×" + BasicDataB;
                    DM = BasicDataA * BasicDataB;

                    return Multiplys;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Multiplys = null;

        }

        public string Division()
        {
            try
            {

                if (BasicDataA > 200 && BasicDataB > 200)
                {
                    throw (new CustomExcepsion("A>200 &&B>200"));
                }

                else
                {
                    Divisions = BasicDataA + "÷" + BasicDataB;
                    DM = BasicDataA / BasicDataB;
                    return Divisions;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return Divisions = null;


        }


        public string MultiplyAndDivision()
        {
            try
            {

                if (BasicDataA > 200 && BasicDataB > 200)
                {
                    throw (new CustomExcepsion("A>200 &&B>200"));
                }

                else
                {

                    Multiply();
                    double a1 = DM = BasicDataA * BasicDataB;
                    DM = 0;
                    Division();
                    double a2 = DM = BasicDataA / BasicDataB;
                    DM = 0;
                    DM = a1 + a2;

                    return Divisions + list1[C] + Multiplys;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return Divisions + Multiplys;
        }
    }
}
