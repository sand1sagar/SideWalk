using Sidewalk.Logic.Database;
using SidewalkUI.Api;
using SidewalkUI.Common;
using SidewalkUI.Filters;
using SidewalkUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace SidewalkUI.Controllers
{
    [MenuFilter]
    public class HomeController : Controller
    {
        SidewalkApiController api = new SidewalkApiController();
        public ActionResult Index()
        {
            var user = Request.LogonUserIdentity;
            return View();
        }

        public JsonResult DataHandler(DTParameters param)
        {
            try
            {
                Models.SearchParemeters keyword = new SearchParemeters();
                var dtsource = new List<NoticeLetterViewModel>();
                List<String> columnSearch = new List<string>();
                foreach (var col in param.Columns)
                {
                    //switch (col.Data)
                    //{
                    //    case "aff_no":
                    //        keyword.AffidavitId = col.Search.Value;
                    //        param.Search.Value = col.Search.Value;
                    //        break;
                    //    case "property_id":
                    //        keyword.PropertyId = col.Search.Value;
                    //        param.Search.Value = col.Search.Value;
                    //        break;
                    //    case "post_dt":
                    //        keyword.InspectionDate = col.Search.Value;
                    //        param.Search.Value = col.Search.Value;
                    //        break;
                    //    case "date_added":
                    //        keyword.AffidavitId = col.Search.Value;
                    //        param.Search.Value = col.Search.Value;
                    //        break;
                    //    case "notes":
                    //        keyword.AffidavitId = col.Search.Value;
                    //        param.Search.Value = col.Search.Value;
                    //        break;
                    //    case "designator":
                    //        keyword.AffidavitId = col.Search.Value;
                    //        param.Search.Value = col.Search.Value;
                    //        break;
                    //    case "property_desc":
                    //        keyword.AffidavitId = col.Search.Value;
                    //        param.Search.Value = col.Search.Value;
                    //        break;
                    //}

                    if (col.Data == "post_dt")
                    {
                        columnSearch.Add(ApplicationCommonClass.ConvertSearchDateFormat(col.Search.Value));
                    }
                    else
                        columnSearch.Add(col.Search.Value);
                }
                keyword.FromDate = (string.IsNullOrEmpty(param.FromDate) ? null : Convert.ToDateTime(param.FromDate).ToString("MM/dd/yyyy"));
                keyword.ToDate = (string.IsNullOrEmpty(param.ToDate) ? null : Convert.ToDateTime(param.ToDate).ToString("MM/dd/yyyy"));
                dtsource = api.GetAffidavitByParameters(keyword);


                List<NoticeLetterViewModel> data = new ResultSet().GetResult(param.Search.Value, param.SortOrder, param.Start, param.Length, dtsource, columnSearch);
                int count = new ResultSet().Count(param.Search.Value, dtsource, columnSearch);
                DTResult<NoticeLetterViewModel> result = new DTResult<NoticeLetterViewModel>
                {
                    draw = param.Draw,
                    data = data,
                    recordsFiltered = count,
                    recordsTotal = count
                };
                return Json(result);
            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message });
            }
        }

        public ActionResult SearchAffidavit(Models.SearchParemeters keyword)
        {
            List<NoticeLetterViewModel> result = api.GetAffidavitByParameters(keyword);

            return View();
        }
        public ActionResult SecondNoticeLetter()
        {
            return View();
        }

        public JsonResult Token()
        {
            var user = Request.LogonUserIdentity;
            string userName = user.Name.Split('\\')[1].ToString();
            string expiryTime = DateTime.Now.AddHours(8).ToString();
            var token = string.Format("{0}-{1}", userName, expiryTime);
            token = Helper.Base64Encode(token);
            return Json(token, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetAllAffidavit()
        {
            var fromDate = DateTime.Now.AddYears(-1).ToShortDateString();
            var toDate = DateTime.Now.ToShortDateString();

            ViewBag.FromDate = fromDate;
            ViewBag.ToDate = toDate;

            var result = api.GetAllAffidavit(fromDate, toDate);
            return View(result);
        }

        [HttpPost]
        public ActionResult GetAllAffidavit(string FromDate, string ToDate)
        {
            ViewBag.FromDate = FromDate;
            ViewBag.ToDate = ToDate;

            var result = api.GetAllAffidavit(FromDate, ToDate);
            return View(result);
        }

        public ActionResult SendPrint(string lstaffidavitid)
        {
            return null;
        }

        [HttpGet]
        public ActionResult GetAllTrackIT()
        {
            var result = api.GetAllTrackIT();
            var lstTrackIt = (List<AffidavitModel>)result[0];
            var lstAffidavitStatus = (List<AffidavitModel>)result[1];
            TempData["lstAffidavitData"] = lstAffidavitStatus;
            var lstSiteAddress = (from company in lstAffidavitStatus
                                  select company).ToList().Select(c => new SelectListItem
                                  {
                                      Value = c.AffidavitId.ToString(),
                                      Text = c.SiteAddress
                                  });
            ViewData["GetSiteAddress"] = new SelectList(lstSiteAddress, "Value", "Text");
            ViewData["GetAffidavit"] = new SelectList(lstSiteAddress, "Value", "Value");
            ViewBag.AffidavitData = lstAffidavitStatus;

            var lstTypeOfInspection = new List<SelectListItem>
            {
                new SelectListItem {Text="Form Inspection",Value="Form Inspection" },
                new SelectListItem {Text="Partial Form Inspection",Value="Partial Form Inspection" },
                new SelectListItem {Text="Final Inspection",Value="Final Inspection" }
            };

            ViewData["TypeOfInspection"] = new SelectList(lstTypeOfInspection, "Value", "Text");
            return View(lstTrackIt);
        }

        public JsonResult SaveTrackItDetails(string affidavitId, string comments, string typeofinspection)
        {
            AffidavitModel aff = new AffidavitModel();
            aff.AffidavitId = Convert.ToInt64(affidavitId);
            aff.Comments = comments;
            aff.TypeOfInspectionNeeded = typeofinspection;

            var result = api.SaveTrackItDetails(aff);
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetTrackItData(long affidavitid)
        {
            AffidavitModel aff = new AffidavitModel();
            if (TempData["lstAffidavitData"] != null)
            {
                TempData.Keep("lstAffidavitData");
                var lstaffidavit = (List<AffidavitModel>)TempData["lstAffidavitData"];
                aff = lstaffidavit.Where(x => x.AffidavitId == affidavitid).SingleOrDefault();
            }
            else
            {
                var result = api.GetAllTrackIT();
                var lstTrackIt = (List<AffidavitModel>)result[0];
                var lstAffidavitStatus = (List<AffidavitModel>)result[1];
                TempData["lstAffidavitData"] = lstAffidavitStatus;
                var lstaffidavit = (List<AffidavitModel>)TempData["lstAffidavitData"];
                aff = lstaffidavit.Where(x => x.AffidavitId == affidavitid).SingleOrDefault();
            }

            return Json(aff, JsonRequestBehavior.AllowGet);
        }

    }
}