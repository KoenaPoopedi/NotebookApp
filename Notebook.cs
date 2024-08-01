using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookApp
{
    class Notebook
    {
        public const string IntroMessage = "Welcome to Notebook App v1";
        public const string OutroMessage = "Thanks for using Notebook App v1"; 

        List<IPageable> pages = new List<IPageable>();

        public delegate void SimpleFunction(string command);
        private Dictionary<string, SimpleFunction>  commandLineArgs = new Dictionary<string, SimpleFunction>();
        public readonly string show = "show", _new = "new", delete = "delete";//keys



        public SimpleFunction this[string command]
        { get
            {
                return commandLineArgs[command];
            }
        }

        public Notebook()
        { 
            commandLineArgs.Add(show, Show);
            commandLineArgs.Add(_new, New);
            commandLineArgs.Add(delete, Delete);

        }   

        /// <summary>
        /// Creates a new notebook with imput keywords for commands instead of default ones.
        /// </summary>
        /// <param name="commandLineKeywords"> index 0 = show, 1 = new, 2 = delete. </param>

        public Notebook(params string[] commandLineKeywords) : this()
        {
            for (int i = 0; i < commandLineKeywords.Length; i++)
            {   //if nothing is input jump to the next iteration
                if (commandLineKeywords[i] == "")
                {
                    continue;
                }
                switch(i)
                {
                    //show
                    case 0:
                        commandLineArgs.Remove(show);
                        commandLineArgs.Add(show = commandLineKeywords[i], Show);
                        break;
                    //new
                    case 1:
                        commandLineArgs.Remove(_new);
                        commandLineArgs.Add(_new = commandLineKeywords[i], New);
                        break ;
                     //delete
                    case 2:
                        commandLineArgs.Remove(delete);
                        commandLineArgs.Add(delete = commandLineKeywords[i], Delete);
                        break ;
                }
            }
        }

        public void Show(string command)
        {
            Console.WriteLine("Show method " + command);
        }
        public void New(string command) 
        { 
            Console.WriteLine("New method " + command);
        }
        public void Delete(string command)
        {
            Console.WriteLine("Delete method " + command);
        }
    }
}
