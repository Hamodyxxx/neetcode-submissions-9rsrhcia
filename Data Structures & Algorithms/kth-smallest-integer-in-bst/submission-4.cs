public class Solution {
    int count = 0;
    int result = 0;
    
    public int KthSmallest(TreeNode root, int k) {
        count = k;
        traverse(root);
        return result;
    }
    void traverse(TreeNode root) {

        if(root == null) return;

        traverse(root.left);

        count--;

        if(count == 0) {
            result = root.val;
            return;
        }

        traverse(root.right);

    }
    
}