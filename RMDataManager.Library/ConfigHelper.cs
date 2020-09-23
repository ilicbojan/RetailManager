using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMDataManager.Library
{
    public class ConfigHelper
    {
        // TODO: Move this fro config to the API
        public static decimal GetTaxRate()
        {
            string rateText = ConfigurationManager.AppSettings["taxRate"];

            bool isValidTextRate = Decimal.TryParse(rateText, out decimal output);

            if (!isValidTextRate)
            {
                throw new ConfigurationErrorsException("The tax rate is not set up properly");
            }

            return output;
        }
    }
}
