using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versenyzo
{
    public class Contestant
    {
        public Contestant(string sor)
        {
            var x = sor.Split(";");
            Name = x[0];
            var scoresSplit = x[1].Split(" ");
            Scores = new List<int>();
            foreach (var item in scoresSplit)
            {
                Scores.Add(int.Parse(item));
            }
        }

        public string Name { get; set; }
        public List<int> Scores { get; set; }

        public override string ToString()
        {
            return $"Név: {Name}, pontok: {string.Join(", ", Scores)}";
        }
    }
}
