using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppUpc.Common
{
    public static class Enums
    {
        public enum Status
        {
            Pending,
            Disabled,
            Approved
        }

        public enum OrderStatus
        {
            Pending,
            Approved,
            Canceled,
            Rejected
        }
    }
}
