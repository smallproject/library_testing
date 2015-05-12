using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Random
{
    class _classRandom1
    {
        public void Main()
        {
            var random = Console.ReadLine();

            Console.WriteLine(random.GetType());

        }

        private System.Random _random = new System.Random();
        public char GetLetter()
        {
            int num = _random.Next(0, 26);
            char let = (char)('a' + num);
            return let;
        }

        public void smallletters()
        {
            int start = 0;
            char letter = 'a';
            while (start < 26)
            {
                Console.WriteLine((char)(letter + start));
                ++start;
            }

        }



        public void bigletters()
        {
            int start = 0;
            char letter = 'A';
            while (start < 26)
            {
                Console.WriteLine((char)(letter + start));
                ++start;
            }

        }
    }
}
