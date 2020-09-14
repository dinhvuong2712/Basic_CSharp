using System;
using System.IO;
using System.Linq;

namespace Basic_CSharp
{
    class Program
    {
        enum Level
        {
            Low,
            Medium,
            Hight
        }
        static void Main(string[] args)
        {
            //Syntax and Comment
            Console.WriteLine("Hello there");
            /*Multy Comment*/

            //Variable
            string name = "Vuong";
            Console.WriteLine("Variable"+ "\n" + name);

            //Data type
            int myNum = 5;
            double myNumDouble = 5.6;
            float myNumFloat = 5F;
            long myNumLong = 5L;
            char myLetter = 'V';
            bool myBool = true;
            string myText = "Vuong";

            Console.WriteLine("Data type" + "\n" + myNum + "\n" + myNumDouble + "\n" + myNumFloat
                + "\n" + myNumLong + "\n" + myLetter + "\n" + myBool + "\n" + myText);

            //Type casting
            //Explicit casting
            myNum = (int)myNumDouble;
            Console.WriteLine("Explicit casting: " + myNum);
            Console.WriteLine("Type casting" + "\n" + Convert.ToInt32(myNumDouble));

            //User input
            name = Console.ReadLine();
            Console.WriteLine("Name : " + name);


            int x = 10;
            int y = 5;

            //Operators
            //Arithmatic operators
            Console.WriteLine("Arithmatic operators: " + (x + y));
            //Assignment operators
            x += 5;
            Console.WriteLine("Assignment operators: " + x);
            //Comparition operators
            Console.WriteLine(x != y);
            //Logical operators
            Console.WriteLine(x > 10 || y > 10);
            //Execise
            Console.WriteLine(10 * 5);

            //Math
            Console.WriteLine(Math.Max(x, y));

            //Strings
            //String lenght
            string txt = "dfasdsadsafsasa";
            Console.WriteLine(txt.Length);
            //Orther methods
            Console.WriteLine(txt.ToUpper());
            //Concatenation
            string concatenation = txt + name;
            Console.WriteLine(concatenation);
            //Concat
            string concat = string.Concat(txt, name);
            Console.WriteLine(concatenation);

            //Interpolation
            string interpolation = $"My name is : {name} {txt}";
            Console.WriteLine(interpolation);

            //Access string
            string myString = "Vuong";
            Console.WriteLine(myString[0]);
            Console.WriteLine(myString.IndexOf("o"));

            //Special charactor
            Console.WriteLine("Hello, my name is \" Vuong \".");

            //Ececise
            name = "Hello";
            Console.WriteLine(name);

            //Boolean Value
            bool isFlowerBeautyfull = true;
            bool isLiveHanoi = false;
            Console.WriteLine(isFlowerBeautyfull + "\n" + isLiveHanoi);
            //Excecise
            Console.WriteLine(x > y);

            /*if{ } else { }*/
            if (x > y)
            {
                Console.WriteLine("Hello there");
            }
            else if(x < y)
            {
                Console.WriteLine("Hello world");
            }
            else 
            {
                Console.WriteLine("Opps somthing wrong");
            }

            string result = (x > 10) ? "Good bye " : "Hello";
            Console.WriteLine(result);

            /*switch case*/
            switch (y)
            {
                case 1:
                    Console.WriteLine("Hello there");
                    break;
                case 2:
                    Console.WriteLine("I'm Vuong");
                    break;
                case 3:
                    Console.WriteLine("What is your name");
                    break;
                case 4:
                    Console.WriteLine("I'm live in Hanoi");
                    break;
                case 5:
                    Console.WriteLine("Where are you from");
                    break;
                default:
                    Console.WriteLine("Opps something wrong");
                    break;
            }

            /*while loop*/
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            /*do/while loop*/
            i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);

            /*for loop*/
            for(int j = 0; j<10; j++)
            {
                Console.WriteLine(j);
            }

            /*foreach*/
            string[] array = { "Dang", "Dinh", "Vuong" }; 
            foreach(string items in array)
            {
                Console.Write(items);
            }
            /*break for*/
            for (int k = 0; k < 10; k++)
            {
                if (k < 5)
                {
                    continue;
                }
                if (k == 5)
                {
                    Console.WriteLine("\n" + k);
                    break;
                }
            }
            /*break while*/
            i = 0;
            while (i < 5)
            {
                if (i == 3)
                {
                    i++;
                    continue;
                }
                if (i == 4)
                {
                    Console.WriteLine(i);
                    break;
                }
                Console.WriteLine(i);
                i++;
            }

            /*Array*/
            Console.WriteLine(array.Length);
            for(int l = 0; l<array.Length; l++)
            {
                Console.WriteLine(array[l]);
            }
            foreach(string items in array)
            {
                Console.WriteLine(items);
            }
            /*sort string*/
            Array.Sort(array);
            foreach (string items in array)
            {
                Console.WriteLine(items);
            }
            /*System.linq*/
            int[] arrayNum = { 1, 3, 2, 8, 7, 4 };
            Console.WriteLine(arrayNum.Max());
            Console.WriteLine(arrayNum.Min());
            Console.WriteLine(arrayNum.Sum());

            /*Method*/
            MethodParameterAndArgument();
            MethodDefaultParameter("Vuong");
            MethodDefaultParameter();
            MethodMultipleParameter("John",25);
            MethodMultipleParameter("Mathew", 27);
            MethodMultipleParameter("Peter", 15);
            Console.WriteLine(MethodReturnValue(x, y));
            MethodNamedAgument(name3: "Vuong", name1: "Dang", name2: "Dinh");

            /*Method overloading*/
            int number = MethodReturnValue(x, y);
            Console.WriteLine(number);

            /*OOP*/
            /*Class Opject*/
            Car car = new Car();
            Console.WriteLine(car.color);

            /*Class Member*/
            Fruit fruit = new Fruit();
            fruit.color = "yellow";
            fruit.name = "banana";
            Console.WriteLine(fruit.name+"\n"+fruit.color);
            fruit.fullThrollter();
            /*Constructor*/
            Person person = new Person("Vuong",20,"Hai Phong");
            person.showInfor();
            /*Access modify*/
            person.showAddress();
            /*Properties and encapsulation*/
            person.Address = "Tien Lang";
            Console.WriteLine(person.Address);
            /*Automatic Properties*/
            person.Name = "Dinh Vuong";
            Console.WriteLine(person.Name);
            /*Inheritance*/
            Car car2 = new Car();
            car2.color = "White";
            Console.WriteLine(car2.brand + car2.color);
            car2.honk();
            /*Polymorphism*/
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            animal.Sound();
            dog.Sound();
            cat.Sound();

            /*Abstract*/
            Pig pig = new Pig();
            pig.Sound();
            pig.sleep();
            /*Interface*/
            Mouse mouse = new Mouse();
            mouse.Sound();

            /*Enum*/
            Level myLevel = Level.Low;
            int myIndexLevel = (int)Level.Medium;
            Console.WriteLine("Level: "+ myLevel + "\nIndexOf Level"+ myIndexLevel);

            switch (myLevel)
            {
                case Level.Low:
                    Console.WriteLine("Low level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Low level");
                    break;
                case Level.Hight:
                    Console.WriteLine("Low level");
                    break;
            }

            /*Files*/
            /*Write File*/
            string myWrite = "Dang Dinh Vuong";
            File.WriteAllText("file.txt", myWrite);

            string readFile = File.ReadAllText("file.txt");
            Console.WriteLine(readFile);

            /*Exception*/
            try
            {
                Console.WriteLine(arrayNum[10]);
            }
            catch
            {
                Console.WriteLine("Some thing wrong");
                
            }
            finally
            {
                Console.WriteLine("Finish try catch");
            }
            checkAge(15);


        }
        static void MethodParameterAndArgument()
        {
            Console.WriteLine("Hello world");
        }
        static void MethodDefaultParameter(string myName = "Norway")
        {
            Console.WriteLine("My name is" + myName);
        }
        static void MethodMultipleParameter(string name, int age)
        {
            Console.WriteLine(name + "\'s " + age);
        }
        static int MethodReturnValue(int x,int y)
        {
            return x + y;
        }
        static void MethodNamedAgument(string name1, string name2, string name3)
        {
            Console.WriteLine("My name is: " + name3);
        }
        static void checkAge(int age)
        {
            if (age > 18)
            {
                Console.WriteLine("You can watch");
            }
            else
            {
                Console.WriteLine("You can't watch");
            }
        }
    }
}
