namespace System.ComponentModel.DataAnnotations.Schema {

    using System;

    /// <summary>
    ///  This is an attribute in the spirit of System.DataComponents
    ///  that identifies an index on a property from the database
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class IndexAttribute : Attribute {

        public IndexAttribute(string name, int order, bool unique, bool clustered) {
            Name = name;
            Order = order;
            Unique = unique;
            Clustered = clustered;
        }

        public string Name { get; }
        public int Order { get; }
        public bool Unique { get; }
        public bool Clustered { get; }
    }
}