#78. Subsets
class Solution:
    def subsets(self, nums: List[int]) -> List[List[int]]:
        result = []

        subset = []
        def dfs(i):
            if i >= len(nums):
                result.append(subset.copy())
                return
            
            #include the current number
            subset.append(nums[i])
            dfs(i + 1)

            #do not include number
            subset.pop()
            dfs(i + 1)

        dfs(0)
        return result