namespace RM.FrameworkExtensions.Tests {
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web.Mvc;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AttributeTests {

        [TestClass]
        public class FormActionTests {

            [TestMethod]
            // Assert
            [ExpectedException(typeof(ArgumentException))]
            public void ShouldThrowOnNullForm() {
                // Arrange
                // Act
                _ = new FormActionAttribute(null, "title", 0);
            }

            [TestMethod]
            // Assert
            [ExpectedException(typeof(ArgumentException))]
            public void ShouldThrowOnEmptyForm() {
                // Arrange
                // Act
                _ = new FormActionAttribute(string.Empty, "title", 0);

            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void ShouldThrowOnNullButtonTitle() {
                // Arrange
                // Act
                _ = new FormActionAttribute("SomeForm", null, 0);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void ShouldThrowOnEmptyButtonTitle() {
                // Arrange
                // Act
                _ = new FormActionAttribute("SomeForm", string.Empty, 0);

            }

            [TestMethod]
            public void ShouldSetProperties() {
                // Arrange
                // Act
                var att = new FormActionAttribute("SomeForm", "SomeTitle", 1);

                // Assert
                Assert.AreEqual("SomeForm", att.Form);
                Assert.AreEqual("SomeTitle", att.ButtonTitle);
                Assert.AreEqual(1, att.Position);
            }
        }


        [TestClass]
        public class NavLinkTests {

            [TestMethod]
            // Assert
            [ExpectedException(typeof(ArgumentException))]
            public void ShouldThrowOnNullMenuGroup() {
                // Arrange
                // Act
                _ = new NavLinkAttribute(null, "title", 0);
            }

            [TestMethod]
            // Assert
            [ExpectedException(typeof(ArgumentException))]
            public void ShouldThrowOnEmptyMenuGroup() {
                // Arrange
                // Act
                _ = new NavLinkAttribute(string.Empty, "title", 0);

            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void ShouldThrowOnNullButtonTitle() {
                // Arrange
                // Act
                _ = new NavLinkAttribute("SomeMenu", null, 0);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void ShouldThrowOnEmptyButtonTitle() {
                // Arrange
                // Act
                _ = new NavLinkAttribute("SomeMenu", string.Empty, 0);

            }

            [TestMethod]
            public void ShouldSetProperties() {
                // Arrange
                // Act
                var att = new FormActionAttribute("SomeMenu", "SomeTitle", 1);

                // Assert
                Assert.AreEqual("SomeMenu", att.Form);
                Assert.AreEqual("SomeTitle", att.ButtonTitle);
                Assert.AreEqual(1, att.Position);
            }
        }


        [TestClass]
        public class FunctionArgumentTests {


            [TestMethod]
            // Assert
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void ShouldThrowOnOrdinalLessThanZero() {
                // Arrange
                // Act
                _ = new FunctionArgumentAttribute(-1, "SomeFunction", typeof(int), "SomeProperty");
            }

            [TestMethod]
            // Assert
            [ExpectedException(typeof(ArgumentException))]
            public void ShouldThrowOnNullFunctionName() {
                // Arrange
                // Act
                _ = new FunctionArgumentAttribute(1, null, typeof(int), "SomeProperty");
            }

            [TestMethod]
            // Assert
            [ExpectedException(typeof(ArgumentException))]
            public void ShouldThrowOnEmptyFunctionName() {
                // Arrange
                // Act
                _ = new FunctionArgumentAttribute(1, string.Empty, typeof(int), "SomeProperty");
            }

            [TestMethod]
            // Assert
            [ExpectedException(typeof(ArgumentNullException))]
            public void ShouldThrowOnNullReturnType() {
                // Arrange
                // Act
                _ = new FunctionArgumentAttribute(1, "SomeFunction", null, "SomeProperty");
            }

            [TestMethod]
            // Assert
            [ExpectedException(typeof(ArgumentException))]
            public void ShouldThrowOnNullPropertyName() {
                // Arrange
                // Act
                _ = new FunctionArgumentAttribute(1, "SomeFunction", typeof(int), null);
            }

            [TestMethod]
            // Assert
            [ExpectedException(typeof(ArgumentException))]
            public void ShouldThrowOnEmptyPropertyName() {
                // Arrange
                // Act
                _ = new FunctionArgumentAttribute(1, "SomeFunction", typeof(int), string.Empty);
            }

            [TestMethod]
            public void ShouldSetPropertyValues() {
                // Arrange
                // Act
                var att = new FunctionArgumentAttribute(1, "SomeFunction", typeof(int), "SomeProperty");

                // Assert
                Assert.AreEqual(1, att.Ordinal);
                Assert.AreEqual("SomeFunction", att.Name);
                Assert.AreEqual(typeof(int), att.ReturnType);
                Assert.AreEqual("SomeProperty", att.PropertyName);
            }
        }


        [TestClass]
        public class RequiredIfTests {

            [TestMethod]
            public void ShouldThrowIfOtherPropertyIsNull() {
                
            }

            [TestMethod]
            public void ShouldThrowIfOtherPropertyIsEmpty() {

            }

            [TestMethod]
            public void ShouldSetProperties() {

            }

            [TestMethod]
            public void ShouldProduceValidationResultsWhenPropertiesDoNotMatch() {

            }

            [TestMethod]
            public void ShouldNotProduceValidationResultsWhenRequiredProperty() {

            }


            [TestMethod]
            public void ShouldProduceValidationResultWhenPropertyIsUnknown() {

            }

            [TestMethod]
            public void ShouldProduceNoValidationResultsWhenInvertedIsFalseAndValueMatchesOtherProperty() {

            }

            [TestMethod]
            public void ShouldProduceNoValidationResultsWhenInvertedIsTrueAndValueDoesNotMatchOtherProperty() {

            }

            [TestMethod]
            public void ShouldProduceValidationResultsWhenInvertedIsFalseAndValueDoesNotMatchOtherProperty() {

            }

            [TestMethod]
            public void ShouldProduceValidationResultsWhenInvertedIsTrueAndValueMatchesOtherProperty() {

            }           
        }
    }
}