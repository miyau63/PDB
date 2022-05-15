using NUnit.Framework;
using task2;

namespace TestProject2
{
    public class Tests
    {
        public MatrBubl matr = new MatrBubl(new int[][]{ new int[]{4,9,6},
                                new int[]{11,0,5},
                                new int[]{14,1,2},
                                new int[]{10,2,2},
                                new int[]{15,26,30}});
        bool TestMatrix(int[][] matrix1, int[][] matrix2)
        {
            for (int i = 0; i < matrix1.Length; i++)
            {
                for (int j = 0; j < matrix1[i].Length; j++)
                {
                    if (matrix1[i][j] != matrix2[i][j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        [Test]
        public void Test1() //по возрастанию суммы
        {
            int[][] res = new int[][]{ new int[]{10,2,2}, 
                                new int[]{11,0,5},
                                new int[]{14,1,2},
                                new int[]{4,9,6},
                                new int[]{15,26,30}};
            matr.BubbleSort((a, b) => (a > b), Operat.Sum);
            Assert.IsTrue(TestMatrix(res, matr.Array));
            
        }

        [Test]
        public void Test2() //по возрастанию макс
        {
            int[][] res = new int[][]{ new int[]{4,9,6},
                                new int[]{10,2,2},
                                new int[]{11,0,5},
                                new int[]{14,1,2},
                                new int[]{15,26,30}};
            matr.BubbleSort((a, b) => (a > b), Operat.Max);
            Assert.IsTrue(TestMatrix(res, matr.Array));

        }

        [Test]
        public void Test3() //по возрастанию мин
        {
            int[][] res = new int[][]{ new int[]{11,0,5},
                                       new int[]{14,1,2},
                                       new int[]{10,2,2},
                                       new int[]{4,9,6},
                                       new int[]{15,26,30}};
            matr.BubbleSort((a, b) => (a > b), Operat.Min);
            Assert.IsTrue(TestMatrix(res, matr.Array));

        }

        [Test]
        public void Test4() //по убыванию мин
        {
            int[][] res = new int[][]{ new int[]{15,26,30},
                                       new int[]{4,9,6},
                                       new int[]{10,2,2},
                                       new int[]{14,1,2},
                                       new int[]{11,0,5}};
            matr.BubbleSort((a, b) => (a < b), Operat.Min);
            Assert.IsTrue(TestMatrix(res, matr.Array));

        }

        [Test]
        public void Test5() //по убыванию макс
        {
            int[][] res = new int[][]{new int[]{15,26,30} ,
                                new int[]{14,1,2}, new int[]{11,0,5},new int[]{10,2,2},new int[]{4,9,6}};
            matr.BubbleSort((a, b) => (a < b), Operat.Max);
            Assert.IsTrue(TestMatrix(res, matr.Array));

        }

        [Test]
        public void Test6() //по убыванию суммы
        {
            int[][] res = new int[][]{new int[]{15,26,30} ,
                                 new int[]{4,9,6},
                                new int[]{14,1,2},
                                new int[]{11,0,5},new int[]{10,2,2}};
            matr.BubbleSort((a, b) => (a < b), Operat.Sum);
            Assert.IsTrue(TestMatrix(res, matr.Array));

        }
    }
}