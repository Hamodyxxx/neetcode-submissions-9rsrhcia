/**
 * Definition for a binary tree node.
 * class TreeNode {
 *     constructor(val = 0, left = null, right = null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

class Solution {
    /**
     * @param {TreeNode} root
     * @return {number}
     */
    maxDepth(root) {
        if(!root) return 0;
        return this.getMaxDepth(root, 1, {depth: 1});
    }

    getMaxDepth(node, depth, max) {
        max.depth = Math.max(max.depth, depth);

        if(node.left) this.getMaxDepth(node.left, depth+1, max);
        if(node.right) this.getMaxDepth(node.right, depth+1, max);

        return max.depth;
    }
}
