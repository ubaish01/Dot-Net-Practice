class Assignment_22feb{

    static void printPatter()
    {
        System.Console.Write("Enter the number of rows you want to print : ");
        int n = int.Parse(System.Console.ReadLine());
        char a = System.Convert.ToChar(65);


        for(int i=0;i<n;i++)
        {
            for(int j=0;j<=i;j++)
            {
                System.Console.Write("{0} ",a);
            }
            System.Console.WriteLine();
            a++;
        }
    }

    static void midElementWithoutOperator()
    {
        int a = 24;
        int b = 50;
        int c = 95;

        // if(a>b)
        //     if(a>c)
        //         if(b>c)
        //             System.Console.WriteLine(b+" is the mid element !");
        //         else
        //             System.Console.WriteLine(c+" is the mid element !");
        // if(b>a)
        //     if(b>c)
        //         if(a>c)
        //             System.Console.WriteLine(a+" is the mid element !");
        //         else
        //             System.Console.WriteLine(c+" is the mid element !");
        // if(c>b)
        //     if(c>a)
        //         if(b>a)
        //             System.Console.WriteLine(b+" is the mid element !");
        //         else
        //             System.Console.WriteLine(a+" is the mid element !");

        if(a>b)
            if(a>c)
                if(b>c)
                    System.Console.WriteLine(b+" is the mid element !");
                else 
                    System.Console.WriteLine(c+" is the mid element !");
            else 
                System.Console.WriteLine(a+" is the mid element !");
        else
            if(a>c)
                System.Console.WriteLine(a+" is the mid element !");
            else    
                if(b<c)
                    System.Console.WriteLine(b+" is the mid element !");
                else 
                    System.Console.WriteLine(c+" is the mid element !");
            




    }

    static void Main()
    {
        midElementWithoutOperator();
    }
}