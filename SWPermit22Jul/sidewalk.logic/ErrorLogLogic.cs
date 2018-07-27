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

    public class FormLogic
    {
        SWPostEntities context = new SWPostEntities();

        public bool AddAffidavitFormInspection(AffidavitFormInspection model, int type)
        {
            bool result = false;
            try
            {
                var existingRecord = context.AffidavitFormInspection.Where(x => x.AffidavitId.Equals(model.AffidavitId)).FirstOrDefault();
                if (existingRecord == null)
                {
                    model.InspectionDate = DateTime.Now;
                    AffidavitHistory history = new AffidavitHistory();
                    var affidavit = context.Affidavit.Where(x => x.AffidavitID.Equals(model.AffidavitId)).FirstOrDefault();
                    var status = context.AffidavitStatus.Where(x => x.AffidavitStatusId == type).FirstOrDefault();
                    history.StatusValue = status.Status;
                    affidavit.Status = status.AffidavitStatusId;
                    history.AffidavitId = model.AffidavitId;
                    history.AffidavitStatusId = type;
                    history.CreatedDate = DateTime.Now;

                    if (type == 5)
                    {
                        history.Comments = model.OtherDoNotPour;
                        history.InspectorId = model.FormFailInspectorId;
                        model.FormFailDate = DateTime.Now;
                    }
                    else if(type == 15)
                    {
                        history.Comments = model.OtherGrantedToPour;
                        history.InspectorId = model.FormPassInspectorId;
                    }
                    else if (type == 6)
                    {
                        history.Comments = model.OtherGrantedToPour;
                        history.InspectorId = model.FormPassInspectorId;
                        model.PermissionGranted = true;
                        model.CompletionDate = DateTime.Now;
                    }
                    model.IsFormPartial = model.IsFormPartial;
                    //model.AffidavitHistory.Add(history);
                    context.AffidavitFormInspection.Add(model);
                    context.AffidavitHistory.Add(history);
                    context.SaveChanges();
                    
                }
                else
                {
                    //var existingRecordHistory = existingRecord.AffidavitHistory.Where(x => x.AffidavitStatusId == type).FirstOrDefault();
                    var existingRecordHistory = context.AffidavitHistory.Where(x => x.AffidavitStatusId == type && x.AffidavitId == existingRecord.AffidavitId).FirstOrDefault();
                    if (existingRecordHistory != null)
                    {
                        var history = context.AffidavitHistory.Where(x => x.AffidavitId.Equals(model.AffidavitId) && x.AffidavitStatusId.Equals(type)).FirstOrDefault();
                        if (type == 5)
                        {
                            history.Comments = model.OtherDoNotPour;
                            history.InspectorId = model.FormFailInspectorId;
                            model.FormFailDate = DateTime.Now;
                        }
                        else if (type == 15)
                        {
                            history.Comments = model.OtherGrantedToPour;
                            history.InspectorId = model.FormPassInspectorId;
                            
                        }
                        else if (type == 6)
                        {
                            history.Comments = model.OtherGrantedToPour;
                            history.InspectorId = model.FormPassInspectorId;
                            existingRecord.PermissionGranted = true;
                            existingRecord.CompletionDate = DateTime.Now;
                        }

                        history.CreatedDate = DateTime.Now;
                    }
                    else
                    {
                        AffidavitHistory history = new AffidavitHistory();
                        var affidavit = context.Affidavit.Where(x => x.AffidavitID.Equals(model.AffidavitId)).FirstOrDefault();
                        var status = context.AffidavitStatus.Where(x => x.AffidavitStatusId == type).FirstOrDefault();
                        history.StatusValue = status.Status;
                        affidavit.Status = status.AffidavitStatusId;
                        history.AffidavitId = model.AffidavitId;
                        history.AffidavitStatusId = type;
                        history.CreatedDate = DateTime.Now;
                        if (type == 5)
                        {
                            history.Comments = model.OtherDoNotPour;
                            history.InspectorId = model.FormFailInspectorId;
                            model.FormFailDate = DateTime.Now;
                        }
                        else if (type == 15)
                        {
                            history.Comments = model.OtherGrantedToPour;
                            history.InspectorId = model.FormPassInspectorId;
                            existingRecord.IsFormPartial = model.IsFormPartial;
                        }
                        else if (type == 6)
                        {
                            history.Comments = model.OtherGrantedToPour;
                            history.InspectorId = model.FormPassInspectorId;
                            existingRecord.PermissionGranted = true;
                            existingRecord.CompletionDate = DateTime.Now;
                        }


                        context.AffidavitHistory.Add(history);
                    }
                    existingRecord.Sidewalk = model.Sidewalk;
                    existingRecord.Driveway = model.Driveway;
                    existingRecord.Curb = model.Curb;
                    existingRecord.NotReady = model.NotReady;
                    existingRecord.InsufficientBarricades = model.InsufficientBarricades;
                    existingRecord.RemoveDebris = model.RemoveDebris;
                    existingRecord.NotDeep = model.NotDeep;
                    existingRecord.CurbHeight = model.CurbHeight;
                    existingRecord.SawCutEdges = model.SawCutEdges;
                    existingRecord.NoPermit = model.NoPermit;
                    existingRecord.OtherDoNotPour = model.OtherDoNotPour;
                    existingRecord.OtherGrantedToPour = model.OtherGrantedToPour;
                    existingRecord.Partial = model.Partial;
                    existingRecord.PartialDescription = model.PartialDescription;
                    existingRecord.MatchJointPattern = model.MatchJointPattern;
                    existingRecord.ToolDeepJoints = model.ToolDeepJoints;
                    existingRecord.PlaceJoints = model.PlaceJoints;
                    existingRecord.IsFormPartial = model.IsFormPartial;
                    //existingRecord.PermissionGranted = model.PermissionGranted;

                    context.SaveChanges();
                }
                result = true;
            }
            catch (Exception ex)
            {
                result = false; ;
            }
            return result;
        }

        public AffidavitFormInspection GetAffidavitFormInspection(long affidavitNo, int type)
        {
            AffidavitFormInspection result = new AffidavitFormInspection();
            try
            {
                result = context.AffidavitFormInspection.Where(x => x.AffidavitId.Equals(affidavitNo)).FirstOrDefault();
                //var history = context.AffidavitHistory.Where(x => x.AffidavitId.Equals(affidavitNo) && x.AffidavitStatusId.Equals(type)).FirstOrDefault();
                //if (history == null)
                //{
                //    result.Sidewalk = false;
                //    result.Driveway = false;
                //    result.Curb = false;                    
                //}

            }
            catch (Exception ex)
            {
                result = null;
            }
            return result;
        }

        public AffidavitFinalInspection GetAffidavitFinalInspection(long affidavitNo, int type)
        {
            AffidavitFinalInspection result = new AffidavitFinalInspection();
            try
            {
                result = context.AffidavitFinalInspection.Where(x => x.AffidavitID.Equals(affidavitNo)).FirstOrDefault();
            }
            catch (Exception ex)
            {
                result = null;
            }
            return result;
        }

        public bool AddAffidavitFinalInspection(AffidavitFinalInspection model, int type)
        {
            bool result = false;
            try
            {
                var existingRecord = context.AffidavitFinalInspection.Where(x => x.AffidavitID.Equals(model.AffidavitID)).FirstOrDefault();
                if (existingRecord == null)
                {
                    model.InspectionDate = DateTime.Now;
                    AffidavitHistory history = new AffidavitHistory();
                    var affidavit = context.Affidavit.Where(x => x.AffidavitID.Equals(model.AffidavitID)).FirstOrDefault();
                    var status = context.AffidavitStatus.Where(x => x.AffidavitStatusId == type).FirstOrDefault();
                    history.StatusValue = status.Status;
                    affidavit.Status = status.AffidavitStatusId;
                    history.AffidavitId = model.AffidavitID;
                    history.AffidavitStatusId = type;
                    history.CreatedDate = DateTime.Now;
                    if (type == 8)
                    {
                        history.Comments = model.OtherRepairsNotAcceptable;
                        history.InspectorId = model.FinalFailInspectorId;
                        model.FinalFailDate = DateTime.Now;
                    }
                    else if (type == 12)
                    {
                        history.Comments = model.OtherRepairsAreCompleteAndSatisfactory;
                        history.InspectorId = model.FinalPassInspectorId;
                        model.RepairsComplete = true;
                        model.CompletionDate = DateTime.Now;
                    }
                    context.AffidavitFinalInspection.Add(model);
                    context.AffidavitHistory.Add(history);
                    context.SaveChanges();
                }
                else
                {
                    var existingRecordHistory = context.AffidavitHistory.Where(x => x.AffidavitStatusId == type && x.AffidavitId == existingRecord.AffidavitID).FirstOrDefault();
                    if (existingRecordHistory != null)
                    {
                        var history = context.AffidavitHistory.Where(x => x.AffidavitId.Equals(model.AffidavitID) && x.AffidavitStatusId.Equals(type)).FirstOrDefault();
                        if (type == 8)
                        {
                            history.Comments = model.OtherRepairsNotAcceptable;
                            history.InspectorId = model.FinalFailInspectorId;
                            model.FinalFailDate = DateTime.Now;
                        }
                        else if (type == 12)
                        {
                            history.Comments = model.OtherRepairsAreCompleteAndSatisfactory;
                            history.InspectorId = model.FinalPassInspectorId;
                            existingRecord.RepairsComplete = true;
                            existingRecord.CompletionDate = DateTime.Now;
                        }
                        history.CreatedDate = DateTime.Now;
                    }
                    else
                    {
                        AffidavitHistory history = new AffidavitHistory();
                        var affidavit = context.Affidavit.Where(x => x.AffidavitID.Equals(model.AffidavitID)).FirstOrDefault();
                        var status = context.AffidavitStatus.Where(x => x.AffidavitStatusId == type).FirstOrDefault();
                        history.StatusValue = status.Status;
                        affidavit.Status = status.AffidavitStatusId;
                        history.AffidavitId = model.AffidavitID;
                        history.AffidavitStatusId = type;
                        history.CreatedDate = DateTime.Now;
                        if (type == 8)
                        {
                            history.Comments = model.OtherRepairsNotAcceptable;
                            history.InspectorId = model.FinalFailInspectorId;
                            model.FinalFailDate = DateTime.Now;
                        }
                        else if (type == 12)
                        {
                            history.Comments = model.OtherRepairsAreCompleteAndSatisfactory;
                            history.InspectorId = model.FinalPassInspectorId;
                            existingRecord.RepairsComplete = true;
                            existingRecord.CompletionDate = DateTime.Now;
                        }
                        //history.InspectorId = model.InspectorID;

                        context.AffidavitHistory.Add(history);
                    }
                    existingRecord.Sidewalk = model.Sidewalk;
                    existingRecord.Driveway = model.Driveway;
                    existingRecord.Curb = model.Curb;
                    existingRecord.ContractorRepaired = model.ContractorRepaired;
                    existingRecord.ContractorRepairedNotCitySpec = model.ContractorRepairedNotCitySpec;
                    existingRecord.OwnerRepaired = model.OwnerRepaired;
                    existingRecord.OwnerRepairedNotCitySpec = model.OwnerRepairedNotCitySpec;
                    existingRecord.RemoveFormsToGrade = model.RemoveFormsToGrade;
                    existingRecord.MoreBackfill = model.MoreBackfill;
                    existingRecord.IncompleteRepairs = model.IncompleteRepairs;
                    existingRecord.MoreGrinding = model.MoreGrinding;
                    existingRecord.RemoveMarkedAreas = model.RemoveMarkedAreas;
                    existingRecord.AsphaltWork = model.AsphaltWork;
                    existingRecord.Graffiti = model.Graffiti;
                    existingRecord.NoRightWayPermit = model.NoRightWayPermit;
                    existingRecord.OtherRepairsNotAcceptable = model.OtherRepairsNotAcceptable;
                    existingRecord.OtherRepairsAreCompleteAndSatisfactory = model.OtherRepairsAreCompleteAndSatisfactory;

                    context.SaveChanges();
                }
                result = true;
            }
            catch (Exception ex)
            {
                result = false; ;
            }
            return result;
        }

    }
}
