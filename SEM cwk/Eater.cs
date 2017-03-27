using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM_cwk
{
    public class Eater
    {
        private string name;
        private string password;
        private float distance;

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

        public float Distance
        {
            get { return distance; }
            set { distance = value; }
        }
    }
}
