using System;
using System.Collections.Generic;
using System.Linq;

public class ChangebaseKSystem
{
    static void Main(string[] args)
    {
        int n = 2;
        int k = 3;

        int answer = solution(n, k);

        Console.WriteLine($"\n{answer}");
    }

    public static int solution(int n, int k)
    {
        int answer = 0;

        string KNum = "";

        while (true)
        {
            if (n < k)
            {
                KNum = n.ToString(); break;
            }

            KNum = KNum.Insert(0, (n % k).ToString());
            n = n / k;

            if (n < k)
            {
                KNum = KNum.Insert(0, n.ToString()); break;
            }
        }

        List<string> without0 = KNum.Split('0').ToList();

        foreach (var item in without0)
        {
            Console.WriteLine(item);
        }

        foreach (string s in without0)
        {
            long sToI = 0;
            bool bo = long.TryParse(s, out sToI);
            if (sToI == 1) continue;
            else if (sToI == 2)
            { answer++; continue; }

            int iRoot = (int)Math.Sqrt(sToI);

            for (int i = 2; i <= iRoot; i++)
            {
                bool b = sToI % i == 0 ? false : true;
                if (!b) break;
                if (b && i == iRoot) answer++;
            }
        }

        return answer;
    }
}