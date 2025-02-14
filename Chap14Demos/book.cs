using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap14Demos
{
    internal class book : Product
    {
        public string Author { get; set; }

        public book(string code, double price, string description, string author) :
            base(code, price, description)
        {
            this.Author = author;
        }

        public override string GetDisplayText(string sep)
        {
            return $"{base.GetDisplayText(sep)}{Author}";
        }
    }
}