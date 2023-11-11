using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice.Models
{
    internal class Books
    {
        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value.Length < 5)
                {
                    Console.WriteLine("5den kicik ola bilmez");
                    return;
                }
                _title = value;
            }
        }
        public readonly int Pages=200;
     

        protected string Author;

        public string ShowAuthor ()
        {
            Author = "Name";
            return Author;
        }
}
}

