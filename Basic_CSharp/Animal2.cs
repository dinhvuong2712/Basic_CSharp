using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_CSharp
{
    abstract class Animal2
    {
        public abstract void Sound();

        public void sleep()
        {
            Console.WriteLine("Zzzzz");
        }
    }
}
