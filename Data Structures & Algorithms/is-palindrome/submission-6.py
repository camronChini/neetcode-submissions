class Solution:
    def isPalindrome(self, s: str) -> bool:
        s = s.lower()
        startPointer = 0
        endPointer = len(s) - 1

        while startPointer < endPointer and startPointer < len(s):
            while  startPointer < endPointer and not s[startPointer].isalnum():
               startPointer = startPointer + 1
            while startPointer < endPointer and not s[endPointer].isalnum():
                endPointer = endPointer - 1
            if s[startPointer] != s[endPointer]:
                return False
            startPointer = startPointer + 1
            endPointer = endPointer - 1
        
        return True