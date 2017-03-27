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

namespace SEM_cwk
{
    /// <summary>
    /// Interaction logic for SignIn.xaml
    /// </summary>
    public partial class SignIn : Page
    {
        private Cook c;
        private MainWindow mw;
        public SignIn(Cook cookAccount, MainWindow mw_in)
        {
            InitializeComponent();
            c = cookAccount;
            mw = mw_in;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (nameBox.Text == c.Name && passBox.Text == c.Password)
            {
                CookerHub ch = new CookerHub(c, mw);
                mw.Content = ch;
            }
            else
            {
                MessageBox.Show("Incorrect login details!");
            }
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Nope! Not in spec!");
        }
    }
}
