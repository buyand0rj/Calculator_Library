using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;

namespace CalculatorLibrary.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_TwoPositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange
            SimpleCalculator calculator = new SimpleCalculator();

            // Act
            int result = calculator.Add(5, 3);

            // Assert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Add_NegativeAndPositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange
            SimpleCalculator calculator = new SimpleCalculator();

            // Act
            int result = calculator.Add(-5, 8);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Subtract_TwoPositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange
            SimpleCalculator calculator = new SimpleCalculator();

            // Act
            int result = calculator.Subtract(10, 4);

            // Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Subtract_NegativeAndPositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange
            SimpleCalculator calculator = new SimpleCalculator();

            // Act
            int result = calculator.Subtract(-5, 3);

            // Assert
            Assert.AreEqual(-8, result);
        }

        [TestMethod]
        public void Memory_AddMultipleItems_ReturnsCorrectMemoryItems()
        {
            // Arrange
            Memory memory = new Memory();

            // Act
            memory.AddToMemory(15);
            memory.AddToMemory(8);
            memory.AddToMemory(3);

            // Assert
            var memoryItems = memory.GetMemoryItems();
            Assert.AreEqual(3, memoryItems.Count);
            Assert.AreEqual(15, memoryItems[0].Value);
            Assert.AreEqual(8, memoryItems[1].Value);
            Assert.AreEqual(3, memoryItems[2].Value);
        }

        [TestMethod]
        public void Memory_GetMemoryItems_EmptyMemory_ReturnsEmptyList()
        {
            // Arrange
            Memory memory = new Memory();

            // Act
            var memoryItems = memory.GetMemoryItems();

            // Assert
            Assert.IsNotNull(memoryItems);
            Assert.AreEqual(0, memoryItems.Count);
        }
    }
}
