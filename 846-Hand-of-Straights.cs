public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {
        if(hand.Length%groupSize > 0)
            return false;

        Array.Sort(hand);
        var lastElements = Enumerable.Repeat((-1,0),hand.Length/groupSize).ToList();

        for(int i = 0 ; i < hand.Length; i++)
        {
            for(int j = 0 ; j < lastElements.Count; j++)
            {
                if(lastElements[j].Item2 == groupSize)
                    continue;
                if(lastElements[j].Item1 == -1 || hand[i] == lastElements[j].Item1 + 1){
                    lastElements[j] = ( hand[i] , lastElements[j].Item2+1 );
                    break;
                }
                else if(j == lastElements.Count -1)
                    return false;
            }
        }
        return lastElements.All(a=>a.Item2 == groupSize);
    }
}