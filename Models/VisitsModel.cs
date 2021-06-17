using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Scoliosis.Models
{
    public class VisitsModel
    {
        [Required]
        [Key]
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
        public static explicit operator InfoVisitModel(VisitsModel visitsModel)
        {

            var infoVisitModel = new InfoVisitModel();

            infoVisitModel.SCN = visitsModel.SCN;

            if (visitsModel.DOC == null)
            {
                infoVisitModel.DOC = null;
            }
            else
            {
                infoVisitModel.DOC = visitsModel.DOC.Value.ToString("dd/MM/yyyy");
            }

            if (visitsModel.DOC == null)
            {
                infoVisitModel.DocHpylink = null;
            }
            else
            {
                infoVisitModel.DocHpylink = visitsModel.DOC.Value.ToString("yyyy-MM-dd");
            }


            infoVisitModel.Virtual = visitsModel.Virtual;

            if (visitsModel.HT != null)
            {
                infoVisitModel.HT = visitsModel.HT.Value.ToString();
            }
            else
            {
                infoVisitModel.HT = "0";
            }

            if (visitsModel.ArmSpan == null)
            {
                infoVisitModel.ArmSpan = "0";
            }
            else
            {
                infoVisitModel.ArmSpan = visitsModel.ArmSpan.ToString();
            }

            if (visitsModel.LArmSpan == null)
            {
                infoVisitModel.LArmSpan = "0";
            }
            else
            {
                infoVisitModel.LArmSpan = visitsModel.LArmSpan.ToString();
            }

            if (visitsModel.RArmSpan == null)
            {
                infoVisitModel.RArmSpan = "0";
            }
            else
            {
                infoVisitModel.RArmSpan = visitsModel.RArmSpan.ToString();
            }

            //Javascript
            if (visitsModel.SHT != null)
            {
                infoVisitModel.SHT = visitsModel.SHT.Value.ToString();
            }
            else
            {
                infoVisitModel.SHT = "";
            }

            if (visitsModel.WT != null)
            {
                infoVisitModel.WT = visitsModel.WT.Value.ToString();
            }
            else
            {
                infoVisitModel.WT = "";
            }

            //if (visitsModel.SHT == null)
            //{
            //    infoVisitModel.SHT = 0;
            //}
            //else
            //{
            //    infoVisitModel.SHT = visitsModel.SHT.Value;
            //}

            //if (visitsModel.WT == null)
            //{
            //    infoVisitModel.WT = 0;
            //}
            //else
            //{
            //    infoVisitModel.WT = visitsModel.WT.Value;
            //}

            if (visitsModel.isMenarchePos == true)
            {
                infoVisitModel.isMenarchePos = "true";
            }
            else
            {
                infoVisitModel.isMenarchePos = "false";
            }

            if (visitsModel.isMenarcheNeg == true)
            {
                infoVisitModel.isMenarcheNeg = "true";
            }
            else
            {
                infoVisitModel.isMenarcheNeg = "false";
            }

            if (visitsModel.MaturYear == null)
            {
                infoVisitModel.MaturYear = 0;
            }
            else
            {
                infoVisitModel.MaturYear = visitsModel.MaturYear.Value;
            }

            if (visitsModel.MaturMonth == null)
            {
                infoVisitModel.MaturMonth = 0;
            }
            else
            {
                infoVisitModel.MaturMonth = visitsModel.MaturMonth.Value;
            }

            infoVisitModel.Jointhyper = visitsModel.Jointhyper;


            if (visitsModel.AbdReflexA == null || visitsModel.AbdReflexA.ToString() == "" || visitsModel.AbdReflexA.ToString() == "\0")
            {
                infoVisitModel.AbdReflexA = "";
            }
            else
            {
                infoVisitModel.AbdReflexA = visitsModel.AbdReflexA.Value.ToString();
            }

            if (visitsModel.AbdReflexB == null || visitsModel.AbdReflexB.ToString() == "" || visitsModel.AbdReflexB.ToString() == "\0")
            {
                infoVisitModel.AbdReflexB = "";
            }
            else
            {
                infoVisitModel.AbdReflexB = visitsModel.AbdReflexB.Value.ToString();
            }

            if (visitsModel.AbdReflexC == null || visitsModel.AbdReflexC.ToString() == "" || visitsModel.AbdReflexC.ToString() == "\0")
            {
                infoVisitModel.AbdReflexC = "";
            }
            else
            {
                infoVisitModel.AbdReflexC = visitsModel.AbdReflexC.Value.ToString();
            }

            if (visitsModel.AbdReflexD == null || visitsModel.AbdReflexD.ToString() == "" || visitsModel.AbdReflexD.ToString() == "\0")
            {
                infoVisitModel.AbdReflexD = "";
            }
            else
            {
                infoVisitModel.AbdReflexD = visitsModel.AbdReflexD.Value.ToString();
            }


            if (visitsModel.CTrunkShiftDir == null || visitsModel.CTrunkShiftDir.ToString() == "" || visitsModel.CTrunkShiftDir.ToString() == "\0")
            {
                infoVisitModel.CTrunkShiftDir = "\0".ToCharArray()[0];
            }
            else
            {
                infoVisitModel.CTrunkShiftDir = visitsModel.CTrunkShiftDir.Value;
            }

            if (visitsModel.CTrunkShift == null)
            {
                infoVisitModel.CTrunkShift = 0;
            }
            else
            {
                infoVisitModel.CTrunkShift = visitsModel.CTrunkShift.Value;
            }


            infoVisitModel.R1Dir = visitsModel.R1Dir;

            if (visitsModel.Rotat1 == null)
            {
                infoVisitModel.Rotat1 = 0;
            }
            else
            {
                infoVisitModel.Rotat1 = visitsModel.Rotat1.Value;
            }

            infoVisitModel.R2Dir = visitsModel.R2Dir;

            if (visitsModel.Rotat2 == null)
            {
                infoVisitModel.Rotat2 = 0;
            }
            else
            {
                infoVisitModel.Rotat2 = visitsModel.Rotat2.Value;
            }

            infoVisitModel.R3Dir = visitsModel.R3Dir;

            if (visitsModel.Rotat3 == null)
            {
                infoVisitModel.Rotat3 = 0;
            }
            else
            {
                infoVisitModel.Rotat3 = visitsModel.Rotat3.Value;
            }

            infoVisitModel.R4Dir = visitsModel.R4Dir;

            if (visitsModel.Rotat4 == null)
            {
                infoVisitModel.Rotat4 = 0;
            }
            else
            {
                infoVisitModel.Rotat4 = visitsModel.Rotat4.Value;
            }

            if (visitsModel.ShoulderDir == null)
            {
                infoVisitModel.ShoulderDir = "";
            }
            else
            {
                infoVisitModel.ShoulderDir = visitsModel.ShoulderDir;
            }

            if (visitsModel.ShoulderAsy == null)
            {
                infoVisitModel.ShoulderAsy = 0;
            }
            else
            {
                infoVisitModel.ShoulderAsy = visitsModel.ShoulderAsy.Value;
            }


            if (visitsModel.BreastTanner == null)
            {
                infoVisitModel.BreastTanner = "";
            }
            else
            {
                infoVisitModel.BreastTanner = visitsModel.BreastTanner;
            }

            if (visitsModel.PubicTanner == null)
            {
                infoVisitModel.PubicTanner = "";
            }
            else
            {
                infoVisitModel.PubicTanner = visitsModel.PubicTanner;
            }

            if (visitsModel.hair == null)
            {
                infoVisitModel.hair = "";
            }
            else
            {
                infoVisitModel.hair = visitsModel.hair;
            }

            if (visitsModel.tricart == null)
            {
                infoVisitModel.tricart = "";
            }
            else
            {
                infoVisitModel.tricart = visitsModel.tricart;
            }


            if (visitsModel.trochanter == null)
            {
                infoVisitModel.trochanter = "";
            }
            else
            {
                infoVisitModel.trochanter = visitsModel.trochanter;
            }

            if (visitsModel.FemoralHead == null)
            {
                infoVisitModel.FemoralHead = "";
            }
            else
            {
                infoVisitModel.FemoralHead = visitsModel.FemoralHead;
            }

            if (visitsModel.withBrace == null)
            {
                infoVisitModel.withBrace = 0;
            }
            else
            {
                infoVisitModel.withBrace = visitsModel.withBrace.Value;
            }


            if (visitsModel.CurveLevel1From == null)
            {
                infoVisitModel.CurveLevel1From = "";
            }
            else
            {
                infoVisitModel.CurveLevel1From = visitsModel.CurveLevel1From;
            }

            if (visitsModel.CurveLevel1To == null)
            {
                infoVisitModel.CurveLevel1To = "";
            }
            else
            {
                infoVisitModel.CurveLevel1To = visitsModel.CurveLevel1To;
            }

            if (visitsModel.CurveLevel2From == null)
            {
                infoVisitModel.CurveLevel2From = "";
            }
            else
            {
                infoVisitModel.CurveLevel2From = visitsModel.CurveLevel2From;
            }

            if (visitsModel.CurveLevel2To == null)
            {
                infoVisitModel.CurveLevel2To = "";
            }
            else
            {
                infoVisitModel.CurveLevel2To = visitsModel.CurveLevel2To;
            }

            if (visitsModel.CurveLevel3From == null)
            {
                infoVisitModel.CurveLevel3From = "";
            }
            else
            {
                infoVisitModel.CurveLevel3From = visitsModel.CurveLevel3From;
            }

            if (visitsModel.CurveLevel3To == null)
            {
                infoVisitModel.CurveLevel3To = "";
            }
            else
            {
                infoVisitModel.CurveLevel3To = visitsModel.CurveLevel3To;
            }

            if (visitsModel.CurveLevel4From == null)
            {
                infoVisitModel.CurveLevel4From = "";
            }
            else
            {
                infoVisitModel.CurveLevel4From = visitsModel.CurveLevel4From;
            }

            if (visitsModel.CurveLevel4To == null)
            {
                infoVisitModel.CurveLevel4To = "";
            }
            else
            {
                infoVisitModel.CurveLevel4To = visitsModel.CurveLevel4To;
            }

            if (visitsModel.CurveApex1 == null)
            {
                infoVisitModel.CurveApex1 = "";
            }
            else
            {
                infoVisitModel.CurveApex1 = visitsModel.CurveApex1;
            }

            if (visitsModel.CurveApex2 == null)
            {
                infoVisitModel.CurveApex2 = "";
            }
            else
            {
                infoVisitModel.CurveApex2 = visitsModel.CurveApex2;
            }

            if (visitsModel.CurveApex3 == null)
            {
                infoVisitModel.CurveApex3 = "";
            }
            else
            {
                infoVisitModel.CurveApex3 = visitsModel.CurveApex3;
            }

            if (visitsModel.CurveApex4 == null)
            {
                infoVisitModel.CurveApex4 = "";
            }
            else
            {
                infoVisitModel.CurveApex4 = visitsModel.CurveApex4;
            }

            if (visitsModel.AVTDir1 == null)
            {
                infoVisitModel.AVTDir1 = "\0".ToCharArray()[0];
            }
            else
            {
                infoVisitModel.AVTDir1 = visitsModel.AVTDir1.Value;
            }

            if (visitsModel.AVTDir2 == null)
            {
                infoVisitModel.AVTDir2 = "\0".ToCharArray()[0];
            }
            else
            {
                infoVisitModel.AVTDir2 = visitsModel.AVTDir2.Value;
            }

            if (visitsModel.AVTDir3 == null)
            {
                infoVisitModel.AVTDir3 = "\0".ToCharArray()[0];
            }
            else
            {
                infoVisitModel.AVTDir3 = visitsModel.AVTDir3.Value;
            }

            if (visitsModel.AVTDir4 == null)
            {
                infoVisitModel.AVTDir4 = "\0".ToCharArray()[0];
            }
            else
            {
                infoVisitModel.AVTDir4 = visitsModel.AVTDir4.Value;
            }

            if (visitsModel.AVTDeg1 == null)
            {
                infoVisitModel.AVTDeg1 = "\0".ToCharArray()[0];
            }
            else
            {
                infoVisitModel.AVTDeg1 = visitsModel.AVTDeg1.Value;
            }

            if (visitsModel.AVTDeg2 == null)
            {
                infoVisitModel.AVTDeg2 = "\0".ToCharArray()[0];
            }
            else
            {
                infoVisitModel.AVTDeg2 = visitsModel.AVTDeg2.Value;
            }

            if (visitsModel.AVTDeg3 == null)
            {
                infoVisitModel.AVTDeg3 = "\0".ToCharArray()[0];
            }
            else
            {
                infoVisitModel.AVTDeg3 = visitsModel.AVTDeg3.Value;
            }

            if (visitsModel.AVTDeg4 == null)
            {
                infoVisitModel.AVTDeg4 = "\0".ToCharArray()[0];
            }
            else
            {
                infoVisitModel.AVTDeg4 = visitsModel.AVTDeg4.Value;
            }

            if (visitsModel.CurveDir1 == null)
            {
                infoVisitModel.CurveDir1 = "";
            }
            else
            {
                infoVisitModel.CurveDir1 = visitsModel.CurveDir1;
            }

            if (visitsModel.CurveDir2 == null)
            {
                infoVisitModel.CurveDir2 = "";
            }
            else
            {
                infoVisitModel.CurveDir2 = visitsModel.CurveDir2;
            }

            if (visitsModel.CurveDir3 == null)
            {
                infoVisitModel.CurveDir3 = "";
            }
            else
            {
                infoVisitModel.CurveDir3 = visitsModel.CurveDir3;
            }

            if (visitsModel.CurveDir4 == null)
            {
                infoVisitModel.CurveDir4 = "";
            }
            else
            {
                infoVisitModel.CurveDir4 = visitsModel.CurveDir4;
            }

            if (visitsModel.ApicalDir1 == null)
            {
                infoVisitModel.ApicalDir1 = "";
            }
            else
            {
                infoVisitModel.ApicalDir1 = visitsModel.ApicalDir1;
            }

            if (visitsModel.ApicalDir2 == null)
            {
                infoVisitModel.ApicalDir2 = "";
            }
            else
            {
                infoVisitModel.ApicalDir2 = visitsModel.ApicalDir2;
            }

            if (visitsModel.ApicalDir3 == null)
            {
                infoVisitModel.ApicalDir3 = "";
            }
            else
            {
                infoVisitModel.ApicalDir3 = visitsModel.ApicalDir3;
            }

            if (visitsModel.ApicalDir4 == null)
            {
                infoVisitModel.ApicalDir4 = "";
            }
            else
            {
                infoVisitModel.ApicalDir4 = visitsModel.ApicalDir4;
            }

            if (visitsModel.withBraceS == null)
            {
                infoVisitModel.withBraceS = 0;
            }
            else
            {
                infoVisitModel.withBraceS = visitsModel.withBraceS.Value;
            }

            if (visitsModel.CurveLevel1FromS == null)
            {
                infoVisitModel.CurveLevel1FromS = "";
            }
            else
            {
                infoVisitModel.CurveLevel1FromS = visitsModel.CurveLevel1FromS;
            }

            if (visitsModel.CurveLevel1FromS == null)
            {
                infoVisitModel.CurveLevel1FromS = "";
            }
            else
            {
                infoVisitModel.CurveLevel1FromS = visitsModel.CurveLevel1FromS;
            }

            if (visitsModel.CurveLevel1ToS == null)
            {
                infoVisitModel.CurveLevel1ToS = "";
            }
            else
            {
                infoVisitModel.CurveLevel1ToS = visitsModel.CurveLevel1ToS;
            }

            if (visitsModel.CurveLevel1ToS == null)
            {
                infoVisitModel.CurveLevel2FromS = "";
            }
            else
            {
                infoVisitModel.CurveLevel2FromS = visitsModel.CurveLevel2FromS;
            }

            if (visitsModel.CurveLevel2ToS == null)
            {
                infoVisitModel.CurveLevel2ToS = "";
            }
            else
            {
                infoVisitModel.CurveLevel2ToS = visitsModel.CurveLevel2ToS;
            }


            if (visitsModel.CurveLevel3FromS == null)
            {
                infoVisitModel.CurveLevel3FromS = "";
            }
            else
            {
                infoVisitModel.CurveLevel3FromS = visitsModel.CurveLevel3FromS;
            }

            if (visitsModel.CurveLevel3ToS == null)
            {
                infoVisitModel.CurveLevel3ToS = "";
            }
            else
            {
                infoVisitModel.CurveLevel3ToS = visitsModel.CurveLevel3ToS;
            }

            if (visitsModel.CurveLevel4FromS == null)
            {
                infoVisitModel.CurveLevel4FromS = "";
            }
            else
            {
                infoVisitModel.CurveLevel4FromS = visitsModel.CurveLevel4FromS;
            }

            if (visitsModel.CurveLevel4ToS == null)
            {
                infoVisitModel.CurveLevel4ToS = "";
            }
            else
            {
                infoVisitModel.CurveLevel4ToS = visitsModel.CurveLevel4ToS;
            }


            if (visitsModel.CurveDir1S == null)
            {
                infoVisitModel.CurveDir1S = "";
            }
            else
            {
                infoVisitModel.CurveDir1S = visitsModel.CurveDir1S;
            }

            if (visitsModel.CurveDir2S == null)
            {
                infoVisitModel.CurveDir2S = "";
            }
            else
            {
                infoVisitModel.CurveDir2S = visitsModel.CurveDir2S;
            }

            if (visitsModel.CurveDir3S == null)
            {
                infoVisitModel.CurveDir3S = "";
            }
            else
            {
                infoVisitModel.CurveDir3S = visitsModel.CurveDir3S;
            }

            if (visitsModel.CurveDir4S == null)
            {
                infoVisitModel.CurveDir4S = "";
            }
            else
            {
                infoVisitModel.CurveDir4S = visitsModel.CurveDir4S;
            }

            if (visitsModel.CurveApex1S == null)
            {
                infoVisitModel.CurveApex1S = "";
            }
            else
            {
                infoVisitModel.CurveApex1S = visitsModel.CurveApex1S;
            }

            if (visitsModel.CurveApex2S == null)
            {
                infoVisitModel.CurveApex2S = "";
            }
            else
            {
                infoVisitModel.CurveApex2S = visitsModel.CurveApex2S;
            }

            if (visitsModel.CurveApex3S == null)
            {
                infoVisitModel.CurveApex3S = "";
            }
            else
            {
                infoVisitModel.CurveApex3S = visitsModel.CurveApex3S;
            }


            if (visitsModel.CurveApex4S == null)
            {
                infoVisitModel.CurveApex4S = "";
            }
            else
            {
                infoVisitModel.CurveApex4S = visitsModel.CurveApex4S;
            }



            if (visitsModel.CurveDeg1S == null)
            {
                infoVisitModel.CurveDeg1S = 0;
            }
            else
            {
                infoVisitModel.CurveDeg1S = visitsModel.CurveDeg1S.Value;
            }

            if (visitsModel.CurveDeg2S == null)
            {
                infoVisitModel.CurveDeg2S = 0;
            }
            else
            {
                infoVisitModel.CurveDeg2S = visitsModel.CurveDeg2S.Value;
            }

            if (visitsModel.CurveDeg3S == null)
            {
                infoVisitModel.CurveDeg3S = 0;
            }
            else
            {
                infoVisitModel.CurveDeg3S = visitsModel.CurveDeg3S.Value;
            }

            if (visitsModel.CurveDeg4S == null)
            {
                infoVisitModel.CurveDeg4S = 0;
            }
            else
            {
                infoVisitModel.CurveDeg4S = visitsModel.CurveDeg4S.Value;
            }


            if (visitsModel.Thoracictype == null)
            {
                infoVisitModel.Thoracictype = "\0".ToCharArray()[0];
            }
            else
            {
                infoVisitModel.Thoracictype = visitsModel.Thoracictype.Value;
            }

            if (visitsModel.Lumbartype == null)
            {
                infoVisitModel.Lumbartype = "\0".ToCharArray()[0];
            }
            else
            {
                infoVisitModel.Lumbartype = visitsModel.Lumbartype.Value;
            }


            if (visitsModel.CurveDeg1 == null)
            {
                infoVisitModel.CurveDeg1 = 0;
            }
            else
            {
                infoVisitModel.CurveDeg1 = visitsModel.CurveDeg1.Value;
            }

            if (visitsModel.CurveDeg2 == null)
            {
                infoVisitModel.CurveDeg2 = 0;
            }
            else
            {
                infoVisitModel.CurveDeg2 = visitsModel.CurveDeg2.Value;
            }

            if (visitsModel.CurveDeg3 == null)
            {
                infoVisitModel.CurveDeg3 = 0;
            }
            else
            {
                infoVisitModel.CurveDeg3 = visitsModel.CurveDeg3.Value;
            }

            if (visitsModel.CurveDeg4 == null)
            {
                infoVisitModel.CurveDeg4 = 0;
            }
            else
            {
                infoVisitModel.CurveDeg4 = visitsModel.CurveDeg4.Value;
            }


            if (visitsModel.TrunkDir == null)
            {
                infoVisitModel.TrunkDir = "";
            }
            else
            {
                infoVisitModel.TrunkDir = visitsModel.TrunkDir.Value.ToString();
            }

            if (visitsModel.RTrunkShift == null)
            {
                infoVisitModel.RTrunkShift = 0;
            }
            else
            {
                infoVisitModel.RTrunkShift = visitsModel.RTrunkShift.Value;
            }

            if (visitsModel.ApicalRotation1 == null)
            {
                infoVisitModel.ApicalRotation1 = "";
            }
            else
            {
                infoVisitModel.ApicalRotation1 = visitsModel.ApicalRotation1;
            }


            if (visitsModel.ApicalRotation2 == null)
            {
                infoVisitModel.ApicalRotation2 = "";
            }
            else
            {
                infoVisitModel.ApicalRotation2 = visitsModel.ApicalRotation2;
            }

            if (visitsModel.ApicalRotation3 == null)
            {
                infoVisitModel.ApicalRotation3 = "";
            }
            else
            {
                infoVisitModel.ApicalRotation3 = visitsModel.ApicalRotation3;
            }

            if (visitsModel.ApicalRotation4 == null)
            {
                infoVisitModel.ApicalRotation4 = "";
            }
            else
            {
                infoVisitModel.ApicalRotation4 = visitsModel.ApicalRotation4;
            }

            if (visitsModel.RSign == null)
            {
                infoVisitModel.RSign = "";
            }
            else
            {
                infoVisitModel.RSign = visitsModel.RSign;
            }

            if (visitsModel.EpFusion == null)
            {
                infoVisitModel.EpFusion = "";
            }
            else
            {
                infoVisitModel.EpFusion = visitsModel.EpFusion;
            }

            if (visitsModel.ThoKyphosis == null)
            {
                infoVisitModel.ThoKyphosis = 0;
            }
            else
            {
                infoVisitModel.ThoKyphosis = visitsModel.ThoKyphosis.Value;
            }

            if (visitsModel.LumLordosis == null)
            {
                infoVisitModel.LumLordosis = 0;
            }
            else
            {
                infoVisitModel.LumLordosis = visitsModel.LumLordosis.Value;
            }


            if (visitsModel.PlanObs == null)
            {
                infoVisitModel.PlanObs = "";
            }
            else
            {
                infoVisitModel.PlanObs = visitsModel.PlanObs;
            }

            if (visitsModel.PlanBrace == null)
            {
                infoVisitModel.PlanBrace = "";
            }
            else
            {
                infoVisitModel.PlanBrace = visitsModel.PlanBrace;
            }

            if (visitsModel.PlanBraceWeanTime == null)
            {
                infoVisitModel.PlanBraceWeanTime = 0;
            }
            else
            {
                infoVisitModel.PlanBraceWeanTime = visitsModel.PlanBraceWeanTime.Value;
            }

            if (visitsModel.PlanFUYear == null)
            {
                infoVisitModel.PlanFUYear = 0;
            }
            else
            {
                infoVisitModel.PlanFUYear = visitsModel.PlanFUYear.Value;
            }

            if (visitsModel.PlanFUMonth == null)
            {
                infoVisitModel.PlanFUMonth = 0;
            }
            else
            {
                infoVisitModel.PlanFUMonth = visitsModel.PlanFUMonth.Value;
            }


            if (visitsModel.PlanFUWeek == null)
            {
                infoVisitModel.PlanFUWeek = 0;
            }
            else
            {
                infoVisitModel.PlanFUWeek = visitsModel.PlanFUWeek.Value;
            }

            if (visitsModel.AfterBracing == true)
            {
                infoVisitModel.AfterBracing = "true";
            }
            else
            {
                infoVisitModel.AfterBracing = "false";
            }

            if (visitsModel.PRN == true)
            {
                infoVisitModel.PRN = "true";
            }
            else
            {
                infoVisitModel.PRN = "false";
            }

            if (visitsModel.PlanXray == null)
            {
                infoVisitModel.PlanXray = "";
            }
            else
            {
                infoVisitModel.PlanXray = visitsModel.PlanXray;
            }

            if (visitsModel.PlanSurgery == null)
            {
                infoVisitModel.PlanSurgery = "";
            }
            else
            {
                infoVisitModel.PlanSurgery = visitsModel.PlanSurgery;
            }

            if (visitsModel.DrName == null)
            {
                infoVisitModel.DrName = "";
            }
            else
            {
                infoVisitModel.DrName = visitsModel.DrName;
            }

            if (visitsModel.SpcRemarks == null)
            {
                infoVisitModel.SpcRemarks = "";
            }
            else
            {
                infoVisitModel.SpcRemarks = visitsModel.SpcRemarks;
            }


            if (visitsModel.LastModify == null)
            {
                infoVisitModel.LastModify = DateTime.Now;
            }
            else
            {
                infoVisitModel.LastModify = visitsModel.LastModify.Value;
            }

            //20200517 Add field
            if (string.IsNullOrEmpty(visitsModel.TOCI))
            {
                infoVisitModel.TOCI = "";
            }
            else
            {
                infoVisitModel.TOCI = visitsModel.TOCI;
            }


            if (string.IsNullOrEmpty(visitsModel.CurveDeg1Padding))
            {
                infoVisitModel.CurveDeg1Padding = "";
            }
            else
            {
                infoVisitModel.CurveDeg1Padding = visitsModel.CurveDeg1Padding;
            }

            if (string.IsNullOrEmpty(visitsModel.CurveDeg1Paddingcm))
            {
                infoVisitModel.CurveDeg1Paddingcm = "";
            }
            else
            {
                infoVisitModel.CurveDeg1Paddingcm = visitsModel.CurveDeg1Paddingcm;
            }

            if (string.IsNullOrEmpty(visitsModel.CurveDeg2Padding))
            {
                infoVisitModel.CurveDeg2Padding = "";
            }
            else
            {
                infoVisitModel.CurveDeg2Padding = visitsModel.CurveDeg2Padding;
            }

            if (string.IsNullOrEmpty(visitsModel.CurveDeg2Paddingcm))
            {
                infoVisitModel.CurveDeg2Paddingcm = "";
            }
            else
            {
                infoVisitModel.CurveDeg2Paddingcm = visitsModel.CurveDeg2Paddingcm;
            }

            if (string.IsNullOrEmpty(visitsModel.CurveDeg3Padding))
            {
                infoVisitModel.CurveDeg3Padding = "";
            }
            else
            {
                infoVisitModel.CurveDeg3Padding = visitsModel.CurveDeg3Padding;
            }

            if (string.IsNullOrEmpty(visitsModel.CurveDeg3Paddingcm))
            {
                infoVisitModel.CurveDeg3Paddingcm = "";
            }
            else
            {
                infoVisitModel.CurveDeg3Paddingcm = visitsModel.CurveDeg3Paddingcm;
            }

            if (string.IsNullOrEmpty(visitsModel.CurveDeg4Padding))
            {
                infoVisitModel.CurveDeg4Padding = "";
            }
            else
            {
                infoVisitModel.CurveDeg4Padding = visitsModel.CurveDeg4Padding;
            }

            if (string.IsNullOrEmpty(visitsModel.CurveDeg4Paddingcm))
            {
                infoVisitModel.CurveDeg4Paddingcm = "";
            }
            else
            {
                infoVisitModel.CurveDeg4Paddingcm = visitsModel.CurveDeg4Paddingcm;
            }

            if (string.IsNullOrEmpty(visitsModel.CurveDeg1Paddings))
            {
                infoVisitModel.CurveDeg1Paddings = "";
            }
            else
            {
                infoVisitModel.CurveDeg1Paddings = visitsModel.CurveDeg1Paddings;
            }

            if (string.IsNullOrEmpty(visitsModel.CurveDeg1Paddingcms))
            {
                infoVisitModel.CurveDeg1Paddingcms = "";
            }
            else
            {
                infoVisitModel.CurveDeg1Paddingcms = visitsModel.CurveDeg1Paddingcms;
            }

            if (string.IsNullOrEmpty(visitsModel.CurveDeg2Paddings))
            {
                infoVisitModel.CurveDeg2Paddings = "";
            }
            else
            {
                infoVisitModel.CurveDeg2Paddings = visitsModel.CurveDeg2Paddings;
            }

            if (string.IsNullOrEmpty(visitsModel.CurveDeg2Paddingcms))
            {
                infoVisitModel.CurveDeg2Paddingcms = "";
            }
            else
            {
                infoVisitModel.CurveDeg2Paddingcms = visitsModel.CurveDeg2Paddingcms;
            }

            if (string.IsNullOrEmpty(visitsModel.CurveDeg3Paddings))
            {
                infoVisitModel.CurveDeg3Paddings = "";
            }
            else
            {
                infoVisitModel.CurveDeg3Paddings = visitsModel.CurveDeg3Paddings;
            }

            if (string.IsNullOrEmpty(visitsModel.CurveDeg3Paddingcms))
            {
                infoVisitModel.CurveDeg3Paddingcms = "";
            }
            else
            {
                infoVisitModel.CurveDeg3Paddingcms = visitsModel.CurveDeg3Paddingcms;
            }

            if (string.IsNullOrEmpty(visitsModel.CurveDeg4Paddings))
            {
                infoVisitModel.CurveDeg4Paddings = "";
            }
            else
            {
                infoVisitModel.CurveDeg4Paddings = visitsModel.CurveDeg4Paddings;
            }

            if (string.IsNullOrEmpty(visitsModel.CurveDeg4Paddingcms))
            {
                infoVisitModel.CurveDeg4Paddingcms = "";
            }
            else
            {
                infoVisitModel.CurveDeg4Paddingcms = visitsModel.CurveDeg4Paddingcms;
            }

            if (string.IsNullOrEmpty(visitsModel.ScannogramTotalR))
            {
                infoVisitModel.ScannogramTotalR = "";
            }
            else
            {
                infoVisitModel.ScannogramTotalR = visitsModel.ScannogramTotalR;
            }

            if (string.IsNullOrEmpty(visitsModel.ScannogramTotalL))
            {
                infoVisitModel.ScannogramTotalL = "";
            }
            else
            {
                infoVisitModel.ScannogramTotalL = visitsModel.ScannogramTotalL;
            }

            if (string.IsNullOrEmpty(visitsModel.ScannogramFemurR))
            {
                infoVisitModel.ScannogramFemurR = "";
            }
            else
            {
                infoVisitModel.ScannogramFemurR = visitsModel.ScannogramFemurR;
            }

            if (string.IsNullOrEmpty(visitsModel.ScannogramFemurL))
            {
                infoVisitModel.ScannogramFemurL = "";
            }
            else
            {
                infoVisitModel.ScannogramFemurL = visitsModel.ScannogramFemurL;
            }

            if (string.IsNullOrEmpty(visitsModel.ScannogramTibiaR))
            {
                infoVisitModel.ScannogramTibiaR = "";
            }
            else
            {
                infoVisitModel.ScannogramTibiaR = visitsModel.ScannogramTibiaR;
            }

            if (string.IsNullOrEmpty(visitsModel.ScannogramTibiaL))
            {
                infoVisitModel.ScannogramTibiaL = "";
            }
            else
            {
                infoVisitModel.ScannogramTibiaL = visitsModel.ScannogramTibiaL;
            }

            //By Eddie Change according to the meeing at 3/7, 10/7 and 31/7
           

            if (visitsModel.QoL == null)
            {
                infoVisitModel.QoL = 0;
            }
            else
            {
                infoVisitModel.QoL = visitsModel.QoL.Value;
            }
            

            if (visitsModel.RadSide1 == null)
            {
                infoVisitModel.RadSide1 = "";
            }
            else
            {
                infoVisitModel.RadSide1 = visitsModel.RadSide1;
            }
            if (visitsModel.RadSide2 == null)
            {
                infoVisitModel.RadSide2 = "";
            }
            else
            {
                infoVisitModel.RadSide2 = visitsModel.RadSide2;
            }
            if (visitsModel.RadSide3 == null)
            {
                infoVisitModel.RadSide3 = "";
            }
            else
            {
                infoVisitModel.RadSide3 = visitsModel.RadSide3;
            }
            if (visitsModel.RadSide4 == null)
            {
                infoVisitModel.RadSide4 = "";
            }
            else
            {
                infoVisitModel.RadSide4 = visitsModel.RadSide4;
            }
            if (visitsModel.RadDeg1 == null)
            {
                infoVisitModel.RadDeg1 = 0;
            }
            else
            {
                infoVisitModel.RadDeg1 = visitsModel.RadDeg1.Value;
            }
            if (visitsModel.RadDeg2 == null)
            {
                infoVisitModel.RadDeg2 = 0;
            }
            else
            {
                infoVisitModel.RadDeg2 = visitsModel.RadDeg2.Value;
            }
            if (visitsModel.RadDeg3 == null)
            {
                infoVisitModel.RadDeg3 = 0;
            }
            else
            {
                infoVisitModel.RadDeg3 = visitsModel.RadDeg3.Value;
            }
            if (visitsModel.RadDeg4 == null)
            {
                infoVisitModel.RadDeg4 = 0;
            }
            else
            {
                infoVisitModel.RadDeg4 = visitsModel.RadDeg4.Value;
            }

            if (visitsModel.RadFlexibility1 == null)
            {
                infoVisitModel.RadFlexibility1 = 0;
            }
            else
            {
                infoVisitModel.RadFlexibility1 = visitsModel.RadFlexibility1.Value;
            }
            if (visitsModel.RadFlexibility2 == null)
            {
                infoVisitModel.RadFlexibility2 = 0;
            }
            else
            {
                infoVisitModel.RadFlexibility2 = visitsModel.RadFlexibility2.Value;
            }
            if (visitsModel.RadFlexibility3 == null)
            {
                infoVisitModel.RadFlexibility3 = 0;
            }
            else
            {
                infoVisitModel.RadFlexibility3 = visitsModel.RadFlexibility3.Value;
            }
            if (visitsModel.RadFlexibility4 == null)
            {
                infoVisitModel.RadFlexibility4 = 0;
            }
            else
            {
                infoVisitModel.RadFlexibility4 = visitsModel.RadFlexibility4.Value;
            }

            infoVisitModel.DrFullName = "";

            return infoVisitModel;

        }

        public static explicit operator InfoVisitsListViewModel(VisitsModel visitsModel)
        {

            var infoVisitsListViewModel = new InfoVisitsListViewModel();

            infoVisitsListViewModel.SCN = visitsModel.SCN;

            //Set in the Controller
            //infoVisitsListViewModel.Age =

            if (visitsModel.SpcRemarks.ToString() != "")
            {
                infoVisitsListViewModel.SpecialRemarks = "Yes";
            }
            else
            {
                infoVisitsListViewModel.SpecialRemarks = "No";
            }

            infoVisitsListViewModel.HeightArmSpan = visitsModel.HT + "/" + visitsModel.ArmSpan;

            if (visitsModel.HT != null)
            {
                infoVisitsListViewModel.SeatingHeight = visitsModel.HT.Value.ToString();
            }
            else
            {
                infoVisitsListViewModel.SeatingHeight = "";
            }

            //Javascript
            if (visitsModel.SHT != null)
            {
                infoVisitsListViewModel.SeatingHeight = visitsModel.SHT.Value.ToString();
            }
            else
            {
                infoVisitsListViewModel.SeatingHeight = "";
            }

            if (visitsModel.WT != null)
            {
                infoVisitsListViewModel.Weight = visitsModel.WT.Value.ToString();
            }
            else
            {
                infoVisitsListViewModel.Weight = "";
            }

            if (visitsModel.MaturYear != null)
            {
                infoVisitsListViewModel.MenarcheYear = visitsModel.MaturYear.Value.ToString();
            }
            else
            {
                infoVisitsListViewModel.MenarcheYear = "";
            }

            if (visitsModel.MaturMonth != null)
            {
                infoVisitsListViewModel.MenarcheMonth = visitsModel.MaturMonth.Value.ToString();
            }
            else
            {
                infoVisitsListViewModel.MenarcheMonth = "";
            }


            if (visitsModel.RSign != null)
            {
                infoVisitsListViewModel.RissersSign = visitsModel.RSign;
            }
            else
            {
                infoVisitsListViewModel.RissersSign = "";
            }

            if (visitsModel.CurveLevel1From != null)
            {
                infoVisitsListViewModel.CruveLevel1 = visitsModel.CurveLevel1From + " - ";
            }
            else
            {
                infoVisitsListViewModel.CruveLevel1 = " - ";
            }

            if (visitsModel.CurveLevel1To != null)
            {
                infoVisitsListViewModel.CruveLevel1 += visitsModel.CurveLevel1To;
            }
            else
            {
                infoVisitsListViewModel.CruveLevel1 += "";
            }


            if (visitsModel.CurveLevel2From != null)
            {
                infoVisitsListViewModel.CruveLevel2 = visitsModel.CurveLevel2From + " - ";
            }
            else
            {
                infoVisitsListViewModel.CruveLevel2 = " - ";
            }

            if (visitsModel.CurveLevel2To != null)
            {
                infoVisitsListViewModel.CruveLevel2 += visitsModel.CurveLevel2To;
            }
            else
            {
                infoVisitsListViewModel.CruveLevel2 += "";
            }


            if (visitsModel.CurveLevel3From != null)
            {
                infoVisitsListViewModel.CruveLevel3 = visitsModel.CurveLevel3From + " - ";
            }
            else
            {
                infoVisitsListViewModel.CruveLevel3 = " - ";
            }

            if (visitsModel.CurveLevel3To != null)
            {
                infoVisitsListViewModel.CruveLevel3 += visitsModel.CurveLevel3To;
            }
            else
            {
                infoVisitsListViewModel.CruveLevel3 += "";
            }

            if (visitsModel.CurveLevel4From != null)
            {
                infoVisitsListViewModel.CruveLevel4 = visitsModel.CurveLevel4From + " - ";
            }
            else
            {
                infoVisitsListViewModel.CruveLevel4 = " - ";
            }

            if (visitsModel.CurveLevel4To != null)
            {
                infoVisitsListViewModel.CruveLevel4 += visitsModel.CurveLevel4To;
            }
            else
            {
                infoVisitsListViewModel.CruveLevel4 += "";
            }

            if (visitsModel.withBrace == null)
            {
                infoVisitsListViewModel.MeasuredWithBrace = "";
            }
            else if (visitsModel.withBrace == 0)
            {
                infoVisitsListViewModel.MeasuredWithBrace = "Unknown";
            }
            else if (visitsModel.withBrace == 1)
            {
                infoVisitsListViewModel.MeasuredWithBrace = "Yes";
            }
            else if (visitsModel.withBrace == 2)
            {
                infoVisitsListViewModel.MeasuredWithBrace = "No";
            }


            if (visitsModel.CurveDeg1 != null)
            {
                infoVisitsListViewModel.CurveDeg1 = visitsModel.CurveDeg1.ToString();
            }
            else
            {
                infoVisitsListViewModel.CurveDeg1 = "";
            }

            if (visitsModel.CurveDeg2 != null)
            {
                infoVisitsListViewModel.CurveDeg2 = visitsModel.CurveDeg2.ToString();
            }
            else
            {
                infoVisitsListViewModel.CurveDeg2 = "";
            }

            if (visitsModel.CurveDeg3 != null)
            {
                infoVisitsListViewModel.CurveDeg3 = visitsModel.CurveDeg3.ToString();
            }
            else
            {
                infoVisitsListViewModel.CurveDeg3 = "";
            }

            if (visitsModel.CurveDeg4 != null)
            {
                infoVisitsListViewModel.CurveDeg4 = visitsModel.CurveDeg4.ToString();
            }
            else
            {
                infoVisitsListViewModel.CurveDeg4 = "";
            }

            if (visitsModel.Virtual != null)
            {
                infoVisitsListViewModel.VisitType = visitsModel.Virtual;
            }
            else
            {
                infoVisitsListViewModel.VisitType = "";
            }

            if (visitsModel.HT != null)
            {
                infoVisitsListViewModel.Height = visitsModel.HT.ToString();
            }
            else
            {
                infoVisitsListViewModel.Height = "";
            }

            if (visitsModel.ArmSpan != null)
            {
                infoVisitsListViewModel.ArmSpan = visitsModel.ArmSpan.ToString();
            }
            else
            {
                infoVisitsListViewModel.ArmSpan = "";
            }

            if (visitsModel.LArmSpan != null)
            {
                infoVisitsListViewModel.LArmSpan = visitsModel.LArmSpan.ToString();
            }
            else
            {
                infoVisitsListViewModel.LArmSpan = "";
            }

            if (visitsModel.RArmSpan != null)
            {
                infoVisitsListViewModel.RArmSpan = visitsModel.RArmSpan.ToString();
            }
            else
            {
                infoVisitsListViewModel.RArmSpan = "";

            }

            if (!string.IsNullOrEmpty(visitsModel.TOCI))
            {

                infoVisitsListViewModel.TOCI = visitsModel.TOCI.ToString();
            }
            else
            {
                infoVisitsListViewModel.TOCI = "";

            }


            if (!string.IsNullOrEmpty(visitsModel.CurveDeg1Padding))
            {

                infoVisitsListViewModel.CurveDeg1Padding = visitsModel.CurveDeg1Padding.ToString();
            }
            else
            {
                infoVisitsListViewModel.CurveDeg1Padding = "";

            }

            if (!string.IsNullOrEmpty(visitsModel.CurveDeg2Padding))
            {

                infoVisitsListViewModel.CurveDeg2Padding = visitsModel.CurveDeg2Padding.ToString();
            }
            else
            {
                infoVisitsListViewModel.CurveDeg2Padding = "";

            }

            if (!string.IsNullOrEmpty(visitsModel.CurveDeg3Padding))
            {

                infoVisitsListViewModel.CurveDeg3Padding = visitsModel.CurveDeg3Padding.ToString();
            }
            else
            {
                infoVisitsListViewModel.CurveDeg3Padding = "";

            }

            if (!string.IsNullOrEmpty(visitsModel.CurveDeg4Padding))
            {

                infoVisitsListViewModel.CurveDeg4Padding = visitsModel.CurveDeg4Padding.ToString();
            }
            else
            {
                infoVisitsListViewModel.CurveDeg4Padding = "";

            }
            if (!string.IsNullOrEmpty(visitsModel.CurveDeg1Paddingcm))
            {

                infoVisitsListViewModel.CurveDeg1Paddingcm = visitsModel.CurveDeg1Paddingcm.ToString();
            }
            else
            {
                infoVisitsListViewModel.CurveDeg1Paddingcm = "";

            }

            if (!string.IsNullOrEmpty(visitsModel.CurveDeg2Paddingcm))
            {

                infoVisitsListViewModel.CurveDeg2Paddingcm = visitsModel.CurveDeg2Paddingcm.ToString();
            }
            else
            {
                infoVisitsListViewModel.CurveDeg2Paddingcm = "";

            }

            if (!string.IsNullOrEmpty(visitsModel.CurveDeg3Paddingcm))
            {

                infoVisitsListViewModel.CurveDeg3Paddingcm = visitsModel.CurveDeg3Paddingcm.ToString();
            }
            else
            {
                infoVisitsListViewModel.CurveDeg3Paddingcm = "";

            }

            if (!string.IsNullOrEmpty(visitsModel.CurveDeg4Paddingcm))
            {

                infoVisitsListViewModel.CurveDeg4Paddingcm = visitsModel.CurveDeg4Paddingcm.ToString();
            }
            else
            {
                infoVisitsListViewModel.CurveDeg4Paddingcm = "";

            }

            //By Eddie Change according to the meeing at 3/7, 10/7 and 31/7
           

            if (visitsModel.QoL == null)
            {
                infoVisitsListViewModel.QoL = "";
            }
            else
            {
                infoVisitsListViewModel.QoL = visitsModel.QoL.ToString();
            }
           
            if (visitsModel.RadDeg1 == null)
            {
                infoVisitsListViewModel.RadDeg1 = "";
            }
            else
            {
                infoVisitsListViewModel.RadDeg1 = visitsModel.RadDeg1.ToString();
            }
            if (visitsModel.RadDeg2 == null)
            {
                infoVisitsListViewModel.RadDeg2 = "";
            }
            else
            {
                infoVisitsListViewModel.RadDeg2 = visitsModel.RadDeg2.ToString();
            }
            if (visitsModel.RadDeg3 == null)
            {
                infoVisitsListViewModel.RadDeg3 = "";
            }
            else
            {
                infoVisitsListViewModel.RadDeg3 = visitsModel.RadDeg3.ToString();
            }
            if (visitsModel.RadDeg4 == null)
            {
                infoVisitsListViewModel.RadDeg4 = "";
            }
            else
            {
                infoVisitsListViewModel.RadDeg4 = visitsModel.RadDeg4.ToString();
            }

            if (visitsModel.RadSide1 == null)
            {
                infoVisitsListViewModel.RadSide1 = "";
            }
            else
            {
                infoVisitsListViewModel.RadSide1 = visitsModel.RadSide1.ToString();
            }
            if (visitsModel.RadSide2 == null)
            {
                infoVisitsListViewModel.RadSide2 = "";
            }
            else
            {
                infoVisitsListViewModel.RadSide2 = visitsModel.RadSide2.ToString();
            }
            if (visitsModel.RadSide3 == null)
            {
                infoVisitsListViewModel.RadSide3 = "";
            }
            else
            {
                infoVisitsListViewModel.RadSide3 = visitsModel.RadSide3.ToString();
            }
            if (visitsModel.RadSide4 == null)
            {
                infoVisitsListViewModel.RadSide4 = "";
            }
            else
            {
                infoVisitsListViewModel.RadSide4 = visitsModel.RadSide4.ToString();
            }

            if (visitsModel.RadDeg1 == null)
            {
                infoVisitsListViewModel.RadDeg1 = "";
            }
            else
            {
                infoVisitsListViewModel.RadDeg1 = visitsModel.RadDeg1.ToString();
            }
            if (visitsModel.RadDeg2 == null)
            {
                infoVisitsListViewModel.RadDeg2 = "";
            }
            else
            {
                infoVisitsListViewModel.RadDeg2 = visitsModel.RadDeg2.ToString();
            }
            if (visitsModel.RadDeg3 == null)
            {
                infoVisitsListViewModel.RadDeg3 = "";
            }
            else
            {
                infoVisitsListViewModel.RadDeg3 = visitsModel.RadDeg3.ToString();
            }
            if (visitsModel.RadDeg4 == null)
            {
                infoVisitsListViewModel.RadDeg4 = "";
            }
            else
            {
                infoVisitsListViewModel.RadDeg4 = visitsModel.RadDeg4.ToString();
            }

            if (visitsModel.RadFlexibility1 == null)
            {
                infoVisitsListViewModel.RadFlexibility1 = "";
            }
            else
            {
                infoVisitsListViewModel.RadFlexibility1 = visitsModel.RadFlexibility1.ToString();
            }
            if (visitsModel.RadFlexibility2 == null)
            {
                infoVisitsListViewModel.RadFlexibility2 = "";
            }
            else
            {
                infoVisitsListViewModel.RadFlexibility2 = visitsModel.RadFlexibility2.ToString();
            }
            if (visitsModel.RadFlexibility3 == null)
            {
                infoVisitsListViewModel.RadFlexibility3 = "";
            }
            else
            {
                infoVisitsListViewModel.RadFlexibility3 = visitsModel.RadFlexibility3.ToString();
            }
            if (visitsModel.RadFlexibility4 == null)
            {
                infoVisitsListViewModel.RadFlexibility4 = "";
            }
            else
            {
                infoVisitsListViewModel.RadFlexibility4 = visitsModel.RadFlexibility4.ToString();
            }

            return infoVisitsListViewModel;
        }




    }
}
