using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SeniorWebAPIProjectV3.DBContext;
using SeniorWebAPIProjectV3.Models;

namespace SeniorWebAPIProjectV3.Services
{
    public interface ISwapService
    {
        public Task<bool> AddSwapAsync(Swap swap);
        public Task<List<Swap>> GetSwapListAsync();
        public Task<bool> UpdateSwapListAsync(List<Swap> swapList);
        public Task<List<Swap>> SearchSwapByUserIdAsync(string userId);
        public Task<List<Swap>> SearchSwapByUserNameAsync(string userName);
        public Task<Swap> GetSwapBySwapIdAsync(string swapId);
        public Task<bool> UpdateSwapAsync(Swap swap);
        public Task<bool> DeleteSwapBySwapIdAsync(string swapId);
    }

    public class SwapService : ISwapService
    {
        private readonly DataContext _dataContext;

        public SwapService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public async Task<bool> AddSwapAsync(Swap swap)
        {
            await _dataContext.Swaps.AddAsync(swap);

            var created = await _dataContext.SaveChangesAsync();

            return created > 0;
        }

        public async Task<List<Swap>> GetSwapListAsync()
        {
            return await _dataContext.Swaps.ToListAsync();
        }

        public async Task<bool> UpdateSwapListAsync(List<Swap> swapList)
        {
            _dataContext.Swaps.UpdateRange(swapList);

            var updated = await _dataContext.SaveChangesAsync();

            return updated > 0;
        }

        public async Task<List<Swap>> SearchSwapByUserIdAsync(string userId)
        {
            var resultList =
                await _dataContext.Swaps
                    .Where(swap => (swap.senderUserID == userId || swap.receiverUserID == userId))
                    .ToListAsync();

            return resultList;
        }

        public async Task<List<Swap>> SearchSwapByUserNameAsync(string userName)
        {
            var resultList =
                await _dataContext.Swaps
                    .Where(swap => (swap.senderUserName == userName || swap.receiverUserName == userName))
                    .ToListAsync();

            return resultList;
        }

        public async Task<Swap> GetSwapBySwapIdAsync(string swapId)
        {
            return await _dataContext.Swaps.SingleOrDefaultAsync(swap => swap.swapID == swapId);
        }

        public async Task<bool> UpdateSwapAsync(Swap swap)
        {
            _dataContext.Swaps.Update(swap);
            var updated = await _dataContext.SaveChangesAsync();
            return updated > 0;
        }

        public async Task<bool> DeleteSwapBySwapIdAsync(string swapId)
        {
            var swap = await GetSwapBySwapIdAsync(swapId);

            if (swap == null)
            {
                return false;
            }

            _dataContext.Swaps.Remove(swap);

            var deleted = await _dataContext.SaveChangesAsync();

            return deleted > 0;
        }
    }
}