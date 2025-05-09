using System.Collections.Generic;

public class MatchService
{
    public List<int> FindMatches(string text, string subtext)
    {
        var matches = new List<int>();

        if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(subtext))
            return matches;

        text = text.ToLower();
        subtext = subtext.ToLower();

        for (int i = 0; i <= text.Length - subtext.Length; i++)
        {
            if (text.Substring(i, subtext.Length) == subtext)
                matches.Add(i + 1);
        }

        return matches;
    }
}