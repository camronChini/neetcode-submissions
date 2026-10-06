class Solution:
     def productExceptSelf(self, nums: List[int]) -> List[int]:
        length = len(nums)
        pref = [0] * length
        suf = [0] * length
        res = [0] * length

        pref[0] = 1
        suf[length - 1] = 1

        for i in range(1,length):
            pref[i] = nums[i - 1] * pref[i - 1]
        for i in range(length - 2, -1, -1):
            suf[i] = nums[i + 1] * suf[i + 1]
        for i in range(length):
            res[i] = pref[i] * suf[i]
        return res