using System;
namespace pattern
{
public class Pattern
{
    public static void Main()
    {
        int rows,c;

        Console.Write("Enter the number of rows:");
        rows=Convert.ToInt32(Console.ReadLine());
        for(int i=0;i<rows;i++)
        {
            for (int s=0;s<rows-i;s++)
            Console.Write(" ");

            for(int j=0;j<=i;j++)
            {
                if(i==1||j==1)
                c=1;
                else
                c=c*(i-j+1)/j;
                Console.Write("{0}",c);
            }
            Console.WriteLine(" ");
        }
    }
}
}