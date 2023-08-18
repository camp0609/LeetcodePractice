class LongestSubstring {
    public static int GetLongestSubstring(string s) {
        int i = 0, j = 0, max = 0;
        HashSet<char> set = new HashSet<char>();
    
        while (j < s.Length) {
            if (!set.Contains(s[j])) {
                set.Add(s[j++]);
                max = Math.Max(max, set.Count);
            } else {
                set.Remove(s[i++]);
            }
        }
    
        return max;
    } 
}