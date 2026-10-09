class Solution:
    def characterReplacement(self, s: str, k: int) -> int:
        longestString = 0
        charSet = set(s)

        for c in charSet:
            count = l = 0
            for r in range(len(s)):
                if s[r] == c:
                    count += 1

                while (r - l + 1) - count > k:
                    if s[l] == c:
                        count -= 1
                    l += 1

                longestString = max(longestString, r - l + 1)

        return longestString