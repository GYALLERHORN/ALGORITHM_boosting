using System;
using System.Collections.Generic;
using System.Text;

public class MakeHamburger
{
    public int solution(int[] ingredient)
    {
        int answer = 0;

        StringBuilder sb = new StringBuilder();

        foreach (int i in ingredient)
        {
            sb.Append(i);
        }

        string ingre = sb.ToString();

        int breadPos = 0;

        while (true)
        {
            if (ingre.Contains("1231"))
            {
                breadPos = ingre.IndexOf("1231");
                for (int i = 0; i < 4; i++)
                {
                    ingre.Remove(ingre[breadPos]);
                }
                answer++;
            }
            else
            {
                break;
            }
        }

        return answer;
    }
}

