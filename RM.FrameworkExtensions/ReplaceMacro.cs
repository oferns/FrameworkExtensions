namespace System {

    using System.Linq.Dynamic.Core;
    using System.Linq.Expressions;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Extension similar to string.Format that uses model property values to replace markers in a stri ng
    /// </summary>
    public static class StringExtensions {

        public static string ReplaceMacro(this string value, object @object) {
            return Regex.Replace(value, @"{(.+?)}",
            match => {
                var p = Expression.Parameter(@object.GetType(), @object.GetType().Name);
                var e = DynamicExpressionParser.ParseLambda(new[] { p }, null, match.Groups[1].Value);
                return (e.Compile().DynamicInvoke(@object) ?? string.Empty).ToString();
            });
        }
    }
}