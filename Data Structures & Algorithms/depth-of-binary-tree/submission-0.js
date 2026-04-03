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
        let max = 0;
        const stack = [
            {
                node: root,
                depth: 1
            }
        ]

        while(stack.length) {
            const curr = stack.shift();

            max = Math.max(max, curr.depth);

            if(curr.node.left) stack.push({
                node: curr.node.left,
                depth: curr.depth + 1
            })

            if(curr.node.right) stack.push({
                node: curr.node.right,
                depth: curr.depth + 1
            })

        }

        return max;
    }
}
