class Solution {
public:
    int minimumOperationsToMakeKPeriodic(string word, int k) {
        int n = word.size();
        unordered_map<string,int> f;
        for (int i = 0; i < n; i+= k) {
            string ss = word. substr(i, k);
            f[ss]++;
        }
        int mf = 0;
        for (const auto& p : f) {
            mf=max(mf, p.second);
        }
        return (n / k) - mf;
    }
};