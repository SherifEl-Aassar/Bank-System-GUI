using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System_GUI
{
    class Customer:Person
    {
       
        public int AccountIndex;

        public List<SavingAccount> sv = new List<SavingAccount>();
        public List<CheckingAccount> Check = new List<CheckingAccount>();
        public List<Loan> Looan = new List<Loan>();

    }
}
