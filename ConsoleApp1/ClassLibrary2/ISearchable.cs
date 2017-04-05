using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SearchAlgorithmsLib
{
    interface ISearchable
    {
        State getInitializeState();
        State getGoalState();
        List<State> getAllPossibleStates(State s);
    }
}
