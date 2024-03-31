using System;
using System.Collections.Generic;
using wctc.edu;

namespace wctc.edu
{
    class MainProgram
    {
        private static readonly FileOutput outFile = new FileOutput("animals.txt");
        // private static readonly FileInput inFile = new FileInput("animals.txt");

        static void Main(string[] args)
        {
            List<Talkable> zoo = new List<Talkable>();

            // Lines to Replace Begin Here
            zoo.Add(new Dog(true, "Bean"));
            zoo.Add(new Cat(9, "Charlie"));
            zoo.Add(new Teacher(44, "Stacy Read"));
            // End Lines to Replace

            foreach (Talkable thing in zoo)
            {
                PrintOut(thing);
            }
            outFile.FileClose();
            // inFile.FileRead();
            // inFile.FileClose();

            FileInput indata = new FileInput("animals.txt");
            string line;
            while ((line = indata.FileReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        public static void PrintOut(Talkable p)
        {
            // Console.WriteLine(p.GetName() + " says=" + p.Talk());
            outFile.FileWrite(p.GetName() + " | " + p.Talk());
        }
    }
}
