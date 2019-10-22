namespace RM.FrameworkExtensions.Tests {
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ReplaceMacroTests {


        [TestMethod]
        public void ShouldReplaceMarkersWithPropertyValues() {

            var model = new { StringProp1 = "Lazy", IntProp1 = 1, DecProp1 = 2.5D, DateTimeProp1 = DateTime.Now, BoolProp1 = true };
            var str = "The {StringProp1} is {IntProp1} in {DecProp1} at {DateTimeProp1} {BoolProp1}";

            var result = str.ReplaceMacro(model);

            Assert.AreEqual("The Lazy is 1 in 2.5", result);
        }
    }
}
