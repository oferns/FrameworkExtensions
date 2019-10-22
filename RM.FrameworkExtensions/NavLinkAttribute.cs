namespace System.Web.Mvc {

    using System;

    /// <summary>
    /// An attribute to indicate a Navigation Link
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public class NavLinkAttribute : Attribute {

        public NavLinkAttribute(string menuGroup, string linkTitle, int position) {
            if (string.IsNullOrWhiteSpace(menuGroup)) {
                throw new ArgumentException("message", nameof(menuGroup));
            }

            if (string.IsNullOrEmpty(linkTitle)) {
                throw new ArgumentException("message", nameof(linkTitle));
            }

            MenuGroup = menuGroup;
            LinkTitle = linkTitle;
            Position = position;
        }

        public string MenuGroup { get; }
        public string LinkTitle { get; }
        public int Position { get; }
    }
}