// 1st
public class Solution {
    public int MaxProduct(int[] nums) {
        Array.Sort(nums);
        return (nums[nums.Length-2]-1)*(nums[nums.Length-1]-1);
    }
}

// 2nd 20%~
public class Solution {
    public int MaxProduct(int[] nums) {
        var pq = new PriorityQueue<int, int>();
        foreach (int i in nums)
            pq.Enqueue(i, -i);
        return (pq.Dequeue()-1)*(pq.Dequeue()-1);
    }
}

// 3rd 50%~
public class Solution {
    public int MaxProduct(int[] nums) {
        int Biggest = Int32.MinValue, Big2nd = Int32.MinValue;
        foreach (int i in nums)
            if (i > Biggest)
            {
                Big2nd = Biggest;
                Biggest = i;
            }
            else if (i > Big2nd)
                Big2nd = i;
        return (Biggest-1)*(Big2nd-1);
    }
}
