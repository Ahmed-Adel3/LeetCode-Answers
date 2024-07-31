public class Solution {
    private Dictionary<int, int> cache;

    public int MinHeightShelves(int[][] books, int shelfWidth) {
        cache = new Dictionary<int, int>();
        return Helper(books, shelfWidth, 0);
    }

    private int Helper(int[][] books, int shelfWidth, int i) {
        if (i == books.Length) {
            return 0;
        }
        if (cache.ContainsKey(i)) {
            return cache[i];
        }

        int curWidth = shelfWidth;
        int maxHeight = 0;
        cache[i] = int.MaxValue;

        for (int j = i; j < books.Length; j++) {
            int width = books[j][0];
            int height = books[j][1];
            if (curWidth < width) {
                break;
            }
            curWidth -= width;
            maxHeight = Math.Max(maxHeight, height);
            cache[i] = Math.Min(
                cache[i],
                Helper(books, shelfWidth, j + 1) + maxHeight
            );
        }

        return cache[i];
    }
}
