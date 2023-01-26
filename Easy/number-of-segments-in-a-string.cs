public class Solution {
    public int CountSegments(string s) {
        return s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }
}
