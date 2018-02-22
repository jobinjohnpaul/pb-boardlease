using PBBoardLeaseCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PBBoardLeaseCalculator.Services
{
    public interface IPriceCalculatorService
    {
        /// <summary>
        /// Get the price for a lease item given the location and size of the board
        /// </summary>
        /// <param name="propertyLocation">The state the board is to be used in</param>
        /// <param name="boardSize">The size of the board</param>
        /// <returns></returns>
        double GetPriceForLeaseItem(State propertyLocation, BoardSize boardSize);

        /// <summary>
        /// Get discount if any to be applied on this
        /// </summary>
        ///<param name="propertyLocation">The state the board is to be used</param>
        /// <param name="boardSize">The size of the board</param>
        /// <param name="duration">The duration of lease for this board</param>
        /// <returns></returns>
        double GetDiscountForLeaseItem(State propertyLocation, BoardSize boardSize, int duration);
    }
}
