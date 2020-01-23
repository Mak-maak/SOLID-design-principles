using System;
using System.Diagnostics;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            // journal instance
            Journal journal = new Journal();
            journal.AddEntry("I cried today.");
            journal.AddEntry("I learnt solid principles today");
            Console.WriteLine(journal);
            
            // persistence instance
            Persistence persistence = new Persistence();
            var filename = @"c:\users\mak\journal.txt";
            persistence.SaveToFile(journal, filename, true);
            Process.Start(filename);
        }
    }
}
