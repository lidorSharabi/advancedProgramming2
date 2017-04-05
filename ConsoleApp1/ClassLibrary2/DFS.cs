using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SearchAlgorithmsLib
{
    
    class DFS : Searcher
    {
        public override Solution search(ISearchable searchable)
        {
            addToOpenList(searchable.getInitializeState());

        }
    }
}
