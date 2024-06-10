class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:
        if len(strs) == 0 or strs[0] == "":
            return ""
        index = 0
        for i, letter in enumerate(strs[0]):
            for str in strs: 
                if len(str) < i+1 or letter != str[i] :
                    return strs[0][0:index]
            index +=1

        return strs[0]
