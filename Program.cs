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

            bool _loopInd = true;

            while (_loopInd)
            {
                string name = "";
                Console.WriteLine("Welcome to this project - \n\t [A] - Add a Cat \n\t [B] - Add a Dog \n\t [C] - Add a Teacher \n\t [Q] - Quit");
                string A1 = Console.ReadLine().ToUpper();

                switch (A1)
                {
                    case "A":
                                Console.WriteLine("What is the Cats name?");
                                name = Console.ReadLine();
                                Console.WriteLine("How many Mice has the Cat killed?");
                                int mice;
                                try{
                                    mice = Int32.Parse(Console.ReadLine());
                                    zoo.Add(new Cat(mice, name));
                                }
                                catch{
                                    Console.WriteLine("Error: answer was not a number\n");
                                    Console.WriteLine("Thanks for Using the program");
                                    _loopInd = false;
                                }

                                break;
                    case "B":
                        Console.WriteLine("What is the Dogs name?");
                        name = Console.ReadLine();
                        Console.WriteLine("Is the dog friendly?\n\t [Y] - Yes \n\t [N] - No");
                        string A2 = Console.ReadLine().ToUpper();
                        switch(A2)
                        {
                            case "Y":
                                zoo.Add(new Dog(true, name));

                            break;
                            case "N":
                                zoo.Add(new Dog(false, name));

                            break;
                            default:
                                 Console.WriteLine("Error: answer was not a Y or N\n");
                                    Console.WriteLine("Thanks for Using the program");
                                    _loopInd = false;

                            break;
                        }
                                        
                               
                        break;
                    case "C":
                        Console.WriteLine("What is the Teachers name?");
                        name = Console.ReadLine();
                        int age;
                        Console.WriteLine("How old is the teacher");
                                try{
                                    age = Int32.Parse(Console.ReadLine());
                                    zoo.Add(new Teacher(age, name));
                                }
                                catch{
                                    Console.WriteLine("Error: answer was not a number\n");
                                    Console.WriteLine("Thanks for Using the program");
                                    _loopInd = false;
                                }
                        break;
                    case "Q":
                        Console.WriteLine("\n\n\nThanks for Using the program");
                       
                        _loopInd = false;
                        break;
                    default:
                        Console.WriteLine("Error: Invalid Answer\n");
                    
                        break;
                }


            }

                    foreach (Talkable thing in zoo)
                        {
                            PrintOut(thing);
                        }
            // Lines to Replace Begin Here
            zoo.Add(new Dog(true, "Bean"));
            
            zoo.Add(new Teacher(44, "Stacy Read"));
            // End Lines to Replace

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
