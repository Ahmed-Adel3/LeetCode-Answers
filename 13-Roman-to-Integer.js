/**
 * @param {string} s
 * @return {number}
 */
var romanToInt = function(s) {
    let dict = {
       "I":1,
       "V":5,
       "X":10,
       "L":50,
       "C":100,
       "D":500,
       "M":1000
    }

    let val = 0;
    let skipNext = false;
    for(let i = 0 ; i < s.length ; i++)
    {
        if(skipNext){
            skipNext = false;
            continue;
        } 

        var chr = s[i];
        if((chr == 'I' || chr == 'X' || chr == 'C') && i != s.length -1)
        {
            var nChr = s[i+1];
            var div = dict[nChr] / dict[chr];
            if(div == 5 || div == 10)
            {
                val += (dict[nChr]-dict[chr]);
                skipNext = true;
                continue;
            }
        }

        val += dict[chr];
    }
    return val;
};