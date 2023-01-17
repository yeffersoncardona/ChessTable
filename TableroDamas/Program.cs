using System;

namespace TableroDamas
{
    class Program
    {
		static int n = 5;
		public static void Main(string[] args)
        {
			

				if (n > 10 || n <= 0)
				{
					n = 5;
				}
				int a = n;
				int b = n;
				int[,] arrayTablero = new int[a,b];

			for (int i = 0; i < arrayTablero.GetLength(0); i++)
			{
				bool x = i % 2 == 0;



				for (int j = 0; j < arrayTablero.GetLength(1); j++)
				{
					Console.Write(x ? "X" : "_");
					x = !x;
				}
				Console.WriteLine("");
			
		}
	}
    }
}
