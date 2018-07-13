using Sidewalk.Logic.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sidewalk.Logic
{
    /// <summary>
    /// City repair item logic will be written here
    /// </summary>
    public class RepairItemLogic
    {
        SWPostEntities context = new SWPostEntities();

        /// <summary>
        /// This method will fill grid of City Contract screen
        /// </summary>
        /// <returns></returns>
        public List<RepairItemGridModel> GetRepairItems()
        {
            List<RepairItemGridModel> result = new List<RepairItemGridModel>();
            try
            {
                //result = (from info in context.RepairItem
                //          where info.IsActive == true
                //          select new RepairItemGridModel()
                //          {
                //              Action = info.RepairItemType,
                //              Print = info.PrintCode.PrintCodeID,
                //              UnitDescription = info.UnitOfMeasure.UomID,
                //              ShortDescription = info.PrintCode.PrintDescription,
                //              Flag = false
                //          }).ToList<RepairItemGridModel>();
            }
            catch (Exception ex)
            {
            }
            return result;
        }
        /// <summary>
        /// this method will use to get repair items
        /// </summary>
        /// <returns></returns>
        public List<PermitFeeRate> GetRepairItemRate()
        {
            List<PermitFeeRate> result = new List<PermitFeeRate>();
            try
            {
                result = context.PermitFeeRate.Where(x => x.Status.Equals(true)).ToList();
                //result = (from info in context.PermitFeeRate
                //          where info.Status == true
                //          select new PermitFeeRate()
                //          {
                //              Status = info.Status,
                //              Action_Type = info.Action_Type,
                //              CurrentRate = info.CurrentRate,
                //              PermitFeeID = info.PermitFeeID
                //          }).ToList<PermitFeeRate>();
            }
            catch (Exception ex)
            {
            }
            return result;
        }
    }
}
