//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace c_sharp;
using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Example Program class.
/// </summary>
public class Program
{
  /// <summary>
  /// Main.
  /// </summary>
  public static void Main()
  {
    /*
      C# Sharp String
    */
    // Exercise 1
    string inputStr = "w3resource.com";
    Console.Write("The characters of the string in reverse are : \n");
    int inputStrLength = inputStr.Length - 1;
    while (inputStrLength >= 0)
    {
      Console.Write("{0}", inputStr[inputStrLength]);
      inputStrLength--;
    }

    // Exercise 2
    string inputStrE2 = "This is w3resource.com";
    int wordsCount = inputStrE2.Split(" ").Count();
    Console.WriteLine($"Total number of words in the string is : {wordsCount}");

    // Exercise 3
    string inputStrE31 = "This is first string";
    string inputStrE32 = "This is first string";
    /*
      lengthFlg = 0 => inputStrE31 = inputStrE32
      lengthFlg = 1 => inputStrE31 > inputStrE32
      lengthFlg = -1 => inputStrE31 < inputStrE32
    */
    int lengthFlg = 0;
    /*
      contentFlg = 0 => content inputStrE31 = inputStrE32
      lengthFlg = 1 => content inputStrE31 != inputStrE32
    */
    int contentFlg = 0;
    int length1 = inputStrE31.Length;
    int length2 = inputStrE32.Length;

    if (length1 == length2)
    {
      lengthFlg = 0;
    }
    else if (length1 > length2)
    {
      lengthFlg = 1;
    }
    else if (length1 < length2)
    {
      lengthFlg = -1;
    }

    if (length1 == length2)
    {
      for (int i = 0; i < length1; i++)
      {
        if (inputStrE31[i] != inputStrE32[i])
        {
          contentFlg = 1;
          i = length1;
        }
      }
    }

    if (lengthFlg == 0)
    {
      if (contentFlg == 0)
      {
        Console.Write("\nThe length of both strings are equal and \nalso, both strings are same.\n\n");
      }
      else
      {
        Console.Write("\nThe length of both strings are equal \nbut both strings are not same.\n\n");
      }
    }

    /*
      LINQ
    */

    // Exercise 1
    // Init data with array 10 int
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

    // Exercise 2
    int min = -10;
    int max = 10;
    Random randNum = new Random();
    int[] n2 = Enumerable
        .Repeat(0, 10)
        .Select(i => randNum.Next(min, max))
        .ToArray();

    var query2 =
      from number2 in n2
      where number2 > 0
      where number2 < 12
      select number2;

    Console.Write("The numbers within the range of 1 to 11 are : \n");
    foreach (var number2 in query2)
    {
        Console.Write("{0}  ", number2);
    }

    // Exercise 3
    int min3 = 0;
    int max3 = 10;
    int[] n3 = Enumerable
        .Repeat(0, 10)
        .Select(i => randNum.Next(min3, max3))
        .ToArray();

    var query3 =
      from number3 in n3
      select new
      {
        text = "Number = " + number3 + ", " + "SqrNo = " + (number3 * number3) + "\n"
      };

    Console.Write("The number of an array and the square of each number : \n");
    foreach (var fn3 in query3)
    {
        Console.Write(fn3.text);
    }

    // Exercise 4
    int min4 = 0;
    int max4 = 20;
    int[] n4 = Enumerable
        .Repeat(0, 10)
        .Select(i => randNum.Next(min4, max4))
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

    foreach (var arr in query5)
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
    int min7 = 0;
    int max7 = 10;
    int[] n7 = Enumerable
        .Repeat(0, 10)
        .Select(i => randNum.Next(min7, max7))
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
      Console.WriteLine(arr.Key + " " + (arr.Key * arr.Count()) + " " + arr.Count() + "\n");
    }

    // Exercise 8
    string[] cities =
    {
        "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS", "NEW YORK",
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

    foreach (var city in query8)
    {
      Console.Write("The city starting with {0} and ending with {1} is : {2} \n", charStar, charEnd, city);
    }

    // Exercise 9
    int min9 = 0;
    int max9 = 1000;
    int[] n9 = Enumerable
        .Repeat(0, 10)
        .Select(i => randNum.Next(min9, max9))
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

    for (int i10 = 0; i10 < numberOfMem; i10++)
    {
      Console.Write("Member {0} : ", i10);
      int memOfList = Convert.ToInt32(Console.ReadLine());
      listNumber.Add(memOfList);
    }

    Console.Write("\nInput the value above you want to display the members of the List : ");
    int numberGreater = Convert.ToInt32(Console.ReadLine());

    List<int> result = listNumber.FindAll(x => x > numberGreater);
    Console.WriteLine("\nThe numbers greater than {0} are : ", numberGreater);
    foreach (var num in result)
    {
      Console.WriteLine(num);
    }

    Console.ReadLine();

    // Exercise 11
    int min11 = 0;
    int max11 = 100;
    List<int> l11 = Enumerable
        .Repeat(0, 10)
        .Select(i => randNum.Next(min11, max11))
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
    IEnumerable<string> result12 = str.Split(' ').Where(s => string.Equals(s, s.ToUpper(), StringComparison.Ordinal));
    Console.Write("\nThe UPPER CASE words are :\n ");
    foreach (string r in result12)
    {
      Console.WriteLine(r);
    }

    // Exercise 13
    Console.Write("Input number of strings to  store in the array :");
    int n13 = Convert.ToInt32(Console.ReadLine());
    string[] stringArr13 = new string[n13];
    Console.Write("Input {0} strings for the array  :\n", n13);
    for (int i13 = 0; i13 < n13; i13++)
    {
      Console.Write("Element[{0}] : ", i13);
      stringArr13[i13] = Console.ReadLine() ?? string.Empty;
    }

    string newstring = string.Join(", ", stringArr13
                        .Select(s => s.ToString()));
    Console.Write("\nHere is the string below created with elements of the above array  :\n");
    Console.WriteLine(newstring);
    Console.ReadLine();

    // Exercise 14
    Random rnd14 = new Random();
    IList<Student> studentList = new List<Student>()
    {
        new Student() { StudentID = 1, StudentName = "John", StudentPoint = rnd14.Next(900, 901) },
        new Student() { StudentID = 2, StudentName = "Moin", StudentPoint = rnd14.Next(900, 901) },
        new Student() { StudentID = 3, StudentName = "Bill", StudentPoint = rnd14.Next(100, 900) },
        new Student() { StudentID = 4, StudentName = "Ram", StudentPoint = rnd14.Next(100, 900) },
        new Student() { StudentID = 5, StudentName = "Ron", StudentPoint = rnd14.Next(100, 900) },
        new Student() { StudentID = 6, StudentName = "Eric", StudentPoint = rnd14.Next(100, 900) },
        new Student() { StudentID = 7, StudentName = "Jack", StudentPoint = rnd14.Next(100, 900) },
    };
    Console.WriteLine(" List Student: \n");
    foreach (var ir14 in studentList)
    {
      Console.WriteLine(" Id : {0},  Name : {1},  achieved Grade Point : {2}", ir14.StudentID, ir14.StudentName, ir14.StudentPoint);
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
      Console.WriteLine(" Id : {0},  Name : {1},  achieved Grade Point : {2}", i14.StudentID, i14.StudentName, i14.StudentPoint);
    }

    Console.ReadLine();

    // Exercise 15
    string[] arrFiles =
    {
      "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt",
      "abc.xml", "ccc.txt", "zzz.txt",
    };

    var fileGroup = arrFiles.Select(file => Path.GetExtension(file).Split('.').Last().ToLower())
                            .GroupBy(f => f, (name, count) => new
                            {
                              Name = name,
                              Count = count,
                            });
    foreach (var v in fileGroup)
    {
      Console.WriteLine("{0} File(s) with {1} Extension ", v.Count, v.Name);
    }

    // Exercise 16
    string filepath = Environment.CurrentDirectory + "/filesExample";
    string[] files = Directory.GetFiles(filepath);
    var avgFileSize = files.Select(file => new FileInfo(file).Length).Average();
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
    List<string> listOfString18 = new List<string>();
    listOfString18.Add("m");
    listOfString18.Add("n");
    listOfString18.Add("o");
    listOfString18.Add("p");
    listOfString18.Add("q");

    Console.Write("Here is the list of items : \n");
    foreach (var l18 in listOfString18)
    {
      Console.WriteLine("Char: {0} ", l18);
    }

    var findLetter = listOfString18.FirstOrDefault(en => en == "p");
    if (findLetter != null)
    {
      listOfString18.Remove(findLetter);
      Console.Write("\nHere is the list after removing the item 'o' from the list : \n");
      foreach (var l18a in listOfString18)
      {
        Console.WriteLine("Char: {0} ", l18a);
      }
    }

    // Exercise 19
    List<string> listOfString19 = new List<string>();
    listOfString19.Add("m");
    listOfString19.Add("n");
    listOfString19.Add("o");
    listOfString19.Add("p");
    listOfString19.Add("q");

    List<string> listResult = listOfString19.Where(s => s != "q").ToList();

    Console.Write("\nHere is the list after removing the item 'q' from the list : \n");
    foreach (var lr19 in listResult)
    {
      Console.WriteLine("Char: {0} ", lr19);
    }

    // Exercise 20
    int min20 = 0;
    int max20 = 10;
    int[] n20 = Enumerable
        .Repeat(0, 10)
        .Select(i => randNum.Next(min20, max20))
        .ToArray();

    var query20 =
      from number20 in n20
      let sqr20 = number20 * number20
      where sqr20 > 20
      select new
      {
        text = "Number = " + number20 + ", " + "SqrNo = " + sqr20 + "\n"
      };

    Console.Write("The number and its square of an array which is more than 20 : \n");
    foreach (var fn20 in query20)
    {
        Console.Write(fn20.text);
    }

    // Exercise 21
    List<string> listOfString21 = new List<string>();
    listOfString21.Add("m");
    listOfString21.Add("n");
    listOfString21.Add("o");
    listOfString21.Add("p");
    listOfString21.Add("q");

    listOfString21.RemoveRange(1, 3);

    Console.Write("\nHere is the list after removing the three items starting from the item index 1 from the list : \n");
    foreach (var lr21 in listOfString21)
    {
      Console.WriteLine("Char: {0} ", lr21);
    }

    // Exercise 22
    Console.Write("Input number of strings to  store in the array :");
    int n22 = Convert.ToInt32(Console.ReadLine());
    string[] arr22 = new string[n22];
    Console.Write("\nInput {0} strings for the array  :\n", n22);
    for (int i22 = 0; i22 < n22; i22++)
    {
      Console.Write("Element[{0}] : ", i22);
      arr22[i22] = Console.ReadLine() ?? string.Empty;
    }

    Console.Write("\nInput the minimum length of the item you want to find : ");
    int minimumLength = Convert.ToInt32(Console.ReadLine());

    var query22 =
        from string22 in arr22
        where string22.Length >= minimumLength
        select string22;

    Console.Write("\nThe items of minimum {0} characters are : \n", minimumLength);
    foreach (string rs22 in query22)
    {
      Console.WriteLine("Item: {0}", rs22);
    }

    Console.ReadLine();

    // Exercise 23
    char[] charList23 = { 'A', 'B', 'C' };
    int[] numList23 = { 1, 2, 3 };

    var cartesianProduct =
        from letterList in charList23
        from numberList in numList23
        select new { letterList, numberList };

    Console.Write("The Cartesian Product are : \n");
    foreach (var product in cartesianProduct)
    {
        Console.WriteLine(product);
    }

    // Exercise 24
    char[] charList24 = { 'A', 'B', 'C' };
    int[] numList24 = { 1, 2, 3 };
    string[] colorList24 = { "Green", "Orange" };

    var cartesianProduct24 =
        from letter in charList24
        from number in numList24
        from colour in colorList24
        select new { letter, number, colour };

    Console.Write("The Cartesian Product are : \n");
    foreach (var product24 in cartesianProduct24)
    {
        Console.WriteLine(product24);
    }

    // Exercise 25
    Item biscuit = new Item { ItemId = 1, ItemName = "Biscuit  " };
    Item chocolate = new Item { ItemId = 2, ItemName = "Chocolate" };
    Item butter = new Item { ItemId = 3, ItemName = "Butter" };
    Item brade = new Item { ItemId = 4, ItemName = "Brade" };
    Item honey = new Item { ItemId = 5, ItemName = "Honey" };
    List<Item> itemList25 = new List<Item> { biscuit, chocolate, butter, brade, honey };

    Purchase purchase1 = new Purchase { PurchaseId = 1, Item = biscuit,  PurchaseQty = 458 };
    Purchase purchase2 = new Purchase { PurchaseId = 2, Item = chocolate,  PurchaseQty = 650 };
    Purchase purchase3 = new Purchase { PurchaseId = 3, Item = butter,  PurchaseQty = 800 };
    Purchase purchase4 = new Purchase { PurchaseId = 4, Item = butter,  PurchaseQty = 900 };
    Purchase purchase5 = new Purchase { PurchaseId = 5, Item = butter,  PurchaseQty = 900 };
    Purchase purchase6 = new Purchase { PurchaseId = 6, Item = brade,  PurchaseQty = 650 };
    Purchase purchase7 = new Purchase { PurchaseId = 7, Item = brade,  PurchaseQty = 700 };
    List<Purchase> purchaseList25 = new List<Purchase> { purchase1, purchase2, purchase3, purchase4, purchase5, purchase6, purchase7 };

    var innerJoin =
        from i25 in itemList25
        join p25 in purchaseList25 on i25 equals p25.Item
        select new
        {
          ItemId = i25.ItemId,
          ItemName = i25.ItemName,
          PurchaseQty = p25.PurchaseQty,
        };

    Console.WriteLine("Item ID\t\tItem Name\tPurchase Quantity");
    Console.WriteLine("-------------------------------------------------------");
    foreach (var data in innerJoin)
    {
      Console.WriteLine(data.ItemId + "\t\t" + data.ItemName + "\t\t" + data.PurchaseQty);
    }

    // Exercise 26
    List<Item> itemList26 = new List<Item> { biscuit, chocolate, butter, brade, honey };
    List<Purchase> purchaseList26 = new List<Purchase> { purchase1, purchase2, purchase3, purchase4, purchase5, purchase6, purchase7 };

    var leftOuterJoin =
        from i26 in itemList26
        join p26 in purchaseList26
        on i26 equals p26.Item
        into gj
        from subPur in gj.DefaultIfEmpty(new Purchase())
        select new
        {
          ItemId = i26.ItemId,
          ItemName = i26.ItemName,
          PurchaseQty = subPur.PurchaseQty,
        };

    Console.WriteLine("Item ID\t\tItem Name\tPurchase Quantity");
    Console.WriteLine("-------------------------------------------------------");
    foreach (var data26 in leftOuterJoin)
    {
      Console.WriteLine(data26.ItemId + "\t\t" + data26.ItemName + "\t\t" + data26.PurchaseQty);
    }

    // Exercise 27
    List<Item> itemList27 = new List<Item> { biscuit, chocolate, butter, brade, honey };
    List<Purchase> purchaseList27 = new List<Purchase> { purchase1, purchase2, purchase3, purchase4, purchase5, purchase6, purchase7 };

    var rightOuterJoin =
        from p27 in purchaseList27
        join i27 in itemList27
        on p27.Item?.ItemId equals i27.ItemId
        into gj
        from subItem in gj.DefaultIfEmpty(new Item())
        select new
        {
          ItemId = subItem.ItemId,
          ItemName = subItem.ItemName,
          PurchaseQty = p27.PurchaseQty,
        };

    Console.WriteLine("Item ID\t\tItem Name\tPurchase Quantity");
    Console.WriteLine("-------------------------------------------------------");
    foreach (var data27 in rightOuterJoin)
    {
      Console.WriteLine(data27.ItemId + "\t\t" + data27.ItemName + "\t\t" + data27.PurchaseQty);
    }

    // Exercise 28
    Console.Write("\nHere is the arranged list :\n");
    IEnumerable<string> cityOrder =
                        cities.OrderBy(str => str.Length)
                        .ThenBy(str => str);

    foreach (string city in cityOrder)
    {
      Console.WriteLine(city);
      Console.ReadLine();
    }

    // Exercise 29
    var citySplit = from i in Enumerable.Range(0, cities.Length)
                                    group cities[i] by i / 2;

    foreach (var city in citySplit)
    {
      Console.WriteLine(string.Join(";  ", city.ToArray()));
      Console.WriteLine("-- here is a group of cities --\n");
    }

    // Exercise 30
    List<Item> itemList30 = new List<Item> { biscuit, chocolate, butter, brade, honey };

    var query30 =
        (from it30 in itemList30
        select it30.ItemName)
        .Distinct()
        .OrderBy(it => it);

    foreach (var i30 in query30)
    {
      Console.WriteLine(i30);
      Console.ReadLine();
    }
  }
}

/// <summary>
/// Student class.
/// </summary>
public class Student
{
  /// <summary>
  /// Gets or sets the ID of Student class.
  /// </summary>
  public int StudentID { get; set; }

  /// <summary>
  /// Gets or sets the StudentName of Student class.
  /// </summary>
  public string? StudentName { get; set; }

  /// <summary>
  /// Gets or sets the StudentPoint of Student class.
  /// </summary>
  public int StudentPoint { get; set; }
}

/// <summary>
/// Item class.
/// </summary>
public class Item
{
  /// <summary>
  /// Gets or sets the ID of Item class.
  /// </summary>
  public int ItemId { get; set; }

  /// <summary>
  /// Gets or sets the Name of Item class.
  /// </summary>
  public string? ItemName { get; set; }
}

/// <summary>
/// Purchase class.
/// </summary>
public class Purchase
{
  /// <summary>
  /// Gets or sets the Id of Purchase class.
  /// </summary>
  public int PurchaseId { get; set; }

  /// <summary>
  /// Gets or sets the Qty of Purchase class.
  /// </summary>
  public int PurchaseQty { get; set; }

  /// <summary>
  /// Gets or sets the Item of Purchase class.
  /// </summary>
  public Item? Item { get; set; }
}