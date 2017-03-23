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
using System.IO;
using Newtonsoft.Json;

namespace SEM_cwk
{
    /// <summary>
    /// Interaction logic for SingUpPage.xaml
    /// </summary>
    public partial class SingUpPage : Page
    {
        public SingUpPage()
        {
            InitializeComponent();
        }

        private void AddNameButton_Click(object sender, RoutedEventArgs e)
        {
            User user = new User
            {
                Name = textBox.Text
            };

            File.WriteAllLines(@"C:\Users\user\Documents\Visual Studio 2015\Projects\SEM cwk\userData.json", JsonConvert.SerializeObject(user));

        }
    }
}
