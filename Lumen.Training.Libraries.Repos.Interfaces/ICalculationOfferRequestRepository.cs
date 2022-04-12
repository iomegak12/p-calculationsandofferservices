using Lumen.Training.Libraries.Shared.Models;
using System;
using System.Collections.Generic;

namespace Lumen.Training.Libraries.Repos.Interfaces
{
    public interface ICalculationOfferRequestRepository : IRepository<CalculationOfferRequest, string>
    {
        IEnumerable<CalculationOfferRequest> GetOfferRequests(string cardType);
    }
}
