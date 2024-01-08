using System;
public class StarryRectangle
{
    public void solution()
    {
        string[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int n = Int32.Parse(s[0]); // 행
        int m = Int32.Parse(s[1]); // 열

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
