class Solution:
    def twoSum(self, numbers: List[int], target: int) -> List[int]:
            startPointer = 0
            endPointer = len(numbers) - 1

            while numbers[startPointer] + numbers[endPointer] != target:
                if numbers[startPointer] + numbers[endPointer] > target:
                    endPointer = endPointer - 1
                else:
                    startPointer = startPointer + 1
            return [startPointer + 1,endPointer + 1]
        