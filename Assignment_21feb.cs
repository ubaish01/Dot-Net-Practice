class Assignment_21feb{


    static int absolute(int n)
    {
        if(n<0) return -n;
        return n;
    }
    static void numberOfElements()
    {
        int [,] arr = new int [3,3];

        int count = 0;

        for(int i=0;i<arr.GetLength(0);i++)
        {
            for(int j=0;j<arr.GetLength(1);j++)
            {
                System.Console.Write("Enter the value at index ["+i+"]["+j+"] : ");
                arr[i,j] = System.Convert.ToInt32(System.Console.ReadLine());
                count++;
            }
        }

        for(int i=0;i<arr.GetLength(0);i++)
        {
            for(int j=0;j<arr.GetLength(1);j++)
            {
                System.Console.Write(arr[i,j]+" ");
            }
            System.Console.WriteLine();
        }

        System.Console.WriteLine("count = "+count);
    }

    static void sumOfElements()
    {
        int [,] arr = new int [3,3];

        int sum = 0;

        for(int i=0;i<arr.GetLength(0);i++)
        {
            for(int j=0;j<arr.GetLength(1);j++)
            {
                System.Console.Write("Enter the value at index ["+i+"]["+j+"] : ");
                arr[i,j] = System.Convert.ToInt32(System.Console.ReadLine());
                sum+=arr[i,j];
            }
        }

        System.Console.WriteLine("sum = "+sum);
    }

    static void numberOfEvenOddPrime()
    {
        System.Console.Write("Enter the size of base array : ");
        int baseSize = System.Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("Enter the size of child array : ");
        int childSize = System.Convert.ToInt32(System.Console.ReadLine());


        int [,] arr = new int [baseSize,childSize];

        int odd=0,even=0,prime=0,notPrime=0,positive=0,negative=0;
        bool isPrime = true;

        int i=0;
        int j,k;

        while(i<arr.GetLength(0))
        {
            j=0;
            while(j<arr.GetLength(1))
            {
                
                k=2;
                System.Console.Write("Enter the value at index ["+i+"]["+j+"] : ");
                arr[i,j] = System.Convert.ToInt32(System.Console.ReadLine());

                int dummy = absolute(arr[i,j]);
                
                // Checking  the number is prime or not 
                while(k<=(dummy/2))
                {
                    if(dummy%k==0)
                    {
                        isPrime = false;
                        break;
                    }
                    k++;
                }

                // counting the number of positive/negative numbers  
                if(arr[i,j]>0) positive++;
                else if(arr[i,j]<0) negative++;

                // counting the number of odd/even 
                if(arr[i,j]%2==0) even++;
                else odd++;

                // counting the number of prime/nonPrime 
                if(isPrime)
                    prime++;
                else 
                    notPrime++;

                isPrime = true;

                j++;
            }
            i++;
        }

        System.Console.WriteLine("Prime = "+prime);
        System.Console.WriteLine("nonPrime = "+notPrime);
        System.Console.WriteLine("even = "+even);
        System.Console.WriteLine("odd = "+odd);
        System.Console.WriteLine("positive = "+positive);
        System.Console.WriteLine("negative = "+negative);
    }



    static void doubeOfAllElements()
    {
        System.Console.Write("Enter the size of base array : ");
        int baseSize = System.Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("Enter the size of child array : ");
        int childSize = System.Convert.ToInt32(System.Console.ReadLine());


        int [,] arr = new int [baseSize,childSize];
        
        int i=0;
        int j;

        while(i<arr.GetLength(0))
        {
            j=0;
            while(j<arr.GetLength(1))
            {
                System.Console.Write("Enter the value at index ["+i+"]["+j+"] : ");
                arr[i,j] = 2*(System.Convert.ToInt32(System.Console.ReadLine()));
                j++;
            }
            i++;
        }
        j=i=0;
        while(i<arr.GetLength(0))
        {
            j=0;
            while(j<arr.GetLength(1))
            {
                System.Console.Write(arr[i,j]+" ");
                j++;
            }
            i++;
            System.Console.WriteLine();
        }

    }

    static void squareOfAllElements()
    {
        System.Console.Write("Enter the size of base array : ");
        int baseSize = System.Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("Enter the size of child array : ");
        int childSize = System.Convert.ToInt32(System.Console.ReadLine());

        int [,] arr = new int [baseSize,childSize];

        int i=0,j;
        while(i<arr.GetLength(0))
        {
            j=0;
            while(j<arr.GetLength(1))
            {
                System.Console.Write("enter the value for index ["+i+"]["+j+"] : ");
                arr[i,j] = System.Convert.ToInt32(System.Console.ReadLine());
                arr[i,j] *= arr[i,j];
                j++;
            }
            i++;
        }

        i=0;
        while(i<arr.GetLength(0))
        {
            j=0;
            System.Console.Write("[");
            while(j<arr.GetLength(1))
            {
                System.Console.Write(arr[i,j]+" ");
                j++;
            }
            System.Console.WriteLine("]");
            i++;
        }
    }


    static void maxMinElement()
    {
        System.Console.Write("Enter the size of base array : ");
        int baseSize = System.Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("Enter the size of child array : ");
        int childSize = System.Convert.ToInt32(System.Console.ReadLine());

        int [,] arr = new int [baseSize,childSize];

        int i=0;
        int j;
        int max = -2451364;
        int min = 54397465;
        while(i<arr.GetLength(0))
        {
            j=0;
            while(j<arr.GetLength(1))
            {
                System.Console.Write("Enter the value at index ["+i+"]["+j+"] : ");
                arr[i,j] = System.Convert.ToInt32(System.Console.ReadLine());
                if(arr[i,j]>max) max = arr[i,j];
                if(arr[i,j]<min) min = arr[i,j];
                j++;
            }
            i++;
        }

        System.Console.WriteLine("Max value : "+max);
        System.Console.WriteLine("min value : "+min);
    }


    static void Main(string []args)
    {
        // numberOfElements();
        // sumOfElements();
        // numberOfEvenOddPrime();
        // doubeOfAllElements();
        // squareOfAllElements();
        maxMinElement();
        // System.Console.WriteLine(-8%2);
    }
}