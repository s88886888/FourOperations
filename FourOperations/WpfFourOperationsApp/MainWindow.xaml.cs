using ConsoleApp2.Base;
using ConsoleApp2.Themeup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfFourOperationsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private double R;
        private double S;
        private int J;
        private int w;
        private readonly string[] vslist = new string[10];
        private readonly string[] vslist1 = new string[10];
        //public bool? IsChecked { get; set; }
        //public void ToggleButton()
        //{
        //    return;
        //}
        OneTheme oneTheme = new OneTheme();
        TwoTheme twoTheme = new TwoTheme();
        ThreeTheme threeTheme = new ThreeTheme();
        FourTheme fourTheme = new FourTheme();

        private void btnL1_Checked(object sender, RoutedEventArgs e)
        {
            J = 1;
            btnL2.IsChecked = false;
            btnL3.IsChecked = false;
            btnL4.IsChecked = false;
            btnadd.IsEnabled = true;
            btnsub.IsEnabled = true;
            BtnClose();
        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            w = 1;
            lbxQuestion.Items.Clear();
            Array.Clear(vslist, 0, vslist.Length);
            if (btnL1.IsChecked == true)
            {
                OneTheme oneTheme = new OneTheme();
                oneTheme.AddThemeCount();
                for (int i = 0; i < oneTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = oneTheme.ArrayTheme[i];
                    vslist1[i] = oneTheme.ArrayAnswer[i];
                    lbxQuestion.Items.Add(vslist[i]);

                }


            }
            else if (btnL2.IsChecked == true)
            {

                TwoTheme twoTheme = new TwoTheme();
                twoTheme.AddThemeCount();
                for (int i = 0; i < twoTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = twoTheme.ArrayTheme[i];
                    vslist1[i] = twoTheme.ArrayAnswer[i];
                    lbxQuestion.Items.Add(vslist[i]);
                }

                twoTheme.AddOutPutTxt();
            }
            else if (btnL3.IsChecked == true)
            {

                ThreeTheme threeTheme = new ThreeTheme();
                threeTheme.AddThemeCount();
                for (int i = 0; i < threeTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = threeTheme.ArrayTheme[i];
                    vslist1[i] = threeTheme.ArrayAnswer[i];
                    lbxQuestion.Items.Add(vslist[i]);
                }

                threeTheme.AddOutPutTxt();
            }
            else if (btnL4.IsChecked == true)
            {

                FourTheme fourTheme = new FourTheme();
                fourTheme.AddThemeCount();
                for (int i = 0; i < fourTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = fourTheme.ArrayTheme[i];
                    vslist1[i] = fourTheme.ArrayAnswer[i];
                    lbxQuestion.Items.Add(vslist[i]);
                }
                fourTheme.AddOutPutTxt();
            }

        }//加法

        private void btnsub_Click(object sender, RoutedEventArgs e)
        {
            w = 2;
            lbxQuestion.Items.Clear();

            if (btnL1.IsChecked == true)
            {

                OneTheme oneTheme = new OneTheme();
                oneTheme.SubThemeCount();

                for (int i = 0; i < oneTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = oneTheme.ArrayTheme[i];
                    vslist1[i] = oneTheme.ArrayAnswer[i];
                    lbxQuestion.Items.Add(vslist[i]);
                }


            }
            else if (btnL2.IsChecked == true)
            {
                TwoTheme twoTheme = new TwoTheme();
                twoTheme.SubThemeCount();
                for (int i = 0; i < twoTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = twoTheme.ArrayTheme[i];
                    vslist1[i] = twoTheme.ArrayAnswer[i];
                    lbxQuestion.Items.Add(vslist[i]);
                }


            }
            else if (btnL3.IsChecked == true)
            {
                ThreeTheme threeTheme = new ThreeTheme();
                threeTheme.SubThemeCount();
                for (int i = 0; i < threeTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = threeTheme.ArrayTheme[i];
                    vslist1[i] = threeTheme.ArrayAnswer[i];
                    lbxQuestion.Items.Add(vslist[i]);
                }


            }
            else if (btnL4.IsChecked == true)
            {
                FourTheme fourTheme = new FourTheme();
                fourTheme.SubThemeCount();
                for (int i = 0; i < fourTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = fourTheme.ArrayTheme[i];
                    vslist1[i] = fourTheme.ArrayAnswer[i];
                    lbxQuestion.Items.Add(vslist[i]);
                }


            }
        }//减法

        private void btnL2_Checked(object sender, RoutedEventArgs e)
        {
            J = 2;
            btnL3.IsChecked = false;
            btnL4.IsChecked = false;
            btnL1.IsChecked = false;
            btnadd.IsEnabled = true;
            btnsub.IsEnabled = true;
            BtnClose();

        }

        private void BtnClose()
        {
            lbxQuestion.Items.Clear();
            btnO.IsEnabled = false;
            btndiv.IsEnabled = false;
            btnmul.IsEnabled = false;
            btnHybrid.IsEnabled = false;
        }//关闭摁键的方法

        private void btnL4_Checked(object sender, RoutedEventArgs e)
        {
            J = 4;
            lbxQuestion.Items.Clear();
            btnL2.IsChecked = false;
            btnL3.IsChecked = false;
            btnL1.IsChecked = false;
            btnadd.IsEnabled = true;
            btnsub.IsEnabled = true;
            btnO.IsEnabled = true;
            btndiv.IsEnabled = true;
            btnmul.IsEnabled = true;
            btnHybrid.IsEnabled = true;
        }

        private void btnL3_Checked(object sender, RoutedEventArgs e)
        {
            J = 3;
            lbxQuestion.Items.Clear();
            btnL2.IsChecked = false;
            btnL1.IsChecked = false;
            btnL4.IsChecked = false;
            btnO.IsEnabled = false;
            btnadd.IsEnabled = true;
            btnsub.IsEnabled = true;
            btndiv.IsEnabled = true;
            btnmul.IsEnabled = true;
            btnHybrid.IsEnabled = true;

        }

        private void btnsubmit_Click(object sender, RoutedEventArgs e)
        {

            if (lbxQuestion == null) { return; }
            else
            {
                if (txtAnswer1.Text == vslist1[0])
                {
                    txtJudge1.Text = "正确";
                    R++;
                }
                else if (txtAnswer1.Text != vslist1[0])
                {
                    txtJudge1.Text = "×";

                }

                if (txtAnswer2.Text == vslist1[1])
                {
                    txtJudge2.Text = "正确";
                    R++;
                }
                else if (txtAnswer2.Text != vslist1[1])
                {
                    txtJudge2.Text = "×";

                }

                if (txtAnswer3.Text == vslist1[2])
                {
                    txtJudge3.Text = "正确";
                    R++;
                }
                else if (txtAnswer3.Text != vslist1[2])
                {
                    txtJudge3.Text = "×";

                }

                if (txtAnswer4.Text == vslist1[3])
                {
                    txtJudge4.Text = "正确";
                    R++;
                }
                else if (txtAnswer4.Text != vslist1[3])
                {
                    txtJudge4.Text = "×";

                }

                if (txtAnswer5.Text == vslist1[4])
                {
                    txtJudge5.Text = "正确";
                    R++;
                }
                else if (txtAnswer5.Text != vslist1[4])
                {
                    txtJudge5.Text = "×";

                }

                if (txtAnswer6.Text == vslist1[5])
                {
                    txtJudge6.Text = "正确";
                    R++;
                }
                else if (txtAnswer6.Text != vslist1[5])
                {
                    txtJudge6.Text = "×";

                }

                if (txtAnswer7.Text == vslist1[6])
                {
                    txtJudge7.Text = "正确";
                    R++;
                }
                else if (txtAnswer7.Text != vslist1[6])
                {
                    txtJudge7.Text = "×";

                }

                if (txtAnswer8.Text == vslist1[7])
                {
                    txtJudge8.Text = "正确";
                    R++;
                }
                else if (txtAnswer8.Text != vslist1[7])
                {
                    txtJudge8.Text = "×";

                }

                if (txtAnswer9.Text == vslist1[8])
                {
                    txtJudge9.Text = "正确";
                    R++;
                }
                else if (txtAnswer9.Text != vslist1[8])
                {
                    txtJudge9.Text = "×";

                }

                if (txtAnswer10.Text == vslist1[9])
                {
                    txtJudge10.Text = "正确";
                    R++;
                }
                else
                if (txtAnswer10.Text != vslist1[9])
                {
                    txtJudge10.Text = "×";

                }
                S = R / 10 * 100;
                txt.Text = Convert.ToString(S) + "%";
            }
        }//判断对错

        private void btnmul_Click(object sender, RoutedEventArgs e)//乘法
        {
            lbxQuestion.Items.Clear();
            w = 3;
            if (btnL3.IsChecked == true)
            {
                ThreeTheme threeTheme = new ThreeTheme();
                threeTheme.MultiplyThemeCount();
                for (int i = 0; i < threeTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = threeTheme.ArrayTheme[i];
                    vslist1[i] = threeTheme.ArrayAnswer[i];
                    lbxQuestion.Items.Add(vslist[i]);
                }

                threeTheme.AddOutPutTxt();
            }
            else if (btnL4.IsChecked == true)
            {
                FourTheme fourTheme = new FourTheme();
                fourTheme.MultiplyThemeCount();
                for (int i = 0; i < fourTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = fourTheme.ArrayTheme[i];
                    vslist1[i] = fourTheme.ArrayAnswer[i];
                    lbxQuestion.Items.Add(vslist[i]);
                }

                fourTheme.AddOutPutTxt();
            }
        }

        private void btnO_Click(object sender, RoutedEventArgs e)//四则
        {
            lbxQuestion.Items.Clear();
            w = 6;
            FourTheme fourTheme = new FourTheme();
            fourTheme.FourOperationsThemeCount();
            for (int i = 0; i < fourTheme.ArrayTheme.Count; i++)
            {
                vslist[i] = fourTheme.ArrayTheme[i];
                vslist1[i] = fourTheme.ArrayAnswer[i];
                lbxQuestion.Items.Add(vslist[i]);
            }
        }

        private void btnHybrid_Click(object sender, RoutedEventArgs e)
        {
            lbxQuestion.Items.Clear();
            w = 5;
            if (btnL3.IsChecked == true)
            {
                ThreeTheme threeTheme = new ThreeTheme();
                threeTheme.HybridOperationCount();
                for (int i = 0; i < threeTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = threeTheme.ArrayTheme[i];
                    vslist1[i] = threeTheme.ArrayAnswer[i];
                    lbxQuestion.Items.Add(vslist[i]);
                }


            }
            else if (btnL4.IsChecked == true)
            {
                FourTheme fourTheme = new FourTheme();
                fourTheme.HybridOperationThemeCount();
                for (int i = 0; i < fourTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = fourTheme.ArrayTheme[i];
                    vslist1[i] = fourTheme.ArrayAnswer[i];
                    lbxQuestion.Items.Add(vslist[i]);
                }


            }
        }//混合

        private void BtnAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("阿宽出品，必属精品", "正道的光");
        }//关于

        private void BtnAgain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();

        }

        private void btndiv_Click(object sender, RoutedEventArgs e)//除法
        {
            lbxQuestion.Items.Clear();
            w = 4;
            if (btnL3.IsChecked == true)
            {
                ThreeTheme threeTheme = new ThreeTheme();
                threeTheme.DivisionThemeCount();
                for (int i = 0; i < threeTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = threeTheme.ArrayTheme[i];
                    vslist1[i] = threeTheme.ArrayAnswer[i];
                    lbxQuestion.Items.Add(vslist[i]);
                }


            }
            else if (btnL4.IsChecked == true)
            {
                FourTheme fourTheme = new FourTheme();
                fourTheme.DivisionThemeCount();
                for (int i = 0; i < fourTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = fourTheme.ArrayTheme[i];
                    vslist1[i] = fourTheme.ArrayAnswer[i];
                    lbxQuestion.Items.Add(vslist[i]);
                }


            }
        }

        private void BtnHelp_Click(object sender, RoutedEventArgs e)//帮助
        {
            System.Diagnostics.Process.Start("explorer.exe", "http://www.baidu.com");
        }

        private void btnPrinting_Click(object sender, RoutedEventArgs e)
        {
            if (w == 1)
            {
                for (int i = 0; i < vslist.Length; i++)
                {
                    oneTheme.ArrayTheme.Add(vslist[i]);
                    oneTheme.ArrayAnswer.Add(vslist1[i]);
                }
                if (J == 1)
                {
                    oneTheme.AddOutPutTxt();
                }
                else if (J == 2)
                {
                    TwoTheme twoTheme = new TwoTheme();
                    twoTheme.AddOutPutTxt();
                }
                else if (J == 3)
                {
                    ThreeTheme threeTheme = new ThreeTheme();
                    threeTheme.AddOutPutTxt();
                }
                else if (J == 4)
                {
                    FourTheme fourTheme = new FourTheme();
                    fourTheme.AddOutPutTxt();

                }


            }
            else if (w == 2)
            {
                oneTheme.AddOutPutTxt();
                if (J == 1)
                {
                    OneTheme oneTheme = new OneTheme();
                    oneTheme.SubOutPutTxt();
                }
                else if (J == 2)
                {
                    TwoTheme twoTheme = new TwoTheme();
                    twoTheme.SubOutPutTxt();
                }
                else if (J == 3)
                {
                    ThreeTheme threeTheme = new ThreeTheme();
                    threeTheme.SubOutPutTxt();
                }
                else if (J == 4)
                {
                    FourTheme fourTheme = new FourTheme();
                    fourTheme.SubOutPutTxt();

                }
            }
            else if (w == 3)
            {

                FourTheme fourTheme = new FourTheme();
                fourTheme.MultiplyOutPutTxt();

            }
            else if (w == 4)
            {
                FourTheme fourTheme = new FourTheme();
                fourTheme.DivisionOutPutTxt();
            }
            else if (w == 5)
            {
                if (J == 3)
                {
                    ThreeTheme threeTheme = new ThreeTheme();
                    threeTheme.MultiplyAndDivisionThemeOutPutTxt();
                }
                else if (J == 4)
                {
                    FourTheme fourTheme = new FourTheme();
                    fourTheme.HybridOperationThemeOutPutTxt();

                }
            }
            else if (w == 6)
            {



                FourTheme fourTheme = new FourTheme();
                fourTheme.FourOperationsThemeOutPutTxt();


            }




        }

        private void Wrongbook_Click(object sender, RoutedEventArgs e)
        {
            List<string> list = new List<string>();
            list.Add(Convert.ToString(txtJudge1));
            list.Add(Convert.ToString(txtJudge2));
            list.Add(Convert.ToString(txtJudge3));
            list.Add(Convert.ToString(txtJudge4));
            list.Add(Convert.ToString(txtJudge5));
            list.Add(Convert.ToString(txtJudge6));
            list.Add(Convert.ToString(txtJudge7));
            list.Add(Convert.ToString(txtJudge8));
            list.Add(Convert.ToString(txtJudge9));
            list.Add(Convert.ToString(txtJudge10));
            oneTheme.tempAnswer = list;
            oneTheme.ErrorsText();
        }
    }
}
