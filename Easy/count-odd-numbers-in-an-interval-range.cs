// 1st
public class Solution {
    public int CountOdds(int low, int high) {
        int ret = 0;
        if ((low % 2) == 0 && (high % 2) == 0)
            ret = (high - low) / 2;
        else if ((low % 2) != 0 && (high % 2) != 0)
            ret = ((high - low) / 2)+1;
        else if ((low % 2) == 0 && (high % 2) != 0)
            ret = ((high - low) / 2)+1;
        else if ((low % 2) != 0 && (high % 2) == 0)
            ret = ((high - low) / 2)+1;
        return ret;
    }
}

// 2nd
public class Solution {
    public int CountOdds(int low, int high) {
        return (low % 2) == 0 && (high % 2) == 0 ? (high - low) / 2 : ((high - low) / 2)+1;
    }
}
