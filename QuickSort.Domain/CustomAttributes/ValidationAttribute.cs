using System.ComponentModel.DataAnnotations;

namespace QuickSort.Domain.CustomAttributes
{
    public class CalculateQuickSortAttribute : ValidationAttribute
    {
        public CalculateQuickSortAttribute()
        {
            ErrorMessage = "Array is not sorted correctly using QuickSort.";
        }

        public override bool IsValid(object value)
        {
            if (value is int[] Array)
            {
                return IsSorted(Array);
            }

            return false;
        }

        private bool IsSorted(int[] Array)
        {
            return IsSorted(Array, 0, Array.Length - 1);
        }

        private bool IsSorted(int[] Array, int minIndex, int maxIndex)
        {
            if (minIndex < maxIndex)
            {
                int pivotIndex = Partition(Array, minIndex, maxIndex);

                if (pivotIndex > 0 && pivotIndex < maxIndex)
                {
                    return IsSorted(Array, minIndex, pivotIndex - 1) && IsSorted(Array, pivotIndex + 1, maxIndex);
                }
            }

            return true;
        }

        private static int Partition(int[] Array, int minIndex, int maxIndex)
        {
            int pivot = Array[maxIndex];
            int i = (minIndex - 1);

            for (int j = minIndex; j <= maxIndex - 1; j++)
            {
                if (Array[j] < pivot)
                {
                    i++;
                    Swap(ref Array[i], ref Array[j]);
                }
            }

            Swap(ref Array[i + 1], ref Array[maxIndex]);

            return i + 1;
        }

        private static void Swap(ref int leftItem, ref int rightItem)
        {
            (rightItem, leftItem) = (leftItem, rightItem);
        }
    }
}
