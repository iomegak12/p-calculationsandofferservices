using Lumen.Training.Libraries.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumen.Training.Libraries.DAL.Interfaces
{
    public interface ICalculationOfferSystemContext : ISystemContext
    {
        DbSet<CalculationOfferRequest> CalculationOfferRequests { get; set; }
        DbSet<CalculationOfferResponse> CalculationOfferResponses { get; set; }
    }
}
