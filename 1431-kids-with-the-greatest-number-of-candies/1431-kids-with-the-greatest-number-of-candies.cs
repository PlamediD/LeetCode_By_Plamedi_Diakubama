public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int max=0; 
        for (int i=0; i<candies.Length; i++){
            if(candies[i]> max){
                max=candies[i]; 
            }
        }
        List<bool> result = new List<bool>();
        
        for(int i=0; i<candies.Length; i++){
            if(candies[i]+extraCandies>=max){
                result.Add(true);
            }
            else{
                result.Add(false);
            }
        }
        
        return result; 
        
    }
}