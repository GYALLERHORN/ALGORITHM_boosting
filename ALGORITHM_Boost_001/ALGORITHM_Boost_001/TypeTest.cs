using System;

public class TypeTest
{
    public string solution(string[] survey, int[] choices)
    {
        string answer = "RCJA";
        string answerRev = "TFMN"; 

        int[] results = new int[4];

        int score = 0;

        for (int i = 0; i < survey.Length; i++)
        {
            score = choices[i] - 4;

            switch (survey[i][0])
            {
                case 'R':
                    results[0] -= score;
                    break;
                case 'T':
                    results[0] += score;
                    break;
                case 'C':
                    results[1] -= score;
                    break;
                case 'F':
                    results[1] += score;
                    break;
                case 'J':
                    results[2] -= score;
                    break;
                case 'M':
                    results[2] += score;
                    break;
                case 'A':
                    results[3] -= score;
                    break;
                case 'N':
                    results[3] += score;
                    break;
            }

        }

        for (int i = 0; i < results.Length; i++)
        {
            if (results[i] < 0)
            {
                answer = answer.Replace(answer[i], answerRev[i]);
            }
        }

        return answer;
    }
}