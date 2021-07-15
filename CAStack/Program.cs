using System;
using System.Collections.Generic;

namespace CAStack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack<Command> undo = new Stack<Command>();
            //Stack<Command> redo = new Stack<Command>();

            //string line;

            //while (true)
            //{
            //    Console.Write("Url ('exit' to quit): ");
            //    line = Console.ReadLine().ToLower();
            //    if (line == "exit")
            //    {
            //        break;
            //    }
            //    else if(line == "back")
            //    {
            //        if (undo.Count > 0)
            //        {
            //            var item = undo.Pop();
            //            redo.Push(item);
            //        }
            //        else
            //        {
            //            continue;
            //        }
            //    }
            //    else if(line == "forward")
            //    {
            //        if (redo.Count > 0)
            //        {
            //            var item = redo.Pop();
            //            undo.Push(item);
            //        }
            //        else
            //        {
            //            continue;
            //        }
            //    }
            //    else
            //    {
            //        // add url to undo list
            //        undo.Push(new Command(line));
            //    }
            //    Console.Clear();

            //    Print("Back", undo);
            //    Print("Forward", redo);

            //} // end of while

            Stack<int> numbers = new Stack<int>(new List<int> { 1, 2, 3 });

            while(numbers.Count > 0)
            {
                var n = numbers.Peek();

                Console.WriteLine(n);
            }    

        } // end of main

        static void Print(string name, Stack<Command> commands)
        {
            Console.WriteLine($"{name} history");
            Console.BackgroundColor = name.ToLower() == "back" ? ConsoleColor.DarkGreen : ConsoleColor.DarkBlue;
            foreach(var u in commands)
            {
                Console.WriteLine($"\t{u}");
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }

    class Command
    {
        private readonly DateTime _createdAt;
        private readonly string _url;

        public Command(string url)
        {
            _createdAt = DateTime.Now;
            _url = url;
        }

        public override string ToString()
        {
            return $"[{this._createdAt.ToString("yyyy-MM-dd hh:mm")}] {this._url}";
        }
    }
}
