﻿namespace StoreParser.Extensions
{
    internal static class Extensions
    {
        public static string RemoveWhiteSpace(this string value)
        {
            return value.Replace("\n", "").Replace("\r", "").Trim();
        }
    }
}