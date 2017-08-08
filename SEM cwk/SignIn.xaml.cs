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
        private Cook a = new Cook();
        private Cook b = new Cook();
        private Cook c = new Cook();

        private MainWindow mw;
        public SignIn( MainWindow mw_in)
        {
            InitializeComponent();
            
            mw = mw_in;
        }
        

        private void button_Click(object sender, RoutedEventArgs e)
        {
            a.Name = "c1";
            a.Password = "password";
            a.HygieneCert = "OK";
            a.Pvg = "AWAITING RESULT";
            a.H_Date = new DateTime(2017, 12, 25);
            
            b.Name = "c2";
            b.Password = "password";
            b.HygieneCert = "OK";
            b.Pvg = "REJECTED";
            b.H_Date = new DateTime(2017, 12, 25);

            c.Name = "c3";
            c.Password = "password";
            c.HygieneCert = "OK";
            c.Pvg = "OK";
            c.H_Date = new DateTime(2017, 12, 25);

            if (nameBox.Text == "c1")
            {
                CookerHub ch = new CookerHub(a, mw);
            }
            else if(nameBox.Text == "c2")
            {
                CookerHub ch = new CookerHub(b, mw);
            }
            else if (nameBox.Text == "c3")
            {
                CookerHub ch = new CookerHub(c, mw);
            }
            else
            {
                MessageBox.Show("input error");
            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Nope! Not in spec!");
        }
    }
}
