using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post =
                "Very very Very very Very very Very very Very very Very very Very very Very very Very very Very very Very very Very very long text here...";
            var shortenedPost = post.Shorten(5);
            Console.WriteLine(shortenedPost + "...");
        }
    }
}
