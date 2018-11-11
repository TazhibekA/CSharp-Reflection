using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            SecondTask();
        }

        public static void FirstTask() {

            Type console = typeof(Console);
            MethodInfo[] methodInfos = console.GetMethods();
            int counter = 1;
            foreach (MethodInfo i in methodInfos)
            
            {
                Console.Write(counter +". "+ i.ReturnType.Name + "    " + i.Name + "(");

                ParameterInfo[] parameterInfos = i.GetParameters();

                for (int j = 0; j < parameterInfos.Length; j++)
                {
                    Console.Write(parameterInfos[j].ParameterType.Name + " " + parameterInfos[j].Name);
                    if (j + 1 < parameterInfos.Length) Console.Write(", ");
                }
                Console.WriteLine(")");
                counter++;
            }

        
        }

        public static void SecondTask()
        {

            ExampleClass exampleClass = new ExampleClass("Aknur",18);

            Type exampleClassType = typeof(ExampleClass);

            Console.WriteLine("Methods of {0}",exampleClassType.Name);
            PropertyInfo[] propertyInfos = exampleClassType.GetProperties();

            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
               Console.WriteLine(propertyInfo.Name+"   "+ propertyInfo.PropertyType.Name + ", value:" + propertyInfo.GetValue(exampleClass, null));
            }

        }
    }
}
