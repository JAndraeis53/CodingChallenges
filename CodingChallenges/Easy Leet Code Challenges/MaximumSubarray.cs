Surprisingly, it is possible to solve the problem in O(n) time, which means that
just one loop is enough. The idea is to calculate, for each array position, the
maximum sum of a subarray that ends at that position. After this, the answer
for the problem is the maximum of those sums.
Consider the subproblem of finding the maximum-sum subarray that ends at
position k. There are two possibilities:

The subarray only contains the element at position k.
The subarray consists of a subarray that ends at position k −1, followed by
the element at position k.
In the latter case, since we want to find a subarray with maximum sum, the
subarray that ends at position k −1 should also have the maximum sum. Thus,
we can solve the problem efficiently by calculating the maximum subarray sum
for each ending position from left to right

public int MaxSubArray(int[] nums) 
{
	int best = nums[0], sum = 0;
	for(var i = 0; i < nums.Length; ++i)
	{
		sum = Math.Max(nums[i], sum + nums[i]);
		best = Math.Max(best, sum);
	}
	return best;
}