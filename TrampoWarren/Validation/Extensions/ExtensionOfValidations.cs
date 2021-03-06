using System.Text.RegularExpressions;

namespace TrampoWarren.Validation.Extensions
{
    public static class ExtensionOfValidations
    {

        public static bool IsValidDocument(this string cpf)
        {
            var expression = "[0-9]{3}\\.?[0-9]{3}\\.?[0-9]{3}\\-?[0-9]{2}";
            return Regex.Match(cpf, expression).Success;
        }
        public static bool IsValidCellPhone(this string cellPhone)
        {
            var expression = "[0-9]{2}?[0-9]{4}?[0-9]{4}";
            return Regex.Match(cellPhone, expression).Success;
        }
        public static bool IsValidPostalCode(this string postalCode)
        {
            var expression = "[0-9]{5}\\-?[0-9]{3}";
            return Regex.Match(postalCode, expression).Success;
        }
    }
}
