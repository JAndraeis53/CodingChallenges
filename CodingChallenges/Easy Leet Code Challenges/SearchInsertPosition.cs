public class Solution {
    public int SearchInsert(int[] nums, int target) {
        var startIndex = 0;
        var endIndex = nums.Length - 1;
            while (startIndex <= endIndex)
            {
                //Instead of using  midPoint = (start + end)/2  to calculate the midpoint,
                //we use midPoint = start + (end - start)/2 to prevent integer overflow
                var midPoint = startIndex + (endIndex - startIndex) / 2;

                //we found the target, return the array index
                if (nums[midPoint] == target)
                    return midPoint;
                //Value inside the array is higher than the target value, move endIndex to midPoint -1
                if (nums[midPoint] > target)
                    endIndex = midPoint - 1;
                //Value inside the array is lower than the target value, move startIndex to midPoint +1
                else startIndex = midPoint + 1;
            }
            // return startIndex, this is the index where the target should've been stored in the array
            return startIndex;
    }
}