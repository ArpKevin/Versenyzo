using Microsoft.VisualBasic;
using System.IO;

namespace Versenyzo
{
    internal class Program
    {
        public List<Contestant> contestants;
        static void Main(string[] args)
        {
            List<Contestant> contestants = new List<Contestant>();

            using StreamReader srSelejtezo = new(@"..\..\..\src\selejtezo.txt");

            while (!srSelejtezo.EndOfStream)
            {

            }

            Console.ReadKey();
        }
    }
}
