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
        return IsValidBST2(root, int.MaxValue, int.MinValue);
    }

    public bool IsValidBST2(TreeNode root, int max, int min) {
        if(root == null) return true;

        if(root.val >= max || root.val <= min) return false;

        return IsValidBST2(
            root.left,
            root.val,
            min
        ) && IsValidBST2(
            root.right,
            max,
            root.val  
        );
    }
}
