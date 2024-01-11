using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LongJump
{
    static void Main()
    {
        Console.WriteLine(solution(2000));
    }

    public static long solution(int n)
    {
        long answer = 0;

        //int minus2Count = 0;

        //while (n >= 0)
        //{
        //    answer += Fac(minus2Count + n) / (Fac(minus2Count) * Fac(n));
        //    n -= 2;
        //    minus2Count++;
        //}

        // 피보나치 수열이다. 1234567제한이 걸려있고, 메모리 제한으로 위의 방법은 불가능하다.

        if (n <= 3) return n;

        long num1 = 2;
        long num2 = 3;

        for (int i = 4; i <= n; i++)
        {
            Console.Write($"{num1},{num2},");
            answer = (num1 + num2) % 1234567;
            num1 = num2;
            num2 = answer;
            Console.WriteLine($"{answer}");
        }

        return answer;
    }

    //public long Fac(int n)
    //{
    //    if (n == 0)
    //    {
    //        return 1;
    //    } 


    //    int facN = 1;

    //    for (int i = 1; i <= n; i++)
    //    {
    //        facN *= i;
    //    }

    //    return facN;
    //}
}
