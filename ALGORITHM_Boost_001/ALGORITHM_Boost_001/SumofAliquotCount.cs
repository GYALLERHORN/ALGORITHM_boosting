using System;

public class SumofAliquotCount
{
    public int solution(int left, int right)
    {
        int answer = 0;

        for (int i = left; i <= right; i++)
        {
            int aliquotCount = 0;
            if (Math.Sqrt(i) % 1f == 0f) // 약수의 개수가 홀수인 경우는
            {
                aliquotCount++; // 따로 +1한다
            }
            for (int j = 1; j < Math.Sqrt(i); j++) // 약수 개수 구하기
            {
                if (i % j == 0) // 나누어떨어질 경우
                {
                    aliquotCount += 2; // +2
                }
            }
            if (aliquotCount % 2 == 0)
            {
                answer += i;
            }
            else
            {
                answer -= i;
            }
        }
        return answer;
    }
}