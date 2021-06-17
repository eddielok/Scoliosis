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
    public class PersonalInfoController : Controller
    {

        //private readonly MyContext _context;
        private readonly IRepository<PersonalInfoModel, string> _repository;

        public PersonalInfoController(IRepository<PersonalInfoModel, string> repository)
        {
            _repository = repository;
        }


        //[HttpGet("{name}/{scn}/{hkid}/{sortBy}/{remarks}/{orderby}/{kingOption}/{dateFrom}/{dateTo}")]
        //public ResultModel Get(string name, string scn, string hkid, string sortBy, string remarks, string orderby, string kingOption, string dateFrom, string dateTo)
        [HttpGet("{sortBy}/{orderby}/{searchString}")]
        public ResultModel Get(string sortBy, string orderby, string searchString)
        {

            var result = new ResultModel();


            string[] searchItems = searchString.Split('&');

            //handleSearch Page
            //var personalInfosData = _repository.Find(x => (x.Name.Contains("a") || x.HKID.Contains("Z")));

            var personalInfosData = _repository.Find(x => 1 == 1);
            var isAllList = false;

            foreach (string searchItem in searchItems)
            {
                if (searchItem == "")
                {
                    continue;
                }

                var item = searchItem.Split("=");

                if (item[0] == "Name")
                {
                    personalInfosData = personalInfosData.Where(x => x.Name.ToLower().Contains(item[1]));
                }

                if (item[0] == "scn")
                {
                    //202003014 May search 760
                    personalInfosData = personalInfosData.Where(x => x.SCN.Contains(item[1]));
                    //personalInfosData = personalInfosData.Where(x => CultureInfo.CurrentCulture.CompareInfo.IndexOf(x.SCN, item[1], CompareOptions.IgnoreCase) >= 0);
                }
                if (item[0] == "HKID")
                {
                    personalInfosData = personalInfosData.Where(x => x.HKID !=null && x.HKID.Contains(item[1]));
                }

                if (item[0] == "kingOption")
                {
                    if (item[1] == "I")
                    {
                        personalInfosData = personalInfosData.Where(x => x.isKingI == true);
                    }

                    if (item[1] == "II")
                    {
                        personalInfosData = personalInfosData.Where(x =>  x.isKingII == true);
                    }

                    if (item[1] == "III")
                    {
                        personalInfosData = personalInfosData.Where(x =>  x.isKingIII == true);
                    }

                    if (item[1] == "IV")
                    {
                        personalInfosData = personalInfosData.Where(x =>  x.isKingIV == true);
                    }

                    if (item[1] == "V")
                    {
                        personalInfosData = personalInfosData.Where(x =>  x.isKingV == true);
                    }

                    if (item[1] == "IV")
                    {
                        personalInfosData = personalInfosData.Where(x => x.isKingIV == true);
                    }

                    if (item[1] == "TL")
                    {
                        personalInfosData = personalInfosData.Where(x => x.isTL == true);
                    }

                    if (item[1] == "L")
                    {
                        personalInfosData = personalInfosData.Where(x =>  x.isL == true);
                    }

                    if (item[1] == "Triple")
                    {
                        personalInfosData = personalInfosData.Where(x => x.isTriple == true);
                    }
                }

                if (item[0] == "Remarks")
                {
                    //personalInfosData = personalInfosData.Where(x => x.SpcRemarks.Contains(item[1]));
                    personalInfosData = personalInfosData.Where(x => (x.SpcRemarks != null)  && CultureInfo.CurrentCulture.CompareInfo.IndexOf(x.SpcRemarks, item[1], CompareOptions.IgnoreCase) >= 0);
                }

                if (item[0] == "dateFrom")
                {
                    string[] dateFrom = item[1].ToString().Split("-");
                    DateTime dateDateFrom = new DateTime(int.Parse(dateFrom[0]), int.Parse(dateFrom[1]), int.Parse(dateFrom[2]));
                    personalInfosData = personalInfosData.Where(x => x.LastModify != null &&  x.LastModify >= dateDateFrom);
                }

                if (item[0] == "dateTo")
                {

                    string[] dateTo = item[1].ToString().Split("-");
                    DateTime dateDateTo = new DateTime(int.Parse(dateTo[0]), int.Parse(dateTo[1]), int.Parse(dateTo[2]));
                    personalInfosData = personalInfosData.Where(x => x.LastModify != null &&  x.LastModify <= dateDateTo);
                }

                if (item[0] == "isAllList")
                {
                    var isAllListReturn = item[1].ToString();

                    if (isAllListReturn == "" || isAllListReturn == "false")
                    {
                        isAllList = false;
                    }

                    if (isAllListReturn == "true")
                    {
                        isAllList = true;
                    }


                }

                if (item[0] == "range")
                {
                    if (isAllList)
                    {
                        var rangeReturn = item[1].ToString();

                        if (rangeReturn == "AD")
                        {
                            personalInfosData = personalInfosData.Where(x => ((x.Name.StartsWith("A")) || (x.Name.StartsWith("a") ||
                                                                                    x.Name.StartsWith("B")) || (x.Name.StartsWith("b") ||
                                                                                    x.Name.StartsWith("C")) || (x.Name.StartsWith("c") ||
                                                                                    x.Name.StartsWith("D")) || (x.Name.StartsWith("d")

                                                                                )));
                        }

                        if (rangeReturn == "EH")
                        {
                            personalInfosData = personalInfosData.Where(x => ((x.Name.StartsWith("E")) || (x.Name.StartsWith("e") ||
                                                                                    x.Name.StartsWith("F")) || (x.Name.StartsWith("f") ||
                                                                                    x.Name.StartsWith("G")) || (x.Name.StartsWith("g") ||
                                                                                     x.Name.StartsWith("H")) || (x.Name.StartsWith("h")
                                                                                )));
                        }

                        if (rangeReturn == "IL")
                        {
                            personalInfosData = personalInfosData.Where(x => ((x.Name.StartsWith("I")) || (x.Name.StartsWith("i") ||
                                                                                    x.Name.StartsWith("J")) || (x.Name.StartsWith("j") ||
                                                                                    x.Name.StartsWith("K")) || (x.Name.StartsWith("k") ||
                                                                                    x.Name.StartsWith("L")) || (x.Name.StartsWith("l")
                                                                                )));
                        }

                        if (rangeReturn == "MP")
                        {
                            personalInfosData = personalInfosData.Where(x => ((x.Name.StartsWith("M")) || (x.Name.StartsWith("m") ||
                                                                                     x.Name.StartsWith("N")) || (x.Name.StartsWith("n") ||
                                                                                    x.Name.StartsWith("O")) || (x.Name.StartsWith("o") ||
                                                                                    x.Name.StartsWith("P")) || (x.Name.StartsWith("p")
                                                                                )));
                        }

                        if (rangeReturn == "QT")
                        {
                            personalInfosData = personalInfosData.Where(x => ((x.Name.StartsWith("Q")) || (x.Name.StartsWith("q") ||
                                                                                    x.Name.StartsWith("R")) || (x.Name.StartsWith("r") ||
                                                                                    x.Name.StartsWith("S")) || (x.Name.StartsWith("s") ||
                                                                                     x.Name.StartsWith("T")) || (x.Name.StartsWith("t")
                                                                                )));
                        }

                        if (rangeReturn == "UZ")
                        {
                            personalInfosData = personalInfosData.Where(x => ((x.Name.StartsWith("U")) || (x.Name.StartsWith("u") ||
                                                                                    x.Name.StartsWith("V")) || (x.Name.StartsWith("V") ||
                                                                                    x.Name.StartsWith("W")) || (x.Name.StartsWith("W") ||
                                                                                    x.Name.StartsWith("X")) || (x.Name.StartsWith("X") ||
                                                                                    x.Name.StartsWith("Y")) || (x.Name.StartsWith("Y") ||
                                                                                    x.Name.StartsWith("Z")) || (x.Name.StartsWith("z")
                                                                                )));
                        }

                    }


                }

            }



            if (orderby == "OrderbyAsc" & sortBy == "SortByName")
            {
                result.Data = personalInfosData.OrderBy(x => x.Name);
            }

            if (orderby == "OrderbyAsc" & sortBy == "SortBySCN")
            {
                result.Data = personalInfosData.OrderBy(x => x.SCN);
            }

            if (orderby == "OrderbyAsc" & sortBy == "SortByHKID")
            {
                result.Data = personalInfosData.OrderBy(x => x.HKID);
            }

            if (orderby == "OrderbyDesc" & sortBy == "SortByName")
            {
                result.Data = personalInfosData.OrderByDescending(x => x.Name);
            }

            if (orderby == "OrderbyDesc" & sortBy == "SortBySCN")
            {
                result.Data = personalInfosData.OrderByDescending(x => x.SCN);
            }

            if (orderby == "OrderbyDesc" & sortBy == "SortByHKID")
            {
                result.Data = personalInfosData.OrderByDescending(x => x.HKID);
            }

            result.IsSuccess = true;

            return result;
        }


        [HttpDelete("{scn}")]
        public ResultModel Delete(string scn)
        {
            var result = new ResultModel();
            try
            {
                _repository.Delete(scn);
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = ex.Message;
            }

            return result;
        }



        [HttpGet("{scn}")]
        public ResultModel Get(string scn)
        {

            var result = new ResultModel();

            //result.Data = _repository.Find(x => string.IsNullOrEmpty(scn)
            //                  || Regex.IsMatch(x.SCN, scn, RegexOptions.IgnoreCase));


            //Update
            var personalInfosData = _repository.Find(x => 1 == 1).AsQueryable<PersonalInfoModel>().AsNoTracking().Where(y => y.SCN == scn);

            //_repository.Find(x => 1 == 1).AsQueryable<VisitsModel>().AsNoTracking().Where(y => y.SCN == scn);


            //personalInfosData = personalInfosData.Where(x => x.SCN.Contains(scn));
            //result.Data = personalInfosData.OrderByDescending(x => x.SCN);

            result.Data = personalInfosData;
            result.IsSuccess = true;

            return result;
        }



        // POST: api/User
        [HttpPost]
        public ResultModel Post([FromBody]PersonalInfoModel personalInfo)
        {
            var result = new ResultModel();

            try
            {
                personalInfo.LastModify = DateTime.Now;
                ValidationPersonalInfo(personalInfo);
                _repository.Create(personalInfo);

                result.Data = personalInfo.SCN;
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.IsSuccess = false;

            }
            return result;
        }

        [HttpPut("{SCN}")]
        public ResultModel Put(string SCN, [FromBody]PersonalInfoModel personalInfo)
        {

            var result = new ResultModel();

            try
            {

                personalInfo.SCN = SCN;
                personalInfo.LastModify  = DateTime.Now;
                ValidationPersonalInfo(personalInfo);

                _repository.Update(personalInfo);
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.IsSuccess = false;

            }
            return result;
        }


        private void ValidationPersonalInfo(PersonalInfoModel personalInfoModel)
        {
            if (personalInfoModel.SCN == null || personalInfoModel.SCN.Length > 8)
            {
                throw new Exception("Unable to Save! Invalid SCN. The SCN should be XX-XXXXX");
            }

            if (personalInfoModel.Name == null || personalInfoModel.SCN.Length > 255)
            {
                throw new Exception("Unable to Save! Invalid Name. The Name should be not greater than 255");
            }

            if (personalInfoModel.HKID == null || personalInfoModel.HKID.Length > 11)
            {
                throw new Exception("Unable to Save! Invalid HKID. The HKID should be not greater than 255");
            }

            if (personalInfoModel.Sex < 0 || personalInfoModel.Sex > 2)
            {
                throw new Exception("Unable to Save! Please select the Sex. ");
            }

            if (personalInfoModel.FamHis != null && personalInfoModel.FamHis.Length > 255)
            {
                throw new Exception("Unable to Save! The FamHis greater than 255 ");
            }

            if (personalInfoModel.AttnPhys != null && personalInfoModel.AttnPhys.Length > 255)
            {
                throw new Exception("Unable to Save! The AttnPhys greater than 255 ");
            }

            if (personalInfoModel.HisOthers != null && personalInfoModel.HisOthers.Length > 255)
            {
                throw new Exception("Unable to Save! The HisOthers greater than 255 ");
            }

            if (personalInfoModel.DiagnosisMisc != null && personalInfoModel.DiagnosisMisc.Length > 255)
            {
                throw new Exception("Unable to Save! The DiagnosisMisc greater than 255 ");
            }

            if (personalInfoModel.ADCA != null && personalInfoModel.ADCA.Length > 1024)
            {
                throw new Exception("Unable to Save! The ADCA greater than 1024 ");
            }

            if (personalInfoModel.BraceOthers != null && personalInfoModel.BraceOthers.Length > 255)
            {
                throw new Exception("Unable to Save! The ADCA greater than 255 ");
            }

            if (personalInfoModel.Surgeons != null && personalInfoModel.Surgeons.Length > 255)
            {
                throw new Exception("Unable to Save! The Surgeons greater than 255 ");
            }

            if (personalInfoModel.otherSurgery != null && personalInfoModel.otherSurgery.Length > 1024)
            {
                throw new Exception("Unable to Save! The otherSurgery greater than 1024 ");
            }

            if (personalInfoModel.LOF != null && personalInfoModel.LOF.Length > 255)
            {
                throw new Exception("Unable to Save! The LOF greater than 255 ");
            }

            if (personalInfoModel.LOFfrom != null && personalInfoModel.LOFfrom.Length > 255)
            {
                throw new Exception("Unable to Save! The LOFfrom greater than 255 ");
            }

            if (personalInfoModel.LOFto != null && personalInfoModel.LOFto.Length > 255)
            {
                throw new Exception("Unable to Save! The LOFto greater than 255 ");
            }

            if (personalInfoModel.otherImplant != null && personalInfoModel.otherImplant.Length > 1024)
            {
                throw new Exception("Unable to Save! The otherImplant greater than 1024 ");
            }

            if (personalInfoModel.otherImplant != null && personalInfoModel.otherImplant.Length > 1024)
            {
                throw new Exception("Unable to Save! The otherImplant greater than 1024 ");
            }

            if (personalInfoModel.Comments != null && personalInfoModel.Comments.Length > 4000)
            {
                throw new Exception("Unable to Save! The otherImplant greater than 4000 ");
            }

            if (personalInfoModel.SpcRemarks != null && personalInfoModel.SpcRemarks.Length > 4000)
            {
                throw new Exception("Unable to Save! The SpcRemarks greater than 4000 ");
            }
        }

    }
}