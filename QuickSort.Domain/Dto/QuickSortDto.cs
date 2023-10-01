using QuickSort.Domain.Services.Interfaces;

namespace QuickSort.Domain.Dto
{
    public class QuickSortInput
    {
        public required int[] Array { get; set; }
        public int MinIndex { get; set; }
        public int MaxIndex { get; set; }
    }
}