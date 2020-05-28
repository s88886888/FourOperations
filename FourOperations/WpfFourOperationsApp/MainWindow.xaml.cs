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
        
        string[] vslist = new string[10];
        string[] vslist1 = new string[10];
        //public bool? IsChecked { get; set; }
        //public void ToggleButton()
        //{
        //    return;
        //}
        OneTheme oneTheme = new OneTheme();
        TwoTheme twoTheme = new TwoTheme();
        ThreeTheme threeTheme = new ThreeTheme();
        FourTheme fourTheme = new FourTheme();
        private void BtnSystem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnL1_Checked(object sender, RoutedEventArgs e)
        {
            btnL2.IsChecked = false;
            btnL3.IsChecked = false;
            btnL4.IsChecked = false;
            btnadd.IsEnabled = true;
            btnsub.IsEnabled = true;
        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            lbxQuestion.ItemsSource = "";
            if (btnL1.IsChecked == true)
            {
                
                oneTheme.AddThemeCount();
                for (int i = 0; i < oneTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = oneTheme.ArrayTheme[i];
                    vslist1[i] = oneTheme.ArrayAnswer[i];
                }
                lbxQuestion.ItemsSource = vslist;
            }
            else if(btnL2.IsChecked == true)
            {
                
                twoTheme.AddThemeCount();
                for (int i = 0; i < twoTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = twoTheme.ArrayTheme[i];
                    vslist1[i] = twoTheme.ArrayAnswer[i];
                }
                lbxQuestion.ItemsSource = vslist;

            }
            else if (btnL3.IsChecked == true)
            {

                threeTheme.AddThemeCount();
                for (int i = 0; i < threeTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = threeTheme.ArrayTheme[i];
                    vslist1[i] = threeTheme.ArrayAnswer[i];
                }
                lbxQuestion.ItemsSource = vslist;

            }
            else if (btnL4.IsChecked == true)
            {

                fourTheme.AddThemeCount();
                for (int i = 0; i < fourTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = fourTheme.ArrayTheme[i];
                    vslist1[i] = fourTheme.ArrayAnswer[i];
                }
                lbxQuestion.ItemsSource = vslist;

            }

        }

        private void btnsub_Click(object sender, RoutedEventArgs e)
        {

            if (btnL1.IsChecked == true)
            {
                oneTheme.SubThemeCount();

                for (int i = 0; i < oneTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = oneTheme.ArrayTheme[i];
                    vslist1[i] = oneTheme.ArrayAnswer[i];
                }
           
            lbxQuestion.ItemsSource = vslist; 
            }
            else if (btnL2.IsChecked == true)
            {

                twoTheme.SubThemeCount();
                for (int i = 0; i < twoTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = twoTheme.ArrayTheme[i];
                    vslist1[i] = twoTheme.ArrayAnswer[i];
                }
                lbxQuestion.ItemsSource = vslist;

            }
            else if (btnL3.IsChecked == true)
            {

                threeTheme.SubThemeCount();
                for (int i = 0; i < threeTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = threeTheme.ArrayTheme[i];
                    vslist1[i] = threeTheme.ArrayAnswer[i];
                }
                lbxQuestion.ItemsSource = vslist;

            }
            else if (btnL4.IsChecked == true)
            {

                fourTheme.SubThemeCount();
                for (int i = 0; i < fourTheme.ArrayTheme.Count; i++)
                {
                    vslist[i] = fourTheme.ArrayTheme[i];
                    vslist1[i] = fourTheme.ArrayAnswer[i];
                }
                lbxQuestion.ItemsSource = vslist;

            }
        }

        private void btnL2_Checked(object sender, RoutedEventArgs e)
        {
            btnL3.IsChecked = false;
            btnL4.IsChecked = false;
            btnL1.IsChecked = false;
            btnadd.IsEnabled = true;
            btnsub.IsEnabled = true;
        }

        private void btnL4_Checked(object sender, RoutedEventArgs e)
        {
            btnL2.IsChecked = false;
            btnL3.IsChecked = false;
            btnL1.IsChecked = false;
            btnadd.IsEnabled = true;
            btnsub.IsEnabled = true;
        }

        private void btnL3_Checked(object sender, RoutedEventArgs e)
        {
            btnL2.IsChecked = false;
            btnL1.IsChecked = false;
            btnL4.IsChecked = false;
            btnadd.IsEnabled = true;
            btnsub.IsEnabled = true;
        }

        private void btnsubmit_Click(object sender, RoutedEventArgs e)
        {
            if (txtAnswer1.Text == vslist1[0])
            {
                txtJudge1.Text = "正确";

            }
             else if  (txtAnswer1.Text != vslist1[0])
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
            else if (txtAnswer10.Text != vslist1[9])
            {
                txtJudge10.Text = "×";

            }
        }
    }
}
