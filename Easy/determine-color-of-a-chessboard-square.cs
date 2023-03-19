public class Solution {
    public bool SquareIsWhite(string coordinates) {
        int num0 = coordinates[1]-'a';
        int num1 = coordinates[0]-'0';
        bool letter = (num0%2)==0 ? true : false;
        bool number = (num1%2)==0 ? true : false;
        return letter == number ? true : false;
    }
}
