using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SEM_cwk
{
    
    class User
    {
        private string name;
        private bool cook;
        private bool safetyCert;
        private bool pvg;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Cook
        {
            get { return cook; }
            set { cook = value; }
        }

        public bool SafetyCert
        {
            get { return safetyCert; }
            set { safetyCert = value; }
        }

        public bool Pvg
        {
            get { return pvg; }
            set { pvg = value; }
        }
    }
}
