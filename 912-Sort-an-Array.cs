public class Solution {
    public int[] SortArray(int[] nums) {
        MergeSort(nums,0,nums.Length-1);
        return nums;
    }

    public void MergeSort(int[] arr, int start, int end)
    {
        if(end <= start) return;

        var mid = (end+start)/2;
        MergeSort(arr,start, mid);
        MergeSort(arr,mid+1, end);

        Merge(arr, start, mid, end);
    }

    public void Merge(int[] arr, int start, int mid, int end)
    {
        int leftSize = mid - start + 1;
        int rightSize = end - mid;

        int[] leftArr = new int[leftSize];
        int[] rightArr = new int[rightSize];

        Array.Copy(arr, start, leftArr, 0, leftSize);
        Array.Copy(arr, mid + 1, rightArr, 0, rightSize);

        int i = 0, j = 0, k = start;

        while (i < leftSize && j < rightSize) {
            if (leftArr[i] <= rightArr[j]) {
                arr[k++] = leftArr[i++];
            } else {
                arr[k++] = rightArr[j++];
            }
        }

        while (i < leftSize) {
            arr[k++] = leftArr[i++];
        }

        while (j < rightSize) {
            arr[k++] = rightArr[j++];
        }
    }
}