using Lumen.Training.Libraries.API.Controllers.Interfaces;
using Lumen.Training.Libraries.Business.Interfaces;
using Lumen.Training.Libraries.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Lumen.Training.Libraries.API.Controllers.Impl
{
    public class CalculationOfferServiceController : ControllerBase, ICalculationOfferServiceController
    {
        private const string INVALID_DEP_ARGUMENTS = "Invalid Dependency Argument(s) Specified!";
        private ICalculationOfferProcessingBusinessComponent calculationOfferProcessingBusinessComponent = default(ICalculationOfferProcessingBusinessComponent);

        public CalculationOfferServiceController(ICalculationOfferProcessingBusinessComponent calculationOfferProcessingBusinessComponent)
        {
            var validation = calculationOfferProcessingBusinessComponent != default(ICalculationOfferProcessingBusinessComponent);

            if (!validation)
                throw new ArgumentNullException(INVALID_DEP_ARGUMENTS);

            this.calculationOfferProcessingBusinessComponent = calculationOfferProcessingBusinessComponent;
        }

        public IActionResult GetCalculationOfferRequests(string cardType)
        {
            throw new NotImplementedException();
        }

        public IActionResult GetCalculationOfferResponse(string requestNumber)
        {
            throw new NotImplementedException();
        }

        public IActionResult ProcessCalculationOfferService(CalculationOfferRequest calculationOfferRequest)
        {
            throw new NotImplementedException();
        }
    }
}
