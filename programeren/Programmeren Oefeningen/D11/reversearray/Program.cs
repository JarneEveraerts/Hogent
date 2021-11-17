using System;

namespace reversearray
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] test0 = { }; // Duizend bommen en granaten Kuifje, een leeg array!
			string[] test1 = { "een" };
			string[] test2 = { "een", "twee" };
			string[] test3 = { "een", "twee", "drie" };
			string[] test4 = { "een", "twee", "drie", "vier" };
			string[] test5 = { "een", "twee", "drie", "vier", "vijf" };

				string[] woorden = test5;

				Console.WriteLine(string.Join(", ", woorden));
				Array.Reverse(woorden);
				Console.WriteLine(string.Join(", ", woorden));

		}
    }
}
