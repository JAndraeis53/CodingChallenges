public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        // This is what we are returning 
        string p = string.Empty;
        
        // this is going to be the max amount of times we loop
        int length = int.MaxValue;
        
        // This grabs the string with the shortest length and sets its length to length
        foreach (var str in strs)
            if (str.Length < length)
                length = str.Length;
        
        // This is going to increment each time a char[index] is equal to eachother 
        int c = 0;
        
        // For each char in the shortest string
        for (int o = 0; o < length; o++) {
            
            // For each string, if the string[i] char is equal, increment
            for (int i = 1; i < strs.Length; i++)
                if (strs[i - 1][o] == strs[i][o])
                    c++;
            
            if (c != strs.Length -1)
                break;
            
            
            // Add char onto prefix string
            p += strs[0][o];
            
            // Reset counter
            c = 0;
        }
        
        return p;
    }
}