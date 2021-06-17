using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scoliosis.Models
{
    public class CreatePersonalInfoViewModel
    {
        public string SCN { get; set; }

        public string Name { get; set; }

        public string DOB { get; set; }

        public string HKID { get; set; }

        public string Sex { get; set; }

        public string AgeOnset { get; set; }

        public string FamHis { get; set; }

        public string AttnPhys { get; set; }

        public string HisOthers { get; set; }

        public string isIS { get; set; }

        public string isCS { get; set; }

        public string isNM { get; set; }

        public string isMisc { get; set; }

        public string DiagnosisMisc { get; set; }
        public string isKingI { get; set; }
        public string isKingII { get; set; }
        public string isKingIII { get; set; }
        public string isKingIV { get; set; }
        public string isKingV { get; set; }
        public string isIso { get; set; }
        public string isTriple { get; set; }
        public string isTL { get; set; }
        public string isL { get; set; }
        public string ADCA { get; set; }
        public string isUnderArm { get; set; }
        public string isMilwaukes { get; set; }
        public string isBoston { get; set; }
        public string isBraceOthers { get; set; }
        public string BraceOthers { get; set; }
        public string BraceStart { get; set; }
        public string BraceWean { get; set; }
        public string BraceStop { get; set; }
        public string ASF { get; set; }
        public string PSF { get; set; }
        public string ASFPSF { get; set; }
        public string ThoRelease { get; set; }

        public string Surgeons { get; set; }
        public string otherSurgery { get; set; }
        public string LOFfrom { get; set; }
        public string LOFto { get; set; }
        public string isAuto { get; set; }
        public string isAllo { get; set; }
        public string isGraOthers { get; set; }
        public string isPosISOLA { get; set; }
        public string isPostHarr { get; set; }
        public string isPostCD { get; set; }
        public string isPostOthers { get; set; }
        public string isAntZielke { get; set; }
        public string isAntOthers { get; set; }
        public string isAntISOLA { get; set; }
        public string otherImplant { get; set; }
        public string PostOPStart { get; set; }
        public string PostOPWean { get; set; }
        public string PostOPStop { get; set; }
        public string isXrayfilm { get; set; }
        public string isMRI { get; set; }
        public string isDXA { get; set; }
        public string isUS { get; set; }

        public string isPQCT { get; set; }

        public string isCTscan { get; set; }
        public string isBioChem { get; set; }
        public string isQCT { get; set; }
        public string isSSEP { get; set; }
        public string isEMG { get; set; }
        public string OtherInvest { get; set; }
        public string Comments { get; set; }

        //20200518 Add field
        public string Lenke1 { get; set; }

        public string Lenke2 { get; set; }

        public string Lenke3 { get; set; }

        public CreatePersonalInfoViewModel SetDefaultValue(CreatePersonalInfoViewModel createPersonalInfoViewModel)
        {

            createPersonalInfoViewModel.SCN = "";

            createPersonalInfoViewModel.Name = "";

            createPersonalInfoViewModel.DOB = "";

            createPersonalInfoViewModel.HKID = "";

            createPersonalInfoViewModel.Sex = "";

            createPersonalInfoViewModel.AgeOnset = "";

            createPersonalInfoViewModel.FamHis = "";

            createPersonalInfoViewModel.AttnPhys = "";

            createPersonalInfoViewModel.HisOthers = "";

            createPersonalInfoViewModel.isIS = "";

            createPersonalInfoViewModel.isCS = "";

            createPersonalInfoViewModel.isNM = "";

            createPersonalInfoViewModel.isMisc = "";

            createPersonalInfoViewModel.DiagnosisMisc = "";
            createPersonalInfoViewModel.isKingI = "";
            createPersonalInfoViewModel.isKingII = "";
            createPersonalInfoViewModel.isKingIII = "";
            createPersonalInfoViewModel.isKingIV = "";
            createPersonalInfoViewModel.isKingV = "";
            createPersonalInfoViewModel.isIso = "";
            createPersonalInfoViewModel.isTriple = "";
            createPersonalInfoViewModel.isTL = "";
            createPersonalInfoViewModel.isL = "";
            createPersonalInfoViewModel.ADCA = "";
            createPersonalInfoViewModel.isUnderArm = "";
            createPersonalInfoViewModel.isMilwaukes = "";
            createPersonalInfoViewModel.isBoston = "";
            createPersonalInfoViewModel.isBraceOthers = "";
            createPersonalInfoViewModel.BraceOthers = "";
            createPersonalInfoViewModel.BraceStart = "";
            createPersonalInfoViewModel.BraceWean = "";
            createPersonalInfoViewModel.BraceStop = "";
            createPersonalInfoViewModel.ASF = "";
            createPersonalInfoViewModel.PSF = "";
            createPersonalInfoViewModel.ASFPSF = "";
            createPersonalInfoViewModel.ThoRelease = "";

            createPersonalInfoViewModel.Surgeons = "";
            createPersonalInfoViewModel.otherSurgery = "";
            createPersonalInfoViewModel.LOFfrom = "";
            createPersonalInfoViewModel.LOFto = "";
            createPersonalInfoViewModel.isAuto = "";
            createPersonalInfoViewModel.isAllo = "";
            createPersonalInfoViewModel.isGraOthers = "";
            createPersonalInfoViewModel.isPosISOLA = "";
            createPersonalInfoViewModel.isPostHarr = "";
            createPersonalInfoViewModel.isPostCD = "";
            createPersonalInfoViewModel.isPostOthers = "";
            createPersonalInfoViewModel.isAntZielke = "";
            createPersonalInfoViewModel.isAntOthers = "";
            createPersonalInfoViewModel.isAntISOLA = "";
            createPersonalInfoViewModel.otherImplant = "";
            createPersonalInfoViewModel.PostOPStart = "";
            createPersonalInfoViewModel.PostOPWean = "";
            createPersonalInfoViewModel.PostOPStop = "";
            createPersonalInfoViewModel.isXrayfilm = "";
            createPersonalInfoViewModel.isMRI = "";
            createPersonalInfoViewModel.isDXA = "";
            createPersonalInfoViewModel.isUS = "";
            createPersonalInfoViewModel.isPQCT = "";
            createPersonalInfoViewModel.isCTscan = "";
            createPersonalInfoViewModel.isBioChem = "";
            createPersonalInfoViewModel.isQCT = "";
            createPersonalInfoViewModel.isSSEP = "";
            createPersonalInfoViewModel.isEMG = "";
            createPersonalInfoViewModel.OtherInvest = "";
            createPersonalInfoViewModel.Comments = "";

            //20200518 Add Field
            createPersonalInfoViewModel.Lenke1 = "";
            createPersonalInfoViewModel.Lenke2 = "";
            createPersonalInfoViewModel.Lenke3 = "";

            return createPersonalInfoViewModel;
        }

        public static explicit operator PersonalInfoModel(CreatePersonalInfoViewModel createPersonalInfoViewModel)
        {
            var personalInfoModel = new PersonalInfoModel();

            personalInfoModel.SCN = createPersonalInfoViewModel.SCN;

            personalInfoModel.Name = createPersonalInfoViewModel.Name;

            personalInfoModel.HKID = createPersonalInfoViewModel.HKID;


            //0,1,2
            if (createPersonalInfoViewModel.Sex.ToString() == "1")
            {
                personalInfoModel.Sex = 1;
            }
            else if (createPersonalInfoViewModel.Sex.ToString() == "2")
            {
                personalInfoModel.Sex = 2;
            }
            else
            {
                personalInfoModel.Sex = 0;
            }

            if (createPersonalInfoViewModel.DOB == "" || createPersonalInfoViewModel.DOB == null)
            {
                personalInfoModel.DOB = null;
            }
            else
            {
                personalInfoModel.DOB = DateTime.Parse(createPersonalInfoViewModel.DOB);
            }

            if (createPersonalInfoViewModel.AgeOnset == null)
            {
                personalInfoModel.AgeOnset = null;
            }
            else
            {
                personalInfoModel.AgeOnset = Double.Parse(createPersonalInfoViewModel.AgeOnset);
            }

            personalInfoModel.FamHis = createPersonalInfoViewModel.FamHis;

            personalInfoModel.AttnPhys = createPersonalInfoViewModel.AttnPhys;

            personalInfoModel.HisOthers = createPersonalInfoViewModel.HisOthers;

            if (createPersonalInfoViewModel.isIS == "")
            {
                personalInfoModel.isIso = false;
            }
            else
            {
                personalInfoModel.isIso = true;
            }

            if (createPersonalInfoViewModel.isCS == "")
            {
                personalInfoModel.isCTscan = false;
            }
            else
            {
                personalInfoModel.isCTscan = true;
            }

            //not know
            if (createPersonalInfoViewModel.isNM == "")
            {
                personalInfoModel.isMRI = false;
            }
            else
            {
                personalInfoModel.isMRI = true;
            }

            //not know
            if (createPersonalInfoViewModel.isMisc == "" || createPersonalInfoViewModel.isMisc == null)
            {
                personalInfoModel.isMilwaukes = false;
            }
            else
            {
                personalInfoModel.isMilwaukes = true;
            }

            personalInfoModel.DiagnosisMisc = createPersonalInfoViewModel.DiagnosisMisc;

            if (createPersonalInfoViewModel.isKingI == "" || createPersonalInfoViewModel.isKingI == null)
            {
                personalInfoModel.isKingI = false;
            }
            else
            {
                personalInfoModel.isKingI = true;
            }

            if (createPersonalInfoViewModel.isKingII == "" || createPersonalInfoViewModel.isKingII == null)
            {
                personalInfoModel.isKingII = false;
            }
            else
            {
                personalInfoModel.isKingII = true;
            }

            if (createPersonalInfoViewModel.isKingIII == "" || createPersonalInfoViewModel.isKingIII == null)
            {
                personalInfoModel.isKingIII = false;
            }
            else
            {
                personalInfoModel.isKingIII = true;
            }

            if (createPersonalInfoViewModel.isKingIV == "" || createPersonalInfoViewModel.isKingIV == null)
            {
                personalInfoModel.isKingIV = false;
            }
            else
            {
                personalInfoModel.isKingIV = true;
            }


            if (createPersonalInfoViewModel.isKingV == "" || createPersonalInfoViewModel.isKingV == null)
            {
                personalInfoModel.isKingV = false;
            }
            else
            {
                personalInfoModel.isKingV = true;
            }

            if (createPersonalInfoViewModel.isIso == "" || createPersonalInfoViewModel.isKingV == null)
            {
                personalInfoModel.isIso = false;
            }
            else
            {
                personalInfoModel.isIso = true;
            }

            if (createPersonalInfoViewModel.isTriple == "" || createPersonalInfoViewModel.isTriple == null)
            {
                personalInfoModel.isTriple = false;
            }
            else
            {
                personalInfoModel.isTriple = true;
            }

            if (createPersonalInfoViewModel.isTL == "" || createPersonalInfoViewModel.isTriple == null)
            {
                personalInfoModel.isTL = false;
            }
            else
            {
                personalInfoModel.isTL = true;
            }

            if (createPersonalInfoViewModel.isL == "" || createPersonalInfoViewModel.isTriple == null)
            {
                personalInfoModel.isL = false;
            }
            else
            {
                personalInfoModel.isL = true;
            }

            personalInfoModel.ADCA = createPersonalInfoViewModel.ADCA;

            if (createPersonalInfoViewModel.isUnderArm == "" || createPersonalInfoViewModel.isUnderArm == null)
            {
                personalInfoModel.isUnderArm = false;
            }
            else
            {
                personalInfoModel.isUnderArm = true;
            }

            if (createPersonalInfoViewModel.isMilwaukes == "" || createPersonalInfoViewModel.isMilwaukes == null)
            {
                personalInfoModel.isMilwaukes = false;
            }
            else
            {
                personalInfoModel.isMilwaukes = true;
            }

            if (createPersonalInfoViewModel.isBoston == "" || createPersonalInfoViewModel.isBoston == null)
            {
                personalInfoModel.isBoston = false;
            }
            else
            {
                personalInfoModel.isBoston = true;
            }

            if (createPersonalInfoViewModel.isBraceOthers == "" || createPersonalInfoViewModel.isBraceOthers == null)
            {
                personalInfoModel.isBraceOthers = false;
            }
            else
            {
                personalInfoModel.isBraceOthers = true;
            }

            personalInfoModel.BraceOthers = createPersonalInfoViewModel.BraceOthers;

            if (createPersonalInfoViewModel.BraceStart == "" || createPersonalInfoViewModel.BraceStart == null)
            {
                personalInfoModel.BraceStart = null;
            }
            else
            {
                personalInfoModel.BraceStart = DateTime.Parse(createPersonalInfoViewModel.BraceStart);
            }

            if (createPersonalInfoViewModel.BraceWean == "" || createPersonalInfoViewModel.BraceWean == null)
            {
                personalInfoModel.BraceWean = null;
            }
            else
            {
                personalInfoModel.BraceWean = DateTime.Parse(createPersonalInfoViewModel.BraceWean);
            }

            if (createPersonalInfoViewModel.BraceStop == "" || createPersonalInfoViewModel.BraceStop == null)
            {
                personalInfoModel.BraceStop = null;
            }
            else
            {
                personalInfoModel.BraceStop = DateTime.Parse(createPersonalInfoViewModel.BraceStop);
            }

            if (createPersonalInfoViewModel.ASF == "" || createPersonalInfoViewModel.ASF == null)
            {
                personalInfoModel.ASF = null;
            }
            else
            {
                personalInfoModel.ASF = DateTime.Parse(createPersonalInfoViewModel.ASF);
            }


            if (createPersonalInfoViewModel.PSF == "" || createPersonalInfoViewModel.PSF == null)
            {
                personalInfoModel.PSF = null;
            }
            else
            {
                personalInfoModel.PSF = DateTime.Parse(createPersonalInfoViewModel.PSF);
            }

            if (createPersonalInfoViewModel.ASFPSF == "" || createPersonalInfoViewModel.ASFPSF == null)
            {
                personalInfoModel.ASFPSF = null;
            }
            else
            {
                personalInfoModel.ASFPSF = DateTime.Parse(createPersonalInfoViewModel.ASFPSF);
            }

            if (createPersonalInfoViewModel.ThoRelease == "" || createPersonalInfoViewModel.ThoRelease == null)
            {
                personalInfoModel.ThoRelease = null;
            }
            else
            {
                personalInfoModel.ThoRelease = DateTime.Parse(createPersonalInfoViewModel.ThoRelease);
            }




            personalInfoModel.otherSurgery = createPersonalInfoViewModel.otherSurgery;

            personalInfoModel.HisOthers = createPersonalInfoViewModel.HisOthers;


            if (createPersonalInfoViewModel.LOFfrom == "" || createPersonalInfoViewModel.LOFfrom == null)
            {
                personalInfoModel.LOFfrom = null;
            }
            else
            {
                personalInfoModel.LOFfrom = createPersonalInfoViewModel.LOFfrom;
            }

            if (createPersonalInfoViewModel.LOFto == "" || createPersonalInfoViewModel.LOFto == null)
            {
                personalInfoModel.LOFto = null;
            }
            else
            {
                personalInfoModel.LOFto = createPersonalInfoViewModel.LOFto;
            }


            if (createPersonalInfoViewModel.isAuto == "" || createPersonalInfoViewModel.isAuto == null)
            {
                personalInfoModel.isAuto = false;
            }
            else
            {
                personalInfoModel.isAuto = true;
            }
             
            if (createPersonalInfoViewModel.isAllo == "" || createPersonalInfoViewModel.isAllo == null)
            {
                personalInfoModel.isAllo = false;
            }
            else
            {
                personalInfoModel.isAllo = true;
            }

            if (createPersonalInfoViewModel.isGraOthers == "" || createPersonalInfoViewModel.isGraOthers == null)
            {
                personalInfoModel.isGraOthers = false;
            }
            else
            {
                personalInfoModel.isGraOthers = true;
            }

            if (createPersonalInfoViewModel.isPosISOLA == "" || createPersonalInfoViewModel.isPosISOLA == null)
            {
                personalInfoModel.isPosISOLA = false;
            }
            else
            {
                personalInfoModel.isPosISOLA = true;
            }

            if (createPersonalInfoViewModel.isPostHarr == "" || createPersonalInfoViewModel.isPostHarr == null) 
            {
                personalInfoModel.isPostHarr = false;
            }
            else
            {
                personalInfoModel.isPostHarr = true;
            }

            if (createPersonalInfoViewModel.isPostCD == "" || createPersonalInfoViewModel.isPostCD == null)
            {
                personalInfoModel.isPostCD = false;
            }
            else
            {
                personalInfoModel.isPostCD = true;
            }

            if (createPersonalInfoViewModel.isPostOthers == "" || createPersonalInfoViewModel.isPostOthers == null)
            {
                personalInfoModel.isPostOthers = false;
            }
            else
            {
                personalInfoModel.isPostOthers = true;
            }

            if (createPersonalInfoViewModel.isAntZielke == "" || createPersonalInfoViewModel.isAntZielke == null)
            {
                personalInfoModel.isAntZielke = false;
            }
            else
            {
                personalInfoModel.isAntZielke = true;
            }

            if (createPersonalInfoViewModel.isAntOthers == "" || createPersonalInfoViewModel.isAntOthers == null)
            {
                personalInfoModel.isAntOthers = false;
            }
            else
            {
                personalInfoModel.isAntOthers = true;
            }

            if (createPersonalInfoViewModel.isAntISOLA == "")
            {
                personalInfoModel.isAntISOLA = false;
            }
            else
            {
                personalInfoModel.isAntISOLA = true;
            }

            createPersonalInfoViewModel.otherImplant = personalInfoModel.otherImplant;

            if (createPersonalInfoViewModel.PostOPStart == "" || createPersonalInfoViewModel.PostOPStart is null)
            {
                personalInfoModel.PostOPStart = null;
            }
            else
            {
                personalInfoModel.PostOPStart = DateTime.Parse(createPersonalInfoViewModel.PostOPStart);
            }

            if (createPersonalInfoViewModel.PostOPWean == "" || createPersonalInfoViewModel.PostOPWean is null)
            {
                personalInfoModel.PostOPWean = null;
            }
            else
            {
                personalInfoModel.PostOPWean = DateTime.Parse(createPersonalInfoViewModel.PostOPWean);
            }

            if (createPersonalInfoViewModel.PostOPStop == "" || createPersonalInfoViewModel.PostOPStop is null)
            {
                personalInfoModel.PostOPStop = null;
            }
            else
            {
                personalInfoModel.PostOPStop = DateTime.Parse(createPersonalInfoViewModel.PostOPStop);
            }

            if (createPersonalInfoViewModel.Surgeons == "" || createPersonalInfoViewModel.Surgeons is null)
            {
                personalInfoModel.Surgeons = "";
            }
            else
            {
                personalInfoModel.Surgeons = createPersonalInfoViewModel.Surgeons;
            }



            if (createPersonalInfoViewModel.isXrayfilm == "" || createPersonalInfoViewModel.isXrayfilm == null)
            {
                personalInfoModel.isXrayfilm = false; 
            }
            else
            {
                personalInfoModel.isXrayfilm = true;
            }

            if (createPersonalInfoViewModel.isMRI == "" || createPersonalInfoViewModel.isMRI == null)
            {
                personalInfoModel.isMRI = false;
            }
            else
            {
                personalInfoModel.isMRI = true;
            }

            if (createPersonalInfoViewModel.isDXA == "" || createPersonalInfoViewModel.isDXA == null)
            {
                personalInfoModel.isDXA = false;
            }
            else
            {
                personalInfoModel.isDXA = true;
            }

            if (createPersonalInfoViewModel.isUS == "" || createPersonalInfoViewModel.isUS == null)
            {
                personalInfoModel.isUS = false;
            }
            else
            {
                personalInfoModel.isUS = true;
            }

            if (createPersonalInfoViewModel.isPQCT == "" || createPersonalInfoViewModel.isPQCT == null)
            {
                personalInfoModel.isPQCT = false;
            }
            else
            {
                personalInfoModel.isPQCT = true;
            }

            if (createPersonalInfoViewModel.isCTscan == "" || createPersonalInfoViewModel.isCTscan == null)
            {
                personalInfoModel.isCTscan = false;
            }
            else
            {
                personalInfoModel.isCTscan = true;
            }

            if (createPersonalInfoViewModel.isBioChem == "" || createPersonalInfoViewModel.isBioChem == null)
            {
                personalInfoModel.isBioChem = false;
            }
            else
            {
                personalInfoModel.isBioChem = true;
            }

            if (createPersonalInfoViewModel.isQCT == "" || createPersonalInfoViewModel.isQCT == null)
            {
                personalInfoModel.isQCT = false;
            }
            else
            {
                personalInfoModel.isQCT = true;
            }

            if (createPersonalInfoViewModel.isSSEP == "" || createPersonalInfoViewModel.isSSEP == null)
            {
                personalInfoModel.isSSEP = false;
            }
            else
            {
                personalInfoModel.isSSEP = true;
            }

            if (createPersonalInfoViewModel.isEMG == "" || createPersonalInfoViewModel.isEMG == null)
            {
                personalInfoModel.isEMG = false;
            }
            else
            {
                personalInfoModel.isEMG = true;
            }

            personalInfoModel.OtherInvest = createPersonalInfoViewModel.OtherInvest;

            personalInfoModel.Comments = createPersonalInfoViewModel.Comments;


            //20200518 Add field
            personalInfoModel.Lenke1 = createPersonalInfoViewModel.Lenke1;
            personalInfoModel.Lenke2 = createPersonalInfoViewModel.Lenke2;
            personalInfoModel.Lenke3 = createPersonalInfoViewModel.Lenke3;



            return personalInfoModel;
        }


    }
}
