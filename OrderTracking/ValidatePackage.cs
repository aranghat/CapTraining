using System;
using System.Text.RegularExpressions;

namespace OrderTracking
{
    public static class ValidatePackage
    {
        public static bool Validate(string packageNumber)
        {
            packageNumber = packageNumber.Trim();
            return Regex.IsMatch(packageNumber, "^[a-zA-Z0-9]{1,10}$") 
                            && packageNumber.StartsWith("BLR"
                                    ,StringComparison.OrdinalIgnoreCase);
        }
    }
}
