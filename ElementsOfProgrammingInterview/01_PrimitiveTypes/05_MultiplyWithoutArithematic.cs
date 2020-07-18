using System;

public class Solution
{
    public static long MultiplyWithoutArithematic(long x, long y) {
        long multiply = 0;
        while(y > 0) {
            if((y & 1) == 1) {
                multiply = add(multiply, x);
            }
            x <<= 1;
            y >>= 1;
        }
        return multiply;
    }

    private static long add(long x, long y) => y == 0 ? x : add(x^y, (x & y)<<1);
}