// 1st (sliding window approach)
double MAV = double.MinValue;
int m = 0;
double sum = 0;
while (m < k) // get first "target"
{
    sum += nums[m];
    m++;
}
MAV = sum / k;
int start = 1;
int end = k;
while (end < nums.Length)
{
    sum -= nums[start - 1];
    sum += nums[end];
    MAV = Math.Max(MAV, sum/k);
    start++;
    end++;
}
return MAV;

// 2nd
double MaxValue = double.MinValue;
int sum = 0;
int end = 0;
while (end < k) // get first "target"
{
    sum += nums[end];
    end++;
}
MaxValue = sum;
int start = 0;
while (end < nums.Length)
{
    sum -= nums[start];
    sum += nums[end];
    MaxValue = Math.Max(MaxValue, sum);
    start++;
    end++;
}
return MaxValue/(k*1.0);
