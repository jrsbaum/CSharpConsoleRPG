using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleRPG.States
{
    class StateGame
        : State
    {
        public StateGame(Stack<State> states)
            : base(states)
        {
                 
        }
    }
}
