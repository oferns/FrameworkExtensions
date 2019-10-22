namespace System.ComponentModel.DataAnnotations.Schema {

    using System;

    /// <summary>
    ///  This is an attribute in the spirit of System.DataComponents
    ///  that identifies a SQL Function from the database
    ///  showing its argument name and types 
    ///  and return type.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class FunctionAttribute : Attribute {

        public FunctionAttribute(string functionName, int arguments, Type returnType) {
            if (string.IsNullOrWhiteSpace(functionName)) {
                throw new ArgumentException("message", nameof(functionName));
            }

            FunctionName = functionName;
            Arguments = arguments;
            ReturnType = returnType ?? throw new ArgumentNullException(nameof(returnType));
            Schema = Schema;
        }

        public string FunctionName { get; }
        public int Arguments { get; }
        public Type ReturnType { get; }
        public string Schema { get; set; }

    }
}