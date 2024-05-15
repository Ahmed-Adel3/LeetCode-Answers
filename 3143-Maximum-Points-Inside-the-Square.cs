using System;
using System.Collections.Generic;

public class Solution {
    public int MaxPointsInsideSquare(int[][] points, string s) {
        int n = points.Length;
        for (int i = 0; i < n; i++) {
            points[i][0] = Math.Abs(points[i][0]);
            points[i][1] = Math.Abs(points[i][1]);
        }

        int l = 0;
        int r = (int) 1e9;
        int ans = 0;

        while (l <= r) {
            int mid = (l + r) / 2;
            Dictionary<char, int> m = new Dictionary<char, int>();
            int f = 1;

            for (int i = 0; i < n; i++) {
                if (points[i][0] <= mid && points[i][1] <= mid) {
                    char c = s[i];
                    if (m.ContainsKey(c)) {
                        m[c]++;
                    } else {
                        m[c] = 1;
                    }
                }
            }

            foreach (int val in m.Values) {
                if (val > 1) {
                    f = 0;
                    break;
                }
            }

            if (f == 1) {
                ans = mid;
                l = mid + 1;
            } else {
                r = mid - 1;
            }
        }

        int cnt = 0;
        for (int i = 0; i < n; i++) {
            if (points[i][0] <= ans && points[i][1] <= ans) {
                cnt++;
            }
        }

        return cnt;
    }
}
