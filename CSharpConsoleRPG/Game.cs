using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleRPG
{
    class Game
    {
        //Variable

        private bool end;

        public bool End
        {
            get { return this.end; }
            set { this.end = value; }
        }

        private Gui gui;

        private Stack<State> states;



        //Private functions
        private void InitVariables()
        {
       
            this.end = false;
        }

        private void InitStates()
        {
            this.states = new Stack<State>();
           

            //Push the first state
            this.states.Push(new StateMainMenu(this.states));

        }



        //Constructors and Desconstructors

        public Game()
        {
            this.InitVariables();
            this.InitStates();            
        }

        public void Run()
        {

            while(this.end == false)
            {
                if(this.states.Count > 0)
                this.states.Peek().Update();
            }

            Console.WriteLine("fim do game");
        }
    }
}
