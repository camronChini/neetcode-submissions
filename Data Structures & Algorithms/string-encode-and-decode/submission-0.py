class Solution:

    def encode(self, strs: List[str]) -> str:
        returnString = ""
        for s in strs:
            returnString += str(len(s))
            returnString += "#"
            returnString += s
        return returnString

    def decode(self, s: str) -> List[str]:
        res = []
        i = 0

        while i < len(s):
            j = i
            while s[j] != "#":
                j = j + 1
            length = int(s[i:j])
            res.append(s[j+1 : j + 1 + length])
            i = j + 1 + length
        return res
