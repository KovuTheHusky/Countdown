using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Extensions
{
    /// <summary>
    /// Provides a filename-safe string.
    /// </summary>
    /// <param name="str">The string to make filename-safe.</param>
    /// <returns>Filename-safe string for NTFS systems.</returns>
    public static string ToFilename(this string str)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < str.Length; ++i)
        {
            if (!(str[i] == '?' || str[i] == '<' || str[i] == '>' || str[i] == '\\' || str[i] == ':' || str[i] == '*' || str[i] == '|' || str[i] == '\"'))
                sb.Append(str[i]);
        }
        return sb.ToString();
    }
}