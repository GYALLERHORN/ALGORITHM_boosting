using System;
using System.Collections.Generic;
using System.Linq;

public class HallOfHonor
{
    public int[] solution(int k, int[] score)
    {
        var answer = new List<int>();

        var hOH = new List<int>();
        for (int i = 0; i < score.Length; i++)
        {
            hOH.Add(score[i]); // score에 한개씩 넣으면서
            hOH = hOH.OrderByDescending(o => o).Take(k).ToList(); // 오름차순하고 최대 k개 뽑아내서
            int lowestScore = hOH.Min(); // 그중 최솟값을 찾아낸다 
            answer.Add(lowestScore);
        }

        return answer.ToArray();
    }
}
