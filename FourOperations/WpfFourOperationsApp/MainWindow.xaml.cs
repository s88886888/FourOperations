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
            btnL2.IsChecked = false;
            btnL3.IsChecked = false;
            btnL4.IsChecked = false;
            btnadd.IsEnabled = true;
            btnsub.IsEnabled = true;
            BtnClose();
        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {

            lbxQuestion.Items.Clear();
            //Array.Clear(vslist, 0, vslist.Length);
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

            }

        }

        private void btnsub_Click(object sender, RoutedEventArgs e)
        {
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
        }

        private void btnL2_Checked(object sender, RoutedEventArgs e)
        {

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
        }

        private void btnL4_Checked(object sender, RoutedEventArgs e)
        {
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

                }
                else if (txtAnswer1.Text != vslist1[0])
                {
                    txtJudge1.Text = "×";

                }

                if (txtAnswer2.Text == vslist1[1])
                {
                    txtJudge2.Text = "正确";

                }
                else if (txtAnswer2.Text != vslist1[1])
                {
                    txtJudge2.Text = "×";

                }

                if (txtAnswer3.Text == vslist1[2])
                {
                    txtJudge3.Text = "正确";

                }
                else if (txtAnswer3.Text != vslist1[2])
                {
                    txtJudge3.Text = "×";

                }

                if (txtAnswer4.Text == vslist1[3])
                {
                    txtJudge4.Text = "正确";

                }
                else if (txtAnswer4.Text != vslist1[3])
                {
                    txtJudge4.Text = "×";

                }

                if (txtAnswer5.Text == vslist1[4])
                {
                    txtJudge5.Text = "正确";

                }
                else if (txtAnswer5.Text != vslist1[4])
                {
                    txtJudge5.Text = "×";

                }

                if (txtAnswer6.Text == vslist1[5])
                {
                    txtJudge6.Text = "正确";

                }
                else if (txtAnswer6.Text != vslist1[5])
                {
                    txtJudge6.Text = "×";

                }

                if (txtAnswer7.Text == vslist1[6])
                {
                    txtJudge7.Text = "正确";

                }
                else if (txtAnswer7.Text != vslist1[6])
                {
                    txtJudge7.Text = "×";

                }

                if (txtAnswer8.Text == vslist1[7])
                {
                    txtJudge8.Text = "正确";

                }
                else if (txtAnswer8.Text != vslist1[7])
                {
                    txtJudge8.Text = "×";

                }

                if (txtAnswer9.Text == vslist1[8])
                {
                    txtJudge9.Text = "正确";

                }
                else if (txtAnswer9.Text != vslist1[8])
                {
                    txtJudge9.Text = "×";

                }

                if (txtAnswer10.Text == vslist1[9])
                {
                    txtJudge10.Text = "正确";

                }
                else 
                if (txtAnswer10.Text != vslist1[9])
                {
                    txtJudge10.Text = "×";

                }
            }
        }

        private void btnmul_Click(object sender, RoutedEventArgs e)
        {
            lbxQuestion.Items.Clear();

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


            }
        }

        private void btnO_Click(object sender, RoutedEventArgs e)
        {
            lbxQuestion.Items.Clear();
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
        }

        private void BtnAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("阿宽出品，必属精品", "正道的光");
        }

        private void BtnAgain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
           
        }

        private void btndiv_Click(object sender, RoutedEventArgs e)
        {
            lbxQuestion.Items.Clear();

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

        private void BtnHelp_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe","http://www.baidu.com");
        }
    }
}
