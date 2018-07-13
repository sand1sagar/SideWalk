using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sidewalk.Logic.Database;

namespace Sidewalk.Logic
{
    /// <summary>
    /// Property related logic will be written here
    /// </summary>
    public class PropertyDetailsLogic
    {
        SWPostEntities context = new SWPostEntities();

        //public bool InsertPropertyDetails(PropertyDetails model)
        //{
        //    bool result = false;
        //    try
        //    {
        //        model.PropertyID = Guid.NewGuid();
        //        context.PropertyDetails.Add(model);
        //        context.SaveChanges();
        //        result = true;
        //        return result;
        //    }
        //    catch (Exception ex)
        //    {
        //        result = false;
        //    }
        //    return result;
        //}
    }
}
