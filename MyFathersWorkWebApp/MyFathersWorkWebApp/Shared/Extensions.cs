using System.Security.Cryptography;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Components;

namespace MyFathersWorkWebApp;

public static class Extensions
{
    public static MarkupString AsMarkup(this string s) => (MarkupString)s;

    public static void ProcessLocalizationFile(this string localization, Dictionary<string, Dictionary<string, string>> target)
    {
        string[] lines     = localization.Split(new[] { '\r', '\n' });
        string[] languages = [];

        for (int x = 0; x < lines.Length; ++x)
        {
            string[] data = lines[x].Split(';');

            if (x == 0)
            {
                List<string> languagesTmp = new();
                for (int y = 1; y < data.Length; ++y)
                {
                    target[data[y]] = new();
                    languagesTmp.Add(data[y]);
                }

                languages = languagesTmp.ToArray();
                continue;
            }

            if (data[0].StartsWith("//")) continue;
            string tag = data[0];

            for (int y = 1; y < data.Length; ++y)
            {
                if (target[languages[y - 1]].ContainsKey(tag)) throw new Exception("Duplicate tag: " + tag);
                target[languages[y - 1]][tag] = data[y];
            }
        }
    }

    public static string InsertImages(this string text)
    {
        string pattern     = "<icon=([A-Za-z0-9_]+)>";
        string replacement = "<img style=\"display: inline-block; height: 1.5em; width: auto; transform: translate(0, -0.1em);\" src=\"images/gameplay/$1.png\" alt=\"$1\">";
        text = Regex.Replace(text, pattern, replacement);

        string pattern2     = "<sprite=([A-Za-z0-9_]+)>";
        string replacement2 = "<img class=\"full-image\" style=\"height: 8em; display: block; margin: 1rem auto;\" src=\"images/gameplay/$1.png\" alt=\"$1\">";
        return Regex.Replace(text, pattern2, replacement2);
    }

    public static T GetRandom<T>(this List<T> list)
    {
        List<T> newOne = new List<T>(list);
        newOne.Shuffle();
        return newOne[0];
    }

    public static string Format(this string text, string value)
    {
        return string.Format(text, value);
    }
    
    public static string Format(this string text, string value, string value2)
    {
        return string.Format(text, value, value2);
    }

    public static IList<T> Shuffle<T>(this IList<T> list)
    {
        RandomNumberGenerator rng = RandomNumberGenerator.Create();
        int                   n   = list.Count;
        while (n > 1)
        {
            byte[] box = new byte[4];
            rng.GetBytes(box);
            int randomIndex                  = BitConverter.ToInt32(box, 0);
            if (randomIndex < 0) randomIndex *= -1;
            randomIndex %= n;
            n--;
            (list[randomIndex], list[n]) = (list[n], list[randomIndex]);
        }

        return list;
    }
}