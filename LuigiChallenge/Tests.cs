using System;
using LuigiChallenge;
using Xunit;
namespace LuigiChallenge
{
    public class LuigiTest
    {

        private static int[][] map1 = new int[][]{
                                               new int[] { 7, 0, 2, 5, 3 },
                                               new int[] { 5, 0, 0, 0, 2 },
                                               new int[] { 6, 9, 9, 0, 5 },
                                               new int[] { 8, 3, 2, 0, 1 }};



        [Theory]
        [InlineData("Down Right Right Down Down")]
        public void Map1(string expected)
        {
            //Arrange
            var luigi = new Luigi();

            //Act

            var actual = luigi.GoHome2D(map1);

            //Assert
            Assert.Equal(expected, actual);
        }


        private static int[][] map2 = new int[][] {
                                       new int[] {0, 9, 3, 9, 3, 9, 3},
                                       new int[] {0, 2, 3, 4, 2, 3, 4},
                                       new int[] {0, 9, 9, 3, 5, 4, 7},
                                       new int[] {0, 0, 0, 0, 0, 0, 0}};

        [Theory]
        [InlineData("Down Down Down Right Right Right Right Right Right")]
        public void Map2(string expected)
        {
            //Arrange
            var luigi = new Luigi();

            //Act

            var actual = luigi.GoHome2D(map2);

            //Assert
            Assert.Equal(expected, actual);


        }



        private static int[][] map3 = new int[][] {
                                                 new int[]  {0, 0, 0, 0, 3, 9, 3},
                                                 new int[]  {7, 2, 3, 0, 0, 3, 4},
                                                 new int[]  {4, 9, 9, 3, 0, 4, 7},
                                                 new int[]  {1, 9, 6, 1, 0, 0, 0}};

        [Theory]
        [InlineData("Right Right Right Down Right Down Down Right Right")]
        public void Map3(string expected)
        {
            //Arrange
            var luigi = new Luigi();

            //Act

            var actual = luigi.GoHome2D(map3);

            //Assert
            Assert.Equal(expected, actual);


        }

        private static int[][] map4 = new int[][] {
                                                new int[]  {0, 9, 3, 9, 3, 9, 3},
                                                new int[]  {0, 0, 3, 4, 2, 3, 4},
                                                new int[]  {6, 0, 9, 3, 5, 4, 7},
                                                new int[]  {7, 0, 0, 0, 0, 0, 0}};

        [Theory]
        [InlineData("Down Right Down Down Right Right Right Right Right")]
        public void Map4(string expected)
        {
            //Arrange
            var luigi = new Luigi();

            //Act

            var actual = luigi.GoHome2D(map4);

            //Assert
            Assert.Equal(expected, actual);

        }


    }
}
