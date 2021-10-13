using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine
{
	class kordused
	{
		static void Main(string[] args)
		{
			/*string[]= new string[8] { "A", "B", "C", "D", "E", "F", "G", "H" };
			nimed[2] = "Anna";
			int nr = 0;
			while(nr<8)
			{
				Console.WriteLine("Tere,{0} õpilane", nimed [nr]);
				nr = nr + 1;
			}
			for (int i=0;i< nimed.Length;i++)
			{
				Console.WriteLine("Tere,{0} õpilane", nimed [i]);
			}
			foreach(var nimi in nimed)
			{
				Console.WriteLine("Tere,{0} õpilane", nimi);
			}
			nr=0
			do
			{
				Console.WriteLine("Tere,{0} õpilane", nimed[i]);
				nr++
			} while (nr!=nimed.Length);

			Console.ReadLine()

			Random rnd = new Random();
			int N = rnd.Next(2, 6);
			int M = rnd.Next(7, 14);
			int[] mass = new int [M-N];
			for (int i=N; i< M+1; i++)
			{
				mass[i - N] = i;
				Console.WriteLine(i*i);
			}
			foreach (var m in mass)


			int sum = 0;
			int mult = 1;
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("Palun sisesta number: ");
				int smt = Convert.ToInt32(Console.ReadLine());
				sum += smt;
				mult = smt * mult;
			}

			{
				double avg = sum / 5;
				Console.WriteLine($"Nums AVG={avg}\nNums SUM={sum}\nNums multiplited={mult}");
			}



			int A = rnd.Next(1, 25);
			int AA;//Kasutaja arv
			int K = 1;//Katset
			do
			{
				Console.WriteLine("{0} Katse. Mis arv?", K);
				AA=int.Parse(Console.ReadLine())
				K++;
			} while (AA!=A && K!=6);
			if(AA==A)
			{
				Console.WriteLine("Palju õnne!");
			}
			else
			{
				Console.WriteLine("Proovi veel!");
			}*/
			int arv;
			int[] arvud = new int[4];
			for(int i=0; i<4; i++)
			{
				Console.WriteLine("Sisesta{0}arv:", i + 1);
				arv = int.Parse(Console.ReadLine());
				arvud[i] = arv;
			}
			Array.Sort(arvud);
		
			int arv4 = 0;
			Array.Reverse(arvud);
			foreach (var a in arvud)
			{
				arv4 = arv4 * 10 + a;
			}
			Console.Write(arv4);
			Console.ReadLine();
		}
	}
} 
