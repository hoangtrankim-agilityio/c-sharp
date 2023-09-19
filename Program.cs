namespace c_sharp;
class Program
{
	static void Main(string[] args)
	{
		/* 
			C# Sharp String 
		*/
		// Exercise 1
		string inputStr = "w3resource.com";
		Console.Write("The characters of the string in reverse are : \n");
		int inputStrLength = inputStr.Length - 1;
		while(inputStrLength >=0 )
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
		int lengthFlg=0;
		/* 
			contentFlg = 0 => content inputStrE31 = inputStrE32
			lengthFlg = 1 => content inputStrE31 != inputStrE32
		*/
		int contentFlg = 0;
		int length1 = inputStrE31.Length;
		int length2 = inputStrE32.Length;

		if(length1 == length2)
      lengthFlg=0;
    else if(length1 > length2)
      lengthFlg=1;
    else if(length1 < length2)
      lengthFlg=-1;

		if(length1 == length2)
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
		if(lengthFlg == 0)
    {
      if(contentFlg==0)
       	Console.Write("\nThe length of both strings are equal and \nalso, both strings are same.\n\n");
      else
        Console.Write("\nThe length of both strings are equal \nbut both strings are not same.\n\n");
    }

	}
}
