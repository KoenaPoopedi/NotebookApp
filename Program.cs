﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NotebookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            NotebookLogger notebookLogger = new NotebookLogger(notebook);
            const string ExitProgramKeyword = "exit";
            string commandPrompt = "Please enetr: " + notebook.show +", "+ notebook._new +", " + notebook.delete + ",or " + notebook.log ;

            Console.WriteLine(Notebook.IntroMessage);
            Console.WriteLine(commandPrompt);

            String input = ""; 
            do
            {
                input = Console.ReadLine();

                string[] commands = input.Split();
                try
                {
                    //get the first command...show, new, or delete
                    //and pass the second to the function
                    notebook[commands[0]]((commands.Length > 1) ? commands[1] : "");
                } catch(KeyNotFoundException e)
                {
                    if (input != ExitProgramKeyword)
                    {
                        Console.WriteLine(commandPrompt);
                        Console.WriteLine(e.Message);
                    }
                }
                Console.WriteLine();

            } while (input != ExitProgramKeyword); 
            Console.WriteLine(Notebook.OutroMessage);
        }
    }
}