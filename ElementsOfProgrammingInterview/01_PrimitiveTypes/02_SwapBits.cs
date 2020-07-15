using System;

public class Solution {
    public static long SwapBits(long x, int i, int j) {
        if((x>>i) & 1 != (x>>j) & 1) {
            x ^= (1L<<i) | (1L<<j);
        }
        return x;
    }
}