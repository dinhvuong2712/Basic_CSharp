using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_CSharp
{
    class Mouse : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Chit chit");
        }
    }
}
