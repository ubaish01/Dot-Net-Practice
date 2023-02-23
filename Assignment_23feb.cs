class Assignment_23feb
{
    static void selectionSort()
    {
        int []arr = new [] {9,12,54,87,23,87,12,54,98,5,2154,87,5};
        for(int i=0;i<arr.Length;i++)
        {
            System.Console.Write(arr[i]+" ");
        }
        System.Console.WriteLine();
        System.Console.WriteLine("-----------------------------");


        for(int i=0;i<arr.Length;i++)
        {
            for(int j=i+1;j<arr.Length;j++)
            {
                if(arr[i]<arr[j])
                {
                    arr[i] = arr[i]+arr[j];
                    arr[j] = arr[i]-arr[j];
                    arr[i] = arr[i]-arr[j];
                }
            }
        }

        for(int i=0;i<arr.Length;i++)
        {
            System.Console.Write(arr[i]+" ");
        }
        System.Console.WriteLine();
    }

    static void ultaTriangle()
    {
        System.Console.Write("Enter the number of rows you want to print : ");
        int n = int.Parse(System.Console.ReadLine());
        char c = System.Convert.ToChar(65);


        for(int i=0;i<n;i++)
        {
            for(int j=n;j>i;j--)
            {
                System.Console.Write(c+" ");
               
            }
            System.Console.WriteLine();
             c++;
        }
    }

    static void jaggedArray()
    {
        System.Console.Write("Enter the length of base array : ");
        int lengthOfBase = int.Parse(System.Console.ReadLine());
        int lengthOfSub;

        int [][] arr = new int [lengthOfBase][];

        for(int i=0;i<lengthOfBase;i++)
        {
            System.Console.Write("Enter the length of subArray at index ["+i+"] : ");
            lengthOfSub = int.Parse(System.Console.ReadLine());
            arr[i] = new int[lengthOfSub];
        }

        for(int i=0;i<arr.Length;i++)
        {
            for(int j=0;j<arr[i].Length;j++)
            {
                System.Console.Write("Enter the value at index ["+i+"]["+j+"] : ");
                arr[i][j] = int.Parse(System.Console.ReadLine());
            }
        }

        System.Console.WriteLine("--------------------Here is your Jagged Array----------------------------");
        for(int i=0;i<arr.Length;i++)
        {
            for(int j=0;j<arr[i].Length;j++)
            {
                System.Console.Write(arr[i][j]+" ");
            }
            System.Console.WriteLine();
        }
    }

    static void Main()
    {
        // selectionSort();
        // jaggedArray();
        ultaTriangle();
    }
}