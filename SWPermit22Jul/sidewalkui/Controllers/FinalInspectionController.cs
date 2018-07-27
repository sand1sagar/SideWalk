using SidewalkUI.Api;
using SidewalkUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SidewalkUI.Controllers
{
    public class FinalInspectionController : Controller
    {
        ////
        //// GET: /FinalInspection/RepairsNotAcceptable


        SidewalkApiController api = new SidewalkApiController();
        public ActionResult RepairsAreCompleteAndSatisfactory(long affidavitNo, string redirectURL = null)
        {
            FormFinalInspectionViewModel model = new FormFinalInspectionViewModel();
            model.AffidavitDetails = api.GetAffidavitByNo(affidavitNo.ToString());
            model.FinalInspection = api.GetAffidavitFinalInspection(affidavitNo, 12);
            if (model.FinalInspection == null)
            {
                model.FinalInspection = new Sidewalk.Logic.Database.AffidavitFinalInspection();
                model.FinalInspection.FinalPassInspectorId = model.AffidavitDetails.AffidavitInfo.Inspector.InspectorId;
                model.FinalInspection.AffidavitID = affidavitNo;
            }
            else
            {
                model.FinalInspection.FinalPassInspectorId = model.AffidavitDetails.AffidavitInfo.Inspector.InspectorId;
            }
            model.redirecURL = redirectURL;

            return View(model);
        }
        public ActionResult RepairsNotAcceptable(long affidavitNo, string redirectURL = null)
        {
            FormFinalInspectionViewModel model = new FormFinalInspectionViewModel();
            model.AffidavitDetails = api.GetAffidavitByNo(affidavitNo.ToString());
            model.FinalInspection = api.GetAffidavitFinalInspection(affidavitNo, 8);
            if (model.FinalInspection == null)
            {
                model.FinalInspection = new Sidewalk.Logic.Database.AffidavitFinalInspection();
                model.FinalInspection.FinalFailInspectorId = model.AffidavitDetails.AffidavitInfo.Inspector.InspectorId;
                model.FinalInspection.AffidavitID = affidavitNo;
            }
            else
            {
                model.FinalInspection.FinalFailInspectorId = model.AffidavitDetails.AffidavitInfo.Inspector.InspectorId;
            }
            model.redirecURL = redirectURL;
            return View(model);
        }
        
        [HttpPost]
        public ActionResult RepairsNotAcceptable(FormFinalInspectionViewModel model)
        {
            api.AddAffidavitFinalInspection(model.FinalInspection, 8);
            if (model.redirecURL == "TrackIt")
            {
                return RedirectToAction("GetAllTrackIT", "Home", new { affidavitNo = model.FinalInspection.AffidavitID });
            }
            else
            {
                return RedirectToAction("GetAffidavitByNo", "Affidavit", new { affidavitNo = model.FinalInspection.AffidavitID });
            }
        }

        [HttpPost]
        public ActionResult RepairsAreCompleteAndSatisfactory(FormFinalInspectionViewModel model)
        {
            api.AddAffidavitFinalInspection(model.FinalInspection, 12);
            if (model.redirecURL == "TrackIt")
            {
                return RedirectToAction("GetAllTrackIT", "Home", new { affidavitNo = model.FinalInspection.AffidavitID });
            }
            else
            {
                return RedirectToAction("GetAffidavitByNo", "Affidavit", new { affidavitNo = model.FinalInspection.AffidavitID });
            }
        }
    }
}