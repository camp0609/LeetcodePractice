class TopKFrequent {
    public static int[] GetTopKFrequent(int[] nums, int k) {
        int[] result = new int[k];
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        List<int>[] bucket = new List<int>[nums.Length + 1];

        for(int i = 0; i < nums.Length; i++) {
            if(frequency.ContainsKey(nums[i])) {
                frequency[nums[i]]++;
            }else {
                frequency.Add(nums[i], 1);
            }
        }

        foreach(var keyVal in frequency) {
            if(bucket[keyVal.Value] == null){
                bucket[keyVal.Value] = new List<int>();
            }
            bucket[keyVal.Value].Add(keyVal.Key);
        }

        int resultCount = 0;

        for(int i = bucket.Length - 1; i >= 0; i--) {
            if(bucket[i] != null) {
                for(int j = 0; j < bucket[i].Count; j++) {
                    result[resultCount] = bucket[i][j];
                    resultCount++;
                    if(resultCount == k) {
                        return result;
                    }
                }
            }
        }
        return result;
    }
}