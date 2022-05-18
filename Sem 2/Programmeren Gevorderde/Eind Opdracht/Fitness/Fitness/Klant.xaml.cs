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
using System.Windows.Shapes;

namespace Fitness
{
    /// <summary>
    /// Interaction logic for Klant.xaml
    /// </summary>
    public partial class Klant : Window
    {
        public Klant(List<string> dataList)
        {
            InitializeComponent();
            Txt_FirstName.Text = dataList[0];
            Txt_Name.Text = dataList[1];
            Txt_Place.Text = dataList[3];
            Txt_Date.Text = dataList[4];
            Txt_Interest.Text = dataList[5];
            Txt_Subsciption.Text = dataList[6];
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}