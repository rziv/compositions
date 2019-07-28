using System;
using System.Collections.Generic;
using System.Text;

namespace FP
{
    class Box 
    {
        private string input;
        public Box(string input)
        {
            this.input = input;
        }

        public Box Map(Func<string, string> cb)
        {
            return new Box(cb(input));
        }

        public string Fold(Func<string, string> cb)
        {
            return cb(input);
        }        
        
    }
}
