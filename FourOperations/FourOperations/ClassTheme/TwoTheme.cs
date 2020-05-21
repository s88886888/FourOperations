
using System;

namespace ConsoleApp2.Themeup
{
    public class TwoTheme 
    {
        readonly Random random = new Random();



        public int DM { get; private set; }
        public string Add { get; private set; }
        public string Sub { get; private set; }
        public int BasicDataA { get; set; }
        public int BasicDataB { get; set; }

        /// <summary>
        /// 二年级出题范围100以内加减
        /// </summary>
        public TwoTheme()
        {
            BasicDataA = random.Next(0, 100);
            BasicDataB = random.Next(0, 100);
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


    }
}
