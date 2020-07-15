using System;

public class Solution
{
    public static long ReverseBits(long x) {
        for(int i=0; i<32; i++) {
            x = swapBits(x, i, 63-i);
        }
        return x;
    }

    private static long swapBits(long x, int i, int j) {
        if(((x>>i) & 1L) != ((x>>j) & 1L)) {
            x ^= (1L<<i) | (1L<<j);
        }
        return x;
    }
}