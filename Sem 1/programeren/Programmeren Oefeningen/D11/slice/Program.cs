using System;
using System.Collections.Generic;

namespace slice
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] getallen = { 0, 1, 2, 3, 4, 5, 6 }; // makkelijke getallen om te testen en te debuggen!

			int[] testHead0 = Slice(getallen, 0, 0);
			int[] testMiddle0 = Slice(getallen, 3, 0);
			int[] testTail0 = Slice(getallen, getallen.Length - 1, 0);

			int[] testHead1 = Slice(getallen, 0, 1);
			int[] testMiddle1 = Slice(getallen, 3, 1);
			int[] testTail1 = Slice(getallen, getallen.Length - 1, 1);

			int[] testHead2 = Slice(getallen, 0, 2);
			int[] testMiddle2 = Slice(getallen, 3, 2);
			int[] testTail2 = Slice(getallen, getallen.Length - 2, 2);

			int[] testComplete = Slice(getallen, 0, getallen.Length);

			int[] array = testHead2;

			string output = String.Join("-", array);
			Console.WriteLine(output);
		}
		static int[] Slice (int[] getallen,int start,int lengte)
        {
			List<int> lijst = new List<int>();
            for (int i = start; i < lengte; i++)
            {
				lijst.Add(getallen[i]);
            }
			return lijst.ToArray();
        }
    }
}
