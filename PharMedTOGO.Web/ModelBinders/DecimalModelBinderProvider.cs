using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace PharMedTOGO.Web.ModelBinders;

public class DecimalModelBinderProvider : IModelBinderProvider
{
    public IModelBinder? GetBinder(ModelBinderProviderContext context)
    {
        ArgumentNullException.ThrowIfNull(context);

        if (context.Metadata.ModelType == typeof(decimal)
            || context.Metadata.ModelType == typeof(decimal?))
        {
            return new DecimalModelBinder();
        }

        return null;
    }
}
