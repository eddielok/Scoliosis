using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Scoliosis.Models
{
    public class InfoPersonalInfoViewModel
    {
        public string SCN { get; set; }
        public string Name { get; set; }

        public string HKID { get; set; }

        public string Sex { get; set; }

        public string DOB { get; set; }

        public string AgeOnset { get; set; }

        public string FamHis { get; set; }

        public string AttnPhys { get; set; }

        public string HisOthers { get; set; }

        public string Diagnosis { get; set; }

        public string DiagnosisMisc { get; set; }

        public string isKingI { get; set; }

        public string isKingII { get; set; }

        public string isKingIII { get; set; }

        public string isKingIV { get; set; }

        public string isKingV { get; set; }

        public string isIso { get; set; }

        public string isIS { get; set; }

        public string isCS { get; set; }

        public string isNM { get; set; }

        public string isMisc { get; set; }


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


        public string Surgeons { get; set; }


        public string ASF { get; set; }


        public string PSF { get; set; }


        public string ASFPSF { get; set; }


        public string ThoRelease { get; set; }


        public string otherSurgery { get; set; }


        public string LOF { get; set; }


        public string LOFfrom { get; set; }

        public string LOFto { get; set; }

        public string isAuto { get; set; }


        public string isAllo { get; set; }


        public string isGraOthers { get; set; }


        public string isPosISOLA { get; set; }


        public string isPostCD { get; set; }


        public string isPostHarr { get; set; }


        public string isPostOthers { get; set; }


        public string isAntZielke { get; set; }


        public string isAntISOLA { get; set; }


        public string isAntOthers { get; set; }


        public string otherImplant { get; set; }


        public string PostOPStart { get; set; }


        public string PostOPWean { get; set; }


        public string PostOPStop { get; set; }


        public string isXrayfilm { get; set; }


        public string isMRI { get; set; }


        public string isDXA { get; set; }


        public string isSSEP { get; set; }

        public string isCTscan { get; set; }


        public string isBioChem { get; set; }


        public string isQCT { get; set; }


        public string isEMG { get; set; }


        public string isUS { get; set; }


        public string isPQCT { get; set; }


        public string OtherInvest { get; set; }


        public string Comments { get; set; }


        public string SpcRemarks { get; set; }



        public string LastModifyBy { get; set; }


        public string LastModify { get; set; }


        //20200518 Add field
        public string Lenke1 { get; set; }

        public string Lenke2 { get; set; }

        public string Lenke3 { get; set; }



        public static explicit operator PersonalInfoModel(InfoPersonalInfoViewModel infoPersonalInfoViewModel)
        {
            var personalInfoModel = new PersonalInfoModel();

            personalInfoModel.SCN = infoPersonalInfoViewModel.SCN ;

            personalInfoModel.HKID = infoPersonalInfoViewModel.HKID ;

            personalInfoModel.Name = infoPersonalInfoViewModel.Name;

            if (infoPersonalInfoViewModel.Sex == "0")
            {
                personalInfoModel.Sex = 0;
            }
            else if (infoPersonalInfoViewModel.Sex == "1")
            {
                personalInfoModel.Sex =  1;
            }
            else if (infoPersonalInfoViewModel.Sex == "2")
            {
                personalInfoModel.Sex = 2;
            }

            if (infoPersonalInfoViewModel.DOB ==null ||infoPersonalInfoViewModel.DOB == "")
            {
                personalInfoModel.DOB = null;
            }
            else
            {
                if (DateTime.TryParseExact(infoPersonalInfoViewModel.DOB, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result) == false)
                {
                    throw new Exception("DOB should dd/MM/yyyy");
                }

                personalInfoModel.DOB = DateTime.ParseExact(infoPersonalInfoViewModel.DOB, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }

            if (infoPersonalInfoViewModel.AgeOnset == null || infoPersonalInfoViewModel.AgeOnset == null)
            {
                personalInfoModel.AgeOnset = 0;
            }
            else
            {
                if (Double.TryParse(infoPersonalInfoViewModel.AgeOnset, out Double result) == false)
                {
                    throw new Exception("AgeOnset should be numeric, e.g. 0.00");
                }

                personalInfoModel.AgeOnset = Double.Parse(infoPersonalInfoViewModel.AgeOnset);
            }

            personalInfoModel.FamHis = infoPersonalInfoViewModel.FamHis ;

            personalInfoModel.AttnPhys = infoPersonalInfoViewModel.AttnPhys;

            personalInfoModel.HisOthers = infoPersonalInfoViewModel.HisOthers;

            personalInfoModel.DiagnosisMisc = infoPersonalInfoViewModel.DiagnosisMisc;


            if (infoPersonalInfoViewModel.isKingI == "true")
            {
                personalInfoModel.isKingI = true;
            }
            else
            {
                personalInfoModel.isKingI =false;
            }

            if (infoPersonalInfoViewModel.isKingII == "true")
            {
                personalInfoModel.isKingII = true;
            }
            else
            {
                personalInfoModel.isKingII = false;
            }


            if (infoPersonalInfoViewModel.isKingIII == "true")
            {
                personalInfoModel.isKingIII = true;
            }
            else
            {
                personalInfoModel.isKingIII = false;
            }

            if (infoPersonalInfoViewModel.isKingIV == "true")
            {
                personalInfoModel.isKingIV = true;
            }
            else
            {
                personalInfoModel.isKingIV = false;
            }

            if (infoPersonalInfoViewModel.isKingV == "true")
            {
                personalInfoModel.isKingV = true;
            }
            else
            {
                personalInfoModel.isKingV = false;
            }

            if (infoPersonalInfoViewModel.isIso == "true")
            {
                personalInfoModel.isIso = true;
            }
            else
            {
                personalInfoModel.isIso = false;
            }

            if (infoPersonalInfoViewModel.isTriple == "true")
            {
                personalInfoModel.isTriple = true;
            }
            else
            {
                personalInfoModel.isTriple = false;
            }

            if (infoPersonalInfoViewModel.isTL == "true")
            {
                personalInfoModel.isTL = true;
            }
            else
            {
                personalInfoModel.isTL = false;
            }

            if (infoPersonalInfoViewModel.isL == "true")
            {
                personalInfoModel.isL = true;
            }
            else
            {
                personalInfoModel.isL = false;
            }


            personalInfoModel.ADCA = infoPersonalInfoViewModel.ADCA ;


            if (infoPersonalInfoViewModel.isUnderArm == "true")
            {
                personalInfoModel.isUnderArm = true;
            }
            else
            {
                personalInfoModel.isUnderArm = false;
            }

            if (infoPersonalInfoViewModel.isMilwaukes == "true")
            {
                personalInfoModel.isMilwaukes = true;
            }
            else
            {
                personalInfoModel.isMilwaukes = false;
            }

            if (infoPersonalInfoViewModel.isBoston == "true")
            {
                personalInfoModel.isBoston = true;
            }
            else
            {
                personalInfoModel.isBoston = false;
            }


            if (infoPersonalInfoViewModel.isBraceOthers == "true")
            {
                personalInfoModel.isBraceOthers = true;
            }
            else
            {
                personalInfoModel.isBraceOthers = false;
            }


            personalInfoModel.BraceOthers = infoPersonalInfoViewModel.BraceOthers ;

            if (infoPersonalInfoViewModel.BraceStart == null || infoPersonalInfoViewModel.BraceStart == "")
            {
                personalInfoModel.BraceStart = null;
            }
            else
            {
                if (DateTime.TryParseExact(infoPersonalInfoViewModel.BraceStart, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result) == false)
                {
                    throw new Exception("BraceStart should be dd/MM/yyyy");
                }

                personalInfoModel.BraceStart = DateTime.ParseExact(infoPersonalInfoViewModel.BraceStart, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }

            if (infoPersonalInfoViewModel.BraceWean == null ||  infoPersonalInfoViewModel.BraceWean == "")
            {
                personalInfoModel.BraceWean = null;
            }
            else
            {
                personalInfoModel.BraceWean = DateTime.ParseExact(infoPersonalInfoViewModel.BraceWean, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }

            if (infoPersonalInfoViewModel.BraceStop == null || infoPersonalInfoViewModel.BraceStop == "")
            {
                personalInfoModel.BraceStop = null;
            }
            else
            {
                if (DateTime.TryParseExact(infoPersonalInfoViewModel.BraceStop, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result) == false)
                {
                    throw new Exception("BraceStop should be dd/MM/yyyy");
                }

                personalInfoModel.BraceStop = DateTime.ParseExact(infoPersonalInfoViewModel.BraceStop, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }


            personalInfoModel.Surgeons = personalInfoModel.Surgeons;


            if (infoPersonalInfoViewModel.ASF == null || infoPersonalInfoViewModel.ASF == "")
            {
                personalInfoModel.ASF = null;
            }
            else
            {
                if (DateTime.TryParseExact(infoPersonalInfoViewModel.ASF, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result) == false)
                {
                    throw new Exception("ASF should be dd/MM/yyyy");
                }

                personalInfoModel.ASF = DateTime.ParseExact(infoPersonalInfoViewModel.ASF, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }

            if (infoPersonalInfoViewModel.PSF == null || infoPersonalInfoViewModel.PSF == "")
            {
                personalInfoModel.PSF = null ;
            }
            else
            {

                if (DateTime.TryParseExact(infoPersonalInfoViewModel.PSF, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result) == false)
                {
                    throw new Exception("PSF should be dd/MM/yyyy");
                }

                personalInfoModel.PSF = DateTime.ParseExact(infoPersonalInfoViewModel.PSF, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }

            if (infoPersonalInfoViewModel.ASFPSF == null || infoPersonalInfoViewModel.ASFPSF == "")
            {
                personalInfoModel.ASFPSF = null;
            }
            else
            {
                if (DateTime.TryParseExact(infoPersonalInfoViewModel.ASFPSF, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result) == false)
                {
                    throw new Exception("ASFPSF should be dd/MM/yyyy");
                }

                personalInfoModel.ASFPSF = DateTime.ParseExact(infoPersonalInfoViewModel.ASFPSF, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }

            if (infoPersonalInfoViewModel.ThoRelease == null || infoPersonalInfoViewModel.ThoRelease == "")
            {
                personalInfoModel.ThoRelease = null;
            }
            else
            {
                if (DateTime.TryParseExact(infoPersonalInfoViewModel.ThoRelease, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result) == false)
                {
                    throw new Exception("ThoRelease should be dd/MM/yyyy");
                }

                personalInfoModel.ThoRelease = DateTime.ParseExact(infoPersonalInfoViewModel.ThoRelease, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }

            personalInfoModel.otherSurgery = infoPersonalInfoViewModel.otherSurgery;

            personalInfoModel.LOFfrom = infoPersonalInfoViewModel.LOFfrom;

            personalInfoModel.LOFto = infoPersonalInfoViewModel.LOFto;



            if (infoPersonalInfoViewModel.isAuto == "true")
            {
                personalInfoModel.isAuto = true;
            }
            else
            {
                personalInfoModel.isAuto = false;
            }



            if (infoPersonalInfoViewModel.isAllo == "true")
            {
                personalInfoModel.isAllo = true;
            }
            else
            {
                personalInfoModel.isAllo = false;
            }

            if (infoPersonalInfoViewModel.isGraOthers == "true")
            {
                personalInfoModel.isGraOthers = true;
            }
            else
            {
                personalInfoModel.isGraOthers = false;
            }

            if (infoPersonalInfoViewModel.isPosISOLA == "true")
            {
                personalInfoModel.isPosISOLA = true;
            }
            else
            {
                personalInfoModel.isPosISOLA = false;
            }

            if (infoPersonalInfoViewModel.isPostHarr == "true")
            {
                personalInfoModel.isPostHarr = true;
            }
            else
            {
                personalInfoModel.isPostHarr = false;
            }

            if (infoPersonalInfoViewModel.isPostCD == "true")
            {
                personalInfoModel.isPostCD = true;
            }
            else
            {
                personalInfoModel.isPostCD = false;
            }

            if (infoPersonalInfoViewModel.isPostOthers == "true")
            {
                personalInfoModel.isPostOthers = true;
            }
            else
            {
                personalInfoModel.isPostOthers = false;
            }


            if (infoPersonalInfoViewModel.isAntZielke == "true")
            {
                personalInfoModel.isAntZielke = true;
            }
            else
            {
                personalInfoModel.isAntZielke = false;
            }

            if (infoPersonalInfoViewModel.isAntOthers == "true")
            {
                personalInfoModel.isAntOthers = true;
            }
            else
            {
                personalInfoModel.isAntOthers = false;
            }

            if (infoPersonalInfoViewModel.isAntISOLA == "true")
            {
                personalInfoModel.isAntISOLA = true;
            }
            else
            {
                personalInfoModel.isAntISOLA = false;
            }

            personalInfoModel.otherImplant = infoPersonalInfoViewModel.otherImplant ;

            if (infoPersonalInfoViewModel.PostOPStart == null || infoPersonalInfoViewModel.PostOPStart == "")
            {
                personalInfoModel.PostOPStart = null;
            }
            else
            {
                if (DateTime.TryParseExact(infoPersonalInfoViewModel.PostOPStart, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result) == false)
                {
                    throw new Exception("PostOPStart should be dd/MM/yyyy");
                }

                personalInfoModel.PostOPStart = DateTime.ParseExact(infoPersonalInfoViewModel.PostOPStart, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }

            if (infoPersonalInfoViewModel.PostOPWean == null || infoPersonalInfoViewModel.PostOPWean == null)
            {
                personalInfoModel.PostOPWean = null;
            }
            else
            {
                if (DateTime.TryParseExact(infoPersonalInfoViewModel.PostOPWean, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result) == false)
                {
                    throw new Exception("PostOPWean should be dd/MM/yyyy");
                }

                personalInfoModel.PostOPWean = DateTime.ParseExact(infoPersonalInfoViewModel.PostOPWean, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }

            if (infoPersonalInfoViewModel.PostOPStop == null || infoPersonalInfoViewModel.PostOPStop == "")
            {
                personalInfoModel.PostOPStop = null;
            }
            else
            {

                if (DateTime.TryParseExact(infoPersonalInfoViewModel.PostOPStop, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result) == false)
                {
                    throw new Exception("PostOPStop should be dd/MM/yyyy");
                }

                personalInfoModel.PostOPStop = DateTime.ParseExact(infoPersonalInfoViewModel.PostOPStop, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }


            if (infoPersonalInfoViewModel.isXrayfilm == "true")
            {
                personalInfoModel.isXrayfilm = true;
            }
            else
            {
                personalInfoModel.isXrayfilm = false;
            }

            if (infoPersonalInfoViewModel.isMRI == "true")
            {
                personalInfoModel.isMRI = true;
            }
            else
            {
                personalInfoModel.isMRI = false;
            }

            if (infoPersonalInfoViewModel.isDXA == "true")
            {
                personalInfoModel.isDXA = true;
            }
            else
            {
                personalInfoModel.isDXA = false;
            }

            if (infoPersonalInfoViewModel.isUS == "true")
            {
                personalInfoModel.isUS = true;
            }
            else
            {
                personalInfoModel.isUS = false;
            }

            if (infoPersonalInfoViewModel.isCTscan == "true")
            {
                personalInfoModel.isCTscan = true;
            }
            else
            {
                personalInfoModel.isCTscan = false;
            }

            if (infoPersonalInfoViewModel.isBioChem == "true")
            {
                personalInfoModel.isBioChem = true;
            }
            else
            {
                personalInfoModel.isBioChem = false;
            }

            if (infoPersonalInfoViewModel.isQCT == "true")
            {
                personalInfoModel.isQCT = true;
            }
            else
            {
                personalInfoModel.isQCT = false;
            }

            if (infoPersonalInfoViewModel.isSSEP == "true")
            {
                personalInfoModel.isSSEP = true;
            }
            else
            {
                personalInfoModel.isSSEP = false;
            }

            if (infoPersonalInfoViewModel.isEMG == "true")
            {
                personalInfoModel.isEMG = true;
            }
            else
            {
                personalInfoModel.isEMG = false;
            }

            personalInfoModel.OtherInvest = infoPersonalInfoViewModel.OtherInvest ;

            personalInfoModel.Comments = infoPersonalInfoViewModel.Comments ;


            //20200518 Add Field
            personalInfoModel.Lenke1 = infoPersonalInfoViewModel.Lenke1 ;
            personalInfoModel.Lenke2 = infoPersonalInfoViewModel.Lenke2 ;
            personalInfoModel.Lenke3 = infoPersonalInfoViewModel.Lenke3 ;

            return personalInfoModel;
        }
    }



}
