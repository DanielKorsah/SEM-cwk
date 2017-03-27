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
        private int id;
        private double distance;

        public Eater(string n, int i, double d)
        {
            name = n;
            id = i;
            distance = d;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public double Distance
        {
            get { return distance; }
            set { distance = value; }
        }
    }
}
