using System.Text.RegularExpressions;

public class Solution {
    public string FractionAddition(string expression) {
        int numerator = 0, denominator = 1;

        Regex regex = new Regex(@\([+-]?\\d+)\\/(\\d+)\);
        MatchCollection matches = regex.Matches(expression);

        foreach (Match match in matches) {
            int num = int.Parse(match.Groups[1].Value);
            int den = int.Parse(match.Groups[2].Value);

            numerator = numerator * den + num * denominator;
            denominator *= den;

            int gcdVal = GCD(Math.Abs(numerator), denominator);
            numerator /= gcdVal;
            denominator /= gcdVal;
        }

        return $\{numerator}/{denominator}\;
    }

    private int GCD(int a, int b) {
        while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}