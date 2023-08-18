using System.Text;

class LongestComPrefix {

    public static string GetLongestCommonPrefix(string[] strings) {
        
        StringBuilder longestCommonPrefix = new StringBuilder();
        if(strings == null || strings.Length == 0) {
            return longestCommonPrefix.ToString();
        }

        //find shortest string, longest prefix is limited to the shortest string
        int shortestString = strings[0].Length;
        foreach(string str in strings) {
            shortestString = Math.Min(shortestString, str.Length);
        }


        for(int i = 0; i < shortestString; i++) {
            char currentChar = strings[0][i];

            foreach(string str in strings) {
                if(currentChar != str[i]) {
                    return longestCommonPrefix.ToString();
                }
                longestCommonPrefix.Append(currentChar);
            }
        }
        return longestCommonPrefix.ToString();

    }
}