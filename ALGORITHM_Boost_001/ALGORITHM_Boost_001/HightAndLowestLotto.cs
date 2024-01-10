using System;

public class HightAndLowestLotto
{
    public int[] solution(int[] lottos, int[] win_nums)
    {
        int[] answer = new int[2] { 7, 7 }; // 7,7로 설정하고 1씩 차감

        for (int i = 0; i < lottos.Length; i++)
        {
            if (lottos[i] == 0) // 숫자 판별 불가의 경우
            {
                answer[0]--; // 로또번호가 맞을 가능성 있음->기대 최고순위 상승
                continue;
            }
            for (int j = 0; j < win_nums.Length; j++)
            {
                if (lottos[i] == win_nums[j]) // 적은번호가 로또에 있을 경우
                {
                    answer[0]--; // 기대 최고&최저 순위 상승
                    answer[1]--;
                }
            }
        }

        for (int i = 0; i < answer.Length; i++)
        {
            if (answer[i] == 7) answer[i] = 6; // 다 틀릴 경우는 6등
        }

        return answer;
    }
}