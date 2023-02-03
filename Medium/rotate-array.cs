public class Solution {
    public void Rotate(int[] nums, int k) {
        k %= nums.Length;
        if (k == 0)
            return;
        var line = new Queue<int>();
        int i = 0;
        do {
            line.Enqueue(nums[i]);
            i++;
        } while (i < k);
        while (i < nums.Length)
        {
            line.Enqueue(nums[i]);
            nums[i] = line.Dequeue();
            i++;
        }
        i = 0;
        while (line.Count > 0)
        {
            nums[i] = line.Dequeue();
            i++;
        }
    }
}
