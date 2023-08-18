class GroupAnagrams{
    public static IList<IList<string>> GetGroupAnagrams(string[] strs) {
        Dictionary<string, IList<string>> groupAnagrams = new Dictionary<string, IList<string>>(); 
        for(int i = 0; i < strs.Length; i++) {
            var chars = strs[i].ToCharArray();
            Array.Sort(chars);
            string key = new String(chars);
            if(groupAnagrams.ContainsKey(key)) {
                groupAnagrams[key].Add(strs[i]);
            }else {
                groupAnagrams.Add(key, new List<string>{strs[i]});
            }
        }
        return groupAnagrams.Values.ToList();
    }
}