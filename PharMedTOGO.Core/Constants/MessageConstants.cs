namespace PharMedTOGO.Core.Constants
{
    public static class MessageConstants
    {
        public const string RequiredMessage = "The following field is required";

        public const string MedicineNameLengthErrorMessage = "Incorrect Medicine Length";

        public const string MedicinePriceMaxValue = "100";
        public const string MedicinePriceMinValue = "0";

        public const string MedicinePriceRangeError = "Price per month must be a positive number and less than {2} leva.";
    }
}
