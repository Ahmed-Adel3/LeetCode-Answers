public class Solution {
    private string[] belowTwenty = {\\, \One\, \Two\, \Three\, \Four\, \Five\, \Six\, \Seven\, \Eight\, \Nine\, 
                                    \Ten\, \Eleven\, \Twelve\, \Thirteen\, \Fourteen\, \Fifteen\, \Sixteen\, 
                                    \Seventeen\, \Eighteen\, \Nineteen\};
    
    private string[] tens = {\\, \\, \Twenty\, \Thirty\, \Forty\, \Fifty\, \Sixty\, \Seventy\, \Eighty\, \Ninety\};
    
    private string[] thousands = {\\, \Thousand\, \Million\, \Billion\};
    public string NumberToWords(int num) {
        if (num == 0)
            return \Zero\;
        
        int i = 0;
        string words = \\;
        
        while (num > 0) {
            if (num % 1000 != 0) {
                words = Helper(num % 1000) + thousands[i] + \ \ + words;
            }
            num /= 1000;
            i++;
        }
        
        return words.Trim();
    }

    private string Helper(int num) {
        if (num == 0)
            return \\;
        else if (num < 20)
            return belowTwenty[num] + \ \;
        else if (num < 100)
            return tens[num / 10] + \ \ + Helper(num % 10);
        else
            return belowTwenty[num / 100] + \ Hundred \ + Helper(num % 100);
    }
}