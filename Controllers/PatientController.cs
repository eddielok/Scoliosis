using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scoliosis.Repositories;
using Scoliosis.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Globalization;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace Scoliosis.Controllers
{
    public class PatientController : Controller
    {

        // [Authorize(Policy = "readonlypolicy")]
        //private readonly MyContext _context;
        //private readonly IRepository<PersonalInfoModel, string> _repository;

        // GET: Patient
        public ActionResult Index()
        {
            return View();
        }


        //var email(userName) = User.FindFirstValue(ClaimTypes.Name);
        //var userId(GUID) = User.FindFirst(ClaimTypes.NameIdentifier).Value;

        //[Authorize(Policy = "readonlypolicy")]
        public ActionResult RecordSummary()
        {
            var infoRecordSummary = new InfoRecordSummary();

            try
            {

                infoRecordSummary.TodayDate = DateTime.Now.ToString("dd/MM/yyyy");
                infoRecordSummary.PatientRecords = "21647";
                infoRecordSummary.VisitsRecords = "101049";
                infoRecordSummary.OperativeDataRecords = "820";
                infoRecordSummary.XRayImages = "150841";
                infoRecordSummary.ClinicalPhotos = "7248";
                infoRecordSummary.ClinicalVideos = "3";

                return View(infoRecordSummary);
            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to Get Record Summary";

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "RecordSummary", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);
            }
        }

        public ActionResult VisitList(string scn)
        {
            try
            {
                if (!IsLogin())
                {
                    return RedirectToReLoginPage();
                }


                var infoBarViewModel = GetInfoBarViewModels(scn);
                var infoVisitModels = GetAllinfoVisitModels(scn);
                var photo = GetPhotoAndXRay(scn);
                var tupleModel = new Tuple<List<InfoVisitModel>, InfoBarViewModel>(infoVisitModels, infoBarViewModel);

                // if (photo.VisitList.Count > 0)
                if (tupleModel.Item1.Count > 0 && photo.VisitList.Count > 0)
                {
                    tupleModel.Item1[0].VisitList = photo.VisitList;
                    tupleModel.Item1[0].PhotoModifyList = photo.PhotoModifyList;
                    tupleModel.Item1[0].VisitListName = photo.VisitListName;

                    //20200819 Add Doctor Full Name
                    tupleModel.Item1[0].DrFullName = GetDoctorFullName(tupleModel.Item1[0].DrName);
                }

                if (infoVisitModels.Count == 0)
                {
                    var directAction = "./VisitPage";
                    return RedirectToAction(directAction, new { scn = scn });
                }

                return View(tupleModel);
            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to Visit List <br/> Reason: " + ex.Message;

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Visit List", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);
            }
        }


        private readonly IHostingEnvironment _hostingEnvironment;
        public PatientController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public ActionResult Visit(string scn, string dob)
        {
            if (!IsLogin())
            {
                return RedirectToReLoginPage();
            }

            try
            {
                var infoBarViewModel = GetInfoBarViewModels(scn);
                var infoVisitModel = GetinfoVisitModel(scn, ConvertUrlDateForm(dob)).Result;
                var tupleModel = new Tuple<InfoVisitModel, InfoBarViewModel>(infoVisitModel, infoBarViewModel);
                var isCreatePage = HttpContext.Session.GetString("_isCreatePage");
                var photo = GetPhotoAndXRay(scn, dob);

                tupleModel.Item1.PhotoList = photo.PhotoList;
                tupleModel.Item1.XRayList = photo.XRayList;
                tupleModel.Item1.XRayPath = photo.XRayPath;
                tupleModel.Item1.ExportList = photo.ExportList;
                tupleModel.Item1.ExportXRayList = photo.ExportXRayList;
                tupleModel.Item1.VisitList = photo.VisitList;
                //By Eddie 20200324
                tupleModel.Item1.PhotoModifyList = photo.PhotoModifyList;
                tupleModel.Item1.XRayModifyList = photo.XRayModifyList;
                if (isCreatePage != "true")
                {
                    ResetSubmitSession();
                }
                else
                {
                    HttpContext.Session.SetString("_isCreatePage", "false");
                }


                return View(tupleModel);
            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to load visit. Message: " + ex.Message;

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Visit", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);
            }
        }

        private List<TemplateRemarksContentViewModel> GetTemplateRemarksContents()
        {

            var templateRemarksContents = new List<TemplateRemarksContentViewModel>();

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/TemplateRemarksContents/";
            var client = new HttpClient();

            HttpResponseMessage response = client.GetAsync(baseAddress + link).GetAwaiter().GetResult();
            response.EnsureSuccessStatusCode();
            var stringResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
            templateRemarksContents = JsonConvert.DeserializeObject<List<TemplateRemarksContentViewModel>>(resultModel.Data.ToString());


            return templateRemarksContents;

        }

        private List<TemplateRemarksHeaderViewModel> GetTemplateRemarksHeaders()
        {

            var templateRemarksHeaders = new List<TemplateRemarksHeaderViewModel>();

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/TemplateRemarksHeaders/";
            var client = new HttpClient();

            HttpResponseMessage response = client.GetAsync(baseAddress + link).GetAwaiter().GetResult();
            response.EnsureSuccessStatusCode();
            var stringResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
            templateRemarksHeaders = JsonConvert.DeserializeObject<List<TemplateRemarksHeaderViewModel>>(resultModel.Data.ToString());

            return templateRemarksHeaders;
        }


        private InfoVisitModel GetPhotoAndXRay(string scn, string dob)
        {
            InfoVisitModel photo = new InfoVisitModel();

            photo.PhotoList = new List<string>();
            photo.XRayList = new List<string>();
            photo.ExportList = new List<string>();
            photo.ExportXRayList = new List<string>();
            //By Eddie 20200324
            photo.PhotoModifyList = new List<string>();
            photo.XRayModifyList = new List<string>();

            var di = new DirectoryInfo(_hostingEnvironment.WebRootPath + "\\ClinicalPhoto" + "\\SC" + scn.Replace("-", "") + "\\" + dob.Replace("-", ""));
            Directory.CreateDirectory(_hostingEnvironment.WebRootPath + "\\ClinicalPhoto" + "\\SC" + scn.Replace("-", "") + "\\" + dob.Replace("-", ""));
            photo.RootPath = _hostingEnvironment.WebRootPath + "\\ClinicalPhoto" + "\\ClinicalPhoto" + "\\SC" + scn.Replace("-", "") + "\\" + dob.Replace("-", "");
            var xray = new DirectoryInfo(_hostingEnvironment.WebRootPath + "\\Xray\\" + scn.Substring(0, 2) + "\\SC" + scn.Replace("-", ""));
            Directory.CreateDirectory(_hostingEnvironment.WebRootPath + "\\Xray\\" + scn.Substring(0, 2) + "\\SC" + scn.Replace("-", ""));
            Directory.CreateDirectory(_hostingEnvironment.WebRootPath + "\\ClinicalPhoto" + "\\SC" + scn.Replace("-", "") + "\\" + dob.Replace("-", "") + "\\Export");
            Directory.CreateDirectory(_hostingEnvironment.WebRootPath + "\\Xray\\" + scn.Substring(0, 2) + "\\SC" + scn.Replace("-", "") + "\\Export");
            photo.XRayPath = "http://www.localhost:8081/index.html?url=http://www.localhost:8081/data/Xray/" + scn.Substring(0, 2) + "/SC" + scn.Replace("-", "") + "/" + dob.Replace("-", "") + "/SC" + scn.Replace("-", "") + "_" + dob.Replace("-", "") + ".nii";
            var exportxray = new DirectoryInfo(_hostingEnvironment.WebRootPath + "\\Xray\\" + scn.Substring(0, 2) + "\\SC" + scn.Replace("-", "") + "\\Export");
            var export = new DirectoryInfo(_hostingEnvironment.WebRootPath + "\\ClinicalPhoto" + "\\SC" + scn.Replace("-", "") + "\\" + dob.Replace("-", "") + "\\Export");
            ImageModel imgEmpy = new ImageModel();
            imgEmpy = imgEmpy.SetDefaultValue();
            try
            {
                foreach (var file in di.EnumerateFiles("*.jpg", SearchOption.TopDirectoryOnly))
                {
                    photo.PhotoList.Add("/ClinicalPhoto" + "/SC" + scn.Replace("-", "") + "/" + dob.Replace("-", "") + "/" + file.Name);
                    ImageModel imgPhoto = new ImageModel();
                    imgPhoto = (ImageModel)GetImage(scn, dob, HttpContext.Session.GetString("_userId").ToString(), file.Name);
                    if (imgPhoto == null)
                    {
                        imgPhoto = imgEmpy;
                    }
                    photo.PhotoModifyList.Add(imgPhoto.imageData);
                }
                foreach (var file in xray.EnumerateFiles("*.jpg", SearchOption.TopDirectoryOnly))
                {
                    photo.XRayList.Add("/Xray/" + scn.Substring(0, 2) + "/SC" + scn.Replace("-", "") + "/" + file.Name);
                    ImageModel imgXRay = new ImageModel();
                    imgXRay = (ImageModel)GetImage(scn, "", HttpContext.Session.GetString("_userId").ToString(), file.Name);
                    if (imgXRay == null) { imgXRay = imgEmpy; }
                    photo.XRayModifyList.Add(imgXRay.imageData);
                }
                foreach (var file in export.EnumerateFiles("*.jpg", SearchOption.TopDirectoryOnly))
                {
                    photo.ExportList.Add("/ClinicalPhoto" + "/SC" + scn.Replace("-", "") + "/" + dob.Replace("-", "") + "/Export/" + file.Name);
                }
                foreach (var file in exportxray.EnumerateFiles("*.jpg", SearchOption.TopDirectoryOnly))
                {
                    photo.ExportXRayList.Add("/Xray/" + scn.Substring(0, 2) + "/SC" + scn.Replace("-", "") + "/Export/" + file.Name);
                }
            }
            catch (Exception ex)
            {

            }
            return photo;
        }
        private List<string> GetSubFolder(string dirPath)
        {

            List<string> dirs = new List<string>(Directory.EnumerateDirectories(dirPath));
            List<string> subFolder = new List<string>();

            foreach (var dir in dirs)
            {
                subFolder.Add(dir.Substring(dir.LastIndexOf("\\") + 1));
                //Console.WriteLine("{0}", dir.Substring(dir.LastIndexOf("\\") + 1));
            }

            return subFolder;
        }
        private InfoVisitModel GetPhotoAndXRay(string scn)
        {
            InfoVisitModel photo = new InfoVisitModel();

            photo.PhotoList = new List<string>();
            photo.XRayList = new List<string>();
            photo.ExportList = new List<string>();
            photo.ExportXRayList = new List<string>();
            photo.VisitList = new List<string>();
            //By Eddie 20200324
            photo.PhotoModifyList = new List<string>();
            photo.XRayModifyList = new List<string>();
            photo.VisitListName = new List<string>();
            var di = new DirectoryInfo(_hostingEnvironment.WebRootPath + "\\ClinicalPhoto" + "\\SC" + scn.Replace("-", ""));
            Directory.CreateDirectory(_hostingEnvironment.WebRootPath + "\\ClinicalPhoto" + "\\SC" + scn.Replace("-", ""));
            photo.RootPath = _hostingEnvironment.WebRootPath + "\\ClinicalPhoto" + "\\ClinicalPhoto" + "\\SC" + scn.Replace("-", "");
            Directory.CreateDirectory(_hostingEnvironment.WebRootPath + "\\Xray\\" + scn.Substring(0, 2) + "\\SC" + scn.Replace("-", ""));
            Directory.CreateDirectory(_hostingEnvironment.WebRootPath + "\\Xray\\" + scn.Substring(0, 2) + "\\SC" + scn.Replace("-", "") + "\\Export");
            var xray = new DirectoryInfo(_hostingEnvironment.WebRootPath + "\\Xray\\" + scn.Substring(0, 2) + "\\SC" + scn.Replace("-", ""));
            var subFolders = GetSubFolder(di.ToString());
            ImageModel imgEmpy = new ImageModel();
            imgEmpy = imgEmpy.SetDefaultValue();
            try
            {
                foreach (var subFolder in subFolders)
                {
                    Directory.CreateDirectory(_hostingEnvironment.WebRootPath + "\\ClinicalPhoto" + "\\SC" + scn.Replace("-", "") + "\\" + subFolder);
                    var diSubFolder = new DirectoryInfo(_hostingEnvironment.WebRootPath + "\\ClinicalPhoto" + "\\SC" + scn.Replace("-", "") + "\\" + subFolder);
                    Directory.CreateDirectory(_hostingEnvironment.WebRootPath + "\\ClinicalPhoto" + "\\SC" + scn.Replace("-", "") + "\\" + subFolder + "\\Export");
                    foreach (var file in diSubFolder.EnumerateFiles("*.jpg", SearchOption.TopDirectoryOnly))
                    {
                        photo.PhotoList.Add("/ClinicalPhoto" + "/SC" + scn.Replace("-", "") + "/" + subFolder + "/" + file.Name);
                        photo.VisitList.Add("/ClinicalPhoto" + "/SC" + scn.Replace("-", "") + "/" + subFolder + "/" + file.Name);
                        ImageModel imgPhoto = new ImageModel();
                        imgPhoto = (ImageModel)GetImage(scn, subFolder.Substring(0, 4) + "-" + subFolder.Substring(4, 2) + "-" + subFolder.Substring(6, 2), HttpContext.Session.GetString("_userId").ToString(), file.Name);
                        if (imgPhoto == null)
                        {
                            imgPhoto = imgEmpy;
                        }
                        photo.PhotoModifyList.Add(imgPhoto.imageData);
                        photo.VisitListName.Add(file.Name.Replace(file.Name.Split("_").First() + "_", "").Replace(".jpg", ""));
                    }
                    Directory.CreateDirectory(_hostingEnvironment.WebRootPath + "\\ClinicalPhoto" + "\\SC" + scn.Replace("-", "") + "\\" + subFolder + "\\Export");
                    var diExportSubFolder = new DirectoryInfo(_hostingEnvironment.WebRootPath + "\\ClinicalPhoto" + "\\SC" + scn.Replace("-", "") + "\\" + subFolder + "\\Export");
                    foreach (var file in diExportSubFolder.EnumerateFiles("*.jpg", SearchOption.TopDirectoryOnly))
                    {
                        photo.ExportList.Add("/ClinicalPhoto" + "/SC" + scn.Replace("-", "") + "/" + subFolder + "/Export/" + file.Name);
                        photo.VisitList.Add("/ClinicalPhoto" + "/SC" + scn.Replace("-", "") + "/" + subFolder + "/Export/" + file.Name);
                        photo.PhotoModifyList.Add("");
                        //photo.VisitListName.Add("Exported_ClinicalPhoto_" + file.Name);
                        photo.VisitListName.Add(file.Name.Replace(file.Name.Split("_").First() + "_", "").Replace(".jpg", ""));
                    }
                }
                Directory.CreateDirectory(_hostingEnvironment.WebRootPath + "\\Xray\\" + scn.Substring(0, 2) + "\\SC" + scn.Replace("-", ""));
                var diXRaySubFolder = new DirectoryInfo(_hostingEnvironment.WebRootPath + "\\Xray\\" + scn.Substring(0, 2) + "\\SC" + scn.Replace("-", ""));
                foreach (var file in diXRaySubFolder.EnumerateFiles("*.jpg", SearchOption.TopDirectoryOnly))
                {
                    photo.XRayList.Add("/Xray/" + scn.Substring(0, 2) + "/SC" + scn.Replace("-", "") + "/" + file.Name);
                    photo.VisitList.Add("/Xray/" + scn.Substring(0, 2) + "/SC" + scn.Replace("-", "") + "/" + file.Name);
                    ImageModel imgXRay = new ImageModel();
                    imgXRay = (ImageModel)GetImage(scn, "", HttpContext.Session.GetString("_userId").ToString(), file.Name);
                    if (imgXRay == null) { imgXRay = imgEmpy; }
                    photo.PhotoModifyList.Add(imgXRay.imageData);
                    //photo.VisitListName.Add("XRay_" + file.Name);
                    photo.VisitListName.Add(file.Name.Replace(file.Name.Split("_").First() + "_", "").Replace(".jpg", "").Replace(".JPG", ""));
                }
                Directory.CreateDirectory(_hostingEnvironment.WebRootPath + "\\Xray\\" + scn.Substring(0, 2) + "\\SC" + scn.Replace("-", "") + "\\Export");
                var diXRayExportSubFolder = new DirectoryInfo(_hostingEnvironment.WebRootPath + "\\Xray\\" + scn.Substring(0, 2) + "\\SC" + scn.Replace("-", "") + "\\Export");
                foreach (var file in diXRayExportSubFolder.EnumerateFiles("*.jpg", SearchOption.TopDirectoryOnly))
                {
                    photo.ExportXRayList.Add("/Xray/" + scn.Substring(0, 2) + "/SC" + scn.Replace("-", "") + "/Export/" + file.Name);
                    photo.VisitList.Add("/Xray/" + scn.Substring(0, 2) + "/SC" + scn.Replace("-", "") + "/Export/" + file.Name);
                    photo.PhotoModifyList.Add("");
                    //photo.VisitListName.Add("Exported_XRay_" + file.Name);
                    photo.VisitListName.Add(file.Name.Replace(file.Name.Split("_").First() + "_", "").Replace(".jpg", ""));
                }
            }
            catch (Exception ex)
            {

            }
            return photo;
        }


        //ActionResult by ppost
        [HttpPost]
        public ActionResult Visit(InfoVisitModel infoVisitModel1, InfoBarViewModel infoBarViewModel1)
        {

            try
            {
                var scn = infoBarViewModel1.SCN;
                var dob = ConvertUrlDateForm(infoVisitModel1.DOC);
                var infoBarViewModel = GetInfoBarViewModels(scn);
                Tuple<InfoVisitModel, InfoBarViewModel> tupleModel;

                infoVisitModel1.SCN = scn;

                VisitsModel visit1;
                ResultModel resultModel;


                try
                {
                    visit1 = (VisitsModel)infoVisitModel1;
                    resultModel = UpdateVisitsAPI(visit1);

                    if (resultModel.IsSuccess)
                    {

                        var infoVisitModelResult = GetinfoVisitModel(scn, dob);
                        var infoVisitModel = SetPhotoInfoVisitModel(infoVisitModelResult.Result);

                        tupleModel = new Tuple<InfoVisitModel, InfoBarViewModel>(infoVisitModel, infoBarViewModel);
                        SetSessionMessage("Update Success");


                        InsertActionLog("Update", "Update Visits Success", scn, dob, HttpContext.Session.GetString("_userId"), "Visit");

                        return View(tupleModel);
                    }
                    else
                    {

                        SetSessionMessage(resultModel.Message);
                    }
                }
                catch (Exception ex1)
                {
                    SetSessionMessage(ex1.Message);
                }
                infoVisitModel1 = SetPhotoInfoVisitModel(infoVisitModel1);
                tupleModel = new Tuple<InfoVisitModel, InfoBarViewModel>(infoVisitModel1, infoBarViewModel);


                InsertActionLog("Update", "Update Visits Fail", scn, dob, HttpContext.Session.GetString("_userId"), "Visit");

                return View(tupleModel);

            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to save visit";

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Visit Post", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }
        }

        private InfoVisitModel SetPhotoInfoVisitModel(InfoVisitModel infoVisitModel)
        {

            var dateTime = ConvertUrlDateForm(infoVisitModel.DOC);

            var photo = GetPhotoAndXRay(infoVisitModel.SCN, dateTime);
            infoVisitModel.PhotoList = photo.PhotoList;
            infoVisitModel.XRayList = photo.XRayList;
            infoVisitModel.XRayPath = photo.XRayPath;
            //By Eddie 20200324
            infoVisitModel.PhotoModifyList = photo.PhotoModifyList;
            infoVisitModel.XRayModifyList = photo.XRayModifyList;
            return infoVisitModel;
        }


        private void SetSessionMessage(string message)
        {

            HttpContext.Session.SetString("_isShowMessage", "true");
            HttpContext.Session.SetString("_alertMessage", message);
        }



        private void ResetSubmitSession()
        {
            HttpContext.Session.SetString("_isShowMessage", "false");
            HttpContext.Session.SetString("_alertMessage", "");
            HttpContext.Session.SetString("_isCreatePage", "false");
        }

        public IActionResult WebRemoveSession()
        {
            ResetSubmitSession();
            return Content(DateTime.Now.Ticks.ToString() + ":AjaxPost");
        }


        public ActionResult EditPersonalInfo(string scn)
        {
            var isCreatePage = HttpContext.Session.GetString("_isCreatePage");

            if (!IsLogin())
            {
                return RedirectToReLoginPage();
            }

            try
            {
                if (isCreatePage == "true")
                {
                    HttpContext.Session.SetString("_isCreatePage", "false");
                }
                else
                {
                    ResetSubmitSession();
                }

                var personalInfoViewModel = GetPersonalInfoModel(scn);
                var infoBarViewModel = GetInfoBarViewModels(scn);
                var infoPersonalInfoViewModel = (InfoPersonalInfoViewModel)personalInfoViewModel.Result;
                var tupleModel = new Tuple<InfoPersonalInfoViewModel, InfoBarViewModel>(infoPersonalInfoViewModel, infoBarViewModel);

                return View(tupleModel);

            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to Update Personal Info";

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Personal Info", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }
        }


        //public ActionResult UpdatePersonalInfo(InfoPersonalInfoViewModel infoPersonalInfoViewModel, InfoBarViewModel infoBarViewModel)
        [HttpPost]
        public ActionResult EditPersonalInfo(InfoPersonalInfoViewModel infoPersonalInfoViewModel, InfoBarViewModel infoBarViewModel)
        {
            try
            {
                var scn = infoPersonalInfoViewModel.SCN;
                //var directAction = "EditPersonalInfo";
                var infoBarViewModel1 = GetInfoBarViewModels(scn);
                Tuple<InfoPersonalInfoViewModel, InfoBarViewModel> tupleModel;

                try
                {
                    var resultModel = UpdatePersonalInfoAPI((PersonalInfoModel)infoPersonalInfoViewModel);
                    //var infoPersonalInfoViewModel1 = GetPersonInfoViewModel(scn);

                    var infoPersonalInfoViewModel1 = (InfoPersonalInfoViewModel)GetPersonalInfoModel(scn).Result;
                    if (resultModel.IsSuccess == true)
                    {
                        SetSessionMessage("Sucessful updated!");
                        tupleModel = new Tuple<InfoPersonalInfoViewModel, InfoBarViewModel>(infoPersonalInfoViewModel1, infoBarViewModel1);
                    }
                    else
                    {
                        SetSessionMessage(resultModel.Message);
                        tupleModel = new Tuple<InfoPersonalInfoViewModel, InfoBarViewModel>(infoPersonalInfoViewModel, infoBarViewModel1);
                    }
                }
                catch (Exception ex)
                {
                    SetSessionMessage(ex.Message);
                    tupleModel = new Tuple<InfoPersonalInfoViewModel, InfoBarViewModel>(infoPersonalInfoViewModel, infoBarViewModel1);
                }

                InsertActionLog("Update", "Update Personal Info Success", scn, "1900-01-01", HttpContext.Session.GetString("_userId"), "PersonalInfo");

                return View(tupleModel);
                // return RedirectToAction(directAction, new { scn = scn });

            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to Update Personal Info";

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "PersonalInfo Edit Post", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);
            }
        }

        public ActionResult TextSearch(string inputText, bool isInitalAss, bool isPatientInfo, bool isRemarkBox, bool isAllOther)
        {

            //var link = $"/api/PersonalI5nfos/98-10053";
            var baseAddress = "Http://" + Request.Host.ToString();

            if (string.IsNullOrEmpty(inputText))
            {
                return View(new List<PersonalInfoModel>());
            }

            var link = $"/api/TextSearchs/" + inputText + "/" + isInitalAss + "/" + isPatientInfo + "/" + isRemarkBox + "/" + isAllOther;
            var client = new HttpClient();

            HttpResponseMessage response = client.GetAsync(baseAddress + link).GetAwaiter().GetResult();
            response.EnsureSuccessStatusCode();
            var stringResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
            var personalInfos = JsonConvert.DeserializeObject<List<PersonalInfoModel>>(resultModel.Data.ToString());

            return View(personalInfos.ToList());

        }


        public ActionResult Search(string Name, string SCN, string HKID, string SortBy, string Orderby, string kingOption, string Remarks, string dateFrom, string dateTo, string isAllList, string range)
        {
            if (!IsLogin())
            {
                return RedirectToReLoginPage();
            }

            try
            {
                //var link = $"/api/PersonalI5nfos/98-10053";
                var baseAddress = "Http://" + Request.Host.ToString();

                //var link = $"/api/PersonalInfos/" + Name + "/" + SCN + "/" + HKID + "/" + SortBy + "/" + Remarks + "/" + Orderby + "/" + kingOption + "/" + dateFrom + "/" + dateTo;
                // [HttpGet("{name}/{scn}/{hkid}/{sortBy}/{remarks}/{orderby}/{kingOption}/{dateFrom}/{dateTo}")]

                var searchString = returnSearchString(Name, SCN, HKID, SortBy, Orderby, kingOption, Remarks, dateFrom, dateTo, isAllList, range);
                var link = $"/api/PersonalInfos/" + SortBy + "/" + Orderby + "/" + searchString;
                var client = new HttpClient();

                HttpResponseMessage response = client.GetAsync(baseAddress + link).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                var stringResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
                var personalInfos = JsonConvert.DeserializeObject<List<PersonalInfoModel>>(resultModel.Data.ToString());
                var patientSearchViewModel = setPatientSearchViewModel(Name, SCN, HKID, SortBy, Orderby, kingOption, Remarks, dateFrom, dateTo, isAllList, range);

                //work
                var tupleModel = new Tuple<List<PersonalInfoModel>, PatientSearchViewModel>(personalInfos.ToList(), patientSearchViewModel);

                return View(tupleModel);


            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to Search Recrod";

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Search", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }
        }


        public ActionResult SearchTrad(string Name, string SCN, string HKID, string SortBy, string Orderby, string kingOption, string Remarks, string dateFrom, string dateTo, string isAllList, string range)
        {
            if (!IsLogin())
            {
                return RedirectToReLoginPage();
            }

            try
            {
                //var link = $"/api/PersonalI5nfos/98-10053";
                var baseAddress = "Http://" + Request.Host.ToString();

                //var link = $"/api/PersonalInfos/" + Name + "/" + SCN + "/" + HKID + "/" + SortBy + "/" + Remarks + "/" + Orderby + "/" + kingOption + "/" + dateFrom + "/" + dateTo;
                // [HttpGet("{name}/{scn}/{hkid}/{sortBy}/{remarks}/{orderby}/{kingOption}/{dateFrom}/{dateTo}")]

                var searchString = returnSearchString(Name, SCN, HKID, SortBy, Orderby, kingOption, Remarks, dateFrom, dateTo, isAllList, range);
                var link = $"/api/PersonalInfos/" + SortBy + "/" + Orderby + "/" + searchString;
                var client = new HttpClient();

                HttpResponseMessage response = client.GetAsync(baseAddress + link).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                var stringResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
                var personalInfos = JsonConvert.DeserializeObject<List<PersonalInfoModel>>(resultModel.Data.ToString());
                var patientSearchViewModel = setPatientSearchViewModel(Name, SCN, HKID, SortBy, Orderby, kingOption, Remarks, dateFrom, dateTo, isAllList, range);

                //work
                var tupleModel = new Tuple<List<PersonalInfoModel>, PatientSearchViewModel>(personalInfos.ToList(), patientSearchViewModel);

                return View(tupleModel);


            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to Search Recrod";

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Search", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }
        }

        private string returnExMessage(Exception ex)
        {

            var exMessage = "";

            if (ex != null && ex.Message != null)
                exMessage = ex.Message;

            return exMessage;
        }

        private string returninnerExceptionMessage(Exception ex)
        {

            var exMessage = "";

            if (ex != null && ex.Message != null && ex.InnerException != null && ex.InnerException.Message != null)
                exMessage = ex.InnerException.Message;

            return exMessage;
        }


        private ActionResult RedirectToErrorPage(string gUIDNumner, DateTime exceptionDateTime, string message)
        {
            var directAction = "../Error";
            return RedirectToAction(directAction, new { GUIDNumner = gUIDNumner, ExceptionDateTime = exceptionDateTime, Message = message });
        }

        public ActionResult SpecialRemarkSummary(string scn)
        {
            try
            {
                var personalInfoModel = GetPersonalInfoModel(scn);
                var visitsModels = GetVisitsModels(scn);
                var infoSpecialRemarkSummaryViewModels = new List<InfoSpecialRemarkSummaryViewModel>();
                var i = 1;

                if (visitsModels.Result == null || visitsModels.Result.Count == 0)
                {
                    var infoSpecialRemarkSummaryViewModel = new InfoSpecialRemarkSummaryViewModel();
                    infoSpecialRemarkSummaryViewModel.SCN = "None";
                    infoSpecialRemarkSummaryViewModel.Name = "None";

                    infoSpecialRemarkSummaryViewModels.Add(infoSpecialRemarkSummaryViewModel);
                }
                else {

                    foreach (var visitsModel in visitsModels.Result)
                    {
                        var infoSpecialRemarkSummaryViewModel = InfoSpecialRemarkSummaryViewModelMapping(personalInfoModel.Result, visitsModel, i);
                        i++;

                        infoSpecialRemarkSummaryViewModels.Add(infoSpecialRemarkSummaryViewModel);
                    }

                }


                return View(infoSpecialRemarkSummaryViewModels);
            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to show special remark summary";

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "SpecialRemarkSummary", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));


                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);
            }
        }
        private List<InfoVisitModel> GetAllinfoVisitModels(string scn)
        {

            var infoVisitModels = new List<InfoVisitModel>();
            var personalInfoModel = GetPersonalInfoModel(scn).Result;
            var visitsModels = GetVisitsModels(scn);

            //var countInt = 0;

            foreach (VisitsModel visitsModel in visitsModels.Result)
            {
                //if (countInt == 3)
                //{
                //    break;
                //}

                //countInt = countInt + 1;

                var infoVisitModel = InfoVisitModelVisitModelMapping(visitsModel, personalInfoModel, true);
                infoVisitModels.Add(infoVisitModel);
            }

            return infoVisitModels;
        }

        private InfoBarViewModel GetInfoBarViewModels(string scn)
        {
            var personalInfoModel = GetPersonalInfoModel(scn);
            var tempStringList = GetVisitsDOBLists(scn);
            var tempPOvistList = GetPOVisitList(scn);
            var tempPhysioList = GetPhysioList(scn);
            var infoBarViewModel = InfoBarViewModelPersonalInfoModelMapping(personalInfoModel.Result, tempStringList.Result, tempPOvistList.Result, tempPhysioList.Result);

            return infoBarViewModel;
        }

        private InfoBarViewModel InfoBarViewModelPersonalInfoModelMapping(PersonalInfoModel personalInfoModel, List<string> visits, List<string> POvisit, List<string> Physio)
        {

            var infoBarViewModel = new InfoBarViewModel();

            infoBarViewModel.HKID = personalInfoModel.HKID;
            infoBarViewModel.Name = personalInfoModel.Name;
            infoBarViewModel.SCN = personalInfoModel.SCN;
            infoBarViewModel.visits = visits;
            infoBarViewModel.POvisit = POvisit;
            infoBarViewModel.Physio = Physio;
            return infoBarViewModel;
        }

        private InfoSpecialRemarkSummaryViewModel InfoSpecialRemarkSummaryViewModelMapping(PersonalInfoModel personalInfoModel, VisitsModel visitsModel, int visitNo)
        {
            var infoSpecialRemarkSummaryViewModel = new InfoSpecialRemarkSummaryViewModel();

            infoSpecialRemarkSummaryViewModel.SCN = personalInfoModel.SCN;
            infoSpecialRemarkSummaryViewModel.VisitNo = visitNo.ToString();
            infoSpecialRemarkSummaryViewModel.Remarks = visitsModel.SpcRemarks;
            infoSpecialRemarkSummaryViewModel.Name = personalInfoModel.Name;
            infoSpecialRemarkSummaryViewModel.Doctor = visitsModel.DrName;
            if (visitsModel.DOC is null)
            {
                infoSpecialRemarkSummaryViewModel.Date = "";
            }
            else
            {
                infoSpecialRemarkSummaryViewModel.Date = visitsModel.DOC.Value.ToString("yyyy-MM-dd");
            }


            return infoSpecialRemarkSummaryViewModel;
        }

        private InfoVisitModel InfoVisitModelVisitModelMapping(VisitsModel visitsModel, PersonalInfoModel personalInfoModel, Boolean isSummary)
        {

            //var infoVisitModel = new InfoVisitModel();

            var infoVisitModel = (InfoVisitModel)visitsModel;

            //infoVisitModel.SCN = visitsModel.SCN;

            //20200819 VisitListRemark

            //if (!string.IsNullOrEmpty(infoVisitModel.VisitListRemark))
            //{
            //    infoVisitModel.VisitListRemark = visitsModel.SpcRemarks;
            //}


            if (visitsModel != null)
            {
                if (isSummary)
                {
                    if (visitsModel.SpcRemarks == null)
                    {
                        infoVisitModel.VisitListRemark = "";
                        infoVisitModel.SpcRemarks = "No";
                    }
                    else
                    {
                        infoVisitModel.VisitListRemark = visitsModel.SpcRemarks;
                        infoVisitModel.SpcRemarks = "Yes";
                    }
                }
                else
                {
                    if (visitsModel.SpcRemarks == null)
                    {
                        infoVisitModel.VisitListRemark = "";
                        infoVisitModel.SpcRemarks = "";
                    }
                    else
                    {
                        infoVisitModel.VisitListRemark = visitsModel.SpcRemarks;
                        infoVisitModel.SpcRemarks = visitsModel.SpcRemarks;
                    }
                }

                if (personalInfoModel.DOB != null && visitsModel.DOC != null)
                {
                    infoVisitModel.Age = CalAge(personalInfoModel.DOB.Value, visitsModel.DOC.Value);
                }
                else
                {
                    infoVisitModel.Age = "";
                }

                infoVisitModel.Remarks = visitsModel.SpcRemarks;
            }
            else
            {
                infoVisitModel.SpcRemarks = "";
                infoVisitModel.Age = "";
                infoVisitModel.Remarks = "";
            }

            return infoVisitModel;
        }

        private string CalAge(DateTime DOB, DateTime DOC)
        {

            var ageYear = DOC.Year - DOB.Year;
            var ageMonth = 0;

            if (DOB.Month >= DOC.Month)
            {
                ageYear = ageYear - 1;
                ageMonth = DOB.Month - DOC.Month;
            }

            if (DOB.Month < DOC.Month)
            {
                ageMonth = DOC.Month - DOB.Month;
            }

            return ageYear + "y" + ageMonth + "m";

        }

        public ActionResult Detail()
        {
            return View();
        }

        //https://localhost:44361/Patient/Search?SortBy=SortBySCN&Orderby=OrderbyDesc&Name=&SCN=&HKID=&kingOption=&Remarks=&dateFrom=2019-06-05&dateTo=2019-06-28

        private PatientSearchViewModel setPatientSearchViewModel(string Name, string SCN, string HKID, string SortBy, string Orderby, string kingOption, string Remarks, string dateFrom, string dateTo, string isAllList, string range)
        {

            var patientSearchViewModel = new PatientSearchViewModel();

            patientSearchViewModel.Name = Name;
            patientSearchViewModel.SCN = SCN;
            patientSearchViewModel.HKID = HKID;
            patientSearchViewModel.SortBy = SortBy;
            patientSearchViewModel.Orderby = Orderby;
            patientSearchViewModel.kingOption = kingOption;
            patientSearchViewModel.Remarks = Remarks;
            patientSearchViewModel.DateFrom = dateFrom;
            patientSearchViewModel.DateTo = dateTo;
            patientSearchViewModel.IsAllList = isAllList;
            patientSearchViewModel.Range = range;

            return patientSearchViewModel;
        }

        private string returnSearchString(string Name, string SCN, string HKID, string SortBy, string Orderby, string kingOption, string Remarks, string dateFrom, string dateTo, string isAllList, string range)
        {

            var searchString = "";



            if (Name != null && Name.TrimEnd().TrimStart() != "")
            {
                searchString += "&Name=" + Name.ToLower();
            }

            if (SCN != null && SCN.TrimEnd().TrimStart() != "")
            {
                searchString += "&scn=" + SCN;
            }

            if (HKID != null && HKID.TrimEnd().TrimStart() != "")
            {
                searchString += "&HKID=" + HKID;
            }

            if (SortBy != null && SortBy.TrimEnd().TrimStart() != "")
            {
                searchString += "&SortBy=" + SortBy;
            }

            if (Orderby != null && Orderby.TrimEnd().TrimStart() != "")
            {
                searchString += "&Orderby=" + Orderby;
            }

            if (kingOption != null && kingOption.TrimEnd().TrimStart() != "")
            {
                searchString += "&kingOption=" + kingOption;
            }

            if (Remarks != null && Remarks.TrimEnd().TrimStart() != "")
            {
                searchString += "&Remarks=" + Remarks;
            }

            if (dateFrom != null && dateFrom.TrimEnd().TrimStart() != "")
            {


                searchString += "&dateFrom=" + ConvertUrlDateForm(dateFrom);
            }

            if (dateTo != null && dateTo.TrimEnd().TrimStart() != "")
            {
                searchString += "&dateTo=" + ConvertUrlDateForm(dateTo);
            }

            if (isAllList != null && isAllList.TrimEnd().TrimStart() != "")
            {
                searchString += "&isAllList=" + isAllList;
            }

            if (range != null && range.TrimEnd().TrimStart() != "")
            {
                searchString += "&range=" + range;
            }

            if (searchString == "")
            {
                searchString = "&";
            }

            return searchString;
        }

        private ResultModel UpdateVisitsAPI(VisitsModel visit)
        {
            var baseAddress = "Http://" + Request.Host.ToString();
            //var link = $"/api/Visits/";
            var link = $"/api/Visits/" + visit.SCN;
            var client1 = new HttpClient();

            //var visit1 = new VisitsModel();
            //visit1.SCN = "99-10289";

            string content = JsonConvert.SerializeObject(visit);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            //HttpResponseMessage response = client1.PostAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            HttpResponseMessage response = client1.PutAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;
        }


        private ResultModel UpdatePersonalInfoAPI(PersonalInfoModel personalInfo)
        {
            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/PersonalInfos/" + personalInfo.SCN;
            var client1 = new HttpClient();

            personalInfo.LastModifyBy = HttpContext.Session.GetString("_userId");

            string content = JsonConvert.SerializeObject(personalInfo);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = client1.PutAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;
        }


        public ActionResult CreatePersonalInfo()
        {
            var ceatePersonalInfoViewModel = new CreatePersonalInfoViewModel();

            if (!IsLogin())
            {
                return RedirectToReLoginPage();
            }

            ceatePersonalInfoViewModel = ceatePersonalInfoViewModel.SetDefaultValue(ceatePersonalInfoViewModel);

            ResetSubmitSession();

            return View(ceatePersonalInfoViewModel);
        }

        [HttpPost]
        public ActionResult CreatePersonalInfo(CreatePersonalInfoViewModel ceatePersonalInfoViewModel)
        {
            try
            {
                if (!IsLogin())
                {
                    return RedirectToReLoginPage();
                }

                var scn = "";
                var directAction = "EditPersonalInfo";

                try
                {

                    var personalInfo = (PersonalInfoModel)ceatePersonalInfoViewModel;
                    scn = personalInfo.SCN;
                    personalInfo.LastModifyBy = HttpContext.Session.GetString("_userId");
                    var resultModel = InsertPersonalInfo(personalInfo);

                    if (resultModel.IsSuccess)
                    {
                        HttpContext.Session.SetString("_isCreatePage", "true");
                        SetSessionMessage("Success Save");
                    }
                    else
                    {

                        SetSessionMessage(resultModel.Message);
                        return View(ceatePersonalInfoViewModel);
                    }

                    //SetSubmitSession(resultModel);

                }
                catch (Exception ex)
                {
                    SetSessionMessage(ex.Message);
                    return View(ceatePersonalInfoViewModel);
                }

                InsertActionLog("Created", "Personal Info Save Successfully", scn, "1900-01-01", HttpContext.Session.GetString("_userId"), "PersonalInfo");
                return RedirectToAction(directAction, new { scn = scn });
            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to Search Recrod <br>" + ex.Message + "<br>" + ex.InnerException.Message;

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "CreatePersonalInfo Post", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));


                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }

        }

        public ActionResult CreateNewVisit(string scn)
        {
            if (!IsLogin())
            {
                return RedirectToReLoginPage();
            }

            try
            {
                var infoBarViewModel = GetInfoBarViewModels(scn);
                var createNewVisitViewModel = new CreateNewVisitViewModel();

                createNewVisitViewModel = createNewVisitViewModel.SetDefaultValue(createNewVisitViewModel);

                var tupleModel = new Tuple<InfoBarViewModel, CreateNewVisitViewModel>(infoBarViewModel, createNewVisitViewModel);

                return View(tupleModel);
            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to Update Personal Info";

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "CreateNewVisit", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);
            }

        }

        [HttpPost]
        public ActionResult CreateNewVisit(CreateNewVisitViewModel createNewVisitViewModel)
        {
            try
            {

                var directAction = "Visit";
                var dob = "";
                var scn = "";
                scn = createNewVisitViewModel.SCN;
                var infoBarViewModel = GetInfoBarViewModels(scn);

                try
                {
                    var visitsModel = (VisitsModel)createNewVisitViewModel;
                    var resultModel = InsertCreateVisitAPI(visitsModel);

                    if (visitsModel.DOC != null)
                    {
                        dob = visitsModel.DOC.Value.ToString("yyyy-MM-dd");
                    }

                    if (resultModel.IsSuccess == true)
                    {
                        HttpContext.Session.SetString("_isCreatePage", "true");
                        SetSessionMessage("Save Success!");
                    }
                    else
                    {

                        SetSessionMessage(resultModel.Message);
                        createNewVisitViewModel = createNewVisitViewModel.SetDefaultValue(createNewVisitViewModel);

                        var tupleModel = new Tuple<InfoBarViewModel, CreateNewVisitViewModel>(infoBarViewModel, createNewVisitViewModel);
                        return View(tupleModel);
                    }

                }
                catch (Exception ex1)
                {
                    SetSessionMessage(ex1.Message);
                    createNewVisitViewModel = createNewVisitViewModel.SetDefaultValue(createNewVisitViewModel);

                    var tupleModel = new Tuple<InfoBarViewModel, CreateNewVisitViewModel>(infoBarViewModel, createNewVisitViewModel);
                    return View(tupleModel);
                }


                InsertActionLog("Created", "New Visit Save Successfully", scn, dob, HttpContext.Session.GetString("_userId"), "Visit");
                return RedirectToAction(directAction, new { scn = scn, dob = dob });
            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to Create New Visit";

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "CreateNewVisit Post", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);
            }
        }


        private ResultModel InsertCreateVisitAPI(VisitsModel visitsModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/Visits/";
            var client1 = new HttpClient();

            string content = JsonConvert.SerializeObject(visitsModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = client1.PostAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;

        }

        private PersonalInfoModel GetPersonInfoViewModel(string scn)
        {

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/PersonalInfos/";
            var client = new HttpClient();

            HttpResponseMessage response = client.GetAsync(baseAddress + link).GetAwaiter().GetResult();
            response.EnsureSuccessStatusCode();
            var stringResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
            var personalInfo = JsonConvert.DeserializeObject<List<PersonalInfoModel>>(resultModel.Data.ToString());

            return personalInfo.FirstOrDefault();
        }

        private ResultModel InsertPersonalInfo(PersonalInfoModel personalInfo)
        {
            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/PersonalInfos/";
            var client1 = new HttpClient();

            string content = JsonConvert.SerializeObject(personalInfo);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = client1.PostAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;
        }

        private async Task<PersonalInfoModel> GetPersonalInfoModel(string scn)
        {

            var baseAddress1 = "Http://" + Request.Host.ToString();
            var link1 = $"/api/PersonalInfos/" + scn;
            var client1 = new HttpClient();
            HttpResponseMessage response1 = await client1.GetAsync(baseAddress1 + link1);
            response1.EnsureSuccessStatusCode();
            var stringResult1 = await response1.Content.ReadAsStringAsync();
            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);
            var personalInfoModel = JsonConvert.DeserializeObject<List<PersonalInfoModel>>(resultModel1.Data.ToString()).FirstOrDefault();

            return personalInfoModel;
        }

        private async Task<List<string>> GetVisitsDOBLists(string scn)
        {

            var baseAddress1 = "Http://" + Request.Host.ToString();
            var link2 = $"/api/Visits/" + scn;
            var client2 = new HttpClient();
            var tempStringList = new List<string>();

            try
            {
                HttpResponseMessage response2 = await client2.GetAsync(baseAddress1 + link2);
                response2.EnsureSuccessStatusCode();

                var stringResult2 = await response2.Content.ReadAsStringAsync();
                ResultModel resultModel2 = JsonConvert.DeserializeObject<ResultModel>(stringResult2);
                var visitsModels = JsonConvert.DeserializeObject<List<string>>(resultModel2.Data.ToString());


                for (var i = 0; i < visitsModels.Count(); i++)
                {
                    tempStringList.Add(visitsModels[i]);
                }
            }
            catch (Exception ex)
            {
                //Should add log
            }

            return tempStringList;
        }

        private async Task<List<VisitsModel>> GetVisitsModels(string scn)
        {

            var infoVisitModels = new List<InfoVisitModel>();
            var dob = "1900-01-01";

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/Visits/" + scn + "/" + dob + "/Y";
            var client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(baseAddress + link);
            response.EnsureSuccessStatusCode();
            var stringResult = await response.Content.ReadAsStringAsync();
            ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
            var visitsModels = JsonConvert.DeserializeObject<List<VisitsModel>>(resultModel.Data.ToString());

            return visitsModels;
        }

        private async Task<InfoVisitModel> GetinfoVisitModel(string scn, string dob)
        {
            //dob Must yyyy-MM-dd
            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/Visits/" + scn + "/" + dob;
            var client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(baseAddress + link);
            response.EnsureSuccessStatusCode();
            var stringResult = await response.Content.ReadAsStringAsync();
            ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
            var visitsModels = JsonConvert.DeserializeObject<List<VisitsModel>>(resultModel.Data.ToString());
            var personalInfoModel = GetPersonalInfoModel(scn);
            var infoVisitModel = InfoVisitModelVisitModelMapping(visitsModels.FirstOrDefault(), personalInfoModel.Result, false);

            return infoVisitModel;

        }




        private string ConvertUrlDateForm(string datetimeStr)
        {

            DateTime datetime = DateTime.Now;

            if (string.IsNullOrEmpty(datetimeStr))
            {
                return datetime.ToString("yyyy-MM-dd");
            }

            if (datetimeStr.Contains("/"))
            {
                datetime = DateTime.ParseExact(datetimeStr, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }

            if (datetimeStr.Contains("-"))
            {
                datetime = DateTime.ParseExact(datetimeStr, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            }

            return datetime.ToString("yyyy-MM-dd");
        }


        public ActionResult UploadImage([FromBody] dynamic imageData, string imgsrc)
        {
            string tpimage = imageData["imageData"];
            string[] src = imgsrc.Split("/");
            string scn = "";
            string dob = "";
            if (src[1] == "Xray")
            {
                scn = src[3].Replace("SC", "").Insert(2, "-");
                dob = src[4].Insert(4, "-").Insert(7, "-");
            }
            else
            {
                scn = src[2].Replace("SC", "").Insert(2, "-");
                dob = src[3].Insert(4, "-").Insert(7, "-");
            }
            //string fileNameWitPath = "C:\\Temp\\" + DateTime.Now.ToString().Replace("/", "-").Replace(" ", "- ").Replace(":", "") + ".png";
            string fileNameWitPath = _hostingEnvironment.WebRootPath + imgsrc.Replace(".jpg", DateTime.Now.ToString("_MM_dd_yyyy_HH_mm_ss") + ".jpg").Replace("/", "\\");
            string filename = System.IO.Path.GetFileNameWithoutExtension(fileNameWitPath);
            if (fileNameWitPath.Contains("Export"))
            { }
            else
                fileNameWitPath = fileNameWitPath.Replace(filename, "Export\\" + filename);
            Directory.CreateDirectory(System.IO.Path.GetDirectoryName(fileNameWitPath));
            using (FileStream fs = new FileStream(fileNameWitPath, FileMode.Create))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    byte[] data = Convert.FromBase64String(tpimage);
                    bw.Write(data);
                    bw.Close();
                }
            }
            return RedirectToAction("./VisitPage", new { scn = scn, dob = dob });

        }
        [HttpPost]
        public void DeleteImage(string imgsrc)
        {

            //string fileNameWitPath = "C:\\Temp\\" + DateTime.Now.ToString().Replace("/", "-").Replace(" ", "- ").Replace(":", "") + ".png";
            string fileNameWitPath = _hostingEnvironment.WebRootPath + imgsrc.Replace("/", "\\");
            System.IO.File.Delete(fileNameWitPath);
        }

        private ResultModel InsertActionLog(string type, string typeDetail, string scn, string doc, string createdby, string actionPage)
        {
            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/ActionLogs";
            var client = new HttpClient();
            var actionLogViewModel = new ActionLogViewModel();

            actionLogViewModel.ActionType = type;
            actionLogViewModel.ActionDetail = typeDetail;
            actionLogViewModel.CreatedBy = createdby;
            actionLogViewModel.scn = scn;

            if (doc == "")
            {
                actionLogViewModel.doc = new DateTime(2000, 1, 1);
            }
            else
            {
                actionLogViewModel.doc = DateTime.ParseExact(doc, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            }


            actionLogViewModel.LogDateTime = DateTime.Now;
            actionLogViewModel.ActionPage = actionPage;

            string content = JsonConvert.SerializeObject(actionLogViewModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = client.PostAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;

        }

        private async Task<List<InfoDisplayLogViewModel>> GetActionVisitLog(string scn, string doc)
        {
            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/ActionLogs/" + scn + "/Visit/" + doc;
            var client = new HttpClient();
            var infoDisplayLogViewModels = new List<InfoDisplayLogViewModel>();

            HttpResponseMessage response = await client.GetAsync(baseAddress + link);
            response.EnsureSuccessStatusCode();
            var stringResult = await response.Content.ReadAsStringAsync();
            ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
            var actionLogViewModels = JsonConvert.DeserializeObject<List<ActionLogViewModel>>(resultModel.Data.ToString());

            foreach (var actionLogViewModel in actionLogViewModels)
            {
                infoDisplayLogViewModels.Add((InfoDisplayLogViewModel)actionLogViewModel);
            }

            return infoDisplayLogViewModels;
        }

        private async Task<List<InfoDisplayLogViewModel>> GetActionPeronalLog(string scn)
        {
            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/ActionLogs/" + scn + "/PersonalInfo";
            var client = new HttpClient();
            var infoDisplayLogViewModels = new List<InfoDisplayLogViewModel>();

            HttpResponseMessage response = await client.GetAsync(baseAddress + link);
            response.EnsureSuccessStatusCode();
            var stringResult = await response.Content.ReadAsStringAsync();
            ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
            var actionLogViewModels = JsonConvert.DeserializeObject<List<ActionLogViewModel>>(resultModel.Data.ToString());

            foreach (var actionLogViewModel in actionLogViewModels)
            {
                infoDisplayLogViewModels.Add((InfoDisplayLogViewModel)actionLogViewModel);
            }

            return infoDisplayLogViewModels;
        }

        public ActionResult DisplayActionLog()
        {
            if (!IsLogin())
            {
                return RedirectToReLoginPage();
            }

            try
            {
                var infoDisplayLogViewModels = new List<InfoDisplayLogViewModel>();

                infoDisplayLogViewModels = GetActionLog().Result;

                if (infoDisplayLogViewModels.Count == 0)
                {

                    var infoDisplayLogViewModel = new InfoDisplayLogViewModel();
                    infoDisplayLogViewModel.scn = "-";
                    infoDisplayLogViewModel.doc = "-";
                    infoDisplayLogViewModel.ActionDetail = "-";
                    infoDisplayLogViewModel.ActionPage = "-";
                    infoDisplayLogViewModel.ActionType = "-";
                    infoDisplayLogViewModels.Add(infoDisplayLogViewModel);

                }

                return View(infoDisplayLogViewModels);
            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to show special remark summary";

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "DisplayVisitsLog", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));


                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);
            }
        }

        private async Task<List<InfoDisplayLogViewModel>> GetActionLog()
        {
            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/ActionLogs";
            var client = new HttpClient();
            var infoDisplayLogViewModels = new List<InfoDisplayLogViewModel>();

            HttpResponseMessage response = await client.GetAsync(baseAddress + link);
            response.EnsureSuccessStatusCode();
            var stringResult = await response.Content.ReadAsStringAsync();
            ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
            var actionLogViewModels = JsonConvert.DeserializeObject<List<ActionLogViewModel>>(resultModel.Data.ToString());

            foreach (var actionLogViewModel in actionLogViewModels)
            {
                infoDisplayLogViewModels.Add((InfoDisplayLogViewModel)actionLogViewModel);
            }

            return infoDisplayLogViewModels;
        }

        private List<InfoDisplayLogViewModel> MappingInfoDisplayLogViewModel(List<ActionLogViewModel> actionLogViewModels)
        {
            var infoDisplayLogViewModels = new List<InfoDisplayLogViewModel>();

            foreach (var actionLogViewModel in actionLogViewModels)
            {
                infoDisplayLogViewModels.Add((InfoDisplayLogViewModel)actionLogViewModel);
            }
            return infoDisplayLogViewModels;
        }

        public ActionResult DisplayVisitsLog(string scn, string doc)
        {
            if (!IsLogin())
            {
                return RedirectToReLoginPage();
            }

            try
            {
                var infoDisplayLogViewModels = new List<InfoDisplayLogViewModel>();

                infoDisplayLogViewModels = GetActionVisitLog(scn, ConvertUrlDateForm(doc)).Result;

                if (infoDisplayLogViewModels.Count == 0)
                {

                    var infoDisplayLogViewModel = new InfoDisplayLogViewModel();
                    infoDisplayLogViewModel.scn = scn;
                    infoDisplayLogViewModel.doc = doc;
                    infoDisplayLogViewModel.ActionDetail = "-";
                    infoDisplayLogViewModel.ActionPage = "-";
                    infoDisplayLogViewModel.ActionType = "-";
                    infoDisplayLogViewModels.Add(infoDisplayLogViewModel);

                }

                return View(infoDisplayLogViewModels);
            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to show special remark summary";

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "DisplayVisitsLog", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));


                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);
            }
        }

        public ActionResult DisplayPeronalLog(string scn)
        {
            try
            {
                var infoDisplayLogViewModels = new List<InfoDisplayLogViewModel>();

                infoDisplayLogViewModels = GetActionPeronalLog(scn).Result;

                if (infoDisplayLogViewModels.Count == 0)
                {
                    var infoDisplayLogViewModel = new InfoDisplayLogViewModel();
                    infoDisplayLogViewModel.scn = scn;
                    infoDisplayLogViewModel.doc = "-";
                    infoDisplayLogViewModel.ActionDetail = "-";
                    infoDisplayLogViewModel.ActionPage = "-";
                    infoDisplayLogViewModel.ActionType = "-";
                    infoDisplayLogViewModels.Add(infoDisplayLogViewModel);
                }

                return View(infoDisplayLogViewModels);
            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to show special remark summary";

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "DisplayPeronalLog", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));


                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);
            }
        }


        public ActionResult InitAssess(string scn)
        {
            if (!IsLogin())
            {
                return RedirectToReLoginPage();
            }


            try
            {
                var infoBarViewModel = GetInfoBarViewModels(scn);

                var initialAssessmentViewModel = new InitAssessViewModel();

                var infoInitialAssessmentViewModel = new InfoInitAssessViewModel();

                var initAssessViewModel = GetInitialAssessment(scn).Result;

                if (initAssessViewModel == null)
                {

                    var initAssessViewModelTemp = new InitAssessViewModel();
                    infoInitialAssessmentViewModel = initAssessViewModelTemp.GetInitInfoInitAssessViewModel();
                    infoInitialAssessmentViewModel.SCN = scn;

                }
                else
                {
                    infoInitialAssessmentViewModel = (InfoInitAssessViewModel)initAssessViewModel;
                }


                var tupleModel = new Tuple<InfoBarViewModel, InfoInitAssessViewModel>(infoBarViewModel, infoInitialAssessmentViewModel);

                return View(tupleModel);
            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to Get Record Summary";

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "InitAssess", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));


                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);
            }
        }

        private async Task<InitAssessViewModel> GetInitialAssessment(string scn)
        {
            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/InitAssesss/" + scn;

            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(baseAddress + link);

            response.EnsureSuccessStatusCode();
            var stringResult = await response.Content.ReadAsStringAsync();
            ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
            var infoInitialAssessmentViewModels = JsonConvert.DeserializeObject<List<InitAssessViewModel>>(resultModel.Data.ToString());

            return infoInitialAssessmentViewModels.FirstOrDefault();
        }

        private bool HasInitAssessViewModel(string scn)
        {
            var initAssessViewModel = GetInitialAssessment(scn).Result;

            if (initAssessViewModel == null)
                return false;

            return true;
        }

        [HttpPost]
        public ActionResult InitAssess(InfoBarViewModel infoBarViewModel, InfoInitAssessViewModel infoInitAssessViewModel)
        {

            var scn = infoInitAssessViewModel.SCN;
            var infoBarViewModel1 = GetInfoBarViewModels(scn);

            try
            {

                var result = "";

                Tuple<InfoBarViewModel, InfoInitAssessViewModel> tupleModel;
                ResultModel resultModel;

                try
                {
                    var initAssessViewModel = (InitAssessViewModel)infoInitAssessViewModel;


                    if (HasInitAssessViewModel(scn))
                    {
                        resultModel = UpdateInitAssesAPI(initAssessViewModel);
                        result = "Update";
                    }
                    else
                    {
                        resultModel = InsertInitAssesAPI(initAssessViewModel);
                        result = "Create";
                    }


                    if (resultModel.IsSuccess)
                    {
                        tupleModel = new Tuple<InfoBarViewModel, InfoInitAssessViewModel>(infoBarViewModel1, (InfoInitAssessViewModel)initAssessViewModel);
                        SetSessionMessage(result + " Success");
                        InsertActionLog(result, result + " InitAssess", scn, "1900-01-01", HttpContext.Session.GetString("_userId"), "InitAssess");

                        return View(tupleModel);
                    }
                    else
                    {

                        SetSessionMessage(resultModel.Message);
                    }
                }
                catch (Exception ex1)
                {
                    SetSessionMessage(ex1.Message);
                }

                tupleModel = new Tuple<InfoBarViewModel, InfoInitAssessViewModel>(infoBarViewModel1, infoInitAssessViewModel);
                return View(tupleModel);

            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Message = " + ex.Message;

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "InitAssess POST", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));


                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }
        }

        private ResultModel UpdateInitAssesAPI(InitAssessViewModel initAssessViewModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/InitAssesss/" + initAssessViewModel.SCN;
            var client1 = new HttpClient();

            string content = JsonConvert.SerializeObject(initAssessViewModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = client1.PutAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;
        }

        private ResultModel InsertInitAssesAPI(InitAssessViewModel initAssessViewModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/InitAssesss/" + initAssessViewModel.SCN;
            var client1 = new HttpClient();

            string content = JsonConvert.SerializeObject(initAssessViewModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = client1.PostAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;
        }



        private bool IsLogin()
        {
            if (HttpContext.Session.GetString("_userId") == "" || HttpContext.Session.GetString("_userId") is null)
            {
                return false;
            }
            return true;
        }

        private ActionResult RedirectToReLoginPage()
        {
            var directAction = "../Identity/Account/Login";
            return RedirectToAction(directAction);
        }

        private ErrorLogViewModel SetErrorLogViewModel(string guid, string page, string exceptionalMessage, string innerExceptionMessage, string createdBy)
        {
            var errorLogViewModel = new ErrorLogViewModel();
            errorLogViewModel.Guid = guid;
            errorLogViewModel.Page = page;
            errorLogViewModel.ExceptionalMessage = exceptionalMessage;
            errorLogViewModel.InnerExceptionMessage = innerExceptionMessage;
            errorLogViewModel.CreatedBy = createdBy;
            errorLogViewModel.CreatedDate = DateTime.Now;

            return errorLogViewModel;
        }

        private ResultModel InsertErrorLog(ErrorLogViewModel errorLogViewModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/ErrorLogs";
            var client1 = new HttpClient();

            string content = JsonConvert.SerializeObject(errorLogViewModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = client1.PostAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;
        }


        //public ActionResult Visit(string scn, string dob, string isDelete)
        //{
        //    var infoBarViewModel = GetInfoBarViewModels(scn);
        //    var infoVisitModel = GetinfoVisitModel(scn, ConvertUrlDateForm(dob)).Result;

        //    var visitModel = (VisitsModel)infoVisitModel;

        //    var tupleModel = new Tuple<InfoVisitModel, InfoBarViewModel>(infoVisitModel, infoBarViewModel);
        //    return View(tupleModel);
        //}


        public ActionResult VisitDelete(string scn, string doc)
        {
            try
            {
                var infoVisitModel = GetinfoVisitModel(scn, ConvertUrlDateForm(doc)).Result;
                var visitModel = (VisitsModel)infoVisitModel;

                InsertVisitsLogAPI(visitModel, Action.Delete);
                DeleteVisitAPI(visitModel);

            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Message = " + ex.Message;

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Visit POST", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }

            return RedirectToAction("./VisitList", new { scn = scn });

        }


        public ActionResult PersonalDelete(string scn)
        {
            try
            {
                var perosnalInfo = GetPersonalInfoModel(scn).Result;

                InsertPersonalInfoLogAPI(perosnalInfo, Action.Delete);
                DeletePersonalInfoAPI(perosnalInfo);

            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Message = " + ex.Message;

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Visit POST", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }

            return RedirectToAction("../home/index");

        }

        private ResultModel DeleteVisitAPI(VisitsModel visitsModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();


            var link = $"/api/Visits/" + visitsModel.SCN + "/" + visitsModel.DOC.Value.ToString("yyyy-MM-dd");
            var client1 = new HttpClient();

            var visitsDeleteLogViewModel = (VisitsLogViewModel)visitsModel;
            visitsDeleteLogViewModel.CreatedDate = DateTime.Now;
            visitsDeleteLogViewModel.CreatedBy = HttpContext.Session.GetString("_userId").ToString();


            string content = JsonConvert.SerializeObject(visitsDeleteLogViewModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = client1.DeleteAsync(baseAddress + link).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;
        }

        private ResultModel DeletePersonalInfoAPI(PersonalInfoModel personalInfo)
        {

            var baseAddress = "Http://" + Request.Host.ToString();


            var link = $"/api/PersonalInfos/" + personalInfo.SCN;
            var client1 = new HttpClient();

            HttpResponseMessage response = client1.DeleteAsync(baseAddress + link).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;
        }

        private enum Action
        {
            Insert,
            Update,
            Delete
        }

        private ResultModel InsertVisitsLogAPI(VisitsModel visitsModel, Action action)
        {

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/VisitsLogs";
            var client1 = new HttpClient();

            var visitsDeleteLogViewModel = (VisitsLogViewModel)visitsModel;
            visitsDeleteLogViewModel.CreatedDate = DateTime.Now;
            visitsDeleteLogViewModel.CreatedBy = HttpContext.Session.GetString("_userId").ToString();
            visitsDeleteLogViewModel.Action = action.ToString();

            string content = JsonConvert.SerializeObject(visitsDeleteLogViewModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = client1.PostAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;
        }


        private ResultModel InsertPersonalInfoLogAPI(PersonalInfoModel personalInfoModel, Action action)
        {

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/PersonalInfoLogs";
            var client1 = new HttpClient();

            var personalInfoViewModel = (PersonalInfoLogViewModel)personalInfoModel;

            personalInfoViewModel.CreatedDate = DateTime.Now;
            personalInfoViewModel.CreatedBy = HttpContext.Session.GetString("_userId").ToString();
            personalInfoViewModel.Action = action.ToString();

            string content = JsonConvert.SerializeObject(personalInfoViewModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = client1.PostAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;
        }


        public ActionResult OperativeDataList(string scn)
        {
            try
            {

                if (!IsLogin())
                {
                    return RedirectToReLoginPage();
                }

                var baseAddress = "Http://" + Request.Host.ToString();
                var link = $"/api/OperativeDatas/" + scn;
                var infoBarViewModel = GetInfoBarViewModels(scn);
                var client = new HttpClient();

                ResetSubmitSession();

                HttpResponseMessage response = client.GetAsync(baseAddress + link).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                var stringResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
                var operativeDatas = JsonConvert.DeserializeObject<List<OperativeDataViewModel>>(resultModel.Data.ToString());

                var operativeDataLists = new List<InfoOperativeDataListViewModel>();

                foreach (var operativeData in operativeDatas)
                {
                    operativeDataLists.Add((InfoOperativeDataListViewModel)operativeData);
                }

                var tupleModel = new Tuple<InfoBarViewModel, List<InfoOperativeDataListViewModel>>(infoBarViewModel, operativeDataLists);

                return View(tupleModel);
            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to Search Recrod";

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Search", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }
        }

        public ActionResult OperativeData(string scn, string recordId)
        {

            if (!IsLogin())
            {
                return RedirectToReLoginPage();
            }

            var infoOperativeDataViewModel = new InfoOperativeDataViewModel();
            Tuple<InfoBarViewModel, InfoOperativeDataViewModel> tupleModel;

            try
            {
                var infoBarViewModel = GetInfoBarViewModels(scn);
                if (recordId == "0")
                {
                    infoOperativeDataViewModel = new InfoOperativeDataViewModel().SetDefaultValue();
                    infoOperativeDataViewModel.SCN = scn;
                    infoOperativeDataViewModel.RecordID = (short)(int.Parse(recordId));
                }
                else
                {
                    infoOperativeDataViewModel = (InfoOperativeDataViewModel)GetOperativeData(scn, recordId);
                }
                tupleModel = new Tuple<InfoBarViewModel, InfoOperativeDataViewModel>(infoBarViewModel, infoOperativeDataViewModel);
                return View(tupleModel);
            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to Search Recrod";

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Search", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }
        }


        [HttpPost]
        public ActionResult OperativeData(InfoBarViewModel infoBarViewModel, InfoOperativeDataViewModel infoOperativeDataViewModel)
        {

            try
            {
                var result = "";
                var scn = infoOperativeDataViewModel.SCN;

                Tuple<InfoBarViewModel, InfoOperativeDataViewModel> tupleModel;
                ResultModel resultModel;
                var infoBarViewModel1 = GetInfoBarViewModels(scn);

                try
                {
                    var operativeDataViewModel = (OperativeDataViewModel)infoOperativeDataViewModel;

                    if (infoOperativeDataViewModel.RecordID == 0)
                    {
                        var newRecordId = GetLatestOperativeDataReordID(infoOperativeDataViewModel.SCN);
                        operativeDataViewModel.RecordID = (short)newRecordId;
                        result = "Create";
                        resultModel = InsertOperativeData(operativeDataViewModel);
                    }
                    else
                    {
                        result = "Udpate";
                        resultModel = UpdateOperativeData(operativeDataViewModel);
                    }


                    if (resultModel.IsSuccess)
                    {
                        var infoOperativeDataViewModel1 = (InfoOperativeDataViewModel)operativeDataViewModel;

                        tupleModel = new Tuple<InfoBarViewModel, InfoOperativeDataViewModel>(infoBarViewModel1, infoOperativeDataViewModel1);

                        SetSessionMessage(result + " Success");
                        InsertActionLog(result, result + " OperativeData", operativeDataViewModel.SCN, "1900-01-01", HttpContext.Session.GetString("_userId"), "OperativeData");

                        //var directAction = "OperativeData?scn=" + scn + "&recordId=" + operativeDataViewModel.RecordID;


                        var directAction = "OperativeData";

                        return RedirectToAction(directAction, new { scn = scn, recordId = operativeDataViewModel.RecordID });
                    }
                    else
                    {
                        SetSessionMessage(resultModel.Message);
                    }
                }
                catch (Exception ex1)
                {
                    SetSessionMessage(ex1.Message);
                    throw ex1;
                }

                InsertActionLog(result, result + " InitAssess", scn, "1900-01-01", HttpContext.Session.GetString("_userId"), "InitAssess");
                tupleModel = new Tuple<InfoBarViewModel, InfoOperativeDataViewModel>(infoBarViewModel1, infoOperativeDataViewModel);
                return View(tupleModel);

            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Message = " + ex.Message;

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "InitAssess POST", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));


                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }
        }

        private int GetLatestOperativeDataReordID(string scn)
        {

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/OperativeDatas/" + scn;
            //var infoBarViewModel = GetInfoBarViewModels(scn);
            var client = new HttpClient();

            HttpResponseMessage response = client.GetAsync(baseAddress + link).GetAwaiter().GetResult();
            response.EnsureSuccessStatusCode();
            var stringResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
            var operativeDatas = JsonConvert.DeserializeObject<List<OperativeDataViewModel>>(resultModel.Data.ToString());

            var lastOperativeData = operativeDatas.OrderByDescending(x => x.RecordID).FirstOrDefault();

            if (lastOperativeData == null)
                return 1;

            var lastOperativeRecordId = int.Parse(lastOperativeData.RecordID.ToString());

            return lastOperativeRecordId + 1;
        }

        private ResultModel UpdateOperativeData(OperativeDataViewModel operativeDataViewModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/OperativeDatas/" + operativeDataViewModel.SCN; ;
            var client1 = new HttpClient();

            string content = JsonConvert.SerializeObject(operativeDataViewModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = client1.PutAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;

        }

        private ResultModel InsertOperativeData(OperativeDataViewModel operativeDataViewModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/OperativeDatas/";
            var client1 = new HttpClient();

            string content = JsonConvert.SerializeObject(operativeDataViewModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = client1.PostAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;
        }


        private OperativeDataViewModel GetOperativeData(string scn, string recordId)
        {

            var operativeDatas = new List<OperativeDataViewModel>();
            var operativeData = new OperativeDataViewModel();

            try
            {
                var baseAddress = "Http://" + Request.Host.ToString();
                var link = $"/api/OperativeDatas/" + scn + "/" + recordId;
                var client = new HttpClient();

                HttpResponseMessage response = client.GetAsync(baseAddress + link).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                var stringResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
                operativeDatas = JsonConvert.DeserializeObject<List<OperativeDataViewModel>>(resultModel.Data.ToString());
                operativeData = operativeDatas.FirstOrDefault();
            }

            catch (Exception ex)
            {
                var gUIDNumner = Guid.NewGuid();

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Search", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));
            }

            return operativeData;
        }

        public ActionResult PrintPersonalInfo(string scn)
        {

            var printPersonalInfo = GetPrintPersonalInfoViewModel(scn);

            return View(printPersonalInfo);
        }


        private PrintPersonalInfoViewModel GetPrintPersonalInfoViewModel(string scn)
        {

            var printPersonalInfoViewModel = new PrintPersonalInfoViewModel();

            var peronsalInfo = GetPersonalInfoModel(scn).Result;

            printPersonalInfoViewModel.Name = IsNullReturnNA(peronsalInfo.Name);

            printPersonalInfoViewModel.SCN = IsNullReturnNA(peronsalInfo.SCN);

            printPersonalInfoViewModel.HKID = IsNullReturnNA(peronsalInfo.HKID);

            printPersonalInfoViewModel.AgeOnset = IsNullReturnNA(peronsalInfo.AgeOnset);

            printPersonalInfoViewModel.FamHis = IsNullReturnNA(peronsalInfo.FamHis);

            printPersonalInfoViewModel.AttnPhys = IsNullReturnNA(peronsalInfo.AttnPhys);

            printPersonalInfoViewModel.DOB = IsNullReturnNA(peronsalInfo.DOB);

            printPersonalInfoViewModel.HisOthers = IsNullReturnNA(peronsalInfo.HisOthers);

            printPersonalInfoViewModel.Sex = IsNullReturnNA(peronsalInfo.Sex);

            if (peronsalInfo.Diagnosis == 1)
            {
                printPersonalInfoViewModel.Diagnosis = "IS";
            }
            else if (peronsalInfo.Diagnosis == 2)
            {
                printPersonalInfoViewModel.Diagnosis = "CS";
            }
            else if (peronsalInfo.Diagnosis == 3)
            {
                printPersonalInfoViewModel.Diagnosis = "NM";
            }
            else if (peronsalInfo.Diagnosis == 3)
            {
                printPersonalInfoViewModel.Diagnosis = "Misc";
            }
            else
            {
                printPersonalInfoViewModel.Diagnosis = "";
            }

            //isKing
            if (peronsalInfo.isKingI)
            {
                printPersonalInfoViewModel.King = "I";
            }

            if (peronsalInfo.isKingII)
            {
                printPersonalInfoViewModel.King += "II";
            }

            if (peronsalInfo.isKingIII)
            {
                printPersonalInfoViewModel.King += "III";
            }

            if (peronsalInfo.isKingIV)
            {
                printPersonalInfoViewModel.King += "IV";
            }

            if (peronsalInfo.isKingV)
            {
                printPersonalInfoViewModel.King += "V";
            }

            if (peronsalInfo.isIso)
            {
                printPersonalInfoViewModel.King += "Isolated";

                if (peronsalInfo.isTL)
                    printPersonalInfoViewModel.King += ", T-L";

                if (peronsalInfo.isL)
                    printPersonalInfoViewModel.King += ", L";
            }

            if (peronsalInfo.isTriple)
            {
                printPersonalInfoViewModel.King = "Triple curve";
            }

            printPersonalInfoViewModel.ADCA = IsNullReturnNA(peronsalInfo.ADCA);

            printPersonalInfoViewModel.Surgeons = IsNullReturnNA(peronsalInfo.Surgeons);

            if (peronsalInfo.isUnderArm)
            {
                printPersonalInfoViewModel.isUnderArm = "Under Arm<br>";
            }

            if (peronsalInfo.isMilwaukes)
            {
                printPersonalInfoViewModel.isMilwaukes = "Milwaukes<br>";
            }

            if (peronsalInfo.isBoston)
            {
                printPersonalInfoViewModel.isBoston = "Boston<br>";
            }

            if (peronsalInfo.isBraceOthers)
            {
                printPersonalInfoViewModel.isBoston = "Others: " + IsNullReturnNA(peronsalInfo.BraceOthers) + "<br>";
            }

            printPersonalInfoViewModel.BraceStart = IsNullReturnNA(peronsalInfo.BraceStart);

            printPersonalInfoViewModel.BraceWean = IsNullReturnNA(peronsalInfo.BraceWean);

            printPersonalInfoViewModel.BraceStop = IsNullReturnNA(peronsalInfo.BraceStop);

            printPersonalInfoViewModel.ASF = IsNullReturnNA(peronsalInfo.ASF);

            printPersonalInfoViewModel.PSF = IsNullReturnNA(peronsalInfo.PSF);

            printPersonalInfoViewModel.ASFPSF = IsNullReturnNA(peronsalInfo.ASFPSF);

            printPersonalInfoViewModel.ThoRelease = IsNullReturnNA(peronsalInfo.ThoRelease);

            printPersonalInfoViewModel.OtherSurgery = IsNullReturnNA(peronsalInfo.otherSurgery);

            printPersonalInfoViewModel.OtherSurgery = IsNullReturnNA(peronsalInfo.LOFfrom);

            printPersonalInfoViewModel.OtherSurgery = IsNullReturnNA(peronsalInfo.LOFto);

            var gcount = 0;
            if (peronsalInfo.isAuto)
            {
                printPersonalInfoViewModel.Grafts = "Auto";
            }

            if (peronsalInfo.isAllo)
            {
                if (gcount > 0)
                {
                    printPersonalInfoViewModel.Grafts = " ,";
                }
                printPersonalInfoViewModel.Grafts = "Allo";
                gcount += 1;
            }

            if (peronsalInfo.isGraOthers)
            {
                if (gcount > 0)
                {
                    printPersonalInfoViewModel.Grafts = " ,";
                }
                printPersonalInfoViewModel.Grafts = "Others";
                gcount += 1;
            }

            if (gcount == 0)
                printPersonalInfoViewModel.Grafts = "N/A";


            //Posterior

            if (peronsalInfo.isPosISOLA == false && peronsalInfo.isPostHarr == false && peronsalInfo.isPostCD == false && peronsalInfo.isPostOthers == false)
            {
                printPersonalInfoViewModel.Posterior = "N/A";
            }
            else
            {

                if (peronsalInfo.isPosISOLA)
                {
                    printPersonalInfoViewModel.Posterior = "ISOLA<br>";
                }

                if (peronsalInfo.isPostHarr)
                {
                    printPersonalInfoViewModel.Posterior += "Harrington+ww<br>";
                }

                if (peronsalInfo.isPostCD)
                {
                    printPersonalInfoViewModel.Posterior += "CD<br>";
                }

                if (peronsalInfo.isPostOthers)
                {
                    printPersonalInfoViewModel.Posterior += "Others";
                }
            }

            if (peronsalInfo.isAntZielke == false && peronsalInfo.isAntISOLA == false && peronsalInfo.isAntOthers == false)
            {
                printPersonalInfoViewModel.Anterior = "N/A";
            }
            else
            {

                if (peronsalInfo.isAntZielke)
                {
                    printPersonalInfoViewModel.Anterior = "Zielke<br>";
                }

                if (peronsalInfo.isAntISOLA)
                {
                    printPersonalInfoViewModel.Anterior += "ISOLA<br>";
                }

                if (peronsalInfo.isAntOthers)
                {
                    printPersonalInfoViewModel.Anterior += "Others<br>";
                }

            }

            printPersonalInfoViewModel.OtherImplant = IsNullReturnNA(peronsalInfo.otherImplant);

            printPersonalInfoViewModel.PostOPStart = IsNullReturnNA(peronsalInfo.PostOPStart);

            printPersonalInfoViewModel.PostOPWean = IsNullReturnNA(peronsalInfo.PostOPWean);

            printPersonalInfoViewModel.PostOPStop = IsNullReturnNA(peronsalInfo.PostOPStop);

            printPersonalInfoViewModel.isXrayfilm = IsNullReturnNA(peronsalInfo.isXrayfilm);

            printPersonalInfoViewModel.isMRI = IsNullReturnNA(peronsalInfo.isMRI);

            printPersonalInfoViewModel.isDXA = IsNullReturnNA(peronsalInfo.isDXA);

            printPersonalInfoViewModel.isUS = IsNullReturnNA(peronsalInfo.isUS);

            printPersonalInfoViewModel.isPQCT = IsNullReturnNA(peronsalInfo.isPQCT);

            printPersonalInfoViewModel.isCTscan = IsNullReturnNA(peronsalInfo.isCTscan);

            printPersonalInfoViewModel.isBioChem = IsNullReturnNA(peronsalInfo.isBioChem);

            printPersonalInfoViewModel.isQCT = IsNullReturnNA(peronsalInfo.isQCT);

            printPersonalInfoViewModel.isSSEP = IsNullReturnNA(peronsalInfo.isSSEP);
            printPersonalInfoViewModel.isEMG = IsNullReturnNA(peronsalInfo.isEMG);

            printPersonalInfoViewModel.OtherInvest = IsNullReturnNA(peronsalInfo.OtherInvest);

            printPersonalInfoViewModel.Comments = IsNullReturnNA(peronsalInfo.Comments);

            printPersonalInfoViewModel.Today = DateTime.Now.ToString("dd/MM/yyyy");

            var userId = HttpContext.Session.GetString("_userId");

            if (userId == null)
            {
                printPersonalInfoViewModel.UserId = "";
            }
            else
            {
                printPersonalInfoViewModel.UserId = HttpContext.Session.GetString("_userId").ToString();
            }

            return printPersonalInfoViewModel;

        }

        private string IsNullReturnNA(bool boolean)
        {

            if (boolean == true)
                return "True";

            return "False";

        }

        private string IsNullReturnNA(DateTime? dt)
        {
            if (dt == null)
                return "N/A";

            return dt.Value.ToString("dd/MM/yyyy");
        }

        private string IsNullReturnNA(Double? db)
        {
            if (db == null)
                return "N/A";

            return db.Value.ToString();
        }


        private string IsNullReturnNA(string str)
        {

            if (string.IsNullOrEmpty(str))
                return "N/A";

            return str;
        }

        public ActionResult PrintVisitInfo(string scn, string doc)
        {
            var printVisitInfo = GetPrintVisitInfoViewModel(scn, doc);

            return View(printVisitInfo);
        }

        private PrintVisitInfoViewModel GetPrintVisitInfoViewModel(string scn, string dob)
        {
            var infoPersonalViewModel = (InfoPersonalInfoViewModel)GetPersonalInfoModel(scn).Result;

            var infoVisitModel = GetinfoVisitModel(scn, dob).Result;

            var printVisitInfoViewModel = new PrintVisitInfoViewModel();

            printVisitInfoViewModel.scn = infoVisitModel.SCN;
            printVisitInfoViewModel.dob = infoVisitModel.DOC;

            printVisitInfoViewModel.hkid = infoPersonalViewModel.HKID;

            printVisitInfoViewModel.oriDate = infoVisitModel.DOC;

            printVisitInfoViewModel.name = infoPersonalViewModel.Name;


            printVisitInfoViewModel.virtualView = infoVisitModel.Virtual;

            printVisitInfoViewModel.HT = infoVisitModel.HT;

            printVisitInfoViewModel.armSpan = infoVisitModel.ArmSpan;

            printVisitInfoViewModel.wt = infoVisitModel.WT;

            printVisitInfoViewModel.isMenarchePos = infoVisitModel.isMenarchePos;

            printVisitInfoViewModel.isMenarcheNeg = infoVisitModel.isMenarcheNeg;

            printVisitInfoViewModel.MaturYear = infoVisitModel.MaturYear.ToString();

            printVisitInfoViewModel.MaturMonth = infoVisitModel.MaturMonth.ToString();

            printVisitInfoViewModel.Jointhyper = infoVisitModel.Jointhyper;

            printVisitInfoViewModel.AbdReflexA = infoVisitModel.AbdReflexA;

            printVisitInfoViewModel.AbdReflexB = infoVisitModel.AbdReflexB;

            printVisitInfoViewModel.AbdReflexC = infoVisitModel.AbdReflexC;

            printVisitInfoViewModel.AbdReflexD = infoVisitModel.AbdReflexD;

            printVisitInfoViewModel.CTrunkShiftDir = infoVisitModel.CTrunkShiftDir.ToString();

            if (infoVisitModel.CTrunkShiftDir.ToString() == "" || infoVisitModel.CTrunkShiftDir.ToString() == "\0")
            {
                printVisitInfoViewModel.CTrunkShiftDir = "";
            }
            else
            {
                printVisitInfoViewModel.CTrunkShiftDir = infoVisitModel.CTrunkShiftDir.ToString();
            }



            printVisitInfoViewModel.BreastTanner = infoVisitModel.BreastTanner;

            printVisitInfoViewModel.PubicTanner = infoVisitModel.PubicTanner;

            printVisitInfoViewModel.hair = infoVisitModel.hair;

            printVisitInfoViewModel.CTrunkShift = infoVisitModel.CTrunkShift.ToString();


            printVisitInfoViewModel.R1Dir = infoVisitModel.R1Dir;
            printVisitInfoViewModel.Rotat1 = infoVisitModel.Rotat1.ToString();
            printVisitInfoViewModel.R2Dir = infoVisitModel.R2Dir;
            printVisitInfoViewModel.Rotat2 = infoVisitModel.Rotat2.ToString();
            printVisitInfoViewModel.R3Dir = infoVisitModel.R3Dir;
            printVisitInfoViewModel.Rotat3 = infoVisitModel.Rotat3.ToString();
            printVisitInfoViewModel.R4Dir = infoVisitModel.R4Dir;
            printVisitInfoViewModel.Rotat4 = infoVisitModel.Rotat4.ToString();
            printVisitInfoViewModel.ShoulderAsy = infoVisitModel.ShoulderAsy.ToString();

            printVisitInfoViewModel.tricart = infoVisitModel.tricart;
            printVisitInfoViewModel.trochanter = infoVisitModel.trochanter;
            printVisitInfoViewModel.FemoralHead = infoVisitModel.FemoralHead;
            printVisitInfoViewModel.withBrace = (short)infoVisitModel.withBrace;
            printVisitInfoViewModel.CurveLevel1From = infoVisitModel.CurveLevel1From;
            printVisitInfoViewModel.CurveLevel1To = infoVisitModel.CurveLevel1To;
            printVisitInfoViewModel.CurveLevel2From = infoVisitModel.CurveLevel2From;
            printVisitInfoViewModel.CurveLevel2To = infoVisitModel.CurveLevel2To;
            printVisitInfoViewModel.CurveLevel3From = infoVisitModel.CurveLevel3From;
            printVisitInfoViewModel.CurveLevel3To = infoVisitModel.CurveLevel3To;
            printVisitInfoViewModel.CurveLevel4From = infoVisitModel.CurveLevel4From;
            printVisitInfoViewModel.CurveLevel4To = infoVisitModel.CurveLevel4To;
            printVisitInfoViewModel.CurveApex1 = infoVisitModel.CurveApex1;
            printVisitInfoViewModel.CurveApex2 = infoVisitModel.CurveApex2;
            printVisitInfoViewModel.CurveApex3 = infoVisitModel.CurveApex3;
            printVisitInfoViewModel.CurveApex4 = infoVisitModel.CurveApex4;

            if (infoVisitModel.AVTDir1.ToString() == "" || infoVisitModel.AVTDir1.ToString() == "\0")
            {
                printVisitInfoViewModel.AVTDir1 = "";
            }
            else
            {
                printVisitInfoViewModel.AVTDir1 = infoVisitModel.AVTDir1.ToString();
            }

            if (infoVisitModel.AVTDir2.ToString() == "" || infoVisitModel.AVTDir2.ToString() == "\0")
            {
                printVisitInfoViewModel.AVTDir2 = "";
            }
            else
            {
                printVisitInfoViewModel.AVTDir2 = infoVisitModel.AVTDir2.ToString();
            }

            if (infoVisitModel.AVTDir3.ToString() == "" || infoVisitModel.AVTDir3.ToString() == "\0")
            {
                printVisitInfoViewModel.AVTDir3 = "";
            }
            else
            {
                printVisitInfoViewModel.AVTDir3 = infoVisitModel.AVTDir3.ToString();
            }


            if (infoVisitModel.AVTDir4.ToString() == "" || infoVisitModel.AVTDir4.ToString() == "\0")
            {
                printVisitInfoViewModel.AVTDir4 = "";
            }
            else
            {
                printVisitInfoViewModel.AVTDir4 = infoVisitModel.AVTDir4.ToString();
            }


            printVisitInfoViewModel.AVTDeg1 = infoVisitModel.AVTDeg1.ToString();
            printVisitInfoViewModel.AVTDeg2 = infoVisitModel.AVTDeg2.ToString();
            printVisitInfoViewModel.AVTDeg3 = infoVisitModel.AVTDeg3.ToString();
            printVisitInfoViewModel.AVTDeg4 = infoVisitModel.AVTDeg4.ToString();
            printVisitInfoViewModel.CurveDir1 = infoVisitModel.CurveDir1;
            printVisitInfoViewModel.CurveDir2 = infoVisitModel.CurveDir2;
            printVisitInfoViewModel.CurveDir3 = infoVisitModel.CurveDir3;
            printVisitInfoViewModel.CurveDir4 = infoVisitModel.CurveDir4;
            printVisitInfoViewModel.ApicalDir1 = infoVisitModel.ApicalDir1;
            printVisitInfoViewModel.ApicalDir2 = infoVisitModel.ApicalDir2;
            printVisitInfoViewModel.ApicalDir3 = infoVisitModel.ApicalDir3;
            printVisitInfoViewModel.ApicalDir4 = infoVisitModel.ApicalDir4;
            printVisitInfoViewModel.withBraceS = (short)infoVisitModel.withBraceS;
            printVisitInfoViewModel.CurveLevel1FromS = infoVisitModel.CurveLevel1FromS;
            printVisitInfoViewModel.CurveLevel1ToS = infoVisitModel.CurveLevel1ToS;
            printVisitInfoViewModel.CurveLevel2FromS = infoVisitModel.CurveLevel2FromS;
            printVisitInfoViewModel.CurveLevel2ToS = infoVisitModel.CurveLevel2ToS;
            printVisitInfoViewModel.CurveLevel3FromS = infoVisitModel.CurveLevel3FromS;
            printVisitInfoViewModel.CurveLevel3ToS = infoVisitModel.CurveLevel3ToS;
            printVisitInfoViewModel.CurveLevel4FromS = infoVisitModel.CurveLevel4FromS;
            printVisitInfoViewModel.CurveLevel4ToS = infoVisitModel.CurveLevel4ToS;
            printVisitInfoViewModel.CurveDir1S = infoVisitModel.CurveDir1S;
            printVisitInfoViewModel.CurveDir2S = infoVisitModel.CurveDir2S;
            printVisitInfoViewModel.CurveDir3S = infoVisitModel.CurveDir3S;
            printVisitInfoViewModel.CurveDir4S = infoVisitModel.CurveDir4S;
            printVisitInfoViewModel.CurveApex1S = infoVisitModel.CurveApex1S;
            printVisitInfoViewModel.CurveApex2S = infoVisitModel.CurveApex2S;
            printVisitInfoViewModel.CurveApex3S = infoVisitModel.CurveApex3S;
            printVisitInfoViewModel.CurveApex4S = infoVisitModel.CurveApex4S;
            printVisitInfoViewModel.CurveDeg1S = infoVisitModel.CurveDeg1S.ToString(); ;
            printVisitInfoViewModel.CurveDeg2S = infoVisitModel.CurveDeg2S.ToString(); ;
            printVisitInfoViewModel.CurveDeg3S = infoVisitModel.CurveDeg3S.ToString(); ;
            printVisitInfoViewModel.CurveDeg4S = infoVisitModel.CurveDeg4S.ToString();

            printVisitInfoViewModel.Thoracictype = infoVisitModel.Thoracictype.ToString();


            printVisitInfoViewModel.Lumbartype = infoVisitModel.Lumbartype.ToString();


            printVisitInfoViewModel.CurveDeg1 = infoVisitModel.CurveDeg1.ToString();
            printVisitInfoViewModel.CurveDeg2 = infoVisitModel.CurveDeg2.ToString();
            printVisitInfoViewModel.CurveDeg3 = infoVisitModel.CurveDeg3.ToString();
            printVisitInfoViewModel.CurveDeg4 = infoVisitModel.CurveDeg4.ToString();

            printVisitInfoViewModel.TrunkDir = infoVisitModel.TrunkDir;

            printVisitInfoViewModel.RTrunkShift = infoVisitModel.RTrunkShift.ToString(); ;
            printVisitInfoViewModel.ApicalRotation1 = infoVisitModel.ApicalRotation1;
            printVisitInfoViewModel.ApicalRotation2 = infoVisitModel.ApicalRotation2;
            printVisitInfoViewModel.ApicalRotation3 = infoVisitModel.ApicalRotation3;
            printVisitInfoViewModel.ApicalRotation4 = infoVisitModel.ApicalRotation4;
            printVisitInfoViewModel.RSign = infoVisitModel.RSign;
            printVisitInfoViewModel.EpFusion = infoVisitModel.EpFusion;
            printVisitInfoViewModel.ThoKyphosis = infoVisitModel.ThoKyphosis.ToString(); ;

            printVisitInfoViewModel.LumLordosis = infoVisitModel.LumLordosis.ToString(); ;
            printVisitInfoViewModel.PlanObs = infoVisitModel.PlanObs;
            printVisitInfoViewModel.PlanBrace = infoVisitModel.PlanBrace;
            printVisitInfoViewModel.PlanBraceWeanTime = infoVisitModel.PlanBraceWeanTime;
            printVisitInfoViewModel.PlanFUYear = infoVisitModel.PlanFUYear.ToString(); ;
            printVisitInfoViewModel.PlanFUMonth = infoVisitModel.PlanFUMonth.ToString(); ;
            printVisitInfoViewModel.PlanFUWeek = infoVisitModel.PlanFUWeek.ToString(); ;

            printVisitInfoViewModel.AfterBracing = infoVisitModel.AfterBracing;

            printVisitInfoViewModel.PRN = infoVisitModel.PRN;



            printVisitInfoViewModel.PlanXray = infoVisitModel.PlanXray;
            printVisitInfoViewModel.PlanSurgery = infoVisitModel.PlanSurgery;
            printVisitInfoViewModel.DrName = infoVisitModel.DrName;
            printVisitInfoViewModel.SpcRemarks = infoVisitModel.SpcRemarks;

            printVisitInfoViewModel.Today = DateTime.Now.ToString("dd/MM/yyyy");

            var userId = HttpContext.Session.GetString("_userId");

            if (userId == null)
            {
                printVisitInfoViewModel.UserId = "";
            }
            else
            {
                printVisitInfoViewModel.UserId = HttpContext.Session.GetString("_userId").ToString();
            }

            return printVisitInfoViewModel;

        }



        public ActionResult PrintReplySlip(string scn, string doc)
        {
            var printReplySlipViewModel = GetPrintReplySlipViewModel(scn, doc);

            return View(printReplySlipViewModel);
        }

        private PrintReplySlipViewModel GetPrintReplySlipViewModel(string scn, string dob)
        {
            var infoPersonalViewModel = (InfoPersonalInfoViewModel)GetPersonalInfoModel(scn).Result;

            var infoVisitsModels = GetinfoVisitModel(scn, dob).Result;

            var printReplySlipViewModel = new PrintReplySlipViewModel();

            printReplySlipViewModel.Date = infoVisitsModels.DOC;

            printReplySlipViewModel.Name = infoPersonalViewModel.Name;

            if (infoPersonalViewModel.Sex == null)
                printReplySlipViewModel.Sex = "";
            else if (infoPersonalViewModel.Sex == "1")
                printReplySlipViewModel.Sex = "Male";
            else if (infoPersonalViewModel.Sex == "2")
                printReplySlipViewModel.Sex = "Famle";

            printReplySlipViewModel.DOB = infoPersonalViewModel.DOB;

            printReplySlipViewModel.CurveLevel1From = infoVisitsModels.CurveLevel1From;

            printReplySlipViewModel.CurveLevel1To = infoVisitsModels.CurveLevel1To;

            printReplySlipViewModel.CurveLevel2From = infoVisitsModels.CurveLevel2From;

            printReplySlipViewModel.CurveLevel2To = infoVisitsModels.CurveLevel2To;

            printReplySlipViewModel.CurveLevel3From = infoVisitsModels.CurveLevel3From;

            printReplySlipViewModel.CurveLevel3To = infoVisitsModels.CurveLevel3To;

            printReplySlipViewModel.CurveLevel4From = infoVisitsModels.CurveLevel4From;

            printReplySlipViewModel.CurveLevel4To = infoVisitsModels.CurveLevel4To;

            printReplySlipViewModel.CurveApex1 = infoVisitsModels.CurveApex1;

            printReplySlipViewModel.CurveApex2 = infoVisitsModels.CurveApex2;

            printReplySlipViewModel.CurveApex3 = infoVisitsModels.CurveApex3;

            printReplySlipViewModel.CurveApex4 = infoVisitsModels.CurveApex4;

            printReplySlipViewModel.CurveDir1 = infoVisitsModels.CurveDir1;

            printReplySlipViewModel.CurveDir2 = infoVisitsModels.CurveDir2;

            printReplySlipViewModel.CurveDir3 = infoVisitsModels.CurveDir3;

            printReplySlipViewModel.CurveDir4 = infoVisitsModels.CurveDir4;

            printReplySlipViewModel.CurveDeg1 = infoVisitsModels.CurveDeg1.ToString();
            printReplySlipViewModel.CurveDeg2 = infoVisitsModels.CurveDeg2.ToString();

            printReplySlipViewModel.CurveDeg3 = infoVisitsModels.CurveDeg3.ToString();

            printReplySlipViewModel.CurveDeg4 = infoVisitsModels.CurveDeg4.ToString();

            printReplySlipViewModel.SpcRemarks = infoVisitsModels.SpcRemarks;

            printReplySlipViewModel.Dr = "";

            printReplySlipViewModel.TodayDate = DateTime.Now.ToString("dd/MM/yyyy");


            return printReplySlipViewModel;

        }


        [HttpPost]
        public ActionResult UserSupplementAdmin(UsersSupplementViewModel usersSupplementViewModel)
        {

            var result = "";
            ResultModel resultModel;

            try
            {

                usersSupplementViewModel.ModifiedBy = HttpContext.Session.GetString("_userId");


                if (HasUsersSupplement(usersSupplementViewModel.UserId))
                {
                    usersSupplementViewModel.CreatedBy = HttpContext.Session.GetString("_userId");
                    resultModel = UpdateUsersSupplement(usersSupplementViewModel);
                    result = "Update";
                }
                else
                {
                    resultModel = InsertUsersSupplement(usersSupplementViewModel);
                    result = "Create";
                }


                if (resultModel.IsSuccess)
                {

                    SetSessionMessage(result + " Success");
                    InsertActionLog(result, result + " usersSupplement", "", "", HttpContext.Session.GetString("_userId"), "usersSupplement");

                    return View(usersSupplementViewModel);
                }
                else
                {
                    SetSessionMessage(resultModel.Message);
                }
            }
            catch (Exception ex1)
            {
                SetSessionMessage(ex1.Message);
            }

            return View(usersSupplementViewModel);
        }

        public ActionResult UserSupplementAdmin(string userId)
        {
            var UserSupplement = GetUserSupplement(userId);

            if (UserSupplement == null)
            {
                UserSupplement = new UsersSupplementViewModel();
                UserSupplement.UserId = userId;
            }

            if (UserSupplement.Role == null)
            {
                UserSupplement.Role = "Administrator";
            }

            return View(UserSupplement);

        }

        public ActionResult UserSupplement(string userId)
        {
            var UserSupplement = GetUserSupplement(userId);

            if (UserSupplement == null)
            {
                UserSupplement = new UsersSupplementViewModel();
                UserSupplement.UserId = userId;
            }

            if (UserSupplement.Role == null)
            {
                UserSupplement.Role = "Administrator";
            }

            return View(UserSupplement);

        }

        public ActionResult UserSupplementList()
        {
            var userSupplements = new List<UsersSupplementViewModel>();

            ResetSubmitSession();

            userSupplements = GetAllUserSupplement();

            return View(userSupplements);

        }

        public UsersSupplementViewModel GetUserSupplement(string userId)
        {

            var UserSupplements = new List<UsersSupplementViewModel>();
            var UserSupplement = new UsersSupplementViewModel();

            try
            {
                var baseAddress = "Http://" + Request.Host.ToString();
                var link = $"/api/UsersSupplements/" + userId + "/";
                var client = new HttpClient();

                HttpResponseMessage response = client.GetAsync(baseAddress + link).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                var stringResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
                UserSupplements = JsonConvert.DeserializeObject<List<UsersSupplementViewModel>>(resultModel.Data.ToString());
                UserSupplement = UserSupplements.FirstOrDefault();
            }

            catch (Exception ex)
            {
                var gUIDNumner = Guid.NewGuid();

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Search", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));
            }

            return UserSupplement;
        }

        public List<UsersSupplementViewModel> GetAllUserSupplement()
        {

            var UserSupplements = new List<UsersSupplementViewModel>();

            try
            {
                var baseAddress = "Http://" + Request.Host.ToString();
                var link = $"/api/UsersSupplements/";
                var client = new HttpClient();

                HttpResponseMessage response = client.GetAsync(baseAddress + link).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                var stringResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
                UserSupplements = JsonConvert.DeserializeObject<List<UsersSupplementViewModel>>(resultModel.Data.ToString());
            }

            catch (Exception ex)
            {
                var gUIDNumner = Guid.NewGuid();

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Search", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));
            }

            return UserSupplements;
        }




        [HttpPost]
        public ActionResult UserSupplement(UsersSupplementViewModel usersSupplementViewModel)
        {

            var result = "";
            ResultModel resultModel;

            try
            {

                usersSupplementViewModel.ModifiedBy = HttpContext.Session.GetString("_userId");


                if (HasUsersSupplement(usersSupplementViewModel.UserId))
                {
                    usersSupplementViewModel.CreatedBy = HttpContext.Session.GetString("_userId");
                    resultModel = UpdateUsersSupplement(usersSupplementViewModel);
                    result = "Update";
                }
                else
                {
                    resultModel = InsertUsersSupplement(usersSupplementViewModel);
                    result = "Create";
                }


                if (resultModel.IsSuccess)
                {

                    SetSessionMessage(result + " Success");
                    InsertActionLog(result, result + " usersSupplement", "", "", HttpContext.Session.GetString("_userId"), "usersSupplement");

                    return View(usersSupplementViewModel);
                }
                else
                {
                    SetSessionMessage(resultModel.Message);
                }
            }
            catch (Exception ex1)
            {
                SetSessionMessage(ex1.Message);
            }

            return View(usersSupplementViewModel);
        }

        private ResultModel UpdateUsersSupplement(UsersSupplementViewModel usersSupplementViewModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/UsersSupplements/";
            var client1 = new HttpClient();

            string content = JsonConvert.SerializeObject(usersSupplementViewModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = client1.PutAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;

        }

        private ResultModel InsertUsersSupplement(UsersSupplementViewModel usersSupplementViewModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/UsersSupplements/";
            var client1 = new HttpClient();

            usersSupplementViewModel.CreatedBy = HttpContext.Session.GetString("_userId");

            string content = JsonConvert.SerializeObject(usersSupplementViewModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = client1.PostAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;

        }
        private bool HasUsersSupplement(string userId)
        {
            var usersSupplement = GetUserSupplement(userId);

            if (usersSupplement == null)
                return false;

            return true;
        }

        public ActionResult RegisterSaveSuccess()
        {

            return View();
        }


        public ActionResult RegisterPage2(string userId, string role)
        {
            var UsersSupplementViewModel = new UsersSupplementViewModel();

            UsersSupplementViewModel.UserId = userId;
            UsersSupplementViewModel.Role = role;

            return View(UsersSupplementViewModel);
        }


        [HttpPost]
        public ActionResult RegisterPage2(UsersSupplementViewModel usersSupplementViewModel)
        {

            var result = "";
            ResultModel resultModel;

            try
            {
                usersSupplementViewModel.ModifiedBy = HttpContext.Session.GetString("_userId");


                if (HasUsersSupplement(usersSupplementViewModel.UserId))
                {
                    usersSupplementViewModel.CreatedBy = HttpContext.Session.GetString("_userId");
                    resultModel = UpdateUsersSupplement(usersSupplementViewModel);
                    result = "Update";
                }
                else
                {
                    usersSupplementViewModel.ModifiedBy = HttpContext.Session.GetString("_userId");
                    resultModel = InsertUsersSupplement(usersSupplementViewModel);
                    result = "Create";
                }


                if (resultModel.IsSuccess)
                {

                    SetSessionMessage(result + " Success");
                    InsertActionLog(result, result + " usersSupplement", "", "", HttpContext.Session.GetString("_userId"), "usersSupplement");

                    return View(usersSupplementViewModel);
                }
                else
                {
                    SetSessionMessage(resultModel.Message);
                }
            }
            catch (Exception ex1)
            {
                SetSessionMessage(ex1.Message);
            }

            return View(usersSupplementViewModel);
        }



        //private async Task<UsersSupplementViewModel> GetRegisterPage2(string userId)
        //{

        //    var baseAddress = "Http://" + Request.Host.ToString();
        //    var link = $"/api/UsersSupplements/" + userId;
        //    var client = new HttpClient();

        //    HttpResponseMessage response = await client.GetAsync(baseAddress + link);
        //    response.EnsureSuccessStatusCode();
        //    var stringResult = await response.Content.ReadAsStringAsync();
        //    ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
        //    var usersSupplementViewModels = JsonConvert.DeserializeObject<List<UsersSupplementViewModel>>(resultModel.Data.ToString());

        //    return usersSupplementViewModels.First();

        //}



        public ActionResult VisitPage(string scn, string dob)
        {

            if (!IsLogin())
            {
                return RedirectToReLoginPage();
            }

            if (HasVisit(scn, dob))
            {
                try
                {
                    var isCreatePage = HttpContext.Session.GetString("_isCreatePage");

                    HttpContext.Session.SetString("_isCreatePage", "false");

                    var infoBarViewModel = GetInfoBarViewModels(scn);
                    var infoVisitModel = GetinfoVisitModel(scn, ConvertUrlDateForm(dob)).Result;
                    var tupleModel = new Tuple<InfoBarViewModel, InfoVisitModel>(infoBarViewModel, infoVisitModel);

                    //20200422 carlos to show the full list
                    //var photo = GetPhotoAndXRay(scn, dob);
                    var photo = GetPhotoAndXRay(scn);

                    tupleModel.Item2.PhotoList = photo.PhotoList;
                    tupleModel.Item2.XRayList = photo.XRayList;
                    tupleModel.Item2.XRayPath = photo.XRayPath;
                    tupleModel.Item2.ExportList = photo.ExportList;
                    tupleModel.Item2.ExportXRayList = photo.ExportXRayList;
                    tupleModel.Item2.VisitList = photo.VisitList;
                    tupleModel.Item2.VisitListName = photo.VisitListName;
                    //Eddie 20200324
                    tupleModel.Item2.PhotoModifyList = photo.PhotoModifyList;
                    tupleModel.Item2.XRayModifyList = photo.XRayModifyList;

                    //20200819 Set Old Value
                    var previousVisitModel = GetPreviousVisitsModel(scn, ConvertUrlDateForm(dob));

                    infoVisitModel.LastDOC = "";
                    infoVisitModel.LastHT = "0";
                    infoVisitModel.LastSHT = "0";
                    infoVisitModel.LastWT = "0";
                    infoVisitModel.LastAS = "0";
                    infoVisitModel.LastRAS = "0";

                    if (previousVisitModel != null)
                    {
                        infoVisitModel.LastDOC = previousVisitModel.DOC.Value.ToString("dd/MM/yyyy");

                        if (previousVisitModel.HT != null)
                        {
                            infoVisitModel.LastHT = previousVisitModel.HT.Value.ToString();
                        }

                        if (previousVisitModel.SHT != null)
                        {
                            infoVisitModel.LastSHT = previousVisitModel.HT.Value.ToString();
                        }

                        if (previousVisitModel.WT != null)
                        {
                            infoVisitModel.LastWT = previousVisitModel.WT.Value.ToString();
                        }

                        if (previousVisitModel.ArmSpan != null)
                        {
                            infoVisitModel.LastAS = previousVisitModel.ArmSpan.Value.ToString();
                        }

                        if (previousVisitModel.RArmSpan != null)
                        {
                            infoVisitModel.LastRAS = previousVisitModel.RArmSpan.Value.ToString();
                        }
                    }

                    tupleModel.Item2.TemplateRemarksContents = GetTemplateRemarksContents();
                    tupleModel.Item2.TemplateRemarksHeaders = GetTemplateRemarksHeaders();

                    //Eddie 20200911
                    if (tupleModel.Item2.CurveDeg1 > 0)
                        tupleModel.Item2.RadFlexibility1 = (tupleModel.Item2.CurveDeg1 - tupleModel.Item2.RadDeg1) / tupleModel.Item2.CurveDeg1 * 100;
                    if (tupleModel.Item2.CurveDeg2 > 0)
                        tupleModel.Item2.RadFlexibility2 = (tupleModel.Item2.CurveDeg2 - tupleModel.Item2.RadDeg2) / tupleModel.Item2.CurveDeg2 * 100;
                    if (tupleModel.Item2.CurveDeg3 > 0)
                        tupleModel.Item2.RadFlexibility3 = (tupleModel.Item2.CurveDeg3 - tupleModel.Item2.RadDeg3) / tupleModel.Item2.CurveDeg3 * 100;
                    if (tupleModel.Item2.CurveDeg4 > 0)
                        tupleModel.Item2.RadFlexibility4 = (tupleModel.Item2.CurveDeg4 - tupleModel.Item2.RadDeg4) / tupleModel.Item2.CurveDeg4 * 100;

                    if (string.IsNullOrEmpty(tupleModel.Item2.DrName))
                    {
                        tupleModel.Item2.DrName = HttpContext.Session.GetString("_userId").ToString();
                    }

                    //20200819 Add Doctor Full Name
                    tupleModel.Item2.DrFullName = GetDoctorFullName(tupleModel.Item2.DrName);

                    if (isCreatePage != "true")
                    {
                        ResetSubmitSession();
                    }
                    else
                    {
                        HttpContext.Session.SetString("_isCreatePage", "false");
                    }

                    return View(tupleModel);
                }
                catch (Exception ex)
                {

                    var gUIDNumner = Guid.NewGuid();
                    var exceptionDateTime = DateTime.Now;
                    var showMessage = "Unable to load visit. Message: " + ex.Message;

                    InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Visit", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                    return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);
                }
            }
            else
            {
                try
                {
                    HttpContext.Session.SetString("_isCreatePage", "true");

                    var infoBarViewModel = GetInfoBarViewModels(scn);
                    var infoVisitModel = new InfoVisitModel();

                    var latestVisitModel = GetlatestVisitsModel(scn);

                    //20200506 if reaching latest: keep the latest stage for subsequent visit
                    if (latestVisitModel != null)
                    {
                        infoVisitModel.EpFusion = latestVisitModel.EpFusion;
                        infoVisitModel.tricart = latestVisitModel.tricart;
                        infoVisitModel.trochanter = latestVisitModel.trochanter;
                        infoVisitModel.FemoralHead = latestVisitModel.FemoralHead;

                        //20200818 Auto Fill
                        infoVisitModel.RSign = latestVisitModel.RSign;
                        infoVisitModel.EpFusion = latestVisitModel.EpFusion;
                        infoVisitModel.tricart = latestVisitModel.tricart;
                        infoVisitModel.trochanter = latestVisitModel.trochanter;
                        infoVisitModel.FemoralHead = latestVisitModel.FemoralHead;

                    }
                    infoVisitModel = infoVisitModel.SetDefaultValue(infoVisitModel);
                    infoVisitModel.SCN = scn;


                    infoVisitModel.TemplateRemarksContents = GetTemplateRemarksContents();
                    infoVisitModel.TemplateRemarksHeaders = GetTemplateRemarksHeaders();


                    var tupleModel = new Tuple<InfoBarViewModel, InfoVisitModel>(infoBarViewModel, infoVisitModel);

                    var photo = GetPhotoAndXRay(scn);

                    tupleModel.Item2.PhotoList = photo.PhotoList;
                    tupleModel.Item2.XRayList = photo.XRayList;
                    tupleModel.Item2.XRayPath = photo.XRayPath;
                    tupleModel.Item2.ExportList = photo.ExportList;
                    tupleModel.Item2.ExportXRayList = photo.ExportXRayList;
                    tupleModel.Item2.VisitList = photo.VisitList;
                    tupleModel.Item2.VisitListName = photo.VisitListName;
                    //Eddie 20200324
                    tupleModel.Item2.PhotoModifyList = photo.PhotoModifyList;
                    tupleModel.Item2.XRayModifyList = photo.XRayModifyList;

                    if (string.IsNullOrEmpty(tupleModel.Item2.DrName))
                    {
                        tupleModel.Item2.DrName = HttpContext.Session.GetString("_userId").ToString();
                    }

                    //20200819 Add Doctor Full Name
                    tupleModel.Item2.DrFullName = GetDoctorFullName(tupleModel.Item2.DrName);

                    //20200819 Set Old Value
                    var previousVisitModel = GetPreviousVisitsModel(scn, ConvertUrlDateForm(dob));

                    infoVisitModel.LastDOC = "";
                    infoVisitModel.LastHT = "0";
                    infoVisitModel.LastSHT = "0";
                    infoVisitModel.LastWT = "0";
                    infoVisitModel.LastAS = "0";
                    infoVisitModel.LastRAS = "0";

                    if (previousVisitModel != null)
                    {
                        infoVisitModel.LastDOC = previousVisitModel.DOC.Value.ToString("dd/MM/yyyy");

                        if (previousVisitModel.HT != null)
                        {
                            infoVisitModel.LastHT = previousVisitModel.HT.Value.ToString();
                        }

                        if (previousVisitModel.SHT != null)
                        {
                            infoVisitModel.LastSHT = previousVisitModel.HT.Value.ToString();
                        }

                        if (previousVisitModel.WT != null)
                        {
                            infoVisitModel.LastWT = previousVisitModel.WT.Value.ToString();
                        }

                        if (previousVisitModel.ArmSpan != null)
                        {
                            infoVisitModel.LastAS = previousVisitModel.ArmSpan.Value.ToString();
                        }

                        if (previousVisitModel.RArmSpan != null)
                        {
                            infoVisitModel.LastRAS = previousVisitModel.RArmSpan.Value.ToString();
                        }
                    }

                    return View(tupleModel);
                }
                catch (Exception ex)
                {

                    var gUIDNumner = Guid.NewGuid();
                    var exceptionDateTime = DateTime.Now;
                    var showMessage = "Unable to Update Personal Info";

                    InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "CreateNewVisit", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                    return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);
                }
            }



        }

        private VisitsModel GetlatestVisitsModel(string scn)
        {


            var visitsModels = new List<VisitsModel>();

            var visitsModel = new VisitsModel();

            visitsModels = GetVisitsModels(scn).Result;

            if (visitsModels != null)
            {
                visitsModel = visitsModels.OrderByDescending(x => x.DOC).FirstOrDefault();
            }

            return visitsModel;
        }

        private VisitsModel GetPreviousVisitsModel(string scn, string doc)
        {

            var dateVal = DateTime.ParseExact(doc, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            var visitsModels = new List<VisitsModel>();
            var visitsModel = new VisitsModel();
            visitsModels = GetVisitsModels(scn).Result.Where(x => x.DOC < dateVal).ToList();

            if (visitsModels != null)
            {
                visitsModel = visitsModels.OrderByDescending(x => x.DOC).FirstOrDefault();
            }

            return visitsModel;
        }


        private bool HasVisit(string scn, string dob)
        {

            try
            {
                //20210217
                //var infoVisitModel = GetinfoVisitModel(scn, ConvertUrlDateForm(dob)).Result;
                //if (infoVisitModel == null)
                //var a = (IsinfoVisitModel(scn, ConvertUrlDateForm(dob)).Result);

                if (!(IsinfoVisitModel(scn, ConvertUrlDateForm(dob)).Result))
                    return false;

            }
            catch (Exception ex)
            {
                return false;
            }

            return true;

        }

        private async Task<bool> IsinfoVisitModel(string scn, string dob)
        {
            //dob Must yyyy-MM-dd
            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/Visits/" + scn + "/" + dob;
            var client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(baseAddress + link);
            response.EnsureSuccessStatusCode();
            var stringResult = await response.Content.ReadAsStringAsync();
            ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);

            var visitsModels = JsonConvert.DeserializeObject<List<VisitsModel>>(resultModel.Data.ToString());

            if (visitsModels == null || visitsModels.Count(x => 1 == 1) < 1)
            {
                return false;
            }

            return true;

        }



        [HttpPost]
        public string VisitPageAjax([FromBody] VisitAjaxJsonViewModel visitAjaxJsonViewModel)
        {
            var visitModel = (VisitsModel)visitAjaxJsonViewModel;
            var scn = visitModel.SCN;
            var dob = visitModel.DOC.Value.ToString("yyyy-MM-dd");

            if (HasVisit(scn, dob))
            {
                UpdateVisitsAPI(visitModel);
                InsertActionLog("Update", "Update Visits Success", scn, dob, HttpContext.Session.GetString("_userId"), "Visit");
                InsertVisitsLogAPI(visitModel, Action.Update);
            }
            else
            {
                InsertCreateVisitAPI(visitModel);
                InsertVisitsLogAPI(visitModel, Action.Insert);
            }


            return "ok";
        }

        [HttpPost]
        public ActionResult VisitPage(InfoBarViewModel infoBarViewModel, InfoVisitModel infoVisitModel)
        {

            try
            {
                var scn = infoVisitModel.SCN;
                var dob = ConvertUrlDateForm(infoVisitModel.DOC);
                var infoBarViewModel1 = GetInfoBarViewModels(scn);
                Tuple<InfoBarViewModel, InfoVisitModel> tupleModel;

                infoVisitModel.SCN = scn;

                VisitsModel visit1;
                ResultModel resultModel;

                visit1 = (VisitsModel)infoVisitModel;

                try
                {
                    if (HasVisit(scn, dob))
                    {
                        //update

                        resultModel = UpdateVisitsAPI(visit1);

                        if (resultModel.IsSuccess)
                        {
                            var infoVisitModelResult = GetinfoVisitModel(scn, dob);
                            var infoVisitModel1 = SetPhotoInfoVisitModel(infoVisitModelResult.Result);

                            tupleModel = new Tuple<InfoBarViewModel, InfoVisitModel>(infoBarViewModel1, infoVisitModel1);
                            var photo = GetPhotoAndXRay(scn);

                            tupleModel.Item2.PhotoList = photo.PhotoList;
                            tupleModel.Item2.XRayList = photo.XRayList;
                            tupleModel.Item2.XRayPath = photo.XRayPath;
                            tupleModel.Item2.ExportList = photo.ExportList;
                            tupleModel.Item2.ExportXRayList = photo.ExportXRayList;
                            tupleModel.Item2.VisitList = photo.VisitList;
                            tupleModel.Item2.VisitListName = photo.VisitListName;
                            //Eddie 20200324
                            tupleModel.Item2.PhotoModifyList = photo.PhotoModifyList;
                            tupleModel.Item2.XRayModifyList = photo.XRayModifyList;

                            tupleModel.Item2.TemplateRemarksContents = GetTemplateRemarksContents();
                            tupleModel.Item2.TemplateRemarksHeaders = GetTemplateRemarksHeaders();

                            //20200819 Add Doctor Full Name
                            tupleModel.Item2.DrFullName = GetDoctorFullName(tupleModel.Item2.DrName);

                            SetSessionMessage("Update Success");

                            InsertActionLog("Update", "Update Visits Success", scn, dob, HttpContext.Session.GetString("_userId"), "Visit");
                            InsertVisitsLogAPI(visit1, Action.Update);

                            return View(tupleModel);
                        }
                        else
                        {
                            SetSessionMessage(resultModel.Message);
                        }

                    }
                    else
                    {
                        // insert
                        resultModel = InsertCreateVisitAPI(visit1);

                        if (visit1.DOC != null)
                        {
                            dob = visit1.DOC.Value.ToString("yyyy-MM-dd");
                        }

                        var infoVisitModelResult = GetinfoVisitModel(scn, dob);
                        var infoVisitModel1 = SetPhotoInfoVisitModel(infoVisitModelResult.Result);

                        tupleModel = new Tuple<InfoBarViewModel, InfoVisitModel>(infoBarViewModel1, infoVisitModel1);
                        var photo = GetPhotoAndXRay(scn);

                        tupleModel.Item2.PhotoList = photo.PhotoList;
                        tupleModel.Item2.XRayList = photo.XRayList;
                        tupleModel.Item2.XRayPath = photo.XRayPath;
                        tupleModel.Item2.ExportList = photo.ExportList;
                        tupleModel.Item2.ExportXRayList = photo.ExportXRayList;
                        tupleModel.Item2.VisitList = photo.VisitList;
                        tupleModel.Item2.VisitListName = photo.VisitListName;
                        //Eddie 20200324
                        tupleModel.Item2.PhotoModifyList = photo.PhotoModifyList;
                        tupleModel.Item2.XRayModifyList = photo.XRayModifyList;

                        tupleModel.Item2.TemplateRemarksContents = GetTemplateRemarksContents();
                        tupleModel.Item2.TemplateRemarksHeaders = GetTemplateRemarksHeaders();

                        //20200819 Add Doctor Full Name
                        tupleModel.Item2.DrFullName = GetDoctorFullName(tupleModel.Item2.DrName);

                        if (resultModel.IsSuccess == true)
                        {
                            HttpContext.Session.SetString("_isCreatePage", "true");
                            SetSessionMessage("Save Success!");

                            InsertVisitsLogAPI(visit1, Action.Insert);

                            var directAction = "VisitPage";

                            //20200515 Delete Pre-Clinic Measurement
                            if (infoVisitModel.OriVirtual == "Pre-Clinic Measurement" && infoVisitModel.Virtual == "Normal")
                            {
                                var previousInfoVisit = GetinfoVisitModel(infoVisitModel.SCN, ConvertUrlDateForm(infoVisitModel.OriDOC)).Result;
                                var previousVisit = (VisitsModel)previousInfoVisit;
                                InsertVisitsLogAPI(previousVisit, Action.Delete);
                                DeleteVisitAPI(previousVisit);
                            }


                            return RedirectToAction(directAction, new { scn = scn, dob = dob });

                            //return View(tupleModel);
                        }
                        else
                        {
                            SetSessionMessage(resultModel.Message);
                            return View(tupleModel);
                        }
                    }

                }
                catch (Exception ex1)
                {
                    SetSessionMessage(ex1.Message);
                }
                infoVisitModel = SetPhotoInfoVisitModel(infoVisitModel);
                tupleModel = new Tuple<InfoBarViewModel, InfoVisitModel>(infoBarViewModel, infoVisitModel);


                InsertActionLog("Update", "Update Visits Fail", scn, dob, HttpContext.Session.GetString("_userId"), "Visit");

                return View(tupleModel);

            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to save visit";

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Visit Post", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }
        }

        private string GetDoctorFullName(string userId)
        {
            var UserSupplement = GetUserSupplement(userId);

            if (UserSupplement == null)
                return "";

            return UserSupplement.FullName;
        }





        public ActionResult EditPersonalInfoPage(string scn)
        {
            var isCreatePage = HttpContext.Session.GetString("_isCreatePage");

            if (!IsLogin())
            {
                return RedirectToReLoginPage();
            }

            try
            {
                if (isCreatePage == "true")
                {
                    HttpContext.Session.SetString("_isCreatePage", "false");
                }
                else
                {
                    ResetSubmitSession();
                }

                var personalInfoViewModel = GetPersonalInfoModel(scn);
                var infoBarViewModel = GetInfoBarViewModels(scn);
                var infoPersonalInfoViewModel = (InfoPersonalInfoViewModel)personalInfoViewModel.Result;
                var tupleModel = new Tuple<InfoPersonalInfoViewModel, InfoBarViewModel>(infoPersonalInfoViewModel, infoBarViewModel);

                return View(tupleModel);

            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to Update Personal Info";

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Personal Info", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }
        }



        [HttpPost]
        public ActionResult EditPersonalInfoPage(InfoPersonalInfoViewModel infoPersonalInfoViewModel, InfoBarViewModel infoBarViewModel)
        {
            try
            {
                var scn = infoPersonalInfoViewModel.SCN;
                //var directAction = "EditPersonalInfo";
                var infoBarViewModel1 = GetInfoBarViewModels(scn);
                Tuple<InfoPersonalInfoViewModel, InfoBarViewModel> tupleModel;

                try
                {
                    var personalInfo = (PersonalInfoModel)infoPersonalInfoViewModel;
                    var resultModel = UpdatePersonalInfoAPI(personalInfo);
                    //var infoPersonalInfoViewModel1 = GetPersonInfoViewModel(scn);

                    var infoPersonalInfoViewModel1 = (InfoPersonalInfoViewModel)GetPersonalInfoModel(scn).Result;

                    if (resultModel.IsSuccess == true)
                    {
                        SetSessionMessage("Sucessful updated!");
                        tupleModel = new Tuple<InfoPersonalInfoViewModel, InfoBarViewModel>(infoPersonalInfoViewModel1, infoBarViewModel1);

                        InsertPersonalInfoLogAPI(personalInfo, Action.Update);

                    }
                    else
                    {
                        SetSessionMessage(resultModel.Message);
                        tupleModel = new Tuple<InfoPersonalInfoViewModel, InfoBarViewModel>(infoPersonalInfoViewModel, infoBarViewModel1);
                    }
                }
                catch (Exception ex)
                {
                    SetSessionMessage(ex.Message);
                    tupleModel = new Tuple<InfoPersonalInfoViewModel, InfoBarViewModel>(infoPersonalInfoViewModel, infoBarViewModel1);
                }

                InsertActionLog("Update", "Update Personal Info Success", scn, "1900-01-01", HttpContext.Session.GetString("_userId"), "PersonalInfo");

                return View(tupleModel);
                // return RedirectToAction(directAction, new { scn = scn });

            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to Update Personal Info";

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "PersonalInfo Edit Post", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);
            }
        }


        public ActionResult CreatePersonalInfoPage(string scn)
        {

            var ceatePersonalInfoViewModel = new CreatePersonalInfoViewModel();

            if (!IsLogin())
            {
                return RedirectToReLoginPage();
            }

            ceatePersonalInfoViewModel = ceatePersonalInfoViewModel.SetDefaultValue(ceatePersonalInfoViewModel);

            ResetSubmitSession();

            return View(ceatePersonalInfoViewModel);

        }


        [HttpPost]
        public ActionResult CreatePersonalInfoPage(CreatePersonalInfoViewModel ceatePersonalInfoViewModel)
        {
            try
            {
                var scn = "";
                var directAction = "EditPersonalInfoPage";
                try
                {

                    var personalInfo = (PersonalInfoModel)ceatePersonalInfoViewModel;
                    scn = personalInfo.SCN;
                    var infoPersonalInfoViewModel1 = GetPersonalInfoModel(scn).Result;
                    if (infoPersonalInfoViewModel1 != null)
                    {
                        SetSessionMessage("Fail to save. Patient records with the same SCN is already existed.");
                        return RedirectToAction(directAction, new { scn = scn });
                    }
                    else
                    {
                        var resultModel = InsertPersonalInfo(personalInfo);
                        if (resultModel.IsSuccess)
                        {
                            HttpContext.Session.SetString("_isCreatePage", "true");
                            var infopersonalModel = GetPersonalInfoModelHKID(ceatePersonalInfoViewModel.HKID);
                            if (infopersonalModel.HKID == ceatePersonalInfoViewModel.HKID)
                            {
                                SetSessionMessage("Success Save. Patient records with the same HKID with different SCN is already exitsted");
                            }
                            else
                            {
                                SetSessionMessage("Success Save");
                            }
                            InsertPersonalInfoLogAPI(personalInfo, Action.Insert);
                        }
                        else
                        {

                            SetSessionMessage(resultModel.Message);
                            return View(ceatePersonalInfoViewModel);
                        }

                        //SetSubmitSession(resultModel);
                    }
                }
                catch (Exception ex)
                {
                    SetSessionMessage(ex.Message);
                    return View(ceatePersonalInfoViewModel);
                }

                InsertActionLog("Created", "Personal Info Save Successfully", scn, "1900-01-01", HttpContext.Session.GetString("_userId"), "PersonalInfo");
                return RedirectToAction(directAction, new { scn = scn });
            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to Search Recrod <br>" + ex.Message + "<br>" + ex.InnerException.Message;

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "CreatePersonalInfo Post", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));


                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }

        }

        public ActionResult InitAssessPage(string scn)
        {
          

            if (!IsLogin())
            {
                return RedirectToReLoginPage();
            }

            try
            {
                var infoBarViewModel = GetInfoBarViewModels(scn);

                var initialAssessmentViewModel = new InitAssessViewModel();

                var infoInitialAssessmentViewModel = new InfoInitAssessViewModel();

                var initAssessViewModel = GetInitialAssessment(scn).Result;

                if (initAssessViewModel == null)
                {

                    var initAssessViewModelTemp = new InitAssessViewModel();
                    infoInitialAssessmentViewModel = initAssessViewModelTemp.GetInitInfoInitAssessViewModel();
                    infoInitialAssessmentViewModel.SCN = scn;

                }
                else
                {
                    infoInitialAssessmentViewModel = (InfoInitAssessViewModel)initAssessViewModel;
                }

                var photo = GetPhotoAndXRay(scn);

                //20210222 Add Xray carlos
                if (photo != null) {
                    infoInitialAssessmentViewModel.PhotoList = photo.PhotoList;
                    infoInitialAssessmentViewModel.XRayList = photo.XRayList;
                    infoInitialAssessmentViewModel.XRayPath = photo.XRayPath;
                    infoInitialAssessmentViewModel.ExportList = photo.ExportList;
                    infoInitialAssessmentViewModel.ExportXRayList = photo.ExportXRayList;
                    infoInitialAssessmentViewModel.VisitList = photo.VisitList;
                    infoInitialAssessmentViewModel.VisitListName = photo.VisitListName;
                    //Eddie 20200324
                    infoInitialAssessmentViewModel.PhotoModifyList = photo.PhotoModifyList;
                    infoInitialAssessmentViewModel.XRayModifyList = photo.XRayModifyList;
                }
                

                var tupleModel = new Tuple<InfoBarViewModel, InfoInitAssessViewModel>(infoBarViewModel, infoInitialAssessmentViewModel);

                return View(tupleModel);
            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to Get Record Summary";

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "InitAssess", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));


                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);
            }
        }



        [HttpPost]
        public ActionResult InitAssessPage(InfoBarViewModel infoBarViewModel, InfoInitAssessViewModel infoInitAssessViewModel)
        {

            var scn = infoInitAssessViewModel.SCN;
            var infoBarViewModel1 = GetInfoBarViewModels(scn);

            try
            {

                var result = "";

                Tuple<InfoBarViewModel, InfoInitAssessViewModel> tupleModel;
                ResultModel resultModel;

                try
                {
                    var initAssessViewModel = (InitAssessViewModel)infoInitAssessViewModel;


                    if (HasInitAssessViewModel(scn))
                    {
                        resultModel = UpdateInitAssesAPI(initAssessViewModel);
                        result = "Update";
                    }
                    else
                    {
                        resultModel = InsertInitAssesAPI(initAssessViewModel);
                        result = "Create";
                    }


                    if (resultModel.IsSuccess)
                    {
                        tupleModel = new Tuple<InfoBarViewModel, InfoInitAssessViewModel>(infoBarViewModel1, (InfoInitAssessViewModel)initAssessViewModel);
                        SetSessionMessage(result + " Success");
                        InsertActionLog(result, result + " InitAssess", scn, "1900-01-01", HttpContext.Session.GetString("_userId"), "InitAssess");

                        return View(tupleModel);
                    }
                    else
                    {

                        SetSessionMessage(resultModel.Message);
                    }
                }
                catch (Exception ex1)
                {
                    SetSessionMessage(ex1.Message);
                }

                tupleModel = new Tuple<InfoBarViewModel, InfoInitAssessViewModel>(infoBarViewModel1, infoInitAssessViewModel);
                return View(tupleModel);

            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Message = " + ex.Message;

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "InitAssess POST", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));


                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }
        }
        private ResultModel InsertImage(ImageModel imageModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/Images/";
            var client1 = new HttpClient();

            string content = JsonConvert.SerializeObject(imageModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = client1.PostAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;
        }
        //20200323 Eddie
        public ActionResult SaveImage([FromBody] dynamic imageData, string imgsrc)
        {
            ImageModel imageModel = new ImageModel();
            string tpimage = imageData["imageData"];
            string[] src = imgsrc.Split("/");
            string scn = "";
            string dob = "";
            string imagename = "";
            if (src[1] == "Xray")
            {
                scn = src[3].Replace("SC", "").Insert(2, "-");
                dob = "";//src[4].Insert(4, "-").Insert(7, "-");
                imagename = src[4];
            }
            else
            {
                scn = src[2].Replace("SC", "").Insert(2, "-");
                dob = src[3].Insert(4, "-").Insert(7, "-");
                imagename = src[4];
            }
            // imageModel.ID = "1";
            imageModel.SCN = scn;
            imageModel.DOB = dob;
            imageModel.imageName = imagename;
            imageModel.imageData = tpimage;
            imageModel.LastModify = DateTime.Now.ToString();
            imageModel.LastModifyBy = HttpContext.Session.GetString("_userId").ToString();
            DeleteImage(imageModel);
            InsertImage(imageModel);
            return RedirectToAction("./Visit", new { scn = scn, dob = dob });

        }
        private ImageModel GetImage(string scn, string dob, string lastmodifyby, string imagename)
        {

            var Images = new List<ImageModel>();
            var Image = new ImageModel();

            try
            {
                var baseAddress = "Http://" + Request.Host.ToString();
                //var link = $"/api/Images/" + scn + "/" + dob + "/" + lastmodifyby.Replace("@","-").Replace(".", "-");
                var link = $"/api/Images/" + scn + "|" + dob + "|" + lastmodifyby + "|" + imagename;
                var client = new HttpClient();

                HttpResponseMessage response = client.GetAsync(baseAddress + link).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                var stringResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
                Images = JsonConvert.DeserializeObject<List<ImageModel>>(resultModel.Data.ToString());
                Image = Images.FirstOrDefault();
            }

            catch (Exception ex)
            {
                var gUIDNumner = Guid.NewGuid();

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Search", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));
            }

            return Image;
        }

        private ResultModel DeleteImage(ImageModel imageModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();

            var link = $"/api/Images/" + imageModel.SCN + "|" + imageModel.DOB + "|" + imageModel.LastModifyBy + "|" + imageModel.imageName;
            var client1 = new HttpClient();

            string content = JsonConvert.SerializeObject(imageModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = client1.DeleteAsync(baseAddress + link).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;
        }

        public ActionResult UploadDocumentList()
        {
            var uploadDocuments = new List<UploadDocumentViewModel>();

            ResetSubmitSession();

            uploadDocuments = GetAllUploadDocument();

            return View(uploadDocuments);

        }

        public ActionResult UploadDocumentListUser()
        {
            var uploadDocuments = new List<UploadDocumentViewModel>();

            ResetSubmitSession();

            uploadDocuments = GetAllUploadDocument();

            return View(uploadDocuments);

        }

        public ActionResult UploadDocument(long id)
        {
            var uploadDocument = new UploadDocumentViewModel();
            uploadDocument = GetUploadDocument(id);

            return View((UploadDocumentLoyoutViewModel)uploadDocument);

        }

        public ActionResult CreateUploadDocument()
        {
            var uploadDocument = new UploadDocumentViewModel();
            uploadDocument.Filename = "";
            uploadDocument.Description = "";

            return View((UploadDocumentLoyoutViewModel)uploadDocument);

        }




        [HttpPost]
        public ActionResult UploadDocument(UploadDocumentLoyoutViewModel uploadDocumentLoyoutViewModel)
        {

            var result = "";
            ResultModel resultModel;

            try
            {

                if (uploadDocumentLoyoutViewModel.file != null)
                {

                    var filePath = Path.Combine(
                      Directory.GetCurrentDirectory(), "wwwroot",
                      uploadDocumentLoyoutViewModel.file.FileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        uploadDocumentLoyoutViewModel.file.CopyToAsync(stream);
                    }
                    uploadDocumentLoyoutViewModel.Filename = uploadDocumentLoyoutViewModel.file.FileName;
                    uploadDocumentLoyoutViewModel.ModifiedBy = HttpContext.Session.GetString("_userId");
                    uploadDocumentLoyoutViewModel.ModifiedDate = DateTime.Now;

                }

                var uploadDocumentViewModel = (UploadDocumentViewModel)uploadDocumentLoyoutViewModel;

                if (HasUploadDocument(uploadDocumentViewModel.Id))
                {

                    resultModel = UpdateUploadDocment(uploadDocumentViewModel);
                    result = "Update";
                }
                else
                {
                    uploadDocumentViewModel.CreatedBy = HttpContext.Session.GetString("_userId");
                    resultModel = InsertUploadDocment(uploadDocumentViewModel);
                    result = "Create";
                }

                uploadDocumentLoyoutViewModel = (UploadDocumentLoyoutViewModel)uploadDocumentViewModel;


                if (resultModel.IsSuccess)
                {

                    SetSessionMessage(result + " Success");
                    InsertActionLog(result, result + " uploadDocument", "", "", HttpContext.Session.GetString("_userId"), "uploadDocument");

                    if (result == "Create")
                    {
                        return RedirectToAction("../Patient/UploadDocumentList");
                    }

                    return View(uploadDocumentLoyoutViewModel);
                }
                else
                {
                    SetSessionMessage(resultModel.Message);
                }
            }
            catch (Exception ex1)
            {
                SetSessionMessage(ex1.Message);
            }

            return View(uploadDocumentLoyoutViewModel);

        }

        private ResultModel UpdateUploadDocment(UploadDocumentViewModel uploadDocumentViewModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/UploadDocuments/" + uploadDocumentViewModel.Id;
            var client1 = new HttpClient();

            string content = JsonConvert.SerializeObject(uploadDocumentViewModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = client1.PutAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;

        }

        private ResultModel InsertUploadDocment(UploadDocumentViewModel uploadDocumentViewModel)
        {
            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/UploadDocuments/";
            var client1 = new HttpClient();

            string content = JsonConvert.SerializeObject(uploadDocumentViewModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = client1.PostAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;
        }

        private bool HasUploadDocument(long id)
        {

            var uploadDocumentViewModel = GetUploadDocument(id);

            if (uploadDocumentViewModel == null)
                return false;

            return true;
        }


        public UploadDocumentViewModel GetUploadDocument(long id)
        {

            var uploadDocuments = new List<UploadDocumentViewModel>();
            var uploadDocument = new UploadDocumentViewModel();

            try
            {
                var baseAddress = "Http://" + Request.Host.ToString();
                var link = $"/api/UploadDocuments/" + id;
                var client = new HttpClient();

                HttpResponseMessage response = client.GetAsync(baseAddress + link).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                var stringResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
                uploadDocuments = JsonConvert.DeserializeObject<List<UploadDocumentViewModel>>(resultModel.Data.ToString());
                uploadDocument = uploadDocuments.FirstOrDefault();
            }

            catch (Exception ex)
            {
                var gUIDNumner = Guid.NewGuid();

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Search", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));
            }

            return uploadDocument;
        }


        public List<UploadDocumentViewModel> GetAllUploadDocument()
        {

            var uploadDocuments = new List<UploadDocumentViewModel>();

            try
            {
                var baseAddress = "Http://" + Request.Host.ToString();
                var link = $"/api/UploadDocuments/";
                var client = new HttpClient();

                HttpResponseMessage response = client.GetAsync(baseAddress + link).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                var stringResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
                uploadDocuments = JsonConvert.DeserializeObject<List<UploadDocumentViewModel>>(resultModel.Data.ToString());
            }

            catch (Exception ex)
            {
                var gUIDNumner = Guid.NewGuid();

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Search", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));
            }

            return uploadDocuments;
        }


        public ActionResult TemplateRemarksContent(int id)
        {

            var templateRemarksHeaders = GetTemplateRemarksHeaders();

            var templateRemarksContent = GetTemplateRemarksContent(id);

            var tupleModel = new Tuple<List<TemplateRemarksHeaderViewModel>, TemplateRemarksContentViewModel>(templateRemarksHeaders, templateRemarksContent);


            return View(tupleModel);

        }


        public ActionResult CreateTemplateRemarksContent()
        {
            var templateRemarksHeaders = GetTemplateRemarksHeaders();
            var templateRemarksContentViewModel = new TemplateRemarksContentViewModel();
            templateRemarksContentViewModel.HeaderId = 0;
            templateRemarksContentViewModel.Name = "";

            var tupleModel = new Tuple<List<TemplateRemarksHeaderViewModel>, TemplateRemarksContentViewModel>(templateRemarksHeaders, templateRemarksContentViewModel);

            return View(tupleModel);

        }

        public ActionResult TemplateRemarksHeader(int id)
        {

            var templateRemarksHeader = GetTemplateRemarksHeader(id);

            return View(templateRemarksHeader);

        }

        public ActionResult CreateTemplateRemarksHeader()
        {
            var templateRemarksHeaderViewModel = new TemplateRemarksHeaderViewModel();
            templateRemarksHeaderViewModel.Id = 0;
            templateRemarksHeaderViewModel.Name = "";

            return View(templateRemarksHeaderViewModel);
        }



        public ActionResult TemplateRemarksContentList()
        {
            ResetSubmitSession();

            var templateRemarksHeaders = GetTemplateRemarksHeaders();

            var templateRemarksContents = GetTemplateRemarksContents();

            var tupleModel = new Tuple<List<TemplateRemarksHeaderViewModel>, List<TemplateRemarksContentViewModel>>(templateRemarksHeaders, templateRemarksContents);

            return View(tupleModel);

        }

        public ActionResult TemplateRemarksHeaderList()
        {
            ResetSubmitSession();

            var templateRemarksHeaders = GetTemplateRemarksHeaders();

            //var tupleModel = new Tuple<List<TemplateRemarksHeaderViewModel>, List<TemplateRemarksContentViewModel>>(templateRemarksHeaders, templateRemarksContents);

            return View(templateRemarksHeaders);

        }





        public TemplateRemarksContentViewModel GetTemplateRemarksContent(int id)
        {
            var templateRemarksContentViewModel = new TemplateRemarksContentViewModel();

            try
            {
                var baseAddress = "Http://" + Request.Host.ToString();
                var link = $"/api/TemplateRemarksContents/" + id;
                var client = new HttpClient();

                HttpResponseMessage response = client.GetAsync(baseAddress + link).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                var stringResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
                var templateRemarksContentViewModels = JsonConvert.DeserializeObject<List<TemplateRemarksContentViewModel>>(resultModel.Data.ToString());
                templateRemarksContentViewModel = templateRemarksContentViewModels.FirstOrDefault();

            }
            catch (Exception ex)
            {
                var gUIDNumner = Guid.NewGuid();

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Search", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));
            }

            return templateRemarksContentViewModel;
        }

        public TemplateRemarksHeaderViewModel GetTemplateRemarksHeader(int id)
        {
            var templateRemarksHeaderViewModel = new TemplateRemarksHeaderViewModel();

            try
            {
                var baseAddress = "Http://" + Request.Host.ToString();
                var link = $"/api/TemplateRemarksHeaders/" + id;
                var client = new HttpClient();

                HttpResponseMessage response = client.GetAsync(baseAddress + link).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                var stringResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
                var templateRemarksHeaderViewModels = JsonConvert.DeserializeObject<List<TemplateRemarksHeaderViewModel>>(resultModel.Data.ToString());
                templateRemarksHeaderViewModel = templateRemarksHeaderViewModels.FirstOrDefault();

            }
            catch (Exception ex)
            {
                var gUIDNumner = Guid.NewGuid();

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Search", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));
            }

            return templateRemarksHeaderViewModel;
        }

        public ActionResult DeleteTemplateRemarksContent(int Id)
        {
            if (HasTemplateRemarksContent(Id))
            {
                var templateRemarksContentViewModel = GetTemplateRemarksContent(Id);
                templateRemarksContentViewModel.Active = false;
                UpdateTemplateRemarksContent(templateRemarksContentViewModel);
            }
            return RedirectToAction("TemplateRemarksContentList", "Patient");
        }

        public ActionResult DeleteTemplateRemarksHeader(int Id)
        {
            if (HasTemplateRemarksHeader(Id))
            {
                var templateRemarksHeaderViewModel = GetTemplateRemarksHeader(Id);
                templateRemarksHeaderViewModel.Active = false;
                UpdateTemplateRemarksHeader(templateRemarksHeaderViewModel);
            }
            return RedirectToAction("TemplateRemarksHeaderList", "Patient");
        }


        [HttpPost]
        public ActionResult TemplateRemarksContent(TemplateRemarksContentViewModel templateRemarksContentViewModel)
        {

            var result = "";
            ResultModel resultModel;


            var templateRemarksHeaders = GetTemplateRemarksHeaders();
            templateRemarksContentViewModel.Active = true;
            templateRemarksContentViewModel.ModifiedDate = DateTime.Now;
            templateRemarksContentViewModel.ModifiedBy = HttpContext.Session.GetString("_userId");
            try
            {
                if (HasTemplateRemarksContent(templateRemarksContentViewModel.Id))
                {
                    resultModel = UpdateTemplateRemarksContent(templateRemarksContentViewModel);
                    result = "Update";
                }
                else
                {
                    templateRemarksContentViewModel.CreatedBy = HttpContext.Session.GetString("_userId");
                    resultModel = InsertTemplateRemarksContent(templateRemarksContentViewModel);
                    result = "Create";
                }

                if (resultModel.IsSuccess)
                {

                    SetSessionMessage(result + " Success");
                    InsertActionLog(result, result + " uploadDocument", "", "", HttpContext.Session.GetString("_userId"), "uploadDocument");

                    if (result == "Create")
                    {
                        return RedirectToAction("../Patient/TemplateRemarksContentList");
                    }

                    return View(new Tuple<List<TemplateRemarksHeaderViewModel>, TemplateRemarksContentViewModel>(templateRemarksHeaders, templateRemarksContentViewModel));
                }
                else
                {
                    SetSessionMessage(resultModel.Message);
                }
            }
            catch (Exception ex1)
            {
                SetSessionMessage(ex1.Message);
            }

            return View(new Tuple<List<TemplateRemarksHeaderViewModel>, TemplateRemarksContentViewModel>(templateRemarksHeaders, templateRemarksContentViewModel));

        }



        [HttpPost]
        public ActionResult TemplateRemarksHeader(TemplateRemarksHeaderViewModel templateRemarksHeaderViewModel)
        {

            var result = "";
            ResultModel resultModel;

            templateRemarksHeaderViewModel.Active = true;
            templateRemarksHeaderViewModel.ModifiedDate = DateTime.Now;
            templateRemarksHeaderViewModel.ModifiedBy = HttpContext.Session.GetString("_userId");
            try
            {
                if (templateRemarksHeaderViewModel.Id != 0 && HasTemplateRemarksContent(templateRemarksHeaderViewModel.Id))
                {
                    resultModel = UpdateTemplateRemarksHeader(templateRemarksHeaderViewModel);
                    result = "Update";
                }
                else
                {
                    templateRemarksHeaderViewModel.CreatedBy = HttpContext.Session.GetString("_userId");
                    templateRemarksHeaderViewModel.CreatedDate = DateTime.Now;

                    resultModel = InsertTemplateRemarksHeader(templateRemarksHeaderViewModel);
                    result = "Create";
                }

                if (resultModel.IsSuccess)
                {

                    SetSessionMessage(result + " Success");
                    InsertActionLog(result, result + " uploadDocument", "", "", HttpContext.Session.GetString("_userId"), "uploadDocument");

                    if (result == "Create")
                    {
                        return RedirectToAction("../Patient/TemplateRemarksContentList");
                    }

                    return View(templateRemarksHeaderViewModel);
                }
                else
                {
                    SetSessionMessage(resultModel.Message);
                }
            }
            catch (Exception ex1)
            {
                SetSessionMessage(ex1.Message);
            }

            return View(templateRemarksHeaderViewModel);

        }


        private bool HasTemplateRemarksContent(long id)
        {

            var templateRemarksContentViewModel = GetTemplateRemarksContent((int)id);

            if (templateRemarksContentViewModel == null)
                return false;

            return true;
        }

        private bool HasTemplateRemarksHeader(long id)
        {

            var templateRemarksContentViewModel = GetTemplateRemarksHeader((int)id);

            if (templateRemarksContentViewModel == null)
                return false;

            return true;
        }





        private ResultModel UpdateTemplateRemarksContent(TemplateRemarksContentViewModel templateRemarksContentViewModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/TemplateRemarksContents/";
            var client1 = new HttpClient();

            string content = JsonConvert.SerializeObject(templateRemarksContentViewModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = client1.PutAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;

        }

        private ResultModel InsertTemplateRemarksContent(TemplateRemarksContentViewModel templateRemarksContentViewModel)
        {
            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/TemplateRemarksContents/";
            var client1 = new HttpClient();

            string content = JsonConvert.SerializeObject(templateRemarksContentViewModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = client1.PostAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;
        }

        // 20200901 Add Remote 
        private ResultModel UpdateTemplateRemarksHeader(TemplateRemarksHeaderViewModel templateRemarksHeaderViewModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/TemplateRemarksHeaders/";
            var client1 = new HttpClient();

            string content = JsonConvert.SerializeObject(templateRemarksHeaderViewModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = client1.PutAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;

        }

        private ResultModel InsertTemplateRemarksHeader(TemplateRemarksHeaderViewModel templateRemarksHeaderViewModel)
        {
            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/TemplateRemarksHeaders/";
            var client1 = new HttpClient();

            string content = JsonConvert.SerializeObject(templateRemarksHeaderViewModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = client1.PostAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;
        }



        //2020-5-26 by Eddie Lok
        public ActionResult POVisitPage(string scn, string DOB)
        {
            try
            {
                if (!IsLogin())
                {
                    return RedirectToReLoginPage();
                }
                var povisitModel = new POVisitModel();
                //   povisitModel = GetPOVisitPage(scn);
                if (DOB == null)
                {
                    povisitModel = new POVisitModel().SetDefaultValue(scn);
                }
                else
                {
                    povisitModel = (POVisitModel)GetPOVisit(scn, DOB);
                }
                var infoBarViewModel = GetInfoBarViewModels(scn);
                var tupleModel = new Tuple<InfoBarViewModel, POVisitModel>(infoBarViewModel, povisitModel);
                return View(tupleModel);
            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to Search Recrod";

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Search", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }
        }

        private async Task<List<string>> GetPOVisitList(string scn)
        {

            var baseAddress1 = "Http://" + Request.Host.ToString();
            var link2 = $"/api/POVisits/" + scn;
            var client2 = new HttpClient();
            var tempStringList = new List<string>();

            try
            {
                HttpResponseMessage response2 = await client2.GetAsync(baseAddress1 + link2);
                response2.EnsureSuccessStatusCode();

                var stringResult2 = await response2.Content.ReadAsStringAsync();
                ResultModel resultModel2 = JsonConvert.DeserializeObject<ResultModel>(stringResult2);
                var visitsModels = JsonConvert.DeserializeObject<List<string>>(resultModel2.Data.ToString());


                for (var i = 0; i < visitsModels.Count(); i++)
                {
                    tempStringList.Add(visitsModels[i]);
                }
            }
            catch (Exception ex)
            {
                //Should add log
            }

            return tempStringList;
        }

        private POVisitModel GetPOVisit(string scn, string DOC)
        {

            var poVisitModel = new POVisitModel();
            var dateTime = DateTime.Parse(DOC);
            var dob = dateTime.ToString("yyyy-MM-dd");
            try
            {
                var baseAddress = "Http://" + Request.Host.ToString();
                var link = $"/api/POVisits/" + scn + "/" + dob;
                var client = new HttpClient();

                HttpResponseMessage response = client.GetAsync(baseAddress + link).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                var stringResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
                var listpoVisitModel = JsonConvert.DeserializeObject<List<POVisitModel>>(resultModel.Data.ToString());
                poVisitModel = listpoVisitModel[0];
            }

            catch (Exception ex)
            {
                var gUIDNumner = Guid.NewGuid();

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Search", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));
            }

            return poVisitModel;
        }

        private ResultModel UpdatePOVisit(POVisitModel poVisitModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/POVisits/" + poVisitModel.SCN;
            var client1 = new HttpClient();

            string content = JsonConvert.SerializeObject(poVisitModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = client1.PutAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;

        }
        private ResultModel InsertPOVisit(POVisitModel poVisitModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/POVisits/";
            var client1 = new HttpClient();

            string content = JsonConvert.SerializeObject(poVisitModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = client1.PostAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;
        }

        [HttpPost]
        public ActionResult POVisitPage(InfoBarViewModel infoBarViewModel, POVisitModel povisitModel)
        {
            try
            {
                var result = "";
                var scn = povisitModel.SCN;

                Tuple<InfoBarViewModel, POVisitModel> tupleModel;
                ResultModel resultModel;
                var infoBarViewModel1 = GetInfoBarViewModels(scn);
                try
                {
                    var newposvisitModel = GetPOVisit(povisitModel.SCN, povisitModel.DOC.ToString());
                    if (newposvisitModel.DOC == null)
                    {
                        result = "Create";
                        resultModel = InsertPOVisit(povisitModel);
                    }
                    else
                    {
                        result = "Udpate";
                        resultModel = UpdatePOVisit(povisitModel);
                    }


                    if (resultModel.IsSuccess)
                    {
                        var povisitModel1 = (POVisitModel)povisitModel;

                        tupleModel = new Tuple<InfoBarViewModel, POVisitModel>(infoBarViewModel1, povisitModel1);

                        SetSessionMessage(result + " Success");
                        InsertActionLog(result, result + " POConfigPage", povisitModel.SCN, "1900-01-01", HttpContext.Session.GetString("_userId"), "POVisitPage");


                        var directAction = "POVisitPage";

                        return RedirectToAction(directAction, new { scn = scn, dob = povisitModel.DOC.Value.ToString("yyyy-MM-dd") });
                    }
                    else
                    {
                        SetSessionMessage(resultModel.Message);
                    }
                }
                catch (Exception ex1)
                {
                    SetSessionMessage(ex1.Message);
                    throw ex1;
                }

                InsertActionLog(result, result + " InitAssess", scn, "1900-01-01", HttpContext.Session.GetString("_userId"), "InitAssess");
                tupleModel = new Tuple<InfoBarViewModel, POVisitModel>(infoBarViewModel1, povisitModel);
                return View(tupleModel);

            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Message = " + ex.Message;

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "InitAssess POST", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));
                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }
        }


        //2020-5-26 by Eddie Lok
        public ActionResult POConfigPage(string scn)
        {
            try
            {
                if (!IsLogin())
                {
                    return RedirectToReLoginPage();
                }
                var poconfigModel = new POConfigModel();
                poconfigModel = (POConfigModel)GetConfig();

                //if (DOB == null)
                //{
                //    poconfigModel = new POConfigModel().SetDefaultValue();
                //}
                //else
                //{
                //    poconfigModel = (POConfigModel)GetConfig();
                //}
                var infoBarViewModel = GetInfoBarViewModels(scn);
                var tupleModel = new Tuple<InfoBarViewModel, POConfigModel>(infoBarViewModel, poconfigModel);
                return View(tupleModel);
            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to Search Recrod";

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Search", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }
        }

        private POConfigModel GetConfig()
        {

            var poconfigModel = new POConfigModel();
            try
            {
                var baseAddress = "Http://" + Request.Host.ToString();
                var link = $"/api/POConfigs/" + "1";
                var client = new HttpClient();

                HttpResponseMessage response = client.GetAsync(baseAddress + link).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                var stringResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
                var listpoconfigModel = JsonConvert.DeserializeObject<List<POConfigModel>>(resultModel.Data.ToString());
                poconfigModel = listpoconfigModel[0];
            }

            catch (Exception ex)
            {
                var gUIDNumner = Guid.NewGuid();

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Search", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));
            }

            return poconfigModel;
        }
        [HttpPost]
        public ActionResult POConfigPage(InfoBarViewModel infoBarViewModel, POConfigModel poconfigModel)
        {
            try
            {
                var result = "";
                var scn = infoBarViewModel.SCN;

                Tuple<InfoBarViewModel, POConfigModel> tupleModel;
                ResultModel resultModel;
                var infoBarViewModel1 = GetInfoBarViewModels(scn);
                try
                {
                    var newpoconfigModel = GetConfig();
                    if (newpoconfigModel.ID == null)
                    {
                        result = "Create";
                        resultModel = InsertPOConfig(poconfigModel);
                    }
                    else
                    {
                        result = "Udpate";
                        resultModel = UpdatePOConfig(poconfigModel);
                    }


                    if (resultModel.IsSuccess)
                    {
                        var poconfigModel1 = (POConfigModel)poconfigModel;

                        tupleModel = new Tuple<InfoBarViewModel, POConfigModel>(infoBarViewModel1, poconfigModel1);

                        SetSessionMessage(result + " Success");
                        InsertActionLog(result, result + " POVisitPage", poconfigModel1.ID, "1900-01-01", HttpContext.Session.GetString("_userId"), "POConfigPage");


                        var directAction = "POConfigPage";

                        return RedirectToAction(directAction, new { scn = scn });
                    }
                    else
                    {
                        SetSessionMessage(resultModel.Message);
                    }
                }
                catch (Exception ex1)
                {
                    SetSessionMessage(ex1.Message);
                    throw ex1;
                }

                InsertActionLog(result, result + " InitAssess", scn, "1900-01-01", HttpContext.Session.GetString("_userId"), "InitAssess");
                tupleModel = new Tuple<InfoBarViewModel, POConfigModel>(infoBarViewModel1, poconfigModel);
                return View(tupleModel);

            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Message = " + ex.Message;

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "InitAssess POST", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));
                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }
        }
        private ResultModel UpdatePOConfig(POConfigModel poconfigModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/POConfigs/" + 1;
            var client1 = new HttpClient();

            string content = JsonConvert.SerializeObject(poconfigModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = client1.PutAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;

        }
        private ResultModel InsertPOConfig(POConfigModel poconfigModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/POConfigs/";
            var client1 = new HttpClient();

            string content = JsonConvert.SerializeObject(poconfigModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = client1.PostAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;
        }

        public ActionResult POEvaluationPage(string scn)
        {
            try
            {
                if (!IsLogin())
                {
                    return RedirectToReLoginPage();
                }
                var poevaluationModel = new POEvaluationModel();
                poevaluationModel = (POEvaluationModel)GetPOEvaluation(scn);
                if (poevaluationModel.SCN == null)
                {
                    poevaluationModel = new POEvaluationModel().SetDefaultValue(scn);

                    // poevaluationModel.PODOC = GetPODOC(scn);
                }
                //if (DOB == null)
                //{
                //    poconfigModel = new POConfigModel().SetDefaultValue();
                //}
                //else
                //{
                //    poconfigModel = (POConfigModel)GetConfig();
                //}
                var infoBarViewModel = GetInfoBarViewModels(scn);
                var uploadDocument = new UploadDocumentViewModel();
                uploadDocument.Filename = "";
                uploadDocument.Description = "";
                var tupleModel = new Tuple<InfoBarViewModel, POEvaluationModel, UploadDocumentLoyoutViewModel>(infoBarViewModel, poevaluationModel, (UploadDocumentLoyoutViewModel)uploadDocument);
                return View(tupleModel);
            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to Search Recrod";

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Search", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }
        }

        private POEvaluationModel GetPOEvaluation(string scn)
        {

            var poevaluationModel = new POEvaluationModel();
            try
            {
                var baseAddress = "Http://" + Request.Host.ToString();
                var link = $"/api/POEvaluations/" + scn;
                var client = new HttpClient();

                HttpResponseMessage response = client.GetAsync(baseAddress + link).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                var stringResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
                var listpoevaluationModel = JsonConvert.DeserializeObject<List<POEvaluationModel>>(resultModel.Data.ToString());
                poevaluationModel = listpoevaluationModel[0];

            }

            catch (Exception ex)
            {
                var gUIDNumner = Guid.NewGuid();

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Search", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));
            }

            return poevaluationModel;
        }
        [HttpPost]
        public ActionResult POEvaluationPage(InfoBarViewModel infoBarViewModel, POEvaluationModel poevaluationModel, UploadDocumentLoyoutViewModel uploadDocumentLoyoutViewModel)
        {
            try
            {
                var result = "";
                var scn = infoBarViewModel.SCN;

                Tuple<InfoBarViewModel, POEvaluationModel> tupleModel;
                ResultModel resultModel;
                var infoBarViewModel1 = GetInfoBarViewModels(scn);
                try
                {
                    var newpoevaluationModel = GetPOEvaluation(scn);
                    if (newpoevaluationModel.SCN == null)
                    {
                        result = "Create";
                        resultModel = InsertPOEvaluation(poevaluationModel);
                    }
                    else
                    {
                        result = "Udpate";
                        resultModel = UpdatePOEvaluation(poevaluationModel);
                    }
                    if (uploadDocumentLoyoutViewModel.file != null)
                    {

                        var filePath = Path.Combine(
                          Directory.GetCurrentDirectory(), "wwwroot",
                          uploadDocumentLoyoutViewModel.file.FileName);

                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            uploadDocumentLoyoutViewModel.file.CopyTo(stream);
                        }
                        if (filePath != null)
                            Insertuploadcsv(poevaluationModel, Path.GetFileName(uploadDocumentLoyoutViewModel.file.FileName));
                    }

                    if (resultModel.IsSuccess)
                    {
                        var poevaluationModel1 = (POEvaluationModel)poevaluationModel;

                        tupleModel = new Tuple<InfoBarViewModel, POEvaluationModel>(infoBarViewModel1, poevaluationModel);

                        SetSessionMessage(result + " Success");
                        InsertActionLog(result, result + " POVisitPage", poevaluationModel1.SCN, "1900-01-01", HttpContext.Session.GetString("_userId"), "POEvaluationPage");


                        var directAction = "POEvaluationPage";

                        return RedirectToAction(directAction, new { scn = scn });
                    }
                    else
                    {
                        SetSessionMessage(resultModel.Message);
                    }
                }
                catch (Exception ex1)
                {
                    SetSessionMessage(ex1.Message);
                    throw ex1;
                }

                InsertActionLog(result, result + " InitAssess", scn, "1900-01-01", HttpContext.Session.GetString("_userId"), "InitAssess");
                tupleModel = new Tuple<InfoBarViewModel, POEvaluationModel>(infoBarViewModel1, poevaluationModel);
                return View(tupleModel);

            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Message = " + ex.Message;

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "InitAssess POST", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));
                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }
        }
        private string Insertuploadcsv(POEvaluationModel poevaluationModel, string filepath)
        {
            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/POEvaluations/insertcsv/" + filepath;
            var client1 = new HttpClient();

            string content = JsonConvert.SerializeObject(poevaluationModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = client1.PutAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return "";
        }
        private ResultModel UpdatePOEvaluation(POEvaluationModel poevaluationModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/POEvaluations/" + poevaluationModel.SCN.ToString();
            var client1 = new HttpClient();

            string content = JsonConvert.SerializeObject(poevaluationModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = client1.PutAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;

        }
        private ResultModel InsertPOEvaluation(POEvaluationModel poevaluationModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/POEvaluations/";
            var client1 = new HttpClient();

            string content = JsonConvert.SerializeObject(poevaluationModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = client1.PostAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;
        }
        public ActionResult POReport(string scn)
        {
            try
            {
                if (!IsLogin())
                {
                    return RedirectToReLoginPage();
                }
                var poconfigModel = new POConfigModel();
                poconfigModel = (POConfigModel)GetConfig();
                var poevaluationModel = new POEvaluationModel();
                poevaluationModel = (POEvaluationModel)GetPOEvaluation(scn);
                if (poevaluationModel.SCN == null)
                {
                    poevaluationModel = poevaluationModel.SetDefaultValue(scn);
                }
                var poImportModel = new POImportModel();
                var listpoImportModel = new List<POImportModel>();
                listpoImportModel = GetPOImport(poevaluationModel.Chip);
                var poimportviewModel = new POImportViewModel();
                List<double> listValue = new List<double>();
                List<string> listdatetime = new List<string>();
                List<double> listAvg = new List<double>();
                List<double> listUpper = new List<double>();
                List<double> listLower = new List<double>();
                double sum = 0;
                int count = 0;
                if (listpoImportModel == null)
                {
                    poimportviewModel.SetDefaultValue();
                }
                else
                {
                    foreach (var poImportModelitem in listpoImportModel)
                    {
                        if (poImportModelitem.Serial != null)
                        {
                            listValue.Add(Convert.ToDouble(poImportModelitem.Value));
                            // listdatetime.Add(count.ToString());
                            // count = count + 1;
                            listdatetime.Add(poImportModelitem.Date);// + ' ' + poImportModelitem.Time);
                            sum += Convert.ToDouble(poImportModelitem.Value);
                            count++;
                        }
                    }
                    double avg = sum / count;
                    double upper = Convert.ToDouble(poconfigModel.Hour) + Convert.ToDouble(poconfigModel.MinHour); ;
                    double lower = Convert.ToDouble(poconfigModel.Hour);
                    double hit = 0;
                    foreach (var poImportModelitem in listpoImportModel)
                    {
                        if (poImportModelitem.Serial != null)
                        {
                            var val = Convert.ToDouble(poImportModelitem.Value);
                            listAvg.Add(avg);
                            listUpper.Add(upper);
                            listLower.Add(lower);
                            if (val >= lower && val <= upper)
                            {
                                hit++;
                            }
                        }
                    }
                    poimportviewModel.avg = JsonConvert.SerializeObject(listAvg);
                    poimportviewModel.upper = JsonConvert.SerializeObject(listUpper);
                    poimportviewModel.lower = JsonConvert.SerializeObject(listLower);
                    poimportviewModel.datapoints = JsonConvert.SerializeObject(listValue);//.ToArray();
                    poimportviewModel.total = count.ToString();
                    poimportviewModel.count = hit.ToString();
                    poimportviewModel.percentage = ((hit / count) * 100).ToString() + "%";
                    //poimportviewModel.labels = listdatetime;
                    ViewBag.Exponate = poimportviewModel.labels = Newtonsoft.Json.JsonConvert.SerializeObject(listdatetime).Replace(@"""", "'").Replace(@"\", @""); ;
                }
                // poimportviewModel.labels = JsonConvert.SerializeObject(listdatetime).Replace(@"""", "O").Replace(@"\", @""); //.ToArray();
                // var json = JsonConvert.SerializeObject(listValue);
                // poImportModel = (POImportModel)GetPOImport(poevaluationModel.Chip);
                var infoBarViewModel = GetInfoBarViewModels(scn);
                var tupleModel = new Tuple<InfoBarViewModel, POEvaluationModel, POImportViewModel, POConfigModel>(infoBarViewModel, poevaluationModel, poimportviewModel, poconfigModel);
                return View(tupleModel);
            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to Show Record";

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "POImport", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }
        }
        private List<POImportModel> GetPOImport(string Chip)
        {

            var poImportModel = new POImportModel();
            try
            {
                var baseAddress = "Http://" + Request.Host.ToString();
                var link = $"/api/POImports/" + Chip;
                var client = new HttpClient();

                HttpResponseMessage response = client.GetAsync(baseAddress + link).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                var stringResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
                var listpoImportModel = JsonConvert.DeserializeObject<List<POImportModel>>(resultModel.Data.ToString());
                return listpoImportModel;
            }

            catch (Exception ex)
            {
                var gUIDNumner = Guid.NewGuid();

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "GetPOImport", returnExMessage(ex), Chip + ':' + returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));
                return null;
            }


        }
        public ActionResult POVisitDelete(string scn, string doc)
        {
            try
            {
                // var infoVisitModel = GetinfoVisitModel(scn, ConvertUrlDateForm(doc)).Result;
                var povisitModel = new POVisitModel();
                povisitModel = (POVisitModel)GetPOVisit(scn, doc);
                DeletePOVisitAPI(povisitModel);

            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Message = " + ex.Message;

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "POVisit POST", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }
            return RedirectToAction("./VisitList", new { scn = scn });
        }
        private ResultModel DeletePOVisitAPI(POVisitModel povisitModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();


            var link = $"/api/POVisits/" + povisitModel.SCN + "/" + povisitModel.DOC.Value.ToString("yyyy-MM-dd");
            var client1 = new HttpClient();
            HttpResponseMessage response = client1.DeleteAsync(baseAddress + link).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;
        }
        public ActionResult POEvaluationDelete(string scn)
        {
            try
            {
                // var infoVisitModel = GetinfoVisitModel(scn, ConvertUrlDateForm(doc)).Result;
                var poevaluationModel = new POEvaluationModel();
                poevaluationModel = (POEvaluationModel)GetPOEvaluation(scn);
                DeletePOEvaluationAPI(poevaluationModel);

            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Message = " + ex.Message;

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "POVisit POST", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }
            return RedirectToAction("./VisitList", new { scn = scn });
        }
        private ResultModel DeletePOEvaluationAPI(POEvaluationModel poevaluationModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();


            var link = $"/api/POEvaluations/" + poevaluationModel.SCN;
            var client1 = new HttpClient();
            HttpResponseMessage response = client1.DeleteAsync(baseAddress + link).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;
        }

        //2020-9-2 by Eddie Lok
        public ActionResult PhysioPage(string scn, string DOB)
        {
            try
            {
                if (!IsLogin())
                {
                    return RedirectToReLoginPage();
                }
                var physioModel = new PhysioModel();

                if (DOB == null)
                {
                    physioModel = new PhysioModel().SetDefaultValue(scn);
                }
                else
                {
                    physioModel = (PhysioModel)GetPhysio(scn, DOB);
                }
                var infoBarViewModel = GetInfoBarViewModels(scn);
                var tupleModel = new Tuple<InfoBarViewModel, PhysioModel>(infoBarViewModel, physioModel);
                return View(tupleModel);
            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to Search Recrod";

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Search", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }
        }
        private PhysioModel GetPhysio(string scn, string DOC)
        {

            var physioModel = new PhysioModel();
            var dateTime = DateTime.Parse(DOC);
            var dob = dateTime.ToString("yyyy-MM-dd");
            try
            {
                var baseAddress = "Http://" + Request.Host.ToString();
                var link = $"/api/Physios/" + scn + "/" + dob;
                var client = new HttpClient();

                HttpResponseMessage response = client.GetAsync(baseAddress + link).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                var stringResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
                var listPhysiotModel = JsonConvert.DeserializeObject<List<PhysioModel>>(resultModel.Data.ToString());
                physioModel = listPhysiotModel[0];
            }

            catch (Exception ex)
            {
                var gUIDNumner = Guid.NewGuid();

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Search", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));
            }

            return physioModel;
        }

        private async Task<List<string>> GetPhysioList(string scn)
        {

            var baseAddress1 = "Http://" + Request.Host.ToString();
            var link2 = $"/api/Physios/" + scn;
            var client2 = new HttpClient();
            var tempStringList = new List<string>();

            try
            {
                HttpResponseMessage response2 = await client2.GetAsync(baseAddress1 + link2);
                response2.EnsureSuccessStatusCode();

                var stringResult2 = await response2.Content.ReadAsStringAsync();
                ResultModel resultModel2 = JsonConvert.DeserializeObject<ResultModel>(stringResult2);
                var visitsModels = JsonConvert.DeserializeObject<List<string>>(resultModel2.Data.ToString());


                for (var i = 0; i < visitsModels.Count(); i++)
                {
                    tempStringList.Add(visitsModels[i]);
                }
            }
            catch (Exception ex)
            {
                //Should add log
            }

            return tempStringList;
        }
        [HttpPost]
        public ActionResult PhysioPage(InfoBarViewModel infoBarViewModel, PhysioModel physioModel)
        {
            try
            {
                var result = "";
                var scn = physioModel.SCN;

                Tuple<InfoBarViewModel, PhysioModel> tupleModel;
                ResultModel resultModel;
                var infoBarViewModel1 = GetInfoBarViewModels(scn);
                try
                {
                    var newposvisitModel = GetPhysio(physioModel.SCN, physioModel.DOC.ToString());
                    if (newposvisitModel.DOC == null)
                    {
                        result = "Create";
                        resultModel = InsertPhysio(physioModel);
                    }
                    else
                    {
                        result = "Udpate";
                        resultModel = UpdatePhysio(physioModel);
                    }


                    if (resultModel.IsSuccess)
                    {
                        var povisitModel1 = (PhysioModel)physioModel;

                        tupleModel = new Tuple<InfoBarViewModel, PhysioModel>(infoBarViewModel1, physioModel);

                        SetSessionMessage(result + " Success");
                        InsertActionLog(result, result + " PhysioPage", physioModel.SCN, "1900-01-01", HttpContext.Session.GetString("_userId"), "PhysioPage");


                        var directAction = "PhysioPage";

                        return RedirectToAction(directAction, new { scn = scn, dob = physioModel.DOC.Value.ToString("yyyy-MM-dd") });
                    }
                    else
                    {
                        SetSessionMessage(resultModel.Message);
                    }
                }
                catch (Exception ex1)
                {
                    SetSessionMessage(ex1.Message);
                    throw ex1;
                }

                InsertActionLog(result, result + " InitAssess", scn, "1900-01-01", HttpContext.Session.GetString("_userId"), "InitAssess");
                tupleModel = new Tuple<InfoBarViewModel, PhysioModel>(infoBarViewModel1, physioModel);
                return View(tupleModel);

            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Message = " + ex.Message;

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "InitAssess POST", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));
                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }
        }
        private ResultModel UpdatePhysio(PhysioModel physioModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/Physios/" + physioModel.SCN;
            var client1 = new HttpClient();

            string content = JsonConvert.SerializeObject(physioModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = client1.PutAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;

        }
        private ResultModel InsertPhysio(PhysioModel physioModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/Physios/";
            var client1 = new HttpClient();

            string content = JsonConvert.SerializeObject(physioModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = client1.PostAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;
        }
        public ActionResult PhysioDelete(string scn, string doc)
        {
            try
            {
                var physioModel = new PhysioModel();
                physioModel = (PhysioModel)GetPhysio(scn, doc);
                DeletePhysioAPI(physioModel);

            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Message = " + ex.Message;

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Physio POST", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }
            return RedirectToAction("./VisitList", new { scn = scn });
        }
        private ResultModel DeletePhysioAPI(PhysioModel physioModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();


            var link = $"/api/Physios/" + physioModel.SCN + "/" + physioModel.DOC.Value.ToString("yyyy-MM-dd");
            var client1 = new HttpClient();
            HttpResponseMessage response = client1.DeleteAsync(baseAddress + link).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;
        }
        private PatientSearchViewModel GetPersonalInfoModelHKID(string hkid)
        {
            var baseAddress = "Http://" + Request.Host.ToString();

            var searchString = returnSearchString("", "", hkid, "", "", "", "", "", "", "", "");
            var link = $"/api/PersonalInfos/" + "" + "/" + "" + "/" + searchString;
            var client = new HttpClient();

            HttpResponseMessage response = client.GetAsync(baseAddress + link).GetAwaiter().GetResult();
            response.EnsureSuccessStatusCode();
            var stringResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
            var personalInfos = JsonConvert.DeserializeObject<List<PersonalInfoModel>>(resultModel.Data.ToString());
            var patientSearchViewModel = setPatientSearchViewModel("", "", hkid, "", "", "", "", "", "", "", "");
            return patientSearchViewModel;
        }
        private List<PODOCModel> GetPODOC(string scn)
        {

            var poDOCModel = new PODOCModel();
            try
            {
                var baseAddress = "Http://" + Request.Host.ToString();
                var link = $"/api/PODOCs/0/" + scn;
                var client = new HttpClient();
                var listpoDOCModel = new List<PODOCModel>();
                HttpResponseMessage response = client.GetAsync(baseAddress + link).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                var stringResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
                listpoDOCModel = JsonConvert.DeserializeObject<List<PODOCModel>>(resultModel.Data.ToString());
                return listpoDOCModel;
            }

            catch (Exception ex)
            {
                var gUIDNumner = Guid.NewGuid();

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Search", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));
                return null;
            }
        }
        public ActionResult PODOCPage(string scn)
        {
            try
            {
                if (!IsLogin())
                {
                    return RedirectToReLoginPage();
                }
                var listpoDOCModel = new List<PODOCModel>();
                listpoDOCModel = GetPODOC(scn);

                var infoBarViewModel = GetInfoBarViewModels(scn);
                var uploadDocument = new UploadDocumentViewModel();
                uploadDocument.Filename = "";
                uploadDocument.Description = "";
                var tupleModel = new Tuple<InfoBarViewModel, List<PODOCModel>, UploadDocumentLoyoutViewModel>(infoBarViewModel, listpoDOCModel, (UploadDocumentLoyoutViewModel)uploadDocument);
                return View(tupleModel);
            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to Search Recrod";

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "Search", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }
        }
        [HttpPost]
        public ActionResult PODOCPage(InfoBarViewModel infoBarViewModel, PODOCModel podocModel, UploadDocumentLoyoutViewModel uploadDocumentLoyoutViewModel)
        {
            try
            {
                var result = "";
                var scn = podocModel.SCN;

                Tuple<InfoBarViewModel, List<PODOCModel>, UploadDocumentLoyoutViewModel> tupleModel;
                ResultModel resultModel;
                var infoBarViewModel1 = GetInfoBarViewModels(scn);
                try
                {

                    //var newpodocModel = GetPODOC(podocModel.SCN);
                    //if (newpodocModel == null)
                    //{
                    //    result = "Create";
                    //    resultModel = InsertPODOC(podocModel);
                    //}
                    //else
                    //{
                    //    result = "Udpate";
                    //    resultModel = UpdatePhysio(physioModel);
                    //}
                    if (uploadDocumentLoyoutViewModel.file != null)
                    {

                        var filePath = Path.Combine(
                          Directory.GetCurrentDirectory(), "wwwroot",
                          uploadDocumentLoyoutViewModel.file.FileName);

                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            uploadDocumentLoyoutViewModel.file.CopyTo(stream);
                        }
                        //  if (filePath != null)
                        //    Insertuploadcsv(podocModel, Path.GetFileName(uploadDocumentLoyoutViewModel.file.FileName));
                        podocModel.DOC = Path.GetFileName(uploadDocumentLoyoutViewModel.file.FileName);
                    }

                    resultModel = InsertPODOC(podocModel);

                    if (resultModel.IsSuccess)
                    {
                        var listpoDOCModel = GetPODOC(podocModel.SCN);
                        var uploadDocument = new UploadDocumentViewModel();
                        uploadDocument.Filename = "";
                        uploadDocument.Description = "";
                        tupleModel = new Tuple<InfoBarViewModel, List<PODOCModel>, UploadDocumentLoyoutViewModel>(infoBarViewModel, listpoDOCModel, (UploadDocumentLoyoutViewModel)uploadDocument);

                        SetSessionMessage(result + " Success");
                        InsertActionLog(result, result + " PODOCPage", podocModel.SCN, "1900-01-01", HttpContext.Session.GetString("_userId"), "PhysioPage");


                        var directAction = "PODOCPage";

                        return RedirectToAction(directAction, new { scn = scn });
                    }
                    else
                    {
                        SetSessionMessage(resultModel.Message);
                        var directAction = "PODOCPage";
                        return RedirectToAction(directAction, new { scn = scn });
                    }
                }
                catch (Exception ex1)
                {
                    SetSessionMessage(ex1.Message);
                    throw ex1;
                }

                //InsertActionLog(result, result + " InitAssess", scn, "1900-01-01", HttpContext.Session.GetString("_userId"), "InitAssess");
                //var listpoDOCModel = GetPODOC(podocModel.SCN);
                //var uploadDocument = new UploadDocumentViewModel();
                //uploadDocument.Filename = "";
                //uploadDocument.Description = "";
                //tupleModel = new Tuple<InfoBarViewModel, List<PODOCModel>, UploadDocumentLoyoutViewModel>(infoBarViewModel, listpoDOCModel, (UploadDocumentLoyoutViewModel)uploadDocument);
                //return View(tupleModel);

            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Message = " + ex.Message;

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "InitAssess POST", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));
                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }
        }
        private ResultModel UpdatePODOC(PODOCModel PODOCModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/PODOCs/" + PODOCModel.SCN;
            var client1 = new HttpClient();

            string content = JsonConvert.SerializeObject(PODOCModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = client1.PutAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;

        }
        private ResultModel InsertPODOC(PODOCModel PODOCModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/PODOCs/";
            var client1 = new HttpClient();

            string content = JsonConvert.SerializeObject(PODOCModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = client1.PostAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;
        }
        public ActionResult PODOCDelete(string scn, string Id)
        {
            try
            {
                var PODOCModel = new PODOCModel();
                PODOCModel.Id = Convert.ToInt64(Id);
                PODOCModel.SCN = scn;
                DeletePODOCAPI(PODOCModel);

            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Message = " + ex.Message;

                InsertErrorLog(SetErrorLogViewModel(gUIDNumner.ToString(), "PODOC POST", returnExMessage(ex), returninnerExceptionMessage(ex), HttpContext.Session.GetString("_userId").ToString()));

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }
            return RedirectToAction("./PODOCPage", new { scn = scn });
        }
        private ResultModel DeletePODOCAPI(PODOCModel PODOCModel)
        {

            var baseAddress = "Http://" + Request.Host.ToString();


            var link = $"/api/PODOCs/" + PODOCModel.Id;
            var client1 = new HttpClient();
            HttpResponseMessage response = client1.DeleteAsync(baseAddress + link).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;
        }
    }


}

public class testJson
{

    public string name { get; set; }
}
