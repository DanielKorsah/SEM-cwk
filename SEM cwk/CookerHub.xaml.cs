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
        Eater match;

        public CookerHub(Cook cookAccount, MainWindow mw_in)
        {
            InitializeComponent();
            c = cookAccount;
            mw = mw_in;
            mw.Content = this;

            //if hygiene test expires at a date later than current date PVG is true
            if (DateTime.Compare(c.H_Date, DateTime.Now.Date) >= 0)
                c.HygieneCert = "OK";
            else
                c.HygieneCert = "EXPIRED";
            

            //Print current approval status and activate or deactivate button to find a match
            if (c.HygieneCert == "OK" && c.Pvg == "OK")
            {
                c.CookApproved = true;
                statusLabel.Content += "APPROVED";
                matchButton.IsEnabled = true;
            }
            else
            {
                c.CookApproved = false;
                statusLabel.Content += "NOT APPROVED";
                matchButton.IsEnabled = false;
            }



            if (c.HygieneCert == "OK")
                statusLabel.Content += "\nHygiene Certified: Yes\nExpires on: " + c.H_Date.ToString("yyyy-MM-dd");
            else
                statusLabel.Content += "\nHygiene Certified: No";

            if (c.Pvg == "OK")
                statusLabel.Content += "\nPVG OK";
            else if (c.Pvg == "AWAITING RESULT")
                statusLabel.Content += "\nPVG AWAITING APPROVAL";
            else
                statusLabel.Content += "\nPVG REJECTED";


        }

        public CookerHub(Cook cookAccount, MainWindow mw_in, Eater m)
        {
            InitializeComponent();
            c = cookAccount;
            mw = mw_in;
            match = m;


            //simulate eater accepting
            MessageBox.Show("The User has accepted your match request.\nYOu are now matched with " + match + ".");
            //show who is matched
            label2.Content += match.Name;


            //if hygiene test expires at a date later than current date PVG is true
            if (DateTime.Compare(c.H_Date, DateTime.Now.Date) >= 0)
                c.HygieneCert = "OK";
            else
                c.HygieneCert = "EXPIRED";
            

            //Print current approval status and activate or deactivate button to find a match
            if (c.HygieneCert == "OK" && c.Pvg == "OK")
            {
                c.CookApproved = true;
                statusLabel.Content += "APPROVED";
                matchButton.IsEnabled = true;
            }
            else
            {
                c.CookApproved = false;
                statusLabel.Content += "NOT APPROVED";
                matchButton.IsEnabled = false;
            }

            if (c.HygieneCert == "OK")
                statusLabel.Content += "\nHygiene Certified: Yes\nExpires on: " + c.H_Date.ToString("yyyy-MM-dd");
            else
                statusLabel.Content += "\nHygiene Certified: No";

            if (c.Pvg == "OK")
                statusLabel.Content += "\nPVG OK";
            else if (c.Pvg == "AWAITING RESULT")
                statusLabel.Content += "\nPVG AWAITING APPROVAL";
            else
                statusLabel.Content += "\nPVG REJECTED";
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


        //if postcode entered and not already matched allow user to select a match
        private void matchButton_Click(object sender, RoutedEventArgs e)
        {
            if(pCodeBox.Text != "" && label2.Content == "Current match is ")
            {
                Browser b = new Browser(c, mw);
                mw.Content = b;
            }
            else if (label2.Content != "Current match is ")
            {
                MessageBox.Show("You may only have one match at a time");
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            label2.Content = "Current match is ";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Account details = new Account(c);
            details.Show();
        }

        private void rateButton_Click(object sender, RoutedEventArgs e)
        {

            if (label2.Content != "Current match is ")
            {
                Rate r = new Rate(c);
                r.Show();
            }
            else
            {
                MessageBox.Show("You have not meal to rate yet");
            }
        }
    }
}
