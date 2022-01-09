using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleRPG
{
   class StateMainMenu 
        : State
    {
        public StateMainMenu(Stack<State> states)
        : base(states)
        {

        }

        override public void Update()
        {
            Console.WriteLine("Escreva um número");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
                this.end = true;


        }
    }
}
