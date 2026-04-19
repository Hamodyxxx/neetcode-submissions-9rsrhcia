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
     * @return {number[][]}
     */
    levelOrder(root) {
        if(!root) return [];
        const res = [];
        this.levelTriversal(root, 0, res);
        return res;
    }

    levelTriversal(node, level, record) {
        if(!record[level]) record[level] = [];

        record[level].push(node.val);
        if(node.left) this.levelTriversal(node.left, level + 1, record);
        if(node.right) this.levelTriversal(node.right, level + 1, record);

    }
}
