class Assigntment_15feb{
    static void numberOfDigits()
    {
        System.Console.Write("Enter the number : ");
        int n = System.Convert.ToInt32(System.Console.ReadLine());
        int count=0;
        int temp = n;
        while(temp>0){
            temp/=10;
            count++;
        }

        System.Console.WriteLine("Number of digitsi in {0} are {1}",n,count);
    }

    static void numberOfEvenAndOddDigits()
    {
        System.Console.Write("Enter the number : ");
        int n = System.Convert.ToInt32(System.Console.ReadLine());
        int odd=0,even=0;
        int temp = n;
        while(temp>0){
            int num = temp%10;
            if(temp%2==0) even++;
            else odd++;
            temp/=10;
        }

        System.Console.WriteLine("Odd digits are {0} and even digits are {1}",odd,even);
    }
    static void numberOfPrimeDigits()
    {
        System.Console.Write("Enter the number : ");
        int n = System.Convert.ToInt32(System.Console.ReadLine());
        int prime=0,nonPrime=0;
        int temp = n;
        while(temp>0){
            int num = temp%10;
            if(isPrime(num))
            {   
                System.Console.WriteLine(num+" is prime");
                prime++;
            } 
            else
            {
                System.Console.WriteLine(num+" is not prime");
                nonPrime++;
            } 
            temp/=10;
        }

        System.Console.WriteLine("Prime digits : "+prime);
        System.Console.WriteLine("Non Prime digits : "+nonPrime);
    }

    static bool isPrime(int n)
    {
        bool flag = true;
        for(int i=2;i<=n/2;i++)
        {
            if(n%i==0)
            {
                flag=false;
                break;
            }
            
        }
        
        return flag;
    }

    // static void doubleOfEveryDigit()
    // {
    //     System.Console.Write("Enter the number : ");
    //     int n = System.Convert.ToInt32(System.Console.ReadLine());
    //     int temp = n;
    //     while(temp>0){
    //         int num = temp%10;
    //         System.Console.Write(2*num);
    //         temp/=10;
    //     }
    // }
   

    static int cube(int n)
    {
        return n*n*n;
    }

    static void maxDigitsAmongNumber()
    {
        System.Console.Write("Enter the number : ");
        int maxi = -10;
        int n = System.Convert.ToInt32(System.Console.ReadLine());
        while(n>0){
            int num = n%10;
            if((cube(n%10))>maxi) maxi = cube(n%10);
            n/=10;
        }

        System.Console.WriteLine(maxi+" is the largest among all the digits");
    }

    static void minDigitsAmongNumber()
    {
        System.Console.Write("Enter the number : ");
        int n = flipNumber(System.Convert.ToInt32(System.Console.ReadLine()));
        // int mini = 10;
        int temp = 0;
        while(n>0){
            int num = 2*(n%10);
            temp = temp*10+(num);
            n/=10;
        }

        System.Console.WriteLine(temp+" is the double of every digit");
    }

    static int flipNumber(int n)
    {
        int ans=0;
        while(n>0)
        {
            ans = ans*10+(n%10);
            n/=10;
        }

        return ans;
    }
    static long flipNumber(long n)
    {
        long ans=0;
        while(n>0)
        {
            ans = ans*10+(n%10);
            n/=10;
        }

        return ans;
    }

    static void doubleOfEveryDigit()
    {
        System.Console.Write("Enter the number : ");
        int n = System.Convert.ToInt32(System.Console.ReadLine());
        int flipped = flipNumber(n);

        while(flipped>0){
            int num = flipped%10;
            System.Console.Write(num*2);
            flipped/=10;
        }

        // System.Console.WriteLine(mini+" is the smallest among all doubles of the digits");
        // System.Console.WriteLine(flipNumber(n));
    }

     static void squareOfEveryDigit()
    {
        System.Console.Write("Enter the number : ");
        long n = flipNumber(System.Convert.ToInt64(System.Console.ReadLine()));
        long temp = n;
        while(temp>0){
            long num = temp%10;
            System.Console.Write(num*num);
            temp/=10;
        }
        System.Console.WriteLine();
    }
    static void cubeOfEveryDigit()
    {
        System.Console.Write("Enter the number : ");
        long n = flipNumber(System.Convert.ToInt64(System.Console.ReadLine()));
        long temp = n;
        string ans="";
        while(temp>0){
            long num = temp%10;
            ans+= System.Convert.ToString(num*num*num);            
            temp/=10;
        }

        System.Console.WriteLine(ans);


        long num1 = System.Convert.ToInt64(ans);
        long maxi = -99999999;

        while(num1>0)
        {
            if((num1%10)>maxi) maxi = num1%10;
            num1/=10;
        }

        System.Console.WriteLine(maxi);
    }

    static void maxFromSquareOfEveryDigit()
    {
         System.Console.Write("Enter the number : ");
        long n = flipNumber(System.Convert.ToInt64(System.Console.ReadLine()));
        long temp = n;
        string ans="";
        while(temp>0){
            long num = temp%10;
            ans+= System.Convert.ToString(num*num);            
            temp/=10;
        }

        System.Console.WriteLine(ans);


        long num1 = System.Convert.ToInt64(ans);
        long maxi = -99999999;

        while(num1>0)
        {
            if((num1%10)>maxi) maxi = num1%10;
            num1/=10;
        }

        System.Console.WriteLine(maxi);



    }

    

    public static void Main(string [] args)
    {
        // numberOfDigits();
        // numberOfEvenAndOddDigits();
        // numberOfPrimeDigits();
        // doubleOfEveryDigit();
        // maxDigitsAmongNumber();
        // minDigitsAmongNumber();
        // doubleEveryDigit();
        // squareOfEveryDigit();
        // cubeOfEveryDigit();
        maxFromSquareOfEveryDigit();

    }
}