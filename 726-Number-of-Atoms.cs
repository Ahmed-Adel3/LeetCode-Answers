public class Solution
{
    public string CountOfAtoms(string formula)
    {
        int i = 0;
        Dictionary<string, int> counters = ParseFormula(formula, ref i);
        List<string> sortedElements = new List<string>(counters.Keys);
        sortedElements.Sort();
        StringBuilder ans = new();
        foreach (string e in sortedElements)
        {
            ans.Append(e);
            if (counters[e] > 1)
                ans.Append(counters[e]);
        }
        return ans.ToString();
    }

    Dictionary<string, int> ParseFormula(string formula, ref int i)
    {
        Dictionary<string, int> dc = new Dictionary<string, int>();
        while (i < formula.Length && formula[i] != ')')
            if (formula[i] == '(')
            {
                i++;
                Dictionary<string, int> innerCounts = ParseFormula(formula, ref i);
                i++;
                int multiplier = ParseNumber(formula, ref i);
                foreach (var kvp in innerCounts)
                    if (dc.ContainsKey(kvp.Key))
                        dc[kvp.Key] += kvp.Value * multiplier;
                    else
                        dc[kvp.Key] = kvp.Value * multiplier;
            }
            else
            {
                string name = ParseName(formula, ref i);
                int count = ParseNumber(formula, ref i);
                if (dc.ContainsKey(name))
                    dc[name] += count;
                else
                    dc[name] = count;
            }
        return dc;
    }

    string ParseName(string formula, ref int i)
    {
        int start = i;
        i++;
        while (i < formula.Length && char.IsLower(formula[i]))
            i++;
        return formula.Substring(start, i - start);
    }

    int ParseNumber(string formula, ref int i)
    {
        if (i < formula.Length && char.IsDigit(formula[i]))
        {
            int start = i;
            while (i < formula.Length && char.IsDigit(formula[i]))
                i++;
            return int.Parse(formula.Substring(start, i - start));
        }
        return 1;
    }
}