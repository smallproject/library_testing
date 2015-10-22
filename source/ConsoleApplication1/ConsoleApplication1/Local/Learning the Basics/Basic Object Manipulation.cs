using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Local.Learning_the_Basics
{
    class Basic_Object_Manipulation
    {
        internal class Person
        {
            internal string name { get; set; }
            internal string gender { get; set; }  
            internal string _birthdate { get; set; }
            internal DateTime birthdate { get; set; }
            internal int age { get; set; }

            internal Person()
            {

            }

            internal void computeAge()
            {
                DateTime date;
                DateTime.TryParse(_birthdate, out date);
                birthdate = date;

                TimeSpan CurrentAge = DateTime.Today - date;

                age = CurrentAge.Days/365;
            }

        }

        public int age(DateTime birthdate)
        {

            //DateTime test;

            //DateTime.TryParse("09-03-1992", out birthdate);

            TimeSpan CurrentAge = DateTime.Today - birthdate;
            //int.TryParse( out int ageM);


            //return CurrentAge;
            Console.WriteLine(birthdate);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(CurrentAge);
            Console.WriteLine(CurrentAge.Days / 365);
            return 0;
        }

        internal int ageDifference(Person a, Person b)
        {
            return a.age - b.age;
        }

        public void Main()
        {
            DateTime age1;
            DateTime age2;

            DateTime.TryParse("09-12-1992", out age1);
            DateTime.TryParse("09-12-1991", out age2);

            Person jerry = new Person()
            {
                name = "Jerry",
                gender = "male",
                _birthdate = "09-12-1997",
                birthdate = age1,
                age = 23
            };
            jerry.computeAge();

            Person mertel = new Person()
            {
                name = "Mertel",
                gender = "female",
                _birthdate = "09-12-1990",
                birthdate = age2,
                age = 25
            };

            mertel.computeAge();

            Console.WriteLine(jerry.name + " " + jerry.gender + " " + jerry._birthdate + " " + jerry.birthdate + " " + jerry.age);
            Console.WriteLine(mertel.name + " " + mertel.gender + " " + mertel._birthdate + " " + mertel.birthdate + " " + mertel.age);
            Console.WriteLine(ageDifference(jerry,mertel));

            Console.WriteLine("Name: {0} Gender: {1}, Birthdate String: {2} Birthdate date: {3} Age: {4}", jerry.name, jerry.gender, jerry._birthdate, jerry.birthdate, jerry.age);
            Console.WriteLine("Name: {0} Gender: {1}, Birthdate String: {2} Birthdate date: {3} Age: {4}", mertel.name, mertel.gender, mertel._birthdate, mertel.birthdate, mertel.age);
        }
    }
}
