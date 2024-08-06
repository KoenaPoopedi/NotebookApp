using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookApp
{
    class Image : IPageable
    {
        private PageData myData;
        private string asciiImage;
        public IPageable Input()
        {
            Console.WriteLine("Please input your name");
            myData.Author = Console.ReadLine();
            Console.WriteLine("Please input the message title");
            myData.tittle = Console.ReadLine();

            Console.WriteLine("Start inputing your image, press enter to create as many lines as you like.");
            Console.WriteLine("Press Ctrl+D then enter on a single line to stop creating your image");
            bool finishedImage = false;
            while (!finishedImage)
            {
                string input = Console.ReadLine(); 
                //in c# is short circuited
                if((input.Length > 0) && (input[0] == 4))
                {
                    finishedImage = true;
                }
                else
                {
                    asciiImage += "\t" + input + "\n";
                }
            }
            return this;
        }

        public void Output()
        {
            Console.WriteLine();
            Console.WriteLine("/--------------------Image--------------------\\");
            Console.WriteLine("Title: " + myData.tittle);
            Console.WriteLine("Author: " + myData.Author);
            Console.WriteLine();
            Console.WriteLine(asciiImage);
            Console.WriteLine("\\--------------------------------------------/");
        }
        public PageData MyData { 
            get {
                return myData;
                    }
            set{
                myData = value;
                    } 
        }
    }
}
