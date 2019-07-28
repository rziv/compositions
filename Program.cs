using System;

namespace FP
{
    class Program
    {
        static void Main(string[] args)
        {            

            Console.WriteLine(new Box("      AVI ").Map(Trim).Map(ToLower).Fold(SayHi));
            Console.ReadLine();

            Console.WriteLine(new Box("      help ").Map(Trim).Fold(Shout));
            Console.ReadLine();

            FromNullable("      ELI ").Map(Trim).Map(ToLower).Map(SayHi).Fold(Throw, Print);
            FromNullable(null).Map(Trim).Map(ToLower).Map(SayHi).Fold(Throw, Print);

            Console.ReadLine();


        }


        static string Shout(string value)
        {
            return new Box(value).Map(ToUpper).Fold(Exclaim);
        }

        static string  SayHi(string name)
        {
            return "Hi " + name;
        }

        static string Trim(string value)
        {
            return value.Trim();
        }

        static string ToLower(string value)
        {
            return value.ToLower();
        }

        static string ToUpper(string value)
        {
            return value.ToUpper();
        }

        static string Exclaim(string value)
        {
            return value + "!";
        }

        static IEither FromNullable(string value)
        {
            return (value == null) ? new Left(value) as IEither : new Right(value) as IEither;
        }

        static string Print(string value)
        {
            Console.WriteLine(value);
            return value;
        }

        static string Throw(string value)
        {
            Console.WriteLine("Empty Value Error!!");
            return null;
        }

    }
}
