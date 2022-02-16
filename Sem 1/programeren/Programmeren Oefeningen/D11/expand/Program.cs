using System;
using System.Collections.Generic;
namespace expand
{
    class Program
    {
		static void Main()
		{
			// voorbeeld 1 : een reeks één keer dupliceren
			int[] scores1 = { 2, 3, -5, 6 };
			int[] expanded1 = Expand(1, scores1);

			Console.WriteLine(String.Join(",", expanded1));
			// output is : 2,3,-5,6

			// voorbeeld 2 : een reeks drie keer dupliceren
			int[] scores2 = { 2, 3, -5, 6 };
			int[] expanded2 = Expand(3, scores2);

			Console.WriteLine(String.Join(",", expanded2));
			// de output is : 2,2,2,3,3,3,-5,-5,-5,6,6,6

			// voorbeeld 3 : een reeks nul keer dupliceren
			int[] scores3 = { };
			int[] expanded3 = Expand(0, scores3);

			Console.WriteLine(String.Join(",", expanded3));
			// output is : (een lege regel)
			// (de Expand oproep retourneerde immers een lege array)

			// voorbeeld 4 : een lege reeks 5 keer dupliceren
			int[] scores4 = { };
			int[] expanded4 = Expand(5, scores4);

			Console.WriteLine(String.Join(",", expanded4));
			// output is : (een lege regel)
			// (de Expand oproep retourneerde immers een lege array)
		}
		static int[] Expand(int count, int[] expand)
        {
			List<int> expandList = new List<int>();
            foreach (int cijfer in expand)
            {
                for (int i = 0; i < count; i++)
                {
					expandList.Add(cijfer);
                }
            }
			return expandList.ToArray();
        }
	}
}
