using IDE_PROYECTO1.automata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE_PROYECTO1.automataDePila
{
    class Pila
    {
        private Stack<Token> pila = new Stack<Token>();

        public void apilar() {
            pila.Push(new Token(5,5,"hola"));
            pila.Pop();
        }
        
    }
}
