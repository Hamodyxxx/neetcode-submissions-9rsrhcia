public class Solution {
    public int KthSmallest(TreeNode root, int k) {
        var list = new LinkedList<int>();
        var node = list.AddFirst(root.val);
        
        traverse(root, list, node);
        var current = list.Last;
        for (int i = 1; i < k; i++)
        {
            current = current.Previous;
        }
        
        return current.Value;
    }

    public void traverse(TreeNode root, LinkedList<int> arr, LinkedListNode<int> parent) {
        
        if(root == null) return;

        if (root.left != null) {
            var leftNode = arr.AddAfter(
                parent,
                root.left.val
            );

            traverse(
                root.left,
                arr,
                leftNode
            );
        }
        
        if (root.right != null) {
            var node = arr.AddBefore(
                parent,
                root.right.val
            );

            traverse(
                root.right,
                arr,
                node
            );
        }
        
    }



}
