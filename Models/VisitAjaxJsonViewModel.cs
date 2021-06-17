using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Scoliosis.Models
{
    public class VisitAjaxJsonViewModel
    {
        public string SCN { get; set; }
        public string OriDOC { get; set; }
        public string OriVirtual { get; set; }
        public string DocHpylink { get; set; }
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
        public string isMenarcheNeg { get; set; }
        public string isMenarchePos { get; set; }
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
        public string ScannogramTotalR { get; set; }
        public string ScannogramTotalL { get; set; }
        public string ScannogramFemurR { get; set; }
        public string ScannogramFemurL { get; set; }
        public string ScannogramTibiaR { get; set; }
        public string ScannogramTibiaL { get; set; }
        public string withBrace { get; set; }
        public string CurveDir1 { get; set; }
        public string CurveLevel1From { get; set; }
        public string CurveLevel1To { get; set; }
        public string CurveApex1 { get; set; }
        public string CurveDeg1 { get; set; }
        public string AVTDir1 { get; set; }
        public string AVTDeg1 { get; set; }
        public string CurveDeg1Padding { get; set; }
        public string CurveDeg1Paddingcm { get; set; }
        public string CurveDir2 { get; set; }
        public string CurveLevel2From { get; set; }
        public string CurveLevel2To { get; set; }
        public string CurveApex2 { get; set; }
        public string CurveDeg2 { get; set; }
        public string AVTDir2 { get; set; }
        public string AVTDeg2 { get; set; }
        public string CurveDeg2Padding { get; set; }
        public string CurveDeg2Paddingcm { get; set; }
        public string CurveDir3 { get; set; }
        public string CurveLevel3From { get; set; }
        public string CurveLevel3To { get; set; }
        public string CurveApex3 { get; set; }
        public string CurveDeg3 { get; set; }
        public string AVTDir3 { get; set; }
        public string AVTDeg3 { get; set; }
        public string CurveDeg3Padding { get; set; }
        public string CurveDeg3Paddingcm { get; set; }
        public string CurveDir4 { get; set; }
        public string CurveLevel4From { get; set; }
        public string CurveLevel4To { get; set; }
        public string CurveApex4 { get; set; }
        public string CurveDeg4 { get; set; }
        public string AVTDir4 { get; set; }
        public string AVTDeg4 { get; set; }
        public string CurveDeg4Padding { get; set; }
        public string CurveDeg4Paddingcm { get; set; }
        public string withBraceS { get; set; }
        public string CurveDir1S { get; set; }
        public string CurveLevel1FromS { get; set; }
        public string CurveLevel1ToS { get; set; }
        public string CurveApex1S { get; set; }
        public string CurveDeg1S { get; set; }
        public string CurveDeg1Paddings { get; set; }
        public string CurveDeg1Paddingcms { get; set; }
        public string CurveDir2S { get; set; }
        public string CurveLevel2FromS { get; set; }
        public string CurveLevel2ToS { get; set; }
        public string CurveApex2S { get; set; }
        public string CurveDeg2S { get; set; }
        public string CurveDeg2Paddings { get; set; }
        public string CurveDeg2Paddingcms { get; set; }
        public string CurveDir3S { get; set; }
        public string CurveLevel3FromS { get; set; }
        public string CurveLevel3ToS { get; set; }
        public string CurveApex3S { get; set; }
        public string CurveDeg3S { get; set; }
        public string CurveDeg3Paddings { get; set; }
        public string CurveDeg3Paddingcms { get; set; }
        public string CurveDir4S { get; set; }
        public string CurveLevel4FromS { get; set; }

        public string CurveLevel4ToS { get; set; }

        public string CurveApex4S { get; set; }
        public string CurveDeg4S { get; set; }
        public string CurveDeg4Paddings { get; set; }
        public string CurveDeg4Paddingcms { get; set; }
        public string TrunkDir { get; set; }
        public string RTrunkShift { get; set; }
        public string ApicalDir1 { get; set; }
        public string ApicalRotation1 { get; set; }
        public string ApicalDir2 { get; set; }

        public string ApicalRotation2 { get; set; }
        public string ApicalDir3 { get; set; }
        public string ApicalRotation3 { get; set; }
        public string ApicalDir4 { get; set; }
        public string ApicalRotation4 { get; set; }
        public string RSign { get; set; }
        public string TOCI { get; set; }
        public string EpFusion { get; set; }
        public string tricart { get; set; }
        public string trochanter { get; set; }
        public string FemoralHead { get; set; }
        public string Thoracictype { get; set; }
        public string ThoKyphosis { get; set; }
        public string Lumbartype { get; set; }
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

        public string submit1 { get; set; }

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

        public static explicit operator VisitsModel(VisitAjaxJsonViewModel visitAjaxJsonViewModel)
        {
            var visitsModel = new VisitsModel();

            visitsModel.SCN = visitAjaxJsonViewModel.SCN;
            visitsModel.DOC = DateTime.ParseExact(visitAjaxJsonViewModel.DOC, "dd/MM/yyyy", CultureInfo.InvariantCulture);


            visitsModel.Virtual = visitAjaxJsonViewModel.Virtual;

            if (String.IsNullOrEmpty(visitAjaxJsonViewModel.HT))
            {
                visitsModel.HT = 0;
            }
            else
            {
                if (Double.TryParse(visitAjaxJsonViewModel.HT, out Double result) == false)
                {
                    throw new Exception("HT should be numeric, e.g. 0.00");
                }

                visitsModel.HT = Double.Parse(visitAjaxJsonViewModel.HT);
            }

            if (String.IsNullOrEmpty(visitAjaxJsonViewModel.ArmSpan))
            {
                visitsModel.ArmSpan = 0;
            }
            else
            {
                if (Double.TryParse(visitAjaxJsonViewModel.ArmSpan, out Double result) == false)
                {
                    throw new Exception("ArmSpan should be numeric, e.g. 0.00");
                }

                visitsModel.ArmSpan = Double.Parse(visitAjaxJsonViewModel.ArmSpan);
            }

            if (String.IsNullOrEmpty(visitAjaxJsonViewModel.LArmSpan))
            {
                visitsModel.LArmSpan = 0;
            }
            else
            {
                if (Double.TryParse(visitAjaxJsonViewModel.LArmSpan, out Double result) == false)
                {
                    throw new Exception("LArmSpan should be numeric, e.g. 0.00");
                }

                visitsModel.LArmSpan = Double.Parse(visitAjaxJsonViewModel.LArmSpan);
            }

            if (String.IsNullOrEmpty(visitAjaxJsonViewModel.RArmSpan))
            {
                visitsModel.RArmSpan = 0;
            }
            else
            {
                if (Double.TryParse(visitAjaxJsonViewModel.RArmSpan, out Double result) == false)
                {
                    throw new Exception("RArmSpan should be numeric, e.g. 0.00");
                }

                visitsModel.RArmSpan = Double.Parse(visitAjaxJsonViewModel.RArmSpan);
            }

            if (String.IsNullOrEmpty(visitAjaxJsonViewModel.SHT))
            {
                visitsModel.SHT = 0;
            }
            else
            {

                if (Double.TryParse(visitAjaxJsonViewModel.SHT, out Double result) == false)
                {
                    throw new Exception("SHT should be numeric, e.g. 0.00");
                }

                visitsModel.SHT = Double.Parse(visitAjaxJsonViewModel.SHT);
            }

            if (String.IsNullOrEmpty(visitAjaxJsonViewModel.WT))
            {
                visitsModel.WT = 0;
            }
            else
            {
                if (Double.TryParse(visitAjaxJsonViewModel.WT, out Double result) == false)
                {
                    throw new Exception("WT should be numeric, e.g. 0.00");
                }

                visitsModel.WT = Double.Parse(visitAjaxJsonViewModel.WT);
            }


            //visitsModel.SHT = infoVisitModel.SHT;
            //visitsModel.WT = infoVisitModel.WT;

            if (visitAjaxJsonViewModel.isMenarchePos == "true")
            {
                visitsModel.isMenarchePos = true;
            }
            else
            {
                visitsModel.isMenarchePos = false;
            }

            if (visitAjaxJsonViewModel.isMenarcheNeg == "true")
            {
                visitsModel.isMenarcheNeg = true;
            }
            else
            {
                visitsModel.isMenarcheNeg = false;
            }


            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.MaturYear)){
                visitsModel.MaturYear = Int32.Parse(visitAjaxJsonViewModel.MaturYear);
            }

            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.MaturYear))
            {
                visitsModel.MaturYear = Int32.Parse(visitAjaxJsonViewModel.MaturMonth);
            }

            visitsModel.Jointhyper = visitAjaxJsonViewModel.Jointhyper;


            if (String.IsNullOrEmpty(visitAjaxJsonViewModel.AbdReflexA) || visitAjaxJsonViewModel.AbdReflexA.ToString() == "\0" || visitAjaxJsonViewModel.AbdReflexA == "")
            {
                visitsModel.AbdReflexA = null;
            }
            else
            {
                visitsModel.AbdReflexA = (visitAjaxJsonViewModel.AbdReflexA.ToCharArray())[0];
            }


            if (String.IsNullOrEmpty(visitAjaxJsonViewModel.AbdReflexB) || visitAjaxJsonViewModel.AbdReflexB.ToString() == "\0" || visitAjaxJsonViewModel.AbdReflexB == "")
            {
                visitsModel.AbdReflexB = null;
            }
            else
            {
                visitsModel.AbdReflexB = (visitAjaxJsonViewModel.AbdReflexB.ToCharArray())[0];
            }

            if (String.IsNullOrEmpty(visitAjaxJsonViewModel.AbdReflexC) || visitAjaxJsonViewModel.AbdReflexC.ToString() == "\0" || visitAjaxJsonViewModel.AbdReflexC == "")
            {
                visitsModel.AbdReflexC = null;
            }
            else
            {
                visitsModel.AbdReflexC = (visitAjaxJsonViewModel.AbdReflexC.ToCharArray())[0];
            }

            if (String.IsNullOrEmpty(visitAjaxJsonViewModel.AbdReflexD) || visitAjaxJsonViewModel.AbdReflexD.ToString() == "\0" || visitAjaxJsonViewModel.AbdReflexD == "")
            {
                visitsModel.AbdReflexD = null;
            }
            else
            {
                visitsModel.AbdReflexD = (visitAjaxJsonViewModel.AbdReflexD.ToCharArray())[0];
            }

            if (String.IsNullOrEmpty(visitAjaxJsonViewModel.ShoulderDir) || visitAjaxJsonViewModel.ShoulderDir.ToString() == "\0")
            {
                visitsModel.ShoulderDir = null;
            }
            else
            {
                visitsModel.ShoulderDir = visitAjaxJsonViewModel.ShoulderDir;
            }

            if (visitAjaxJsonViewModel.CTrunkShiftDir == null || visitAjaxJsonViewModel.CTrunkShiftDir.ToString() == "\0" || visitAjaxJsonViewModel.CTrunkShiftDir == "") 
            {
                visitsModel.CTrunkShiftDir = null;
            }
            else
            {
                visitsModel.CTrunkShiftDir = visitAjaxJsonViewModel.CTrunkShiftDir.ToCharArray()[0];
            }

            if (String.IsNullOrEmpty(visitAjaxJsonViewModel.BreastTanner) || visitAjaxJsonViewModel.BreastTanner.ToString() == "\0")
            {
                visitsModel.BreastTanner = null;
            }
            else
            {
                visitsModel.BreastTanner = visitAjaxJsonViewModel.BreastTanner;
            }

            if (String.IsNullOrEmpty(visitAjaxJsonViewModel.PubicTanner) || visitAjaxJsonViewModel.PubicTanner.ToString() == "\0")
            {
                visitsModel.PubicTanner = null;
            }
            else
            {
                visitsModel.PubicTanner = visitAjaxJsonViewModel.PubicTanner;
            }

            if (String.IsNullOrEmpty(visitAjaxJsonViewModel.hair) || visitAjaxJsonViewModel.hair.ToString() == "\0")
            {
                visitsModel.hair = null;
            }
            else
            {
                visitsModel.hair = visitAjaxJsonViewModel.hair;
            }

            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.CTrunkShift)) {

                visitsModel.CTrunkShift = double.Parse(visitAjaxJsonViewModel.CTrunkShift);
            }


            //sql orginal checking CK_Visits_RDIR_CHECK

            if (string.IsNullOrEmpty(visitAjaxJsonViewModel.R1Dir)) {
                visitsModel.R1Dir = null;
            }
            else
            {
                visitsModel.R1Dir = visitAjaxJsonViewModel.R1Dir;
            }
          

            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.Rotat1))
            {

                visitsModel.Rotat1 = double.Parse(visitAjaxJsonViewModel.Rotat1);
            }


            if (string.IsNullOrEmpty(visitAjaxJsonViewModel.R2Dir))
            {
                visitsModel.R2Dir = null;
            }
            else
            {
                visitsModel.R2Dir = visitAjaxJsonViewModel.R2Dir;
            }


            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.Rotat2))
            {

                visitsModel.Rotat2 = double.Parse(visitAjaxJsonViewModel.Rotat2);
            }

            if (string.IsNullOrEmpty(visitAjaxJsonViewModel.R3Dir))
            {
                visitsModel.R3Dir = null;
            }
            else
            {
                visitsModel.R3Dir = visitAjaxJsonViewModel.R3Dir;
            }

            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.Rotat3))
            {

                visitsModel.Rotat3 = double.Parse(visitAjaxJsonViewModel.Rotat3);
            }

            if (string.IsNullOrEmpty(visitAjaxJsonViewModel.R4Dir))
            {
                visitsModel.R4Dir = null;
            }
            else
            {
                visitsModel.R4Dir = visitAjaxJsonViewModel.R4Dir;
            }

            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.Rotat4))
            {

                visitsModel.Rotat4 = double.Parse(visitAjaxJsonViewModel.Rotat4);
            }

            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.ShoulderAsy))
            {

                visitsModel.ShoulderAsy = double.Parse(visitAjaxJsonViewModel.ShoulderAsy);
            }

            visitsModel.tricart = visitAjaxJsonViewModel.tricart;
            visitsModel.trochanter = visitAjaxJsonViewModel.trochanter;
            visitsModel.FemoralHead = visitAjaxJsonViewModel.FemoralHead;


            visitsModel.withBrace = short.Parse(visitAjaxJsonViewModel.withBrace);


            visitsModel.CurveLevel1From = visitAjaxJsonViewModel.CurveLevel1From;
            visitsModel.CurveLevel1To = visitAjaxJsonViewModel.CurveLevel1To;
            visitsModel.CurveLevel2From = visitAjaxJsonViewModel.CurveLevel2From;
            visitsModel.CurveLevel2To = visitAjaxJsonViewModel.CurveLevel2To;
            visitsModel.CurveLevel3From = visitAjaxJsonViewModel.CurveLevel3From;
            visitsModel.CurveLevel3To = visitAjaxJsonViewModel.CurveLevel3To;
            visitsModel.CurveLevel4From = visitAjaxJsonViewModel.CurveLevel4From;
            visitsModel.CurveLevel4To = visitAjaxJsonViewModel.CurveLevel4To;
            visitsModel.CurveApex1 = visitAjaxJsonViewModel.CurveApex1;
            visitsModel.CurveApex2 = visitAjaxJsonViewModel.CurveApex2;
            visitsModel.CurveApex3 = visitAjaxJsonViewModel.CurveApex3;
            visitsModel.CurveApex4 = visitAjaxJsonViewModel.CurveApex4;

            if (String.IsNullOrEmpty(visitAjaxJsonViewModel.AVTDir1) || visitAjaxJsonViewModel.AVTDir1.ToString() == "\0" || visitAjaxJsonViewModel.AVTDir1 == "") 
            {
                visitsModel.AVTDir1 = null;
            }
            else
            {
                visitsModel.AVTDir1 = (visitAjaxJsonViewModel.AVTDir1.ToCharArray())[0];
            }

            if (String.IsNullOrEmpty(visitAjaxJsonViewModel.AVTDir2) || visitAjaxJsonViewModel.AVTDir2.ToString() == "\0" || visitAjaxJsonViewModel.AVTDir2 == "") 
            {
                visitsModel.AVTDir2 = null;
            }
            else
            {
                visitsModel.AVTDir2 = (visitAjaxJsonViewModel.AVTDir2.ToCharArray())[0];
            }

            if (String.IsNullOrEmpty(visitAjaxJsonViewModel.AVTDir3) || visitAjaxJsonViewModel.AVTDir3.ToString() == "\0" || visitAjaxJsonViewModel.AVTDir3 == "") 
            {
                visitsModel.AVTDir3 = null;
            }
            else
            {
                visitsModel.AVTDir3 = (visitAjaxJsonViewModel.AVTDir3.ToCharArray())[0];
            }

            if (String.IsNullOrEmpty(visitAjaxJsonViewModel.AVTDir4) || visitAjaxJsonViewModel.AVTDir4.ToString() == "\0" || visitAjaxJsonViewModel.AVTDir4 == "") 
            {
                visitsModel.AVTDir4 = null;
            }
            else
            {
                visitsModel.AVTDir4 = (visitAjaxJsonViewModel.AVTDir4.ToCharArray())[0];
            }

            if (String.IsNullOrEmpty(visitAjaxJsonViewModel.AVTDeg1) || visitAjaxJsonViewModel.AVTDeg1.ToString() == "\0" || visitAjaxJsonViewModel.AVTDeg1 == "")
            {
                visitsModel.AVTDeg1 = null;
            }
            else
            {
                visitsModel.AVTDeg1 = (visitAjaxJsonViewModel.AVTDeg1.ToCharArray())[0];
            }

            if (String.IsNullOrEmpty(visitAjaxJsonViewModel.AVTDeg2) || visitAjaxJsonViewModel.AVTDeg2.ToString() == "\0" || visitAjaxJsonViewModel.AVTDeg2 == "")
            {
                visitsModel.AVTDeg2 = null;
            }
            else
            {
                visitsModel.AVTDeg2 = (visitAjaxJsonViewModel.AVTDeg2.ToCharArray())[0];
            }

            if (String.IsNullOrEmpty(visitAjaxJsonViewModel.AVTDeg3) || visitAjaxJsonViewModel.AVTDeg3.ToString() == "\0" || visitAjaxJsonViewModel.AVTDeg3 == "")
            {
                visitsModel.AVTDeg3 = null;
            }
            else
            {
                visitsModel.AVTDeg3 = (visitAjaxJsonViewModel.AVTDeg3.ToCharArray())[0];
            }

            if (String.IsNullOrEmpty(visitAjaxJsonViewModel.AVTDeg4) || visitAjaxJsonViewModel.AVTDeg4.ToString() == "\0" || visitAjaxJsonViewModel.AVTDeg4 == "")
            {
                visitsModel.AVTDeg4 = null;
            }
            else
            {
                visitsModel.AVTDeg4 = (visitAjaxJsonViewModel.AVTDeg4.ToCharArray())[0];
            }


            visitsModel.CurveDir1 = visitAjaxJsonViewModel.CurveDir1;
            visitsModel.CurveDir2 = visitAjaxJsonViewModel.CurveDir2;
            visitsModel.CurveDir3 = visitAjaxJsonViewModel.CurveDir3;
            visitsModel.CurveDir4 = visitAjaxJsonViewModel.CurveDir4;
            visitsModel.ApicalDir1 = visitAjaxJsonViewModel.ApicalDir1;
            visitsModel.ApicalDir2 = visitAjaxJsonViewModel.ApicalDir2;
            visitsModel.ApicalDir3 = visitAjaxJsonViewModel.ApicalDir3;
            visitsModel.ApicalDir4 = visitAjaxJsonViewModel.ApicalDir4;

            visitsModel.withBraceS = short.Parse(visitAjaxJsonViewModel.withBraceS);

            visitsModel.CurveLevel1FromS = visitAjaxJsonViewModel.CurveLevel1FromS;
            visitsModel.CurveLevel1ToS = visitAjaxJsonViewModel.CurveLevel1ToS;
            visitsModel.CurveLevel2FromS = visitAjaxJsonViewModel.CurveLevel2FromS;
            visitsModel.CurveLevel2ToS = visitAjaxJsonViewModel.CurveLevel2ToS;
            visitsModel.CurveLevel3FromS = visitAjaxJsonViewModel.CurveLevel3FromS;
            visitsModel.CurveLevel3ToS = visitAjaxJsonViewModel.CurveLevel3ToS;
            visitsModel.CurveLevel4FromS = visitAjaxJsonViewModel.CurveLevel4FromS;
            visitsModel.CurveLevel4ToS = visitAjaxJsonViewModel.CurveLevel4ToS;
            visitsModel.CurveDir1S = visitAjaxJsonViewModel.CurveDir1S;
            visitsModel.CurveDir2S = visitAjaxJsonViewModel.CurveDir2S;
            visitsModel.CurveDir3S = visitAjaxJsonViewModel.CurveDir3S;
            visitsModel.CurveDir4S = visitAjaxJsonViewModel.CurveDir4S;
            visitsModel.CurveApex1S = visitAjaxJsonViewModel.CurveApex1S;
            visitsModel.CurveApex2S = visitAjaxJsonViewModel.CurveApex2S;
            visitsModel.CurveApex3S = visitAjaxJsonViewModel.CurveApex3S;
            visitsModel.CurveApex4S = visitAjaxJsonViewModel.CurveApex4S;

            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.CurveDeg1S))
            {

                visitsModel.CurveDeg1S = double.Parse(visitAjaxJsonViewModel.CurveDeg1S);
            }

            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.CurveDeg2S))
            {

                visitsModel.CurveDeg2S = double.Parse(visitAjaxJsonViewModel.CurveDeg2S);
            }

            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.CurveDeg3S))
            {

                visitsModel.CurveDeg3S = double.Parse(visitAjaxJsonViewModel.CurveDeg3S);
            }

            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.CurveDeg4S))
            {

                visitsModel.CurveDeg4S = double.Parse(visitAjaxJsonViewModel.CurveDeg4S);
            }



            if (string.IsNullOrEmpty(visitAjaxJsonViewModel.Lumbartype) || visitAjaxJsonViewModel.Lumbartype.ToString() == "\0")
            {
                visitsModel.Thoracictype = null;
            }
            else
            {
                visitsModel.Thoracictype = (visitAjaxJsonViewModel.Thoracictype.ToCharArray())[0];;
            }


            if (string.IsNullOrEmpty(visitAjaxJsonViewModel.Lumbartype) || visitAjaxJsonViewModel.Lumbartype.ToString() == "\0")
            {
                visitsModel.Lumbartype = null;
            }
            else
            {
                visitsModel.Lumbartype = (visitAjaxJsonViewModel.Lumbartype.ToCharArray())[0];
            }


            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.CurveDeg1))
            {

                visitsModel.CurveDeg1 = double.Parse(visitAjaxJsonViewModel.CurveDeg1);
            }

            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.CurveDeg2))
            {

                visitsModel.CurveDeg2 = double.Parse(visitAjaxJsonViewModel.CurveDeg2);
            }

            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.CurveDeg3))
            {

                visitsModel.CurveDeg3 = double.Parse(visitAjaxJsonViewModel.CurveDeg3);
            }

            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.CurveDeg4))
            {

                visitsModel.CurveDeg4 = double.Parse(visitAjaxJsonViewModel.CurveDeg4);
            }


            if (String.IsNullOrEmpty(visitAjaxJsonViewModel.TrunkDir) || visitAjaxJsonViewModel.TrunkDir == "")
            {
                visitsModel.TrunkDir = null;
            }
            else
            {
                var trunkDirChar = visitAjaxJsonViewModel.TrunkDir.ToCharArray();
                visitsModel.TrunkDir = trunkDirChar[0];
            }


            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.RTrunkShift))
            {

                visitsModel.RTrunkShift = double.Parse(visitAjaxJsonViewModel.RTrunkShift);
            }

            visitsModel.ApicalRotation1 = visitAjaxJsonViewModel.ApicalRotation1;
            visitsModel.ApicalRotation2 = visitAjaxJsonViewModel.ApicalRotation2;
            visitsModel.ApicalRotation3 = visitAjaxJsonViewModel.ApicalRotation3;
            visitsModel.ApicalRotation4 = visitAjaxJsonViewModel.ApicalRotation4;
            visitsModel.RSign = visitAjaxJsonViewModel.RSign;
            visitsModel.EpFusion = visitAjaxJsonViewModel.EpFusion;


            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.ThoKyphosis))
            {

                visitsModel.ThoKyphosis = double.Parse(visitAjaxJsonViewModel.ThoKyphosis);
            }

            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.LumLordosis))
            {

                visitsModel.LumLordosis = double.Parse(visitAjaxJsonViewModel.LumLordosis);
            }


            visitsModel.PlanObs = visitAjaxJsonViewModel.PlanObs;
            visitsModel.PlanBrace = visitAjaxJsonViewModel.PlanBrace;

            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.PlanBraceWeanTime))
            {

                visitsModel.PlanBraceWeanTime = Int32.Parse(visitAjaxJsonViewModel.PlanBraceWeanTime);
            }

            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.PlanFUYear))
            {

                visitsModel.PlanFUYear = double.Parse(visitAjaxJsonViewModel.PlanFUYear);
            }

            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.PlanFUMonth))
            {

                visitsModel.PlanFUMonth = double.Parse(visitAjaxJsonViewModel.PlanFUMonth);
            }

            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.PlanFUWeek))
            {

                visitsModel.PlanFUWeek = double.Parse(visitAjaxJsonViewModel.PlanFUWeek);
            }


            if (visitAjaxJsonViewModel.AfterBracing == "true")
            {
                visitsModel.AfterBracing = true;
            }
            else
            {
                visitsModel.AfterBracing = false;
            }

            if (visitAjaxJsonViewModel.PRN == "true")
            {
                visitsModel.PRN = true;
            }
            else
            {
                visitsModel.PRN = false;
            }

            visitsModel.PlanXray = visitAjaxJsonViewModel.PlanXray;
            visitsModel.PlanSurgery = visitAjaxJsonViewModel.PlanSurgery;
            visitsModel.DrName = visitAjaxJsonViewModel.DrName;
            visitsModel.SpcRemarks = visitAjaxJsonViewModel.SpcRemarks;

            visitsModel.LastModify = DateTime.Now;

            //20200517 Add field

            visitsModel.TOCI = visitAjaxJsonViewModel.TOCI;
            visitsModel.CurveDeg1Padding = visitAjaxJsonViewModel.CurveDeg1Padding;
            visitsModel.CurveDeg2Padding = visitAjaxJsonViewModel.CurveDeg2Padding;
            visitsModel.CurveDeg3Padding = visitAjaxJsonViewModel.CurveDeg3Padding;
            visitsModel.CurveDeg4Padding = visitAjaxJsonViewModel.CurveDeg4Padding;
            visitsModel.CurveDeg1Paddingcm = visitAjaxJsonViewModel.CurveDeg1Paddingcm;
            visitsModel.CurveDeg2Paddingcm = visitAjaxJsonViewModel.CurveDeg2Paddingcm;
            visitsModel.CurveDeg3Paddingcm = visitAjaxJsonViewModel.CurveDeg3Paddingcm;
            visitsModel.CurveDeg4Paddingcm = visitAjaxJsonViewModel.CurveDeg4Paddingcm;

            visitsModel.CurveDeg1Paddings = visitAjaxJsonViewModel.CurveDeg1Paddings;
            visitsModel.CurveDeg2Paddings = visitAjaxJsonViewModel.CurveDeg2Paddings;
            visitsModel.CurveDeg3Paddings = visitAjaxJsonViewModel.CurveDeg3Paddings;
            visitsModel.CurveDeg4Paddings = visitAjaxJsonViewModel.CurveDeg4Paddings;
            visitsModel.CurveDeg1Paddingcms = visitAjaxJsonViewModel.CurveDeg1Paddingcms;
            visitsModel.CurveDeg2Paddingcms = visitAjaxJsonViewModel.CurveDeg2Paddingcms;
            visitsModel.CurveDeg3Paddingcms = visitAjaxJsonViewModel.CurveDeg3Paddingcms;
            visitsModel.CurveDeg4Paddingcms = visitAjaxJsonViewModel.CurveDeg4Paddingcms;


            visitsModel.ScannogramTotalR = visitAjaxJsonViewModel.ScannogramTotalR;
            visitsModel.ScannogramTotalL = visitAjaxJsonViewModel.ScannogramTotalL;
            visitsModel.ScannogramFemurR = visitAjaxJsonViewModel.ScannogramFemurR;
            visitsModel.ScannogramFemurL = visitAjaxJsonViewModel.ScannogramFemurL;
            visitsModel.ScannogramTibiaR = visitAjaxJsonViewModel.ScannogramTibiaR;
            visitsModel.ScannogramTibiaL = visitAjaxJsonViewModel.ScannogramTibiaL;

            //By Eddie Change according to the meeing at 3/7, 10/7 and 31/7
            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.QoL))
            {

                visitsModel.QoL = double.Parse(visitAjaxJsonViewModel.QoL);
            }
            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.RadSide1))
            {
                visitsModel.RadSide1 = visitAjaxJsonViewModel.RadSide1;
            }
            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.RadSide2))
            {
                visitsModel.RadSide2 = visitAjaxJsonViewModel.RadSide2;
            }
            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.RadSide3))
            {
                visitsModel.RadSide3 = visitAjaxJsonViewModel.RadSide3;
            }
            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.RadSide4))
            {
                visitsModel.RadSide4 = visitAjaxJsonViewModel.RadSide4;
            }
            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.RadDeg1))
            {

                visitsModel.RadDeg1 = double.Parse(visitAjaxJsonViewModel.RadDeg1);
            }
            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.RadDeg2))
            {

                visitsModel.RadDeg2 = double.Parse(visitAjaxJsonViewModel.RadDeg2);
            }
            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.RadDeg3))
            {

                visitsModel.RadDeg3 = double.Parse(visitAjaxJsonViewModel.RadDeg3);
            }
            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.RadDeg4))
            {

                visitsModel.RadDeg4 = double.Parse(visitAjaxJsonViewModel.RadDeg4);
            }

            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.RadFlexibility1))
            {

                visitsModel.RadFlexibility1 = double.Parse(visitAjaxJsonViewModel.RadFlexibility1);
            }
            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.RadFlexibility2))
            {

                visitsModel.RadFlexibility2 = double.Parse(visitAjaxJsonViewModel.RadFlexibility2);
            }
            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.RadFlexibility3))
            {

                visitsModel.RadFlexibility3 = double.Parse(visitAjaxJsonViewModel.RadFlexibility3);
            }
            if (!string.IsNullOrEmpty(visitAjaxJsonViewModel.RadFlexibility4))
            {

                visitsModel.RadFlexibility4 = double.Parse(visitAjaxJsonViewModel.RadFlexibility4);
            }

            return visitsModel;

        }


    }
}
