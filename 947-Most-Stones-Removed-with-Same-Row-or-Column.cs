public class Solution {
    private int connectedComponentCount = 0;

    public int RemoveStones(int[][] stones) {
        int[] setRepresentatives = new int[20003];
        foreach (var stone in stones) {
            MergeComponents(stone[0] + 1, stone[1] + 10002, setRepresentatives);
        }
        return stones.Length - connectedComponentCount;
    }

    private int FindRepresentative(int element, int[] setRepresentatives) {
        if (setRepresentatives[element] == 0) {
            setRepresentatives[element] = element;
            connectedComponentCount++;
        }
        return setRepresentatives[element] == element ? element : 
               (setRepresentatives[element] = FindRepresentative(setRepresentatives[element], setRepresentatives));
    }

    private void MergeComponents(int elementA, int elementB, int[] setRepresentatives) {
        int repA = FindRepresentative(elementA, setRepresentatives);
        int repB = FindRepresentative(elementB, setRepresentatives);
        if (repA != repB) {
            setRepresentatives[repB] = repA;
            connectedComponentCount--;
        }
    }
}