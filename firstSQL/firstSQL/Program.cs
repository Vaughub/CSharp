using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace firstSQL
{
	class Program
	{
		static async Task Main(string[] args)
		{
			QueryData<Person> data = new QueryData<Person>("person");
			QueryData<Pet> petData = new QueryData<Pet>("pet");
			//var testData = new QueryData<int>("Ola");

			//Person per = new Person();
			//var propertyInfos = per.GetType().GetFields();

			IEnumerable<Person> readById = await data.ReadById(2);




			Console.WriteLine(readById);


			//var add = await data.AddData("Grøt", "Tryne");
			//Console.WriteLine($"{add} rows affected");

			//var delete = await data.DeleteData(8);
			//Console.WriteLine($"{delete} rows affected\n");

			//var all = await data.ReadAll();
			//foreach (var p in all)
			//{
			//	Console.WriteLine(p.Id + " " + p.FirstName + " " + p.LastName);
			//}

			//var petAll = await petData.ReadAll();
			//foreach (var p in petAll)
			//{
			//	Console.WriteLine($"{p.Animal} {p.Name}");
			//}


			//var persons = all.OrderBy(e => e.Id).Reverse().Where(e => e.FirstName.StartsWith("O"));

			Console.WriteLine();
		}




		//static void Test()
		//{
		//	long x = long.MaxValue;
		//	Console.WriteLine(x);

		//	float f = x;
		//	double d = x;
		//	decimal m = x;
		//	Console.WriteLine(f);
		//	Console.WriteLine(d);
		//	Console.WriteLine(m);
		//	Console.WriteLine();
		//	//int.Parse()
		//	//Console.WriteLine(double.Parse("6,00234419836431E+15", NumberStyles.Any));

		//	int[] numbers = new int[1000];
		//	numbers[88] = 1;
		//	numbers[20] = 1;
		//	numbers[40] = 2;
		//	numbers[889] = 1;
		//	//Array
		//	//if (numbers.Any(t => t == 1))
		//	//{
		//	//	Console.WriteLine("Done!");
		//	//	return;
		//	//}


		//	var list = new List<object>(20);
		//	//var arraySegment = new ArraySegment<int>();
		//	int[] array = new int[10];
		//	ArrayList myAL = new ArrayList();

		//	list.Add(5);
		//	list.Add("5");
		//	list.Add(true);
		//	myAL.Add(5);
		//	myAL.Add("5");

		//	object trop;
		//	trop = 4;
		//	trop = "4";

		//	var enumerable = numbers.Select(n => n).ToArray();
		//	var enumerableB = numbers.Where(r => r == 1).ToArray();
		//	var kek = numbers.Any(f => f == 1);
		//	//bool frop = numbers.Any(h => h == 1);
		//}
	}
}
