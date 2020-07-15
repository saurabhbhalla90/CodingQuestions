using System;

public class Solution
{
    public static long ClosestIntegerSameWeight(long x) {
        int i = 0;
        while(i<63 && ((x>>i & 1) == (x>>(i+1) & 1))) {
            i++;
        }
        return x ^ 3L<<i;
    }
}