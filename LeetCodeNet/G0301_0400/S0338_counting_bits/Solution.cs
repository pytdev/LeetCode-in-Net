namespace LeetCodeNet.G0301_0400.S0338_counting_bits {

// #Easy #Dynamic_Programming #Bit_Manipulation #LeetCode_75_Bit_Manipulation
// #Udemy_Bit_Manipulation #Big_O_Time_O(num)_Space_O(num)
// #2025_06_16_Time_0_ms_(100.00%)_Space_43.52_MB_(53.08%)

public class Solution {
    public int[] CountBits(int num) {
        int[] result = new int[num + 1];
        int borderPos = 1;
        int incrPos = 1;
        for (int i = 1; i < result.Length; i++) {
            // when we reach pow of 2 ,  reset borderPos and incrPos
            if (incrPos == borderPos) {
                result[i] = 1;
                incrPos = 1;
                borderPos = i;
            } else {
                result[i] = 1 + result[incrPos++];
            }
        }
        return result;
    }
}
}
