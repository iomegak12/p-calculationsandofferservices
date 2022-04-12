using System;

namespace Lumen.Training.Libraries.Business.Validations.Interfaces
{
    public interface IBusinessValidation<ModelType>
    {
        bool Validate(ModelType entityType);
    }
}
