using Lumen.Training.Libraries.DAL.Interfaces;
using Lumen.Training.Libraries.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Lumen.Training.Libraries.DAL.Impl
{
    public class CalculationOfferSystemContext : DbContext, ICalculationOfferSystemContext
    {
        public DbSet<CalculationOfferRequest> CalculationOfferRequests { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<CalculationOfferResponse> CalculationOfferResponses { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CommitChanges()
        {
            throw new NotImplementedException();
        }
    }
}
