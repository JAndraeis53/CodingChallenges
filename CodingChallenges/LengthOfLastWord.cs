public class Solution {
    public int LengthOfLastWord(string s) {
			//Delete all empty spaces from beginning and end of the string with Trim(' ')
			//Split all sentences if they have any spaces with Split(' ') and it returns a string array
			//[^1] calls last element in string array and gets its length
            return s.Trim(' ').Split(' ')[^1].Length;
    }
}