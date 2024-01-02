using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DescendingString
{
    public string solution(string s)
    {
        List<char> sArray = new List<char>();

        foreach (char c in s) // 주어진 문자열의 문자 하나하나를 분리해 배열화
        {
            sArray.Add(c);
        }
        var arr = from c in sArray
                  orderby c descending
                  select c; // ASCII 10진법에 따라 내림차순 재정렬

        StringBuilder sb = new StringBuilder();
        foreach (char c in arr) // 배열을 다시 문자열화
        {
            sb.Append(c);
        }

        string answer = sb.ToString();
        return answer;
    }
}
