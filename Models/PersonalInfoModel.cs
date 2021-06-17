using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Scoliosis.Models
{
    public class PersonalInfoModel
    {

        [Required]
        [Key]
        public string SCN { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string HKID { get; set; }

        [Required]
        public Nullable<Int16> Sex { get; set; }

        [Required]
        public Nullable<DateTime> DOB { get; set; }

        [Required]
        public Nullable<double> AgeOnset { get; set; }

        [Required]
        public string FamHis { get; set; }

        [Required]
        public string AttnPhys { get; set; }

        [Required]
        public string HisOthers { get; set; }

        [Required]
        public Int16 Diagnosis { get; set; }

        [Required]
        public string DiagnosisMisc { get; set; }

        [Required]
        public bool isKingI { get; set; }

        [Required]
        public bool isKingII { get; set; }

        [Required]
        public bool isKingIII { get; set; }

        [Required]
        public bool isKingIV { get; set; }

        [Required]
        public bool isKingV { get; set; }

        [Required]
        public bool isIso { get; set; }

        [Required]
        public bool isTriple { get; set; }

        [Required]
        public bool isTL { get; set; }

        [Required]
        public bool isL { get; set; }

        [Required]
        public string ADCA { get; set; }

        [Required]
        public bool isUnderArm { get; set; }

        [Required]
        public bool isMilwaukes { get; set; }
        [Required]
        public bool isBoston { get; set; }

        [Required]
        public bool isBraceOthers { get; set; }

        [Required]
        public string BraceOthers { get; set; }

        [Required]
        public Nullable<DateTime> BraceStart { get; set; }


        [Required]
        public Nullable<DateTime> BraceWean { get; set; }


        [Required]
        public Nullable<DateTime> BraceStop { get; set; }

        [Required]
        public string Surgeons { get; set; }

        [Required]
        public Nullable<DateTime> ASF { get; set; }

        [Required]
        public Nullable<DateTime> PSF { get; set; }

        [Required]
        public Nullable<DateTime> ASFPSF { get; set; }

        [Required]
        public Nullable<DateTime> ThoRelease { get; set; }

        [Required]
        public string otherSurgery { get; set; }

        [Required]
        public string LOF { get; set; }

        [Required]
        public string LOFfrom { get; set; }


        [Required]
        public string LOFto { get; set; }


        [Required]
        public bool isAuto { get; set; }

        [Required]
        public bool isAllo { get; set; }


        [Required]
        public bool isGraOthers { get; set; }

        [Required]
        public bool isPosISOLA { get; set; }

        [Required]
        public bool isPostCD { get; set; }

        [Required]
        public bool isPostHarr { get; set; }

        [Required]
        public bool isPostOthers { get; set; }

        [Required]
        public bool isAntZielke { get; set; }

        [Required]
        public bool isAntISOLA { get; set; }

        [Required]
        public bool isAntOthers { get; set; }

        [Required]
        public string otherImplant { get; set; }

        [Required]
        public Nullable<DateTime> PostOPStart { get; set; }

        [Required]
        public Nullable<DateTime> PostOPWean { get; set; }

        [Required]
        public Nullable<DateTime> PostOPStop { get; set; }

        [Required]
        public bool isXrayfilm { get; set; }

        [Required]
        public bool isMRI { get; set; }

        [Required]
        public bool isDXA { get; set; }

        [Required]
        public bool isSSEP { get; set; }
        [Required]
        public bool isCTscan { get; set; }

        [Required]
        public bool isBioChem { get; set; }

        [Required]
        public bool isQCT { get; set; }

        [Required]
        public bool isEMG { get; set; }

        [Required]
        public bool isUS { get; set; }

        [Required]
        public bool isPQCT { get; set; }

        [Required]
        public string OtherInvest { get; set; }

        [Required]
        public string Comments { get; set; }

        [Required]
        public string SpcRemarks { get; set; }


        [Required]
        public string LastModifyBy { get; set; }

        [Required]
        public Nullable<DateTime> LastModify { get; set; }


        //20200518 Add Field
        [Required]
        public string Lenke1 { get; set; }

        [Required]
        public string Lenke2 { get; set; }

        [Required]
        public string Lenke3 { get; set; }


        public static explicit operator InfoPersonalInfoViewModel(PersonalInfoModel personalInfoModel)
        {
            var infoPersonalInfoViewModel = new InfoPersonalInfoViewModel();

            infoPersonalInfoViewModel.SCN = personalInfoModel.SCN;

            infoPersonalInfoViewModel.HKID = personalInfoModel.HKID;

            infoPersonalInfoViewModel.Name = personalInfoModel.Name;

            if (personalInfoModel.Sex == 0)
            {
                infoPersonalInfoViewModel.Sex = "";
            }
            else if (personalInfoModel.Sex == 1)
            {
                infoPersonalInfoViewModel.Sex = "1";
            }
            else if (personalInfoModel.Sex == 2)
            {
                infoPersonalInfoViewModel.Sex = "2";
            }

            if (personalInfoModel.DOB == null)
            {
                infoPersonalInfoViewModel.DOB = "";
            }
            else
            {
                infoPersonalInfoViewModel.DOB = personalInfoModel.DOB.Value.ToString("dd/MM/yyyy");
            }

            if (personalInfoModel.AgeOnset == null)
            {
                infoPersonalInfoViewModel.AgeOnset = "";
            }
            else {
                infoPersonalInfoViewModel.AgeOnset = personalInfoModel.AgeOnset.Value.ToString();
            }

            infoPersonalInfoViewModel.FamHis = personalInfoModel.FamHis;

            infoPersonalInfoViewModel.AttnPhys = personalInfoModel.AttnPhys;

            infoPersonalInfoViewModel.HisOthers = personalInfoModel.HisOthers;

            infoPersonalInfoViewModel.DiagnosisMisc = personalInfoModel.DiagnosisMisc;

            if (personalInfoModel.isKingI == true) {
                infoPersonalInfoViewModel.isKingI = "true";
            }
            else {
                infoPersonalInfoViewModel.isKingI = "false";
            }

            if (personalInfoModel.isKingII == true)
            {
                infoPersonalInfoViewModel.isKingII = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isKingII = "false";
            }

            if (personalInfoModel.isKingIII == true)
            {
                infoPersonalInfoViewModel.isKingIII = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isKingIII = "false";
            }

            if (personalInfoModel.isKingIV == true)
            {
                infoPersonalInfoViewModel.isKingIV = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isKingIV = "false";
            }

            if (personalInfoModel.isKingV == true)
            {
                infoPersonalInfoViewModel.isKingV = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isKingV = "false";
            }

            if (personalInfoModel.isIso == true)
            {
                infoPersonalInfoViewModel.isIso = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isIso = "false";
            }

            if (personalInfoModel.isTriple == true)
            {
                infoPersonalInfoViewModel.isTriple = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isTriple = "false";
            }

            if (personalInfoModel.isTL == true)
            {
                infoPersonalInfoViewModel.isTL = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isTL = "false";
            }

            if (personalInfoModel.isL == true)
            {
                infoPersonalInfoViewModel.isL = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isL = "false";
            }
            

            infoPersonalInfoViewModel.ADCA = personalInfoModel.ADCA;


            if (personalInfoModel.isUnderArm == true)
            {
                infoPersonalInfoViewModel.isUnderArm = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isUnderArm = "false";
            }

            if (personalInfoModel.isMilwaukes == true)
            {
                infoPersonalInfoViewModel.isMilwaukes = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isMilwaukes = "false";
            }

            if (personalInfoModel.isBoston == true)
            {
                infoPersonalInfoViewModel.isBoston = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isBoston = "false";
            }

            if (personalInfoModel.isBraceOthers == true)
            {
                infoPersonalInfoViewModel.isBraceOthers = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isBraceOthers = "false";
            }


           

            infoPersonalInfoViewModel.BraceOthers = personalInfoModel.BraceOthers;


            if (personalInfoModel.BraceStart == null)
            {
                infoPersonalInfoViewModel.BraceStart = "";
            }
            else
            {
                infoPersonalInfoViewModel.BraceStart = personalInfoModel.BraceStart.Value.ToString("dd/MM/yyyy");
            }

            if (personalInfoModel.BraceWean == null)
            {
                infoPersonalInfoViewModel.BraceWean = "";
            }
            else
            {
                infoPersonalInfoViewModel.BraceWean = personalInfoModel.BraceWean.Value.ToString("dd/MM/yyyy");
            }

            if (personalInfoModel.BraceStop == null)
            {
                infoPersonalInfoViewModel.BraceStop = "";
            }
            else
            {
                infoPersonalInfoViewModel.BraceStop = personalInfoModel.BraceStop.Value.ToString("dd/MM/yyyy");
            }


            if (personalInfoModel.Surgeons == null)
            {
                infoPersonalInfoViewModel.Surgeons = "";
            }
            else {
                infoPersonalInfoViewModel.Surgeons = personalInfoModel.Surgeons;
            }
           


            if (personalInfoModel.ASF == null)
            {
                infoPersonalInfoViewModel.ASF = "";
            }
            else
            {
                infoPersonalInfoViewModel.ASF = personalInfoModel.ASF.Value.ToString("dd/MM/yyyy");
            }

            if (personalInfoModel.PSF == null)
            {
                infoPersonalInfoViewModel.PSF = "";
            }
            else
            {
                infoPersonalInfoViewModel.PSF = personalInfoModel.PSF.Value.ToString("dd/MM/yyyy");
            }

            if (personalInfoModel.ASFPSF == null)
            {
                infoPersonalInfoViewModel.ASFPSF = "";
            }
            else
            {
                infoPersonalInfoViewModel.ASFPSF = personalInfoModel.ASFPSF.Value.ToString("dd/MM/yyyy");
            }

            if (personalInfoModel.ThoRelease == null)
            {
                infoPersonalInfoViewModel.ThoRelease = "";
            }
            else
            {
                infoPersonalInfoViewModel.ThoRelease = personalInfoModel.ThoRelease.Value.ToString("dd/MM/yyyy");
            }

            if (personalInfoModel.otherSurgery == null)
            {
                infoPersonalInfoViewModel.otherSurgery = "";
            }
            else
            {
                infoPersonalInfoViewModel.otherSurgery = personalInfoModel.otherSurgery;
            }

            if (personalInfoModel.LOFfrom == null)
            {
                infoPersonalInfoViewModel.LOFfrom = "";
            }
            else
            {
                infoPersonalInfoViewModel.LOFfrom = personalInfoModel.LOFfrom;
            }

            if (personalInfoModel.LOFto == null)
            {
                infoPersonalInfoViewModel.LOFto = "";
            }
            else
            {
                infoPersonalInfoViewModel.LOFto = personalInfoModel.LOFto;
            }


            if (personalInfoModel.isAuto == true)
            {
                infoPersonalInfoViewModel.isAuto = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isAuto = "false";
            }


            if (personalInfoModel.isAllo == true)
            {
                infoPersonalInfoViewModel.isAllo = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isAllo = "false";
            }


            if (personalInfoModel.isGraOthers == true)
            {
                infoPersonalInfoViewModel.isGraOthers = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isGraOthers = "false";
            }

            if (personalInfoModel.isPosISOLA == true)
            {
                infoPersonalInfoViewModel.isPosISOLA = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isPosISOLA = "false";
            }

            if (personalInfoModel.isPostCD == true)
            {
                infoPersonalInfoViewModel.isPostCD = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isPostCD = "false";
            }

            if (personalInfoModel.isPostOthers == true)
            {
                infoPersonalInfoViewModel.isPostOthers = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isPostOthers = "false";
            }

            if (personalInfoModel.isPostHarr == true)
            {
                infoPersonalInfoViewModel.isPostHarr = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isPostHarr = "false";
            }
            

            if (personalInfoModel.isAntZielke == true)
            {
                infoPersonalInfoViewModel.isAntZielke = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isAntZielke = "false";
            }

            if (personalInfoModel.isAntOthers == true)
            {
                infoPersonalInfoViewModel.isAntOthers = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isAntOthers = "false";
            }

            if (personalInfoModel.isAntISOLA == true)
            {
                infoPersonalInfoViewModel.isAntISOLA = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isAntISOLA = "false";
            }

            

            infoPersonalInfoViewModel.otherImplant = personalInfoModel.otherImplant;

            if (personalInfoModel.PostOPStart == null)
            {
                infoPersonalInfoViewModel.PostOPStart = "";
            }
            else
            {
                infoPersonalInfoViewModel.PostOPStart = personalInfoModel.PostOPStart.Value.ToString("dd/MM/yyyy");
            }

            if (personalInfoModel.PostOPWean == null)
            {
                infoPersonalInfoViewModel.PostOPWean = "";
            }
            else
            {
                infoPersonalInfoViewModel.PostOPWean = personalInfoModel.PostOPWean.Value.ToString("dd/MM/yyyy");
            }

            if (personalInfoModel.PostOPStop == null)
            {
                infoPersonalInfoViewModel.PostOPStop = "";
            }
            else
            {
                infoPersonalInfoViewModel.PostOPStop = personalInfoModel.PostOPStop.Value.ToString("dd/MM/yyyy");
            }


            if (personalInfoModel.isXrayfilm == true)
            {
                infoPersonalInfoViewModel.isXrayfilm = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isXrayfilm = "false";
            }


            if (personalInfoModel.isMRI == true)
            {
                infoPersonalInfoViewModel.isMRI = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isMRI = "false";
            }


            if (personalInfoModel.isDXA == true)
            {
                infoPersonalInfoViewModel.isDXA = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isDXA = "false";
            }

            if (personalInfoModel.isUS == true)
            {
                infoPersonalInfoViewModel.isUS = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isUS = "false";
            }

            if (personalInfoModel.isCTscan == true)
            {
                infoPersonalInfoViewModel.isCTscan = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isCTscan = "false";
            }

            if (personalInfoModel.isBioChem == true)
            {
                infoPersonalInfoViewModel.isBioChem = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isBioChem = "false";
            }

            
            if (personalInfoModel.isQCT == true)
            {
                infoPersonalInfoViewModel.isQCT = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isQCT = "false";
            }

            if (personalInfoModel.isSSEP == true)
            {
                infoPersonalInfoViewModel.isSSEP = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isSSEP = "false";
            }


            if (personalInfoModel.isEMG == true)
            {
                infoPersonalInfoViewModel.isEMG = "true";
            }
            else
            {
                infoPersonalInfoViewModel.isEMG = "false";
            }
            


            infoPersonalInfoViewModel.OtherInvest = personalInfoModel.OtherInvest;

            infoPersonalInfoViewModel.Comments = personalInfoModel.Comments;


            //20200518 Add Field
            infoPersonalInfoViewModel.Lenke1 = personalInfoModel.Lenke1;
            infoPersonalInfoViewModel.Lenke2 = personalInfoModel.Lenke2;
            infoPersonalInfoViewModel.Lenke3 = personalInfoModel.Lenke3;

            return infoPersonalInfoViewModel;
        }



    }
}
