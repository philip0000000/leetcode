// O(n log n) ???
public class Solution {
    int NumberOfOneBits(int i)
    {
        int num = 0;
        while (i > 0)
        {
            if ((i & 1) == 1)
                num++;
            i >>= 1;
        }
        return num;
    }

    public int[] CountBits(int n) {
        n++;
        int[] ans = new int[n];

        for (int i = 0; i < n; i++)
            ans[i] = NumberOfOneBits(i);

        return ans;
    }
}

// O(n) ?
//8421
//||||
//vvvv
//0000
//0001|1bit has gap of 1
//0010
//0011|2bit has a gap of 2
//0100|4bit has a gap of 4
//0101
//0110
//0111
//0100|8 bit has a gap of 8
//1001
//1010
//1011
public class Solution {
    int NumberOfBits(int i)
    {
        int num = 0;
        while (i > 0)
        {
            num++;
            i >>= 1;
        }
        return num;
    }

    public int[] CountBits(int n) {
        n++;
        int[] ans = new int[n];
        int MaxBits = NumberOfBits(n);

        bool AddOne;
        int count;
        for (int m = 0; m < MaxBits; m++)
        {
            AddOne = false;
            count = 0;
            int Seperation = 1 << m; // 2^m
            Console.WriteLine(Seperation);
            for (int i = 0; i < n; i++)
            {
                if (count >= Seperation)
                {
                    count = 0;
                    AddOne = !AddOne; // flip value to add/not add
                }

                if (AddOne == true)
                    ans[i]++;
                count++;
            }
        }

        return ans;
    }
}
