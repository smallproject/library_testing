

using System;

namespace ConsoleApplication1.Local
{
    class getBasic
    {
        private string _input;
        private string _value;
        public string input
        {
            get { return _input; }
            set { _input = value; }
        }

        public void Main()
        {
            input = "hello";
            Console.WriteLine(input);
            Console.WriteLine(_input);
        }
    }
}
