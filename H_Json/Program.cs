using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace H_Json
{
    class Person
    {
        public string Name { get; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    

    internal class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person("Илья", 21);
            string json = JsonSerializer.Serialize(tom);
            Console.WriteLine(json);
            Console.WriteLine(System.Text.RegularExpressions.Regex.Unescape(json)); // json на русский
        }
    }
}
