namespace QuickSort.Domain.Services.Interfaces
{
    public interface IQuickSortService
    {
        int[] GenerateQuickSort(int[] Array, int MinIndex, int MaxIndex);
    }
}