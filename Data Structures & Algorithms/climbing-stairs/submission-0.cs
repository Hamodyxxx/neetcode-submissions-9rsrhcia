public class Solution {
    public int ClimbStairs(int n) {   
        if(n == 1) return 1;
        if(n == 2) return 2;  
        int n1 = 1, n2 = 2;
        int x;
        for(int i = 3; i <= n; i++) {
            x = n1 + n2;
            n1 = n2;
            n2 = x;
        }
        return n2;
    }
}
