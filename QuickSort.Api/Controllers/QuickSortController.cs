using Microsoft.AspNetCore.Mvc;
using QuickSort.Domain.Services.Interfaces;

namespace QuickSort.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuickSortController : ControllerBase
    {
        private readonly IQuickSortService quickSortService;

        public QuickSortController(IQuickSortService quickSortService)
        {
            this.quickSortService = quickSortService;
        }

        [HttpPost]
        [Route("sort")]
        public IActionResult SortArray([FromBody] int[] array)
        {
            try
            {
                if (array == null || array.Length == 0)
                {
                    return BadRequest("Array cannot be empty.");
                }

                var sortedArray = quickSortService.GenerateQuickSort(array, 0, array.Length - 1);
                return Ok(sortedArray);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }
    }
}
