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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Cook a = new Cook();
        private Cook b = new Cook();
        private Cook c = new Cook();
        

        public MainWindow()
        {
            InitializeComponent();
            MainWindow mw = this;

            a.Name = "c1";
            a.Password = "password";
            a.HygieneCert = "OK";
            a.Pvg = "Awaiting Result";

            //both run out on christmas
            a.H_Date = new DateTime(2017, 12, 25);
            


            b.Name = "c2";
            b.Password = "password";
            b.HygieneCert = "OK";
            b.Pvg ="Rejected";

            //both run out on christmas
            b.H_Date = new DateTime(2017, 12, 25);

            c.Name = "c3";
            c.Password = "password";
            c.HygieneCert = "OK";
            c.Pvg = "OK";

            //both run out on christmas
            c.H_Date = new DateTime(2017, 12, 25);

            
            this.Content = new SignIn(mw);
        }
        
    }
}
