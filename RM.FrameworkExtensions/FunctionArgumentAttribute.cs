namespace System.ComponentModel.DataAnnotations.Schema {

    using System;

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = false)]
    public class FunctionArgumentAttribute : Attribute {

        public FunctionArgumentAttribute(int ordinal, string name, Type returnType, string propertyName) {
            Ordinal = ordinal >= 0 ? ordinal : throw new ArgumentOutOfRangeException(nameof(ordinal), "Ordinal must be positive");

            if (string.IsNullOrWhiteSpace(name)) {
                throw new ArgumentException(nameof(name));
            }

            ReturnType = returnType ?? throw new ArgumentNullException(nameof(returnType));

            if (string.IsNullOrWhiteSpace(propertyName)) {
                throw new ArgumentException(nameof(propertyName));
            }

            Name = name;
            PropertyName = propertyName;
        }

        public string PropertyName { get; }
        public int Ordinal { get; }
        public string Name { get; }
        public Type ReturnType { get; }
    }
}