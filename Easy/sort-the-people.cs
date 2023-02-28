// 1st https://leetcode.com/problems/sort-the-people/submissions/906781757/
public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        var pq = new PriorityQueue<string, int>();
        for (int i = 0; i < heights.Length; i++)
            pq.Enqueue(names[i], -heights[i]);
        var ret = new List<string>();
        while (pq.Count>0)
            ret.Add(pq.Dequeue());
        return ret.ToArray();
    }
}

// 2nd https://leetcode.com/problems/sort-the-people/submissions/906782686/ 50%~
public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        for (int i = 0; i < heights.Length; i++)
            heights[i]=-heights[i];
        Array.Sort(heights, names);
        return names;
    }
}
