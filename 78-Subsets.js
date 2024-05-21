var subsets = function(nums) {
    const res = [];
    const subset = [];

    const dfs = function(i) {
        if (i === nums.length) {
            res.push([...subset]);
            return;
        }

        subset.push(nums[i]);
        dfs(i + 1);

        subset.pop();
        dfs(i + 1);
    };

    dfs(0);
    return res;    
};