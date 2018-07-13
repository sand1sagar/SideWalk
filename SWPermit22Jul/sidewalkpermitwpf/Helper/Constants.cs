using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SidewalkPermitWPF.Helper
{
    public static class Constants
    {
        public const int PermitStatus_Submitted = 1;
        public const int PermitStatus_Accepted = 2;
        public const int PermitStatus_Rejected = 3;
        public const int PermitStatus_DoNotProcess = 4;
        public const int PermitStatus_Cancelled = 5;

        public const string PermitLastAction_Submitted = "Application Submitted";
        public const string PermitLastAction_Approved = "Application Approved";

        public const string PermitPaymentMethod_Card = "Credit";
        public const string PermitPaymentMethod_Check = "Check";
        public const string PermitPaymentMethod_Cash = "Cash";

        public const string RepairItem_Sidewalk = "4\" Sidewalk";
        public const string RepairItem_Driveway = "6\" Driveway";
        public const string RepairItem_Curbs = "Curbs";
        //public const string RepairItem_Curbs = "Curbs";

    }
}
