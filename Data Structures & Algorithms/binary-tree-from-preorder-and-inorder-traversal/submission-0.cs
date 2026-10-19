public class Solution {
    int inorderIdx = 0;
    int preorderIdx = 0;

    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        return Build2(preorder, inorder, int.MinValue);
    }

    public TreeNode Build2(int[] preorder, int[] inorder, int stop) {
        if (preorderIdx >= preorder.Length) return null;
        if (inorder[inorderIdx] == stop) {
            inorderIdx++;
            return null;
        }

        var n = new TreeNode(preorder[preorderIdx++]);

        n.left = Build2(preorder, inorder, n.val);
        n.right = Build2(preorder, inorder, stop);

        return n;
    }
}