namespace System.ComponentModel {

    using System;

    /// <summary>
    /// Attribute to identify a ReadOnly object or property
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = false)]
    public class IsReadOnlyAttribute : Attribute {

        public IsReadOnlyAttribute(bool readOnly) {
            ReadOnly = readOnly;
        }

        public bool ReadOnly { get; }
    }
}