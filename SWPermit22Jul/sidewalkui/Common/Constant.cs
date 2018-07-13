using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SidewalkUI.Common
{
    public static class Constant
    {
        //Empty GUID
        public const string EmptyGUID = "00000000-0000-0000-0000-000000000000";
        
        //Status Constants
        public const string Status_SidewalkPosted = "Sidewalk Posted";
        public const string Status_Inspection = "Inspection";
        public const string Status_InspectionRejected = "Inspection Rejected";
        public const string Status_NoticeSend = "Notice Send";
        public const string Status_2ndNoticeSend = "2nd Notice Send";
        public const string Status_Permit = "Permit";
        public const string Status_Repair = "Repair";
        public const string Status_FinalInspection = "Final Inspection";
        public const string Status_Done = "Done";
    }
}