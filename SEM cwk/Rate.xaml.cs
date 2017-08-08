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

namespace SEM_cwk
{
    /// <summary>
    /// Interaction logic for Rate.xaml
    /// </summary>
    public partial class Rate : Window
    {
        Cook c;
        public Rate(Cook c_in)
        {
            InitializeComponent();
            c = c_in;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            c.RateMeal(Convert.ToInt32(rating.Text));
            this.Close();
        }
    }
}
