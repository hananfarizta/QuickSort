using QuickSort.Domain.Services.Implementation;

namespace QuickSort.Tests
{
    public class QuickSortServiceTests
    {
        [Fact]
        public void QuickSort_ShouldNotModifySortedArray()
        {
            // Arrange
            var quickSortService = new QuickSortService();
            int[] sortedArray = { 1, 2, 3, 4, 5 };
            int[] expectedSortedArray = { 1, 2, 3, 4, 5 };

            // Act
            var result = quickSortService.GenerateQuickSort(sortedArray, 0, sortedArray.Length - 1);

            // Assert
            Assert.Equal(expectedSortedArray, result);
        }

        [Fact]
        public void QuickSort_ShouldSortArrayWithSameElements()
        {
            // Arrange
            var quickSortService = new QuickSortService();
            int[] unsortedArray = { 5, 5, 5, 5, 5 };
            int[] expectedSortedArray = { 5, 5, 5, 5, 5 };

            // Act
            var result = quickSortService.GenerateQuickSort(unsortedArray, 0, unsortedArray.Length - 1);

            // Assert
            Assert.Equal(expectedSortedArray, result);
        }

        [Fact]
        public void QuickSort_ShouldSortArrayInReverseOrder()
        {
            // Arrange
            var quickSortService = new QuickSortService();
            int[] unsortedArray = { 7, 6, 5, 4, 3, 2, 1 };
            int[] expectedSortedArray = { 1, 2, 3, 4, 5, 6, 7 };

            // Act
            var result = quickSortService.GenerateQuickSort(unsortedArray, 0, unsortedArray.Length - 1);

            // Assert
            Assert.Equal(expectedSortedArray, result);
        }
    }
}
