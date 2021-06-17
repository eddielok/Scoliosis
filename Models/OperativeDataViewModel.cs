using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;


namespace Scoliosis.Models
{
    public class OperativeDataViewModel
    {

        [Required]
        [Key]
        public string SCN { get; set; }
        public Int16 RecordID { get; set; }
        public string PreRisserS { get; set; }
        public Nullable<double> PreHeightF { get; set; }
        public Nullable<double> PreArmSpanF { get; set; }
        public Nullable<double> PreWeightF { get; set; }
        public Nullable<double> PreSittingF { get; set; }
        public Nullable<char> PreARankS { get; set; }
        public Nullable<char> PreASideS { get; set; }
        public string PreALevelFromS { get; set; }
        public string PreALevelToS { get; set; }
        public string PreAApexS { get; set; }
        public Nullable<double> PreACobbsAngleF { get; set; }
        public Nullable<double> PreAFulcrumF { get; set; }
        public Nullable<double> PreABendingF { get; set; }
        public Nullable<char> PreBRankS { get; set; }
        public Nullable<char> PreBSideS { get; set; }
        public string PreBLevelFromS { get; set; }
        public string PreBLevelToS { get; set; }
        public string PreBApexS { get; set; }
        public Nullable<double> PreBCobbsAngleF { get; set; }
        public Nullable<double> PreBFulcrumF { get; set; }
        public Nullable<double> PreBBendingF { get; set; }
        public Nullable<char> PreCRankS { get; set; }
        public Nullable<char> PreCSideS { get; set; }
        public string PreCLevelFromS { get; set; }
        public string PreCLevelToS { get; set; }
        public string PreCApexS { get; set; }
        public Nullable<double> PreCCobbsAngleF { get; set; }
        public Nullable<double> PreCFulcrumF { get; set; }
        public Nullable<double> PreCBendingF { get; set; }
        public Nullable<char> PreDRankS { get; set; }
        public Nullable<char> PreDSideS { get; set; }
        public string PreDLevelFromS { get; set; }
        public string PreDLevelToS { get; set; }
        public string PreDApexS { get; set; }
        public Nullable<double> PreDCobbsAngleF { get; set; }
        public Nullable<double> PreDFulcrumF { get; set; }
        public Nullable<double> PreDBendingF { get; set; }
        public Nullable<char> PreMRIR { get; set; }
        public string PreMRIT { get; set; }
        public Nullable<double> PreSSEPRF { get; set; }
        public Nullable<double> PreSSEPLF { get; set; }
        public Nullable<double> PreSSEPRP37F { get; set; }
        public Nullable<double> PreSSEPRN45F { get; set; }
        public Nullable<double> PreSSEPLP37F { get; set; }
        public Nullable<double> PreSSEPLN45F { get; set; }
        public Nullable<double> PreLumbarF { get; set; }
        public Nullable<double> PreZScoreF { get; set; }
        public Nullable<double> PreRBMDF { get; set; }
        public Nullable<double> PreRZScoreF { get; set; }
        public Nullable<double> PreLBMDF { get; set; }
        public Nullable<double> PreLZScoreF { get; set; }
        public Nullable<double> PreTibiaRD50F { get; set; }
        public Nullable<double> PreTibiaLD50F { get; set; }
        public Nullable<double> PreTibiaRD100F { get; set; }
        public Nullable<double> PreTibiaLD100F { get; set; }
        public Nullable<double> PreRadiusRD50F { get; set; }
        public Nullable<double> PreRadiusLD50F { get; set; }
        public Nullable<double> PreRadiusRD100F { get; set; }
        public Nullable<double> PreRadiusLD100F { get; set; }
        public Nullable<double> PreFVCPredictionF { get; set; }
        public Nullable<double> PreFVCObservedF { get; set; }
        public Nullable<double> PreFEV1PredictionF { get; set; }
        public Nullable<double> PreFEV1ObservedF { get; set; }
        public string PreECGT { get; set; }
        public Nullable<double> PreINRF { get; set; }
        public Nullable<double> PrePTF { get; set; }
        public Nullable<double> PreaPTTF { get; set; }
        public Nullable<double> PrePlateletF { get; set; }
        public string PreCommentsA { get; set; }
        public Nullable<DateTime> PlanDateD { get; set; }
        public string PlanDoctorS { get; set; }
        public Nullable<char> PlanARankS { get; set; }
        public Nullable<char> PlanASideS { get; set; }
        public string PlanALevelFromS { get; set; }
        public string PlanALevelToS { get; set; }
        public string PlanAApexS { get; set; }
        public Nullable<double> PlanACobbsAngleF { get; set; }
        public Nullable<double> PlanAFulcrumF { get; set; }
        public Nullable<double> PlanABendingF { get; set; }
        public Nullable<char> PlanBRankS { get; set; }
        public Nullable<char> PlanBSideS { get; set; }
        public string PlanBLevelFromS { get; set; }
        public string PlanBLevelToS { get; set; }
        public string PlanBApexS { get; set; }
        public Nullable<double> PlanBCobbsAngleF { get; set; }
        public Nullable<double> PlanBFulcrumF { get; set; }
        public Nullable<double> PlanBBendingF { get; set; }
        public Nullable<char> PlanCRankS { get; set; }
        public Nullable<char> PlanCSideS { get; set; }
        public string PlanCLevelFromS { get; set; }
        public string PlanCLevelToS { get; set; }
        public string PlanCApexS { get; set; }
        public Nullable<double> PlanCCobbsAngleF { get; set; }
        public Nullable<double> PlanCFulcrumF { get; set; }
        public Nullable<double> PlanCBendingF { get; set; }
        public Nullable<char> PlanDRankS { get; set; }
        public Nullable<char> PlanDSideS { get; set; }
        public string PlanDLevelFromS { get; set; }
        public string PlanDLevelToS { get; set; }
        public string PlanDApexS { get; set; }
        public Nullable<double> PlanDCobbsAngleF { get; set; }
        public Nullable<double> PlanDFulcrumF { get; set; }
        public Nullable<double> PlanDBendingF { get; set; }
        public string PlanRisserS { get; set; }
        public Nullable<char> PlanPriorityR { get; set; }
        public Nullable<char> PlanMRIR { get; set; }
        public string PlanMRISpecifyT { get; set; }
        public string PlanMRIActionT { get; set; }
        public Nullable<char> PlanClottingR { get; set; }
        public string PlanClottingSpecifyT { get; set; }
        public string PlanClottingActionT { get; set; }
        public Nullable<char> PlanCardiacR { get; set; }
        public string PlanCardiacSpecifyT { get; set; }
        public string PlanCardiacActionT { get; set; }
        public Nullable<char> PlanRespR { get; set; }
        public string PlanRespSpecifyT { get; set; }
        public string PlanRespActionT { get; set; }
        public Nullable<char> PlanSSEPR { get; set; }
        public string PlanSSEPSpecifyT { get; set; }
        public string PlanSSEPActionT { get; set; }
        public Nullable<char> PlanHaloR { get; set; }
        public Nullable<bool> PlanASFC { get; set; }
        public string PlanASFLevelFromS { get; set; }
        public string PlanASFLevelToS { get; set; }
        public Nullable<bool> PlanASFHZC { get; set; }
        public Nullable<bool> PlanASFIsolaC { get; set; }
        public Nullable<bool> PlanASFOthersC { get; set; }
        public string PlanASFOthersT { get; set; }
        public Nullable<char> PlanASFBoneR { get; set; }
        public string PlanASFBoneOtherT { get; set; }
        public Nullable<bool> PlanPSFC { get; set; }
        public string PlanPSFLevelFromS { get; set; }
        public string PlanPSFLevelToS { get; set; }
        public Nullable<bool> PlanPSFHarringtonC { get; set; }
        public Nullable<bool> PlanPSFLuqueC { get; set; }
        public Nullable<bool> PlanPSFWisconsinC { get; set; }
        public Nullable<bool> PlanPSFCDC { get; set; }
        public Nullable<bool> PlanPSFIsolaC { get; set; }
        public Nullable<bool> PlanPSFOthersC { get; set; }
        public string PlanPSFOthersT { get; set; }
        public Nullable<char> PlanPSFBoneR { get; set; }
        public string PlanPSFBoneOtherT { get; set; }
        public Nullable<bool> PlanVATC { get; set; }
        public string PlanVATLevelFromS { get; set; }
        public string PlanVATLevelToS { get; set; }
        public Nullable<bool> PlanVATYesC { get; set; }
        public string PlanVATYesT { get; set; }
        public Nullable<char> PlanVATBoneR { get; set; }
        public string PlanVATBoneOtherT { get; set; }
        public string PlanRemarksA { get; set; }
        public Nullable<DateTime> IntraDateD { get; set; }
        public string IntraAnaesthetistT { get; set; }
        public Nullable<double> IntraDurationF { get; set; }
        public Nullable<double> IntraNonSaverF { get; set; }
        public Nullable<char> IntraSaverR { get; set; }
        public Nullable<double> IntraSaverF { get; set; }
        public Nullable<double> IntraAutoOutF { get; set; }
        public Nullable<double> IntraAutologousF { get; set; }
        public Nullable<double> IntraAutoInF { get; set; }
        public Nullable<double> IntraWholeBloodF { get; set; }
        public Nullable<double> IntraPackedCellF { get; set; }
        public Nullable<double> IntraCrystalloidF { get; set; }
        public Nullable<double> IntraColloidF { get; set; }
        public Nullable<double> IntraPlateletF { get; set; }
        public Nullable<double> IntraFFPF { get; set; }
        public Nullable<char> IntraAntibioticsR { get; set; }
        public string IntraAntibioticsT { get; set; }
        public string ProChiefS { get; set; }
        public string ProAssistant1S { get; set; }
        public string ProAssistant2S { get; set; }
        public string ProAssistant3S { get; set; }
        public string ProSurgeonOthersT { get; set; }
        public Nullable<char> ProPosteriorLevelR { get; set; }
        public string ProPosteriorFromS { get; set; }
        public string ProPosteriorToS { get; set; }
        public Nullable<Int16> ProPosteriorLevelF { get; set; }
        public Nullable<bool> ProPHarringtonC { get; set; }
        public Nullable<bool> ProPLuqueC { get; set; }
        public Nullable<bool> ProPWisconsinC { get; set; }
        public Nullable<bool> ProPCDC { get; set; }
        public Nullable<bool> ProPIsolaC { get; set; }
        public Nullable<bool> ProPOthersC { get; set; }
        public string ProPOthersT { get; set; }
        public Nullable<char> ProAnteriorLevelR { get; set; }
        public string ProAnteriorFromS { get; set; }
        public string ProAnteriorToS { get; set; }
        public Nullable<Int16> ProAnteriorLevelF { get; set; }
        public Nullable<bool> ProAZielkeC { get; set; }
        public Nullable<bool> ProAHalmC { get; set; }
        public Nullable<bool> ProAIsolaC { get; set; }
        public Nullable<bool> ProAOthersC { get; set; }
        public string ProAOthersT { get; set; }
        public Nullable<char> ProThoracoscopicR { get; set; }
        public string ProSurgeonT { get; set; }
        public string ProThoracoscopicFromT { get; set; }
        public string ProThoracoscopicToT { get; set; }
        public string ProThoracoscopicSideS { get; set; }
        public Nullable<char> ProBoneR { get; set; }
        public Nullable<bool> ProAutologousC { get; set; }
        public Nullable<double> ProAutologousF { get; set; }
        public Nullable<bool> ProAllograftC { get; set; }
        public Nullable<double> ProAllograftF { get; set; }
        public Nullable<bool> ProBoneOthersC { get; set; }
        public string ProBoneOthersT { get; set; }
        public Nullable<char> ProWakeR { get; set; }
        public string ProWakeT { get; set; }
        public Nullable<char> ProSSEPR { get; set; }
        public string ProSSEPT { get; set; }
        public Nullable<char> ProMEPR { get; set; }
        public string ProMEPT { get; set; }
        public string ProImplantA { get; set; }
        public string ProOthersA { get; set; }
        public string ProRemarkA { get; set; }
        public Nullable<double> PostTransfusionWholeF { get; set; }
        public Nullable<double> PostTransfusionPackedF { get; set; }
        public Nullable<double> PostLastHbF { get; set; }
        public Nullable<double> PostLastHbDayF { get; set; }
        public Nullable<double> PostPreOpHbF { get; set; }
        public Nullable<double> PostPlateletF { get; set; }
        public Nullable<double> PostFFPF { get; set; }
        public Nullable<Int16> PostDaysF { get; set; }
        public Nullable<char> PostBracingR { get; set; }
        public string PostBracingT { get; set; }
        public string PostComplicationA { get; set; }
        public Nullable<bool> PostWithBraceC { get; set; }
        public Nullable<char> PostACobbsF { get; set; }
        public Nullable<double> PostAPreAVTF { get; set; }
        public Nullable<char> PostAPreAVTS { get; set; }
        public Nullable<double> PostAPostAVTF { get; set; }
        public Nullable<char> PostAPostAVTS { get; set; }
        public string PostBCobbsF { get; set; }
        public Nullable<double> PostBPreAVTF { get; set; }
        public Nullable<char> PostBPreAVTS { get; set; }
        public Nullable<double> PostBPostAVTF { get; set; }
        public Nullable<char> PostBPostAVTS { get; set; }
        public string PostCCobbsF { get; set; }
        public Nullable<double> PostCPreAVTF { get; set; }
        public Nullable<char> PostCPreAVTS { get; set; }
        public Nullable<double> PostCPostAVTF { get; set; }
        public Nullable<char> PostCPostAVTS { get; set; }
        public string PostDCobbsF { get; set; }
        public Nullable<double> PostDPreAVTF { get; set; }
        public Nullable<char> PostDPreAVTS { get; set; }
        public Nullable<double> PostDPostAVTF { get; set; }
        public Nullable<char> PostDPostAVTS { get; set; }
        public Nullable<double> PostPreOpTrunkF { get; set; }
        public Nullable<char> PostPreOpTrunkS { get; set; }
        public Nullable<double> PostPostOpTrunkF { get; set; }
        public Nullable<char> PostPostOpTrunkS { get; set; }
        public Nullable<double> PostUpperF { get; set; }
        public Nullable<char> PostUpperS { get; set; }
        public Nullable<double> PostLowerF { get; set; }
        public Nullable<char> PostLowerS { get; set; }
        public string PostRemarkA { get; set; }

        public static explicit operator InfoOperativeDataListViewModel(OperativeDataViewModel operativeDataViewModel)
        {
            var infoOperativeDataListViewModel = new InfoOperativeDataListViewModel();

            infoOperativeDataListViewModel.RecordID = operativeDataViewModel.RecordID;

            infoOperativeDataListViewModel.SCN = operativeDataViewModel.SCN;

            if (operativeDataViewModel.IntraDateD != null)
            {
                infoOperativeDataListViewModel.IntraDateD = operativeDataViewModel.IntraDateD.Value.ToString("yyyy-MM-dd");
            }
            else {
                infoOperativeDataListViewModel.IntraDateD = "";
            }

            

            return infoOperativeDataListViewModel;

        }


        public static explicit operator InfoOperativeDataViewModel(OperativeDataViewModel operativeDataViewModel)
        {
            var infoOperativeDataViewModel = new InfoOperativeDataViewModel();

            infoOperativeDataViewModel.SCN = operativeDataViewModel.SCN;
            infoOperativeDataViewModel.RecordID = operativeDataViewModel.RecordID;

            if (operativeDataViewModel.PreRisserS == null)
            {
                infoOperativeDataViewModel.PreRisserS = "";
            }
            else
            {
                infoOperativeDataViewModel.PreRisserS = operativeDataViewModel.PreRisserS;
            }

            if (operativeDataViewModel.PreHeightF == null)
            {
                infoOperativeDataViewModel.PreHeightF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreHeightF = operativeDataViewModel.PreHeightF.Value.ToString();
            }


            if (operativeDataViewModel.PreArmSpanF == null)
            {
                infoOperativeDataViewModel.PreArmSpanF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreArmSpanF = operativeDataViewModel.PreArmSpanF.Value.ToString();
            }

            if (operativeDataViewModel.PreWeightF == null)
            {
                infoOperativeDataViewModel.PreWeightF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreWeightF = operativeDataViewModel.PreWeightF.Value.ToString();
            }

            if (operativeDataViewModel.PreSittingF == null)
            {
                infoOperativeDataViewModel.PreSittingF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreSittingF = operativeDataViewModel.PreSittingF.Value.ToString();
            }

            if (operativeDataViewModel.PreSittingF == null)
            {
                infoOperativeDataViewModel.PreSittingF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreSittingF = operativeDataViewModel.PreSittingF.Value.ToString();
            }

            if (operativeDataViewModel.PreARankS == null)
            {
                infoOperativeDataViewModel.PreARankS = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreARankS = operativeDataViewModel.PreARankS.Value.ToString();
            }


            if (operativeDataViewModel.PreASideS == null)
            {
                infoOperativeDataViewModel.PreASideS = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreASideS = operativeDataViewModel.PreASideS.Value.ToString();
            }


            if (operativeDataViewModel.PreALevelFromS == null)
            {
                infoOperativeDataViewModel.PreALevelFromS = "";
            }
            else
            {
                infoOperativeDataViewModel.PreALevelFromS = operativeDataViewModel.PreALevelFromS;
            }


            if (operativeDataViewModel.PreALevelToS == null)
            {
                infoOperativeDataViewModel.PreALevelToS = "";
            }
            else
            {
                infoOperativeDataViewModel.PreALevelToS = operativeDataViewModel.PreALevelToS;
            }

            if (operativeDataViewModel.PreAApexS == null)
            {
                infoOperativeDataViewModel.PreAApexS = "";
            }
            else
            {
                infoOperativeDataViewModel.PreAApexS = operativeDataViewModel.PreAApexS;
            }

            if (operativeDataViewModel.PreACobbsAngleF == null)
            {
                infoOperativeDataViewModel.PreACobbsAngleF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreACobbsAngleF = operativeDataViewModel.PreACobbsAngleF.Value.ToString();
            }

            if (operativeDataViewModel.PreAFulcrumF == null)
            {
                infoOperativeDataViewModel.PreAFulcrumF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreAFulcrumF = operativeDataViewModel.PreAFulcrumF.Value.ToString();
            }

            if (operativeDataViewModel.PreABendingF == null)
            {
                infoOperativeDataViewModel.PreABendingF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreABendingF = operativeDataViewModel.PreABendingF.Value.ToString();
            }

            if (operativeDataViewModel.PreBRankS == null)
            {
                infoOperativeDataViewModel.PreBRankS = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreBRankS = operativeDataViewModel.PreBRankS.Value.ToString();
            }

            if (operativeDataViewModel.PreBSideS == null)
            {
                infoOperativeDataViewModel.PreBSideS = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreBSideS = operativeDataViewModel.PreBSideS.Value.ToString();
            }


            if (operativeDataViewModel.PreBLevelFromS == null)
            {
                infoOperativeDataViewModel.PreBLevelFromS = "";
            }
            else
            {
                infoOperativeDataViewModel.PreBLevelFromS = operativeDataViewModel.PreBLevelFromS;
            }


            if (operativeDataViewModel.PreBLevelToS == null)
            {
                infoOperativeDataViewModel.PreBLevelToS = "";
            }
            else
            {
                infoOperativeDataViewModel.PreBLevelToS = operativeDataViewModel.PreBLevelToS;
            }

            if (operativeDataViewModel.PreBApexS == null)
            {
                infoOperativeDataViewModel.PreBApexS = "";
            }
            else
            {
                infoOperativeDataViewModel.PreBApexS = operativeDataViewModel.PreBApexS;
            }



            if (operativeDataViewModel.PreBCobbsAngleF == null)
            {
                infoOperativeDataViewModel.PreBCobbsAngleF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreBCobbsAngleF = operativeDataViewModel.PreBCobbsAngleF.Value.ToString();
            }

            if (operativeDataViewModel.PreBFulcrumF == null)
            {
                infoOperativeDataViewModel.PreBFulcrumF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreBFulcrumF = operativeDataViewModel.PreBFulcrumF.Value.ToString();
            }

            if (operativeDataViewModel.PreBBendingF == null)
            {
                infoOperativeDataViewModel.PreBBendingF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreBBendingF = operativeDataViewModel.PreBBendingF.Value.ToString();
            }

            if (operativeDataViewModel.PreCRankS == null)
            {
                infoOperativeDataViewModel.PreCRankS = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreCRankS = operativeDataViewModel.PreCRankS.Value.ToString();
            }

            if (operativeDataViewModel.PreCSideS == null)
            {
                infoOperativeDataViewModel.PreCSideS = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreCSideS = operativeDataViewModel.PreCSideS.Value.ToString();
            }

            if (operativeDataViewModel.PreCLevelFromS == null)
            {
                infoOperativeDataViewModel.PreCLevelFromS = "";
            }
            else
            {
                infoOperativeDataViewModel.PreCLevelFromS = operativeDataViewModel.PreCLevelFromS;
            }

            if (operativeDataViewModel.PreCLevelToS == null)
            {
                infoOperativeDataViewModel.PreCLevelToS = "";
            }
            else
            {
                infoOperativeDataViewModel.PreCLevelToS = operativeDataViewModel.PreCLevelToS;
            }

            if (operativeDataViewModel.PreCApexS == null)
            {
                infoOperativeDataViewModel.PreCApexS = "";
            }
            else
            {
                infoOperativeDataViewModel.PreCApexS = operativeDataViewModel.PreCApexS;
            }

            if (operativeDataViewModel.PreCCobbsAngleF == null)
            {
                infoOperativeDataViewModel.PreCCobbsAngleF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreCCobbsAngleF = operativeDataViewModel.PreCCobbsAngleF.Value.ToString();
            }

            if (operativeDataViewModel.PreCFulcrumF == null)
            {
                infoOperativeDataViewModel.PreCFulcrumF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreCFulcrumF = operativeDataViewModel.PreCFulcrumF.Value.ToString();
            }

            if (operativeDataViewModel.PreCBendingF == null)
            {
                infoOperativeDataViewModel.PreCBendingF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreCBendingF = operativeDataViewModel.PreCBendingF.Value.ToString();
            }

            if (operativeDataViewModel.PreDRankS == null)
            {
                infoOperativeDataViewModel.PreDRankS = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreDRankS = operativeDataViewModel.PreDRankS.Value.ToString();
            }

            if (operativeDataViewModel.PreDSideS == null)
            {
                infoOperativeDataViewModel.PreDSideS = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreDSideS = operativeDataViewModel.PreDSideS.Value.ToString();
            }


            if (operativeDataViewModel.PreDLevelFromS == null)
            {
                infoOperativeDataViewModel.PreDLevelFromS = "";
            }
            else
            {
                infoOperativeDataViewModel.PreDLevelFromS = operativeDataViewModel.PreDLevelFromS;
            }

            if (operativeDataViewModel.PreDLevelToS == null)
            {
                infoOperativeDataViewModel.PreDLevelToS = "";
            }
            else
            {
                infoOperativeDataViewModel.PreDLevelToS = operativeDataViewModel.PreDLevelToS;
            }

            if (operativeDataViewModel.PreDApexS == null)
            {
                infoOperativeDataViewModel.PreDApexS = "";
            }
            else
            {
                infoOperativeDataViewModel.PreDApexS = operativeDataViewModel.PreDApexS;
            }


            if (operativeDataViewModel.PreDCobbsAngleF == null)
            {
                infoOperativeDataViewModel.PreDCobbsAngleF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreDCobbsAngleF = operativeDataViewModel.PreDCobbsAngleF.Value.ToString();
            }


            if (operativeDataViewModel.PreDFulcrumF == null)
            {
                infoOperativeDataViewModel.PreDFulcrumF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreDFulcrumF = operativeDataViewModel.PreDFulcrumF.Value.ToString();
            }

            if (operativeDataViewModel.PreDBendingF == null)
            {
                infoOperativeDataViewModel.PreDBendingF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreDBendingF = operativeDataViewModel.PreDBendingF.Value.ToString();
            }

            if (operativeDataViewModel.PreMRIR == null)
            {
                infoOperativeDataViewModel.PreMRIR = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreMRIR = operativeDataViewModel.PreMRIR.Value.ToString();
            }

            infoOperativeDataViewModel.PreMRIT = operativeDataViewModel.PreMRIT;

            if (operativeDataViewModel.PreSSEPRF == null)
            {
                infoOperativeDataViewModel.PreSSEPRF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreSSEPRF = operativeDataViewModel.PreSSEPRF.Value.ToString();
            }

            if (operativeDataViewModel.PreSSEPLF == null)
            {
                infoOperativeDataViewModel.PreSSEPLF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreSSEPLF = operativeDataViewModel.PreSSEPLF.Value.ToString();
            }

            if (operativeDataViewModel.PreSSEPRP37F == null)
            {
                infoOperativeDataViewModel.PreSSEPRP37F = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreSSEPRP37F = operativeDataViewModel.PreSSEPRP37F.Value.ToString();
            }

            if (operativeDataViewModel.PreSSEPRN45F == null)
            {
                infoOperativeDataViewModel.PreSSEPRN45F = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreSSEPRN45F = operativeDataViewModel.PreSSEPRN45F.Value.ToString();
            }

            if (operativeDataViewModel.PreLumbarF == null)
            {
                infoOperativeDataViewModel.PreLumbarF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreLumbarF = operativeDataViewModel.PreLumbarF.Value.ToString();
            }

            if (operativeDataViewModel.PreZScoreF == null)
            {
                infoOperativeDataViewModel.PreZScoreF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreZScoreF = operativeDataViewModel.PreZScoreF.Value.ToString();
            }

            if (operativeDataViewModel.PreRBMDF == null)
            {
                infoOperativeDataViewModel.PreRBMDF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreRBMDF = operativeDataViewModel.PreRBMDF.Value.ToString();
            }

            if (operativeDataViewModel.PreRZScoreF == null)
            {
                infoOperativeDataViewModel.PreRZScoreF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreRZScoreF = operativeDataViewModel.PreRZScoreF.Value.ToString();
            }

            if (operativeDataViewModel.PreLBMDF == null)
            {
                infoOperativeDataViewModel.PreLBMDF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreLBMDF = operativeDataViewModel.PreLBMDF.Value.ToString();
            }

            if (operativeDataViewModel.PreLZScoreF == null)
            {
                infoOperativeDataViewModel.PreLZScoreF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreLZScoreF = operativeDataViewModel.PreLZScoreF.Value.ToString();
            }


            if (operativeDataViewModel.PreTibiaRD50F == null)
            {
                infoOperativeDataViewModel.PreTibiaRD50F = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreTibiaRD50F = operativeDataViewModel.PreTibiaRD50F.Value.ToString();
            }

            if (operativeDataViewModel.PreTibiaLD50F == null)
            {
                infoOperativeDataViewModel.PreTibiaLD50F = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreTibiaLD50F = operativeDataViewModel.PreTibiaLD50F.Value.ToString();
            }

            if (operativeDataViewModel.PreTibiaRD100F == null)
            {
                infoOperativeDataViewModel.PreTibiaRD100F = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreTibiaRD100F = operativeDataViewModel.PreTibiaRD100F.Value.ToString();
            }

            if (operativeDataViewModel.PreTibiaLD100F == null)
            {
                infoOperativeDataViewModel.PreTibiaLD100F = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreTibiaLD100F = operativeDataViewModel.PreTibiaLD100F.Value.ToString();
            }

            if (operativeDataViewModel.PreRadiusRD50F == null)
            {
                infoOperativeDataViewModel.PreRadiusRD50F = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreRadiusRD50F = operativeDataViewModel.PreRadiusRD50F.Value.ToString();
            }

            if (operativeDataViewModel.PreRadiusLD50F == null)
            {
                infoOperativeDataViewModel.PreRadiusLD50F = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreRadiusLD50F = operativeDataViewModel.PreRadiusLD50F.Value.ToString();
            }

            if (operativeDataViewModel.PreRadiusRD100F == null)
            {
                infoOperativeDataViewModel.PreRadiusRD100F = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreRadiusRD100F = operativeDataViewModel.PreRadiusRD100F.Value.ToString();
            }

            if (operativeDataViewModel.PreRadiusLD100F == null)
            {
                infoOperativeDataViewModel.PreRadiusLD100F = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreRadiusLD100F = operativeDataViewModel.PreRadiusLD100F.Value.ToString();
            }

            if (operativeDataViewModel.PreFVCPredictionF == null)
            {
                infoOperativeDataViewModel.PreFVCPredictionF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreFVCPredictionF = operativeDataViewModel.PreFVCPredictionF.Value.ToString();
            }

            if (operativeDataViewModel.PreFVCObservedF == null)
            {
                infoOperativeDataViewModel.PreFVCObservedF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreFVCObservedF = operativeDataViewModel.PreFVCObservedF.Value.ToString();
            }

            if (operativeDataViewModel.PreFEV1PredictionF == null)
            {
                infoOperativeDataViewModel.PreFEV1PredictionF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreFEV1PredictionF = operativeDataViewModel.PreFEV1PredictionF.Value.ToString();
            }

            if (operativeDataViewModel.PreFEV1ObservedF == null)
            {
                infoOperativeDataViewModel.PreFEV1ObservedF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreFEV1ObservedF = operativeDataViewModel.PreFEV1ObservedF.Value.ToString();
            }

            infoOperativeDataViewModel.PreECGT = operativeDataViewModel.PreECGT;


            if (operativeDataViewModel.PreINRF == null)
            {
                infoOperativeDataViewModel.PreINRF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreINRF = operativeDataViewModel.PreINRF.Value.ToString();
            }

            if (operativeDataViewModel.PrePTF == null)
            {
                infoOperativeDataViewModel.PrePTF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PrePTF = operativeDataViewModel.PrePTF.Value.ToString();
            }

            if (operativeDataViewModel.PreaPTTF == null)
            {
                infoOperativeDataViewModel.PreaPTTF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PreaPTTF = operativeDataViewModel.PreaPTTF.Value.ToString();
            }

            if (operativeDataViewModel.PrePlateletF == null)
            {
                infoOperativeDataViewModel.PrePlateletF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PrePlateletF = operativeDataViewModel.PrePlateletF.Value.ToString();
            }


            if (operativeDataViewModel.PreCommentsA == null)
            {
                infoOperativeDataViewModel.PreCommentsA = "";
            }
            else
            {
                infoOperativeDataViewModel.PreCommentsA = operativeDataViewModel.PreCommentsA.ToString();
            }


            if (operativeDataViewModel.PlanDateD == null)
            {
                infoOperativeDataViewModel.PlanDateD = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanDateD = operativeDataViewModel.PlanDateD.Value.ToString("dd/mm/yyyy");
            }

            if (string.IsNullOrEmpty(operativeDataViewModel.PlanDoctorS))
            {
                infoOperativeDataViewModel.PlanDoctorS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanDoctorS = operativeDataViewModel.PlanDoctorS.ToString();
            }



            if (operativeDataViewModel.PlanARankS == null)
            {
                infoOperativeDataViewModel.PlanARankS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanARankS = operativeDataViewModel.PlanARankS.Value.ToString();
            }

            if (operativeDataViewModel.PlanASideS == null)
            {
                infoOperativeDataViewModel.PlanASideS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanASideS = operativeDataViewModel.PlanASideS.Value.ToString();
            }

            if (operativeDataViewModel.PlanALevelFromS == null)
            {
                infoOperativeDataViewModel.PlanALevelFromS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanALevelFromS = operativeDataViewModel.PlanALevelFromS;
            }

            if (operativeDataViewModel.PlanALevelToS == null)
            {
                infoOperativeDataViewModel.PlanALevelToS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanALevelToS = operativeDataViewModel.PlanALevelToS;
            }

            if (operativeDataViewModel.PlanAApexS == null)
            {
                infoOperativeDataViewModel.PlanAApexS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanAApexS = operativeDataViewModel.PlanAApexS;
            }



            if (operativeDataViewModel.PlanACobbsAngleF == null)
            {
                infoOperativeDataViewModel.PlanACobbsAngleF = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanACobbsAngleF = operativeDataViewModel.PlanACobbsAngleF.Value.ToString();
            }


            if (operativeDataViewModel.PlanAFulcrumF == null)
            {
                infoOperativeDataViewModel.PlanAFulcrumF = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanAFulcrumF = operativeDataViewModel.PlanAFulcrumF.Value.ToString();
            }

            if (operativeDataViewModel.PlanABendingF == null)
            {
                infoOperativeDataViewModel.PlanABendingF = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanABendingF = operativeDataViewModel.PlanABendingF.Value.ToString();
            }

            if (operativeDataViewModel.PlanBRankS == null)
            {
                infoOperativeDataViewModel.PlanBRankS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanBRankS = operativeDataViewModel.PlanBRankS.Value.ToString();
            }

            if (operativeDataViewModel.PlanBSideS == null)
            {
                infoOperativeDataViewModel.PlanBSideS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanBSideS = operativeDataViewModel.PlanBSideS.Value.ToString();
            }


            if (operativeDataViewModel.PlanBLevelFromS == null)
            {
                infoOperativeDataViewModel.PlanBLevelFromS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanBLevelFromS = operativeDataViewModel.PlanBLevelFromS;
            }

            if (operativeDataViewModel.PlanBLevelToS == null)
            {
                infoOperativeDataViewModel.PlanBLevelToS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanBLevelToS = operativeDataViewModel.PlanBLevelToS;
            }

            if (operativeDataViewModel.PlanBApexS == null)
            {
                infoOperativeDataViewModel.PlanBApexS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanBApexS = operativeDataViewModel.PlanBApexS;
            }

            if (operativeDataViewModel.PlanBCobbsAngleF == null)
            {
                infoOperativeDataViewModel.PlanBCobbsAngleF = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanBCobbsAngleF = operativeDataViewModel.PlanBCobbsAngleF.Value.ToString();
            }

            if (operativeDataViewModel.PlanBFulcrumF == null)
            {
                infoOperativeDataViewModel.PlanBFulcrumF = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanBFulcrumF = operativeDataViewModel.PlanBFulcrumF.Value.ToString();
            }

            if (operativeDataViewModel.PlanBBendingF == null)
            {
                infoOperativeDataViewModel.PlanBBendingF = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanBBendingF = operativeDataViewModel.PlanBBendingF.Value.ToString();
            }

            if (operativeDataViewModel.PlanCRankS == null)
            {
                infoOperativeDataViewModel.PlanCRankS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanCRankS = operativeDataViewModel.PlanCRankS.Value.ToString();
            }

            if (operativeDataViewModel.PlanCSideS == null)
            {
                infoOperativeDataViewModel.PlanCSideS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanCSideS = operativeDataViewModel.PlanCSideS.Value.ToString();
            }

            if (operativeDataViewModel.PlanCLevelFromS == null)
            {
                infoOperativeDataViewModel.PlanCLevelFromS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanCLevelFromS = operativeDataViewModel.PlanCLevelFromS;
            }

            if (operativeDataViewModel.PlanCLevelToS == null)
            {
                infoOperativeDataViewModel.PlanCLevelToS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanCLevelToS = operativeDataViewModel.PlanCLevelToS;
            }


            if (operativeDataViewModel.PlanCApexS == null)
            {
                infoOperativeDataViewModel.PlanCApexS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanCApexS = operativeDataViewModel.PlanCApexS;
            }


            if (operativeDataViewModel.PlanCCobbsAngleF == null)
            {
                infoOperativeDataViewModel.PlanCCobbsAngleF = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanCCobbsAngleF = operativeDataViewModel.PlanCCobbsAngleF.Value.ToString();
            }

            if (operativeDataViewModel.PlanCFulcrumF == null)
            {
                infoOperativeDataViewModel.PlanCFulcrumF = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanCFulcrumF = operativeDataViewModel.PlanCFulcrumF.Value.ToString();
            }

            if (operativeDataViewModel.PlanCBendingF == null)
            {
                infoOperativeDataViewModel.PlanCBendingF = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanCBendingF = operativeDataViewModel.PlanCBendingF.Value.ToString();
            }

            if (operativeDataViewModel.PlanDRankS == null)
            {
                infoOperativeDataViewModel.PlanDRankS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanDRankS = operativeDataViewModel.PlanDRankS.Value.ToString();
            }

            if (operativeDataViewModel.PlanDSideS == null)
            {
                infoOperativeDataViewModel.PlanDSideS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanDSideS = operativeDataViewModel.PlanDSideS.Value.ToString();
            }

            if (operativeDataViewModel.PlanDLevelFromS == null)
            {
                infoOperativeDataViewModel.PlanDLevelFromS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanDLevelFromS = operativeDataViewModel.PlanDLevelFromS;
            }

            if (operativeDataViewModel.PlanDLevelToS == null)
            {
                infoOperativeDataViewModel.PlanDLevelToS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanDLevelToS = operativeDataViewModel.PlanDLevelToS;
            }

            if (operativeDataViewModel.PlanDApexS == null)
            {
                infoOperativeDataViewModel.PlanDApexS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanDApexS = operativeDataViewModel.PlanDApexS;
            }

            if (operativeDataViewModel.PlanDCobbsAngleF == null)
            {
                infoOperativeDataViewModel.PlanDCobbsAngleF = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanDCobbsAngleF = operativeDataViewModel.PlanDCobbsAngleF.Value.ToString();
            }

            if (operativeDataViewModel.PlanDFulcrumF == null)
            {
                infoOperativeDataViewModel.PlanDFulcrumF = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanDFulcrumF = operativeDataViewModel.PlanDFulcrumF.Value.ToString();
            }

            if (operativeDataViewModel.PlanDBendingF == null)
            {
                infoOperativeDataViewModel.PlanDBendingF = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanDBendingF = operativeDataViewModel.PlanDBendingF.Value.ToString();
            }


            if (operativeDataViewModel.PlanRisserS == null)
            {
                infoOperativeDataViewModel.PlanRisserS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanRisserS = operativeDataViewModel.PlanRisserS.ToString();
            }


            if (operativeDataViewModel.PlanPriorityR == null)
            {
                infoOperativeDataViewModel.PlanPriorityR = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanPriorityR = operativeDataViewModel.PlanPriorityR.Value.ToString();
            }

            if (operativeDataViewModel.PlanMRIR == null)
            {
                infoOperativeDataViewModel.PlanMRIR = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanMRIR = operativeDataViewModel.PlanMRIR.Value.ToString();
            }


            if (operativeDataViewModel.PlanMRISpecifyT == null)
            {
                infoOperativeDataViewModel.PlanMRISpecifyT = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanMRISpecifyT = operativeDataViewModel.PlanMRISpecifyT;
            }

            if (operativeDataViewModel.PlanMRIActionT == null)
            {
                infoOperativeDataViewModel.PlanMRIActionT = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanMRIActionT = operativeDataViewModel.PlanMRIActionT;
            }


            if (operativeDataViewModel.PlanClottingR == null)
            {
                infoOperativeDataViewModel.PlanClottingR = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanClottingR = operativeDataViewModel.PlanClottingR.Value.ToString();
            }

            if (operativeDataViewModel.PlanClottingSpecifyT == null)
            {
                infoOperativeDataViewModel.PlanClottingSpecifyT = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanClottingSpecifyT = operativeDataViewModel.PlanClottingSpecifyT;
            }

            if (operativeDataViewModel.PlanClottingActionT == null)
            {
                infoOperativeDataViewModel.PlanClottingActionT = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanClottingActionT = operativeDataViewModel.PlanClottingActionT;
            }


            if (operativeDataViewModel.PlanCardiacR == null)
            {
                infoOperativeDataViewModel.PlanCardiacR = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanCardiacR = operativeDataViewModel.PlanCardiacR.Value.ToString();
            }

            if (operativeDataViewModel.PlanCardiacSpecifyT == null)
            {
                infoOperativeDataViewModel.PlanCardiacSpecifyT = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanCardiacSpecifyT = operativeDataViewModel.PlanCardiacSpecifyT;
            }

            if (operativeDataViewModel.PlanCardiacActionT == null)
            {
                infoOperativeDataViewModel.PlanCardiacActionT = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanCardiacActionT = operativeDataViewModel.PlanCardiacActionT;
            }



            if (operativeDataViewModel.PlanRespR == null)
            {
                infoOperativeDataViewModel.PlanRespR = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanRespR = operativeDataViewModel.PlanRespR.Value.ToString();
            }

            if (operativeDataViewModel.PlanRespSpecifyT == null)
            {
                infoOperativeDataViewModel.PlanRespSpecifyT = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanRespSpecifyT = operativeDataViewModel.PlanRespSpecifyT;
            }

            if (operativeDataViewModel.PlanRespActionT == null)
            {
                infoOperativeDataViewModel.PlanRespActionT = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanRespActionT = operativeDataViewModel.PlanRespActionT;
            }

            if (operativeDataViewModel.PlanSSEPR == null)
            {
                infoOperativeDataViewModel.PlanSSEPR = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanSSEPR = operativeDataViewModel.PlanSSEPR.Value.ToString();
            }



            if (operativeDataViewModel.PlanSSEPSpecifyT == null)
            {
                infoOperativeDataViewModel.PlanSSEPSpecifyT = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanSSEPSpecifyT = operativeDataViewModel.PlanSSEPSpecifyT;
            }

            if (operativeDataViewModel.PlanSSEPActionT == null)
            {
                infoOperativeDataViewModel.PlanSSEPActionT = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanSSEPActionT = operativeDataViewModel.PlanSSEPActionT;
            }


            if (operativeDataViewModel.PlanHaloR == null)
            {
                infoOperativeDataViewModel.PlanHaloR = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanHaloR = operativeDataViewModel.PlanHaloR.Value.ToString();
            }

            if (operativeDataViewModel.PlanASFC == null)
            {
                infoOperativeDataViewModel.PlanASFC = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanASFC = operativeDataViewModel.PlanASFC.Value.ToString();
            }

            if (operativeDataViewModel.PlanASFLevelFromS == null)
            {
                infoOperativeDataViewModel.PlanASFLevelFromS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanASFLevelFromS = operativeDataViewModel.PlanASFLevelFromS;
            }

            if (operativeDataViewModel.PlanASFLevelToS == null)
            {
                infoOperativeDataViewModel.PlanASFLevelToS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanASFLevelToS = operativeDataViewModel.PlanASFLevelToS;
            }

            if (operativeDataViewModel.PlanASFHZC == null)
            {
                infoOperativeDataViewModel.PlanASFHZC = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanASFHZC = operativeDataViewModel.PlanASFHZC.Value.ToString();
            }

            if (operativeDataViewModel.PlanASFIsolaC == null)
            {
                infoOperativeDataViewModel.PlanASFIsolaC = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanASFIsolaC = operativeDataViewModel.PlanASFIsolaC.Value.ToString();
            }

            if (operativeDataViewModel.PlanASFOthersC == null)
            {
                infoOperativeDataViewModel.PlanASFOthersC = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanASFOthersC = operativeDataViewModel.PlanASFOthersC.Value.ToString();
            }

            if (operativeDataViewModel.PlanASFOthersT == null)
            {
                infoOperativeDataViewModel.PlanASFOthersT = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanASFOthersT = operativeDataViewModel.PlanASFOthersT.ToString();
            }

            if (operativeDataViewModel.PlanASFBoneR == null)
            {
                infoOperativeDataViewModel.PlanASFBoneR = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanASFBoneR = operativeDataViewModel.PlanASFBoneR.Value.ToString();
            }


            if (operativeDataViewModel.PlanASFBoneOtherT == null)
            {
                infoOperativeDataViewModel.PlanASFBoneOtherT = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanASFBoneOtherT = operativeDataViewModel.PlanASFBoneOtherT.ToString();
            }


            if (operativeDataViewModel.PlanPSFC == null)
            {
                infoOperativeDataViewModel.PlanPSFC = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanPSFC = operativeDataViewModel.PlanPSFC.Value.ToString();
            }


            if (operativeDataViewModel.PlanPSFLevelFromS == null)
            {
                infoOperativeDataViewModel.PlanPSFLevelFromS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanPSFLevelFromS = operativeDataViewModel.PlanPSFLevelFromS;
            }


            if (operativeDataViewModel.PlanPSFLevelToS == null)
            {
                infoOperativeDataViewModel.PlanPSFLevelToS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanPSFLevelToS = operativeDataViewModel.PlanPSFLevelToS;
            }



            if (operativeDataViewModel.PlanPSFHarringtonC == null)
            {
                infoOperativeDataViewModel.PlanPSFHarringtonC = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanPSFHarringtonC = operativeDataViewModel.PlanPSFHarringtonC.Value.ToString();
            }

            if (operativeDataViewModel.PlanPSFLuqueC == null)
            {
                infoOperativeDataViewModel.PlanPSFLuqueC = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanPSFLuqueC = operativeDataViewModel.PlanPSFLuqueC.Value.ToString();
            }

            if (operativeDataViewModel.PlanPSFWisconsinC == null)
            {
                infoOperativeDataViewModel.PlanPSFWisconsinC = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanPSFWisconsinC = operativeDataViewModel.PlanPSFWisconsinC.Value.ToString();
            }

            if (operativeDataViewModel.PlanPSFCDC == null)
            {
                infoOperativeDataViewModel.PlanPSFCDC = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanPSFCDC = operativeDataViewModel.PlanPSFCDC.Value.ToString();
            }

            if (operativeDataViewModel.PlanPSFIsolaC == null)
            {
                infoOperativeDataViewModel.PlanPSFIsolaC = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanPSFIsolaC = operativeDataViewModel.PlanPSFIsolaC.Value.ToString();
            }

            if (operativeDataViewModel.PlanPSFOthersC == null)
            {
                infoOperativeDataViewModel.PlanPSFOthersC = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanPSFOthersC = operativeDataViewModel.PlanPSFOthersC.Value.ToString();
            }

            if (operativeDataViewModel.PlanPSFBoneR == null)
            {
                infoOperativeDataViewModel.PlanPSFBoneR = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanPSFBoneR = operativeDataViewModel.PlanPSFBoneR.Value.ToString();
            }


            if (operativeDataViewModel.PlanPSFOthersT == null)
            {
                infoOperativeDataViewModel.PlanPSFOthersT = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanPSFOthersT = operativeDataViewModel.PlanPSFOthersT;
            }

            if (operativeDataViewModel.PlanPSFBoneOtherT == null)
            {
                infoOperativeDataViewModel.PlanPSFBoneOtherT = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanPSFBoneOtherT = operativeDataViewModel.PlanPSFBoneOtherT;
            }

            if (operativeDataViewModel.PlanVATC == null)
            {
                infoOperativeDataViewModel.PlanVATC = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanVATC = operativeDataViewModel.PlanVATC.Value.ToString();
            }

            if (operativeDataViewModel.PlanVATLevelFromS == null)
            {
                infoOperativeDataViewModel.PlanVATLevelFromS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanVATLevelFromS = operativeDataViewModel.PlanVATLevelFromS;
            }

            if (operativeDataViewModel.PlanVATLevelToS == null)
            {
                infoOperativeDataViewModel.PlanVATLevelToS = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanVATLevelToS = operativeDataViewModel.PlanVATLevelToS;
            }


            if (operativeDataViewModel.PlanVATYesC == null)
            {
                infoOperativeDataViewModel.PlanVATYesC = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanVATYesC = operativeDataViewModel.PlanVATYesC.Value.ToString();
            }


            if (operativeDataViewModel.PlanVATYesT == null)
            {
                infoOperativeDataViewModel.PlanVATYesT = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanVATYesT = operativeDataViewModel.PlanVATYesT.ToString();
            }


            if (operativeDataViewModel.PlanVATBoneR == null)
            {
                infoOperativeDataViewModel.PlanVATBoneR = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanVATBoneR = operativeDataViewModel.PlanVATBoneR.Value.ToString();
            }

            if (operativeDataViewModel.PlanVATBoneOtherT == null)
            {
                infoOperativeDataViewModel.PlanVATBoneOtherT = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanVATBoneOtherT = operativeDataViewModel.PlanVATBoneOtherT;
            }

            if (operativeDataViewModel.PlanRemarksA == null)
            {
                infoOperativeDataViewModel.PlanRemarksA = "";
            }
            else
            {
                infoOperativeDataViewModel.PlanRemarksA = operativeDataViewModel.PlanRemarksA;
            }


            if (operativeDataViewModel.IntraDateD == null)
            {
                infoOperativeDataViewModel.IntraDateD = "";
            }
            else
            {
                infoOperativeDataViewModel.IntraDateD = operativeDataViewModel.IntraDateD.Value.ToString("dd/MM/yyyy");
            }

            if (operativeDataViewModel.IntraAnaesthetistT == null)
            {
                infoOperativeDataViewModel.IntraAnaesthetistT = "";
            }
            else
            {
                infoOperativeDataViewModel.IntraAnaesthetistT = operativeDataViewModel.IntraAnaesthetistT.ToString();
            }



            if (operativeDataViewModel.IntraDurationF == null)
            {
                infoOperativeDataViewModel.IntraDurationF = "";
            }
            else
            {
                infoOperativeDataViewModel.IntraDurationF = operativeDataViewModel.IntraDurationF.Value.ToString();
            }

            if (operativeDataViewModel.IntraNonSaverF == null)
            {
                infoOperativeDataViewModel.IntraNonSaverF = "";
            }
            else
            {
                infoOperativeDataViewModel.IntraNonSaverF = operativeDataViewModel.IntraNonSaverF.Value.ToString();
            }

            if (operativeDataViewModel.IntraSaverR == null)
            {
                infoOperativeDataViewModel.IntraSaverR = "";
            }
            else
            {
                infoOperativeDataViewModel.IntraSaverR = operativeDataViewModel.IntraSaverR.Value.ToString();
            }

            if (operativeDataViewModel.IntraSaverF == null)
            {
                infoOperativeDataViewModel.IntraSaverF = "";
            }
            else
            {
                infoOperativeDataViewModel.IntraSaverF = operativeDataViewModel.IntraSaverF.Value.ToString();
            }

            if (operativeDataViewModel.IntraAutoOutF == null)
            {
                infoOperativeDataViewModel.IntraAutoOutF = "";
            }
            else
            {
                infoOperativeDataViewModel.IntraAutoOutF = operativeDataViewModel.IntraAutoOutF.Value.ToString();
            }

            if (operativeDataViewModel.IntraAutologousF == null)
            {
                infoOperativeDataViewModel.IntraAutologousF = "";
            }
            else
            {
                infoOperativeDataViewModel.IntraAutologousF = operativeDataViewModel.IntraAutologousF.Value.ToString();
            }

            if (operativeDataViewModel.IntraAutoInF == null)
            {
                infoOperativeDataViewModel.IntraAutoInF = "";
            }
            else
            {
                infoOperativeDataViewModel.IntraAutoInF = operativeDataViewModel.IntraAutoInF.Value.ToString();
            }

            if (operativeDataViewModel.IntraWholeBloodF == null)
            {
                infoOperativeDataViewModel.IntraWholeBloodF = "";
            }
            else
            {
                infoOperativeDataViewModel.IntraWholeBloodF = operativeDataViewModel.IntraWholeBloodF.Value.ToString();
            }

            if (operativeDataViewModel.IntraPackedCellF == null)
            {
                infoOperativeDataViewModel.IntraPackedCellF = "";
            }
            else
            {
                infoOperativeDataViewModel.IntraPackedCellF = operativeDataViewModel.IntraPackedCellF.Value.ToString();
            }

            if (operativeDataViewModel.IntraCrystalloidF == null)
            {
                infoOperativeDataViewModel.IntraCrystalloidF = "";
            }
            else
            {
                infoOperativeDataViewModel.IntraCrystalloidF = operativeDataViewModel.IntraCrystalloidF.Value.ToString();
            }

            if (operativeDataViewModel.IntraColloidF == null)
            {
                infoOperativeDataViewModel.IntraColloidF = "";
            }
            else
            {
                infoOperativeDataViewModel.IntraColloidF = operativeDataViewModel.IntraColloidF.Value.ToString();
            }

            if (operativeDataViewModel.IntraPlateletF == null)
            {
                infoOperativeDataViewModel.IntraPlateletF = "";
            }
            else
            {
                infoOperativeDataViewModel.IntraPlateletF = operativeDataViewModel.IntraPlateletF.Value.ToString();
            }

            if (operativeDataViewModel.IntraFFPF == null)
            {
                infoOperativeDataViewModel.IntraFFPF = "";
            }
            else
            {
                infoOperativeDataViewModel.IntraFFPF = operativeDataViewModel.IntraFFPF.Value.ToString();
            }

            if (operativeDataViewModel.IntraAntibioticsR == null)
            {
                infoOperativeDataViewModel.IntraAntibioticsR = "";
            }
            else
            {
                infoOperativeDataViewModel.IntraAntibioticsR = operativeDataViewModel.IntraAntibioticsR.Value.ToString();
            }


            if (operativeDataViewModel.IntraAntibioticsT == null)
            {
                infoOperativeDataViewModel.IntraAntibioticsT = "";
            }
            else
            {
                infoOperativeDataViewModel.IntraAntibioticsT = operativeDataViewModel.IntraAntibioticsT;
            }


            if (operativeDataViewModel.ProChiefS == null)
            {
                infoOperativeDataViewModel.ProChiefS = "";
            }
            else
            {
                infoOperativeDataViewModel.ProChiefS = operativeDataViewModel.ProChiefS;
            }

            if (operativeDataViewModel.ProAssistant1S == null)
            {
                infoOperativeDataViewModel.ProAssistant1S = "";
            }
            else
            {
                infoOperativeDataViewModel.ProAssistant1S = operativeDataViewModel.ProAssistant1S;
            }


            if (operativeDataViewModel.ProAssistant2S == null)
            {
                infoOperativeDataViewModel.ProAssistant2S = "";
            }
            else
            {
                infoOperativeDataViewModel.ProAssistant2S = operativeDataViewModel.ProAssistant2S;
            }

            if (operativeDataViewModel.ProAssistant3S == null)
            {
                infoOperativeDataViewModel.ProAssistant3S = "";
            }
            else
            {
                infoOperativeDataViewModel.ProAssistant3S = operativeDataViewModel.ProAssistant3S;
            }


            if (operativeDataViewModel.ProSurgeonOthersT == null)
            {
                infoOperativeDataViewModel.ProSurgeonOthersT = "";
            }
            else
            {
                infoOperativeDataViewModel.ProSurgeonOthersT = operativeDataViewModel.ProSurgeonOthersT;
            }


            if (operativeDataViewModel.ProPosteriorLevelR == null)
            {
                infoOperativeDataViewModel.ProPosteriorLevelR = "";
            }
            else
            {
                infoOperativeDataViewModel.ProPosteriorLevelR = operativeDataViewModel.ProPosteriorLevelR.Value.ToString();
            }

            if (operativeDataViewModel.ProPosteriorFromS == null)
            {
                infoOperativeDataViewModel.ProPosteriorFromS = "";
            }
            else
            {
                infoOperativeDataViewModel.ProPosteriorFromS = operativeDataViewModel.ProPosteriorFromS;
            }

            if (operativeDataViewModel.ProPosteriorToS == null)
            {
                infoOperativeDataViewModel.ProPosteriorToS = "";
            }
            else
            {
                infoOperativeDataViewModel.ProPosteriorToS = operativeDataViewModel.ProPosteriorToS;
            }


            if (operativeDataViewModel.ProPosteriorLevelF == null)
            {
                infoOperativeDataViewModel.ProPosteriorLevelF = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProPosteriorLevelF = operativeDataViewModel.ProPosteriorLevelF.Value.ToString();
            }

            if (operativeDataViewModel.ProPHarringtonC == null)
            {
                infoOperativeDataViewModel.ProPHarringtonC = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProPHarringtonC = operativeDataViewModel.ProPHarringtonC.Value.ToString();
            }

            if (operativeDataViewModel.ProPLuqueC == null)
            {
                infoOperativeDataViewModel.ProPLuqueC = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProPLuqueC = operativeDataViewModel.ProPLuqueC.Value.ToString();
            }

            if (operativeDataViewModel.ProPWisconsinC == null)
            {
                infoOperativeDataViewModel.ProPWisconsinC = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProPWisconsinC = operativeDataViewModel.ProPWisconsinC.Value.ToString();
            }

            if (operativeDataViewModel.ProPCDC == null)
            {
                infoOperativeDataViewModel.ProPCDC = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProPCDC = operativeDataViewModel.ProPCDC.Value.ToString();
            }

            if (operativeDataViewModel.ProPIsolaC == null)
            {
                infoOperativeDataViewModel.ProPIsolaC = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProPIsolaC = operativeDataViewModel.ProPIsolaC.Value.ToString();
            }

            if (operativeDataViewModel.ProPOthersC == null)
            {
                infoOperativeDataViewModel.ProPOthersC = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProPOthersC = operativeDataViewModel.ProPOthersC.Value.ToString();
            }

            if (operativeDataViewModel.ProAnteriorLevelR == null)
            {
                infoOperativeDataViewModel.ProAnteriorLevelR = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProAnteriorLevelR = operativeDataViewModel.ProAnteriorLevelR.Value.ToString();
            }


            if (operativeDataViewModel.ProAnteriorFromS == null)
            {
                infoOperativeDataViewModel.ProAnteriorFromS = "";
            }
            else
            {
                infoOperativeDataViewModel.ProAnteriorFromS = operativeDataViewModel.ProAnteriorFromS;
            }

            if (operativeDataViewModel.ProAnteriorToS == null)
            {
                infoOperativeDataViewModel.ProAnteriorToS = "";
            }
            else
            {
                infoOperativeDataViewModel.ProAnteriorToS = operativeDataViewModel.ProAnteriorToS;
            }



            if (operativeDataViewModel.ProAnteriorLevelF == null)
            {
                infoOperativeDataViewModel.ProAnteriorLevelF = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProAnteriorLevelF = operativeDataViewModel.ProAnteriorLevelF.Value.ToString();
            }

            if (operativeDataViewModel.ProAZielkeC == null)
            {
                infoOperativeDataViewModel.ProAZielkeC = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProAZielkeC = operativeDataViewModel.ProAZielkeC.Value.ToString();
            }

            if (operativeDataViewModel.ProAHalmC == null)
            {
                infoOperativeDataViewModel.ProAHalmC = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProAHalmC = operativeDataViewModel.ProAHalmC.Value.ToString();
            }

            if (operativeDataViewModel.ProAIsolaC == null)
            {
                infoOperativeDataViewModel.ProAIsolaC = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProAIsolaC = operativeDataViewModel.ProAIsolaC.Value.ToString();
            }

            if (operativeDataViewModel.ProAOthersC == null)
            {
                infoOperativeDataViewModel.ProAOthersC = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProAOthersC = operativeDataViewModel.ProAOthersC.Value.ToString();
            }

            if (operativeDataViewModel.ProAOthersT == null)
            {
                infoOperativeDataViewModel.ProAOthersT = "";
            }
            else
            {
                infoOperativeDataViewModel.ProAOthersT = operativeDataViewModel.ProAOthersT.ToString();
            }

            if (operativeDataViewModel.ProThoracoscopicR == null)
            {
                infoOperativeDataViewModel.ProThoracoscopicR = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProThoracoscopicR = operativeDataViewModel.ProThoracoscopicR.Value.ToString();
            }


            if (operativeDataViewModel.ProSurgeonT == null)
            {
                infoOperativeDataViewModel.ProSurgeonT = "";
            }
            else
            {
                infoOperativeDataViewModel.ProSurgeonT = operativeDataViewModel.ProSurgeonT;
            }

            if (operativeDataViewModel.ProThoracoscopicFromT == null)
            {
                infoOperativeDataViewModel.ProThoracoscopicFromT = "";
            }
            else
            {
                infoOperativeDataViewModel.ProThoracoscopicFromT = operativeDataViewModel.ProThoracoscopicFromT.ToString();
            }

            if (operativeDataViewModel.ProThoracoscopicToT == null)
            {
                infoOperativeDataViewModel.ProThoracoscopicToT = "";
            }
            else
            {
                infoOperativeDataViewModel.ProThoracoscopicToT = operativeDataViewModel.ProThoracoscopicToT.ToString();
            }

            if (operativeDataViewModel.ProThoracoscopicSideS == null)
            {
                infoOperativeDataViewModel.ProThoracoscopicSideS = "";
            }
            else
            {
                infoOperativeDataViewModel.ProThoracoscopicSideS = operativeDataViewModel.ProThoracoscopicSideS.ToString();
            }

            if (operativeDataViewModel.ProBoneR == null)
            {
                infoOperativeDataViewModel.ProBoneR = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProBoneR = operativeDataViewModel.ProBoneR.Value.ToString();
            }

            if (operativeDataViewModel.ProAutologousC == null)
            {
                infoOperativeDataViewModel.ProAutologousC = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProAutologousC = operativeDataViewModel.ProAutologousC.Value.ToString();
            }

            if (operativeDataViewModel.ProAutologousF == null)
            {
                infoOperativeDataViewModel.ProAutologousF = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProAutologousF = operativeDataViewModel.ProAutologousF.Value.ToString();
            }

            if (operativeDataViewModel.ProAllograftC == null)
            {
                infoOperativeDataViewModel.ProAllograftC = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProAllograftC = operativeDataViewModel.ProAllograftC.Value.ToString();
            }

            if (operativeDataViewModel.ProAllograftF == null)
            {
                infoOperativeDataViewModel.ProAllograftF = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProAllograftF = operativeDataViewModel.ProAllograftF.Value.ToString();
            }


            if (operativeDataViewModel.ProBoneOthersC == null)
            {
                infoOperativeDataViewModel.ProBoneOthersC = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProBoneOthersC = operativeDataViewModel.ProBoneOthersC.Value.ToString();
            }

            if (operativeDataViewModel.ProBoneOthersT == null)
            {
                infoOperativeDataViewModel.ProBoneOthersT = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProBoneOthersT = operativeDataViewModel.ProBoneOthersT.ToString();
            }

            if (operativeDataViewModel.ProWakeR == null)
            {
                infoOperativeDataViewModel.ProWakeR = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProWakeR = operativeDataViewModel.ProWakeR.Value.ToString();
            }

            if (operativeDataViewModel.ProSSEPR == null)
            {

                infoOperativeDataViewModel.ProSSEPR = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProSSEPR = operativeDataViewModel.ProSSEPR.Value.ToString();
            }

            if (operativeDataViewModel.ProSSEPT == null)
            {
                infoOperativeDataViewModel.ProSSEPT = "";
            }
            else
            {
                infoOperativeDataViewModel.ProSSEPT = operativeDataViewModel.ProSSEPT.ToString();
            }

            if (operativeDataViewModel.ProWakeT == null)
            {
                infoOperativeDataViewModel.ProWakeT = "";
            }
            else
            {
                infoOperativeDataViewModel.ProWakeT = operativeDataViewModel.ProWakeT.ToString();
            }


            if (operativeDataViewModel.ProSSEPR == null)
            {
                infoOperativeDataViewModel.ProMEPR = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProMEPR = operativeDataViewModel.ProMEPR.Value.ToString();
            }


            if (operativeDataViewModel.ProMEPT == null)
            {
                infoOperativeDataViewModel.ProMEPT = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProMEPT = operativeDataViewModel.ProMEPT.ToString();
            }


            if (operativeDataViewModel.ProImplantA == null)
            {
                infoOperativeDataViewModel.ProImplantA = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProImplantA = operativeDataViewModel.ProImplantA.ToString();
            }

            if (operativeDataViewModel.ProOthersA == null)
            {
                infoOperativeDataViewModel.ProOthersA = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProOthersA = operativeDataViewModel.ProOthersA.ToString();
            }

            if (operativeDataViewModel.ProRemarkA == null)
            {
                infoOperativeDataViewModel.ProRemarkA = "0";
            }
            else
            {
                infoOperativeDataViewModel.ProRemarkA = operativeDataViewModel.ProRemarkA.ToString();
            }

            if (operativeDataViewModel.PostTransfusionWholeF == null)
            {
                infoOperativeDataViewModel.PostTransfusionWholeF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostTransfusionWholeF = operativeDataViewModel.PostTransfusionWholeF.Value.ToString();
            }

            if (operativeDataViewModel.PostTransfusionPackedF == null)
            {
                infoOperativeDataViewModel.PostTransfusionPackedF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostTransfusionPackedF = operativeDataViewModel.PostTransfusionPackedF.Value.ToString();
            }


            if (operativeDataViewModel.PostLastHbF == null)
            {
                infoOperativeDataViewModel.PostLastHbF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostLastHbF = operativeDataViewModel.PostLastHbF.Value.ToString();
            }

            if (operativeDataViewModel.PostLastHbDayF == null)
            {
                infoOperativeDataViewModel.PostLastHbDayF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostLastHbDayF = operativeDataViewModel.PostLastHbDayF.Value.ToString();
            }


            if (operativeDataViewModel.PostPreOpHbF == null)
            {
                infoOperativeDataViewModel.PostPreOpHbF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostPreOpHbF = operativeDataViewModel.PostPreOpHbF.Value.ToString();
            }

            if (operativeDataViewModel.PostPlateletF == null)
            {
                infoOperativeDataViewModel.PostPlateletF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostPlateletF = operativeDataViewModel.PostPlateletF.Value.ToString();
            }


            if (operativeDataViewModel.PostFFPF == null)
            {
                infoOperativeDataViewModel.PostFFPF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostFFPF = operativeDataViewModel.PostFFPF.Value.ToString();
            }

            if (operativeDataViewModel.PostDaysF == null)
            {
                infoOperativeDataViewModel.PostDaysF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostDaysF = operativeDataViewModel.PostDaysF.Value.ToString();
            }

            if (operativeDataViewModel.PostBracingR == null)
            {
                infoOperativeDataViewModel.PostBracingR = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostBracingR = operativeDataViewModel.PostBracingR.Value.ToString();
            }

            if (operativeDataViewModel.PostBracingT == null)
            {
                infoOperativeDataViewModel.PostBracingT = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostBracingT = operativeDataViewModel.PostBracingT.ToString();
            }

            if (operativeDataViewModel.PostComplicationA == null)
            {
                infoOperativeDataViewModel.PostComplicationA = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostComplicationA = operativeDataViewModel.PostComplicationA.ToString();
            }


            if (operativeDataViewModel.PostWithBraceC == null)
            {
                infoOperativeDataViewModel.PostWithBraceC = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostWithBraceC = operativeDataViewModel.PostWithBraceC.Value.ToString();
            }

            if (operativeDataViewModel.PostACobbsF == null)
            {
                infoOperativeDataViewModel.PostACobbsF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostACobbsF = operativeDataViewModel.PostACobbsF.Value.ToString();
            }

            if (operativeDataViewModel.PostAPreAVTF == null)
            {
                infoOperativeDataViewModel.PostAPreAVTF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostAPreAVTF = operativeDataViewModel.PostAPreAVTF.Value.ToString();
            }

            if (operativeDataViewModel.PostAPreAVTS == null)
            {
                infoOperativeDataViewModel.PostAPreAVTS = "";
            }
            else
            {
                infoOperativeDataViewModel.PostAPreAVTS = operativeDataViewModel.PostAPreAVTS.Value.ToString();
            }

            if (operativeDataViewModel.PostAPostAVTF == null)
            {
                infoOperativeDataViewModel.PostAPreAVTS = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostAPostAVTF = operativeDataViewModel.PostAPostAVTF.Value.ToString();
            }

            if (operativeDataViewModel.PostAPostAVTS == null)
            {
                infoOperativeDataViewModel.PostAPostAVTS = "";
            }
            else
            {
                infoOperativeDataViewModel.PostAPostAVTS = operativeDataViewModel.PostAPostAVTS.Value.ToString();
            }


            if (operativeDataViewModel.PostBCobbsF == null)
            {
                infoOperativeDataViewModel.PostBCobbsF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostBCobbsF = operativeDataViewModel.PostBCobbsF.ToString();
            }

            if (operativeDataViewModel.PostBPreAVTF == null)
            {
                infoOperativeDataViewModel.PostBPreAVTF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostBPreAVTF = operativeDataViewModel.PostBPreAVTF.Value.ToString();
            }

            if (operativeDataViewModel.PostBPreAVTS == null)
            {
                infoOperativeDataViewModel.PostBPreAVTS = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostBPreAVTS = operativeDataViewModel.PostBPreAVTS.Value.ToString();
            }

            if (operativeDataViewModel.PostBPostAVTF == null)
            {
                infoOperativeDataViewModel.PostBPostAVTF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostBPostAVTF = operativeDataViewModel.PostBPostAVTF.Value.ToString();
            }

            if (operativeDataViewModel.PostBPostAVTS == null)
            {
                infoOperativeDataViewModel.PostBPostAVTS = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostBPostAVTS = operativeDataViewModel.PostBPostAVTS.Value.ToString();
            }

            infoOperativeDataViewModel.PostCCobbsF = operativeDataViewModel.PostCCobbsF;

            if (operativeDataViewModel.PostCPreAVTF == null)
            {
                infoOperativeDataViewModel.PostCPreAVTF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostCPreAVTF = operativeDataViewModel.PostCPreAVTF.Value.ToString();
            }

            if (operativeDataViewModel.PostCPreAVTS == null)
            {
                infoOperativeDataViewModel.PostCPreAVTS = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostCPreAVTS = operativeDataViewModel.PostCPreAVTS.Value.ToString();
            }

            if (operativeDataViewModel.PostCPostAVTF == null)
            {
                infoOperativeDataViewModel.PostCPostAVTF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostCPostAVTF = operativeDataViewModel.PostCPostAVTF.Value.ToString();
            }

            if (operativeDataViewModel.PostCPostAVTS == null)
            {
                infoOperativeDataViewModel.PostCPostAVTS = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostCPostAVTS = operativeDataViewModel.PostCPostAVTS.Value.ToString();
            }

            infoOperativeDataViewModel.PostDCobbsF = operativeDataViewModel.PostDCobbsF;

            if (operativeDataViewModel.PostDPreAVTF == null)
            {
                infoOperativeDataViewModel.PostDPreAVTF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostDPreAVTF = operativeDataViewModel.PostDPreAVTF.Value.ToString();
            }

            if (operativeDataViewModel.PostDPreAVTS == null)
            {
                infoOperativeDataViewModel.PostDPreAVTS = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostDPreAVTS = operativeDataViewModel.PostDPreAVTS.Value.ToString();
            }

            if (operativeDataViewModel.PostDPostAVTF == null)
            {
                infoOperativeDataViewModel.PostDPostAVTF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostDPostAVTF = operativeDataViewModel.PostDPostAVTF.Value.ToString();
            }

            if (operativeDataViewModel.PostDPostAVTS == null)
            {
                infoOperativeDataViewModel.PostDPostAVTS = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostDPostAVTS = operativeDataViewModel.PostDPostAVTS.Value.ToString();
            }

            if (operativeDataViewModel.PostPreOpTrunkF == null)
            {
                infoOperativeDataViewModel.PostPreOpTrunkF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostPreOpTrunkF = operativeDataViewModel.PostPreOpTrunkF.Value.ToString();
            }

            if (operativeDataViewModel.PostPreOpTrunkS == null)
            {
                infoOperativeDataViewModel.PostPreOpTrunkS = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostPreOpTrunkS = operativeDataViewModel.PostPreOpTrunkS.Value.ToString();
            }

            if (operativeDataViewModel.PostPostOpTrunkF == null)
            {
                infoOperativeDataViewModel.PostPostOpTrunkF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostPostOpTrunkF = operativeDataViewModel.PostPostOpTrunkF.Value.ToString();
            }


            if (operativeDataViewModel.PostPostOpTrunkS == null)
            {
                infoOperativeDataViewModel.PostPostOpTrunkS = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostPostOpTrunkS = operativeDataViewModel.PostPostOpTrunkS.Value.ToString();
            }


            if (operativeDataViewModel.PostUpperF == null)
            {
                infoOperativeDataViewModel.PostUpperF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostUpperF = operativeDataViewModel.PostUpperF.Value.ToString();
            }

            if (operativeDataViewModel.PostUpperS == null)
            {
                infoOperativeDataViewModel.PostUpperS = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostUpperS = operativeDataViewModel.PostUpperS.Value.ToString();
            }

            if (operativeDataViewModel.PostLowerF == null)
            {
                infoOperativeDataViewModel.PostLowerF = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostLowerF = operativeDataViewModel.PostLowerF.Value.ToString();
            }

            if (operativeDataViewModel.PostLowerS == null)
            {
                infoOperativeDataViewModel.PostLowerS = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostLowerS = operativeDataViewModel.PostLowerS.Value.ToString();
            }


            if (operativeDataViewModel.PostRemarkA == null)
            {
                infoOperativeDataViewModel.PostRemarkA = "0";
            }
            else
            {
                infoOperativeDataViewModel.PostRemarkA = operativeDataViewModel.PostRemarkA.ToString();
            }

            return infoOperativeDataViewModel;
        }

    }
}
