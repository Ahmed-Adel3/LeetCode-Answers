class Solution:
    def commonChars(self, words: List[str]) -> List[str]:
        index = Counter(words[0])

        for word in words:
            curr_index = Counter(word)
            for chr in index:
                index[chr] = min(index[chr],curr_index[chr])
 
        res = []

        for chr in index:
            for num in range(index[chr]):
                res.append(chr)
        
        return res



        