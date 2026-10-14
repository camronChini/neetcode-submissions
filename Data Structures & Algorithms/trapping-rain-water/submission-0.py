        
class Solution:
    def trap(self, height: List[int]) -> int:
        if len(height) == 0:
            return 0


        
        prefixMax = [0] * len(height)
        suffixMax = [0] * len(height)

        prefixMax[0] = height[0]
        for i in range(1,len(height)):
            prefixMax[i] = max(prefixMax[i-1], height[i])

        suffixMax[len(height) - 1] = height[len(height)- 1]
        for i in range(len(height) - 2, -1, -1):
            suffixMax[i] = max(suffixMax[i + 1], height[i])


        rainTotal = 0
        for i in range(len(height)):
            rainTotal += min(prefixMax[i], suffixMax[i]) - height[i]

        return rainTotal