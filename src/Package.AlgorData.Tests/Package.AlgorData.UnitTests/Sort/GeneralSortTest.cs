using Package.AlgorData.Algorithms.Sort;

namespace Package.AlgorData.UnitTests.Sort
{
    public class GeneralSortTest
    {
        [Fact(DisplayName = "Sort An Array")]
        public void Sort_An_Array()
        {
            //Arrange
            int[] arr = new int[] { 35, 10, 25, 6 };
            int[] sortedArr = new int[] { 6, 10, 25, 35 };

            //Act
            new GeneralSort<int>(new Selection<int>()).Sort(arr);

            //Assert
            Assert.Equal(arr, sortedArr);
        }
    }
}