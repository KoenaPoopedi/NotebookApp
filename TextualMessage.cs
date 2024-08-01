using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookApp
{
    class TextualMessage : IPageable
    {
        protected PageData myData;
        protected string message;
      
        public virtual IPageable Input()
        {
            Console.WriteLine("Please input your name");
            myData.Author = Console.ReadLine();
            Console.WriteLine("Plase input the message tittle");
            myData.tittle = Console.ReadLine();
            Console.WriteLine("Please input a message");
            message = Console.ReadLine();

            return this;
        }

        public void Output()
        {
            Console.WriteLine();
            Console.WriteLine("/------------------Message-----------------\\");
            Console.WriteLine("Title: " + myData.tittle);
            Console.WriteLine("Author: " + myData.Author);
            Console.WriteLine("Message: \n \n" + message);
            Console.WriteLine("\\-----------------------------------------/");
           
        }
        public PageData MyData
        { get{ 
                return myData;
             }
            set {
                myData = value;
            }
        }
    }
}
