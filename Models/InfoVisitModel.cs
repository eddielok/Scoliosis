using Microsoft.AspNetCore.Session;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Scoliosis.Models
{
    public class InfoVisitModel
    {

        public string SCN { get; set; }

        public string DOC { get; set; }

        public string OriDOC { get; set; }

        public string OriVirtual { get; set; }

        public string DocHpylink { get; set; }

        public string Age { get; set; }

        public string Virtual { get; set; }

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

        public int MaturYear { get; set; }

        public int MaturMonth { get; set; }

        public string Jointhyper { get; set; }

        public string AbdReflexA { get; set; }

        public string AbdReflexB { get; set; }

        public string AbdReflexC { get; set; }

        public string AbdReflexD { get; set; }

        public char CTrunkShiftDir { get; set; }

        public double CTrunkShift { get; set; }


        public string R1Dir { get; set; }

        public double Rotat1 { get; set; }

        public string R2Dir { get; set; }

        public double Rotat2 { get; set; }

        public string R3Dir { get; set; }

        public double Rotat3 { get; set; }

        public string R4Dir { get; set; }

        public double Rotat4 { get; set; }

        public string ShoulderDir { get; set; }

        public double ShoulderAsy { get; set; }

        public string BreastTanner { get; set; }
        public string PubicTanner { get; set; }

        public string hair { get; set; }

        public int withBrace { get; set; }


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
        public char AVTDir1 { get; set; }
        public char AVTDir2 { get; set; }
        public char AVTDir3 { get; set; }
        public char AVTDir4 { get; set; }


        public double AVTDeg1 { get; set; }
        public double AVTDeg2 { get; set; }
        public double AVTDeg3 { get; set; }
        public double AVTDeg4 { get; set; }


        public string CurveDir1 { get; set; }
        public string CurveDir2 { get; set; }
        public string CurveDir3 { get; set; }

        public string CurveDir4 { get; set; }
        public int withBraceS { get; set; }
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

        public double CurveDeg1S { get; set; }

        public double CurveDeg2S { get; set; }

        public double CurveDeg3S { get; set; }

        public double CurveDeg4S { get; set; }



        public char Thoracictype { get; set; }
        public char Lumbartype { get; set; }


        //public double SHT { get; set; }

        //public double WT { get; set; }



        public string tricart { get; set; }
        public string trochanter { get; set; }
        public string FemoralHead { get; set; }


        public double CurveDeg1 { get; set; }

        public double CurveDeg2 { get; set; }

        public double CurveDeg3 { get; set; }

        public double CurveDeg4 { get; set; }

        public string TrunkDir { get; set; }

        public double RTrunkShift { get; set; }

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

        public double ThoKyphosis { get; set; }

        public double LumLordosis { get; set; }

        public string PlanObs { get; set; }
        public string PlanBrace { get; set; }

        public int PlanBraceWeanTime { get; set; }

        public double PlanFUYear { get; set; }

        public double PlanFUMonth { get; set; }

        public double PlanFUWeek { get; set; }

        public string AfterBracing { get; set; }

        public string PRN { get; set; }

        public string PlanXray { get; set; }

        public string PlanSurgery { get; set; }

        public string DrName { get; set; }

        public string SpcRemarks { get; set; }

        public DateTime LastModify { get; set; }


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

        public List<string> ExportXRayList { get; set; }
        public List<string> ExportList { get; set; }

        public List<string> VisitList { get; set; }
        public List<string> PhotoModifyList { get; set; }
        public List<string> XRayModifyList { get; set; }

        public List<string> VisitListName { get; set; }
 
        public List <TemplateRemarksHeaderViewModel> TemplateRemarksHeaders{ get; set; }

        public List<TemplateRemarksContentViewModel> TemplateRemarksContents { get; set; }

        
        //By Eddie Change according to the meeing at 3/7, 10/7 and 31/7
        public string LenkeCurveType { get; set; }
        public string LenkeLSM { get; set; }
        public string LenkeTSP { get; set; }
        public double QoL { get; set; }
        public string RadSide1 { get; set; }
        public string RadSide2 { get; set; }
        public string RadSide3 { get; set; }
        public string RadSide4 { get; set; }
        public double RadDeg1 { get; set; }
        public double RadDeg2 { get; set; }
        public double RadDeg3 { get; set; }
        public double RadDeg4 { get; set; }
        public double RadFlexibility1 { get; set; }
        public double RadFlexibility2 { get; set; }
        public double RadFlexibility3 { get; set; }
        public double RadFlexibility4 { get; set; }

        //20200819 Display Only Doctor Name
        public string DrFullName { get; set; }

        //20201819 LastValueForCal
        public string LastDOC { get; set; }
        public string LastHT { get; set; }
        public string LastSHT { get; set; }
        public string LastWT { get; set; }
        public string LastAS { get; set; }
        public string LastRAS { get; set; }

        //20200819 SpcRemarks for display in VisitList
        public string VisitListRemark { get; set; }
		
		 public string Remarks { get; set; }



        public static explicit operator VisitsModel(InfoVisitModel infoVisitModel)
        {
            var visitsModel = new VisitsModel();

            visitsModel.SCN = infoVisitModel.SCN;
            visitsModel.DOC = DateTime.ParseExact(infoVisitModel.DOC, "dd/MM/yyyy", CultureInfo.InvariantCulture);


            visitsModel.Virtual = infoVisitModel.Virtual;

            if (String.IsNullOrEmpty(infoVisitModel.HT))
            {
                visitsModel.HT = 0;
            }
            else
            {
                if (Double.TryParse(infoVisitModel.HT, out Double result) == false)
                {
                    throw new Exception("HT should be numeric, e.g. 0.00");
                }

                visitsModel.HT = Double.Parse(infoVisitModel.HT);
            }

            if (String.IsNullOrEmpty(infoVisitModel.ArmSpan))
            {
                visitsModel.ArmSpan = 0;
            }
            else
            {
                if (Double.TryParse(infoVisitModel.ArmSpan, out Double result) == false)
                {
                    throw new Exception("ArmSpan should be numeric, e.g. 0.00");
                }

                visitsModel.ArmSpan = Double.Parse(infoVisitModel.ArmSpan);
            }

            if (String.IsNullOrEmpty(infoVisitModel.LArmSpan))
            {
                visitsModel.LArmSpan = 0;
            }
            else
            {
                if (Double.TryParse(infoVisitModel.LArmSpan, out Double result) == false)
                {
                    throw new Exception("LArmSpan should be numeric, e.g. 0.00");
                }

                visitsModel.LArmSpan = Double.Parse(infoVisitModel.LArmSpan);
            }

            if (String.IsNullOrEmpty(infoVisitModel.RArmSpan))
            {
                visitsModel.RArmSpan = 0;
            }
            else
            {
                if (Double.TryParse(infoVisitModel.RArmSpan, out Double result) == false)
                {
                    throw new Exception("RArmSpan should be numeric, e.g. 0.00");
                }

                visitsModel.RArmSpan = Double.Parse(infoVisitModel.RArmSpan);
            }

            if (String.IsNullOrEmpty(infoVisitModel.SHT))
            {
                visitsModel.SHT = 0;
            }
            else
            {

                if (Double.TryParse(infoVisitModel.SHT, out Double result) == false)
                {
                    throw new Exception("SHT should be numeric, e.g. 0.00");
                }

                visitsModel.SHT = Double.Parse(infoVisitModel.SHT);
            }

            if (String.IsNullOrEmpty(infoVisitModel.WT))
            {
                visitsModel.WT = 0;
            }
            else
            {
                if (Double.TryParse(infoVisitModel.WT, out Double result) == false)
                {
                    throw new Exception("WT should be numeric, e.g. 0.00");
                }

                visitsModel.WT = Double.Parse(infoVisitModel.WT);
            }


            //visitsModel.SHT = infoVisitModel.SHT;
            //visitsModel.WT = infoVisitModel.WT;

            if (infoVisitModel.isMenarchePos == "true")
            {
                visitsModel.isMenarchePos = true;
            }
            else
            {
                visitsModel.isMenarchePos = false;
            }

            if (infoVisitModel.isMenarcheNeg == "true")
            {
                visitsModel.isMenarcheNeg = true;
            }
            else
            {
                visitsModel.isMenarcheNeg = false;
            }



            visitsModel.MaturYear = infoVisitModel.MaturYear;
            visitsModel.MaturMonth = infoVisitModel.MaturMonth;

            visitsModel.Jointhyper = infoVisitModel.Jointhyper;


            if (String.IsNullOrEmpty(infoVisitModel.AbdReflexA) || infoVisitModel.AbdReflexA.ToString() == "\0")
            {
                visitsModel.AbdReflexA = null;
            }
            else
            {
                visitsModel.AbdReflexA = (infoVisitModel.AbdReflexA.ToCharArray())[0];
            }


            if (String.IsNullOrEmpty(infoVisitModel.AbdReflexB) || infoVisitModel.AbdReflexB.ToString() == "\0")
            {
                visitsModel.AbdReflexB = null;
            }
            else
            {
                visitsModel.AbdReflexB = (infoVisitModel.AbdReflexB.ToCharArray())[0];
            }

            if (String.IsNullOrEmpty(infoVisitModel.AbdReflexC) || infoVisitModel.AbdReflexC.ToString() == "\0")
            {
                visitsModel.AbdReflexC = null;
            }
            else
            {
                visitsModel.AbdReflexC = (infoVisitModel.AbdReflexC.ToCharArray())[0];
            }

            if (String.IsNullOrEmpty(infoVisitModel.AbdReflexD) || infoVisitModel.AbdReflexD.ToString() == "\0")
            {
                visitsModel.AbdReflexD = null;
            }
            else
            {
                visitsModel.AbdReflexD = (infoVisitModel.AbdReflexD.ToCharArray())[0];
            }

            if (String.IsNullOrEmpty(infoVisitModel.ShoulderDir) || infoVisitModel.ShoulderDir.ToString() == "\0")
            {
                visitsModel.ShoulderDir = null;
            }
            else
            {
                visitsModel.ShoulderDir = infoVisitModel.ShoulderDir;
            }

            if (infoVisitModel.CTrunkShiftDir == null || infoVisitModel.CTrunkShiftDir.ToString() == "\0")
            {
                visitsModel.CTrunkShiftDir = null;
            }
            else
            {
                visitsModel.CTrunkShiftDir = infoVisitModel.CTrunkShiftDir;
            }

            if (String.IsNullOrEmpty(infoVisitModel.BreastTanner) || infoVisitModel.BreastTanner.ToString() == "\0")
            {
                visitsModel.BreastTanner = null;
            }
            else
            {
                visitsModel.BreastTanner = infoVisitModel.BreastTanner;
            }

            if (String.IsNullOrEmpty(infoVisitModel.PubicTanner) || infoVisitModel.PubicTanner.ToString() == "\0")
            {
                visitsModel.PubicTanner = null;
            }
            else
            {
                visitsModel.PubicTanner = infoVisitModel.PubicTanner;
            }

            if (String.IsNullOrEmpty(infoVisitModel.hair) || infoVisitModel.hair.ToString() == "\0")
            {
                visitsModel.hair = null;
            }
            else
            {
                visitsModel.hair = infoVisitModel.hair;
            }


            visitsModel.CTrunkShift = infoVisitModel.CTrunkShift;


            visitsModel.R1Dir = infoVisitModel.R1Dir;
            visitsModel.Rotat1 = infoVisitModel.Rotat1;
            visitsModel.R2Dir = infoVisitModel.R2Dir;
            visitsModel.Rotat2 = infoVisitModel.Rotat2;
            visitsModel.R3Dir = infoVisitModel.R3Dir;
            visitsModel.Rotat3 = infoVisitModel.Rotat3;
            visitsModel.R4Dir = infoVisitModel.R4Dir;
            visitsModel.Rotat4 = infoVisitModel.Rotat4;
            visitsModel.ShoulderAsy = infoVisitModel.ShoulderAsy;

            visitsModel.tricart = infoVisitModel.tricart;
            visitsModel.trochanter = infoVisitModel.trochanter;
            visitsModel.FemoralHead = infoVisitModel.FemoralHead;
            visitsModel.withBrace = (short)infoVisitModel.withBrace;
            visitsModel.CurveLevel1From = infoVisitModel.CurveLevel1From;
            visitsModel.CurveLevel1To = infoVisitModel.CurveLevel1To;
            visitsModel.CurveLevel2From = infoVisitModel.CurveLevel2From;
            visitsModel.CurveLevel2To = infoVisitModel.CurveLevel2To;
            visitsModel.CurveLevel3From = infoVisitModel.CurveLevel3From;
            visitsModel.CurveLevel3To = infoVisitModel.CurveLevel3To;
            visitsModel.CurveLevel4From = infoVisitModel.CurveLevel4From;
            visitsModel.CurveLevel4To = infoVisitModel.CurveLevel4To;
            visitsModel.CurveApex1 = infoVisitModel.CurveApex1;
            visitsModel.CurveApex2 = infoVisitModel.CurveApex2;
            visitsModel.CurveApex3 = infoVisitModel.CurveApex3;
            visitsModel.CurveApex4 = infoVisitModel.CurveApex4;
            visitsModel.AVTDir1 = infoVisitModel.AVTDir1;
            visitsModel.AVTDir2 = infoVisitModel.AVTDir2;
            visitsModel.AVTDir3 = infoVisitModel.AVTDir3;
            visitsModel.AVTDir4 = infoVisitModel.AVTDir4;
            visitsModel.AVTDeg1 = infoVisitModel.AVTDeg1;
            visitsModel.AVTDeg2 = infoVisitModel.AVTDeg2;
            visitsModel.AVTDeg3 = infoVisitModel.AVTDeg3;
            visitsModel.AVTDeg4 = infoVisitModel.AVTDeg4;
            visitsModel.CurveDir1 = infoVisitModel.CurveDir1;
            visitsModel.CurveDir2 = infoVisitModel.CurveDir2;
            visitsModel.CurveDir3 = infoVisitModel.CurveDir3;
            visitsModel.CurveDir4 = infoVisitModel.CurveDir4;
            visitsModel.ApicalDir1 = infoVisitModel.ApicalDir1;
            visitsModel.ApicalDir2 = infoVisitModel.ApicalDir2;
            visitsModel.ApicalDir3 = infoVisitModel.ApicalDir3;
            visitsModel.ApicalDir4 = infoVisitModel.ApicalDir4;
            visitsModel.withBraceS = (short)infoVisitModel.withBraceS;
            visitsModel.CurveLevel1FromS = infoVisitModel.CurveLevel1FromS;
            visitsModel.CurveLevel1ToS = infoVisitModel.CurveLevel1ToS;
            visitsModel.CurveLevel2FromS = infoVisitModel.CurveLevel2FromS;
            visitsModel.CurveLevel2ToS = infoVisitModel.CurveLevel2ToS;
            visitsModel.CurveLevel3FromS = infoVisitModel.CurveLevel3FromS;
            visitsModel.CurveLevel3ToS = infoVisitModel.CurveLevel3ToS;
            visitsModel.CurveLevel4FromS = infoVisitModel.CurveLevel4FromS;
            visitsModel.CurveLevel4ToS = infoVisitModel.CurveLevel4ToS;
            visitsModel.CurveDir1S = infoVisitModel.CurveDir1S;
            visitsModel.CurveDir2S = infoVisitModel.CurveDir2S;
            visitsModel.CurveDir3S = infoVisitModel.CurveDir3S;
            visitsModel.CurveDir4S = infoVisitModel.CurveDir4S;
            visitsModel.CurveApex1S = infoVisitModel.CurveApex1S;
            visitsModel.CurveApex2S = infoVisitModel.CurveApex2S;
            visitsModel.CurveApex3S = infoVisitModel.CurveApex3S;
            visitsModel.CurveApex4S = infoVisitModel.CurveApex4S;
            visitsModel.CurveDeg1S = infoVisitModel.CurveDeg1S;
            visitsModel.CurveDeg2S = infoVisitModel.CurveDeg2S;
            visitsModel.CurveDeg3S = infoVisitModel.CurveDeg3S;
            visitsModel.CurveDeg4S = infoVisitModel.CurveDeg4S;


            if (infoVisitModel.Lumbartype == null || infoVisitModel.Lumbartype.ToString() == "\0")
            {
                visitsModel.Thoracictype = null;
            }
            else
            {
                visitsModel.Thoracictype = infoVisitModel.Thoracictype;
            }


            if (infoVisitModel.Lumbartype.ToString() == "\0")
            {
                visitsModel.Lumbartype = null;
            }
            else
            {
                visitsModel.Lumbartype = infoVisitModel.Lumbartype;
            }

            visitsModel.CurveDeg1 = infoVisitModel.CurveDeg1;
            visitsModel.CurveDeg2 = infoVisitModel.CurveDeg2;
            visitsModel.CurveDeg3 = infoVisitModel.CurveDeg3;
            visitsModel.CurveDeg4 = infoVisitModel.CurveDeg4;


            if (String.IsNullOrEmpty(infoVisitModel.TrunkDir) || infoVisitModel.TrunkDir == "")
            {
                visitsModel.TrunkDir = null;
            }
            else
            {
                var trunkDirChar = infoVisitModel.TrunkDir.ToCharArray();
                visitsModel.TrunkDir = trunkDirChar[0];
            }


            visitsModel.RTrunkShift = infoVisitModel.RTrunkShift;
            visitsModel.ApicalRotation1 = infoVisitModel.ApicalRotation1;
            visitsModel.ApicalRotation2 = infoVisitModel.ApicalRotation2;
            visitsModel.ApicalRotation3 = infoVisitModel.ApicalRotation3;
            visitsModel.ApicalRotation4 = infoVisitModel.ApicalRotation4;
            visitsModel.RSign = infoVisitModel.RSign;
            visitsModel.EpFusion = infoVisitModel.EpFusion;


            if (infoVisitModel.ThoKyphosis == null || infoVisitModel.ThoKyphosis.ToString() == "\0")
            {
                visitsModel.ThoKyphosis = infoVisitModel.ThoKyphosis;
            }
            else
            {
                visitsModel.ThoKyphosis = infoVisitModel.ThoKyphosis;
            }



            visitsModel.LumLordosis = infoVisitModel.LumLordosis;
            visitsModel.PlanObs = infoVisitModel.PlanObs;
            visitsModel.PlanBrace = infoVisitModel.PlanBrace;
            visitsModel.PlanBraceWeanTime = infoVisitModel.PlanBraceWeanTime;
            visitsModel.PlanFUYear = infoVisitModel.PlanFUYear;
            visitsModel.PlanFUMonth = infoVisitModel.PlanFUMonth;
            visitsModel.PlanFUWeek = infoVisitModel.PlanFUWeek;



            if (infoVisitModel.AfterBracing == "true")
            {
                visitsModel.AfterBracing = true;
            }
            else
            {
                visitsModel.AfterBracing = false;
            }

            if (infoVisitModel.PRN == "true")
            {
                visitsModel.PRN = true;
            }
            else
            {
                visitsModel.PRN = false;
            }

            visitsModel.PlanXray = infoVisitModel.PlanXray;
            visitsModel.PlanSurgery = infoVisitModel.PlanSurgery;
            visitsModel.DrName = infoVisitModel.DrName;
            visitsModel.SpcRemarks = infoVisitModel.SpcRemarks;
            visitsModel.LastModify = infoVisitModel.LastModify;

            //20200517 Add field

            visitsModel.TOCI = infoVisitModel.TOCI;
            visitsModel.CurveDeg1Padding = infoVisitModel.CurveDeg1Padding;
            visitsModel.CurveDeg2Padding = infoVisitModel.CurveDeg2Padding;
            visitsModel.CurveDeg3Padding = infoVisitModel.CurveDeg3Padding;
            visitsModel.CurveDeg4Padding = infoVisitModel.CurveDeg4Padding;
            visitsModel.CurveDeg1Paddingcm = infoVisitModel.CurveDeg1Paddingcm;
            visitsModel.CurveDeg2Paddingcm = infoVisitModel.CurveDeg2Paddingcm;
            visitsModel.CurveDeg3Paddingcm = infoVisitModel.CurveDeg3Paddingcm;
            visitsModel.CurveDeg4Paddingcm = infoVisitModel.CurveDeg4Paddingcm;

            visitsModel.CurveDeg1Paddings = infoVisitModel.CurveDeg1Paddings;
            visitsModel.CurveDeg2Paddings = infoVisitModel.CurveDeg2Paddings;
            visitsModel.CurveDeg3Paddings = infoVisitModel.CurveDeg3Paddings;
            visitsModel.CurveDeg4Paddings = infoVisitModel.CurveDeg4Paddings;
            visitsModel.CurveDeg1Paddingcms = infoVisitModel.CurveDeg1Paddingcms;
            visitsModel.CurveDeg2Paddingcms = infoVisitModel.CurveDeg2Paddingcms;
            visitsModel.CurveDeg3Paddingcms = infoVisitModel.CurveDeg3Paddingcms;
            visitsModel.CurveDeg4Paddingcms = infoVisitModel.CurveDeg4Paddingcms;


            visitsModel.ScannogramTotalR = infoVisitModel.ScannogramTotalR;
            visitsModel.ScannogramTotalL = infoVisitModel.ScannogramTotalL;
            visitsModel.ScannogramFemurR = infoVisitModel.ScannogramFemurR;
            visitsModel.ScannogramFemurL = infoVisitModel.ScannogramFemurL;
            visitsModel.ScannogramTibiaR = infoVisitModel.ScannogramTibiaR;
            visitsModel.ScannogramTibiaL = infoVisitModel.ScannogramTibiaL;

            //By Eddie Change according to the meeing at 3/7, 10/7 and 31/7
            visitsModel.QoL = infoVisitModel.QoL;
            visitsModel.RadSide1 = infoVisitModel.RadSide1;
            visitsModel.RadSide2 = infoVisitModel.RadSide2;
            visitsModel.RadSide3 = infoVisitModel.RadSide3;
            visitsModel.RadSide4 = infoVisitModel.RadSide4;
            visitsModel.RadDeg1 = infoVisitModel.RadDeg1;
            visitsModel.RadDeg2 = infoVisitModel.RadDeg2;
            visitsModel.RadDeg3 = infoVisitModel.RadDeg3;
            visitsModel.RadDeg4 = infoVisitModel.RadDeg4;
            visitsModel.RadFlexibility1 = infoVisitModel.RadFlexibility1;
            visitsModel.RadFlexibility2 = infoVisitModel.RadFlexibility2;
            visitsModel.RadFlexibility3 = infoVisitModel.RadFlexibility3;
            visitsModel.RadFlexibility4 = infoVisitModel.RadFlexibility4;

            return visitsModel;

        }


        public InfoVisitModel SetDefaultValue(InfoVisitModel infoVisitModel)
        {


            infoVisitModel.SCN = infoVisitModel.SCN;
            infoVisitModel.DOC = DateTime.Now.ToString("dd/MM/yyyy");

            if (string.IsNullOrEmpty(infoVisitModel.Virtual))
                infoVisitModel.Virtual = "";

            if (string.IsNullOrEmpty(infoVisitModel.Age))
                infoVisitModel.Age = "";

            if (string.IsNullOrEmpty(infoVisitModel.HT))
                infoVisitModel.HT = "";

            if (string.IsNullOrEmpty(infoVisitModel.ArmSpan))
                infoVisitModel.ArmSpan = "";

            if (string.IsNullOrEmpty(infoVisitModel.LArmSpan))
                infoVisitModel.LArmSpan = "";

            if (string.IsNullOrEmpty(infoVisitModel.RArmSpan))
                infoVisitModel.RArmSpan = "";

            if (string.IsNullOrEmpty(infoVisitModel.SHT))
                infoVisitModel.SHT = "";

            if (string.IsNullOrEmpty(infoVisitModel.WT))
                infoVisitModel.WT = "";

            if (string.IsNullOrEmpty(infoVisitModel.HGV))
                infoVisitModel.HGV = "";

            if (string.IsNullOrEmpty(infoVisitModel.ASGV))
                infoVisitModel.ASGV = "";

            if (string.IsNullOrEmpty(infoVisitModel.LASGV))
                infoVisitModel.LASGV = "";

            if (string.IsNullOrEmpty(infoVisitModel.RASGV))
                infoVisitModel.RASGV = "";

            if (string.IsNullOrEmpty(infoVisitModel.SHTGV))
                infoVisitModel.SHTGV = "";

            if (string.IsNullOrEmpty(infoVisitModel.WGV))
                infoVisitModel.WGV = "";

            if (string.IsNullOrEmpty(infoVisitModel.isMenarchePos))
                infoVisitModel.isMenarchePos = "";

            if (string.IsNullOrEmpty(infoVisitModel.isMenarcheNeg))
                infoVisitModel.isMenarcheNeg = "";

            infoVisitModel.MaturYear = 0;

            infoVisitModel.MaturMonth = 0;

            if (string.IsNullOrEmpty(infoVisitModel.Jointhyper))
                infoVisitModel.Jointhyper = "";

            if (string.IsNullOrEmpty(infoVisitModel.AbdReflexA))
                infoVisitModel.AbdReflexA = "";

            if (string.IsNullOrEmpty(infoVisitModel.AbdReflexB))
                infoVisitModel.AbdReflexB = "";

            if (string.IsNullOrEmpty(infoVisitModel.AbdReflexC))
                infoVisitModel.AbdReflexC = "";

            if (string.IsNullOrEmpty(infoVisitModel.AbdReflexD))
                infoVisitModel.AbdReflexD = "";

            infoVisitModel.CTrunkShiftDir = "\0".ToCharArray()[0];

            infoVisitModel.CTrunkShift = 0;

            if (string.IsNullOrEmpty(infoVisitModel.R1Dir))
                infoVisitModel.R1Dir = "";

            infoVisitModel.Rotat1 = 0;

            if (string.IsNullOrEmpty(infoVisitModel.R2Dir))
                infoVisitModel.R2Dir = "";

            infoVisitModel.Rotat2 = 0;

            if (string.IsNullOrEmpty(infoVisitModel.R3Dir))
                infoVisitModel.R3Dir = "";

            infoVisitModel.Rotat3 = 0;

            if (string.IsNullOrEmpty(infoVisitModel.R4Dir))
                infoVisitModel.R4Dir = "";

            infoVisitModel.Rotat4 = 0;

            if (string.IsNullOrEmpty(infoVisitModel.ShoulderDir))
                infoVisitModel.ShoulderDir = "";

            infoVisitModel.ShoulderAsy = 0;

            if (string.IsNullOrEmpty(infoVisitModel.BreastTanner))
                infoVisitModel.BreastTanner = "";

            if (string.IsNullOrEmpty(infoVisitModel.PubicTanner))
                infoVisitModel.PubicTanner = "";

            if (string.IsNullOrEmpty(infoVisitModel.hair))
                infoVisitModel.hair = "";

            if (string.IsNullOrEmpty(infoVisitModel.tricart))
                infoVisitModel.tricart = "";

            if (string.IsNullOrEmpty(infoVisitModel.trochanter))
                infoVisitModel.trochanter = "";

            if (string.IsNullOrEmpty(infoVisitModel.FemoralHead))
                infoVisitModel.FemoralHead = "";

            infoVisitModel.withBrace = 0;

            if (string.IsNullOrEmpty(infoVisitModel.CurveLevel1From))
                infoVisitModel.CurveLevel1From = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveLevel1To))
                infoVisitModel.CurveLevel1To = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveLevel2From))
                infoVisitModel.CurveLevel2From = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveLevel2To))
                infoVisitModel.CurveLevel2To = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveLevel3From))
                infoVisitModel.CurveLevel3From = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveLevel3To))
                infoVisitModel.CurveLevel3To = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveLevel4From))
                infoVisitModel.CurveLevel4From = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveLevel4To))
                infoVisitModel.CurveLevel4To = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveApex1))
                infoVisitModel.CurveApex1 = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveApex2))
                infoVisitModel.CurveApex2 = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveApex3))
                infoVisitModel.CurveApex3 = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveApex4))
                infoVisitModel.CurveApex4 = "";

            infoVisitModel.AVTDir1 = "\0".ToCharArray()[0];

            infoVisitModel.AVTDir2 = "\0".ToCharArray()[0];

            infoVisitModel.AVTDir3 = "\0".ToCharArray()[0];

            infoVisitModel.AVTDir4 = "\0".ToCharArray()[0];

            infoVisitModel.AVTDeg1 = "\0".ToCharArray()[0];

            infoVisitModel.AVTDeg2 = "\0".ToCharArray()[0];

            infoVisitModel.AVTDeg3 = "\0".ToCharArray()[0];

            infoVisitModel.AVTDeg4 = "\0".ToCharArray()[0];

            if (string.IsNullOrEmpty(infoVisitModel.CurveDir1))
                infoVisitModel.CurveDir1 = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveDir2))
                infoVisitModel.CurveDir2 = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveDir3))
                infoVisitModel.CurveDir3 = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveDir4))
                infoVisitModel.CurveDir4 = "";

            infoVisitModel.withBraceS = 0;

            if (string.IsNullOrEmpty(infoVisitModel.CurveLevel1FromS))
                infoVisitModel.CurveLevel1FromS = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveLevel1ToS))
                infoVisitModel.CurveLevel1ToS = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveLevel2FromS))
                infoVisitModel.CurveLevel2FromS = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveLevel2ToS))
                infoVisitModel.CurveLevel2ToS = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveLevel3FromS))
                infoVisitModel.CurveLevel3FromS = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveLevel3ToS))
                infoVisitModel.CurveLevel3ToS = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveLevel4FromS))
                infoVisitModel.CurveLevel4FromS = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveLevel4ToS))
                infoVisitModel.CurveLevel4ToS = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveDir1S))
                infoVisitModel.CurveDir1S = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveDir2S))
                infoVisitModel.CurveDir2S = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveDir3S))
                infoVisitModel.CurveDir3S = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveDir4S))
                infoVisitModel.CurveDir4S = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveApex1S))
                infoVisitModel.CurveApex1S = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveApex2S))
                infoVisitModel.CurveApex2S = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveApex3S))
                infoVisitModel.CurveApex3S = "";

            if (string.IsNullOrEmpty(infoVisitModel.CurveApex4S))
                infoVisitModel.CurveApex4S = "";

            infoVisitModel.CurveDeg1S = 0;

            infoVisitModel.CurveDeg2S = 0;

            infoVisitModel.CurveDeg3S = 0;

            infoVisitModel.CurveDeg4S = 0;

            infoVisitModel.Thoracictype = "\0".ToCharArray()[0];

            infoVisitModel.Lumbartype = "\0".ToCharArray()[0];


            infoVisitModel.CurveDeg1 = 0;

            infoVisitModel.CurveDeg2 = 0;

            infoVisitModel.CurveDeg3 = 0;

            infoVisitModel.CurveDeg4 = 0;

            if (string.IsNullOrEmpty(infoVisitModel.TrunkDir))
                infoVisitModel.TrunkDir = "";

            infoVisitModel.RTrunkShift = 0;

            if (string.IsNullOrEmpty(infoVisitModel.ApicalDir1))
                infoVisitModel.ApicalDir1 = "";

            if (string.IsNullOrEmpty(infoVisitModel.ApicalDir2))
                infoVisitModel.ApicalDir2 = "";

            if (string.IsNullOrEmpty(infoVisitModel.ApicalDir3))
                infoVisitModel.ApicalDir3 = "";

            if (string.IsNullOrEmpty(infoVisitModel.ApicalDir4))
                infoVisitModel.ApicalDir4 = "";

            if (string.IsNullOrEmpty(infoVisitModel.ApicalRotation1))
                infoVisitModel.ApicalRotation1 = "";

            if (string.IsNullOrEmpty(infoVisitModel.ApicalRotation2))
                infoVisitModel.ApicalRotation2 = "";

            if (string.IsNullOrEmpty(infoVisitModel.ApicalRotation3))
                infoVisitModel.ApicalRotation3 = "";

            if (string.IsNullOrEmpty(infoVisitModel.ApicalRotation4))
                infoVisitModel.ApicalRotation4 = "";

            if (string.IsNullOrEmpty(infoVisitModel.RSign))
                infoVisitModel.RSign = "";

            if (string.IsNullOrEmpty(infoVisitModel.EpFusion))
                infoVisitModel.EpFusion = "";

            infoVisitModel.ThoKyphosis = 0;

            infoVisitModel.LumLordosis = 0;

            if (string.IsNullOrEmpty(infoVisitModel.PlanObs))
                infoVisitModel.PlanObs = "";

            if (string.IsNullOrEmpty(infoVisitModel.PlanBrace))
                infoVisitModel.PlanBrace = "";

            infoVisitModel.PlanBraceWeanTime = 0;

            infoVisitModel.PlanFUYear = 0;

            infoVisitModel.PlanFUMonth = 0;

            infoVisitModel.PlanFUWeek = 0;

            if (string.IsNullOrEmpty(infoVisitModel.AfterBracing))
                infoVisitModel.AfterBracing = "";

            if (string.IsNullOrEmpty(infoVisitModel.PRN))
                infoVisitModel.PRN = "";

            if (string.IsNullOrEmpty(infoVisitModel.PlanXray))
                infoVisitModel.PlanXray = "";

            if (string.IsNullOrEmpty(infoVisitModel.PlanSurgery))
                infoVisitModel.PlanSurgery = "";

            if (string.IsNullOrEmpty(infoVisitModel.DrName))
                infoVisitModel.DrName = "";

            if (string.IsNullOrEmpty(infoVisitModel.SpcRemarks))
                infoVisitModel.SpcRemarks = "";

            infoVisitModel.LastModify = DateTime.Now;

            infoVisitModel.TOCI = "";

                infoVisitModel.CurveDeg1Padding = "";
            infoVisitModel.CurveDeg2Padding = "";
            infoVisitModel.CurveDeg3Padding = "";
            infoVisitModel.CurveDeg4Padding = "";
            infoVisitModel.CurveDeg1Paddingcm = "";
            infoVisitModel.CurveDeg2Paddingcm = "";
            infoVisitModel.CurveDeg3Paddingcm = "";
            infoVisitModel.CurveDeg4Paddingcm = "";

            //By Eddie Change according to the meeing at 3/7, 10/7 and 31/7

                infoVisitModel.QoL = 0;

            if (infoVisitModel.RadSide1 == null)
                infoVisitModel.RadSide1 = "";
            if (infoVisitModel.RadSide2 == null)
                infoVisitModel.RadSide2 = "";
            if (infoVisitModel.RadSide3 == null)
                infoVisitModel.RadSide3 = "";
            if (infoVisitModel.RadSide4 == null)
                infoVisitModel.RadSide4 = "";

                infoVisitModel.RadDeg1 = 0;
                infoVisitModel.RadDeg2 = 0;
                infoVisitModel.RadDeg3 = 0;
                infoVisitModel.RadDeg4 = 0;
                infoVisitModel.RadFlexibility1 = 0;
                infoVisitModel.RadFlexibility2 = 0;
                infoVisitModel.RadFlexibility3 = 0;
                infoVisitModel.RadFlexibility4 = 0;
            if (string.IsNullOrEmpty(infoVisitModel.Remarks))
                infoVisitModel.Remarks = "";

            return infoVisitModel;
        }

    }



}
