using System;
using System.Linq;
using System.Collections.Generic;

public class SelectTangerine
{
    public int solution(int k, int[] tangerine)
    {
        int answer = 0;

        Dictionary<int, int> tangerineAmountD = new Dictionary<int, int>();

        foreach (int t in tangerine)
        {
            if (tangerineAmountD.ContainsKey(t)) tangerineAmountD[t]++; // t사이즈 귤이 이미 있다면, 해당 갯수 +1 <tangerine[t]가 되는 거였다.>
            else tangerineAmountD.Add(t, 1); // t사이즈 귤이 dictionary에 없다면, 해당 사이즈 짝을 하나 생성
        }

        List<int> tangerineAmount = new List<int>();

        foreach (KeyValuePair<int, int> item in tangerineAmountD)
        {
            tangerineAmount.Add(item.Value); // tangerineAmountD의 Value값만을 List화
        }

        tangerineAmount = tangerineAmount.OrderByDescending(x => x).ToList(); // 내림차순 정렬

        int tangerineInBox = 0;

        foreach (int t in tangerineAmount)
        {
            if (tangerineInBox >= k) // 귤박스가 가득 차면 끝
            {
                break;
            }
            tangerineInBox += t; // 갯수가 많은 사이즈부터 담기
            answer++;
        }

        return answer;
    }
}