
class Solution:
    def search(self, nums: List[int], target: int) -> int:
        lowerBound = 0
        upperBound = len(nums) - 1

        while lowerBound <= upperBound:
            currentIndex = (lowerBound + upperBound) // 2
            if nums[currentIndex] == target:
                return currentIndex
            elif nums[currentIndex] > target:
                upperBound = currentIndex - 1
            else:
                lowerBound = currentIndex + 1

        return -1
    