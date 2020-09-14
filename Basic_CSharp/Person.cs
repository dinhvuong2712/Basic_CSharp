using System;

namespace Basic_CSharp
{
    class Person
    {
        public string name;
        public int age;

        public Person(string name, int age, string address)
        {
            Address = address;
            this.name = name;
            this.age = age;
        }

        public void showInfor()
        {
            Console.WriteLine("Name: " + name + "Age" + age);
        }
        public void showAddress()
        {
            Console.WriteLine("Address: " + Address);
        }
        public string Address { get; set; }
        public string Name { get; set; }
    }
}
