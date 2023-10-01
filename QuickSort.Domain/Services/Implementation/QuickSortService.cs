using QuickSort.Domain.Services.Interfaces;

namespace QuickSort.Domain.Services.Implementation
{
    public class QuickSortService : IQuickSortService
    {
        public int[] GenerateQuickSort(int[] Array, int MinIndex, int MaxIndex)
        {
            if (MinIndex < MaxIndex)
            {
                int pivotIndex = Partition(Array, MinIndex, MaxIndex);

                GenerateQuickSort(Array, MinIndex, pivotIndex - 1);
                GenerateQuickSort(Array, pivotIndex + 1, MaxIndex);
            }

            return Array;
        }

        private static int Partition(int[] Array, int MinIndex, int MaxIndex)
        {
            int pivot = Array[MaxIndex];
            int i = (MinIndex - 1);

            for (int j = MinIndex; j <= MaxIndex - 1; j++)
            {
                if (Array[j] < pivot)
                {
                    i++;
                    Swap(ref Array[i], ref Array[j]);
                }
            }

            Swap(ref Array[i + 1], ref Array[MaxIndex]);

            return i + 1;
        }

        private static void Swap(ref int leftItem, ref int rightItem)
        {
            (rightItem, leftItem) = (leftItem, rightItem);
        }
    }
}
