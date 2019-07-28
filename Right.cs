using System;
using System.Collections.Generic;
using System.Text;

namespace FP
{
    class Right:IEither
    {
        private string input;
        public Right(string input)
        {
            this.input = input;
        }

        public IEither Map(Func<string, string> cb)
        {
            return new Right(cb(input));
        }

        public string Fold(Func<string, string> lcb, Func<string, string> rcb)
        {
            return rcb(input);
        }
    }
}
