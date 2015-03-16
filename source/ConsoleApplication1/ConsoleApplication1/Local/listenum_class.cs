using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Local
{
    class listenum_class
    {
        public List<parent> Parents = new List<parent>(); 
        public class parent
        {
            public int index { get; set; }
            public string property1 { get; set; }
            public string property2 { get; set; }
            public List<child> Childrenlist = new List<child>();

        }

        public List<child> Children = new List<child>(); 
        public class child
        {
            public int index { get; set; }
            public string property1 { get; set; }
            public string property2 { get; set; }
            public string property3 { get; set; }
        }



        public void main()
        {
            Children = new List<child>();
            Children.Add(new child() { index = 1, property1 = "Michael", property2 = "D", property3 = "Villas" });
            Children.Add(new child() { index = 2, property1 = "Arny", property2 = "D", property3 = "Villas" });
            Children.Add(new child() { index = 3, property1 = "William", property2 = "D", property3 = "Villas" });
            Parents.Add(new parent()
            {
                index = 1,
                property1 = "Jasper",
                property2 = "Villas",
                Childrenlist = Children
            });

            Children = new List<child>();
            Children.Add(new child() { index = 1, property1 = "Minx", property2 = "D", property3 = "Buenaflor" });
            Children.Add(new child() { index = 2, property1 = "Lito", property2 = "D", property3 = "Buenaflor" });
            Children.Add(new child() { index = 3, property1 = "Armani", property2 = "D", property3 = "Buenaflor" });
            Parents.Add(new parent()
            {
                index = 2,
                property1 = "Nadine",
                property2 = "Buenaflor",
                Childrenlist = Children
            });

            Children = new List<child>();
            Children.Add(new child() { index = 1, property1 = "Jeffry", property2 = "D", property3 = "Cantillas" });
            Children.Add(new child() { index = 2, property1 = "Roman", property2 = "D", property3 = "Cantillas" });
            Children.Add(new child() { index = 3, property1 = "Exaly", property2 = "D", property3 = "Cantillas" });
            Parents.Add(new parent()
            {
                index = 3,
                property1 = "Jomar",
                property2 = "Cantillas",
                Childrenlist = Children
            });

            foreach (var parent in Parents)
            {
                Console.WriteLine("PARENT :: {0} {1} {2}", parent.index, parent.property1, parent.property2);
                foreach (var children in parent.Childrenlist)
                {
                    Console.WriteLine("Child :: {0} {1} {2} {3}", children.index, children.property1, children.property2, children.property3);
                }
                Console.WriteLine("\n");
            }


        }
    }
}
