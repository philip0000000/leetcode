// Solution 1
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var Found = new System.Collections.Generic.HashSet<int>();
        foreach(int n in nums)
        {
            if (Found.Contains(n) == true)
                return true;
            Found.Add(n);
        }

        return false;
    }
}

// Solution 2
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var Found = new System.Collections.Generic.HashSet<int>();
        for (int m = nums.Length - 1; m >= 0; m--)
        {
            if (Found.Add(nums[m]) == false) // Add return false if the element is already present
                return true;
        }

        return false;
    }
}
