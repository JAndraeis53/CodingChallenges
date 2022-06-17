public class Solution {
    public int MySqrt(int x) {
        long left = 0;
        long right = x;
        if (x == 1)
        {
            return 1;
        }
        else
        {            
        while (left <= right)
        {
            long middle = (left + right) / 2;
            if (middle * middle == x)
            {
                return (int)middle;
            }
            if (middle * middle < x)
            {
                left = middle + 1;                
            }
            else
            {
                right = middle - 1;
            }         
        }
        }
    return (int)right;
    }
}