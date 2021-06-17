using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Scoliosis.Models
{
    public class InitAssessViewModel
    {
        [Required]
        [Key]
        public string SCN { get; set; }

        public Nullable<DateTime> iadate { get; set; }

        public Nullable<bool> isReferralStudent { get; set; }

        public Nullable<bool> isReferralOther { get; set; }

        public string ReferralOther { get; set; }

        public Nullable<bool> isConcernNil { get; set; }

        public Nullable<bool> isConcernOther { get; set; }

        public string ConcernOther { get; set; }

        public Nullable<bool> isSymNil { get; set; }

        public Nullable<bool> isSymBack { get; set; }

        public string SymBack { get; set; }

        public Nullable<bool> isSymLimb { get; set; }

        public string SymLimb { get; set; }

        public Nullable<bool> isSymCon { get; set; }

        public string SymCon { get; set; }

        public Nullable<bool> isSymOther { get; set; }

        public string SymOther { get; set; }

        public Nullable<bool> isPastGood { get; set; }

        public Nullable<bool> isPastSpinal { get; set; }

        public string PastSpinal { get; set; }

        public Nullable<bool> isPastBone { get; set; }

        public string PastBone { get; set; }

        public Nullable<bool> isPastOther { get; set; }

        public string PastOther { get; set; }

        public Nullable<bool> isMedicationNil { get; set; }

        public Nullable<bool> isMedication { get; set; }

        public string Medication { get; set; }

        public Nullable<bool> isPreOpNil { get; set; }

        public Nullable<bool> isPreOp { get; set; }

        public string PreOp { get; set; }

        public Nullable<bool> isAllergyNil { get; set; }

        public Nullable<bool> isAllergy { get; set; }

        public string Allergy { get; set; }

        public Nullable<bool> isGenNormal { get; set; }

        public Nullable<bool> isGenLeg { get; set; }

        public string GenLeg { get; set; }

        public Nullable<bool> isGenDys { get; set; }

        public string GenDys { get; set; }

        public Nullable<bool> isGenSkin { get; set; }

        public string GenSkin { get; set; }

        public Nullable<bool> isGenOther { get; set; }

        public string GenOther { get; set; }

        public Nullable<bool> isBackInspectNormal { get; set; }

        public Nullable<bool> isBackInspectAsy { get; set; }

        public Nullable<bool> isBackInspectAsyR { get; set; }

        public Nullable<bool> isBackInspectAsyL { get; set; }

        public Nullable<bool> isBackInspectRib { get; set; }

        public Nullable<bool> isBackInspectRibR { get; set; }

        public Nullable<bool> isBackInspectRibL { get; set; }

        public Nullable<bool> isBackInspectLumbar { get; set; }

        public Nullable<bool> isBackInspectLumbarR { get; set; }

        public Nullable<bool> isBackInspectLumbarL { get; set; }

        public Nullable<bool> isBackPelvisTilt { get; set; }
        public Nullable<bool> isBackPelvisTiltL { get; set; }
        public Nullable<bool> isBackPelvisTiltR { get; set; }
        public Nullable<bool> isBackInspectOther { get; set; }
        public string BackInspectOther { get; set; }

        public Nullable<bool> isBackPalpationNormal { get; set; }
        public Nullable<bool> isBackPalpationAbnormal { get; set; }
        public string BackPalpationAbnormal { get; set; }

        public Nullable<bool> isBackRangeNormal { get; set; }
        public Nullable<bool> isBackRangeDys { get; set; }

        public string BackRangeDys { get; set; }

        public Nullable<double> BackRangeSchober5 { get; set; }

        public Nullable<double> BackRangeSchober10 { get; set; }

        public Nullable<double> BackRangeSchober15 { get; set; }

        public Nullable<bool> isBackRangeAbnormal { get; set; }

        public string BackRangeForward { get; set; }

        public string BackRangeSide { get; set; }
        public Nullable<bool> isBackLegNormal { get; set; }

        public Nullable<bool> isBackLegAbnormal { get; set; }

        public string BackLegAbnormal { get; set; }
        public Nullable<bool> isBackLimbNormal { get; set; }

        public Nullable<bool> isBackLimbAbnormal { get; set; }

        public string BackLimbAbnormal { get; set; }

        public string Remarks { get; set; }

        public Nullable<DateTime> LastModify { get; set; }


        public static explicit operator InfoInitAssessViewModel(InitAssessViewModel InitAssessViewModel)
        {

            var infoInitAssessViewModel = new InfoInitAssessViewModel();

            infoInitAssessViewModel.SCN = InitAssessViewModel.SCN;

            if (InitAssessViewModel.iadate == null)
            {
                infoInitAssessViewModel.iadate = "";
            }
            else
            {
                infoInitAssessViewModel.iadate = InitAssessViewModel.iadate.Value.ToString("dd/MM/yyyy");
            }

            if (InitAssessViewModel.isReferralStudent == true)
            {
                infoInitAssessViewModel.isReferralStudent = "true";
            }
            else
            {
                infoInitAssessViewModel.isReferralStudent = "false";
            }


            if (InitAssessViewModel.isReferralOther == true)
            {
                infoInitAssessViewModel.isReferralOther = "true";
            }
            else
            {
                infoInitAssessViewModel.isReferralOther = "false";
            }

            if (InitAssessViewModel.ReferralOther == null)
            {
                infoInitAssessViewModel.ReferralOther = "";
            }
            else
            {
                infoInitAssessViewModel.ReferralOther = InitAssessViewModel.ReferralOther;
            }

            if (InitAssessViewModel.isConcernNil == true)
            {
                infoInitAssessViewModel.isConcernNil = "true";
            }
            else
            {
                infoInitAssessViewModel.isConcernNil = "false";
            }

            if (InitAssessViewModel.isConcernOther == true)
            {
                infoInitAssessViewModel.isConcernOther = "true";
            }
            else
            {
                infoInitAssessViewModel.isConcernOther = "false";
            }

            if (InitAssessViewModel.ConcernOther == null)
            {
                infoInitAssessViewModel.ConcernOther = "";
            }
            else
            {
                infoInitAssessViewModel.ConcernOther = InitAssessViewModel.ConcernOther;
            }

            if (InitAssessViewModel.isSymNil == true)
            {
                infoInitAssessViewModel.isSymNil = "true";
            }
            else
            {
                infoInitAssessViewModel.isSymNil = "false";
            }


            if (InitAssessViewModel.isSymBack == true)
            {
                infoInitAssessViewModel.isSymBack = "true";
            }
            else
            {
                infoInitAssessViewModel.isSymBack = "false";
            }


            if (InitAssessViewModel.SymBack == null)
            {
                infoInitAssessViewModel.SymBack = "";
            }
            else
            {
                infoInitAssessViewModel.SymBack = InitAssessViewModel.SymBack;
            }

            if (InitAssessViewModel.isSymLimb == true)
            {
                infoInitAssessViewModel.isSymLimb = "true";
            }
            else
            {
                infoInitAssessViewModel.isSymLimb = "false";
            }

            if (InitAssessViewModel.SymLimb == null)
            {
                infoInitAssessViewModel.SymLimb = "";
            }
            else
            {
                infoInitAssessViewModel.SymLimb = InitAssessViewModel.SymLimb;
            }

            if (InitAssessViewModel.isSymCon == true)
            {
                infoInitAssessViewModel.isSymCon = "true";
            }
            else
            {
                infoInitAssessViewModel.isSymCon = "false";
            }

            if (InitAssessViewModel.SymCon == null)
            {
                infoInitAssessViewModel.SymCon = "";
            }
            else
            {
                infoInitAssessViewModel.SymCon = InitAssessViewModel.SymCon;
            }

            if (InitAssessViewModel.isSymOther == true)
            {
                infoInitAssessViewModel.isSymOther = "true";
            }
            else
            {
                infoInitAssessViewModel.isSymOther = "false";
            }

            if (InitAssessViewModel.SymOther == null)
            {
                infoInitAssessViewModel.SymOther = "";
            }
            else
            {
                infoInitAssessViewModel.SymOther = InitAssessViewModel.SymOther;
            }

            if (InitAssessViewModel.isPastGood == true)
            {
                infoInitAssessViewModel.isPastGood = "true";
            }
            else
            {
                infoInitAssessViewModel.isPastGood = "false";
            }

            if (InitAssessViewModel.isPastSpinal == true)
            {
                infoInitAssessViewModel.isPastSpinal = "true";
            }
            else
            {
                infoInitAssessViewModel.isPastSpinal = "false";
            }

            if (InitAssessViewModel.PastSpinal == null)
            {
                infoInitAssessViewModel.PastSpinal = "";
            }
            else
            {
                infoInitAssessViewModel.PastSpinal = InitAssessViewModel.PastSpinal;
            }


            if (InitAssessViewModel.isPastBone == true)
            {
                infoInitAssessViewModel.isPastBone = "true";
            }
            else
            {
                infoInitAssessViewModel.isPastBone = "false";
            }

            if (InitAssessViewModel.PastBone == null)
            {
                infoInitAssessViewModel.PastBone = "";
            }
            else
            {
                infoInitAssessViewModel.PastBone = InitAssessViewModel.PastBone;
            }


            if (InitAssessViewModel.isPastOther == true)
            {
                infoInitAssessViewModel.isPastOther = "true";
            }
            else
            {
                infoInitAssessViewModel.isPastOther = "false";
            }

            if (InitAssessViewModel.PastOther == null)
            {
                infoInitAssessViewModel.PastOther = "";
            }
            else
            {
                infoInitAssessViewModel.PastOther = InitAssessViewModel.PastOther;
            }


            if (InitAssessViewModel.isMedicationNil == true)
            {
                infoInitAssessViewModel.isMedicationNil = "true";
            }
            else
            {
                infoInitAssessViewModel.isMedicationNil = "false";
            }

            if (InitAssessViewModel.isMedication == true)
            {
                infoInitAssessViewModel.isMedication = "true";
            }
            else
            {
                infoInitAssessViewModel.isMedication = "false";
            }

            if (InitAssessViewModel.Medication == null)
            {
                infoInitAssessViewModel.Medication = "";
            }
            else
            {
                infoInitAssessViewModel.Medication = InitAssessViewModel.Medication;
            }


            if (InitAssessViewModel.isPreOpNil == true)
            {
                infoInitAssessViewModel.isPreOpNil = "true";
            }
            else
            {
                infoInitAssessViewModel.isPreOpNil = "false";
            }

            if (InitAssessViewModel.isPreOp == true)
            {
                infoInitAssessViewModel.isPreOp = "true";
            }
            else
            {
                infoInitAssessViewModel.isPreOp = "false";
            }

            if (InitAssessViewModel.PreOp == null)
            {
                infoInitAssessViewModel.PreOp = "";
            }
            else
            {
                infoInitAssessViewModel.PreOp = InitAssessViewModel.PreOp;
            }


            if (InitAssessViewModel.isAllergyNil == true)
            {
                infoInitAssessViewModel.isAllergyNil = "true";
            }
            else
            {
                infoInitAssessViewModel.isAllergyNil = "false";
            }

            if (InitAssessViewModel.isAllergy == true)
            {
                infoInitAssessViewModel.isAllergy = "true";
            }
            else
            {
                infoInitAssessViewModel.isAllergy = "false";
            }

            if (InitAssessViewModel.Allergy == null)
            {
                infoInitAssessViewModel.Allergy = "";
            }
            else
            {
                infoInitAssessViewModel.Allergy = InitAssessViewModel.Allergy;
            }

            if (InitAssessViewModel.isGenNormal == true)
            {
                infoInitAssessViewModel.isGenNormal = "true";
            }
            else
            {
                infoInitAssessViewModel.isGenNormal = "false";
            }

            if (InitAssessViewModel.isGenLeg == true)
            {
                infoInitAssessViewModel.isGenLeg = "true";
            }
            else
            {
                infoInitAssessViewModel.isGenLeg = "false";
            }

            if (InitAssessViewModel.GenLeg == null)
            {
                infoInitAssessViewModel.GenLeg = "";
            }
            else
            {
                infoInitAssessViewModel.GenLeg = InitAssessViewModel.GenLeg;
            }

            if (InitAssessViewModel.isGenDys == true)
            {
                infoInitAssessViewModel.isGenDys = "true";
            }
            else
            {
                infoInitAssessViewModel.isGenDys = "false";
            }

            if (InitAssessViewModel.GenDys == null)
            {
                infoInitAssessViewModel.GenDys = "";
            }
            else
            {
                infoInitAssessViewModel.GenDys = InitAssessViewModel.GenDys;
            }


            if (InitAssessViewModel.isGenSkin == true)
            {
                infoInitAssessViewModel.isGenSkin = "true";
            }
            else
            {
                infoInitAssessViewModel.isGenSkin = "false";
            }

            if (InitAssessViewModel.GenSkin == null)
            {
                infoInitAssessViewModel.GenSkin = "";
            }
            else
            {
                infoInitAssessViewModel.GenSkin = InitAssessViewModel.GenSkin;
            }


            if (InitAssessViewModel.isGenOther == true)
            {
                infoInitAssessViewModel.isGenOther = "true";
            }
            else
            {
                infoInitAssessViewModel.isGenOther = "false";
            }

            if (InitAssessViewModel.GenOther == null)
            {
                infoInitAssessViewModel.GenOther = "";
            }
            else
            {
                infoInitAssessViewModel.GenOther = InitAssessViewModel.GenOther;
            }

            if (InitAssessViewModel.isBackInspectNormal == true)
            {
                infoInitAssessViewModel.isBackInspectNormal = "true";
            }
            else
            {
                infoInitAssessViewModel.isBackInspectNormal = "false";
            }

            if (InitAssessViewModel.isBackInspectAsy == true)
            {
                infoInitAssessViewModel.isBackInspectAsy = "true";
            }
            else
            {
                infoInitAssessViewModel.isBackInspectAsy = "false";
            }

            if (InitAssessViewModel.isBackInspectAsyR == true)
            {
                infoInitAssessViewModel.isBackInspectAsyR = "true";
            }
            else
            {
                infoInitAssessViewModel.isBackInspectAsyR = "false";
            }

            if (InitAssessViewModel.isBackInspectAsyL == true)
            {
                infoInitAssessViewModel.isBackInspectAsyL = "true";
            }
            else
            {
                infoInitAssessViewModel.isBackInspectAsyL = "false";
            }

            if (InitAssessViewModel.isBackInspectRib == true)
            {
                infoInitAssessViewModel.isBackInspectRib = "true";
            }
            else
            {
                infoInitAssessViewModel.isBackInspectRib = "false";
            }

            if (InitAssessViewModel.isBackInspectRibR == true)
            {
                infoInitAssessViewModel.isBackInspectRibR = "true";
            }
            else
            {
                infoInitAssessViewModel.isBackInspectRibR = "false";
            }

            if (InitAssessViewModel.isBackInspectRibL == true)
            {
                infoInitAssessViewModel.isBackInspectRibL = "true";
            }
            else
            {
                infoInitAssessViewModel.isBackInspectRibL = "false";
            }

            if (InitAssessViewModel.isBackInspectLumbar == true)
            {
                infoInitAssessViewModel.isBackInspectLumbar = "true";
            }
            else
            {
                infoInitAssessViewModel.isBackInspectLumbar = "false";
            }

            if (InitAssessViewModel.isBackInspectLumbarR == true)
            {
                infoInitAssessViewModel.isBackInspectLumbarR = "true";
            }
            else
            {
                infoInitAssessViewModel.isBackInspectLumbarR = "false";
            }

            if (InitAssessViewModel.isBackInspectLumbarL == true)
            {
                infoInitAssessViewModel.isBackInspectLumbarL = "true";
            }
            else
            {
                infoInitAssessViewModel.isBackInspectLumbarL = "false";
            }

            if (InitAssessViewModel.isBackPelvisTilt == true)
            {
                infoInitAssessViewModel.isBackPelvisTilt = "true";
            }
            else
            {
                infoInitAssessViewModel.isBackPelvisTilt = "false";
            }

            if (InitAssessViewModel.isBackPelvisTilt == true)
            {
                infoInitAssessViewModel.isBackPelvisTilt = "true";
            }
            else
            {
                infoInitAssessViewModel.isBackPelvisTilt = "false";
            }

            if (InitAssessViewModel.isBackPelvisTiltL == true)
            {
                infoInitAssessViewModel.isBackPelvisTiltL = "true";
            }
            else
            {
                infoInitAssessViewModel.isBackPelvisTiltL = "false";
            }


            if (InitAssessViewModel.isBackPelvisTiltR == true)
            {
                infoInitAssessViewModel.isBackPelvisTiltR = "true";
            }
            else
            {
                infoInitAssessViewModel.isBackPelvisTiltR = "false";
            }

            if (InitAssessViewModel.isBackInspectOther == true)
            {
                infoInitAssessViewModel.isBackInspectOther = "true";
            }
            else
            {
                infoInitAssessViewModel.isBackInspectOther = "false";
            }

            if (InitAssessViewModel.BackInspectOther == null)
            {
                infoInitAssessViewModel.BackInspectOther = "";
            }
            else
            {
                infoInitAssessViewModel.BackInspectOther = InitAssessViewModel.BackInspectOther;
            }

            if (InitAssessViewModel.isBackPalpationNormal == true)
            {
                infoInitAssessViewModel.isBackPalpationNormal = "true";
            }
            else
            {
                infoInitAssessViewModel.isBackPalpationNormal = "false";
            }

            if (InitAssessViewModel.isBackPalpationAbnormal == true)
            {
                infoInitAssessViewModel.isBackPalpationAbnormal = "true";
            }
            else
            {
                infoInitAssessViewModel.isBackPalpationAbnormal = "false";
            }

            if (InitAssessViewModel.BackPalpationAbnormal == null)
            {
                infoInitAssessViewModel.BackPalpationAbnormal = "";
            }
            else
            {
                infoInitAssessViewModel.BackPalpationAbnormal = InitAssessViewModel.BackPalpationAbnormal;
            }

            if (InitAssessViewModel.isBackRangeNormal == true)
            {
                infoInitAssessViewModel.isBackRangeNormal = "true";
            }
            else
            {
                infoInitAssessViewModel.isBackRangeNormal = "false";
            }

            if (InitAssessViewModel.isBackRangeDys == true)
            {
                infoInitAssessViewModel.isBackRangeDys = "true";
            }
            else
            {
                infoInitAssessViewModel.isBackRangeDys = "false";
            }

            if (InitAssessViewModel.BackRangeDys == null)
            {
                infoInitAssessViewModel.BackRangeDys = "";
            }
            else
            {
                infoInitAssessViewModel.BackRangeDys = InitAssessViewModel.BackRangeDys;
            }


            if (InitAssessViewModel.BackRangeSchober5 == null)
            {
                infoInitAssessViewModel.BackRangeSchober5 = "";
            }
            else
            {
                infoInitAssessViewModel.BackRangeSchober5 = InitAssessViewModel.BackRangeSchober5.Value.ToString();
            }


            if (InitAssessViewModel.BackRangeSchober10 == null)
            {
                infoInitAssessViewModel.BackRangeSchober10 = "";
            }
            else
            {
                infoInitAssessViewModel.BackRangeSchober10 = InitAssessViewModel.BackRangeSchober10.Value.ToString();
            }

            if (InitAssessViewModel.BackRangeSchober15 == null)
            {
                infoInitAssessViewModel.BackRangeSchober15 = "";
            }
            else
            {
                infoInitAssessViewModel.BackRangeSchober15 = InitAssessViewModel.BackRangeSchober15.Value.ToString();
            }

            if (InitAssessViewModel.isBackRangeAbnormal == true)
            {
                infoInitAssessViewModel.isBackRangeAbnormal = "true";
            }
            else
            {
                infoInitAssessViewModel.isBackRangeAbnormal = "false";
            }

            if (InitAssessViewModel.BackRangeForward == null)
            {
                infoInitAssessViewModel.BackRangeForward = "";
            }
            else
            {
                infoInitAssessViewModel.BackRangeForward = InitAssessViewModel.BackRangeForward;
            }

            if (InitAssessViewModel.BackRangeSide == null)
            {
                infoInitAssessViewModel.BackRangeSide = "";
            }
            else
            {
                infoInitAssessViewModel.BackRangeSide = InitAssessViewModel.BackRangeSide;
            }


            if (InitAssessViewModel.isBackLegNormal == true)
            {
                infoInitAssessViewModel.isBackLegNormal = "true";
            }
            else
            {
                infoInitAssessViewModel.isBackLegNormal = "false";
            }

            if (InitAssessViewModel.isBackLegAbnormal == true)
            {
                infoInitAssessViewModel.isBackLegAbnormal = "true";
            }
            else
            {
                infoInitAssessViewModel.isBackLegAbnormal = "false";
            }

            if (InitAssessViewModel.BackLegAbnormal == null)
            {
                infoInitAssessViewModel.BackLegAbnormal = "";
            }
            else
            {
                infoInitAssessViewModel.BackLegAbnormal = InitAssessViewModel.BackLegAbnormal;
            }


            if (InitAssessViewModel.isBackLimbNormal == true)
            {
                infoInitAssessViewModel.isBackLimbNormal = "true";
            }
            else
            {
                infoInitAssessViewModel.isBackLimbNormal = "false";
            }

            if (InitAssessViewModel.isBackLimbAbnormal == true)
            {
                infoInitAssessViewModel.isBackLimbAbnormal = "true";
            }
            else
            {
                infoInitAssessViewModel.isBackLimbAbnormal = "false";
            }

            if (InitAssessViewModel.BackLimbAbnormal == null)
            {
                infoInitAssessViewModel.BackLimbAbnormal = "";
            }
            else
            {
                infoInitAssessViewModel.BackLimbAbnormal = InitAssessViewModel.BackLimbAbnormal;
            }

            if (InitAssessViewModel.Remarks == null)
            {
                infoInitAssessViewModel.Remarks = "";
            }
            else
            {
                infoInitAssessViewModel.Remarks = InitAssessViewModel.Remarks;
            }


            if (InitAssessViewModel.LastModify == null)
            {
                infoInitAssessViewModel.LastModify = "";
            }
            else
            {
                infoInitAssessViewModel.LastModify = InitAssessViewModel.LastModify.Value.ToString("yyyy-MM-dd");
            }

            return infoInitAssessViewModel;
        }


        public InfoInitAssessViewModel GetInitInfoInitAssessViewModel()
        {
            var infoInitAssessViewModel = new InfoInitAssessViewModel();

            infoInitAssessViewModel.SCN = "";

            infoInitAssessViewModel.iadate = "";

            infoInitAssessViewModel.isReferralStudent = "false";

            infoInitAssessViewModel.isReferralOther = "false";

            infoInitAssessViewModel.ReferralOther = "";

            infoInitAssessViewModel.isConcernNil = "false";

            infoInitAssessViewModel.isConcernOther = "false";

            infoInitAssessViewModel.ConcernOther = "";

            infoInitAssessViewModel.isSymNil = "false";

            infoInitAssessViewModel.isSymBack = "false";

            infoInitAssessViewModel.SymBack = "";

            infoInitAssessViewModel.isSymLimb = "false";

            infoInitAssessViewModel.SymLimb = "";

            infoInitAssessViewModel.isSymCon = "false";

            infoInitAssessViewModel.SymCon = "";

            infoInitAssessViewModel.isSymOther = "false";

            infoInitAssessViewModel.SymOther = "";

            infoInitAssessViewModel.isPastGood = "false";

            infoInitAssessViewModel.isPastSpinal = "false";

            infoInitAssessViewModel.PastSpinal = "";

            infoInitAssessViewModel.isPastBone = "false";

            infoInitAssessViewModel.PastBone = "";

            infoInitAssessViewModel.isPastOther = "false";

            infoInitAssessViewModel.PastOther = "";

            infoInitAssessViewModel.isMedicationNil = "false";

            infoInitAssessViewModel.isMedication = "false";

            infoInitAssessViewModel.Medication = "";

            infoInitAssessViewModel.isPreOpNil = "false";

            infoInitAssessViewModel.isPreOp = "false";

            infoInitAssessViewModel.PreOp = "";

            infoInitAssessViewModel.isAllergyNil = "false";

            infoInitAssessViewModel.isAllergy = "false";

            infoInitAssessViewModel.Allergy = "";

            infoInitAssessViewModel.isGenNormal = "false";

            infoInitAssessViewModel.isGenLeg = "false";

            infoInitAssessViewModel.GenLeg = "";

            infoInitAssessViewModel.isGenDys = "false";

            infoInitAssessViewModel.GenDys = "";

            infoInitAssessViewModel.isGenSkin = "false";

            infoInitAssessViewModel.GenSkin = "";

            infoInitAssessViewModel.isGenOther = "false";

            infoInitAssessViewModel.GenOther = "";

            infoInitAssessViewModel.isBackInspectNormal = "false";

            infoInitAssessViewModel.isBackInspectAsy = "false";

            infoInitAssessViewModel.isBackInspectAsyR = "false";

            infoInitAssessViewModel.isBackInspectAsyL = "false";

            infoInitAssessViewModel.isBackInspectRib = "false";

            infoInitAssessViewModel.isBackInspectRibR = "false";

            infoInitAssessViewModel.isBackInspectRibL = "false";

            infoInitAssessViewModel.isBackInspectLumbar = "false";

            infoInitAssessViewModel.isBackInspectLumbarR = "false";


            infoInitAssessViewModel.isBackPelvisTilt = "false";

            infoInitAssessViewModel.isBackPelvisTilt = "false";

            infoInitAssessViewModel.isBackPelvisTiltL = "false";

            infoInitAssessViewModel.isBackPelvisTiltR = "false";

            infoInitAssessViewModel.isBackInspectOther = "false";

            infoInitAssessViewModel.BackInspectOther = "";

            infoInitAssessViewModel.isBackPalpationNormal = "false";

            infoInitAssessViewModel.isBackPalpationAbnormal = "false";

            infoInitAssessViewModel.BackPalpationAbnormal = "";

            infoInitAssessViewModel.isBackRangeNormal = "false";


            infoInitAssessViewModel.isBackRangeDys = "false";

            infoInitAssessViewModel.BackRangeDys = "";

            infoInitAssessViewModel.BackRangeSchober5 = "0";

            infoInitAssessViewModel.BackRangeSchober10 = "0";

            infoInitAssessViewModel.BackRangeSchober15 = "0";

            infoInitAssessViewModel.isBackRangeAbnormal = "false";

            infoInitAssessViewModel.BackRangeForward = "";

            infoInitAssessViewModel.BackRangeSide = "";

            infoInitAssessViewModel.isBackLegNormal = "false";

            infoInitAssessViewModel.isBackLegAbnormal = "false";

            infoInitAssessViewModel.BackLegAbnormal = "";

            infoInitAssessViewModel.isBackLimbNormal = "false";

            infoInitAssessViewModel.isBackLimbAbnormal = "false";

            infoInitAssessViewModel.BackLimbAbnormal = "";

            infoInitAssessViewModel.Remarks = "";

            infoInitAssessViewModel.LastModify = "";


            return infoInitAssessViewModel;
        }


    }


}
   
