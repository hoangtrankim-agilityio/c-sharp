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
		foreach(var fn3 in query3) 
		{			
				Console.Write(fn3.text); 
		}

		// Exercise 4
		int Min4 = 0;
		int Max4 = 20;
		int[] n4 = Enumerable
				.Repeat(0, 10)
				.Select(i => randNum.Next(Min4, Max4))
				.ToArray(); 
		Console.Write("The numbers in the array are : \n");
		foreach (var i4 in n4)
		{
			Console.WriteLine(i4 + ", ");
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
		foreach (var i7 in n7)
		{
			Console.WriteLine(i7 + ", ");
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
		foreach (var i9 in n9)
		{
			Console.WriteLine(i9 + ", ");
		}

		var query9 = 
				from number9 in n9
				where number9 > 200
				select number9;

		Console.WriteLine("The numbers greater than 80 are : \n");
		foreach (var fn9 in query9)
		{
			Console.WriteLine(fn9 + "\n");
		}

		// Exercise 10
		List<int> listNumber = new List<int>(); 
		Console.Write("Input the number of members on the List : ");  
		int numberOfMem = Convert.ToInt32(Console.ReadLine());             
		
		for(int i10 = 0; i10 < numberOfMem; i10++)
		{
			Console.Write("Member {0} : ", i10);  
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
		foreach (var i11 in l11)
		{
			Console.WriteLine(i11 + ", ");
		}

		Console.Write("\nHow many records you want to display ? : ");  
		int numberRecord = Convert.ToInt32(Console.ReadLine());
		l11.Sort();
		l11.Reverse();

		Console.Write("The top {0} records from the list are : \n", numberRecord);  
		foreach (int fn11 in l11.Take(numberRecord))
		{
			Console.WriteLine(fn11);
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

		// Exercise 13	
		Console.Write("Input number of strings to  store in the array :");
		int n13 = Convert.ToInt32(Console.ReadLine()); 
		string[] stringArr13 =new string[n13];      
		Console.Write("Input {0} strings for the array  :\n", n13);
		for(int i13 = 0; i13 < n13; i13++)
		{
			Console.Write("Element[{0}] : ", i13);
			stringArr13[i13] = Console.ReadLine();	
		}

		string newstring = String.Join(", ", stringArr13
												.Select(s => s.ToString()));
		Console.Write("\nHere is the string below created with elements of the above array  :\n");                          
		Console.WriteLine(newstring);
		Console.ReadLine();

		// Exercise 14
		Random rnd14 = new Random();
		IList<Student> studentList = new List<Student>() { 
				new Student() { StudentID = 1, StudentName = "John", StudentPoint = rnd14.Next(900, 901)},
				new Student() { StudentID = 2, StudentName = "Moin", StudentPoint = rnd14.Next(900, 901)},
				new Student() { StudentID = 3, StudentName = "Bill", StudentPoint = rnd14.Next(100, 900)},
				new Student() { StudentID = 4, StudentName = "Ram" , StudentPoint = rnd14.Next(100, 900)},
				new Student() { StudentID = 5, StudentName = "Ron" , StudentPoint = rnd14.Next(100, 900)},
				new Student() { StudentID = 6, StudentName = "Eric" , StudentPoint = rnd14.Next(100, 900)},
				new Student() { StudentID = 7, StudentName = "Jack" , StudentPoint = rnd14.Next(100, 900)} 
		};
		Console.WriteLine(" List Student: \n");
		foreach (var ir14 in studentList)
		{	
			Console.WriteLine(" Id : {0},  Name : {1},  achieved Grade Point : {2}",ir14.StudentID, ir14.StudentName, ir14.StudentPoint);
		}

		Console.Write("Which maximum grade point(1st, 2nd, 3rd, ...) you want to find  : ");
		int rank = Convert.ToInt32(Console.ReadLine()); 			
		Console.Write("\n"); 
		var students = 
					(from student in studentList  
					group student by student.StudentPoint into g
					orderby g.Key descending
					select g).ToList();
		foreach (var i14 in students[rank - 1])
		{
			Console.WriteLine(" Id : {0},  Name : {1},  achieved Grade Point : {2}",i14.StudentID, i14.StudentName, i14.StudentPoint);
		};
		Console.ReadLine();


		// Exercise 15
		string[] arrFiles = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt",
                             "abc.xml", "ccc.txt", "zzz.txt" };

		var fileGroup = arrFiles.Select(file => Path.GetExtension(file).Split('.').Last().ToLower())
														.GroupBy(f => f, (name, count) => new {
															Name = name,
															Count = count
														});
		foreach (var v in fileGroup)
		{
			Console.WriteLine("{0} File(s) with {1} Extension ", v.Count, v.Name);
		}

		// Exercise 16
		string filepath = Environment.CurrentDirectory + "/filesExample";
		string[] files = Directory.GetFiles(filepath);
		var avgFileSize = files.Select(file =>new FileInfo(file).Length).Average();
		Console.WriteLine("The Average file size is {0} MB", avgFileSize);

		// Exercise 17
		List<string> listOfString17 = new List<string>();
		listOfString17.Add("m");
		listOfString17.Add("n");
		listOfString17.Add("o");
		listOfString17.Add("p");
		listOfString17.Add("q");

		Console.Write("Here is the list of items : \n");
		foreach (var l17 in listOfString17)
		{
			Console.WriteLine("Char: {0} ", l17);
		}

		listOfString17.Remove("o");
		Console.Write("\nHere is the list after removing the item 'o' from the list : \n");
		foreach (var l17a in listOfString17)
		{
			Console.WriteLine("Char: {0} ", l17a);
		}

		// Exercise 18
		// TODO: Don't clear 
	}
}


public class Student{
	public int StudentID { get; set; }
	public string StudentName { get; set; }
	public int StudentPoint { get; set; }
}