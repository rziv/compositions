using System;
using System.Collections.Generic;
using System.Text;

namespace FP
{
    class Left: IEither
    {
        private string input;
        public Left(string input)
        {
            this.input = input;
        }

        public IEither Map(Func<string, string> cb)
        {
            return new Left(input);
        }

        public string Fold(Func<string, string> lcb, Func<string, string> rcb)
        {
            return lcb(input);
        }
    }
}
