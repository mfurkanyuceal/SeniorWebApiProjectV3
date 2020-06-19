using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SeniorWebAPIProjectV3.Models;
using SeniorWebAPIProjectV3.Services;

namespace SeniorWebAPIProjectV3.Controllers
{
    public class SwapController : Controller
    {
        private readonly ILogger<SwapController> _logger;
        private readonly ISwapService _swapService;

        public SwapController(ILogger<SwapController> logger, ISwapService swapService)
        {
            _logger = logger;
            _swapService = swapService;
        }


        [HttpGet]
        public async Task<List<Swap>> GetAllSwaps()
        {
            return await _swapService.GetSwapListAsync();
        }

        [HttpGet]
        public async Task<List<Swap>> GetSwapsByUserId([FromRoute] string userId)
        {
            return await _swapService.SearchSwapByUserIdAsync(userId);
        }

        [HttpGet]
        public async Task<Swap> GetSwap([FromRoute] string swapId)
        {
            return await _swapService.GetSwapBySwapIdAsync(swapId);
        }

        [HttpGet]
        public async Task<bool> Delete([FromRoute] string swapId)
        {
            var swap = await _swapService.GetSwapBySwapIdAsync(swapId);

            if (swap == null)
            {
                return false;
            }


            var deleted = await _swapService.DeleteSwapBySwapIdAsync(swapId);

            return deleted;
        }

        [HttpPost]
        public async Task<Swap> Update([FromBody] Swap swap)
        {
            var tempSwap = await _swapService.GetSwapBySwapIdAsync(swap.SwapId);

            if (tempSwap == null)
            {
                return null;
            }


            var updatedSwap = await _swapService.UpdateSwapAsync(swap);


            if (updatedSwap)
            {
                return await _swapService.GetSwapBySwapIdAsync(swap.SwapId);
            }

            return null;
        }


        [HttpPost]
        public async Task<Swap> Create([FromBody] Swap swap)
        {
            
            var created = await _swapService.AddSwapAsync(swap);

            if (!created)
            {
                return null;
            }

            return await _swapService.GetSwapBySwapIdAsync(swap.SwapId);
        }
    }
}