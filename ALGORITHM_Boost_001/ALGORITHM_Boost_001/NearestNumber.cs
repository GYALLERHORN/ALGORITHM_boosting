using System;

public class NearestNumber
{
    public int[] solution(string s)
    {
        int[] answer = new int[s.Length];

        int index = -1;

        for (int i = 0; i < s.Length; i++) // 0번째 인덱스에서 출발
        {
            index = -1; // 처음 나오는 글자는 -1로 초기화
            for (int j = i - 1; j >= 0; j--) // i번째 앞에서부터 0번째 인덱스까지 순환
            {
                if (s[j] == s[i])
                {
                    index = i - j;
                    break;
                }
            }
            answer[i] = index;
        }
        return answer;
    }
}