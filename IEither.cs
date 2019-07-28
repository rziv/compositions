using System;
using System.Collections.Generic;
using System.Text;

namespace FP
{
    internal interface IEither
    {
        IEither Map(Func<string, string> cb);
        string Fold(Func<string, string> lcb, Func<string, string> rcb);
    }
}
