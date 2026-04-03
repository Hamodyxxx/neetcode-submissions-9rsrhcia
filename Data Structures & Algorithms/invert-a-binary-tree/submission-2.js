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
     * @return {TreeNode}
     */
    invertTree(node) {
        if(!node) return node;
        const stack = [node];

        while(stack.length != 0) {
            let node = stack.shift();

            if(node.left) stack.push(node.left);
            if(node.right) stack.push(node.right);

            let left = node.left;
            node.left = node.right;
            node.right = left;


        }
        return node;
    }
}
