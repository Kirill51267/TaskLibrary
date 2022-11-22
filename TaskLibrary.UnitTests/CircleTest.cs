namespace TaskLibrary.UnitTests
{
    public class CircleTest
    {
        [Fact]
        public void CalculateArea_1_return_Pi()
        {
            //Arrange
            var circle = new Circle(1);

            //Act
            var result = circle.CalculateArea();

            //Assert
            double expected = Math.PI;
            Assert.Equal(expected, result);
        }
    }
}