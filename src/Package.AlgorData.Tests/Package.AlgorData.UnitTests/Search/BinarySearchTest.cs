using PackageBinarySearch = Package.AlgorData.Algorithms.Search.BinarySearch;

namespace Package.AlgorData.UnitTests.Search
{
    public class BinarySearchTest
    {
        [Fact(DisplayName = "BinarySearch Should Return Index Of Element In An Array")]
        public void BinarySearch_Should_Return_Index_Of_Element_In_An_Array()
        {
            //Arrange
            PackageBinarySearch.BinarySearch<string> binSearch = new();
            string[] arr = new string[] {"a", "rosto" ,"maçã", "do"};
            string element = "maçã";

            //Act
            int elementIndex = binSearch.IndexOf(arr, element);

            //Assert
            Assert.Equal(2, elementIndex);
        }

        [Fact(DisplayName = "BinarySearch Should Return Minus One When Element Is Not In Array")]
        public void BinarySearch_Should_Return_MinusOne_When_Element_Is_Not_In_Array()
        {
            //Arrange
            PackageBinarySearch.BinarySearch<string> binSearch = new();
            string[] arr = new string[] {"a", "rosto" ,"maçã", "do"};
            string element = "carro";

            //Act
            int elementIndex = binSearch.IndexOf(arr, element);

            //Assert
            Assert.Equal(-1, elementIndex);
        }

        [Fact(DisplayName = "BinarySearch Should Throw InvalidOperationException In Empty Array")]
        public void BinarySearch_Should_Throw_InvalidOperationException_When_No_Array_Is_Provided()
        {
            //Arrange
            PackageBinarySearch.BinarySearch<int> binSearch = new();
            var expectedErrorMessage = "Can not peform search on null array";

            //Act && Assert
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => { binSearch.IndexOf(null, 12); });
            Assert.Equal(ex.Message, expectedErrorMessage);
        }
    }
}