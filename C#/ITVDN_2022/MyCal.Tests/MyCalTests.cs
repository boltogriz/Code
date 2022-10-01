using System;
using Microsoft.VisualStudio.TestPlatform.Utilities;
namespace MyCal.Tests

{
    public class MyCalTests
    {
        [Fact]
        public void Sum_10and20_30returned()
        {
            // arrange
            int x = 10;
            int y = 20;
            int expected = 30;

            // act
            MyCal c = new MyCal();

            // assert
        }
    }
}