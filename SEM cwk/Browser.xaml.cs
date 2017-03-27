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
    /// Interaction logic for Browser.xaml
    /// </summary>
    public partial class Browser : Page
    {
        Cook c;
        MainWindow mw;

        //declare some names for eater
        string[] names = new string[10] { "Adam", "Dora", "Luke", "Jenifer", "Kyle", "Emily", "Mike", "Alice", "James", "Lilith" };
        List<Eater> eaters = new List<Eater>();

        public Browser(Cook cookAccount, MainWindow mw_in)
        {
            InitializeComponent();
            c = cookAccount;
            mw = mw_in;
            
            Random r = new Random();
            for(int i = 0; i<10; i++)
            {
                //generate eaters of random distance
                eaters.Add(new Eater(names[i], 100 + i, 100* Math.Round(r.NextDouble(), 5)));
                comboBox.Items.Add(eaters[i].Name);
            }
        }

        private void mButton_Click(object sender, RoutedEventArgs e)
        {
            Eater match = eaters[comboBox.SelectedIndex];
            CookerHub ch = new CookerHub(c, mw, match);
            mw.Content = ch;
        }
    }
}
