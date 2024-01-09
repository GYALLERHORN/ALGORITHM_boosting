using System;

class FindInsufficientMoney
{
    public long solution(int price, long money, int count)
    {
        long totalFee = 0;
        for (int i = 1; i <= count; i++)
        {
            totalFee += price * i;
        }
        if (totalFee <= money)
        {
            return 0;

        }
        return totalFee - money;
    }
}
