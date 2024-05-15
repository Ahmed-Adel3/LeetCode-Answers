public class Solution {
    public int NumSteps(string s) {
        
        var steps = 0;
        var arr = s.ToCharArray().ToList();
        while(arr.Count > 1 || arr[0] != '1')
        {
            if(arr.Last() == '0') //even
            {
                arr.RemoveAt(arr.Count-1);
                steps++;
            }
            else {  //odd
                for(int i = arr.Count-1; i >=0 ; i--)
                {
                    if(arr[i] == '0'){
                        arr[i] = '1';
                        break;
                    }
                    else{
                        arr[i] = '0';
                        if (i == 0)
                        {
                            arr.Insert(0, '1');
                            break;
                        }
                    }
                }
                steps++;
            }
        }
        return steps;
    }
}