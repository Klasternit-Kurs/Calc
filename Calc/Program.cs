using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = 5;    //implicitan cast zato sto ne moze da bude problema
			double y = x;

			double x1 = 2;
			int y1 = (int)x1;  //eksplicitan cast jer imamo rizik

			byte b = 1;
			
			b -= 5;
			Console.WriteLine("Bajt je: " + b);

			uint nekiInt = 2;
			nekiInt -= 10;
			Console.WriteLine("Uint je: " + nekiInt);


			int broj = 1;
			broj = broj + 5;
			broj += 5;
			broj *= 2;

			broj++; //uveca za jedan
			broj--; //smanji za jedan
			++broj;

			broj = 5;

			Console.WriteLine(++broj); //6
			Console.WriteLine(broj++); //6
			Console.WriteLine(broj);
			//Izmena
			broj = 5;
			if (broj++ > 5)
			{
				Console.WriteLine("Jeste vece");
			}

			broj = 5;
			if (++broj > 5)
			{
				Console.WriteLine("Jeste vece");
			}

			broj = 0;
			Console.WriteLine(++broj);
			broj = 0;
			Console.WriteLine(broj++); 
			Console.WriteLine(broj);


			Console.Write("Unesite prvi broj: ");
			//string unos;
			//unos = Console.ReadLine();
			//int broj1 = int.Parse(unos);
			//Ovo iznad je isto kao i ova linija ispod :) 
			int broj1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Uneli ste: " + broj1);

			Console.Write("Unesite drugi broj: ");
			string unos2 = Console.ReadLine();
			Console.WriteLine("Uneli ste: " + unos2);
			int broj2 = int.Parse(unos2);


			Console.Write("Unesite + za sabirnje, - za oduzimanje, / za deljenje ili * za mnozenje: ");
			string operacija = Console.ReadLine();

			if (operacija == "+")
			{
				int zbir = broj1 + broj2;
				Console.WriteLine("Zbir je: " + zbir);
			}
			else if (operacija == "*")
			{
				int produkt = broj1 * broj2;
				Console.WriteLine("Proizvod je: " + produkt);
			} else if (operacija == "-")
			{
				int razlika = broj1 - broj2;
				Console.WriteLine("Razlika je: " + razlika);
			} else if (operacija == "/")
			{
				          //Eksplicitni cast
				double rez = (double)broj1 / broj2;
				Console.WriteLine("Rezultat je: " + rez);
			} else
			{
				Console.WriteLine("Nepostojeca operacija :(");
			} 

			//Ovo je samo radi toga 
			//da stane na kraju
			Console.ReadKey();
		}
	}
}
