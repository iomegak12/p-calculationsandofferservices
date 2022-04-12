using Lumen.Training.Libraries.Repos.Interfaces;
using Lumen.Training.Libraries.Shared.Models;
using System;
using System.Collections.Generic;

namespace Lumen.Training.Libraries.Repos.Impl
{
    public class CalculationOfferRequestRepository : ICalculationOfferRequestRepository
    {
        public CalculationOfferRequest AddNewEntity(CalculationOfferRequest entityType)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CalculationOfferRequest> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public CalculationOfferRequest GetEntityByKey(string entityKey)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CalculationOfferRequest> GetOfferRequests(string cardType)
        {
            throw new NotImplementedException();
        }
    }
}
