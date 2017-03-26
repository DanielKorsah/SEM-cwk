﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SEM_cwk
{
    
    class Cook
    {
        private string name;
        private bool hygieneCert;
        private bool pvg;
        private DateTime hDate;
        private DateTime pDate;

        public string Name
        {
            get { return name; }
            set { name = value; }
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
            get { return hDate; }
            set { hDate = value; }
        }

        public DateTime P_Date
        {
            get { return pDate; }
            set { pDate = value; }
        }
    }
}