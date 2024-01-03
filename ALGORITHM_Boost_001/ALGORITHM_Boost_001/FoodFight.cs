using System;
using System.Linq;

public class FoodFight
{
    public string solution(int[] food)
    {
        string answer = "";

        for (int i = 1; i < food.Length; i++)
        {
            int temp = food[i] / 2;
            for (int j = 0; j < temp; j++)
            {
                answer += i;
            }
        }

        char[] chaArr = answer.ToCharArray();
        Array.Reverse(chaArr);

        answer = answer + "0" + new string(chaArr);

        return answer;
    }
}