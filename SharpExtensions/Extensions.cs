using System;

namespace SharpExtensions
{
    public static class Extensions
    {
        public static int ToInt(this string value)
        {
            return Convert.ToInt32(value);
        }
        public static int ToInt(this decimal value)
        {
            return Convert.ToInt32(decimal.Round(value));
        }
        public static int ToInt(this double value)
        {
            return Convert.ToInt32(value);
        }
        public static short ToShort(this string value)
        {
            return Convert.ToInt16(value);
        }
        public static short ToShort(this decimal value)
        {
            return Convert.ToInt16(decimal.Round(value));
        }
        public static short ToShort(this double value)
        {
            return Convert.ToInt16(value);
        }
        public static long ToLong(this string value)
        {
            return Convert.ToInt64(value);
        }
        public static long ToLong(this decimal value)
        {
            return Convert.ToInt64(decimal.Round(value));
        }
        public static long ToLong(this double value)
        {
            return Convert.ToInt64(value);
        }
        public static double ToDouble(this string value)
        {
            return Convert.ToDouble(value);
        }
        public static double ToDouble(this int value)
        {
            return Convert.ToDouble(value);
        }
        public static double ToDouble(this decimal value)
        {
            return Convert.ToDouble(value);
        }
        public static double ToDouble(this float value)
        {
            return Convert.ToDouble(value);
        }
        public static DateTime ToDateTime(this string value)
        {
            return Convert.ToDateTime(value);
        }
        public static string FromArrayToString(this int[] value)
        {
            return string.Join(",", value);
        }
        public static string FromArrayToString(this string[] value)
        {
            return string.Join(",", value);
        }
        public static string FromArrayToString(this decimal[] value)
        {
            return string.Join(",", value);
        }
        public static string FromArrayToString(this double[] value)
        {
            return string.Join(",", value);
        }
        public static string FromArrayToString(this int[] value, string characterSeparator)
        {
            return string.Join(characterSeparator, value);
        }
        public static string FromArrayToString(this string[] value, string characterSeparator)
        {
            return string.Join(characterSeparator, value);
        }
        public static string FromArrayToString(this decimal[] value, string characterSeparator)
        {
            return string.Join(characterSeparator, value);
        }
        public static string FromArrayToString(this double[] value, string characterSeparator)
        {
            return string.Join(characterSeparator, value);
        }
        public static int[] ToOrderBy(this int[] value)
        {
            Array.Sort(value);
            return value;
        }

    }
}
