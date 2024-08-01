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
        //define later 
        public virtual IPageable Input()
        {
            throw new NotImplementedException();
        }

        public void Output()
        {
            throw new NotImplementedException();
        }
        public PageData MyData
        { get {
                return MyData;
            }
            set {
                myData = value;
            }
        }
    }
}
