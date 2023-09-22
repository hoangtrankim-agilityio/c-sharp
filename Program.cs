namespace c_sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

class Program
{
	static void Main(string[] args)
	{
		/* 
			C# Sharp String 
		*/
		// // Exercise 1
		// string inputStr = "w3resource.com";
		// Console.Write("The characters of the string in reverse are : \n");
		// int inputStrLength = inputStr.Length - 1;
		// while(inputStrLength >=0 )
		// {
		// 	Console.Write("{0}", inputStr[inputStrLength]);
		// 	inputStrLength--;
		// }

		// // Exercise 2
		// string inputStrE2 = "This is w3resource.com";
		// int wordsCount = inputStrE2.Split(" ").Count();
		// Console.WriteLine($"Total number of words in the string is : {wordsCount}");

		// // Exercise 3
		// string inputStrE31 = "This is first string";
		// string inputStrE32 = "This is first string";
		// /* 
		// 	lengthFlg = 0 => inputStrE31 = inputStrE32
		// 	lengthFlg = 1 => inputStrE31 > inputStrE32
		// 	lengthFlg = -1 => inputStrE31 < inputStrE32
		// */
		// int lengthFlg=0;
		// /* 
		// 	contentFlg = 0 => content inputStrE31 = inputStrE32
		// 	lengthFlg = 1 => content inputStrE31 != inputStrE32
		// */
		// int contentFlg = 0;
		// int length1 = inputStrE31.Length;
		// int length2 = inputStrE32.Length;

		// if(length1 == length2)
    //   lengthFlg=0;
    // else if(length1 > length2)
    //   lengthFlg=1;
    // else if(length1 < length2)
    //   lengthFlg=-1;

		// if(length1 == length2)
		// {
		// 	for (int i = 0; i < length1; i++)
		// 	{
		// 		if (inputStrE31[i] != inputStrE32[i])
		// 		{
		// 			contentFlg = 1;
		// 			i = length1;
		// 		}
		// 	}
		// }
		// if(lengthFlg == 0)
    // {
    //   if(contentFlg==0)
    //    	Console.Write("\nThe length of both strings are equal and \nalso, both strings are same.\n\n");
    //   else
    //     Console.Write("\nThe length of both strings are equal \nbut both strings are not same.\n\n");
    // }

		/*
			LINQ
		*/
		// Exercise 1
		//Init data with array 10 int
		int[] n1 = Enumerable.Range(0, 10).ToArray();
		
		// nQuery is an IEnumerable<int>
		var query =
				from n in n1
				where (n % 2) == 0
				select n;

		// Query execution.
		Console.Write("The numbers which produce the remainder 0 after divided by 2 are : \n");
		foreach (int n in query)
		{
			Console.Write("{0} ", n);
		}

		//Exercise 2
		int Min = -10;
		int Max = 10;
		Random randNum = new Random();
		int[] n2 = Enumerable
				.Repeat(0, 10)
				.Select(i => randNum.Next(Min, Max))
				.ToArray();

		var query2 = 
			from number2 in n2
			where number2 > 0 
			where number2 < 12 
			select number2;  
		
		Console.Write("The numbers within the range of 1 to 11 are : \n");			
		foreach(var number2 in query2) 
		{			
				Console.Write("{0}  ", number2); 
		}

		// Exercise 3
		int Min3 = 0;
		int Max3 = 10;
		int[] n3 = Enumerable
				.Repeat(0, 10)
				.Select(i => randNum.Next(Min3, Max3))
				.ToArray();

		var query3 = 
			from number3 in n3
			select new { 
				text = "Number = " + number3 + ", "+ "SqrNo = " + number3 * number3 + "\n"
			};  
		
		Console.Write("The number of an array and the square of each number : \n");			
		foreach(var n in query3) 
		{			
				Console.Write(n.text); 
		}

		// Exercise 4
		int Min4 = 0;
		int Max4 = 20;
		int[] n4 = Enumerable
				.Repeat(0, 10)
				.Select(i => randNum.Next(Min4, Max4))
				.ToArray(); 
		Console.Write("The numbers in the array are : \n");
		foreach (var i in n4)
		{
			Console.WriteLine(i + ", ");
		}
			
		var query4 =
		 		from x in n4  
				group x by x into grouping 
				select grouping;  
		Console.WriteLine("The number and the Frequency are : \n"); 
		foreach (var arr in query4)  
		{  
			Console.WriteLine("Number " + arr.Key + " appears " + arr.Count() + " times \n");  
		} 

		// Exercise 5
		char[] text = "apple".ToCharArray();
		var query5 =
				from c in text
				group c by c into grouping
				select grouping;

		foreach(var arr in query5)  
		{  
			Console.WriteLine("Character " + arr.Key + ": " + arr.Count() + " times");  
		} 

		// Exercise 6
		string[] dayOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
			
		var days = 
			   from d in dayOfWeek 
				 select d;
		foreach (var d in days)
		{
				Console.WriteLine(d);
		}

		// Exercise 7
		int Min7 = 0;
		int Max7 = 10;
		int[] n7 = Enumerable
				.Repeat(0, 10)
				.Select(i => randNum.Next(Min7, Max7))
				.ToArray(); 
		Console.Write("The numbers in the array are : \n");
		foreach (var i in n7)
		{
			Console.WriteLine(i + ", ");
		}
		var query7 =
		 	 from x7 in n7  
				 group x7 by x7 into grouping 
				 select grouping;  
		Console.WriteLine("Number Number*Frequency Frequency : \n"); 
		foreach (var arr in query7)  
		{  
			Console.WriteLine(arr.Key + " " + arr.Key * arr.Count() +  " " +  arr.Count() + "\n");  
		} 

		// Exercise 8
		string[] cities =  
		{  
				"ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"  
		};
		string charStar = "A";
		string charEnd = "M"; 
		Console.Write("\nInput starting character for the string : " + charStar);  
		Console.Write("\nInput ending character for the string : " + charEnd + "\n"); 

		var query8 =
			  from city in cities  
				where city.StartsWith(charStar)  
				where city.EndsWith(charEnd)  
				select city;  
	
		foreach(var city in query8)  
		{  
				Console.Write("The city starting with {0} and ending with {1} is : {2} \n", charStar, charEnd, city);  
		} 

		// Exercise 9
		int Min9 = 0;
		int Max9 = 1000;
		int[] n9 = Enumerable
				.Repeat(0, 10)
				.Select(i => randNum.Next(Min9, Max9))
				.ToArray(); 
		Console.Write("The members of the list are : \n");
		foreach (var i in n9)
		{
			Console.WriteLine(i + ", ");
		}

		var query9 = 
				from number9 in n9
				where number9 > 200
				select number9;

		Console.WriteLine("The numbers greater than 80 are : \n");
		foreach (var n in query9)
		{
			Console.WriteLine(n + "\n");
		}

		// Exercise 10
		List<int> listNumber = new List<int>(); 
		Console.Write("Input the number of members on the List : ");  
		int numberOfMem = Convert.ToInt32(Console.ReadLine());             
		
		for(int i = 0; i < numberOfMem; i++)
		{
			Console.Write("Member {0} : ",i);  
			int memOfList= Convert.ToInt32(Console.ReadLine()); 
			listNumber.Add(memOfList);
		}
		
		Console.Write("\nInput the value above you want to display the members of the List : ");  
		int numberGreater = Convert.ToInt32(Console.ReadLine());     

		List<int> result = listNumber.FindAll(x => x > numberGreater ? true : false);  
		Console.WriteLine("\nThe numbers greater than {0} are : ",numberGreater);
		foreach (var num in result)  
		{  
			Console.WriteLine(num);  
		}  
		Console.ReadLine();

		// Exercise 11
		int Min11 = 0;
		int Max11 = 100;
		List<int> l11 = Enumerable
				.Repeat(0, 10)
				.Select(i => randNum.Next(Min11, Max11))
				.ToList(); 
		Console.Write("The members of the list are : \n");
		foreach (var i in l11)
		{
			Console.WriteLine(i + ", ");
		}

		Console.Write("\nHow many records you want to display ? : ");  
		int numberRecord = Convert.ToInt32(Console.ReadLine());
		l11.Sort();
		l11.Reverse();

		Console.Write("The top {0} records from the list are : \n", numberRecord);  
		foreach (int i in l11.Take(numberRecord))
		{
			Console.WriteLine(i);
		}
		Console.ReadLine();

		// Exercise 12
		string str = "this IS a STRING";
		IEnumerable<string> result12 = str.Split(' ').Where(s => String.Equals(s, s.ToUpper(), StringComparison.Ordinal ));
		Console.Write("\nThe UPPER CASE words are :\n ");
		foreach (string r in result12)
		{
			Console.WriteLine(r);
		}
		
	}
}
