public class Solution {
    public int[] PlusOne(int[] digits) {
        
                string[] result = Array.ConvertAll(digits, x => x.ToString());
                string y = string.Join("", result);
				BigInteger bigIntFromInt64 = new BigInteger();
				BigInteger.TryParse(y, out bigIntFromInt64);
				bigIntFromInt64 = bigIntFromInt64 + 1;
                char[] chararray = bigIntFromInt64.ToString().ToCharArray();
                var resarray = new int[chararray.Length];
                for (int i = 0; i < chararray.Length; i++)
                {
                    resarray[i] = Convert.ToInt32(Char.GetNumericValue(chararray[i]));
                }
                return resarray;
    }
}