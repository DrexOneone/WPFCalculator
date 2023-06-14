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

namespace WpfCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _entries;
     
        public string Entries
        {
            get
            {
                return _entries;
            }
            set
            {
                _entries = value;
                UpdateText();
            }
        }
        
        public MainWindow()
        {
            DataContext = this;
            
            InitializeComponent();
        }
        
        private void Button1_Click(object sender, RoutedEventArgs e)
        {

            Entries += '1'; 
           
        }
        
        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            Entries += '0';
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Entries += '2';
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Entries += '3';
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Entries += '4';
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            Entries += '5';
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            Entries += '6';
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            Entries += '7';
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            Entries += '8';
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            Entries += '9';
        }

        private void ButtonAC_Click(object sender, RoutedEventArgs e)
        {
            Entries = string.Empty;
        }

        private void Buttonsubtract_Click(object sender, RoutedEventArgs e)
        {
            Entries += '-';
        }

        private void Buttonadd_Click(object sender, RoutedEventArgs e)
        {
            Entries += '+';
        }

        private void Buttonequals_Click(object sender, RoutedEventArgs e)
        {
            

       
        }
        
        private void UpdateText()
        {
            TextBlockOutput.Text = Entries;
        }
    }
}
