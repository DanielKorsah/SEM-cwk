﻿using System;
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

            if(c.HygieneCert && c.Pvg)
            {
                statusLabel.Content += "APPROVED";
            }
            else
            {
                statusLabel.Content += "NOT APPROVED";
            }
        }


    }
}
