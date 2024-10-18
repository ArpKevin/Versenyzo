using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;

namespace Versenyzo
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            List<Contestant> contestants = new List<Contestant>();
            contestants = Contestant.beolvasas();

            Console.WriteLine($"3. feladat: A versenyen {contestants.Count()} versenyző vett részt.");

            Console.Write("4. feladat: Kérem a zsűritag sorszámát: ");
            int juryNum = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine($"5. feladat: A zsűritag által adott pontszámok átlaga: {Math.Round(contestants.Average(c => c.Scores[juryNum]), 1)}");

            var contestantWithMostScore = contestants.MaxBy(c => c.Scores.Sum());

            Console.WriteLine($"6. feladat: A legmagasabb pontszámot elérő versenyző: {contestantWithMostScore.Name}. Pontszáma: {contestantWithMostScore.Scores.Sum()}");

            Console.ReadKey();
        }
    }
}