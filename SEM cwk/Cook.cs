using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM_cwk
{
    
    public class Cook
    {
        private string name;
        private string password;
        private bool hygieneCert;
        private bool pvg;

        //expiry dates for hygiene certification and pvg
        private DateTime hDate;
        private DateTime pDate;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        
        public bool HygieneCert
        {
            get { return hygieneCert; }
            set { hygieneCert = value; }
        }

        public bool Pvg
        {
            get { return pvg; }
            set { pvg = value; }
        }

        public DateTime H_Date
        {
            get { return hDate.Date; }
            set { hDate = value; }
        }

        public DateTime P_Date
        {
            get { return pDate.Date; }
            set { pDate = value; }
        }
    }
}
