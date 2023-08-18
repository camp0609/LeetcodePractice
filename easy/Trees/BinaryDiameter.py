# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def __init__(self):
	    self.result = 0

    def dfs(self, node: Optional[TreeNode]) -> int:
            left = self.dfs(node.left) if node.left else 0
            right = self.dfs(node.right) if node.right else 0
            self.result = max(self.result, left + right)

            return 1 + max(left, right)

    def diameterOfBinaryTree(self, root: Optional[TreeNode]) -> int:
        self.dfs(root)
        return self.result