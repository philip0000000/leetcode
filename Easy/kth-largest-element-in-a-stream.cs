// 1st
public class KthLargest {

    private int maxLength;
    private PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

    public KthLargest(int k, int[] nums) {
        int i = 0;
        for (int j = 0; i < nums.Length && j < k; i++, j++)
        {
            pq.Enqueue(nums[i], nums[i]);
        }
        while (i < nums.Length)
        {
            if (pq.Peek() < nums[i])
            {
                pq.Enqueue(nums[i], nums[i]);
                pq.Dequeue();
            }
            i++;
        }
        maxLength = k;
    }
    
    public int Add(int val) {
        if (pq.Count < maxLength)
            pq.Enqueue(val, val);
        else if (pq.Count >= maxLength && pq.Peek() < val)
        {
            pq.Enqueue(val, val);
            pq.Dequeue();
        }
        return pq.Peek();
    }
}

// 2nd Beats 97.33%
public class KthLargest {

    private int maxLength;
    private PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
    private int tempPeek = Int32.MinValue;

    public KthLargest(int k, int[] nums) {
        int i = 0;
        for (int j = 0; i < nums.Length && j < k; i++, j++)
        {
            pq.Enqueue(nums[i], nums[i]);
        }
        if (pq.Count > 0)
            tempPeek = pq.Peek();
        while (i < nums.Length)
        {
            if (tempPeek < nums[i])
            {
                pq.Enqueue(nums[i], nums[i]);
                pq.Dequeue();
                tempPeek = pq.Peek();
            }
            i++;
        }
        maxLength = k;
    }
    
    public int Add(int val) {
        if (pq.Count < maxLength)
        {
            pq.Enqueue(val, val);
            tempPeek = pq.Peek();
        }
        else if (pq.Count >= maxLength && tempPeek < val)
        {
            pq.Enqueue(val, val);
            pq.Dequeue();
            tempPeek = pq.Peek();
        }
        return tempPeek;
    }
}
