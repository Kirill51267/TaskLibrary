namespace TaskLibrary.UnitTests
{
    public class TriangleTest
    {
        [Fact]
        public void CalculateArea_3and4and5_Return_6()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            var result = triangle.CalculateArea();

            //Assert
            double expected = 6;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void isStraightTriangle_3and4and5_Return_false()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            var result = triangle.isStraightTriangle();

            //Assert
            Assert.False(result);
        }
    }
}
