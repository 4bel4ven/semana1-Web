using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppUpc.Common
{
    public class ValidationHelper
    {
        public static bool ProductPendingOrDisabled(Enums.Status status)
        {
            var statusList = new List<Enums.Status>();

            statusList.Add(Enums.Status.Disabled);
            statusList.Add(Enums.Status.Pending);

            return statusList.Contains(status);
        }
    }
}
