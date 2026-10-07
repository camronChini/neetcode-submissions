class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:

        if nums == []:
            return 0

        longestSequence = 1
        numsSet = set(nums)
        for num in numsSet:
            if not ((num - 1) in numsSet):
                currentSequence = 1
                while (num + 1) in numsSet:
                    num = num + 1
                    currentSequence = currentSequence + 1
                    if currentSequence > longestSequence:
                        longestSequence = currentSequence

        return longestSequence
