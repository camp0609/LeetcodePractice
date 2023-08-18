import collections
#199. Binary Tree Right Side View
# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def rightSideView(self, root: Optional[TreeNode]) -> List[int]:
        result = []

        queue = collections.deque()
        queue.append(root)

        while queue:
            rightNode = None
            queueLength = len(queue)
            
            for i in range(queueLength):
                node = queue.popleft()
                if node:
                    rightNode = node
                    queue.append(rightNode.left)
                    queue.append(rightNode.right)

            if rightNode:
                result.append(rightNode.val)
        
        return result
                