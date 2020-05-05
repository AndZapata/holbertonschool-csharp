using NUnit.Framework;
namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void arrangeTest()
        {
            Assert.Pass();
        }
        [Test]
        public void defaultTest()
        {
            int[,] matrix = new int[,] {
                {1, 2},
                {3, 4},
                {5, 6},
                {7, 8},
                {9, 10}
            };
            int num = 2;
            int[,] result = Matrix.Divide(matrix, num);
            int[,] answer = new int[,] {
                {0, 1},
                {1, 2},
                {2, 3},
                {3, 4},
                {4, 5}
            };
            Assert.AreEqual(answer, result);
        }
        [Test]
        public void divideByZero()
        {
            int[,] matrix = new int[,] {
                {1, 2},
                {3, 4},
                {5, 6},
                {7, 8},
                {9, 10}
            };
            int num = 0;
            int[,] result = Matrix.Divide(matrix, num);
            Assert.AreEqual(null, result);
        }
        [Test]
        public void matrixIsNull()
        {
            int[,] matrix = null;
            int num = 0;
            int[,] result = Matrix.Divide(matrix, num);
            Assert.AreEqual(null, result);
        }
        [Test]
        public void zeroAtAnyPlace()
        {
            int[,] matrix = new int[,] {
                {1, 2},
                {3, 4},
                {5, 0},
                {7, 8},
                {9, 10}
            };
            int num = 2;
            int[,] result = Matrix.Divide(matrix, num);
            int[,] answer = new int[,] {
                {0, 1},
                {1, 2},
                {2, 0},
                {3, 4},
                {4, 5}
            };
            Assert.AreEqual(answer, result);
        }
    }
}
