public class Solution {
    public string CategorizeBox(int length, int width, int height, int mass) {
        bool Bulky = false,
             Heavy = false;
        if (length >= 10000 || height >= 10000 || width >= 10000 ||
            (long)length * (long)height * (long)width >= 1000000000)
            Bulky = true;
        if (mass >= 100)
            Heavy = true;
        if (Bulky == true && Heavy == true)
            return "Both";
        if (Bulky)
            return "Bulky";
        if (Heavy)
            return "Heavy";
        return "Neither";
    }
}
