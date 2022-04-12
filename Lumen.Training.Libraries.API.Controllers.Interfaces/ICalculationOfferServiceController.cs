using Lumen.Training.Libraries.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Lumen.Training.Libraries.API.Controllers.Interfaces
{
    public interface ICalculationOfferServiceController
    {
        IActionResult ProcessCalculationOfferService(CalculationOfferRequest calculationOfferRequest);
        IActionResult GetCalculationOfferRequests(string cardType);
        IActionResult GetCalculationOfferResponse(string requestNumber);
    }
}
