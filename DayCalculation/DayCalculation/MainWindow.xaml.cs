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

namespace DayCalculation
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

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
                //recieve data from screen
                double inc, exp, stf;

                inc = Convert.ToDouble(Income.Text);
                exp = Convert.ToDouble(Expenditure.Text);
                stf = Convert.ToDouble(Stuff.Text);

                //convert integer or...etc to string
                string day = Convert.ToString(Math.Ceiling(stf / (inc - exp)));

                //report string to screen
                NumberDay.Text = day;
            
                                    
        }
                
    }
}
