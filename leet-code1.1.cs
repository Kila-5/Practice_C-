using System.Collections.Generic; 

public class Solution {
  
    public int[] TwoSum(int[] nums, int target) 
    {
      var list = new List<int>();
      for (int i = 0; i<nums.Length; i++)
      {
        for (int j = i+1; j<nums.Length; j++)
          {
          if (nums[i] + nums[j] == target)
            {
              list.AddRange(new[]{i, j});
              int[] result = list.ToArray();
              return(result);
            }
          }
      }
      return(null);
    
    }
}