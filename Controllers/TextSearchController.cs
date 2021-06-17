using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scoliosis.Models;
using Scoliosis.Repositories;

namespace Scoliosis.Controllers
{
    [Route("api/[controller]s")]
    public class TextSearchController : Controller
    {
        private readonly IRepository<PersonalInfoModel, string> _repositoryPersonalinfoModel;
        private readonly IRepositoryVisit<VisitsModel, string> _repositoryVisitsModel;

        //public TextSearchController(IRepository<PersonalInfoModel, string> repositoryPersonalinfoModel)
        //{
        //    _repositoryPersonalinfoModel = repositoryPersonalinfoModel;
        //}

        //public TextSearchController(IRepositoryVisit<VisitsModel, string> repositoryVisitsModel)
        //{
        //    _repositoryVisitsModel = repositoryVisitsModel;

        //}

        private readonly MyContext _context;

        public TextSearchController(MyContext context)
        {
            _context = context;
        }


        [HttpGet("{inputText}/{isInitalAss}/{isPatientInfo}/{isRemarkBox}/{isAllOther}/")]
        public ResultModel Get(string inputText, bool isInitalAss, bool isPatientInfo, bool isRemarkBox, bool isAllOther)
        {
            var resultModel = new ResultModel();

            

            //var visitResult = _context.Visits.Where(x => x.SpcRemarks.Contains(inputText));
            //var visitSCNs = visitResult.Select(x => x.SCN).OrderBy(x => x).ToArray();

            //var perosonalResult = _context.PersonalInfo.Where(x => x.Comments.Contains(inputText)) ;
            //var perosonalScns = perosonalResult.Select(x => x.SCN).OrderBy(x => x).ToArray();

            string[] visitSCNs;
            string[] perosonalScns;
            string[] initAssessSCNs;
            string[] RemarkSCNs;

            var perosonalFinalResult = _context.PersonalInfo.Where(x => 1 == 1);

            if (isAllOther)
            {
                visitSCNs = GetVisitSCN(inputText);
                perosonalScns = GetPersonalSCN(inputText);
                initAssessSCNs = GetInitAssessSCN(inputText);
                RemarkSCNs = GetRemarkMark(inputText);

                perosonalFinalResult = _context.PersonalInfo.Where(x => visitSCNs.Any(visitSCN => x.SCN.Contains(visitSCN))
                                                             || perosonalScns.Any(perosonalScn => x.SCN.Contains(perosonalScn))
                                                             || initAssessSCNs.Any(initAssessSCN => x.SCN.Contains(initAssessSCN)));
            }

            if (!isAllOther)
            {
                if (isPatientInfo)
                {
                    perosonalScns = GetPersonalSCN(inputText);
                    perosonalFinalResult = perosonalFinalResult.Where(x => perosonalScns.Any(perosonalScn => x.SCN.Contains(perosonalScn)));

                }
                if (isInitalAss)
                {
                    initAssessSCNs = GetInitAssessSCN(inputText);
                    perosonalFinalResult = perosonalFinalResult.Where(x => initAssessSCNs.Any(initAssessSCN => x.SCN.Contains(initAssessSCN)));
                }

                if (isRemarkBox)
                {
                    RemarkSCNs = GetRemarkMark(inputText);
                    perosonalFinalResult = perosonalFinalResult.Where(x => RemarkSCNs.Any(RemarkSCN => x.SCN.Contains(RemarkSCN)));
                }

            }

            resultModel.Data = perosonalFinalResult.ToList();

            resultModel.Message = "Success";

            return resultModel;
        }

        private string[] GetRemarkMark(string inputText)
        {

            var visitResult = _context.Visits.Where(x => x.SpcRemarks.Contains(inputText));
            var perosonalResult = _context.PersonalInfo.Where(x => x.SpcRemarks.Contains(inputText));
            var initAssessResult = _context.InitAssess.Where(x => x.Remarks.Contains(inputText));

            var visitSCNs = visitResult.Select(x => x.SCN).OrderBy(x => x).ToArray();
            var perosonalScns = perosonalResult.Select(x => x.SCN).OrderBy(x => x).ToArray();
            var initAssessScns = initAssessResult.Select(x => x.SCN).OrderBy(x => x).ToArray();

            var remarkScns = _context.PersonalInfo.Where(x => visitSCNs.Any(visitSCN => x.SCN.Contains(visitSCN))
                                                               || perosonalScns.Any(perosonalScn => x.SCN.Contains(perosonalScn))
                                                               || initAssessScns.Any(initAssessSCN => x.SCN.Contains(initAssessSCN)))
                                                            .Select(x => x.SCN).OrderBy(x => x).ToArray();

            return remarkScns;

        }


        private string[] GetVisitSCN(string inputText)
        {
            var visitResult = _context.Visits.Where(x => x.SpcRemarks.Contains(inputText));
            var visitSCNs = visitResult.Select(x => x.SCN).OrderBy(x => x).ToArray();

            return visitSCNs;

        }
        private string[] GetPersonalSCN(string inputText)
        {


            var perosonalResult = _context.PersonalInfo.Where(x => x.Comments.Contains(inputText) ||
                                                                    x.FamHis.Contains(inputText) ||
                                                                    x.AttnPhys.Contains(inputText) ||
                                                                    x.DiagnosisMisc.Contains(inputText) ||
                                                                    x.ADCA.Contains(inputText) ||
                                                                    x.BraceOthers.Contains(inputText) ||
                                                                    x.Surgeons.Contains(inputText) ||
                                                                    x.otherSurgery.Contains(inputText) ||
                                                                    x.otherImplant.Contains(inputText) ||
                                                                    x.OtherInvest.Contains(inputText) ||
                                                                    x.SpcRemarks.Contains(inputText)
                                                                    );
            var perosonalScns = perosonalResult.Select(x => x.SCN).OrderBy(x => x).ToArray();

            return perosonalScns;

        }


        private string[] GetInitAssessSCN(string inputText)
        {


            var initAssessResult = _context.InitAssess.Where(x => x.Remarks.Contains(inputText) ||
                                                                    x.ReferralOther.Contains(inputText) ||
                                                                    x.ConcernOther.Contains(inputText) ||
                                                                    x.SymBack.Contains(inputText) ||
                                                                    x.SymLimb.Contains(inputText) ||
                                                                    x.SymCon.Contains(inputText) ||
                                                                    x.SymOther.Contains(inputText) ||
                                                                    x.PastSpinal.Contains(inputText) ||
                                                                    x.PastOther.Contains(inputText) ||
                                                                    x.GenOther.Contains(inputText) ||
                                                                    x.BackInspectOther.Contains(inputText)
                                                                    );

            var initAssessScns = initAssessResult.Select(x => x.SCN).OrderBy(x => x).ToArray();

            return initAssessScns;

        }

        //[HttpGet("{sortBy}/{orderby}/{searchString}")]
        //public ResultModel Get(string sortBy, string orderby, string inputText)
        //{
        //    var resultModel = new ResultModel();

        //    var visitsResult = _repositoryVisitsModel.Find(x => 1 == 1);
        //    var perosonalResult = _repositoryPersonalinfoModel.Find(x => 1 == 1);

        //    visitsResult = visitsResult.Where(x => x.SpcRemarks.Contains("inputText"));

        //    var visitSCNs = visitsResult.Select(x => x.SCN).OrderBy(x => x).ToArray();

        //    perosonalResult.Where(x => visitSCNs.Any(visitSCN => x.SCN.Contains(visitSCN)));

        //    var outputResult = perosonalResult.ToList();

        //    //perosonalResult = perosonalResult.Where (y => s

        //    resultModel.IsSuccess = true;
        //    resultModel.Data = outputResult;

        //    return resultModel;


        //}


    }
}