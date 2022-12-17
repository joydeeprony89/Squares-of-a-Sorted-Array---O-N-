// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var nums = new int[] { -11, -4, 2, 3, 7 };
Solution s = new Solution();
var answer = s.SortedSquares(nums);
Console.WriteLine(string.Join(",", answer));


public class Solution
{
  /*
  As the array is sorted in asc order and has negetive value
  -11, -4, 2, 3, 7, if we take Abs value for each it should have been sorted - 2, 3, 4, 7, 11
  so in input the last element square could be the largest of the smallest element square, How ? as you can see the smallest element is -11, but sqr is - 121 and sqr of lrgest element is 49, so we need to compare first and last element always to get the largest sqr element
  */
  public int[] SortedSquares(int[] nums)
  {
    int n = nums.Length;
    var result = new int[n];
    int i = 0; int j = n - 1;
    for (int k = n - 1; k >= 0; k--)
    {
      int small = nums[i];
      int large = nums[j];
      if (Math.Abs(small) > Math.Abs(large))
      {
        result[k] = small * small;
        i++;
      }
      else
      {
        result[k] = large * large;
        j--;
      }
    }
    return result;
  }
}
