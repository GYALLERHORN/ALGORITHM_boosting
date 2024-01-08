using System;
using System.Collections.Generic;

public class ReverseTernaryScale
{
    public int solution(int n)
    {
        int answer = 0;

        List<int> arr = new List<int>();

        while (true)
        {
            if (n < 3) // 시작부터 n<3이면 바로 끝내기
            {
                return n;
            }

            arr.Insert(0, n % 3);
            n = n / 3;
            if (n < 3)
            {
                arr.Insert(0, n);
                break;
            }
        }

        for (int i = 0; i <= arr.Count - 1; i++)
        {
            answer += (int)Math.Pow(3, i) * arr[i];
        }

        return answer;
    }
}