using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookApp
{
   public struct PageData
    {
        public string tittle;
        public string Author;
    }
    public interface IPageable
    {
        PageData MyData { get; set; } //set method is not necessary

        //how we are going to input our item
        IPageable Input();

        //how do we output this item
        void Output();
    }
}
