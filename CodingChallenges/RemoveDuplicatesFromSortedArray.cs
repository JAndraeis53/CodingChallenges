public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length == 0 || nums == null)return 0;
        
        int currEl = 0;
        for(int i=1;i<nums.Length;i++)
        {
            if(nums[currEl] != nums[i])
            {
                currEl++;
                nums[currEl] = nums[i];
            }
        }
        return currEl+1;
    }
}