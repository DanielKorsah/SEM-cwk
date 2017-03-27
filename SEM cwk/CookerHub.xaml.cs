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
    /// Interaction logic for CookerHub.xaml
    /// </summary>
    public partial class CookerHub : Page
    {
        Cook c;
        MainWindow mw;

        public CookerHub(Cook cookAccount, MainWindow mw_in)
        {
            InitializeComponent();
            c = cookAccount;
            mw = mw_in;

            //if hygiene test expires at a date later than current date PVG is true
            if (DateTime.Compare(c.H_Date, DateTime.Now.Date) >= 0)
                c.HygieneCert = true;
            else
                c.HygieneCert = false;

            //if pvg expires at a date later than current date PVG is true
            if (DateTime.Compare(c.P_Date, DateTime.Now.Date) >= 0)
                c.Pvg = true;
            else
                c.Pvg = false;

            //Print current approval status
            if(c.HygieneCert && c.Pvg)
                statusLabel.Content += "APPROVED";
            else
                statusLabel.Content += "NOT APPROVED";

            if(c.HygieneCert)
                statusLabel.Content += "\nHygiene Certified: Yes\nExpires on: " + c.H_Date.ToString("yyyy-MM-dd");
            else
                statusLabel.Content += "\nHygiene Certified: No";
            
            if(c.Pvg)
                statusLabel.Content += "\nPVG up-to-date: Yes\nExpires on: " + c.P_Date.ToString("yyyy-MM-dd");
            else
                statusLabel.Content += "\nPVG up-to-date: No";
        }

        //self explanatory buttons
        private void instructionButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("These are instructions. There are serveral pages of these.");
        }

        private void hTestButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Nope! Not in spec and unnecessary. Look at when the dates run out");
        }

        private void pvgButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Nope! Not in spec and unnecessary. Look at when the dates run out");
        }
    }
}
