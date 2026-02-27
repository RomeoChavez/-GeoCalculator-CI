using Xunit;
using GeoApp.Models;

namespace GeoApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAreaRectangulo()
        {
            // Arrange & Act
            double resultado = Calculadora.AreaRectangulo(10, 5);

            // Assert
            Assert.Equal(50, resultado);
        }
    }
}