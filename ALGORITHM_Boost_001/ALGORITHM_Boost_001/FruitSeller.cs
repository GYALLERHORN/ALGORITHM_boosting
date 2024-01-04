using System;
using System.Collections.Generic;
using System.Linq;

public class FruitSeller
{
    public int solution(int k, int m, int[] score)
    {
        int answer = 0;

        score = score.OrderByDescending(x => x).ToArray(); // 낮은 점수 과일 순으로 재정렬
        Queue<int> fruitsList = new Queue<int>();
        foreach (var fruit in score)
        {
            fruitsList.Enqueue(fruit); // Queue로 관리
        }

        List<int> fruitsBox = new List<int>(); // 과일 담을 상자

        for (int i = 0; i < score.Length; i++)
        {
            fruitsBox.Add(fruitsList.Dequeue()); // 낮은 점수 순부터 빼서 상자에 넣기 
            if (fruitsBox.Count == m) // 상자가 꽉 차면
            {
                answer += fruitsBox.Min() * m; // 상자 내 과일 최저점수로 상자점수 매겨서 합산
                fruitsBox.Clear(); // 상자 비우기
            }
        }

        return answer;
    }
}

