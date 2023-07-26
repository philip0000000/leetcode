public class ParkingSystem {
    private int[] max = new int[3];
    private int[] parking = new int[3];

    public ParkingSystem(int big, int medium, int small) {
        max[0] = big;
        max[1] = medium;
        max[2] = small;
        parking[0] = 0;
        parking[1] = 0;
        parking[2] = 0;
    }
    
    public bool AddCar(int carType) {
        switch (carType)
        {
            case 1:
                if (parking[0] >= max[0])
                    return false;
                parking[0]++;
                break;
            case 2:
                if (parking[1] >= max[1])
                    return false;
                parking[1]++;
                break;
            case 3:
                if (parking[2] >= max[2])
                    return false;
                parking[2]++;
                break;
            default:
                return false;
        }
        return true;
    }
}
