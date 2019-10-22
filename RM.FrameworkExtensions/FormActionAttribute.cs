namespace System.Web.Mvc {

    using System;

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class FormActionAttribute : Attribute {
        public FormActionAttribute(string form, string buttonTitle, int position) {
            if (string.IsNullOrWhiteSpace(form)) {
                throw new ArgumentException("message", nameof(form));
            }

            if (string.IsNullOrWhiteSpace(buttonTitle)) {
                throw new ArgumentException("message", nameof(buttonTitle));
            }

            Form = form;
            ButtonTitle = buttonTitle;
            Position = position;
        }

        public string Form { get; }
        public string ButtonTitle { get; }
        public int Position { get; }
    }
}