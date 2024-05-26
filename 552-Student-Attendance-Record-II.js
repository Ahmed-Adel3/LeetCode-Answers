/**
 * @param {number} n
 * @return {number}
 */
var checkRecord = function(n) {
    const MOD = 1000000007;

    // Initialize the memoization array
    let temp = new Array(n).fill(0).map(() => 
        new Array(2).fill(0).map(() => 
            new Array(3).fill(-1)
        )
    );

    const check_all_records = (cur_ind, count_a, count_l) => {
        if (cur_ind === n) {
            return 1;
        }
        if (temp[cur_ind][count_a][count_l] !== -1) {
            return temp[cur_ind][count_a][count_l];
        }
        let with_a_next = (count_a === 0) ? check_all_records(cur_ind + 1, count_a + 1, 0) : 0;
        let with_l_next = (count_l === 2) ? 0 : check_all_records(cur_ind + 1, count_a, count_l + 1);
        let with_p_next = check_all_records(cur_ind + 1, count_a, 0);
        let total = ((with_a_next + with_l_next) % MOD + with_p_next) % MOD;

        temp[cur_ind][count_a][count_l] = total;
        return total;
    };

    return check_all_records(0, 0, 0);
};