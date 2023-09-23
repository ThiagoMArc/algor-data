using Package.AlgorData.Algorithms.Sort;

namespace Package.AlgorData.UnitTests.Sort
{
    public class GeneralSortTest
    {
        [Theory(DisplayName = "Sort An Array")]
        [MemberData(nameof(GetSortAlgorithm))]
        public void Sort_An_Array(ISort<int> sortAlgorithm)
        {
            //Arrange
            int[] arr = new int[] { 35, 10, 25, 6 };
            int[] sortedArr = new int[] { 6, 10, 25, 35 };

            //Act
            new GeneralSort<int>(sortAlgorithm).Sort(arr);

            //Assert
            Assert.Equal(arr, sortedArr);
        }

        public static IEnumerable<object[]> GetSortAlgorithm()
        {
            var sortAlgorithm = new List<object[]>
            {
                new object[] { new Selection<int>() },
            };

            return sortAlgorithm;
        }
    }
}