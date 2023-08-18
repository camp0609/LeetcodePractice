import collections
# 102. Binary Tree Level Order Traversal

# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def levelOrder(self, root: Optional[TreeNode]) -> List[List[int]]:
        result = []

        queue = collections.deque()
        queue.append(root)

        while queue:
            queueLength = len(queue)
            currentLevel = []
            for i in range(queueLength):
                currentNode = queue.popleft()
                if currentNode:
                    currentLevel.append(currentNode.val)
                    queue.append(currentNode.left)
                    queue.append(currentNode.right)
            if currentLevel:
                result.append(currentLevel)


        return result