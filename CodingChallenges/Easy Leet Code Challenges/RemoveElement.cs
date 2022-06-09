public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var count = nums.Length;
        
        for(int i = 0; i < nums.Length; i++){
            if(val == nums[i]){
                nums[i] = 101;
                count--;
            }
        }
        
        Array.Sort(nums);
        return count;
    }
}