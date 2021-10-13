using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine
{
	class abivahend
	{
		static void Main(string[] args)
		{
			Console.WriteLine(alamprogramm.Korruta(3, 6));
			Double arv1 = 5;
			Double arv2 = 6;

			Double result = alamprogramm.Eval(arv1.ToString() + "+" + arv2.ToString());
			Console.WriteLine(result);
			Console.ReadLine();
		}
	}
}
