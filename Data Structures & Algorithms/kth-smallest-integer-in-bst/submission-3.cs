public class Solution {
    
    public int KthSmallest(TreeNode root, int k) {
        var s = new Stack<TreeNode>();
        var n = 0;
        
        while (root != null || s.Count  > 0) {
            while (root != null) {
                s.Push(root);
                root = root.left;
            }

            root = s.Pop();

            n++;

            if (k == n) return root.val;
            
            
            root = root.right;
        }

        return -1;
    }
    
}