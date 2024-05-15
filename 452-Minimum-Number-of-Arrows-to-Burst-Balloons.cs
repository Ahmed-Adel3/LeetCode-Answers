public class Solution {
    public int FindMinArrowShots(int[][] points) {
        if(points == null ) return 0;

        //SortPoints(points,0,points.Length-1);
        Array.Sort(points, (x, y) => x[0].CompareTo(y[0]));
        var count = 0;
        int? sharedStart = null;
        int? sharedEnd = null;

        int end;
        int nextStart;
        int nextEnd;
        int lowestEnd;

        for(int i = 0 ; i < points.Length; i ++)
        {
            if(i == points.Length -1)
            {
                if(sharedStart == null)
                    count++;
                continue;
            }

            end = points[i][1];
            nextStart = points[i+1][0];
            nextEnd = points[i+1][1];
            lowestEnd = end > nextEnd ? nextEnd:end;

            if(nextStart <= lowestEnd)
            {
                if(sharedStart != null)
                {
                    if(sharedStart < nextStart)
                        sharedStart = nextStart;

                    if(sharedEnd > lowestEnd)
                        sharedEnd = lowestEnd;
                    
                    if(sharedEnd < sharedStart){
                        sharedStart = null;
                        sharedEnd = null;
                    }
                }
                else
                {
                    sharedStart = nextStart;
                    sharedEnd = lowestEnd;
                    count++;
                }
            }
            else
            {
                if(sharedStart != null)
                {
                    sharedStart = null;
                    sharedEnd = null;
                }
                else
                    count++;
            }
        }
        return count;
    }


    //Merge sort ==> not used
    public void SortPoints(int[][] points,int start, int end)
    {
        if(end <= start) 
            return;

        int mid = (start+end)/2;

        SortPoints(points,start,mid);
        SortPoints(points,mid+1,end);

        Merge(points,start,mid,end);
    }

    public void Merge(int[][] points, int start, int mid, int end){
        int i,j,k;
        
        int left_length = mid - start + 1;
        int right_length = end - mid;

        int[][] leftArr = new int[left_length][];
        int[][] rightArr = new int[right_length][];

        for( i = 0 ; i < left_length ; i++){
            leftArr[i] = new int[2];
            leftArr[i][0] = points[i + start][0];
            leftArr[i][1] = points[i + start][1];
        } 

        for( j = 0 ; j < right_length ; j++){
            rightArr[j] = new int[2];
            rightArr[j][0] = points[mid+j+1][0];
            rightArr[j][1] = points[mid+j+1][1];
        }

        i = 0; j = 0 ; k = start;

        while(i < left_length && j < right_length){
            if(leftArr[i][0] <= rightArr[j][0]){
                points[k][0] = leftArr[i][0];
                points[k][1] = leftArr[i][1];
                i++;
                k++;
            }
            else 
            {
                points[k][0] = rightArr[j][0];
                points[k][1] = rightArr[j][1];
                j++;
                k++;
            }
        } 

        while(i < left_length){
            points[k][0] = leftArr[i][0];
            points[k][1] = leftArr[i][1];
            i++;
            k++;
        }

        while(j < right_length){
            points[k][0] = rightArr[j][0];
            points[k][1] = rightArr[j][1];
            j++;
            k++;
        }
    }
}