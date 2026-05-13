/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsValidBST(TreeNode root) {
        List<int> sbLarger = [], sbSmaller = [];

        return IsValidBST2(root, sbLarger, sbSmaller);
    }

    public bool IsValidBST2(TreeNode root, List<int> sbLarger, List<int> sbSmaller) {
        if(root == null) return true;

        for(int i = 0; i < sbLarger.Count; i++) {
            if(root.val <= sbLarger[i]) return false;
        }

        for(int i = 0; i < sbSmaller.Count; i++) {
            if(root.val >= sbSmaller[i]) return false;
        }

        bool isRight = true;

        if(root.left != null) {
            sbSmaller.Add(root.val);
            isRight = isRight && IsValidBST2(root.left, sbLarger, sbSmaller);
            sbSmaller.RemoveAt(sbSmaller.Count - 1);
        }

        if(root.right != null) {
            sbLarger.Add(root.val);
            isRight = isRight && IsValidBST2(root.right, sbLarger, sbSmaller);
            sbLarger.RemoveAt(sbLarger.Count - 1);
        }

        return isRight;
    }
}
