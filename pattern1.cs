class Pattern1{

    static void drawPattern(int n)
    {
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<=i;j++)
            {
                System.Console.Write(" * ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine();
        }
    }

    public static void Main(string [] args)
    {
        System.Console.Write("Enter the number of rows : ");
        int rows = System.Convert.ToInt32(System.Console.ReadLine());
        drawPattern(rows);
        System.Console.WriteLine("Program Finished !");
    }
}