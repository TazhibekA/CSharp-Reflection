using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApp7
{
    public class ExampleClass
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public ExampleClass(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Show() {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
        }

    }
}
