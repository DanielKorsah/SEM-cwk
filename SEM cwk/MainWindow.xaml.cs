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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            SingUpPage s = new SingUpPage();
            this.Content = s;
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            SingUpPage L = new SingUpPage();
            L.textBox.Text = "Fuck You too!";
            this.Content = L;
            
        }
    }
}
