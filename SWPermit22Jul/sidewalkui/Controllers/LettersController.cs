﻿using SidewalkUI.Api;
using SidewalkUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace SidewalkUI.Controllers
{
    public class LettersController : Controller
    {
        SidewalkApiController api = new SidewalkApiController();
        //
        // GET: /Letters/
        public ActionResult NoticeLetter()
        { 
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
    }
    public class ResultSet
    {
        public List<NoticeLetterViewModel> GetResult(string search, string sortOrder, int start, int length, List<NoticeLetterViewModel> dtResult, List<string> columnFilters)
        {
            return FilterResult(search, dtResult, columnFilters).SortBy(sortOrder).Skip(start).Take(length).ToList();
        }

        public int Count(string search, List<NoticeLetterViewModel> dtResult, List<string> columnFilters)
        {
            return FilterResult(search, dtResult, columnFilters).Count();
        }

        private IQueryable<NoticeLetterViewModel> FilterResult(string search, List<NoticeLetterViewModel> dtResult, List<string> columnFilters)
        {
            IQueryable<NoticeLetterViewModel> results = dtResult.AsQueryable();
            try
            {

                results = results.Where(p => (search == null
                    || (p.AffidavitID.ToString() != null && p.AffidavitID.ToString().Contains(search)
                    || p.PropertyDescription != null && p.PropertyDescription.ToLower().Contains(search.ToLower())
                    //|| p.SiteStreetNumber != null && p.SiteStreetNumber.Contains(search)
                    //|| p.SiteStreetName != null && p.SiteStreetName.ToLower().Contains(search.ToLower())
                    || p.Owner1 != null && p.Owner1.ToLower().Contains(search.ToLower())
                    || p.PropertyID != null && p.PropertyID.ToLower().Contains(search.ToLower())
                    || p.InspectionDate != null && Convert.ToDateTime(p.InspectionDate).ToShortDateString().Contains(search)
                    //|| p.post_dt != null && p.post_dt.Contains(search)
                    //|| p.date_added != null && p.date_added.Contains(search)
                    || p.StatusValue != null || p.StatusValue.ToLower().Contains(search.ToLower())
                    //|| p.SiteStreetDesignator != null && p.SiteStreetDesignator.ToLower().Contains(search.ToLower())
                    || p.InspectorName != null && p.InspectorName.ToLower().Contains(search.ToLower())

                    ))
                    && (columnFilters[0] == null || (p.AffidavitID.ToString() != null && p.AffidavitID.ToString().Contains(columnFilters[0])))
                    && (columnFilters[1] == null || (p.PropertyDescription != null && p.PropertyDescription.ToLower().Contains(columnFilters[1].ToLower())))
                    && (columnFilters[2] == null || (p.Owner1 != null && p.Owner1.ToLower().Contains(columnFilters[2].ToLower())))
                    && (columnFilters[3] == null || (p.PropertyID != null && p.PropertyID.ToLower().Contains(columnFilters[3].ToLower())))
                    && (columnFilters[4] == null || (p.InspectionDate != null && p.InspectionDate.ToString().Contains(columnFilters[4])))
                    //&& (columnFilters[5] == null || (p.date_added != null && p.date_added.Contains(columnFilters[5])))
                    && (columnFilters[5] == null || (p.StatusValue != null && p.StatusValue.ToLower().Contains(columnFilters[5].ToLower())))
                    //&& (columnFilters[6] == null || (p.SiteStreetDesignator != null && p.SiteStreetDesignator.ToLower().Contains(columnFilters[6].ToLower())))
                    && (columnFilters[6] == null || (p.InspectorName != null && p.InspectorName.ToLower().Contains(columnFilters[6].ToLower())))
                    );
            }
            catch (Exception ex)
            {
            }
            return results;
        }
    }
}