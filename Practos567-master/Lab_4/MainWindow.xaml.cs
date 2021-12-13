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
using Lab_4;

namespace Lab_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Para firstpara;
        Para secondpara;
        bool rez_1;
        bool rez_2;
        private void FirstPairAdd(object sender, RoutedEventArgs e)
        {
            firstpara = new Para();
            firstpara.FirstNum = Convert.ToInt32(value11.Text);
            firstpara.SecondNum = Convert.ToInt32(value12.Text);
        }

        private void Compare_Click(object sender, RoutedEventArgs e)
        {
            rez_1 = firstpara.CompareFirst(secondpara);
            rez_2 = firstpara.CompareSecond(secondpara);
            result1.Text = Convert.ToString(rez_1);
            result2.Text = Convert.ToString(rez_2);
        }

        private void SecondPairAdd(object sender, RoutedEventArgs e)
        {
            secondpara = new Para();
            secondpara.FirstNum = Convert.ToInt32(value21.Text);
            secondpara.SecondNum = Convert.ToInt32(value22.Text);
        }

        private void FirstPairClear(object sender, RoutedEventArgs e)
        {
            value11.Text = "";
            value12.Text = "";
            firstpara.FirstNum = 0;
            firstpara.SecondNum = 0;

        }

        private void SecondPairClear(object sender, RoutedEventArgs e)
        {
            value21.Text = "";
            value22.Text = "";
            secondpara.FirstNum = 0;
            secondpara.SecondNum = 0;
        }

        private void Comper(object sender, RoutedEventArgs e)
        {

        }
        //практическая №6
        private void CompareSecond_Click(object sender, RoutedEventArgs e)
        {
            rez_1 = firstpara >= secondpara;
            rez_2 = firstpara > secondpara;
            rez1.Text = Convert.ToString(rez_1);
            rez2.Text = Convert.ToString(rez_2);
        }

        private void FirstPairAdd_2(object sender, RoutedEventArgs e)
        {
            firstpara = new Para();
            firstpara.FirstNum = Convert.ToInt32(val11.Text);
            firstpara.SecondNum = Convert.ToInt32(val12.Text);
        }

        private void SecondPairAdd_2(object sender, RoutedEventArgs e)
        {
            secondpara = new Para();
            secondpara.FirstNum = Convert.ToInt32(val21.Text);
            secondpara.SecondNum = Convert.ToInt32(val22.Text);
        }
        //практическая №7
        Faction firstfaction;
        Faction secondfaction;
        Faction faction = new Faction();
        private void FirstPairAdd_3(object sender, RoutedEventArgs e)
        {
            firstfaction = new Faction();
            firstfaction.FirstNum = Convert.ToInt32(va11.Text);
            firstfaction.SecondNum = Convert.ToInt32(va12.Text);
        }

        private void SecondPairAdd_3(object sender, RoutedEventArgs e)
        {
            secondfaction = new Faction();
            secondfaction.FirstNum = Convert.ToInt32(va21.Text);
            secondfaction.SecondNum = Convert.ToInt32(va22.Text);
        }

        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            
           faction= firstfaction.SumEd(secondfaction);
            re1.Text = Convert.ToString(faction.FirstNum);
            re2.Text = Convert.ToString(faction.SecondNum);
        }
    }
}
