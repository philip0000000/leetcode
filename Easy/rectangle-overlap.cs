// 1st
public class Solution {
    public bool IsRectangleOverlap(int[] rec1, int[] rec2) {
        if ((rec1[0] >= rec2[0] && rec1[0] >= rec2[2]) ||
            (rec1[2] <= rec2[0] && rec1[2] <= rec2[2]))
            return false;
        if ((rec1[1] <= rec2[1] && rec1[3] <= rec2[1]) ||
            (rec1[1] >= rec2[3] && rec1[3] >= rec2[3]))
            return false;
        return true;
    }
}

// 2nd
public class Solution {
    public bool IsRectangleOverlap(int[] rec1, int[] rec2) {
        return !((rec1[0] >= rec2[0] && rec1[0] >= rec2[2]) ||
                 (rec1[2] <= rec2[0] && rec1[2] <= rec2[2]) ||
                 (rec1[1] <= rec2[1] && rec1[3] <= rec2[1]) ||
                 (rec1[1] >= rec2[3] && rec1[3] >= rec2[3]));
    }
}
