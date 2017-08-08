using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SEM_cwk
{
    
    public class Cook : User
    {
        private string hygieneCert;
        private string pvg;
        private bool cookApproved;

        //expiry dates for hygiene certification and pvg
        private DateTime hDate;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        
        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        public string HygieneCert
        {
            get { return hygieneCert; }
            set { hygieneCert = value; }
        }

        public string Pvg
        {
            get { return pvg; }
            set { pvg = value; }
        }

        public bool CookApproved
        {
            get { return cookApproved; }
            set { cookApproved = value; }
        }

        public DateTime H_Date
        {
            get { return hDate.Date; }
            set { hDate = value; }
        }

        public void RateMeal(int num)
        {
            if (num > 5 || num < 0)
            {
                MessageBox.Show("Error");
            }
            else
            {
                MessageBox.Show("you rated " + num + " stars");
            }
        }

        public void UploadPicture()
        {
            MessageBox.Show("Picture uploaded.");
        }
    }
}
