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
        private Cook c = new Cook();

        public MainWindow()
        {
            InitializeComponent();
            MainWindow mw = this;

            c.Name = "Obama";
            c.Password = "password";
            c.HygieneCert = true;
            c.Pvg = true;

            //both run out on christmas
            c.H_Date = new DateTime(2017, 12, 25);
            c.P_Date = new DateTime(2017, 12, 25);

            this.Content = new SignIn(c, mw);
        }
        
    }
}
