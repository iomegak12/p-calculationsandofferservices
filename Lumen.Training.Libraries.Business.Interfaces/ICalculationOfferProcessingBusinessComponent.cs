using Lumen.Training.Libraries.Shared.Models;
using System;
using System.Collections.Generic;

namespace Lumen.Training.Libraries.Business.Interfaces
{
    public interface ICalculationOfferProcessingBusinessComponent
    {
        CalculationOfferResponse ProcessCalculationOfferRequest(CalculationOfferRequest request);
        IEnumerable<CalculationOfferRequest> GetCalculationOfferRequests(string cardType);
        CalculationOfferResponse GetCalculationOfferResponse(string requestNumber);
    }
}
