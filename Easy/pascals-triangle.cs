// without looking at other people
public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> Ret = new List<IList<int>>();
        Ret.Add( new List<int>() );
        Ret[0].Add(1);

        for (int i = 1; i < numRows; i++)
        {
            Ret.Add( new List<int>() ); // add list

            for (int m = 0; m < i+1; m++)
            {
                // left value
                int val0;
                if (m == 0)
                {
                    Ret[i].Add(1);
                    continue;
                }
                else
                    val0 = Ret[i-1][m-1];

                // right value
                int val1;
                if (m == i)
                {
                    Ret[i].Add(1);
                    continue;
                }
                else
                    val1 = Ret[i-1][m];

                Ret[i].Add(val0 + val1);
            }
        }

        return Ret;
    }
}

// 2nd attempt
public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> Ret = new List<IList<int>>();
        Ret.Add( new List<int>() );
        Ret[0].Add(1);

        for (int i = 1; i < numRows; i++)
        {
            Ret.Add( new List<int>() ); // add list

            for (int m = 0; m < i+1; m++)
            {
                if (m == 0 || m == i)
                {
                    Ret[i].Add(1);
                    continue;
                }

                Ret[i].Add(Ret[i-1][m-1] + Ret[i-1][m]); // add value
            }
        }

        return Ret;
    }
}
