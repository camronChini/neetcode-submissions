

class Solution:
    def isValid(self, s: str) -> bool:
        stack = []
        bracketPairs = {
            ")" : "(",
            "]" : "[",
            "}" : "{"
        }

        for c in s:
            if not (c in bracketPairs):
                stack.append(c)
            else:
                if stack and stack[-1] == bracketPairs[c]:
                    stack.pop()
                else:
                    return False

        if stack:
            return False
        else:
            return True