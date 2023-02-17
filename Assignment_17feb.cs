class Assigntment_17feb{

    // Question 1
    static void numOfEvenOdd(int [] arr)
    {
        int odd = 0,even=0;
        foreach(int item in arr)
        {
            if(item%2==0) even++;
            else odd++;
        }

        System.Console.WriteLine("Even numbers : "+even);
        System.Console.WriteLine("Odd numbers : "+odd);
    }

    
    // Question 2
    static void numOfPositiveNegative(int [] arr)
    {
        int pos = 0,neg=0;
        foreach(int item in arr)
        {
            if(item>=0) pos++;
            else neg++;
        }

        System.Console.WriteLine("positive count : "+pos);
        System.Console.WriteLine("negative count : "+neg);
    }
    // Question 3
    static bool isPrime(int n)
    {
        for(int i=2;i<=n/2;i++)
        {
            if(n%i==0) return false;
        }

        return true;
    }

    static void numOfPrimeAndNonePrime(int [] arr)
    {
        int prime = 0,nonPrime=0;
        foreach(int item in arr)
        {
            if(isPrime(item)) prime++;
            else nonPrime++;
        }

        System.Console.WriteLine("prime count : "+prime);
        System.Console.WriteLine("nonPrime count : "+nonPrime);
    }

    // Question 4
    static void maxElementInArray(int [] arr)
    {
        int maxi = System.Int32.MinValue;
        foreach(int item in arr)
        {
            if(item>maxi) maxi = item;
        }

        System.Console.WriteLine("Highest value : "+maxi);
    }

    static void minElementInArray(int [] arr)
    {
        int min = System.Int32.MaxValue;
        foreach(int item in arr)
        {
            if(item<min) min = item;
        }

        System.Console.WriteLine("Minimum value : "+min);
    }

    // Question 5
    static void sumOfArray(int []arr)
    {
        int sum = 0;
        foreach(int item in arr)
        {
            sum+=item;
        }
        System.Console.WriteLine("The sum of all element is "+sum);
    }
    // Question  6
    static void countTheElements(int []arr)
    {
        int count = 0;
        foreach(int item in arr)count++;
        System.Console.WriteLine("The number of elements in this array :  "+count);
    }
    // Question 7
    static void reverseTheArray(int []arr)
    {
        int n = arr.Length;
        for(int i=0;i<n/2;i++)
        {
            int temp = arr[i];
            arr[i] = arr[arr.Length-1-i];
            arr[arr.Length-1-i] = temp;
        }
        
        System.Console.WriteLine("Printing reverse of the array...");
        foreach(int item in arr) System.Console.Write(" {0} ",item);
    }
    // Question 8.1
    static void ascendingOrder(int []arr)
    {
        int n = arr.Length;
        for(int i=0;i<n;i++)
        {
            for(int j=1;j<n-i;j++)
            {
                if(arr[j-1]>arr[j])
                {
                    arr[j] = arr[j-1]+arr[j];
                    arr[j-1] = arr[j]-arr[j-1];
                    arr[j] = arr[j] - arr[j-1];

                    // int temp = arr[j-1];
                    // arr[j-1] = arr[j];
                    // arr[j] = temp;
                }
            }
        }
        
        System.Console.WriteLine("Printing ascending order of the array...");
        foreach(int item in arr) System.Console.Write(" {0} ",item);
    }
    // Question 8.2
    static void descendingOrder(int []arr)
    {
        int n = arr.Length;
        for(int i=0;i<n;i++)
        {
            for(int j=1;j<n-i;j++)
            {
                if(arr[j-1]<arr[j])
                {
                    arr[j] = arr[j-1]+arr[j];
                    arr[j-1] = arr[j]-arr[j-1];
                    arr[j] = arr[j] - arr[j-1];

                    // int temp = arr[j-1];
                    // arr[j-1] = arr[j];
                    // arr[j] = temp;
                }
            }
        }
        
        System.Console.WriteLine("Printing ascending order of the array...");
        foreach(int item in arr) System.Console.Write(" {0} ",item);
    }
    // Question 9
    static void linearSearch(int []arr,int key)
    {
        int n = arr.Length;
        bool found = false;
        int elemIndex = 0;

        for(int i=0;i<n;i++)
        {
            if(arr[i]==key)
            {
                found = true;
                elemIndex = i;
            }
        }
        
        if(found)
            System.Console.WriteLine("Element {0} fount at index {1}",key,elemIndex);
        else 
            System.Console.WriteLine("Element {0} not found in array",key);

    }
    static void binarySearch(int []arr,int key)
    {
        int n = arr.Length;
        int low = 0,high = n-1;
        bool found = false;
        int elemIndex = 0;
        int mid = (high+low)/2;

        while(low<=high)
        {
            mid = (low+high)/2;
            if(arr[mid]==key)
            {
                found = true;
                elemIndex = mid;
                break;
            }
            else if(key>arr[mid])
            {
                low=mid+1;
            }
            else
            {
                high = mid-1;
            }
        }
        
       if(found)
            System.Console.WriteLine("Element {0} fount at index {1}",key,elemIndex);
        else 
            System.Console.WriteLine("Element {0} not found in array",key);

    }

    static void Main(string []args)
    {
        System.Console.Write("Enter the number of element : ");
        int n = System.Convert.ToInt32(System.Console.ReadLine());

        int [] arr = new int[n];

        for(int i=0;i<n;i++)
        {
            System.Console.Write("enter the element at postion {0} : ",i+1);
            arr[i] = System.Convert.ToInt32(System.Console.ReadLine());
        }

        // numOfEvenOdd(arr); 1
        // numOfPositiveNegative(arr); 2
        // numOfPrimeAndNonePrime(arr); 3
        // maxElementInArray(arr); 4.1
        // minElementInArray(arr); 4.2
        // sumOfArray(arr); 5
        // countTheElements(arr); 6
        // reverseTheArray(arr); 7
        // ascendingOrder(arr); 8.1
        // descendingOrder(arr);
        // linearSearch(arr,5);
        binarySearch(arr,5);


    }
}