public class Solution {
    public int MaxArea(int[] heights)
    {

        int startPointer = 0;
        int heightsLength = heights.Length;
        int endPointer = heightsLength - 1;
        int highestArea = 0;
        
        while(startPointer < endPointer)
        {
            int area = Math.Abs(startPointer - endPointer) * Math.Min(heights[startPointer], heights[endPointer]);
            if (area > highestArea)
            {
               highestArea = area;
            }
            if(heights[startPointer] < heights[endPointer])
            {
                startPointer++;
            }
            else
            {
                endPointer--;
            }
        }

        return highestArea;
        
    }
}
