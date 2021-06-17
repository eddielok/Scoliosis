using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Scoliosis.Models
{
    public class PersonalInfoLogViewModel
    {
        [Required]
        [Key]
        public Int64 id { get; set; }

        [Required]
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

        public string Action { get; set; }

        public string CreatedBy { get; set; }

        public Nullable<DateTime> CreatedDate { get; set; }

        //20200518 Add Field
        public string Lenke1 { get; set; }
        public string Lenke2 { get; set; }
        public string Lenke3 { get; set; }

    

        public static explicit operator PersonalInfoLogViewModel(PersonalInfoModel personalInfoModel)
        {
            var personalInfoLogViewModel = new PersonalInfoLogViewModel();

            personalInfoLogViewModel.SCN = personalInfoModel.SCN;

            personalInfoLogViewModel.HKID = personalInfoModel.HKID;

            personalInfoLogViewModel.Name = personalInfoModel.Name;

            personalInfoLogViewModel.Sex = personalInfoModel.Sex;

            personalInfoLogViewModel.DOB = personalInfoModel.DOB;

            personalInfoLogViewModel.AgeOnset = personalInfoModel.AgeOnset;


            personalInfoLogViewModel.FamHis = personalInfoModel.FamHis;

            personalInfoLogViewModel.AttnPhys = personalInfoModel.AttnPhys;

            personalInfoLogViewModel.HisOthers = personalInfoModel.HisOthers;

            personalInfoLogViewModel.DiagnosisMisc = personalInfoModel.DiagnosisMisc;

            personalInfoLogViewModel.isKingI = personalInfoModel.isKingI;
            personalInfoLogViewModel.isKingII = personalInfoModel.isKingII;

            personalInfoLogViewModel.isKingIII = personalInfoModel.isKingIII;


            personalInfoLogViewModel.isKingIV = personalInfoModel.isKingIV;

            personalInfoLogViewModel.isKingV = personalInfoModel.isKingV;


            personalInfoLogViewModel.isIso = personalInfoModel.isIso;

            personalInfoLogViewModel.isTriple = personalInfoModel.isTriple;

            personalInfoLogViewModel.isTL = personalInfoModel.isTL;

            personalInfoLogViewModel.isL = personalInfoModel.isL;

            personalInfoLogViewModel.isUnderArm = personalInfoModel.isUnderArm;
            personalInfoLogViewModel.isMilwaukes = personalInfoModel.isMilwaukes;



            personalInfoLogViewModel.ADCA = personalInfoModel.ADCA;


            personalInfoLogViewModel.isBoston = personalInfoModel.isBoston;

            personalInfoLogViewModel.isBraceOthers = personalInfoModel.isBraceOthers;

            personalInfoLogViewModel.BraceOthers = personalInfoModel.BraceOthers;


            personalInfoLogViewModel.BraceStart = personalInfoModel.BraceStart;

            personalInfoLogViewModel.BraceWean = personalInfoModel.BraceWean;

            personalInfoLogViewModel.BraceStop = personalInfoModel.BraceStop;

            personalInfoLogViewModel.Surgeons = personalInfoModel.Surgeons;

            personalInfoLogViewModel.ASF = personalInfoModel.ASF;


            personalInfoLogViewModel.PSF = personalInfoModel.PSF;


            personalInfoLogViewModel.ASFPSF = personalInfoModel.ASFPSF;


            personalInfoLogViewModel.ThoRelease = personalInfoModel.ThoRelease;

            personalInfoLogViewModel.otherSurgery = personalInfoModel.otherSurgery;


            personalInfoLogViewModel.LOFfrom = personalInfoModel.LOFfrom;

            personalInfoLogViewModel.LOFto = personalInfoModel.LOFto;

            personalInfoLogViewModel.isAuto = personalInfoModel.isAuto;

            personalInfoLogViewModel.isAllo = personalInfoModel.isAllo;

            personalInfoLogViewModel.isGraOthers = personalInfoModel.isGraOthers;

            personalInfoLogViewModel.isPosISOLA = personalInfoModel.isPosISOLA;

            personalInfoLogViewModel.isPostCD = personalInfoModel.isPostCD;

            personalInfoLogViewModel.isPostOthers = personalInfoModel.isPostOthers;

            personalInfoLogViewModel.isPostHarr = personalInfoModel.isPostHarr;

            personalInfoLogViewModel.isAntZielke = personalInfoModel.isAntZielke;

            personalInfoLogViewModel.isAntOthers = personalInfoModel.isAntOthers;

            personalInfoLogViewModel.isAntISOLA = personalInfoModel.isAntISOLA;

            personalInfoLogViewModel.otherImplant = personalInfoModel.otherImplant;

            personalInfoLogViewModel.PostOPStart = personalInfoModel.PostOPStart;


            personalInfoLogViewModel.PostOPWean = personalInfoModel.PostOPWean;

            personalInfoLogViewModel.PostOPStop = personalInfoModel.PostOPStop;


            personalInfoLogViewModel.isXrayfilm = personalInfoModel.isXrayfilm;

            personalInfoLogViewModel.isMRI = personalInfoModel.isMRI;

            personalInfoLogViewModel.isDXA = personalInfoModel.isDXA;

            personalInfoLogViewModel.isUS = personalInfoModel.isUS;

            personalInfoLogViewModel.isCTscan = personalInfoModel.isCTscan;

            personalInfoLogViewModel.isBioChem = personalInfoModel.isBioChem;

            personalInfoLogViewModel.isQCT = personalInfoModel.isQCT;

            personalInfoLogViewModel.isSSEP = personalInfoModel.isSSEP;

            personalInfoLogViewModel.isEMG = personalInfoModel.isEMG;


            personalInfoLogViewModel.OtherInvest = personalInfoModel.OtherInvest;

            personalInfoLogViewModel.Comments = personalInfoModel.Comments;

            //20200518 Add field
            personalInfoLogViewModel.Lenke1 = personalInfoModel.Lenke1;
            personalInfoLogViewModel.Lenke2 = personalInfoModel.Lenke2;
            personalInfoLogViewModel.Lenke3 = personalInfoModel.Lenke3;

            return personalInfoLogViewModel;
        }


    }
}
