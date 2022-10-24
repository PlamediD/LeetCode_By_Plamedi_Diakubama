public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        Dictionary<int,int> twoSum = new();
        
        //traverse the givven array 
        for(int i=0; i<nums.Length; i++){
            
           // check if target- num at current index is already int he dictionary 
             if(twoSum.ContainsKey(target - nums[i])){
                 
                 //if it is then return array containing indexes 
                 return new int[]{i, twoSum[target - nums[i]]};
             }
                 
                
            else if(!twoSum.ContainsKey(nums[i])){
                
                twoSum.Add(nums[i], i);
            }
                
        }
        
        
       
        //if no numbers are found return an empty array 
        return new int[0];
    }
}