using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SidewalkUI.Models;
using Sidewalk.Logic;
using Sidewalk.Logic.Database;
using AutoMapper;
using SidewalkUI.Common;

namespace SidewalkUI.Controllers
{
    public class InspectionController : Controller
    {
        
        // GET: /Inspection/PostSidewalk
        public ActionResult PostSidewalk()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PostSidewalk(PostSidewalkModel model)
        {
            //PropertyDetailsLogic propertyLogic = new PropertyDetailsLogic();
            //Mapper.CreateMap<PostSidewalkModel, PropertyDetails>();
            //var property = Mapper.Map<PostSidewalkModel, PropertyDetails>(model);
            //if(model.PropertyID.ToString().Equals(Constant.EmptyGUID))
            //{
            //    property.CreatedDate = DateTime.Now;
            //    property.UpdatedDate = DateTime.Now;
            //}
            //else
            //{
            //    property.UpdatedDate = DateTime.Now;
            //}
            //if(propertyLogic.InsertPropertyDetails(property))
            //{
            //    //Create sidewalk
            //    SidewalkLogic sidewalkLogic=new SidewalkLogic ();
            //    SidewalkPost sidewalk = new SidewalkPost();
            //    sidewalk.PropertyID = property.PropertyID;
            //    sidewalk.SidewalkID = Guid.NewGuid();
            //    sidewalk.TrackID = "111";
            //    sidewalk.CreatedDate = DateTime.Now;
            //    //Create status
            //    if(sidewalkLogic.InsertSidewalk(sidewalk))
            //    {
            //        StatusLogic statusLogic = new StatusLogic();
                    
            //        SidewalkStatus sidewalkStatus = new SidewalkStatus();
            //        sidewalkStatus.PropertyID = property.PropertyID;
            //        sidewalkStatus.SidewalkID = sidewalk.SidewalkID;
            //        sidewalkStatus.StatusID = statusLogic.GetStatus(Constant.Status_SidewalkPosted).StatusID;
            //        sidewalkStatus.UpdateDate = DateTime.Now;
            //        sidewalkStatus.SidewalkStatusID = Guid.NewGuid();
            //        sidewalkLogic.InsertSidewalkStatus(sidewalkStatus);
            //    }
            //}
            //ViewBag.SidewalkPost = "Sidewalk posted successfully!";
            return View();
        }
        public ActionResult CreateAfficavit()
        {
            return View();
        }
        public ActionResult DeleteInspection()
        {
            return View();
        }
	}
}