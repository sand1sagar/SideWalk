using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sidewalk.Logic.Database;

namespace Sidewalk.Logic
{
    /// <summary>
    /// Logic for status of affidavit will be written here
    /// </summary>

    public class ErrorLogLogic
    {
        SWPostEntities context = new SWPostEntities();

        public List<ErrorLog> GetErrorList()
        {
            List<ErrorLog> result = new List<ErrorLog>();
            try
            {
                result = context.ErrorLog.OrderByDescending(x => x.CreatedDate).ToList();
            }
            catch (Exception ex)
            {
            }
            return result;
        }

        public void InsertErrorLog(ErrorLog model)
        {
            try
            {
                context.ErrorLog.Add(model);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
