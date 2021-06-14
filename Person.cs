using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System_GUI
{
    class Person
    {
        private string ID;
        private string First_Name;
        private string Last_Name;
        private string Password;

        public Person()
        {
            ID = null;
            First_Name = null;
            Last_Name = null;
            Password = null;
        }

        public void set_ID(string ID)
        {
            this.ID = ID;
        }
        public string get_ID()
        {
            return ID;
        }

        public void set_FirstName(string Name)
        {
            First_Name = Name;
        }
        public string get_FirstName()
        {
            return First_Name;
        }

        public void set_LastName(string Name)
        {
            Last_Name = Name;
        }
        public string get_LastName()
        {
            return Last_Name;
        }

        public void set_Pass(string Pass)
        {
            Password = Pass;
        }
        public string get_Pass()
        {
            return Password;
        }
    }
}
