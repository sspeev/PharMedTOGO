using System.ComponentModel.DataAnnotations;
using System.Globalization;
using static PharMedTOGO.Core.Constants.MessageConstants;

namespace PharMedTOGO.Core.Attributes
{
    public class DateValid : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;

            var isValid = DateTime.TryParseExact(value.ToString(),
                DateFormat,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out dateTime);

            if (isValid && dateTime.Year > 2020)
            {
                return true;
            }
            else return false;
        }
    }
}
