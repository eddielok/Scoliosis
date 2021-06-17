using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Scoliosis.Models
{
    public class VisitsLogViewModel
    {
        [Required]
        [Key]
        public Int64 id { get; set; }

        [Required]
        public String SCN { get; set; }

        [Required]
        public Nullable<DateTime> DOC { get; set; }

        public String Virtual { get; set; }

        public Nullable<double> HT { get; set; }

        public Nullable<double> ArmSpan { get; set; }

        public Nullable<double> LArmSpan { get; set; }

        public Nullable<double> RArmSpan { get; set; }

        public Nullable<double> SHT { get; set; }

        public Nullable<double> WT { get; set; }

        public Nullable<bool> isMenarchePos { get; set; }

        public Nullable<bool> isMenarcheNeg { get; set; }

        public Nullable<int> MaturYear { get; set; }

        public Nullable<int> MaturMonth { get; set; }

        public String Jointhyper { get; set; }

        public Nullable<char> AbdReflexA { get; set; }

        public Nullable<char> AbdReflexB { get; set; }

        public Nullable<char> AbdReflexC { get; set; }

        public Nullable<char> AbdReflexD { get; set; }

        public Nullable<char> CTrunkShiftDir { get; set; }

        public Nullable<double> CTrunkShift { get; set; }

        public String R1Dir { get; set; }

        public Nullable<double> Rotat1 { get; set; }

        public String R2Dir { get; set; }

        public Nullable<double> Rotat2 { get; set; }

        public String R3Dir { get; set; }

        public Nullable<double> Rotat3 { get; set; }

        public String R4Dir { get; set; }

        public Nullable<double> Rotat4 { get; set; }

        public String ShoulderDir { get; set; }

        public Nullable<double> ShoulderAsy { get; set; }

        public String BreastTanner { get; set; }
        public String PubicTanner { get; set; }
        public String hair { get; set; }
        public String tricart { get; set; }
        public String trochanter { get; set; }
        public String FemoralHead { get; set; }
        public Nullable<Int16> withBrace { get; set; }
        public String CurveLevel1From { get; set; }
        public String CurveLevel1To { get; set; }
        public String CurveLevel2From { get; set; }
        public String CurveLevel2To { get; set; }
        public String CurveLevel3From { get; set; }
        public String CurveLevel3To { get; set; }
        public String CurveLevel4From { get; set; }
        public String CurveLevel4To { get; set; }
        public String CurveApex1 { get; set; }
        public String CurveApex2 { get; set; }
        public String CurveApex3 { get; set; }
        public String CurveApex4 { get; set; }
        public Nullable<char> AVTDir1 { get; set; }
        public Nullable<char> AVTDir2 { get; set; }
        public Nullable<char> AVTDir3 { get; set; }
        public Nullable<char> AVTDir4 { get; set; }

        public Nullable<double> AVTDeg1 { get; set; }
        public Nullable<double> AVTDeg2 { get; set; }
        public Nullable<double> AVTDeg3 { get; set; }
        public Nullable<double> AVTDeg4 { get; set; }


        public String CurveDir1 { get; set; }
        public String CurveDir2 { get; set; }
        public String CurveDir3 { get; set; }

        public String CurveDir4 { get; set; }
        public Nullable<Int16> withBraceS { get; set; }
        public String CurveLevel1FromS { get; set; }

        public String CurveLevel1ToS { get; set; }
        public String CurveLevel2FromS { get; set; }
        public String CurveLevel2ToS { get; set; }

        public String CurveLevel3FromS { get; set; }

        public String CurveLevel3ToS { get; set; }
        public String CurveLevel4FromS { get; set; }
        public String CurveLevel4ToS { get; set; }
        public String CurveDir1S { get; set; }
        public String CurveDir2S { get; set; }
        public String CurveDir3S { get; set; }
        public String CurveDir4S { get; set; }
        public String CurveApex1S { get; set; }
        public String CurveApex2S { get; set; }
        public String CurveApex3S { get; set; }
        public String CurveApex4S { get; set; }

        public Nullable<double> CurveDeg1S { get; set; }

        public Nullable<double> CurveDeg2S { get; set; }

        public Nullable<double> CurveDeg3S { get; set; }

        public Nullable<double> CurveDeg4S { get; set; }



        public Nullable<char> Thoracictype { get; set; }
        public Nullable<char> Lumbartype { get; set; }
        public Nullable<double> CurveDeg1 { get; set; }

        public Nullable<double> CurveDeg2 { get; set; }

        public Nullable<double> CurveDeg3 { get; set; }

        public Nullable<double> CurveDeg4 { get; set; }

        public Nullable<char> TrunkDir { get; set; }

        public Nullable<double> RTrunkShift { get; set; }

        public String ApicalDir1 { get; set; }
        public String ApicalDir2 { get; set; }
        public String ApicalDir3 { get; set; }
        public String ApicalDir4 { get; set; }


        public String ApicalRotation1 { get; set; }
        public String ApicalRotation2 { get; set; }
        public String ApicalRotation3 { get; set; }
        public String ApicalRotation4 { get; set; }
        public String RSign { get; set; }
        public String EpFusion { get; set; }

        public Nullable<double> ThoKyphosis { get; set; }

        public Nullable<double> LumLordosis { get; set; }

        public String PlanObs { get; set; }
        public String PlanBrace { get; set; }


        public Nullable<int> PlanBraceWeanTime { get; set; }

        public Nullable<double> PlanFUYear { get; set; }

        public Nullable<double> PlanFUMonth { get; set; }

        public Nullable<double> PlanFUWeek { get; set; }

        public Nullable<bool> AfterBracing { get; set; }

        public Nullable<bool> PRN { get; set; }

        public string PlanXray { get; set; }

        public string PlanSurgery { get; set; }

        public string DrName { get; set; }

        public string SpcRemarks { get; set; }

        public Nullable<DateTime> LastModify { get; set; }

        public string Action { get; set; }

        public string CreatedBy { get; set; }

        public Nullable<DateTime> CreatedDate { get; set; }

        //20200517 Add field
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

        //By Eddie Change according to the meeing at 3/7, 10/7 and 31/7
        public Nullable<double> SRS22 { get; set; }
        public Nullable<double> QoL { get; set; }
        public string RadSide1 { get; set; }
        public string RadSide2 { get; set; }
        public string RadSide3 { get; set; }
        public string RadSide4 { get; set; }
        public Nullable<double> RadDeg1 { get; set; }
        public Nullable<double> RadDeg2 { get; set; }
        public Nullable<double> RadDeg3 { get; set; }
        public Nullable<double> RadDeg4 { get; set; }
        public Nullable<double> RadFlexibility1 { get; set; }
        public Nullable<double> RadFlexibility2 { get; set; }
        public Nullable<double> RadFlexibility3 { get; set; }
        public Nullable<double> RadFlexibility4 { get; set; }

        public static explicit operator VisitsLogViewModel(VisitsModel visitsModel)
        {
            var visitsLogViewModel = new VisitsLogViewModel();


            visitsLogViewModel.SCN = visitsModel.SCN;


            visitsLogViewModel.DOC = visitsModel.DOC;
            visitsLogViewModel.Virtual = visitsModel.Virtual;


            visitsLogViewModel.HT = visitsModel.HT;

            visitsLogViewModel.ArmSpan = visitsModel.ArmSpan;


            visitsLogViewModel.LArmSpan = visitsModel.LArmSpan;


            visitsLogViewModel.RArmSpan = visitsModel.RArmSpan;

            visitsLogViewModel.SHT = visitsModel.SHT;

            visitsLogViewModel.WT = visitsModel.WT;


            visitsLogViewModel.isMenarchePos = visitsModel.isMenarchePos;

            visitsLogViewModel.isMenarcheNeg = visitsModel.isMenarcheNeg;



            visitsLogViewModel.MaturYear = visitsModel.MaturYear;

            visitsLogViewModel.MaturMonth = visitsModel.MaturMonth;

            visitsLogViewModel.Jointhyper = visitsModel.Jointhyper;




            visitsLogViewModel.AbdReflexA = visitsModel.AbdReflexA;

            visitsLogViewModel.AbdReflexB = visitsModel.AbdReflexB;

            visitsLogViewModel.AbdReflexC = visitsModel.AbdReflexC;

            visitsLogViewModel.AbdReflexD = visitsModel.AbdReflexD;
            visitsLogViewModel.CTrunkShiftDir = visitsModel.CTrunkShiftDir;

            visitsLogViewModel.CTrunkShift = visitsModel.CTrunkShift;

            visitsLogViewModel.R1Dir = visitsModel.R1Dir;


            visitsLogViewModel.Rotat1 = visitsModel.Rotat1;


            visitsLogViewModel.R2Dir = visitsModel.R2Dir;


            visitsLogViewModel.Rotat2 = visitsModel.Rotat2;


            visitsLogViewModel.R3Dir = visitsModel.R3Dir;


            visitsLogViewModel.Rotat3 = visitsModel.Rotat3;

            visitsLogViewModel.R4Dir = visitsModel.R4Dir;

            visitsLogViewModel.Rotat4 = visitsModel.Rotat4;

            visitsLogViewModel.ShoulderDir = visitsModel.ShoulderDir;

            visitsLogViewModel.ShoulderAsy = visitsModel.ShoulderAsy;

            visitsLogViewModel.BreastTanner = visitsModel.BreastTanner;

            visitsLogViewModel.PubicTanner = visitsModel.PubicTanner;

            visitsLogViewModel.hair = visitsModel.hair;



            visitsLogViewModel.tricart = visitsModel.tricart;

            visitsLogViewModel.trochanter = visitsModel.trochanter;

            visitsLogViewModel.FemoralHead = visitsModel.FemoralHead;

            visitsLogViewModel.withBrace = visitsModel.withBrace;

            visitsLogViewModel.CurveLevel1From = visitsModel.CurveLevel1From;

            visitsLogViewModel.CurveLevel1To = visitsModel.CurveLevel1To;

            visitsLogViewModel.CurveLevel2From = visitsModel.CurveLevel2From;

            visitsLogViewModel.CurveLevel2To = visitsModel.CurveLevel2To;

            visitsLogViewModel.CurveLevel3From = visitsModel.CurveLevel3From;

            visitsLogViewModel.CurveLevel3To = visitsModel.CurveLevel3To;

            visitsLogViewModel.CurveLevel4From = visitsModel.CurveLevel4From;

            visitsLogViewModel.CurveLevel4To = visitsModel.CurveLevel4To;

            visitsLogViewModel.CurveApex1 = visitsModel.CurveApex1;

            visitsLogViewModel.CurveApex2 = visitsModel.CurveApex2;

            visitsLogViewModel.CurveApex3 = visitsModel.CurveApex3;

            visitsLogViewModel.CurveApex4 = visitsModel.CurveApex4;

            visitsLogViewModel.AVTDir1 = visitsModel.AVTDir1;

            visitsLogViewModel.AVTDir2 = visitsModel.AVTDir2;

            visitsLogViewModel.AVTDir3 = visitsModel.AVTDir3;

            visitsLogViewModel.AVTDir4 = visitsModel.AVTDir4;

            visitsLogViewModel.AVTDeg1 = visitsModel.AVTDeg1;

            visitsLogViewModel.AVTDeg2 = visitsModel.AVTDeg2;

            visitsLogViewModel.AVTDeg3 = visitsModel.AVTDeg3;

            visitsLogViewModel.AVTDeg4 = visitsModel.AVTDeg4;

            visitsLogViewModel.CurveDir1 = visitsModel.CurveDir1;

            visitsLogViewModel.CurveDir2 = visitsModel.CurveDir2;

            visitsLogViewModel.CurveDir3 = visitsModel.CurveDir3;

            visitsLogViewModel.CurveDir4 = visitsModel.CurveDir4;

            visitsLogViewModel.ApicalDir1 = visitsModel.ApicalDir1;

            visitsLogViewModel.ApicalDir2 = visitsModel.ApicalDir2;

            visitsLogViewModel.ApicalDir3 = visitsModel.ApicalDir3;

            visitsLogViewModel.ApicalDir4 = visitsModel.ApicalDir4;

            visitsLogViewModel.withBraceS = visitsModel.withBraceS;

            visitsLogViewModel.CurveLevel1FromS = visitsModel.CurveLevel1FromS;

            visitsLogViewModel.CurveLevel1FromS = visitsModel.CurveLevel1FromS;

            visitsLogViewModel.CurveLevel1ToS = visitsModel.CurveLevel1ToS;

            visitsLogViewModel.CurveLevel2FromS = visitsModel.CurveLevel2FromS;

            visitsLogViewModel.CurveLevel2ToS = visitsModel.CurveLevel2ToS;

            visitsLogViewModel.CurveLevel3FromS = visitsModel.CurveLevel3FromS;

            visitsLogViewModel.CurveLevel3ToS = visitsModel.CurveLevel3ToS;

            visitsLogViewModel.CurveLevel4FromS = visitsModel.CurveLevel4FromS;

            visitsLogViewModel.CurveLevel4ToS = visitsModel.CurveLevel4ToS;

            visitsLogViewModel.CurveDir1S = visitsModel.CurveDir1S;

            visitsLogViewModel.CurveDir2S = visitsModel.CurveDir2S;

            visitsLogViewModel.CurveDir3S = visitsModel.CurveDir3S;

            visitsLogViewModel.CurveDir4S = visitsModel.CurveDir4S;

            visitsLogViewModel.CurveApex1S = visitsModel.CurveApex1S;

            visitsLogViewModel.CurveApex2S = visitsModel.CurveApex2S;

            visitsLogViewModel.CurveApex3S = visitsModel.CurveApex3S;

            visitsLogViewModel.CurveApex4S = visitsModel.CurveApex4S;

            visitsLogViewModel.CurveDeg1S = visitsModel.CurveDeg1S;

            visitsLogViewModel.CurveDeg2S = visitsModel.CurveDeg2S;

            visitsLogViewModel.CurveDeg3S = visitsModel.CurveDeg3S;

            visitsLogViewModel.CurveDeg4S = visitsModel.CurveDeg4S;

            visitsLogViewModel.Thoracictype = visitsModel.Thoracictype;

            visitsLogViewModel.Lumbartype = visitsModel.Lumbartype;

            visitsLogViewModel.CurveDeg1 = visitsModel.CurveDeg1;

            visitsLogViewModel.CurveDeg2 = visitsModel.CurveDeg2;

            visitsLogViewModel.CurveDeg3 = visitsModel.CurveDeg3;

            visitsLogViewModel.CurveDeg4 = visitsModel.CurveDeg4;

            visitsLogViewModel.TrunkDir = visitsModel.TrunkDir;

            visitsLogViewModel.RTrunkShift = visitsModel.RTrunkShift;

            visitsLogViewModel.ApicalRotation1 = visitsModel.ApicalRotation1;

            visitsLogViewModel.ApicalRotation2 = visitsModel.ApicalRotation2;


            visitsLogViewModel.ApicalRotation3 = visitsModel.ApicalRotation3;

            visitsLogViewModel.ApicalRotation4 = visitsModel.ApicalRotation4;

            visitsLogViewModel.RSign = visitsModel.RSign;

            visitsLogViewModel.EpFusion = visitsModel.EpFusion;

            visitsLogViewModel.ThoKyphosis = visitsModel.ThoKyphosis;

            visitsLogViewModel.LumLordosis = visitsModel.LumLordosis;

            visitsLogViewModel.PlanObs = visitsModel.PlanObs;

            visitsLogViewModel.PlanBrace = visitsModel.PlanBrace;

            visitsLogViewModel.PlanBraceWeanTime = visitsModel.PlanBraceWeanTime;

            visitsLogViewModel.PlanFUYear = visitsModel.PlanFUYear;

            visitsLogViewModel.PlanFUMonth = visitsModel.PlanFUMonth;

            visitsLogViewModel.PlanFUWeek = visitsModel.PlanFUWeek;

            visitsLogViewModel.AfterBracing = visitsModel.AfterBracing;


            visitsLogViewModel.PRN = visitsModel.PRN;

            visitsLogViewModel.PlanXray = visitsModel.PlanXray;

            visitsLogViewModel.PlanSurgery = visitsModel.PlanSurgery;

            visitsLogViewModel.DrName = visitsModel.DrName;

            visitsLogViewModel.SpcRemarks = visitsModel.SpcRemarks;


            if (visitsModel.LastModify == DateTime.MinValue)
            {
                visitsLogViewModel.LastModify = null;
            }
            else
            {
                visitsLogViewModel.LastModify = visitsModel.LastModify;
            }

            //20200517 Add field
            visitsLogViewModel.TOCI = visitsModel.TOCI;

            visitsLogViewModel.CurveDeg1Padding = visitsModel.CurveDeg1Padding;
            visitsLogViewModel.CurveDeg1Paddingcm = visitsModel.CurveDeg1Paddingcm;
            visitsLogViewModel.CurveDeg2Padding = visitsModel.CurveDeg2Padding;
            visitsLogViewModel.CurveDeg2Paddingcm = visitsModel.CurveDeg2Paddingcm;
            visitsLogViewModel.CurveDeg3Padding = visitsModel.CurveDeg3Padding;
            visitsLogViewModel.CurveDeg3Paddingcm = visitsModel.CurveDeg3Paddingcm;
            visitsLogViewModel.CurveDeg4Padding = visitsModel.CurveDeg4Padding;
            visitsLogViewModel.CurveDeg4Paddingcm = visitsModel.CurveDeg4Paddingcm;

            visitsLogViewModel.CurveDeg1Paddings = visitsModel.CurveDeg1Paddings;
            visitsLogViewModel.CurveDeg1Paddingcms = visitsModel.CurveDeg1Paddingcms;
            visitsLogViewModel.CurveDeg2Paddings = visitsModel.CurveDeg2Paddings;
            visitsLogViewModel.CurveDeg2Paddingcms = visitsModel.CurveDeg2Paddingcms;
            visitsLogViewModel.CurveDeg3Paddings = visitsModel.CurveDeg3Paddings;
            visitsLogViewModel.CurveDeg3Paddingcms = visitsModel.CurveDeg3Paddingcms;
            visitsLogViewModel.CurveDeg4Paddings = visitsModel.CurveDeg4Paddings;
            visitsLogViewModel.CurveDeg4Paddingcms = visitsModel.CurveDeg4Paddingcms;

            visitsLogViewModel.ScannogramTotalR = visitsModel.ScannogramTotalR;
            visitsLogViewModel.ScannogramTotalL = visitsModel.ScannogramTotalL;
            visitsLogViewModel.ScannogramFemurR = visitsModel.ScannogramFemurR;
            visitsLogViewModel.ScannogramFemurL = visitsModel.ScannogramFemurL;
            visitsLogViewModel.ScannogramTibiaR = visitsModel.ScannogramTibiaR;
            visitsLogViewModel.ScannogramTibiaL = visitsModel.ScannogramTibiaL;

            //By Eddie Change according to the meeing at 3/7, 10/7 and 31/7
            visitsLogViewModel.QoL = visitsModel.QoL;
            visitsLogViewModel.RadSide1 = visitsModel.RadSide1;
            visitsLogViewModel.RadSide2 = visitsModel.RadSide2;
            visitsLogViewModel.RadSide3 = visitsModel.RadSide3;
            visitsLogViewModel.RadSide4 = visitsModel.RadSide4;
            visitsLogViewModel.RadDeg1 = visitsModel.RadDeg1;
            visitsLogViewModel.RadDeg2 = visitsModel.RadDeg2;
            visitsLogViewModel.RadDeg3 = visitsModel.RadDeg3;
            visitsLogViewModel.RadDeg4 = visitsModel.RadDeg4;
            visitsLogViewModel.RadFlexibility1 = visitsModel.RadFlexibility1;
            visitsLogViewModel.RadFlexibility2 = visitsModel.RadFlexibility2;
            visitsLogViewModel.RadFlexibility3 = visitsModel.RadFlexibility3;
            visitsLogViewModel.RadFlexibility4 = visitsModel.RadFlexibility4;

            return visitsLogViewModel;
        }

    }
}
