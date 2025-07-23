using System;
using System.Collections.Generic;


namespace HashsetNamespace
{
	class ExampleHashset
	{
		static void Main()
		{
			HashSet<int> numbers = new HashSet<int>();
			numbers.Add(10);
			numbers.Add(20);
			numbers.Add(30);
			numbers.Add(30); ///it will remove in dynamic time. hashset avoids duplication


			foreach(int i in numbers)
			{
				Console.WriteLine(i);
			}


			HashSet<string> emails = new HashSet<string>();

			emails.Add("Mouni@gmail.com");
			emails.Add("Mouni@gmail.com"); // it won't print in output
			emails.Add("Mouni1@gmail.com");

			foreach(string s in emails)
			{
				Console.WriteLine("hashtable" + s);
			}

			if (emails.Contains("Mouni@gmail.com"))
			{
				Console.WriteLine("Yes .. it is available");
			}

			emails.Remove("Mouni@gmail.com");
			emails.Add("Mounica@gmail.com");



			List<string> emails1 = new List<string>();
			//we can get the all vails
			emails1.Add("pvryar@gmail.com");
			emails1.Add("pvryar@gmail.com");
			emails1.Add("pvryar@gmail.com");
			emails1.Add("pvryar@gmail.com");
			emails1.Add("pvryar1@gmail.com");

			foreach(string emailing in emails1)
			{
				Console.WriteLine("List " + emailing);
			}
			

		}
	}
}