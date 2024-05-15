public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        var arr = new int[26];
        int maxFreq = 0; //max number of occurances of a task
        int maxOccuredItemsCount = 0; // number of tasks with max occurance
        foreach(var task in tasks)
        {
            int charAscii = task - 'A'; //get the index of the item (ascii of item - ascii of A)
            arr[charAscii]++;
            if(arr[charAscii] > maxFreq)
            {
                maxFreq = arr[charAscii];
                maxOccuredItemsCount = 1;
            }
            else if(arr[charAscii] == maxFreq)
            {
                maxOccuredItemsCount++;
            }
        }

        int numberOfGaps = maxFreq - 1;    //A__A__A__A
        int numberOfSpacesInGap = n-(maxOccuredItemsCount-1); // it can be AB_AB_AB_AB if A & B both max occur 4 times
        int emptySpaces = numberOfGaps * numberOfSpacesInGap;

        int remainingTasksWithoutMostOccurred = tasks.Length - maxFreq * maxOccuredItemsCount;

        int idles = Math.Max(0 , emptySpaces - remainingTasksWithoutMostOccurred);
        return tasks.Length + idles;
    }
}