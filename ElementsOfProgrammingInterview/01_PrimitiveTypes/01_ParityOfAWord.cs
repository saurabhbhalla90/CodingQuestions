using System;

public class Solution {
    public static int Parity(long x) {
        int y = 32;
        while(y > 0) {
            long temp = x>>y;
            x ^= temp;
            y = y >> 1;
        }
        return x & 1;
    }
}