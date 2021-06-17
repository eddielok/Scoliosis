using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Scoliosis.Models;
using System.Text.RegularExpressions;
using Scoliosis.Repositories;
using System.Globalization;

namespace Scoliosis.Controllers
{
    [Route("api/[controller]s")]
    public class VisitController : Controller
    {
        //private readonly MyContext _context;
        private readonly IRepositoryVisit<VisitsModel, string> _repository;

        public VisitController(IRepositoryVisit<VisitsModel, string> repository)
        {
            _repository = repository;
        }

        [HttpGet("{scn}/{dob}")]
        public ResultModel Get(string scn, string dob)
        {
            var result = new ResultModel();

            DateTime? visitDob = DateTime.Today;

            if (dob != "")
            {
                visitDob = DateTime.ParseExact(dob, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            }

            if (dob == "1900-01-01")
            {
                visitDob = GetLastVisitDob(scn);
            }

            if (visitDob == null)
            {
                result.IsSuccess = false;
                result.Message = "Visit Dob is empty";
                return result;
            }

            var visitsData = _repository.Find(x => x.SCN == scn && x.DOC == visitDob);

            result.IsSuccess = true;
            result.Data = visitsData;

            return result;

        }

        [HttpGet("{scn}/{isVisits}/{isGetAsync}")]
        public ResultModel Get(string scn, string isVisits, string isGetAsync)
        {
            var result = new ResultModel();
            var visitsDatas = _repository.Find(x => 1 == 1).AsQueryable<VisitsModel>().AsNoTracking().Where(y => y.SCN == scn).OrderBy(z => z.DOC);
            //var visisLists = new List<string>();

            result.IsSuccess = true;
            //result.Data = visisLists;
            result.Data = visitsDatas;

            return result;
        }

        [HttpGet("{scn}")]
        public ResultModel Get(string scn)
        {
            var result = new ResultModel();

            var visitsDatas = _repository.Find(x => 1 == 1).AsQueryable<VisitsModel>().AsNoTracking().Where(y => y.SCN == scn).OrderByDescending(z => z.DOC);
            var visisLists = new List<string>();


            //For hyperlink
            foreach (var visitsData in visitsDatas.ToList())
            {
                if (visitsData.DOC != null)
                {
                    visisLists.Add(visitsData.Virtual.Substring(1, 1) + " " + visitsData.DOC.Value.ToString("yyyy-MM-dd"));
                }
            }

            result.IsSuccess = true;
            result.Data = visisLists;

            return result;
        }


        private DateTime? GetLastVisitDob(string scn)
        {
            var visitsDatas = _repository.Find(x => 1 == 1).AsQueryable<VisitsModel>().AsNoTracking().Where(y => y.SCN == scn);
            return visitsDatas.OrderByDescending(x => x.DOC).FirstOrDefault().DOC;
        }


        //[HttpGet("{scn}")]
        //public ResultModel GetLatestVisit(string scn) {

          
        //    var resultModel = new ResultModel();

        //    try
        //    {
        //        var visitModel = _repository.Find(x => 1 == 1).AsQueryable<VisitsModel>().AsNoTracking().Where(y => y.SCN == scn).OrderByDescending(z => z.DOC).FirstOrDefault();

        //        resultModel.IsSuccess = true;
        //        resultModel.Data = visitModel;

        //    }
        //    catch (Exception ex) {
        //        resultModel.IsSuccess = false;
        //        resultModel.Message = ex.Message;
        //    }

        //    return resultModel;
            
        //}


        [HttpPost]
        public ResultModel POST([FromBody]VisitsModel visitsModel)
        {
            var result = new ResultModel();

            try
            {
                ValidaitonVisit(visitsModel);

                visitsModel.LastModify = DateTime.Now;

                _repository.Create(visitsModel);
                result.Data = visitsModel.SCN;

                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = ex.Message;
            }
            return result;
        }


        [HttpPut("{SCN}")]
        public ResultModel Put(string SCN, [FromBody]VisitsModel visitsModel)
        {

            var result = new ResultModel();
            try
            {
                ValidaitonVisit(visitsModel);

                visitsModel.SCN = SCN;
                visitsModel.LastModify = DateTime.Now;

                _repository.Update(visitsModel);
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = ex.Message;
            }


            return result;
        }

        [HttpDelete("{scn}/{doc}")]
        public ResultModel Delete(string scn, string doc)
        {
            var result = new ResultModel();
            try
            {
                _repository.Delete(scn, doc);
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = ex.Message;
            }

            return result;
        }



        private void ValidaitonVisit(VisitsModel visitsModel)
        {

            if (visitsModel.SCN == null || visitsModel.SCN.Length > 8)
            {
                throw new Exception("Unable to Save! Invalid SCN. The SCN should be XX-XXXXX");
            }

            if (visitsModel.DOC == null || visitsModel.DOC.Value.ToString().Trim() == "")
            {
                throw new Exception("Unable to Save!  Date of Clinc should not be empty");
            }


            if (visitsModel.Virtual.Trim().Length == 0 || visitsModel.Virtual.Trim() == "")
            {
                throw new Exception("Unable to Save! Virtual should not be empty");
            }
            //if (visitsModel.MaturYear <= 1900 && visitsModel.MaturYear >= 2099) {
            //    throw new Exception("Unable to Save!  MaturYear should between 1900 and 2099 ");
            //}

            //if (visitsModel.MaturMonth >= 1 && visitsModel.MaturMonth <= 12)
            //{
            //    throw new Exception("Unable to Save!  MaturMonth should be between 1 and 12");
            //}

            if (visitsModel.Jointhyper != null && visitsModel.Jointhyper != "" && visitsModel.Jointhyper.Length > 255)
            {
                throw new Exception("Jointhyper should be not longer than 255");
            }

            if (visitsModel.R1Dir != null && visitsModel.R1Dir != "" && visitsModel.R1Dir.Length > 12)
            {
                throw new Exception("R1Dir should be not longer than 12");
            }

            if (visitsModel.R2Dir != null && visitsModel.R2Dir != "" && visitsModel.R2Dir.Length > 12)
            {
                throw new Exception("R2Dir should be not longer than 12");
            }

            if (visitsModel.R3Dir != null && visitsModel.R3Dir != "" && visitsModel.R3Dir.Length > 12)
            {
                throw new Exception("R3Dir should be not longer than 12");
            }

            if (visitsModel.R4Dir != null && visitsModel.R4Dir != "" && visitsModel.R4Dir.Length > 12)
            {
                throw new Exception("R4Dir should be not longer than 12");
            }

            if (visitsModel.ShoulderDir != null && visitsModel.ShoulderDir != "" && visitsModel.ShoulderDir.Length > 50)
            {
                throw new Exception("ShoulderDir should be not longer than 50");
            }

            if (visitsModel.BreastTanner != null && visitsModel.BreastTanner != "" && visitsModel.BreastTanner.Length > 16)
            {
                throw new Exception("BreastTanner should be not longer than 16");
            }

            if (visitsModel.hair != null && visitsModel.hair != "" && visitsModel.hair.Length > 50)
            {
                throw new Exception("Hair should be not longer than 50");
            }

            if (visitsModel.tricart != null && visitsModel.tricart != "" && visitsModel.tricart.Length > 50)
            {
                throw new Exception("tricart should be not longer than 50");
            }

            if (visitsModel.trochanter != null && visitsModel.trochanter != "" && visitsModel.trochanter.Length > 50)
            {
                throw new Exception("trochanter should be not longer than 50");
            }

            if (visitsModel.FemoralHead != null && visitsModel.FemoralHead != "" && visitsModel.FemoralHead.Length > 50)
            {
                throw new Exception("FemoralHead should be not longer than 50");
            }

            if (visitsModel.CurveLevel1From != null && visitsModel.CurveLevel1From != "" && visitsModel.CurveLevel1From.Length > 50)
            {
                throw new Exception("CurveLevel1From should be not longer than 50");
            }

            if (visitsModel.CurveLevel1To != null && visitsModel.CurveLevel1To != "" && visitsModel.CurveLevel1To.Length > 50)
            {
                throw new Exception("CurveLevel1To should be not longer than 50");
            }

            if (visitsModel.CurveLevel2From != null && visitsModel.CurveLevel2From != "" && visitsModel.CurveLevel2From.Length > 50)
            {
                throw new Exception("CurveLevel2From should be not longer than 50");
            }

            if (visitsModel.CurveLevel2To != null && visitsModel.CurveLevel2To != "" && visitsModel.CurveLevel2To.Length > 50)
            {
                throw new Exception("CurveLevel2To should be not longer than 50");
            }

            if (visitsModel.CurveLevel3From != null && visitsModel.CurveLevel3From != "" && visitsModel.CurveLevel3From.Length > 50)
            {
                throw new Exception("CurveLevel3From should be not longer than 50");
            }

            if (visitsModel.CurveLevel3To != null && visitsModel.CurveLevel3To != "" && visitsModel.CurveLevel3To.Length > 50)
            {
                throw new Exception("CurveLevel3To should be not longer than 50");
            }

            if (visitsModel.CurveLevel4From != null && visitsModel.CurveLevel4From != "" && visitsModel.CurveLevel4From.Length > 50)
            {
                throw new Exception("CurveLevel4From should be not longer than 50");
            }

            if (visitsModel.CurveLevel4To != null && visitsModel.CurveLevel4To != "" && visitsModel.CurveLevel4To.Length > 50)
            {
                throw new Exception("CurveLevel4To should be not longer than 50");
            }

            if (visitsModel.CurveApex1 != null && visitsModel.CurveApex1 != "" && visitsModel.CurveApex1.Length > 255)
            {
                throw new Exception("CurveApex1 should be not longer than 255");
            }

            if (visitsModel.CurveApex2 != null && visitsModel.CurveApex2 != "" && visitsModel.CurveApex2.Length > 255)
            {
                throw new Exception("CurveApex2 should be not longer than 255");
            }

            if (visitsModel.CurveApex3 != null && visitsModel.CurveApex3 != "" && visitsModel.CurveApex3.Length > 255)
            {
                throw new Exception("CurveApex3 should be not longer than 255");
            }

            if (visitsModel.CurveApex4 != null && visitsModel.CurveApex4 != "" && visitsModel.CurveApex4.Length > 255)
            {
                throw new Exception("CurveApex4 should be not longer than 255");
            }

            if (visitsModel.CurveDir1 != null && visitsModel.CurveDir1 != "" && visitsModel.CurveDir1.Length > 255)
            {
                throw new Exception("CurveDir1 should be not longer than 255");
            }

            if (visitsModel.CurveDir2 != null && visitsModel.CurveDir2 != "" && visitsModel.CurveDir2.Length > 255)
            {
                throw new Exception("CurveDir2 should be not longer than 255");
            }

            if (visitsModel.CurveDir3 != null && visitsModel.CurveDir3 != "" && visitsModel.CurveDir3.Length > 255)
            {
                throw new Exception("CurveDir3 should be not longer than 255");
            }

            if (visitsModel.CurveDir4 != null && visitsModel.CurveDir4 != "" && visitsModel.CurveDir4.Length > 255)
            {
                throw new Exception("CurveDir4 should be not longer than 255");
            }

            if (visitsModel.ApicalDir1 != null && visitsModel.ApicalDir1 != "" && visitsModel.ApicalDir1.Length > 255)
            {
                throw new Exception("ApicalDir1 should be not longer than 255");
            }

            if (visitsModel.ApicalDir2 != null && visitsModel.ApicalDir2 != "" && visitsModel.ApicalDir2.Length > 255)
            {
                throw new Exception("ApicalDir2 should be not longer than 255");
            }

            if (visitsModel.ApicalDir3 != null && visitsModel.ApicalDir3 != "" && visitsModel.ApicalDir3.Length > 255)
            {
                throw new Exception("ApicalDir3 should be not longer than 255");
            }

            if (visitsModel.ApicalDir4 != null && visitsModel.ApicalDir4 != "" && visitsModel.ApicalDir4.Length > 255)
            {
                throw new Exception("ApicalDir4 should be not longer than 255");
            }

            if (visitsModel.CurveLevel1FromS != null && visitsModel.CurveLevel1FromS != "" && visitsModel.CurveLevel1FromS.Length > 50)
            {
                throw new Exception("CurveLevel1FromS should be not longer than 50");
            }

            if (visitsModel.CurveLevel1ToS != null && visitsModel.CurveLevel1ToS != "" && visitsModel.CurveLevel1ToS.Length > 50)
            {
                throw new Exception("CurveLevel1ToS should be not longer than 50");
            }

            if (visitsModel.CurveLevel2FromS != null && visitsModel.CurveLevel2FromS != "" && visitsModel.CurveLevel2FromS.Length > 50)
            {
                throw new Exception("CurveLevel2FromS should be not longer than 50");
            }

            if (visitsModel.CurveLevel2ToS != null && visitsModel.CurveLevel2ToS != "" && visitsModel.CurveLevel2ToS.Length > 50)
            {
                throw new Exception("CurveLevel2ToS should be not longer than 50");
            }

            if (visitsModel.CurveLevel3FromS != null && visitsModel.CurveLevel3FromS != "" && visitsModel.CurveLevel3FromS.Length > 50)
            {
                throw new Exception("CurveLevel3FromS should be not longer than 50");
            }

            if (visitsModel.CurveLevel3ToS != null && visitsModel.CurveLevel3ToS != "" && visitsModel.CurveLevel3ToS.Length > 50)
            {
                throw new Exception("CurveLevel3ToS should be not longer than 50");
            }

            if (visitsModel.CurveLevel4FromS != null && visitsModel.CurveLevel4ToS != "" && visitsModel.CurveLevel4FromS.Length > 50)
            {
                throw new Exception("CurveLevel4FromS should be not longer than 50");
            }

            if (visitsModel.CurveLevel4ToS != null && visitsModel.CurveLevel4ToS != "" && visitsModel.CurveLevel4ToS.Length > 50)
            {
                throw new Exception("CurveLevel4ToS should be not longer than 50");
            }

            if (visitsModel.CurveDir1S != null && visitsModel.CurveDir1S != "" && visitsModel.CurveDir1S.Length > 255)
            {
                throw new Exception("CurveDir1S should be not longer than 255");
            }

            if (visitsModel.CurveDir2S != null && visitsModel.CurveDir2S != "" && visitsModel.CurveDir2S.Length > 255)
            {
                throw new Exception("CurveDir2S should be not longer than 255");
            }

            if (visitsModel.CurveDir3S != null && visitsModel.CurveDir3S != "" && visitsModel.CurveDir3S.Length > 255)
            {
                throw new Exception("CurveDir3S should be not longer than 255");
            }

            if (visitsModel.CurveDir4S != null && visitsModel.CurveDir4S != "" && visitsModel.CurveDir4S.Length > 255)
            {
                throw new Exception("CurveDir4S should be not longer than 255");
            }

            if (visitsModel.CurveApex1S != null && visitsModel.CurveApex1S != "" && visitsModel.CurveApex1S.Length > 255)
            {
                throw new Exception("CurveApex1S should be not longer than 255");
            }

            if (visitsModel.CurveApex2S != null && visitsModel.CurveApex2S != "" && visitsModel.CurveApex2S.Length > 255)
            {
                throw new Exception("CurveApex2S should be not longer than 255");
            }

            if (visitsModel.CurveApex3S != null && visitsModel.CurveApex3S != "" && visitsModel.CurveApex3S.Length > 255)
            {
                throw new Exception("CurveApex3S should be not longer than 255");
            }

            if (visitsModel.CurveApex4S != null && visitsModel.CurveApex4S != "" && visitsModel.CurveApex4S.Length > 255)
            {
                throw new Exception("CurveApex4S should be not longer than 255");
            }

            if (visitsModel.Thoracictype != null && visitsModel.Thoracictype.Value.ToString().Length > 1)
            {
                throw new Exception("Thoracictype should be not longer than 1");
            }

            if (visitsModel.Lumbartype != null && visitsModel.Lumbartype.Value.ToString().Length > 1)
            {
                throw new Exception("Lumbartype should be not longer than 1");
            }

            if (visitsModel.ApicalRotation1 != null && visitsModel.ApicalRotation1 != "" && visitsModel.ApicalRotation1.Length > 255)
            {
                throw new Exception("ApicalRotation1 should be not longer than 255");
            }

            if (visitsModel.ApicalRotation2 != null && visitsModel.ApicalRotation2 != "" && visitsModel.ApicalRotation2.Length > 255)
            {
                throw new Exception("ApicalRotation2 should be not longer than 255");
            }

            if (visitsModel.ApicalRotation3 != null && visitsModel.ApicalRotation3 != "" && visitsModel.ApicalRotation3.Length > 255)
            {
                throw new Exception("ApicalRotation3 should be not longer than 255");
            }

            if (visitsModel.ApicalRotation4 != null && visitsModel.ApicalRotation4 != "" && visitsModel.ApicalRotation4.Length > 255)
            {
                throw new Exception("ApicalRotation4 should be not longer than 255");
            }

            if (visitsModel.RSign != null && visitsModel.RSign != "" && visitsModel.RSign.Length > 255)
            {
                throw new Exception("RSign should be not longer than 255");
            }

            if (visitsModel.EpFusion != null && visitsModel.EpFusion != "" && visitsModel.EpFusion.Length > 255)
            {
                throw new Exception("EpFusion should be not longer than 255");
            }

            if (visitsModel.PlanObs != null && visitsModel.PlanObs != "" && visitsModel.PlanObs.Length > 255)
            {
                throw new Exception("PlanObs should be not longer than 255");
            }

            if (visitsModel.PlanBrace != null && visitsModel.PlanBrace != "" && visitsModel.PlanBrace.Length > 255)
            {
                throw new Exception("PlanBrace should be not longer than 255");
            }

            if (visitsModel.PlanXray != null && visitsModel.PlanXray != "" && visitsModel.PlanXray.Length > 3)
            {
                throw new Exception("PlanXray should be not longer than 3");
            }

            if (visitsModel.PlanSurgery != null && visitsModel.PlanSurgery != "" && visitsModel.PlanSurgery.Length > 3)
            {
                throw new Exception("PlanSurgery should be not longer than 3");
            }

            if (visitsModel.DrName != null && visitsModel.DrName != "" && visitsModel.DrName.Length > 100)
            {
                throw new Exception("DrName should be not longer than 100");
            }

            if (visitsModel.SpcRemarks != null && visitsModel.SpcRemarks != "" && visitsModel.SpcRemarks.Length > 4000)
            {
                throw new Exception("SpcRemarks should be not longer than 100");
            }

        }




    }
}