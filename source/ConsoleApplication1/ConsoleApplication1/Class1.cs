using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class1
    {

    }

    internal class month
    {
        public int id { get; set; }
        public string name { get; set; }

        internal month() 
        {
            
        }

        public List<month> months = new List<month>(); 
    }

    internal class Account
    {
        public int Id { get; set; }
        public string account_user { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public DateTime birthdate { get; set; }

        public bool gender { get; set; }

        List<Account> accounts = new List<Account>(); 
    }

    internal class TestArea
    {
        public void fill()
        {
            string[][] arrayaccount = new string[10][];
        }
    }
}
