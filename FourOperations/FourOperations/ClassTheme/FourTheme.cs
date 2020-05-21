using ConsoleApp2.Base;
using FourOperationsDemo.BaseDate;
using System;
using System.Collections.Generic;
using System.Data;

namespace ConsoleApp2.Themeup
{
    public class FourTheme :  IBasicTheme
    {
        readonly Random random = new Random();

        public string Sub { get; private set; }
        public string Add { get; private set; }
        public string Multiplys { get; private set; }
        public string Divisions { get; private set; }
        public double DM { get; private set; }
        public int C { get; }
        public int Z { get; }
        public int Y { get; }
        public int D { get; set; }

        public int E { get; set; }

        public string Four { get; set; }
        public object Doublea { get; set; }

        readonly List<string> list1 = new List<string>() { "+", "-", "×", "÷" };



        /// <summary>
        /// 200以内有负数，分数，四则运算10*1+5*3
        /// </summary>
        public FourTheme()
        {
            BasicDataA = random.Next(-200, 200);
            BasicDataB = random.Next(-200, 200);
            C = random.Next(0, 3);
            Z = random.Next(0, 3);
            Y = random.Next(0, 3);
            E = random.Next(-200, 200);
            D = random.Next(-200, 200);
        }
        public string AddTheme()
        {
            try
            {
                if (BasicDataA > 20 && BasicDataB > 20)
                {
                    throw new Exception("A>20 并且 B>20");
                }
                else
                {
                    Add = BasicDataA + "+" + BasicDataB;
                    DM = BasicDataA + BasicDataB;
                    return Add;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Add = null;

        }
        public string SubTheme()
        {
            try
            {
                if (BasicDataA > 20 && BasicDataB > 20)
                {
                    throw new Exception("A>20 并且 B>20");
                }
                else
                {
                    if (BasicDataA > BasicDataB)
                    {
                        Sub = BasicDataA + "-" + BasicDataB;
                    }
                    else
                    {
                        BasicDataA += BasicDataB;
                        BasicDataB = BasicDataA - BasicDataB;
                        BasicDataA -= BasicDataB;
                        Sub = BasicDataA + "-" + BasicDataB;
                    }
                    DM = BasicDataA + BasicDataB;
                    return Sub;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Sub = null;





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

                if (BasicDataA > 200 && BasicDataB > 200 || BasicDataA < -200 && BasicDataB < -200)
                {
                    throw (new CustomExcepsion("A>200 &&B>200"));
                }

                else
                {
                    DataTable dt = new DataTable();                  
                    Four = BasicDataA + list1[Z] + BasicDataB + list1[C] + D + list1[Y] + E;
                    //核心代码
                    Doublea = dt.Compute("BasicDataA + list1[Z] + BasicDataB + list1[C] + D + list1[Y] + E+", "false");               
                    return Four;
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
