using Lumen.Training.Libraries.Business.Interfaces;
using Lumen.Training.Libraries.Repos.Interfaces;
using Lumen.Training.Libraries.Shared.Models;
using System;
using System.Collections.Generic;

namespace Lumen.Training.Libraries.Business.Impl
{
    public class CalculationOfferProcessingBusinessComponent : ICalculationOfferProcessingBusinessComponent
    {
        private ICalculationOfferRequestRepository calculationOfferRequestRepository = default(ICalculationOfferRequestRepository);
        private ICalculationOfferResponseRepository CalculationOfferResponseRepository = default(ICalculationOfferResponseRepository);

        private const string INVALID_DEP_ARGUMENTS = "Invalid Dependency Argument(s) Specified!";
        public CalculationOfferProcessingBusinessComponent(
            ICalculationOfferRequestRepository calculationOfferRequestRepository, 
            ICalculationOfferResponseRepository calculationOfferResponseRepository)
        {
            var validation = calculationOfferRequestRepository != default(ICalculationOfferRequestRepository) &&
                calculationOfferResponseRepository != default(ICalculationOfferResponseRepository);

            if (!validation)
                throw new ArgumentNullException(INVALID_DEP_ARGUMENTS);

            this.calculationOfferRequestRepository = calculationOfferRequestRepository;
            this.CalculationOfferResponseRepository = calculationOfferResponseRepository;
        }

        public IEnumerable<CalculationOfferRequest> GetCalculationOfferRequests(string cardType)
        {
            throw new NotImplementedException();
        }

        public CalculationOfferResponse GetCalculationOfferResponse(string requestNumber)
        {
            throw new NotImplementedException();
        }

        public CalculationOfferResponse ProcessCalculationOfferRequest(CalculationOfferRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
