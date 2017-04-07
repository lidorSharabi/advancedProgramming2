using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SearchAlgorithmsLib
{
    public class State<T>
    {
        private T state; // the state represented by a string
        private double cost; // cost to reach this state (set by a setter)
        private State<T> cameFrom; // the state we came from to this state (setter)

        public State(T state) // CTOR
        {
            this.state = state;
        }

        // we overload Object's Equals method
        public bool Equals(State<T> s)
        {
            return state.Equals(s.state);
        }
    }
}
