class IsAnagram {
    public static bool GetIsAnagram(string s, string t) {
        int[] alphabet = new int[26];

        for(int i = 0; i < s.Length; i++) {
            alphabet[s[i] - 'a']++;
        }
        for(int i = 0; i < t.Length; i++) {
            alphabet[t[i] - 'a']--;
        }

        for(int i = 0; i < alphabet.Length; i++) {
            if(alphabet[i] != 0) {
                return false;
            }
        }
        return true;
    }

    public static bool GetIsAnagramHashmap(string s, string t) {
        Dictionary<char, int> alphabet = new Dictionary<char, int>();
        
        for(int i = 0; i < s.Length; i++) {
            alphabet.Add(s[i], alphabet.GetValueOrDefault(s[i], 0) + 1);
        }
        for(int i = 0; i < t.Length; i++) {
            alphabet.Add(t[i], alphabet.GetValueOrDefault(t[i], 0) - 1);
        }

        foreach(var letter in alphabet) {
            if(letter.Value != 0) {
                return false;
            }
        }
        return true;
    }
}