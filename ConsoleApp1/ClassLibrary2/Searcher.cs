using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Priority_Queue;

namespace SearchAlgorithmsLib
{
    public abstract class Searcher<T> : ISearchable<T>
    {
        private SimplePriorityQueue<State<T>> openList;
        private int evaluatedNodes;

        public Searcher()
        {
            openList = new SimplePriorityQueue<State<T>>();
            evaluatedNodes = 0;
        }

        protected void addToOpenList(State<T> state)
        {
            openList.Enqueue(state, 1);
        }

        protected State<T> popOpenList()
        {
            evaluatedNodes++;
            return openList.Dequeue();
        }

        public int openListSize
        {
            get { return openList.Count; }
        }

        public int getNumberOfNodesEvaluated()
        {
            return evaluatedNodes;
        }

        public abstract Solution search(ISearchable<T> searchable);
    }
}
