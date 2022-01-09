using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleRPG
{
    class State
    {

        protected Stack<State> states;
        protected bool end = false;

        public State(Stack<State> states)
        {
            this.states = states;

        }

        public bool requestEnd()
        {
            return this.end;
        }


        virtual public void Update()
        {

        }
    }
}
