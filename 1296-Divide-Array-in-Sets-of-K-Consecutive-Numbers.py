class Solution:
    def isPossibleDivide(self, nums: List[int], k: int) -> bool:
        if len(nums) % k != 0:
            return False

        count = Counter(nums)
        
        for num in sorted(count):
            if count[num] > 0:
                occurrences = count[num]
                for i in range(num, num + k):
                    if count[i] < occurrences:
                        return False
                    count[i] -= occurrences
        
        return True
        