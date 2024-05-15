public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        var boats = 0;
        var i = 0;
        int j = people.Length-1;
        while(i <= j)
        {
            if(people[i] + people[j] <= limit)
                i++;
            j--;
            boats++;
        }
        return boats;
    }
}