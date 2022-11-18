public class Solution {
    public System.Numerics.BigInteger factorial(System.Numerics.BigInteger n) {
            return (n > 1) ? n * factorial(n - 1) : 1;
    }

    //https://en.wikipedia.org/wiki/Pascal's_triangle#Binomial_expansions
    public int BinomialCoefficient(long n, long u)
    {
        System.Numerics.BigInteger bn = n;
        System.Numerics.BigInteger bu = u;
        return (int)(factorial(bn) / (factorial(bu) * factorial(bn - bu)));
    }

    public IList<int> GetRow(int rowIndex) {
        var ret = new List<int>();

        for (int i = 0; i < rowIndex+1; i++)
        {
            ret.Add(BinomialCoefficient(rowIndex, i));
        }

        return ret;
    }
}

//https://stackoverflow.com/questions/15580291/how-to-efficiently-calculate-a-row-in-pascals-triangle
public class Solution {
    public IList<int> GetRow(int rowIndex) {
        var list = new List<int> { 1 };

        for (int k = 0; k < rowIndex; k++)
            list.Add((int)(
                ((long)list[k] * (long)(rowIndex - k)) / (long)(k + 1)
            ));

        return list;
    }
}
