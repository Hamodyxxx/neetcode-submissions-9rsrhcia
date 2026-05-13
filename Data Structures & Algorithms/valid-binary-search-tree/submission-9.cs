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
        if(root == null) return true;

        List<int> sbLarger = [], sbSmaller = [];

        return IsValidBST2(ref root, ref sbLarger, ref sbSmaller);
    }

    public bool IsValidBST2(ref TreeNode root, ref List<int> sbLarger, ref List<int> sbSmaller) {
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
            isRight = isRight && IsValidBST2(ref root.left, ref sbLarger, ref sbSmaller);
            sbSmaller.RemoveAt(sbSmaller.Count - 1);
        }

        if(root.right != null) {
            sbLarger.Add(root.val);
            isRight = isRight && IsValidBST2(ref root.right, ref sbLarger, ref sbSmaller);
            sbLarger.RemoveAt(sbLarger.Count - 1);
        }

        return isRight;
    }
}
