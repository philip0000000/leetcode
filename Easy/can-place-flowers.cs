// 1st
public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        if (flowerbed.Length > 1)
        {
            if (flowerbed[0] == 0 && flowerbed[1] == 0)
            {
                flowerbed[0] = 1;
                n--;
            }
            if (flowerbed[flowerbed.Length - 1] == 0 && flowerbed[flowerbed.Length - 2] == 0)
            {
                flowerbed[flowerbed.Length - 1] = 1;
                n--;
            }
            for (int i = 1; i+1 < flowerbed.Length - 1; i++)
                if (flowerbed[i-1] == 0 &&
                    flowerbed[i] == 0 &&
                    flowerbed[i+1] == 0)
                {
                    flowerbed[i] = 1;
                    i++;
                    n--;
                    if (n < 1)
                        break;
                }
        }
        else if (flowerbed[0] == 0)
            n--;
        return n > 0 ? false : true;
    }
}

// 2nd 50%~
public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        for (int i = 0; i < flowerbed.Length; i++)
            if (flowerbed[i] == 0 && 
                (i == 0 || flowerbed[i - 1] == 0) && 
                (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
            {
                flowerbed[i] = 1;
                i++;
                n--;
            }
        return n <= 0;
    }
}
