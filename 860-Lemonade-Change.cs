public class Solution {
    public bool LemonadeChange(int[] bills)
    {
        int five = 0, ten = 0;
        foreach (int b in bills)
        {
            if (b == 5)
            {
                five++;
            }
            else if (b == 10)
            {
                ten++;
                int change = b - 5; // Equivalent to deducting $5 as change given
                if (five > 0)
                {
                    five--;
                }
                else
                {
                    return false;
                }
            }
            else if (b == 20)
            {
                int change = b - 5;
                if (five > 0 && ten > 0)
                {
                    five--;
                    ten--;
                }
                else if (five >= 3)
                {
                    five -= 3;
                }
                else
                {
                    return false;
                }
            }
        }
        return true;
    }
}