// 1st
public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k) {
        int ret = 0;
        int p = 0;
        while (tickets[k]>0)
        {
            while (tickets[p]==0)
            {
                p++;
                if (p==tickets.Length)
                    p=0;
            }
            tickets[p]--;
            ret++;
            p++;
            if (p==tickets.Length)
                p=0;
        }
        return ret;
    }
}

// 2nd https://leetcode.com/problems/time-needed-to-buy-tickets/submissions/906555021/
public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k) {
        int ret = 0;
        var queue = new Queue<int>();
        for (int i = 0; i < tickets.Length; i++)
            queue.Enqueue(i);
        while (true)
        {
            int i = queue.Dequeue();
            tickets[i]--;
            ret++;
            if (tickets[i]>0)
                queue.Enqueue(i);
            else if (i==k)
                return ret;
        }
        return ret;
    }
}

// 3rd
public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k) {
        int ret = 0;
        for (int i = 0; i < tickets.Length; i++)
            if (tickets[i]<tickets[k])
                ret+=tickets[i];
            else
            {
                ret+=tickets[k];
                if (i>k)
                    ret--;
            }
        return ret;
    }
}
