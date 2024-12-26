public class Solution {
    public int Compress(char[] chars) {
        int start = 0, end = chars.Length;
        int idx = 0;
        for(int i = 0; i < chars.Length; i++)
        {
            char ch = chars[i];
            // current character is assigned to variable ch
            int charCount = 0;
            while(i < chars.Length && chars[i] == ch)
            {
                // checking how many occurences of the current element are there
                charCount++;
                // stri=oring the number of elements in charCount variable
                i++;
            }
            chars[idx++] = ch;
            // storing the character at the correct index
            if(charCount > 1)
            {
                string charCountString = charCount.ToString();
                foreach(char dig in charCountString)
                {
                    // if character has more than one occurences than storing it's number of occurences next to it in the original array
                    chars[idx++] = dig;
                }
            }
            i--;
        }
        return idx;
    }
}
