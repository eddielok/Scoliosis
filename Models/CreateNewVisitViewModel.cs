using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Scoliosis.Models
{
    public class CreateNewVisitViewModel
    {
        public string SCN { get; set; }
        public string DOC { get; set; }
        public string Virtual { get; set; }

        public string Age { get; set; }

        public string HT { get; set; }

        public string ArmSpan { get; set; }

        public string LArmSpan { get; set; }

        public string RArmSpan { get; set; }

        public string SHT { get; set; }

        public string WT { get; set; }

        public string HGV { get; set; }

        public string ASGV { get; set; }

        public string LASGV { get; set; }

        public string RASGV { get; set; }

        public string SHTGV { get; set; }

        public string WGV { get; set; }

        public string isMenarchePos { get; set; }

        public string isMenarcheNeg { get; set; }

        public string MaturYear { get; set; }

        public string MaturMonth { get; set; }

        public string Jointhyper { get; set; }

        public string AbdReflexA { get; set; }

        public string AbdReflexB { get; set; }

        public string AbdReflexC { get; set; }

        public string AbdReflexD { get; set; }

        public string CTrunkShiftDir { get; set; }

        public string CTrunkShift { get; set; }

        public string R1Dir { get; set; }

        public string Rotat1 { get; set; }

        public string R2Dir { get; set; }

        public string Rotat2 { get; set; }

        public string R3Dir { get; set; }

        public string Rotat3 { get; set; }

        public string R4Dir { get; set; }

        public string Rotat4 { get; set; }

        public string ShoulderDir { get; set; }

        public string ShoulderAsy { get; set; }

        public string BreastTanner { get; set; }
        public string PubicTanner { get; set; }
        public string hair { get; set; }
        public string tricart { get; set; }
        public string trochanter { get; set; }
        public string FemoralHead { get; set; }
        public string withBrace { get; set; }
        public string CurveLevel1From { get; set; }
        public string CurveLevel1To { get; set; }
        public string CurveLevel2From { get; set; }
        public string CurveLevel2To { get; set; }
        public string CurveLevel3From { get; set; }
        public string CurveLevel3To { get; set; }
        public string CurveLevel4From { get; set; }
        public string CurveLevel4To { get; set; }
        public string CurveApex1 { get; set; }
        public string CurveApex2 { get; set; }
        public string CurveApex3 { get; set; }
        public string CurveApex4 { get; set; }
        public string AVTDir1 { get; set; }
        public string AVTDir2 { get; set; }
        public string AVTDir3 { get; set; }
        public string AVTDir4 { get; set; }

        public string AVTDeg1 { get; set; }
        public string AVTDeg2 { get; set; }
        public string AVTDeg3 { get; set; }
        public string AVTDeg4 { get; set; }


        public string CurveDir1 { get; set; }
        public string CurveDir2 { get; set; }
        public string CurveDir3 { get; set; }

        public string CurveDir4 { get; set; }
        public string withBraceS { get; set; }
        public string CurveLevel1FromS { get; set; }

        public string CurveLevel1ToS { get; set; }
        public string CurveLevel2FromS { get; set; }
        public string CurveLevel2ToS { get; set; }

        public string CurveLevel3FromS { get; set; }

        public string CurveLevel3ToS { get; set; }
        public string CurveLevel4FromS { get; set; }
        public string CurveLevel4ToS { get; set; }
        public string CurveDir1S { get; set; }
        public string CurveDir2S { get; set; }
        public string CurveDir3S { get; set; }
        public string CurveDir4S { get; set; }
        public string CurveApex1S { get; set; }
        public string CurveApex2S { get; set; }
        public string CurveApex3S { get; set; }
        public string CurveApex4S { get; set; }
        public string CurveDeg1S { get; set; }
        public string CurveDeg2S { get; set; }
        public string CurveDeg3S { get; set; }
        public string CurveDeg4S { get; set; }
        public string Thoracictype { get; set; }
        public string Lumbartype { get; set; }
        public string CurveDeg1 { get; set; }
        public string CurveDeg2 { get; set; }
        public string CurveDeg3 { get; set; }

        public string CurveDeg4 { get; set; }

        public string TrunkDir { get; set; }
        public string RTrunkShift { get; set; }

        public string ApicalDir1 { get; set; }
        public string ApicalDir2 { get; set; }
        public string ApicalDir3 { get; set; }
        public string ApicalDir4 { get; set; }
        public string ApicalRotation1 { get; set; }
        public string ApicalRotation2 { get; set; }
        public string ApicalRotation3 { get; set; }
        public string ApicalRotation4 { get; set; }
        public string RSign { get; set; }
        public string EpFusion { get; set; }
        public string ThoKyphosis { get; set; }
        public string LumLordosis { get; set; }
        public string PlanObs { get; set; }
        public string PlanBrace { get; set; }
        public string PlanBraceWeanTime { get; set; }

        public string PlanFUYear { get; set; }

        public string PlanFUMonth { get; set; }

        public string PlanFUWeek { get; set; }

        public string AfterBracing { get; set; }

        public string PRN { get; set; }

        public string PlanXray { get; set; }

        public string PlanSurgery { get; set; }

        public string DrName { get; set; }

        public string SpcRemarks { get; set; }

        public string LastModify { get; set; }

        //20200517 Add Field
        public string TOCI { get; set; }

        public string CurveDeg1Padding { get; set; }
        public string CurveDeg2Padding { get; set; }
        public string CurveDeg3Padding { get; set; }
        public string CurveDeg4Padding { get; set; }
        public string CurveDeg1Paddingcm { get; set; }
        public string CurveDeg2Paddingcm { get; set; }
        public string CurveDeg3Paddingcm { get; set; }
        public string CurveDeg4Paddingcm { get; set; }

        public string CurveDeg1Paddings { get; set; }
        public string CurveDeg2Paddings { get; set; }
        public string CurveDeg3Paddings { get; set; }
        public string CurveDeg4Paddings { get; set; }
        public string CurveDeg1Paddingcms { get; set; }
        public string CurveDeg2Paddingcms { get; set; }
        public string CurveDeg3Paddingcms { get; set; }
        public string CurveDeg4Paddingcms { get; set; }

        public string ScannogramTotalR { get; set; }
        public string ScannogramTotalL { get; set; }
        public string ScannogramFemurR { get; set; }
        public string ScannogramFemurL { get; set; }
        public string ScannogramTibiaR { get; set; }
        public string ScannogramTibiaL { get; set; }

        


        //By Eddie
        public List<string> PhotoList { get; set; }
        public string RootPath { get; set; }
        public List<string> XRayList { get; set; }

        public string XRayPath { get; set; }

        //By Eddie Change according to the meeing at 3/7, 10/7 and 31/7
        public string QoL { get; set; }
        public string RadSide1 { get; set; }
        public string RadSide2 { get; set; }
        public string RadSide3 { get; set; }
        public string RadSide4 { get; set; }
        public string RadDeg1 { get; set; }
        public string RadDeg2 { get; set; }
        public string RadDeg3 { get; set; }
        public string RadDeg4 { get; set; }
        public string RadFlexibility1 { get; set; }
        public string RadFlexibility2 { get; set; }
        public string RadFlexibility3 { get; set; }
        public string RadFlexibility4 { get; set; }
        public CreateNewVisitViewModel SetDefaultValue(CreateNewVisitViewModel createNewVisitViewModel)
        {


            createNewVisitViewModel.SCN = createNewVisitViewModel.SCN;
            createNewVisitViewModel.DOC = DateTime.Now.ToString("dd/MM/yyyy");


            if (createNewVisitViewModel.Virtual == null)
                    createNewVisitViewModel.Virtual = "";

            if (createNewVisitViewModel.Age == null)
                createNewVisitViewModel.Age = "";

            if (createNewVisitViewModel.HT == null)
                createNewVisitViewModel.HT = "";

            if (createNewVisitViewModel.ArmSpan == null)
                createNewVisitViewModel.ArmSpan = "";

            if (createNewVisitViewModel.LArmSpan == null)
                createNewVisitViewModel.LArmSpan = "";

            if (createNewVisitViewModel.RArmSpan == null)
                createNewVisitViewModel.RArmSpan = "";

            if (createNewVisitViewModel.SHT == null)
                createNewVisitViewModel.SHT = "";

            if (createNewVisitViewModel.WT == null)
                createNewVisitViewModel.WT = "";

            if (createNewVisitViewModel.HGV == null)
                createNewVisitViewModel.HGV = "";

            if (createNewVisitViewModel.ASGV == null)
                createNewVisitViewModel.ASGV = "";

            if (createNewVisitViewModel.LASGV == null)
                createNewVisitViewModel.LASGV = "";

            if (createNewVisitViewModel.RASGV == null)
                createNewVisitViewModel.RASGV = "";

            if (createNewVisitViewModel.SHTGV == null)
                createNewVisitViewModel.SHTGV = "";

            if (createNewVisitViewModel.WGV == null)
                createNewVisitViewModel.WGV = "";

            if (createNewVisitViewModel.isMenarchePos == null)
                createNewVisitViewModel.isMenarchePos = "";

            if (createNewVisitViewModel.isMenarcheNeg == null)
                createNewVisitViewModel.isMenarcheNeg = "";

            if (createNewVisitViewModel.MaturYear == null)
                createNewVisitViewModel.MaturYear = "";

            if (createNewVisitViewModel.MaturMonth == null)
                createNewVisitViewModel.MaturMonth = "";

            if (createNewVisitViewModel.Jointhyper == null)
                createNewVisitViewModel.Jointhyper = "";

            if (createNewVisitViewModel.AbdReflexA == null)
                createNewVisitViewModel.AbdReflexA = "";

            if (createNewVisitViewModel.AbdReflexB == null)
                createNewVisitViewModel.AbdReflexB = "";

            if (createNewVisitViewModel.AbdReflexC == null)
                createNewVisitViewModel.AbdReflexC = "";

            if (createNewVisitViewModel.AbdReflexD == null)
                createNewVisitViewModel.AbdReflexD = "";

            if (createNewVisitViewModel.CTrunkShiftDir == null)
                createNewVisitViewModel.CTrunkShiftDir = "";

            if (createNewVisitViewModel.CTrunkShift == null)
                createNewVisitViewModel.CTrunkShift = "";

            if (createNewVisitViewModel.R1Dir == null)
                createNewVisitViewModel.R1Dir = "";

            if (createNewVisitViewModel.Rotat1 == null)
                createNewVisitViewModel.Rotat1 = "";

            if (createNewVisitViewModel.R2Dir == null)
                createNewVisitViewModel.R2Dir = "";

            if (createNewVisitViewModel.Rotat2 == null)
                createNewVisitViewModel.Rotat2 = "";

            if (createNewVisitViewModel.R3Dir == null)
                createNewVisitViewModel.R3Dir = "";

            if (createNewVisitViewModel.Rotat3 == null)
                createNewVisitViewModel.Rotat3 = "";

            if (createNewVisitViewModel.R4Dir == null)
                createNewVisitViewModel.R4Dir = "";

            if (createNewVisitViewModel.Rotat4 == null)
                createNewVisitViewModel.Rotat4 = "";

            if (createNewVisitViewModel.ShoulderDir == null)
                createNewVisitViewModel.ShoulderDir = "";

            if (createNewVisitViewModel.ShoulderAsy == null)
                createNewVisitViewModel.ShoulderAsy = "";

            if (createNewVisitViewModel.BreastTanner == null)
                createNewVisitViewModel.BreastTanner = "";

            if (createNewVisitViewModel.PubicTanner == null)
                createNewVisitViewModel.PubicTanner = "";

            if (createNewVisitViewModel.hair == null)
                createNewVisitViewModel.hair = "";

            if (createNewVisitViewModel.tricart == null)
                createNewVisitViewModel.tricart = "";

            if (createNewVisitViewModel.trochanter == null)
                createNewVisitViewModel.trochanter = "";

            if (createNewVisitViewModel.FemoralHead == null)
                createNewVisitViewModel.FemoralHead = "";

            if (createNewVisitViewModel.withBrace == null)
                createNewVisitViewModel.withBrace = "";

            if (createNewVisitViewModel.CurveLevel1From == null)
                createNewVisitViewModel.CurveLevel1From = "";

            if (createNewVisitViewModel.CurveLevel1To == null)
                createNewVisitViewModel.CurveLevel1To = "";

            if (createNewVisitViewModel.CurveLevel2From == null)
                createNewVisitViewModel.CurveLevel2From = "";

            if (createNewVisitViewModel.CurveLevel2To == null)
                createNewVisitViewModel.CurveLevel2To = "";

            if (createNewVisitViewModel.CurveLevel3From == null)
                createNewVisitViewModel.CurveLevel3From = "";

            if (createNewVisitViewModel.CurveLevel3To == null)
                createNewVisitViewModel.CurveLevel3To = "";

            if (createNewVisitViewModel.CurveLevel4From == null)
                createNewVisitViewModel.CurveLevel4From = "";

            if (createNewVisitViewModel.CurveLevel4To == null)
                createNewVisitViewModel.CurveLevel4To = "";

            if (createNewVisitViewModel.CurveApex1 == null)
                createNewVisitViewModel.CurveApex1 = "";

            if (createNewVisitViewModel.CurveApex2 == null)
                createNewVisitViewModel.CurveApex2 = "";

            if (createNewVisitViewModel.CurveApex3 == null)
                createNewVisitViewModel.CurveApex3 = "";

            if (createNewVisitViewModel.CurveApex4 == null)
                createNewVisitViewModel.CurveApex4 = "";

            if (createNewVisitViewModel.AVTDir1 == null)
                createNewVisitViewModel.AVTDir1 = "";

            if (createNewVisitViewModel.AVTDir2 == null)
                createNewVisitViewModel.AVTDir2 = "";

            if (createNewVisitViewModel.AVTDir3 == null)
                createNewVisitViewModel.AVTDir3 = "";

            if (createNewVisitViewModel.AVTDir4 == null)
                createNewVisitViewModel.AVTDir4 = "";

            if (createNewVisitViewModel.AVTDeg1 == null)
                createNewVisitViewModel.AVTDeg1 = "";

            if (createNewVisitViewModel.AVTDeg2 == null)
                createNewVisitViewModel.AVTDeg2 = "";

            if (createNewVisitViewModel.AVTDeg3 == null)
                createNewVisitViewModel.AVTDeg3 = "";

            if (createNewVisitViewModel.AVTDeg4 == null)
                createNewVisitViewModel.AVTDeg4 = "";

            if (createNewVisitViewModel.CurveDir1 == null)
                createNewVisitViewModel.CurveDir1 = "";

            if (createNewVisitViewModel.CurveDir2 == null)
                createNewVisitViewModel.CurveDir2 = "";

            if (createNewVisitViewModel.CurveDir3 == null)
                createNewVisitViewModel.CurveDir3 = "";

            if (createNewVisitViewModel.CurveDir4 == null)
                createNewVisitViewModel.CurveDir4 = "";

            if (createNewVisitViewModel.withBraceS == null)
                createNewVisitViewModel.withBraceS = "";

            if (createNewVisitViewModel.CurveLevel1FromS == null)
                createNewVisitViewModel.CurveLevel1FromS = "";

            if (createNewVisitViewModel.CurveLevel1ToS == null)
                createNewVisitViewModel.CurveLevel1ToS = "";

            if (createNewVisitViewModel.CurveLevel2FromS == null)
                createNewVisitViewModel.CurveLevel2FromS = "";

            if (createNewVisitViewModel.CurveLevel2ToS == null)
                createNewVisitViewModel.CurveLevel2ToS = "";

            if (createNewVisitViewModel.CurveLevel3FromS == null)
                createNewVisitViewModel.CurveLevel3FromS = "";

            if (createNewVisitViewModel.CurveLevel3ToS == null)
                createNewVisitViewModel.CurveLevel3ToS = "";

            if (createNewVisitViewModel.CurveLevel4FromS == null)
                createNewVisitViewModel.CurveLevel4FromS = "";

            if (createNewVisitViewModel.CurveLevel4ToS == null)
                createNewVisitViewModel.CurveLevel4ToS = "";

            if (createNewVisitViewModel.CurveDir1S == null)
                createNewVisitViewModel.CurveDir1S = "";

            if (createNewVisitViewModel.CurveDir2S == null)
                createNewVisitViewModel.CurveDir2S = "";

            if (createNewVisitViewModel.CurveDir3S == null)
                createNewVisitViewModel.CurveDir3S = "";

            if (createNewVisitViewModel.CurveDir4S == null)
                createNewVisitViewModel.CurveDir4S = "";

            if (createNewVisitViewModel.CurveApex1S == null)
                createNewVisitViewModel.CurveApex1S = "";

            if (createNewVisitViewModel.CurveApex2S == null)
                createNewVisitViewModel.CurveApex2S = "";

            if (createNewVisitViewModel.CurveApex3S == null)
                createNewVisitViewModel.CurveApex3S = "";

            if (createNewVisitViewModel.CurveApex4S == null)
                createNewVisitViewModel.CurveApex4S = "";

            if (createNewVisitViewModel.CurveDeg1S == null)
                createNewVisitViewModel.CurveDeg1S = "";

            if (createNewVisitViewModel.CurveDeg2S == null)
                createNewVisitViewModel.CurveDeg2S = "";

            if (createNewVisitViewModel.CurveDeg3S == null)
                createNewVisitViewModel.CurveDeg3S = "";

            if (createNewVisitViewModel.CurveDeg4S == null)
                createNewVisitViewModel.CurveDeg4S = "";

            if (createNewVisitViewModel.Thoracictype == null)
                createNewVisitViewModel.Thoracictype = "";

            if (createNewVisitViewModel.Lumbartype == null)
                createNewVisitViewModel.Lumbartype = "";

            if (createNewVisitViewModel.CurveDeg1 == null)
                createNewVisitViewModel.CurveDeg1 = "";

            if (createNewVisitViewModel.CurveDeg2 == null)
                createNewVisitViewModel.CurveDeg2 = "";

            if (createNewVisitViewModel.CurveDeg3 == null)
                createNewVisitViewModel.CurveDeg3 = "";

            if (createNewVisitViewModel.CurveDeg4 == null)
                createNewVisitViewModel.CurveDeg4 = "";

            if (createNewVisitViewModel.TrunkDir == null)
                createNewVisitViewModel.TrunkDir = "";

            if (createNewVisitViewModel.RTrunkShift == null)
                createNewVisitViewModel.RTrunkShift = "";

            if (createNewVisitViewModel.ApicalDir1 == null)
                createNewVisitViewModel.ApicalDir1 = "";

            if (createNewVisitViewModel.ApicalDir2 == null)
                createNewVisitViewModel.ApicalDir2 = "";

            if (createNewVisitViewModel.ApicalDir3 == null)
                createNewVisitViewModel.ApicalDir3 = "";

            if (createNewVisitViewModel.ApicalDir4 == null)
                createNewVisitViewModel.ApicalDir4 = "";

            if (createNewVisitViewModel.ApicalRotation1 == null)
                createNewVisitViewModel.ApicalRotation1 = "";

            if (createNewVisitViewModel.ApicalRotation2 == null)
                createNewVisitViewModel.ApicalRotation2 = "";

            if (createNewVisitViewModel.ApicalRotation3 == null)
                createNewVisitViewModel.ApicalRotation3 = "";

            if (createNewVisitViewModel.ApicalRotation4 == null)
                createNewVisitViewModel.ApicalRotation4 = "";

            if (createNewVisitViewModel.RSign == null)
                createNewVisitViewModel.RSign = "";

            if (createNewVisitViewModel.EpFusion == null)
                createNewVisitViewModel.EpFusion = "";

            if (createNewVisitViewModel.ThoKyphosis == null)
                createNewVisitViewModel.ThoKyphosis = "";

            if (createNewVisitViewModel.LumLordosis == null)
                createNewVisitViewModel.LumLordosis = "";

            if (createNewVisitViewModel.PlanObs == null)
                createNewVisitViewModel.PlanObs = "";

            if (createNewVisitViewModel.PlanBrace == null)
                createNewVisitViewModel.PlanBrace = "";

            if (createNewVisitViewModel.PlanBraceWeanTime == null)
                createNewVisitViewModel.PlanBraceWeanTime = "";

            if (createNewVisitViewModel.PlanFUYear == null)
                createNewVisitViewModel.PlanFUYear = "";

            if (createNewVisitViewModel.PlanFUMonth == null)
                createNewVisitViewModel.PlanFUMonth = "";

            if (createNewVisitViewModel.PlanFUWeek == null)
                createNewVisitViewModel.PlanFUWeek = "";

            if (createNewVisitViewModel.AfterBracing == null)
                createNewVisitViewModel.AfterBracing = "";

            if (createNewVisitViewModel.PRN == null)
                createNewVisitViewModel.PRN = "";

            if (createNewVisitViewModel.PlanXray == null)
                createNewVisitViewModel.PlanXray = "";

            if (createNewVisitViewModel.PlanSurgery == null)
                createNewVisitViewModel.PlanSurgery = "";

            if (createNewVisitViewModel.DrName == null)
                createNewVisitViewModel.DrName = "";

            if (createNewVisitViewModel.SpcRemarks == null)
                createNewVisitViewModel.SpcRemarks = "";

            if (createNewVisitViewModel.LastModify == null)
                createNewVisitViewModel.LastModify = "";

            //By Eddie Change according to the meeing at 3/7, 10/7 and 31/7
            
            if (createNewVisitViewModel.QoL == null)
                createNewVisitViewModel.QoL = "";
            if (createNewVisitViewModel.RadSide1 == null)
                createNewVisitViewModel.RadSide1 = "";
            if (createNewVisitViewModel.RadSide2 == null)
                createNewVisitViewModel.RadSide2 = "";
            if (createNewVisitViewModel.RadSide3 == null)
                createNewVisitViewModel.RadSide3 = "";
            if (createNewVisitViewModel.RadSide4 == null)
                createNewVisitViewModel.RadSide4 = "";
            if (createNewVisitViewModel.RadDeg1 == null)
                createNewVisitViewModel.RadDeg1 = "";
            if (createNewVisitViewModel.RadDeg2 == null)
                createNewVisitViewModel.RadDeg2 = "";
            if (createNewVisitViewModel.RadDeg3 == null)
                createNewVisitViewModel.RadDeg3 = "";
            if (createNewVisitViewModel.RadDeg4 == null)
                createNewVisitViewModel.RadDeg4 = "";
            if (createNewVisitViewModel.RadFlexibility1 == null)
                createNewVisitViewModel.RadFlexibility1 = "";
            if (createNewVisitViewModel.RadFlexibility2 == null)
                createNewVisitViewModel.RadFlexibility2 = "";
            if (createNewVisitViewModel.RadFlexibility3 == null)
                createNewVisitViewModel.RadFlexibility3 = "";
            if (createNewVisitViewModel.RadFlexibility4 == null)
                createNewVisitViewModel.RadFlexibility4 = "";

            return createNewVisitViewModel;
        }

        public static explicit operator VisitsModel(CreateNewVisitViewModel createNewVisitViewModel)
        {
            var visitsModel = new VisitsModel();


            visitsModel.SCN = createNewVisitViewModel.SCN;


            if (createNewVisitViewModel.DOC == "" || createNewVisitViewModel.DOC == null)
            {
                visitsModel.DOC = null;
            }
            else
            {
                visitsModel.DOC = DateTime.ParseExact(createNewVisitViewModel.DOC, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }

            visitsModel.Virtual = createNewVisitViewModel.Virtual;

            if (createNewVisitViewModel.HT == null)
            {
                visitsModel.HT = null;
            }
            else
            {
                if (Double.TryParse(createNewVisitViewModel.HT, out Double result) == false)
                {
                    throw new Exception("HT should be numeric, e.g. 0.00");
                }

                visitsModel.HT = double.Parse(createNewVisitViewModel.HT);
            }

            if (createNewVisitViewModel.ArmSpan == "" || createNewVisitViewModel.ArmSpan == null)
            {
                visitsModel.ArmSpan = null;
            }
            else
            {
                if (Double.TryParse(createNewVisitViewModel.ArmSpan, out Double result) == false)
                {
                    throw new Exception("ArmSpan should be numeric, e.g. 0.00");
                }

                visitsModel.ArmSpan = double.Parse(createNewVisitViewModel.ArmSpan);
            }

            if (createNewVisitViewModel.LArmSpan == null)
            {
                visitsModel.LArmSpan = null;
            }
            else
            {
                if (Double.TryParse(createNewVisitViewModel.LArmSpan, out Double result) == false)
                {
                    throw new Exception("LArmSpan should be numeric, e.g. 0.00");
                }

                visitsModel.LArmSpan = Double.Parse(createNewVisitViewModel.LArmSpan);
            }

            if (createNewVisitViewModel.RArmSpan == null)
            {
                visitsModel.RArmSpan = null;
            }
            else
            {
                if (Double.TryParse(createNewVisitViewModel.RArmSpan, out Double result) == false)
                {
                    throw new Exception("RArmSpan should be numeric, e.g. 0.00");
                }

                visitsModel.RArmSpan = Double.Parse(createNewVisitViewModel.RArmSpan);
            }

            if (createNewVisitViewModel.SHT == null)
            {
                visitsModel.SHT = null;
            }
            else
            {
                if (Double.TryParse(createNewVisitViewModel.SHT, out Double result) == false)
                {
                    throw new Exception("SHT should be numeric, e.g. 0.00");
                }

                visitsModel.SHT = Double.Parse(createNewVisitViewModel.SHT);
            }

            if (createNewVisitViewModel.WT == null)
            {
                createNewVisitViewModel.WT = null;
            }
            else
            {

                if (Double.TryParse(createNewVisitViewModel.WT, out Double result) == false)
                {
                    throw new Exception("WT should be numeric, e.g. 0.00");
                }

                visitsModel.WT = Double.Parse(createNewVisitViewModel.WT);
            }


            if (createNewVisitViewModel.isMenarchePos == "true")
            {
                visitsModel.isMenarchePos = true;
            }
            else
            {
                visitsModel.isMenarchePos = false;
            }

            if (createNewVisitViewModel.isMenarcheNeg == "true")
            {
                visitsModel.isMenarcheNeg = true;
            }
            else
            {
                visitsModel.isMenarcheNeg = false;
            }


            if (createNewVisitViewModel.MaturYear == null)
            {
                visitsModel.MaturYear = null;
            }
            else
            {
                visitsModel.MaturYear = int.Parse(createNewVisitViewModel.MaturYear);
            }

            if (createNewVisitViewModel.MaturMonth == null)
            {
                visitsModel.MaturMonth = null;
            }
            else
            {
                visitsModel.MaturMonth = int.Parse(createNewVisitViewModel.MaturMonth);
            }

            visitsModel.Jointhyper = createNewVisitViewModel.Jointhyper;

            if (createNewVisitViewModel.AbdReflexA == null || createNewVisitViewModel.AbdReflexA.ToString() == "")
            {
                visitsModel.AbdReflexA = null;
            }
            else
            {
                visitsModel.AbdReflexA = createNewVisitViewModel.AbdReflexA.ToCharArray()[0];
            }

            if (createNewVisitViewModel.AbdReflexB == null || createNewVisitViewModel.AbdReflexB.ToString() == "")
            {
                visitsModel.AbdReflexB = null;
            }
            else
            {
                visitsModel.AbdReflexB = createNewVisitViewModel.AbdReflexB.ToCharArray()[0];
            }

            if (createNewVisitViewModel.AbdReflexC == null || createNewVisitViewModel.AbdReflexC.ToString() == "")
            {
                visitsModel.AbdReflexC = null;
            }
            else
            {
                visitsModel.AbdReflexC = createNewVisitViewModel.AbdReflexC.ToCharArray()[0];
            }

            if (createNewVisitViewModel.AbdReflexD == null || createNewVisitViewModel.AbdReflexD.ToString() == "")
            {
                visitsModel.AbdReflexD = null;
            }
            else
            {
                visitsModel.AbdReflexD = createNewVisitViewModel.AbdReflexD.ToCharArray()[0];
            }


            if (createNewVisitViewModel.CTrunkShiftDir == null || createNewVisitViewModel.CTrunkShiftDir.ToString() == "")
            {
                visitsModel.CTrunkShiftDir = null;
            }
            else
            {
                visitsModel.CTrunkShiftDir = createNewVisitViewModel.CTrunkShiftDir.ToCharArray()[0];
            }

            if (createNewVisitViewModel.CTrunkShift == null)
            {
                visitsModel.CTrunkShift = 0;
            }
            else
            {
                visitsModel.CTrunkShift = Double.Parse(createNewVisitViewModel.CTrunkShift);
            }

            visitsModel.R1Dir = createNewVisitViewModel.R1Dir;

            if (createNewVisitViewModel.Rotat1 == "" || createNewVisitViewModel.Rotat1 == null)
            {
                visitsModel.Rotat1 = null;
            }
            else
            {
                visitsModel.Rotat1 = Double.Parse(createNewVisitViewModel.Rotat1);
            }

            visitsModel.R2Dir = createNewVisitViewModel.R2Dir;

            if (createNewVisitViewModel.Rotat2 == "" || createNewVisitViewModel.Rotat2 == null)
            {
                visitsModel.Rotat2 = null;
            }
            else
            {
                visitsModel.Rotat2 = Double.Parse(createNewVisitViewModel.Rotat2);
            }

            visitsModel.R3Dir = createNewVisitViewModel.R3Dir;

            if (createNewVisitViewModel.Rotat3 == "" || createNewVisitViewModel.Rotat3 == null)
            {
                visitsModel.Rotat3 = null;
            }
            else
            {
                visitsModel.Rotat3 = Double.Parse(createNewVisitViewModel.Rotat3);
            }

            visitsModel.R4Dir = createNewVisitViewModel.R4Dir;

            if (createNewVisitViewModel.Rotat4 == "" || createNewVisitViewModel.Rotat4 == null)
            {
                visitsModel.Rotat4 = null;
            }
            else
            {
                visitsModel.Rotat4 = Double.Parse(createNewVisitViewModel.Rotat4);
            }


            visitsModel.ShoulderDir = createNewVisitViewModel.ShoulderDir;


            if (createNewVisitViewModel.ShoulderAsy == "" || createNewVisitViewModel.ShoulderAsy == null)
            {
                visitsModel.ShoulderAsy = null;
            }
            else
            {
                visitsModel.ShoulderAsy = Double.Parse(createNewVisitViewModel.ShoulderAsy);
            }

            visitsModel.BreastTanner = createNewVisitViewModel.BreastTanner;


            visitsModel.PubicTanner = createNewVisitViewModel.PubicTanner;

            visitsModel.hair = createNewVisitViewModel.PubicTanner;

            visitsModel.tricart = createNewVisitViewModel.tricart;

            visitsModel.trochanter = createNewVisitViewModel.trochanter;

            visitsModel.FemoralHead = createNewVisitViewModel.FemoralHead;


            if (createNewVisitViewModel.withBrace == "" || createNewVisitViewModel.withBrace == null)
            {
                visitsModel.withBrace = null;
            }
            else
            {
                visitsModel.withBrace = short.Parse(createNewVisitViewModel.withBrace);
            }


            visitsModel.CurveLevel1From = createNewVisitViewModel.CurveLevel1From;

            visitsModel.CurveLevel1To = createNewVisitViewModel.CurveLevel1To;

            visitsModel.CurveLevel2From = createNewVisitViewModel.CurveLevel2From;

            visitsModel.CurveLevel2To = createNewVisitViewModel.CurveLevel2To;

            visitsModel.CurveLevel3From = createNewVisitViewModel.CurveLevel3From;

            visitsModel.CurveLevel3To = createNewVisitViewModel.CurveLevel3To;

            visitsModel.CurveLevel4From = createNewVisitViewModel.CurveLevel4From;

            visitsModel.CurveLevel4To = createNewVisitViewModel.CurveLevel4To;

            visitsModel.CurveApex1 = createNewVisitViewModel.CurveApex1;

            visitsModel.CurveApex2 = createNewVisitViewModel.CurveApex1;

            visitsModel.CurveApex3 = createNewVisitViewModel.CurveApex1;

            visitsModel.CurveApex4 = createNewVisitViewModel.CurveApex1;


            if (createNewVisitViewModel.AVTDir1 == null || createNewVisitViewModel.AVTDir1.ToString() == "")
            {
                visitsModel.AVTDir1 = null;
            }
            else
            {
                visitsModel.AVTDir1 = createNewVisitViewModel.AVTDir1.ToCharArray()[0];
            }

            if (createNewVisitViewModel.AVTDir2 == null || createNewVisitViewModel.AVTDir2.ToString() == "")
            {
                visitsModel.AVTDir2 = null;
            }
            else
            {
                visitsModel.AVTDir2 = createNewVisitViewModel.AVTDir2.ToCharArray()[0];
            }

            if (createNewVisitViewModel.AVTDir3 == null || createNewVisitViewModel.AVTDir3.ToString() == "")
            {
                visitsModel.AVTDir3 = null;
            }
            else
            {
                visitsModel.AVTDir3 = createNewVisitViewModel.AVTDir3.ToCharArray()[0];
            }


            if (createNewVisitViewModel.AVTDir4 == null || createNewVisitViewModel.AVTDir4.ToString() == "")
            {
                visitsModel.AVTDir4 = null;
            }
            else
            {
                visitsModel.AVTDir4 = createNewVisitViewModel.AVTDir4.ToCharArray()[0];
            }


            if (createNewVisitViewModel.AVTDeg1 == "" || createNewVisitViewModel.AVTDeg1 == null)
            {
                visitsModel.AVTDeg1 = null;
            }
            else
            {
                visitsModel.AVTDeg1 = Double.Parse(createNewVisitViewModel.AVTDeg1);
            }

            if (createNewVisitViewModel.AVTDeg2 == "" || createNewVisitViewModel.AVTDeg2 == null)
            {
                visitsModel.AVTDeg2 = null;
            }
            else
            {
                visitsModel.AVTDeg2 = Double.Parse(createNewVisitViewModel.AVTDeg2);
            }

            if (createNewVisitViewModel.AVTDeg3 == "" || createNewVisitViewModel.AVTDeg3 == null)
            {
                visitsModel.AVTDeg3 = null;
            }
            else
            {
                visitsModel.AVTDeg3 = Double.Parse(createNewVisitViewModel.AVTDeg3);
            }

            if (createNewVisitViewModel.AVTDeg4 == "" || createNewVisitViewModel.AVTDeg4 == null)
            {
                visitsModel.AVTDeg4 = null;
            }
            else
            {
                visitsModel.AVTDeg4 = Double.Parse(createNewVisitViewModel.AVTDeg4);
            }

            visitsModel.CurveDir1 = createNewVisitViewModel.CurveDir1;

            visitsModel.CurveDir2 = createNewVisitViewModel.CurveDir2;

            visitsModel.CurveDir3 = createNewVisitViewModel.CurveDir3;

            visitsModel.CurveDir4 = createNewVisitViewModel.CurveDir4;

            visitsModel.ApicalDir1 = createNewVisitViewModel.ApicalDir1;

            visitsModel.ApicalDir2 = createNewVisitViewModel.ApicalDir2;

            visitsModel.ApicalDir3 = createNewVisitViewModel.ApicalDir3;

            visitsModel.ApicalDir4 = createNewVisitViewModel.ApicalDir4;

            if (createNewVisitViewModel.withBraceS == "" || createNewVisitViewModel.withBraceS == null)
            {
                visitsModel.withBraceS = null;
            }
            else
            {
                visitsModel.withBraceS = short.Parse(createNewVisitViewModel.withBraceS);
            }


            visitsModel.CurveLevel1FromS = createNewVisitViewModel.CurveLevel1FromS;

            visitsModel.CurveLevel1ToS = createNewVisitViewModel.CurveLevel1ToS;

            visitsModel.CurveLevel2FromS = createNewVisitViewModel.CurveLevel2FromS;

            visitsModel.CurveLevel2ToS = createNewVisitViewModel.CurveLevel2ToS;

            visitsModel.CurveLevel3FromS = createNewVisitViewModel.CurveLevel3FromS;

            visitsModel.CurveLevel3ToS = createNewVisitViewModel.CurveLevel3ToS;

            visitsModel.CurveLevel4FromS = createNewVisitViewModel.CurveLevel4FromS;

            visitsModel.CurveLevel4ToS = createNewVisitViewModel.CurveLevel4ToS;

            visitsModel.CurveDir1S = createNewVisitViewModel.CurveDir1S;

            visitsModel.CurveDir2S = createNewVisitViewModel.CurveDir2S;

            visitsModel.CurveDir1S = createNewVisitViewModel.CurveDir1S;

            visitsModel.CurveDir3S = createNewVisitViewModel.CurveDir3S;

            visitsModel.CurveDir4S = createNewVisitViewModel.CurveDir4S;

            visitsModel.CurveApex1S = createNewVisitViewModel.CurveApex1S;

            visitsModel.CurveApex2S = createNewVisitViewModel.CurveApex2S;

            visitsModel.CurveApex3S = createNewVisitViewModel.CurveApex3S;

            visitsModel.CurveApex4S = createNewVisitViewModel.CurveApex4S;


            if (createNewVisitViewModel.CurveDeg1S == "" || createNewVisitViewModel.CurveDeg1S == null)
            {
                visitsModel.CurveDeg1S = null;
            }
            else
            {
                visitsModel.CurveDeg1S = Double.Parse(createNewVisitViewModel.CurveDeg1S);
            }

            if (createNewVisitViewModel.CurveDeg2S == "" || createNewVisitViewModel.CurveDeg2S == null)
            {
                visitsModel.CurveDeg2S = null;
            }
            else
            {
                visitsModel.CurveDeg2S = Double.Parse(createNewVisitViewModel.CurveDeg2S);
            }

            if (createNewVisitViewModel.CurveDeg3S == "" || createNewVisitViewModel.CurveDeg3S == null)
            {
                visitsModel.CurveDeg3S = null;
            }
            else
            {
                visitsModel.CurveDeg3S = Double.Parse(createNewVisitViewModel.CurveDeg3S);
            }

            if (createNewVisitViewModel.CurveDeg4S == "" || createNewVisitViewModel.CurveDeg4S == null)
            {
                visitsModel.CurveDeg4S = null;
            }
            else
            {
                visitsModel.CurveDeg4S = Double.Parse(createNewVisitViewModel.CurveDeg4S);
            }

            if (createNewVisitViewModel.Thoracictype == "" || createNewVisitViewModel.Thoracictype == null)
            {
                visitsModel.Thoracictype = null;
            }
            else
            {
                visitsModel.Thoracictype = createNewVisitViewModel.Thoracictype.ToCharArray()[0];
            }

            if (createNewVisitViewModel.Lumbartype == "" || createNewVisitViewModel.Lumbartype == null)
            {
                visitsModel.Lumbartype = null;
            }
            else
            {
                visitsModel.Lumbartype = createNewVisitViewModel.Lumbartype.ToCharArray()[0];
            }


            if (createNewVisitViewModel.CurveDeg1 == "" || createNewVisitViewModel.CurveDeg1 == null)
            {
                visitsModel.CurveDeg1 = null;
            }
            else
            {
                visitsModel.CurveDeg1 = Double.Parse(createNewVisitViewModel.CurveDeg1);
            }


            if (createNewVisitViewModel.CurveDeg2 == "" || createNewVisitViewModel.CurveDeg2 == null)
            {
                visitsModel.CurveDeg2 = null;
            }
            else
            {
                visitsModel.CurveDeg2 = Double.Parse(createNewVisitViewModel.CurveDeg2);
            }


            if (createNewVisitViewModel.CurveDeg3 == "" || createNewVisitViewModel.CurveDeg3 == null)
            {
                visitsModel.CurveDeg3 = null;
            }
            else
            {
                visitsModel.CurveDeg3 = Double.Parse(createNewVisitViewModel.CurveDeg3);
            }


            if (createNewVisitViewModel.CurveDeg4 == "" || createNewVisitViewModel.CurveDeg4 == null)
            {
                visitsModel.CurveDeg4 = null;
            }
            else
            {
                visitsModel.CurveDeg4 = Double.Parse(createNewVisitViewModel.CurveDeg4);
            }



            if (createNewVisitViewModel.TrunkDir == null || createNewVisitViewModel.TrunkDir.ToString() == "")
            {
                visitsModel.TrunkDir = null;
            }
            else
            {
                visitsModel.TrunkDir = createNewVisitViewModel.TrunkDir.ToCharArray()[0];
            }

            if (createNewVisitViewModel.RTrunkShift == "" || createNewVisitViewModel.RTrunkShift == null)
            {
                visitsModel.RTrunkShift = null;
            }
            else
            {
                visitsModel.RTrunkShift = Double.Parse(createNewVisitViewModel.RTrunkShift);
            }

            visitsModel.ApicalRotation1 = createNewVisitViewModel.ApicalRotation1;

            visitsModel.ApicalRotation2 = createNewVisitViewModel.ApicalRotation2;

            visitsModel.ApicalRotation3 = createNewVisitViewModel.ApicalRotation3;

            visitsModel.ApicalRotation4 = createNewVisitViewModel.ApicalRotation4;

            visitsModel.RSign = createNewVisitViewModel.RSign;

            visitsModel.EpFusion = createNewVisitViewModel.EpFusion;

            if (createNewVisitViewModel.ThoKyphosis == "" || createNewVisitViewModel.ThoKyphosis == null)
            {
                visitsModel.ThoKyphosis = null;
            }
            else
            {
                visitsModel.ThoKyphosis = Double.Parse(createNewVisitViewModel.ThoKyphosis);
            }

            if (createNewVisitViewModel.LumLordosis == "" || createNewVisitViewModel.LumLordosis == null)
            {
                visitsModel.LumLordosis = null;
            }
            else
            {
                visitsModel.LumLordosis = Double.Parse(createNewVisitViewModel.LumLordosis);
            }


            visitsModel.PlanObs = createNewVisitViewModel.PlanObs;


            visitsModel.PlanBrace = createNewVisitViewModel.PlanBrace;


            if (createNewVisitViewModel.PlanBraceWeanTime == "" || createNewVisitViewModel.PlanBraceWeanTime == null)
            {
                visitsModel.PlanBraceWeanTime = null;
            }
            else
            {
                visitsModel.PlanBraceWeanTime = int.Parse(createNewVisitViewModel.PlanBraceWeanTime);
            }


            if (createNewVisitViewModel.PlanFUYear == "" || createNewVisitViewModel.PlanFUYear == null)
            {
                visitsModel.PlanFUYear = null;
            }
            else
            {
                visitsModel.PlanFUYear = Double.Parse(createNewVisitViewModel.PlanFUYear);
            }

            if (createNewVisitViewModel.PlanFUMonth == "" || createNewVisitViewModel.PlanFUMonth == null)
            {
                visitsModel.PlanFUMonth = null;
            }
            else
            {
                visitsModel.PlanFUMonth = Double.Parse(createNewVisitViewModel.PlanFUMonth);
            }

            if (createNewVisitViewModel.PlanFUWeek == "" || createNewVisitViewModel.PlanFUWeek == null)
            {
                visitsModel.PlanFUWeek = null;
            }
            else
            {
                visitsModel.PlanFUWeek = Double.Parse(createNewVisitViewModel.PlanFUWeek);
            }


            if (createNewVisitViewModel.AfterBracing == "true")
            {
                visitsModel.AfterBracing = true;
            }
            else
            {
                visitsModel.AfterBracing = false;
            }

            if (createNewVisitViewModel.PRN == "true")
            {
                visitsModel.PRN = true;
            }
            else
            {
                visitsModel.PRN = false;
            }

            visitsModel.PlanXray = createNewVisitViewModel.PlanXray;


            visitsModel.PlanSurgery = createNewVisitViewModel.PlanSurgery;

            visitsModel.DrName = createNewVisitViewModel.DrName;


            visitsModel.SpcRemarks = createNewVisitViewModel.SpcRemarks;



            if (createNewVisitViewModel.LastModify == "" || createNewVisitViewModel.LastModify == null)
            {
                visitsModel.LastModify = null;
            }
            else
            {
                visitsModel.LastModify = DateTime.ParseExact(createNewVisitViewModel.LastModify, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }

            //20200518 TOCI
            visitsModel.TOCI = createNewVisitViewModel.TOCI;
            visitsModel.CurveDeg1Padding = createNewVisitViewModel.CurveDeg1Padding;
            visitsModel.CurveDeg2Padding = createNewVisitViewModel.CurveDeg2Padding;
            visitsModel.CurveDeg3Padding = createNewVisitViewModel.CurveDeg3Padding;
            visitsModel.CurveDeg4Padding = createNewVisitViewModel.CurveDeg4Padding;
            visitsModel.CurveDeg1Paddingcm = createNewVisitViewModel.CurveDeg1Paddingcm;
            visitsModel.CurveDeg2Paddingcm = createNewVisitViewModel.CurveDeg2Paddingcm;
            visitsModel.CurveDeg3Paddingcm = createNewVisitViewModel.CurveDeg3Paddingcm;
            visitsModel.CurveDeg4Paddingcm = createNewVisitViewModel.CurveDeg4Paddingcm;


            if (createNewVisitViewModel.QoL == "" || createNewVisitViewModel.QoL == null)
            {
                visitsModel.QoL = null;
            }
            else
            {
                visitsModel.QoL = Double.Parse(createNewVisitViewModel.QoL);
            }
            
            if (createNewVisitViewModel.RadDeg1 == "" || createNewVisitViewModel.RadDeg1 == null)
            {
                visitsModel.RadDeg1 = null;
            }
            else
            {
                visitsModel.RadDeg1 = Double.Parse(createNewVisitViewModel.RadDeg1);
            }
            if (createNewVisitViewModel.RadDeg2 == "" || createNewVisitViewModel.RadDeg2 == null)
            {
                visitsModel.RadDeg2 = null;
            }
            else
            {
                visitsModel.RadDeg2 = Double.Parse(createNewVisitViewModel.RadDeg2);
            }
            if (createNewVisitViewModel.RadDeg3 == "" || createNewVisitViewModel.RadDeg3 == null)
            {
                visitsModel.RadDeg3 = null;
            }
            else
            {
                visitsModel.RadDeg3 = Double.Parse(createNewVisitViewModel.RadDeg3);
            }
            if (createNewVisitViewModel.RadDeg4 == "" || createNewVisitViewModel.RadDeg4 == null)
            {
                visitsModel.RadDeg4 = null;
            }
            else
            {
                visitsModel.RadDeg4 = Double.Parse(createNewVisitViewModel.RadDeg4);
            }

            if (createNewVisitViewModel.RadFlexibility1 == "" || createNewVisitViewModel.RadFlexibility1 == null)
            {
                visitsModel.RadFlexibility1 = null;
            }
            else
            {
                visitsModel.RadFlexibility1 = Double.Parse(createNewVisitViewModel.RadFlexibility1);
            }
            if (createNewVisitViewModel.RadFlexibility2 == "" || createNewVisitViewModel.RadFlexibility2 == null)
            {
                visitsModel.RadFlexibility2 = null;
            }
            else
            {
                visitsModel.RadFlexibility2 = Double.Parse(createNewVisitViewModel.RadFlexibility2);
            }
            if (createNewVisitViewModel.RadFlexibility3 == "" || createNewVisitViewModel.RadFlexibility3 == null)
            {
                visitsModel.RadFlexibility3 = null;
            }
            else
            {
                visitsModel.RadFlexibility3 = Double.Parse(createNewVisitViewModel.RadFlexibility3);
            }
            if (createNewVisitViewModel.RadFlexibility4 == "" || createNewVisitViewModel.RadFlexibility4 == null)
            {
                visitsModel.RadFlexibility4 = null;
            }
            else
            {
                visitsModel.RadFlexibility4 = Double.Parse(createNewVisitViewModel.RadFlexibility4);
            }

            return visitsModel;

        }
    }
}
