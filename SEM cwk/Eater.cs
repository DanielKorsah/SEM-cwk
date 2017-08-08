using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SEM_cwk
{
    public class Eater:User
    {
     
        private int id;

        public Eater(string n, int i, double d)
        {
            name = n;
            id = i;
            this.location = "Edinburgh";
        }

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

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public void RateMeal(int num)
        {
            MessageBox.Show("you rated " + num + " stars");
        }


    }
}
