public class TimeMap {
    Dictionary<string,List<(int time,string val)>> dict;

    public TimeMap() {
        dict = new Dictionary<string,List<(int,string)>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!dict.ContainsKey(key))
            dict.Add(key,new List<(int,string)>());
        dict[key].Add((timestamp,value));
    }
    
    public string Get(string key, int timestamp) {
        if(!dict.ContainsKey(key))
            return string.Empty;

        var values = dict[key];
        int left = 0 , right = values.Count-1;
        var res = "";

        while(left <= right)
        {
            var mid = left + (right-left)/2;

            if(values[mid].time <= timestamp)
            {
                res = values[mid].val;
                left = mid +1;
            }
            else right = mid -1;
        }
        return res;
    }
}