class practice_18feb{

	static void CheckChar()
	{
		System.Console.Write("Enter the character : ");
		char c = System.Convert.ToChar(System.Console.ReadLine());
		if(c>=97 && c<=122)
		{
			System.Console.WriteLine("Small");
		}
		else if(c>=65 && c<=95)
		{
			System.Console.WriteLine("Capital");
		}
		else if(c>=48 && c<=57)
		{
			System.Console.WriteLine("Number");
		}
		else
		{
			System.Console.WriteLine("Special Character");
		}
	}
	static void printAlphabets()
	{
		char c = System.Convert.ToChar(97);

		// while(c<91)
		// {
		// 	System.Console.Write(c+" ");
		// 	c++;
		// }



		for(int i = 0;i<5;i++)
		{
			for(int j=0;j<=5;j++)
			{
				System.Console.Write(c+" ");
				c++;
				if(c==123)
					{
						break;
					}
			}
			System.Console.WriteLine();
		}
	}


	static void Main(string [] args)
	{
		
	printAlphabets();
	}


}