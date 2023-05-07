using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxSubarray
{
    internal class FindMaxSubarray
    {
        public static (int low, int high, int sum) maxSubarray(int[] a ,int low , int high)
        {
            int left_sum, right_sum, cross_sum;
            int left_low, left_high, right_low, right_high, cross_low, cross_high;
            if (low == high)
            {
                return (low, high, a[low]);
            }
            else
            {
                int mid = (high + low ) / 2;
                
                (left_low, left_high, left_sum) = maxSubarray(a, low, mid);
                (right_low, right_high, right_sum) = maxSubarray(a, mid+1, high);
                (cross_low ,cross_high, cross_sum) = maxCrossSubarray(a,low, mid , high);
                if(left_sum >= right_sum & left_sum >= cross_sum)
                {
                    return (left_low, left_high, left_sum);
                }
                if (right_sum >= left_sum & right_sum >= cross_sum)
                {
                    return (right_low, right_high, right_sum);
                }
                if (cross_sum >= left_sum & cross_sum >= right_sum)
                {
                    return (cross_low, cross_high, cross_sum);
                }
                else
                {
                    return (cross_low, cross_high, cross_sum);
                }
            }
        }

        private static (int low, int high, int cross_sum) maxCrossSubarray(int[] a, int low, int mid, int high)
        {
            int left_sum = int.MinValue, right_sum = int.MinValue, sum;
            int max_left=mid, max_right=mid;
            sum = 0;
            for (int i = mid;i>=low;i--)
            {
                sum += a[i];
                if(sum > left_sum)
                {
                    left_sum = sum;
                    max_left = i;
                }
            }
            sum = 0;
            for (int i = mid+1; i <= high; i++)
            {
                sum += a[i];
                if (sum > right_sum)
                {
                    right_sum = sum;
                    max_right = i;
                }
            }
            return (max_left, max_right, left_sum + right_sum);
        }
    }
}
