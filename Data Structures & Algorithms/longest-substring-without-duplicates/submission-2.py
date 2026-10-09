class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        left = 0
        right = 0
        maxLen = 0
        currentChars = set()

        if s == "":
            return 0
        else:
            currentChars.add(s[0])
            maxLen = 1
        
        while right < len(s) - 1:
            right += 1
            if s[right] in currentChars:
                while s[left] != s[right]:
                    currentChars.remove(s[left])
                    left += 1
                left += 1
            else:
                currentChars.add(s[right])

            if(right - left + 1) > maxLen:
                maxLen = (right - left + 1)

        return maxLen
