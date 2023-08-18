class Solution:
    def lastStoneWeight(self, stones: List[int]) -> int:
        stones = [-s for s in stones]
        heapq.heapify(stones)

        while len(stones) > 1:
            stone1 = heapq.heappop(stones)
            stone2 = heapq.heappop(stones)

            newStone = stone1 - stone2
            if newStone != 0:
                heapq.heappush(stones, newStone)
            
        stones.append(0)
        return abs(stones[0])