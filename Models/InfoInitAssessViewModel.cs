using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Scoliosis.Models
{
    public class InfoInitAssessViewModel
    {

        public string SCN { get; set; }

        public string iadate { get; set; }

        public string isReferralStudent { get; set; }

        public string isReferralOther { get; set; }

        public string ReferralOther { get; set; }

        public string isConcernNil { get; set; }

        public string isConcernOther { get; set; }

        public string ConcernOther { get; set; }

        public string isSymNil { get; set; }

        public string isSymBack { get; set; }

        public string SymBack { get; set; }

        public string isSymLimb { get; set; }

        public string SymLimb { get; set; }

        public string isSymCon { get; set; }

        public string SymCon { get; set; }

        public string isSymOther { get; set; }

        public string SymOther { get; set; }

        public string isPastGood { get; set; }

        public string isPastSpinal { get; set; }

        public string PastSpinal { get; set; }

        public string isPastBone { get; set; }

        public string PastBone { get; set; }

        public string isPastOther { get; set; }

        public string PastOther { get; set; }

        public string isMedicationNil { get; set; }

        public string isMedication { get; set; }

        public string Medication { get; set; }

        public string isPreOpNil { get; set; }

        public string isPreOp { get; set; }

        public string PreOp { get; set; }

        public string isAllergyNil { get; set; }

        public string isAllergy { get; set; }

        public string Allergy { get; set; }

        public string isGenNormal { get; set; }

        public string isGenLeg { get; set; }

        public string GenLeg { get; set; }

        public string isGenDys { get; set; }

        public string GenDys { get; set; }

        public string isGenSkin { get; set; }

        public string GenSkin { get; set; }

        public string isGenOther { get; set; }

        public string GenOther { get; set; }

        public string isBackInspectNormal { get; set; }

        public string isBackInspectAsy { get; set; }

        public string isBackInspectAsyR { get; set; }

        public string isBackInspectAsyL { get; set; }

        public string isBackInspectRib { get; set; }

        public string isBackInspectRibR { get; set; }

        public string isBackInspectRibL { get; set; }

        public string isBackInspectLumbar { get; set; }

        public string isBackInspectLumbarR { get; set; }

        public string isBackInspectLumbarL { get; set; }

        public string isBackPelvisTilt { get; set; }
        public string isBackPelvisTiltL { get; set; }
        public string isBackPelvisTiltR { get; set; }
        public string isBackInspectOther { get; set; }
        public string BackInspectOther { get; set; }

        public string isBackPalpationNormal { get; set; }
        public string isBackPalpationAbnormal { get; set; }
        public string BackPalpationAbnormal { get; set; }

        public string isBackRangeNormal { get; set; }
        public string isBackRangeDys { get; set; }

        public string BackRangeDys { get; set; }

        public string BackRangeSchober5 { get; set; }

        public string BackRangeSchober10 { get; set; }

        public string BackRangeSchober15 { get; set; }

        public string isBackRangeAbnormal { get; set; }

        public string BackRangeForward { get; set; }

        public string BackRangeSide { get; set; }
        public string isBackLegNormal { get; set; }

        public string isBackLegAbnormal { get; set; }

        public string BackLegAbnormal { get; set; }
        public string isBackLimbNormal { get; set; }

        public string isBackLimbAbnormal { get; set; }

        public string BackLimbAbnormal { get; set; }

        public string Remarks { get; set; }

        public string LastModify { get; set; }


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



        public static explicit operator InitAssessViewModel(InfoInitAssessViewModel infoInitAssessViewModel)
        {
            var initAssessViewModel = new InitAssessViewModel();



            initAssessViewModel.SCN = infoInitAssessViewModel.SCN;

            if (infoInitAssessViewModel.iadate == null) { 

                initAssessViewModel.iadate = DateTime.Now;
            }else {
                initAssessViewModel.iadate = DateTime.ParseExact(infoInitAssessViewModel.iadate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            }



            if (infoInitAssessViewModel.isReferralStudent == "true")
            {
                initAssessViewModel.isReferralStudent = true;
            }
            else
            {
                initAssessViewModel.isReferralStudent = false;
            }

            if (infoInitAssessViewModel.ReferralOther == null) {
                initAssessViewModel.ReferralOther = "";
            }
            else { 
                initAssessViewModel.ReferralOther = infoInitAssessViewModel.ReferralOther;
            }

            if (infoInitAssessViewModel.isConcernNil == "true")
            {
                initAssessViewModel.isConcernNil = true;
            }
            else
            {
                initAssessViewModel.isConcernNil = false;
            }

            if (infoInitAssessViewModel.isConcernOther == "true")
            {
                initAssessViewModel.isConcernOther = true;
            }
            else
            {
                initAssessViewModel.isConcernOther = false;
            }

            initAssessViewModel.ConcernOther = infoInitAssessViewModel.ConcernOther;


            if (infoInitAssessViewModel.isConcernOther == "true")
            {
                initAssessViewModel.isConcernOther = true;
            }
            else
            {
                initAssessViewModel.isConcernOther = false;
            }

            if (infoInitAssessViewModel.isSymNil == "true")
            {
                initAssessViewModel.isSymNil = true;
            }
            else
            {
                initAssessViewModel.isSymNil = false;
            }

            if (infoInitAssessViewModel.isSymBack == "true")
            {
                initAssessViewModel.isSymBack = true;
            }
            else
            {
                initAssessViewModel.isSymBack = false;
            }


            initAssessViewModel.SymBack = infoInitAssessViewModel.SymBack;


            if (infoInitAssessViewModel.isSymLimb == "true")
            {
                initAssessViewModel.isSymLimb = true;
            }
            else
            {
                initAssessViewModel.isSymLimb = false;
            }


            if (infoInitAssessViewModel.SymLimb == null)
            {
                initAssessViewModel.SymLimb = "";
            }
            else
            {

                initAssessViewModel.SymLimb = infoInitAssessViewModel.SymLimb;
            }


            if (infoInitAssessViewModel.isSymCon == "true")
            {
                initAssessViewModel.isSymCon = true;
            }
            else
            {
                initAssessViewModel.isSymCon = false;
            }

            initAssessViewModel.SymCon = infoInitAssessViewModel.SymCon;

            if (infoInitAssessViewModel.isSymOther == "true")
            {
                initAssessViewModel.isSymOther = true;
            }
            else
            {
                initAssessViewModel.isSymOther = false;
            }

            if (infoInitAssessViewModel.SymOther == null)
            {
                initAssessViewModel.SymOther = "";
            }
            else {

                initAssessViewModel.SymOther = infoInitAssessViewModel.SymOther;
            }


            if (infoInitAssessViewModel.isPastGood == "true")
            {
                initAssessViewModel.isPastGood = true;
            }
            else
            {
                initAssessViewModel.isPastGood = false;
            }

            if (infoInitAssessViewModel.isPastSpinal == "true")
            {
                initAssessViewModel.isPastSpinal = true;
            }
            else
            {
                initAssessViewModel.isPastSpinal = false;
            }

            initAssessViewModel.PastSpinal = infoInitAssessViewModel.PastSpinal;

            if (infoInitAssessViewModel.isPastBone == "true")
            {
                initAssessViewModel.isPastBone = true;
            }
            else
            {
                initAssessViewModel.isPastBone = false;
            }

            if (infoInitAssessViewModel.PastBone == null)
            {
                initAssessViewModel.PastBone = "";
            }
            else
            {

                initAssessViewModel.PastBone = infoInitAssessViewModel.PastBone;
            }

            if (infoInitAssessViewModel.isPastOther == "true")
            {
                initAssessViewModel.isPastOther = true;
            }
            else
            {
                initAssessViewModel.isPastOther = false;
            }

            if (infoInitAssessViewModel.PastOther == null)
            {
                initAssessViewModel.PastOther = "";
            }
            else
            {

                initAssessViewModel.PastOther = infoInitAssessViewModel.PastOther;
            }

            if (infoInitAssessViewModel.isMedicationNil == "true")
            {
                initAssessViewModel.isMedicationNil = true;
            }
            else
            {
                initAssessViewModel.isMedicationNil = false;
            }


            if (infoInitAssessViewModel.isMedication == "true")
            {
                initAssessViewModel.isMedication = true;
            }
            else
            {
                initAssessViewModel.isMedication = false;
            }


            if (infoInitAssessViewModel.Medication == null)
            {
                initAssessViewModel.Medication = "";
            }
            else
            {

                initAssessViewModel.Medication = infoInitAssessViewModel.Medication;
            }

            if (infoInitAssessViewModel.isPreOpNil == "true")
            {
                initAssessViewModel.isPreOpNil = true;
            }
            else
            {
                initAssessViewModel.isPreOpNil = false;
            }

            if (infoInitAssessViewModel.isPreOp == "true")
            {
                initAssessViewModel.isPreOp = true;
            }
            else
            {
                initAssessViewModel.isPreOp = false;
            }

            if (infoInitAssessViewModel.PreOp == null)
            {
                initAssessViewModel.PreOp = "";
            }
            else
            {

                initAssessViewModel.PreOp = infoInitAssessViewModel.PreOp;
            }


            if (infoInitAssessViewModel.isAllergyNil == "true")
            {
                initAssessViewModel.isAllergyNil = true;
            }
            else
            {
                initAssessViewModel.isAllergyNil = false;
            }

            if (infoInitAssessViewModel.isAllergy == "true")
            {
                initAssessViewModel.isAllergy = true;
            }
            else
            {
                initAssessViewModel.isAllergy = false;
            }


            if (infoInitAssessViewModel.Allergy == null)
            {
                initAssessViewModel.Allergy = "";
            }
            else
            {
                initAssessViewModel.Allergy = infoInitAssessViewModel.Allergy;
            }


            if (infoInitAssessViewModel.isGenNormal == "true")
            {
                initAssessViewModel.isGenNormal = true;
            }
            else
            {
                initAssessViewModel.isGenNormal = false;
            }


            if (infoInitAssessViewModel.isGenLeg == "true")
            {
                initAssessViewModel.isGenLeg = true;
            }
            else
            {
                initAssessViewModel.isGenLeg = false;
            }


            initAssessViewModel.GenLeg = infoInitAssessViewModel.GenLeg;

            if (infoInitAssessViewModel.isGenDys == "true")
            {
                initAssessViewModel.isGenDys = true;
            }
            else
            {
                initAssessViewModel.isGenDys = false;
            }

            if (infoInitAssessViewModel.GenDys == null)
            {
                initAssessViewModel.GenDys = "";
            }
            else
            {
                initAssessViewModel.GenDys = infoInitAssessViewModel.GenDys;
            }
            

            if (infoInitAssessViewModel.isGenSkin == "true")
            {
                initAssessViewModel.isGenSkin = true;
            }
            else
            {
                initAssessViewModel.isGenSkin = false;
            }


            if (infoInitAssessViewModel.GenSkin == null)
            {
                initAssessViewModel.GenSkin = "";
            }
            else
            {
                initAssessViewModel.GenSkin = infoInitAssessViewModel.GenSkin;
            }



            if (infoInitAssessViewModel.isGenOther == "true")
            {
                initAssessViewModel.isGenOther = true;
            }
            else
            {
                initAssessViewModel.isGenOther = false;
            }


            if (infoInitAssessViewModel.GenOther == null)
            {
                initAssessViewModel.GenOther = "";
            }
            else
            {
                initAssessViewModel.GenOther = infoInitAssessViewModel.GenOther;
            }

            if (infoInitAssessViewModel.isBackInspectNormal == "true")
            {
                initAssessViewModel.isBackInspectNormal = true;
            }
            else
            {
                initAssessViewModel.isBackInspectNormal = false;
            }


            if (infoInitAssessViewModel.isBackInspectAsy == "true")
            {
                initAssessViewModel.isBackInspectAsy = true;
            }
            else
            {
                initAssessViewModel.isBackInspectAsy = false;
            }

            if (infoInitAssessViewModel.isBackInspectAsyR == "true")
            {
                initAssessViewModel.isBackInspectAsyR = true;
            }
            else
            {
                initAssessViewModel.isBackInspectAsyR = false;
            }


            if (infoInitAssessViewModel.isBackInspectAsyL == "true")
            {
                initAssessViewModel.isBackInspectAsyL = true;
            }
            else
            {
                initAssessViewModel.isBackInspectAsyL = false;
            }

            if (infoInitAssessViewModel.isBackInspectRib == "true")
            {
                initAssessViewModel.isBackInspectRib = true;
            }
            else
            {
                initAssessViewModel.isBackInspectRib = false;
            }


            if (infoInitAssessViewModel.isBackInspectRibR == "true")
            {
                initAssessViewModel.isBackInspectRibR = true;
            }
            else
            {
                initAssessViewModel.isBackInspectRibR = false;
            }

            if (infoInitAssessViewModel.isBackInspectRibL == "true")
            {
                initAssessViewModel.isBackInspectRibL = true;
            }
            else
            {
                initAssessViewModel.isBackInspectRibL = false;
            }


            if (infoInitAssessViewModel.isBackInspectLumbar == "true")
            {
                initAssessViewModel.isBackInspectLumbar = true;
            }
            else
            {
                initAssessViewModel.isBackInspectLumbar = false;
            }

            if (infoInitAssessViewModel.isBackInspectLumbarR == "true")
            {
                initAssessViewModel.isBackInspectLumbarR = true;
            }
            else
            {
                initAssessViewModel.isBackInspectLumbarR = false;
            }

            if (infoInitAssessViewModel.isBackInspectLumbarL == "true")
            {
                initAssessViewModel.isBackInspectLumbarL = true;
            }
            else
            {
                initAssessViewModel.isBackInspectLumbarL = false;
            }

            if (infoInitAssessViewModel.isBackPelvisTilt == "true")
            {
                initAssessViewModel.isBackPelvisTilt = true;
            }
            else
            {
                initAssessViewModel.isBackPelvisTilt = false;
            }

            if (infoInitAssessViewModel.isBackPelvisTilt == "true")
            {
                initAssessViewModel.isBackPelvisTilt = true;
            }
            else
            {
                initAssessViewModel.isBackPelvisTilt = false;
            }

            if (infoInitAssessViewModel.isBackPelvisTiltL == "true")
            {
                initAssessViewModel.isBackPelvisTiltL = true;
            }
            else
            {
                initAssessViewModel.isBackPelvisTiltL = false;
            }

            if (infoInitAssessViewModel.isBackPelvisTiltR == "true")
            {
                initAssessViewModel.isBackPelvisTiltR = true;
            }
            else
            {
                initAssessViewModel.isBackPelvisTiltR = false;
            }

            if (infoInitAssessViewModel.isBackInspectOther == "true")
            {
                initAssessViewModel.isBackInspectOther = true;
            }
            else
            {
                initAssessViewModel.isBackInspectOther = false;
            }

            if (infoInitAssessViewModel.isBackInspectOther == "true")
            {
                initAssessViewModel.isBackInspectOther = true;
            }
            else
            {
                initAssessViewModel.isBackInspectOther = false;
            }


            if (infoInitAssessViewModel.BackInspectOther == null)
            {
                initAssessViewModel.BackInspectOther = "";
            }
            else
            {
                initAssessViewModel.BackInspectOther = infoInitAssessViewModel.BackInspectOther;
            }


            if (infoInitAssessViewModel.isBackPalpationNormal == "true")
            {
                initAssessViewModel.isBackPalpationNormal = true;
            }
            else
            {
                initAssessViewModel.isBackPalpationNormal = false;
            }

            if (infoInitAssessViewModel.isBackPalpationAbnormal == "true")
            {
                initAssessViewModel.isBackPalpationAbnormal = true;
            }
            else
            {
                initAssessViewModel.isBackPalpationAbnormal = false;
            }

            if (infoInitAssessViewModel.BackPalpationAbnormal == null)
            {
                initAssessViewModel.BackPalpationAbnormal = "";
            }
            else
            {
                initAssessViewModel.BackPalpationAbnormal = infoInitAssessViewModel.BackPalpationAbnormal;
            }

         
            if (infoInitAssessViewModel.isBackRangeNormal == "true")
            {
                initAssessViewModel.isBackRangeNormal = true;
            }
            else
            {
                initAssessViewModel.isBackRangeNormal = false;
            }

            if (infoInitAssessViewModel.isBackRangeDys == "true")
            {
                initAssessViewModel.isBackRangeDys = true;
            }
            else
            {
                initAssessViewModel.isBackRangeDys = false;
            }

            if (infoInitAssessViewModel.BackRangeDys == null)
            {
                initAssessViewModel.BackRangeDys = "";
            }
            else
            {
                initAssessViewModel.BackRangeDys = infoInitAssessViewModel.BackRangeDys;
            }
          

            if (infoInitAssessViewModel.BackRangeSchober5 == null)
            {
                initAssessViewModel.BackRangeSchober5 = 0;
            }
            else
            {

                if (Double.TryParse(infoInitAssessViewModel.BackRangeSchober5, out Double result) == false)
                {
                    throw new Exception("BackRangeSchober5 should be numeric, e.g. 0.00");
                }

                initAssessViewModel.BackRangeSchober5 = Double.Parse(infoInitAssessViewModel.BackRangeSchober5);
            }


            if (infoInitAssessViewModel.BackRangeSchober10 == null)
            {
                initAssessViewModel.BackRangeSchober10 = 0;
            }
            else
            {

                if (Double.TryParse(infoInitAssessViewModel.BackRangeSchober10, out Double result) == false)
                {
                    throw new Exception("BackRangeSchober10 should be numeric, e.g. 0.00");
                }

                initAssessViewModel.BackRangeSchober10 = Double.Parse(infoInitAssessViewModel.BackRangeSchober10);
            }


            if (infoInitAssessViewModel.BackRangeSchober10 == null)
            {
                initAssessViewModel.BackRangeSchober10 = 0;
            }
            else
            {

                if (Double.TryParse(infoInitAssessViewModel.BackRangeSchober15, out Double result) == false)
                {
                    throw new Exception("BackRangeSchober15 should be numeric, e.g. 0.00");
                }

                initAssessViewModel.BackRangeSchober15 = Double.Parse(infoInitAssessViewModel.BackRangeSchober15);
            }




            if (infoInitAssessViewModel.isBackRangeDys == "true")
            {
                initAssessViewModel.isBackRangeDys = true;
            }
            else
            {
                initAssessViewModel.isBackRangeDys = false;
            }


            if (infoInitAssessViewModel.isBackRangeAbnormal == "true")
            {
                initAssessViewModel.isBackRangeAbnormal = true;
            }
            else
            {
                initAssessViewModel.isBackRangeAbnormal = false;
            }


            if (infoInitAssessViewModel.BackRangeForward == null)
            {
                initAssessViewModel.BackRangeForward = "";
            }
            else
            {
                initAssessViewModel.BackRangeForward = infoInitAssessViewModel.BackRangeForward;
            }

            if (infoInitAssessViewModel.BackRangeSide == null)
            {
                initAssessViewModel.BackRangeSide = "";
            }
            else
            {
                initAssessViewModel.BackRangeSide = infoInitAssessViewModel.BackRangeSide;
            }



            if (infoInitAssessViewModel.isBackLegNormal == "true")
            {
                initAssessViewModel.isBackLegNormal = true;
            }
            else
            {
                initAssessViewModel.isBackLegNormal = false;
            }

            if (infoInitAssessViewModel.isBackLegAbnormal == "true")
            {
                initAssessViewModel.isBackLegAbnormal = true;
            }
            else
            {
                initAssessViewModel.isBackLegAbnormal = false;
            }

            initAssessViewModel.BackLegAbnormal = infoInitAssessViewModel.BackLegAbnormal;

            if (infoInitAssessViewModel.isBackLimbNormal == "true")
            {
                initAssessViewModel.isBackLimbNormal = true;
            }
            else
            {
                initAssessViewModel.isBackLimbNormal = false;
            }



            if (infoInitAssessViewModel.isBackLimbAbnormal == "true")
            {
                initAssessViewModel.isBackLimbAbnormal = true;
            }
            else
            {
                initAssessViewModel.isBackLimbAbnormal = false;
            }


            if (infoInitAssessViewModel.BackLimbAbnormal == null)
            {
                initAssessViewModel.BackLimbAbnormal = "";
            }
            else
            {
                initAssessViewModel.BackLimbAbnormal = infoInitAssessViewModel.BackLimbAbnormal;
            }

            if (infoInitAssessViewModel.Remarks == null)
            {
                initAssessViewModel.Remarks = "";
            }
            else
            {
                initAssessViewModel.Remarks = infoInitAssessViewModel.Remarks;
            }

            initAssessViewModel.LastModify = DateTime.Now;


            return initAssessViewModel;

        }
    }



}
