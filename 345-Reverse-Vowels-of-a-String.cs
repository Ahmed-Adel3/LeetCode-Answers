public class Solution {
    public string ReverseVowels(string s) {
        var arr = s.ToCharArray();
        var vowels = new List<char>{'a','e','i','o','u','A','E','I','O','U'};
        var items = new List<char>();

        for(int i = 0; i < arr.Length ; i++){
            if(vowels.Contains(arr[i]))
                items.Add(arr[i]);
        }
        items.Reverse();
        for(int i = 0; i < arr.Length ; i++){
            if(vowels.Contains(arr[i])){
                arr[i]=items[0];
                items.RemoveAt(0);
            }
        }

        return new String(arr);
    }
}