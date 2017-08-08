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
    /// Interaction logic for Account.xaml
    /// </summary>
    public partial class Account : Window
    {
        Cook c;
        public Account(Cook c_in)
        {
            InitializeComponent();
            c = c_in;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            c.Name = tb1.Text;
            c.Password = tb2.Text;
            MessageBox.Show("Details Updated.");
            this.Close();
        }
    }
}
