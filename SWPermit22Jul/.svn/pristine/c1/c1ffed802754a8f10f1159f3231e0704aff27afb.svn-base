using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SidewalkUI
{
    public static class ApplicationCommonClass
    {
        public static string ConvertSearchDateFormat(string pDate)
        {
            try
            {
                if (pDate != null)
                {
                    string[] splitData = pDate.Split('/');
                    if (splitData.Length == 3)
                    {
                        if (splitData[0].Length == 2 && splitData[0].StartsWith("0"))
                        {
                            splitData[0] = splitData[0].Replace((splitData[0].Substring(0, 1)), "");
                        }
                        if (splitData[1].Length == 2 && splitData[1].StartsWith("0"))
                        {
                            splitData[1] = splitData[1].Replace((splitData[1].Substring(0, 1)), "");
                        }
                        return (splitData[0] + "/" + splitData[1] + "/" + splitData[2]);
                    }
                    else
                        return pDate;
                }
                else
                {
                    return pDate;
                }
            }
            catch (Exception)
            {
                return pDate;
            }
        }
    }
}