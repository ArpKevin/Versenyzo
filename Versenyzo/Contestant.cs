using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versenyzo
{
    internal class Contestant
    {
        public Contestant(string name, List<int> scores)
        {
            Name = name;
            Scores = scores;
        }

        public string Name { get; set; }
        public List<int> Scores { get; set; }
    }
}
