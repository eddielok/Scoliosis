using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Scoliosis.Models
{
    public class InfoOperativeDataViewModel
    {
        public string SCN { get; set; }
        public Int16 RecordID { get; set; }
        public string PreRisserS { get; set; }
        public string PreHeightF { get; set; }
        public string PreArmSpanF { get; set; }
        public string PreWeightF { get; set; }
        public string PreSittingF { get; set; }
        public string PreARankS { get; set; }
        public string PreASideS { get; set; }
        public string PreALevelFromS { get; set; }
        public string PreALevelToS { get; set; }
        public string PreAApexS { get; set; }
        public string PreACobbsAngleF { get; set; }
        public string PreAFulcrumF { get; set; }
        public string PreABendingF { get; set; }
        public string PreBRankS { get; set; }
        public string PreBSideS { get; set; }
        public string PreBLevelFromS { get; set; }
        public string PreBLevelToS { get; set; }
        public string PreBApexS { get; set; }
        public string PreBCobbsAngleF { get; set; }
        public string PreBFulcrumF { get; set; }
        public string PreBBendingF { get; set; }
        public string PreCRankS { get; set; }
        public string PreCSideS { get; set; }
        public string PreCLevelFromS { get; set; }
        public string PreCLevelToS { get; set; }
        public string PreCApexS { get; set; }
        public string PreCCobbsAngleF { get; set; }
        public string PreCFulcrumF { get; set; }
        public string PreCBendingF { get; set; }
        public string PreDRankS { get; set; }
        public string PreDSideS { get; set; }
        public string PreDLevelFromS { get; set; }
        public string PreDLevelToS { get; set; }
        public string PreDApexS { get; set; }
        public string PreDCobbsAngleF { get; set; }
        public string PreDFulcrumF { get; set; }
        public string PreDBendingF { get; set; }
        public string PreMRIR { get; set; }
        public string PreMRIT { get; set; }
        public string PreSSEPRF { get; set; }
        public string PreSSEPLF { get; set; }
        public string PreSSEPRP37F { get; set; }
        public string PreSSEPRN45F { get; set; }
        public string PreSSEPLP37F { get; set; }
        public string PreSSEPLN45F { get; set; }
        public string PreLumbarF { get; set; }
        public string PreZScoreF { get; set; }
        public string PreRBMDF { get; set; }
        public string PreRZScoreF { get; set; }
        public string PreLBMDF { get; set; }
        public string PreLZScoreF { get; set; }
        public string PreTibiaRD50F { get; set; }
        public string PreTibiaLD50F { get; set; }
        public string PreTibiaRD100F { get; set; }
        public string PreTibiaLD100F { get; set; }
        public string PreRadiusRD50F { get; set; }
        public string PreRadiusLD50F { get; set; }
        public string PreRadiusRD100F { get; set; }
        public string PreRadiusLD100F { get; set; }
        public string PreFVCPredictionF { get; set; }
        public string PreFVCObservedF { get; set; }
        public string PreFEV1PredictionF { get; set; }
        public string PreFEV1ObservedF { get; set; }
        public string PreECGT { get; set; }
        public string PreINRF { get; set; }
        public string PrePTF { get; set; }
        public string PreaPTTF { get; set; }
        public string PrePlateletF { get; set; }
        public string PreCommentsA { get; set; }
        public string PlanDateD { get; set; }
        public string PlanDoctorS { get; set; }
        public string PlanARankS { get; set; }
        public string PlanASideS { get; set; }
        public string PlanALevelFromS { get; set; }
        public string PlanALevelToS { get; set; }
        public string PlanAApexS { get; set; }
        public string PlanACobbsAngleF { get; set; }
        public string PlanAFulcrumF { get; set; }
        public string PlanABendingF { get; set; }
        public string PlanBRankS { get; set; }
        public string PlanBSideS { get; set; }
        public string PlanBLevelFromS { get; set; }
        public string PlanBLevelToS { get; set; }
        public string PlanBApexS { get; set; }
        public string PlanBCobbsAngleF { get; set; }
        public string PlanBFulcrumF { get; set; }
        public string PlanBBendingF { get; set; }
        public string PlanCRankS { get; set; }
        public string PlanCSideS { get; set; }
        public string PlanCLevelFromS { get; set; }
        public string PlanCLevelToS { get; set; }
        public string PlanCApexS { get; set; }
        public string PlanCCobbsAngleF { get; set; }
        public string PlanCFulcrumF { get; set; }
        public string PlanCBendingF { get; set; }
        public string PlanDRankS { get; set; }
        public string PlanDSideS { get; set; }
        public string PlanDLevelFromS { get; set; }
        public string PlanDLevelToS { get; set; }
        public string PlanDApexS { get; set; }
        public string PlanDCobbsAngleF { get; set; }
        public string PlanDFulcrumF { get; set; }
        public string PlanDBendingF { get; set; }
        public string PlanRisserS { get; set; }
        public string PlanPriorityR { get; set; }
        public string PlanMRIR { get; set; }
        public string PlanMRISpecifyT { get; set; }
        public string PlanMRIActionT { get; set; }
        public string PlanClottingR { get; set; }
        public string PlanClottingSpecifyT { get; set; }
        public string PlanClottingActionT { get; set; }
        public string PlanCardiacR { get; set; }
        public string PlanCardiacSpecifyT { get; set; }
        public string PlanCardiacActionT { get; set; }
        public string PlanRespR { get; set; }
        public string PlanRespSpecifyT { get; set; }
        public string PlanRespActionT { get; set; }
        public string PlanSSEPR { get; set; }
        public string PlanSSEPSpecifyT { get; set; }
        public string PlanSSEPActionT { get; set; }
        public string PlanHaloR { get; set; }
        public string PlanASFC { get; set; }
        public string PlanASFLevelFromS { get; set; }
        public string PlanASFLevelToS { get; set; }
        public string PlanASFHZC { get; set; }
        public string PlanASFIsolaC { get; set; }
        public string PlanASFOthersC { get; set; }
        public string PlanASFOthersT { get; set; }
        public string PlanASFBoneR { get; set; }
        public string PlanASFBoneOtherT { get; set; }
        public string PlanPSFC { get; set; }
        public string PlanPSFLevelFromS { get; set; }
        public string PlanPSFLevelToS { get; set; }
        public string PlanPSFHarringtonC { get; set; }
        public string PlanPSFLuqueC { get; set; }
        public string PlanPSFWisconsinC { get; set; }
        public string PlanPSFCDC { get; set; }
        public string PlanPSFIsolaC { get; set; }
        public string PlanPSFOthersC { get; set; }
        public string PlanPSFOthersT { get; set; }
        public string PlanPSFBoneR { get; set; }
        public string PlanPSFBoneOtherT { get; set; }
        public string PlanVATC { get; set; }
        public string PlanVATLevelFromS { get; set; }
        public string PlanVATLevelToS { get; set; }
        public string PlanVATYesC { get; set; }
        public string PlanVATYesT { get; set; }
        public string PlanVATBoneR { get; set; }
        public string PlanVATBoneOtherT { get; set; }
        public string PlanRemarksA { get; set; }
        public string IntraDateD { get; set; }
        public string IntraAnaesthetistT { get; set; }
        public string IntraDurationF { get; set; }
        public string IntraNonSaverF { get; set; }
        public string IntraSaverR { get; set; }
        public string IntraSaverF { get; set; }
        public string IntraAutoOutF { get; set; }
        public string IntraAutologousF { get; set; }
        public string IntraAutoInF { get; set; }
        public string IntraWholeBloodF { get; set; }
        public string IntraPackedCellF { get; set; }
        public string IntraCrystalloidF { get; set; }
        public string IntraColloidF { get; set; }
        public string IntraPlateletF { get; set; }
        public string IntraFFPF { get; set; }
        public string IntraAntibioticsR { get; set; }
        public string IntraAntibioticsT { get; set; }
        public string ProChiefS { get; set; }
        public string ProAssistant1S { get; set; }
        public string ProAssistant2S { get; set; }
        public string ProAssistant3S { get; set; }
        public string ProSurgeonOthersT { get; set; }
        public string ProPosteriorLevelR { get; set; }
        public string ProPosteriorFromS { get; set; }
        public string ProPosteriorToS { get; set; }
        public string ProPosteriorLevelF { get; set; }
        public string ProPHarringtonC { get; set; }
        public string ProPLuqueC { get; set; }
        public string ProPWisconsinC { get; set; }
        public string ProPCDC { get; set; }
        public string ProPIsolaC { get; set; }
        public string ProPOthersC { get; set; }
        public string ProPOthersT { get; set; }
        public string ProAnteriorLevelR { get; set; }
        public string ProAnteriorFromS { get; set; }
        public string ProAnteriorToS { get; set; }
        public string ProAnteriorLevelF { get; set; }
        public string ProAZielkeC { get; set; }
        public string ProAHalmC { get; set; }
        public string ProAIsolaC { get; set; }
        public string ProAOthersC { get; set; }
        public string ProAOthersT { get; set; }
        public string ProThoracoscopicR { get; set; }
        public string ProSurgeonT { get; set; }
        public string ProThoracoscopicFromT { get; set; }
        public string ProThoracoscopicToT { get; set; }
        public string ProThoracoscopicSideS { get; set; }
        public string ProBoneR { get; set; }
        public string ProAutologousC { get; set; }
        public string ProAutologousF { get; set; }
        public string ProAllograftC { get; set; }
        public string ProAllograftF { get; set; }
        public string ProBoneOthersC { get; set; }
        public string ProBoneOthersT { get; set; }
        public string ProWakeR { get; set; }
        public string ProWakeT { get; set; }
        public string ProSSEPR { get; set; }
        public string ProSSEPT { get; set; }
        public string ProMEPR { get; set; }
        public string ProMEPT { get; set; }
        public string ProImplantA { get; set; }
        public string ProOthersA { get; set; }
        public string ProRemarkA { get; set; }
        public string PostTransfusionWholeF { get; set; }
        public string PostTransfusionPackedF { get; set; }
        public string PostLastHbF { get; set; }
        public string PostLastHbDayF { get; set; }
        public string PostPreOpHbF { get; set; }
        public string PostPlateletF { get; set; }
        public string PostFFPF { get; set; }
        public string PostDaysF { get; set; }
        public string PostBracingR { get; set; }
        public string PostBracingT { get; set; }
        public string PostComplicationA { get; set; }
        public string PostWithBraceC { get; set; }
        public string PostACobbsF { get; set; }
        public string PostAPreAVTF { get; set; }
        public string PostAPreAVTS { get; set; }
        public string PostAPostAVTF { get; set; }
        public string PostAPostAVTS { get; set; }
        public string PostBCobbsF { get; set; }
        public string PostBPreAVTF { get; set; }
        public string PostBPreAVTS { get; set; }
        public string PostBPostAVTF { get; set; }
        public string PostBPostAVTS { get; set; }
        public string PostCCobbsF { get; set; }
        public string PostCPreAVTF { get; set; }
        public string PostCPreAVTS { get; set; }
        public string PostCPostAVTF { get; set; }
        public string PostCPostAVTS { get; set; }
        public string PostDCobbsF { get; set; }
        public string PostDPreAVTF { get; set; }
        public string PostDPreAVTS { get; set; }
        public string PostDPostAVTF { get; set; }
        public string PostDPostAVTS { get; set; }
        public string PostPreOpTrunkF { get; set; }
        public string PostPreOpTrunkS { get; set; }
        public string PostPostOpTrunkF { get; set; }
        public string PostPostOpTrunkS { get; set; }
        public string PostUpperF { get; set; }
        public string PostUpperS { get; set; }
        public string PostLowerF { get; set; }
        public string PostLowerS { get; set; }
        public string PostRemarkA { get; set; }

        public static explicit operator OperativeDataViewModel(InfoOperativeDataViewModel infoOperativeDataViewModel)
        {

            var operativeDataViewModel = new OperativeDataViewModel();

            operativeDataViewModel.SCN = infoOperativeDataViewModel.SCN;

            operativeDataViewModel.RecordID = (short)infoOperativeDataViewModel.RecordID;


            if (infoOperativeDataViewModel.PreRisserS == "" || infoOperativeDataViewModel.PreRisserS == null)
            {
                operativeDataViewModel.PreRisserS = null;
            }
            else
            {
                operativeDataViewModel.PreRisserS = infoOperativeDataViewModel.PreRisserS;
            }

            if (infoOperativeDataViewModel.PreHeightF == "" || infoOperativeDataViewModel.PreHeightF == null)
            {
                operativeDataViewModel.PreHeightF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreHeightF, out Double result) == false)
                {
                    throw new Exception("Pre HeightF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreHeightF = Double.Parse(infoOperativeDataViewModel.PreHeightF);
            }

            if (infoOperativeDataViewModel.PreArmSpanF == "" || infoOperativeDataViewModel.PreArmSpanF == null)
            {
                operativeDataViewModel.PreArmSpanF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreArmSpanF, out Double result) == false)
                {
                    throw new Exception("Pre ArmSpanF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreArmSpanF = Double.Parse(infoOperativeDataViewModel.PreArmSpanF);
            }

            if (infoOperativeDataViewModel.PreWeightF == "" || infoOperativeDataViewModel.PreWeightF == null)
            {
                operativeDataViewModel.PreWeightF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreWeightF, out Double result) == false)
                {
                    throw new Exception("PreWeightF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreWeightF = Double.Parse(infoOperativeDataViewModel.PreWeightF);
            }


            if (infoOperativeDataViewModel.PreSittingF == "" || infoOperativeDataViewModel.PreSittingF == null)
            {
                operativeDataViewModel.PreSittingF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreSittingF, out Double result) == false)
                {
                    throw new Exception("PreSittingF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreSittingF = Double.Parse(infoOperativeDataViewModel.PreSittingF);
            }


            if (infoOperativeDataViewModel.PreARankS == "" || infoOperativeDataViewModel.PreARankS == null)
            {
                operativeDataViewModel.PreARankS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PreARankS, out Char result) == false)
                {
                    throw new Exception("PreSittingF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreARankS = Char.Parse(infoOperativeDataViewModel.PreARankS);
            }

            if (infoOperativeDataViewModel.PreASideS == "" || infoOperativeDataViewModel.PreASideS == null)
            {
                operativeDataViewModel.PreASideS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PreASideS, out Char result) == false)
                {
                    throw new Exception("PreASideS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreASideS = Char.Parse(infoOperativeDataViewModel.PreASideS);
            }


            if (infoOperativeDataViewModel.PreALevelFromS == "" || infoOperativeDataViewModel.PreALevelFromS == null)
            {
                operativeDataViewModel.PreALevelFromS = null;
            }
            else
            {
                operativeDataViewModel.PreALevelFromS = infoOperativeDataViewModel.PreALevelFromS;
            }

            if (infoOperativeDataViewModel.PreALevelToS == "" || infoOperativeDataViewModel.PreALevelToS == null)
            {
                operativeDataViewModel.PreALevelToS = null;
            }
            else
            {
                operativeDataViewModel.PreALevelToS = infoOperativeDataViewModel.PreALevelToS;
            }

            if (infoOperativeDataViewModel.PreAApexS == "" || infoOperativeDataViewModel.PreAApexS == null)
            {
                operativeDataViewModel.PreAApexS = null;
            }
            else
            {
                operativeDataViewModel.PreAApexS = infoOperativeDataViewModel.PreAApexS;
            }


            if (infoOperativeDataViewModel.PreACobbsAngleF == "" || infoOperativeDataViewModel.PreACobbsAngleF == null)
            {
                operativeDataViewModel.PreACobbsAngleF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreACobbsAngleF, out Double result) == false)
                {
                    throw new Exception("PreACobbsAngleF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreACobbsAngleF = Double.Parse(infoOperativeDataViewModel.PreACobbsAngleF);
            }

            if (infoOperativeDataViewModel.PreAFulcrumF == "" || infoOperativeDataViewModel.PreAFulcrumF == null)
            {
                operativeDataViewModel.PreAFulcrumF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreAFulcrumF, out Double result) == false)
                {
                    throw new Exception("PreAFulcrumF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreAFulcrumF = Double.Parse(infoOperativeDataViewModel.PreAFulcrumF);
            }


            if (infoOperativeDataViewModel.PreABendingF == "" || infoOperativeDataViewModel.PreABendingF == null)
            {
                operativeDataViewModel.PreABendingF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreABendingF, out Double result) == false)
                {
                    throw new Exception("PreABendingF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreABendingF = Double.Parse(infoOperativeDataViewModel.PreABendingF);
            }


            if (infoOperativeDataViewModel.PreBRankS == "" || infoOperativeDataViewModel.PreBRankS == null)
            {
                operativeDataViewModel.PreBRankS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PreBRankS, out Char result) == false)
                {
                    throw new Exception("PreBRankS should be Char, e.g. 0.00");
                }

                operativeDataViewModel.PreBRankS = Char.Parse(infoOperativeDataViewModel.PreBRankS);
            }

            if (infoOperativeDataViewModel.PreBSideS == "" || infoOperativeDataViewModel.PreBSideS == null)
            {
                operativeDataViewModel.PreBSideS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PreBSideS, out Char result) == false)
                {
                    throw new Exception("PreBSideS should be Char, e.g. 0.00");
                }

                operativeDataViewModel.PreBSideS = Char.Parse(infoOperativeDataViewModel.PreBSideS);
            }


            if (infoOperativeDataViewModel.PreBLevelFromS == "" || infoOperativeDataViewModel.PreBLevelFromS == null)
            {
                operativeDataViewModel.PreBLevelFromS = null;
            }
            else
            {
                operativeDataViewModel.PreBLevelFromS = infoOperativeDataViewModel.PreBLevelFromS;
            }

            if (infoOperativeDataViewModel.PreBLevelFromS == "" || infoOperativeDataViewModel.PreBLevelFromS == null)
            {
                operativeDataViewModel.PreBLevelFromS = null;
            }
            else
            {
                operativeDataViewModel.PreBLevelFromS = infoOperativeDataViewModel.PreBLevelFromS;
            }


            if (infoOperativeDataViewModel.PreBLevelToS == "" || infoOperativeDataViewModel.PreBLevelToS == null)
            {
                operativeDataViewModel.PreBLevelToS = null;
            }
            else
            {
                operativeDataViewModel.PreBLevelToS = infoOperativeDataViewModel.PreBLevelToS;
            }

            if (infoOperativeDataViewModel.PreBApexS == "" || infoOperativeDataViewModel.PreBApexS == null)
            {
                operativeDataViewModel.PreBApexS = null;
            }
            else
            {
                operativeDataViewModel.PreBApexS = infoOperativeDataViewModel.PreBApexS;
            }


            if (infoOperativeDataViewModel.PreBCobbsAngleF == "" || infoOperativeDataViewModel.PreBCobbsAngleF == null)
            {
                operativeDataViewModel.PreBCobbsAngleF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreBCobbsAngleF, out Double result) == false)
                {
                    throw new Exception("PreBCobbsAngleF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreBCobbsAngleF = Double.Parse(infoOperativeDataViewModel.PreBCobbsAngleF);
            }


            if (infoOperativeDataViewModel.PreBFulcrumF == "" || infoOperativeDataViewModel.PreBFulcrumF == null)
            {
                operativeDataViewModel.PreBFulcrumF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreBFulcrumF, out Double result) == false)
                {
                    throw new Exception("PreBCobbsAngleF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreBFulcrumF = Double.Parse(infoOperativeDataViewModel.PreBFulcrumF);
            }

            if (infoOperativeDataViewModel.PreBBendingF == "" || infoOperativeDataViewModel.PreBBendingF == null)
            {
                operativeDataViewModel.PreBBendingF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreBBendingF, out Double result) == false)
                {
                    throw new Exception("PreBBendingF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreBBendingF = Double.Parse(infoOperativeDataViewModel.PreBBendingF);
            }

            if (infoOperativeDataViewModel.PreCRankS == "" || infoOperativeDataViewModel.PreCRankS == null)
            {
                operativeDataViewModel.PreCRankS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PreCRankS, out Char result) == false)
                {
                    throw new Exception("PreCRankS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreCRankS = Char.Parse(infoOperativeDataViewModel.PreCRankS);
            }


            if (infoOperativeDataViewModel.PreCSideS == "" || infoOperativeDataViewModel.PreCSideS == null)
            {
                operativeDataViewModel.PreCSideS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PreCSideS, out Char result) == false)
                {
                    throw new Exception("PreCSideS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreCSideS = Char.Parse(infoOperativeDataViewModel.PreCSideS);
            }


            if (infoOperativeDataViewModel.PreCLevelFromS == "" || infoOperativeDataViewModel.PreCLevelToS == null)
            {
                operativeDataViewModel.PreCLevelFromS = null;
            }
            else
            {
                operativeDataViewModel.PreCLevelFromS = infoOperativeDataViewModel.PreCLevelFromS;
            }

            if (infoOperativeDataViewModel.PreCLevelToS == "" || infoOperativeDataViewModel.PreBBendingF == null)
            {
                operativeDataViewModel.PreCLevelToS = null;
            }
            else
            {
                operativeDataViewModel.PreCLevelToS = infoOperativeDataViewModel.PreCLevelToS;
            }

            if (infoOperativeDataViewModel.PreCApexS == "" || infoOperativeDataViewModel.PreCApexS == null)
            {
                operativeDataViewModel.PreCApexS = null;
            }
            else
            {
                operativeDataViewModel.PreCApexS = infoOperativeDataViewModel.PreCApexS;
            }


            if (infoOperativeDataViewModel.PreCCobbsAngleF == "" || infoOperativeDataViewModel.PreCCobbsAngleF == null)
            {
                operativeDataViewModel.PreCCobbsAngleF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreCCobbsAngleF, out Double result) == false)
                {
                    throw new Exception("PreCSideS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreCCobbsAngleF = Double.Parse(infoOperativeDataViewModel.PreCCobbsAngleF);
            }


            if (infoOperativeDataViewModel.PreCFulcrumF == "" || infoOperativeDataViewModel.PreCFulcrumF == null)
            {
                operativeDataViewModel.PreCFulcrumF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreCFulcrumF, out Double result) == false)
                {
                    throw new Exception("PreCSideS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreCFulcrumF = Double.Parse(infoOperativeDataViewModel.PreCFulcrumF);
            }


            if (infoOperativeDataViewModel.PreCBendingF == "" || infoOperativeDataViewModel.PreCBendingF == null)
            {
                operativeDataViewModel.PreCBendingF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreCBendingF, out Double result) == false)
                {
                    throw new Exception("PreCSideS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreCBendingF = Double.Parse(infoOperativeDataViewModel.PreCBendingF);
            }


            if (infoOperativeDataViewModel.PreDRankS == "" || infoOperativeDataViewModel.PreDRankS == null)
            {
                operativeDataViewModel.PreDRankS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PreDRankS, out Char result) == false)
                {
                    throw new Exception("PreCSideS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreDRankS = Char.Parse(infoOperativeDataViewModel.PreDRankS);
            }


            if (infoOperativeDataViewModel.PreDSideS == "" || infoOperativeDataViewModel.PreDSideS == null)
            {
                operativeDataViewModel.PreDSideS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PreDSideS, out Char result) == false)
                {
                    throw new Exception("PreCSideS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreDSideS = Char.Parse(infoOperativeDataViewModel.PreDSideS);
            }


            if (infoOperativeDataViewModel.PreDLevelFromS == "" || infoOperativeDataViewModel.PreDLevelFromS == null)
            {
                operativeDataViewModel.PreDLevelFromS = null;
            }
            else
            {
                operativeDataViewModel.PreDLevelFromS = infoOperativeDataViewModel.PreDLevelFromS;
            }

            if (infoOperativeDataViewModel.PreDLevelToS == "" || infoOperativeDataViewModel.PreDLevelToS == null)
            {
                operativeDataViewModel.PreDLevelToS = null;
            }
            else
            {
                operativeDataViewModel.PreDLevelToS = infoOperativeDataViewModel.PreDLevelToS;
            }


            if (infoOperativeDataViewModel.PreDApexS == "" || infoOperativeDataViewModel.PreDApexS == null)
            {
                operativeDataViewModel.PreDApexS = null;
            }
            else
            {
                operativeDataViewModel.PreDApexS = infoOperativeDataViewModel.PreDApexS;
            }


            if (infoOperativeDataViewModel.PreDCobbsAngleF == "" || infoOperativeDataViewModel.PreDCobbsAngleF == null)
            {
                operativeDataViewModel.PreDCobbsAngleF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreDCobbsAngleF, out Double result) == false)
                {
                    throw new Exception("PreCSideS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreDCobbsAngleF = Double.Parse(infoOperativeDataViewModel.PreDCobbsAngleF);
            }


            if (infoOperativeDataViewModel.PreDFulcrumF == "" || infoOperativeDataViewModel.PreDFulcrumF == null)
            {
                operativeDataViewModel.PreDFulcrumF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreDFulcrumF, out Double result) == false)
                {
                    throw new Exception("PreCSideS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreDFulcrumF = Double.Parse(infoOperativeDataViewModel.PreDFulcrumF);
            }

            if (infoOperativeDataViewModel.PreDBendingF == "" || infoOperativeDataViewModel.PreDBendingF == null)
            {
                operativeDataViewModel.PreDBendingF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreDBendingF, out Double result) == false)
                {
                    throw new Exception("PreCSideS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreDBendingF = Double.Parse(infoOperativeDataViewModel.PreDBendingF);
            }


            if (infoOperativeDataViewModel.PreMRIR == "" || infoOperativeDataViewModel.PreMRIR == null)
            {
                operativeDataViewModel.PreMRIR = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PreMRIR, out Char result) == false)
                {
                    throw new Exception("PreCSideS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreMRIR = Char.Parse(infoOperativeDataViewModel.PreMRIR);
            }


            if (infoOperativeDataViewModel.PreMRIT == "" || infoOperativeDataViewModel.PreMRIT == null)
            {
                operativeDataViewModel.PreMRIT = null;
            }
            else
            {
                operativeDataViewModel.PreMRIT = infoOperativeDataViewModel.PreMRIT;
            }


            if (infoOperativeDataViewModel.PreSSEPRF == "" || infoOperativeDataViewModel.PreSSEPRF == null)
            {
                operativeDataViewModel.PreSSEPRF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreSSEPRF, out Double result) == false)
                {
                    throw new Exception("PreCSideS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreSSEPRF = Double.Parse(infoOperativeDataViewModel.PreSSEPRF);
            }



            if (infoOperativeDataViewModel.PreSSEPLF == "" || infoOperativeDataViewModel.PreSSEPLF == null)
            {
                operativeDataViewModel.PreSSEPLF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreSSEPLF, out Double result) == false)
                {
                    throw new Exception("PreCSideS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreSSEPLF = Double.Parse(infoOperativeDataViewModel.PreSSEPLF);
            }

            if (infoOperativeDataViewModel.PreSSEPRP37F == "" || infoOperativeDataViewModel.PreSSEPRP37F == null)
            {
                operativeDataViewModel.PreSSEPRP37F = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreSSEPRP37F, out Double result) == false)
                {
                    throw new Exception("PreCSideS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreSSEPRP37F = Double.Parse(infoOperativeDataViewModel.PreSSEPRP37F);
            }

            if (infoOperativeDataViewModel.PreSSEPRN45F == "" || infoOperativeDataViewModel.PreSSEPRN45F == null)
            {
                operativeDataViewModel.PreSSEPRN45F = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreSSEPRN45F, out Double result) == false)
                {
                    throw new Exception("PreCSideS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreSSEPRN45F = Double.Parse(infoOperativeDataViewModel.PreSSEPRN45F);
            }



            if (infoOperativeDataViewModel.PreLumbarF == "" || infoOperativeDataViewModel.PreLumbarF == null)
            {
                operativeDataViewModel.PreLumbarF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreLumbarF, out Double result) == false)
                {
                    throw new Exception("PreCSideS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreLumbarF = Double.Parse(infoOperativeDataViewModel.PreLumbarF);
            }


            if (infoOperativeDataViewModel.PreZScoreF == "" || infoOperativeDataViewModel.PreZScoreF == null)
            {
                operativeDataViewModel.PreZScoreF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreZScoreF, out Double result) == false)
                {
                    throw new Exception("PreZScoreF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreZScoreF = Double.Parse(infoOperativeDataViewModel.PreZScoreF);
            }


            if (infoOperativeDataViewModel.PreRBMDF == "" || infoOperativeDataViewModel.PreRBMDF == null)
            {
                operativeDataViewModel.PreRBMDF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreRBMDF, out Double result) == false)
                {
                    throw new Exception("PreRBMDF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreRBMDF = Double.Parse(infoOperativeDataViewModel.PreRBMDF);
            }


            if (infoOperativeDataViewModel.PreRZScoreF == "" || infoOperativeDataViewModel.PreRZScoreF == null)
            {
                operativeDataViewModel.PreRZScoreF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreRZScoreF, out Double result) == false)
                {
                    throw new Exception("PreRZScoreF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreRZScoreF = Double.Parse(infoOperativeDataViewModel.PreRZScoreF);
            }

            if (infoOperativeDataViewModel.PreLBMDF == "" || infoOperativeDataViewModel.PreLBMDF == null)
            {
                operativeDataViewModel.PreLBMDF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreLBMDF, out Double result) == false)
                {
                    throw new Exception("PreRZScoreF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreLBMDF = Double.Parse(infoOperativeDataViewModel.PreLBMDF);
            }


            if (infoOperativeDataViewModel.PreLZScoreF == "" || infoOperativeDataViewModel.PreLZScoreF == null)
            {
                operativeDataViewModel.PreLZScoreF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreLZScoreF, out Double result) == false)
                {
                    throw new Exception("PreRZScoreF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreLZScoreF = Double.Parse(infoOperativeDataViewModel.PreLZScoreF);
            }



            if (infoOperativeDataViewModel.PreTibiaRD50F == "" || infoOperativeDataViewModel.PreTibiaRD50F == null)
            {
                operativeDataViewModel.PreTibiaRD50F = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreTibiaRD50F, out Double result) == false)
                {
                    throw new Exception("PreTibiaRD50F should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreTibiaRD50F = Double.Parse(infoOperativeDataViewModel.PreTibiaRD50F);
            }

            if (infoOperativeDataViewModel.PreTibiaLD50F == "" || infoOperativeDataViewModel.PreTibiaLD50F == null)
            {
                operativeDataViewModel.PreTibiaLD50F = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreTibiaLD50F, out Double result) == false)
                {
                    throw new Exception("PreTibiaLD50F should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreTibiaLD50F = Double.Parse(infoOperativeDataViewModel.PreTibiaLD50F);
            }


            if (infoOperativeDataViewModel.PreTibiaRD100F == "" || infoOperativeDataViewModel.PreTibiaRD100F == null)
            {
                operativeDataViewModel.PreTibiaRD100F = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreTibiaRD100F, out Double result) == false)
                {
                    throw new Exception("PreTibiaRD100F should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreTibiaRD100F = Double.Parse(infoOperativeDataViewModel.PreTibiaRD100F);
            }



            if (infoOperativeDataViewModel.PreTibiaLD100F == "" || infoOperativeDataViewModel.PreTibiaLD100F == null)
            {
                operativeDataViewModel.PreTibiaLD100F = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreTibiaLD100F, out Double result) == false)
                {
                    throw new Exception("PreTibiaRD100F should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreTibiaLD100F = Double.Parse(infoOperativeDataViewModel.PreTibiaLD100F);
            }

            if (infoOperativeDataViewModel.PreRadiusRD50F == "" || infoOperativeDataViewModel.PreRadiusRD50F == null)
            {
                operativeDataViewModel.PreRadiusRD50F = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreRadiusRD50F, out Double result) == false)
                {
                    throw new Exception("PreRadiusRD50F should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreRadiusRD50F = Double.Parse(infoOperativeDataViewModel.PreRadiusRD50F);
            }

            if (infoOperativeDataViewModel.PreRadiusLD50F == "" || infoOperativeDataViewModel.PreRadiusLD50F == null)
            {
                operativeDataViewModel.PreRadiusLD50F = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreRadiusLD50F, out Double result) == false)
                {
                    throw new Exception("PreRadiusLD50F should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreRadiusLD50F = Double.Parse(infoOperativeDataViewModel.PreRadiusLD50F);
            }

            if (infoOperativeDataViewModel.PreRadiusRD100F == "" || infoOperativeDataViewModel.PreRadiusRD100F == null)
            {
                operativeDataViewModel.PreRadiusRD100F = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreRadiusRD100F, out Double result) == false)
                {
                    throw new Exception("PreRadiusRD100F should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreRadiusRD100F = Double.Parse(infoOperativeDataViewModel.PreRadiusRD100F);
            }


            if (infoOperativeDataViewModel.PreRadiusLD100F == "" || infoOperativeDataViewModel.PreRadiusLD100F == null)
            {
                operativeDataViewModel.PreRadiusLD100F = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreRadiusLD100F, out Double result) == false)
                {
                    throw new Exception("PreRadiusLD100F should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreRadiusLD100F = Double.Parse(infoOperativeDataViewModel.PreRadiusLD100F);
            }

            if (infoOperativeDataViewModel.PreFVCPredictionF == "" || infoOperativeDataViewModel.PreFVCPredictionF == null)
            {
                operativeDataViewModel.PreFVCPredictionF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreFVCPredictionF, out Double result) == false)
                {
                    throw new Exception("PreFVCPredictionF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreFVCPredictionF = Double.Parse(infoOperativeDataViewModel.PreFVCPredictionF);
            }


            if (infoOperativeDataViewModel.PreFVCObservedF == "" || infoOperativeDataViewModel.PreFVCObservedF == null)
            {
                operativeDataViewModel.PreFVCObservedF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreFVCObservedF, out Double result) == false)
                {
                    throw new Exception("PreFVCObservedF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreFVCObservedF = Double.Parse(infoOperativeDataViewModel.PreFVCObservedF);
            }


            if (infoOperativeDataViewModel.PreFEV1PredictionF == "" || infoOperativeDataViewModel.PreFEV1PredictionF == null)
            {
                operativeDataViewModel.PreFEV1PredictionF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreFEV1PredictionF, out Double result) == false)
                {
                    throw new Exception("PreFEV1PredictionF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreFEV1PredictionF = Double.Parse(infoOperativeDataViewModel.PreFEV1PredictionF);
            }

            if (infoOperativeDataViewModel.PreFEV1ObservedF == "" || infoOperativeDataViewModel.PreFEV1ObservedF == null)
            {
                operativeDataViewModel.PreFEV1ObservedF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreFEV1ObservedF, out Double result) == false)
                {
                    throw new Exception("PreFEV1ObservedF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreFEV1ObservedF = Double.Parse(infoOperativeDataViewModel.PreFEV1ObservedF);
            }


            if (infoOperativeDataViewModel.PreECGT == "" || infoOperativeDataViewModel.PreECGT == null)
            {
                operativeDataViewModel.PreECGT = null;
            }
            else
            {
                operativeDataViewModel.PreECGT = infoOperativeDataViewModel.PreECGT;
            }


            if (infoOperativeDataViewModel.PreINRF == "" || infoOperativeDataViewModel.PreINRF == null)
            {
                operativeDataViewModel.PreINRF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreINRF, out Double result) == false)
                {
                    throw new Exception("PreINRF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreINRF = Double.Parse(infoOperativeDataViewModel.PreINRF);
            }

            if (infoOperativeDataViewModel.PrePTF == "" || infoOperativeDataViewModel.PrePTF == null)
            {
                operativeDataViewModel.PrePTF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PrePTF, out Double result) == false)
                {
                    throw new Exception("PrePTF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PrePTF = Double.Parse(infoOperativeDataViewModel.PrePTF);
            }

            if (infoOperativeDataViewModel.PreaPTTF == "" || infoOperativeDataViewModel.PreaPTTF == null)
            {
                operativeDataViewModel.PreaPTTF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PreaPTTF, out Double result) == false)
                {
                    throw new Exception("PrePTF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PreaPTTF = Double.Parse(infoOperativeDataViewModel.PreaPTTF);
            }

            if (infoOperativeDataViewModel.PrePlateletF == "" || infoOperativeDataViewModel.PrePlateletF == null)
            {
                operativeDataViewModel.PrePlateletF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PrePlateletF, out Double result) == false)
                {
                    throw new Exception("PrePlateletF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PrePlateletF = Double.Parse(infoOperativeDataViewModel.PrePlateletF);
            }


            if (infoOperativeDataViewModel.PreCommentsA == "" || infoOperativeDataViewModel.PreCommentsA == null)
            {
                operativeDataViewModel.PreCommentsA = null;
            }
            else
            {
                operativeDataViewModel.PreCommentsA = infoOperativeDataViewModel.PreCommentsA;
            }



            if (infoOperativeDataViewModel.PlanDateD == "" || infoOperativeDataViewModel.PlanDateD == null)
            {
                operativeDataViewModel.PlanDateD = null;
            }
            else
            {
                if (DateTime.TryParse(infoOperativeDataViewModel.PlanDateD, out DateTime result) == false)
                {
                    throw new Exception("PlanDateD should be datetime(dd/mm/yyyy), e.g. 0.00");
                }

                operativeDataViewModel.PlanDateD = DateTime.ParseExact(infoOperativeDataViewModel.PlanDateD, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }

            if (string.IsNullOrEmpty(infoOperativeDataViewModel.PlanDoctorS))
            {
                operativeDataViewModel.PlanDoctorS = "";
            }
            else
            {
                operativeDataViewModel.PlanDoctorS = infoOperativeDataViewModel.PlanDoctorS;
            }


            if (infoOperativeDataViewModel.PlanARankS == "" || infoOperativeDataViewModel.PlanARankS == null)
            {
                operativeDataViewModel.PlanARankS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PlanARankS, out Char result) == false)
                {
                    throw new Exception("PlanARankS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanARankS = Char.Parse(infoOperativeDataViewModel.PlanARankS);
            }


            if (infoOperativeDataViewModel.PlanASideS == "" || infoOperativeDataViewModel.PlanASideS == null)
            {
                operativeDataViewModel.PlanASideS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PlanASideS, out Char result) == false)
                {
                    throw new Exception("PlanASideS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanASideS = Char.Parse(infoOperativeDataViewModel.PlanASideS);
            }


            if (infoOperativeDataViewModel.PlanALevelFromS == "" || infoOperativeDataViewModel.PlanALevelFromS == null)
            {
                operativeDataViewModel.PlanALevelFromS = null;
            }
            else
            {
                operativeDataViewModel.PlanALevelFromS = infoOperativeDataViewModel.PlanALevelFromS;
            }


            if (infoOperativeDataViewModel.PlanALevelToS == "" || infoOperativeDataViewModel.PlanALevelToS == null)
            {
                operativeDataViewModel.PlanALevelToS = null;
            }
            else
            {
                operativeDataViewModel.PlanALevelToS = infoOperativeDataViewModel.PlanALevelToS;
            }


            if (infoOperativeDataViewModel.PlanAApexS == "" || infoOperativeDataViewModel.PlanAApexS == null)
            {
                operativeDataViewModel.PlanAApexS = null;
            }
            else
            {
                operativeDataViewModel.PlanAApexS = infoOperativeDataViewModel.PlanAApexS;
            }


            if (infoOperativeDataViewModel.PlanACobbsAngleF == "" || infoOperativeDataViewModel.PlanACobbsAngleF == null)
            {
                operativeDataViewModel.PlanACobbsAngleF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PlanACobbsAngleF, out Double result) == false)
                {
                    throw new Exception("PlanACobbsAngleF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanACobbsAngleF = Double.Parse(infoOperativeDataViewModel.PlanACobbsAngleF);
            }

            if (infoOperativeDataViewModel.PlanAFulcrumF == "" || infoOperativeDataViewModel.PlanAFulcrumF == null)
            {
                operativeDataViewModel.PlanAFulcrumF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PlanAFulcrumF, out Double result) == false)
                {
                    throw new Exception("PlanAFulcrumF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanAFulcrumF = Double.Parse(infoOperativeDataViewModel.PlanAFulcrumF);
            }


            if (infoOperativeDataViewModel.PlanABendingF == "" || infoOperativeDataViewModel.PlanABendingF == null)
            {
                operativeDataViewModel.PlanABendingF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PlanABendingF, out Double result) == false)
                {
                    throw new Exception("PlanABendingF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanABendingF = Double.Parse(infoOperativeDataViewModel.PlanABendingF);
            }

            if (infoOperativeDataViewModel.PlanBRankS == "" || infoOperativeDataViewModel.PlanBRankS == null)
            {
                operativeDataViewModel.PlanBRankS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PlanBRankS, out Char result) == false)
                {
                    throw new Exception("PlanBRankS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanBRankS = Char.Parse(infoOperativeDataViewModel.PlanBRankS);
            }


            if (infoOperativeDataViewModel.PlanBSideS == "" || infoOperativeDataViewModel.PlanBSideS == null)
            {
                operativeDataViewModel.PlanBSideS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PlanBSideS, out Char result) == false)
                {
                    throw new Exception("PlanBSideS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanBSideS = Char.Parse(infoOperativeDataViewModel.PlanBSideS);
            }



            if (infoOperativeDataViewModel.PlanBLevelFromS == "" || infoOperativeDataViewModel.PlanBLevelFromS == null)
            {
                operativeDataViewModel.PlanBLevelFromS = null;
            }
            else
            {
                operativeDataViewModel.PlanBLevelFromS = infoOperativeDataViewModel.PlanBLevelFromS;
            }


            if (infoOperativeDataViewModel.PlanBLevelToS == "" || infoOperativeDataViewModel.PlanBLevelToS == null)
            {
                operativeDataViewModel.PlanBLevelToS = null;
            }
            else
            {
                operativeDataViewModel.PlanBLevelToS = infoOperativeDataViewModel.PlanBLevelToS;
            }


            if (infoOperativeDataViewModel.PlanBApexS == "" || infoOperativeDataViewModel.PlanBApexS == null)
            {
                operativeDataViewModel.PlanBApexS = null;
            }
            else
            {
                operativeDataViewModel.PlanBApexS = infoOperativeDataViewModel.PlanBApexS;
            }



            if (infoOperativeDataViewModel.PlanBCobbsAngleF == "" || infoOperativeDataViewModel.PlanBCobbsAngleF == null)
            {
                operativeDataViewModel.PlanBCobbsAngleF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PlanBCobbsAngleF, out Double result) == false)
                {
                    throw new Exception("PlanBCobbsAngleF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanBCobbsAngleF = Double.Parse(infoOperativeDataViewModel.PlanBCobbsAngleF);
            }

            if (infoOperativeDataViewModel.PlanBFulcrumF == "" || infoOperativeDataViewModel.PlanBFulcrumF == null)
            {
                operativeDataViewModel.PlanBFulcrumF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PlanBFulcrumF, out Double result) == false)
                {
                    throw new Exception("PlanBCobbsAngleF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanBFulcrumF = Double.Parse(infoOperativeDataViewModel.PlanBFulcrumF);
            }


            if (infoOperativeDataViewModel.PlanBBendingF == "" || infoOperativeDataViewModel.PlanBBendingF == null)
            {
                operativeDataViewModel.PlanBBendingF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PlanBBendingF, out Double result) == false)
                {
                    throw new Exception("PlanBBendingF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanBBendingF = Double.Parse(infoOperativeDataViewModel.PlanBBendingF);
            }

            if (infoOperativeDataViewModel.PlanCRankS == "" || infoOperativeDataViewModel.PlanCRankS == null)
            {
                operativeDataViewModel.PlanCRankS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PlanCRankS, out Char result) == false)
                {
                    throw new Exception("PlanCRankS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanCRankS = Char.Parse(infoOperativeDataViewModel.PlanCRankS);
            }

            if (infoOperativeDataViewModel.PlanCSideS == "" || infoOperativeDataViewModel.PlanCSideS == null)
            {
                operativeDataViewModel.PlanCSideS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PlanCSideS, out Char result) == false)
                {
                    throw new Exception("PlanCSideS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanCSideS = Char.Parse(infoOperativeDataViewModel.PlanCSideS);
            }

            if (infoOperativeDataViewModel.PlanCLevelFromS == "" || infoOperativeDataViewModel.PlanCLevelFromS == null)
            {
                operativeDataViewModel.PlanCLevelFromS = null;
            }
            else
            {
                operativeDataViewModel.PlanCLevelFromS = infoOperativeDataViewModel.PlanCLevelFromS;
            }


            if (infoOperativeDataViewModel.PlanCLevelToS == "" || infoOperativeDataViewModel.PlanCLevelToS == null)
            {
                operativeDataViewModel.PlanCLevelToS = null;
            }
            else
            {
                operativeDataViewModel.PlanCLevelToS = infoOperativeDataViewModel.PlanCLevelToS;
            }

            if (infoOperativeDataViewModel.PlanCApexS == "" || infoOperativeDataViewModel.PlanCApexS == null)
            {
                operativeDataViewModel.PlanCApexS = null;
            }
            else
            {
                operativeDataViewModel.PlanCApexS = infoOperativeDataViewModel.PlanCApexS;
            }

            if (infoOperativeDataViewModel.PlanCCobbsAngleF == "" || infoOperativeDataViewModel.PlanCCobbsAngleF == null)
            {
                operativeDataViewModel.PlanCCobbsAngleF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PlanCCobbsAngleF, out Double result) == false)
                {
                    throw new Exception("PlanCCobbsAngleF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanCCobbsAngleF = Double.Parse(infoOperativeDataViewModel.PlanCCobbsAngleF);
            }

            if (infoOperativeDataViewModel.PlanCFulcrumF == "" || infoOperativeDataViewModel.PlanCFulcrumF == null)
            {
                operativeDataViewModel.PlanCFulcrumF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PlanCFulcrumF, out Double result) == false)
                {
                    throw new Exception("PlanCFulcrumF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanCFulcrumF = Double.Parse(infoOperativeDataViewModel.PlanCFulcrumF);
            }

            if (infoOperativeDataViewModel.PlanCBendingF == "" || infoOperativeDataViewModel.PlanCBendingF == null)
            {
                operativeDataViewModel.PlanCBendingF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PlanCBendingF, out Double result) == false)
                {
                    throw new Exception("PlanCBendingF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanCBendingF = Double.Parse(infoOperativeDataViewModel.PlanCBendingF);
            }

            if (infoOperativeDataViewModel.PlanDRankS == "" || infoOperativeDataViewModel.PlanDRankS == null)
            {
                operativeDataViewModel.PlanDRankS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PlanDRankS, out Char result) == false)
                {
                    throw new Exception("PlanDRankS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanDRankS = Char.Parse(infoOperativeDataViewModel.PlanDRankS);
            }


            if (infoOperativeDataViewModel.PlanDSideS == "" || infoOperativeDataViewModel.PlanDSideS == null)
            {
                operativeDataViewModel.PlanDSideS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PlanDSideS, out Char result) == false)
                {
                    throw new Exception("PlanDSideS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanDSideS = Char.Parse(infoOperativeDataViewModel.PlanDSideS);
            }


            if (infoOperativeDataViewModel.PlanDLevelFromS == "" || infoOperativeDataViewModel.PlanDLevelFromS == null)
            {
                operativeDataViewModel.PlanDLevelFromS = null;
            }
            else
            {
                operativeDataViewModel.PlanDLevelFromS = infoOperativeDataViewModel.PlanDLevelFromS;
            }

            if (infoOperativeDataViewModel.PlanDLevelToS == "" || infoOperativeDataViewModel.PlanDLevelToS == null)
            {
                operativeDataViewModel.PlanDLevelToS = null;
            }
            else
            {
                operativeDataViewModel.PlanDLevelToS = infoOperativeDataViewModel.PlanDLevelToS;
            }


            if (infoOperativeDataViewModel.PlanDApexS == "" || infoOperativeDataViewModel.PlanDApexS == null)
            {
                operativeDataViewModel.PlanDApexS = null;
            }
            else
            {
                operativeDataViewModel.PlanDApexS = infoOperativeDataViewModel.PlanDApexS;
            }


            if (infoOperativeDataViewModel.PlanDCobbsAngleF == "" || infoOperativeDataViewModel.PlanDCobbsAngleF == null)
            {
                operativeDataViewModel.PlanDCobbsAngleF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PlanDCobbsAngleF, out Double result) == false)
                {
                    throw new Exception("PlanDCobbsAngleF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanDCobbsAngleF = Double.Parse(infoOperativeDataViewModel.PlanDCobbsAngleF);
            }


            if (infoOperativeDataViewModel.PlanDFulcrumF == "" || infoOperativeDataViewModel.PlanDFulcrumF == null)
            {
                operativeDataViewModel.PlanDFulcrumF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PlanDFulcrumF, out Double result) == false)
                {
                    throw new Exception("PlanDFulcrumF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanDFulcrumF = Double.Parse(infoOperativeDataViewModel.PlanDFulcrumF);
            }

            if (infoOperativeDataViewModel.PlanDBendingF == "" || infoOperativeDataViewModel.PlanDBendingF == null)
            {
                operativeDataViewModel.PlanDBendingF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PlanDBendingF, out Double result) == false)
                {
                    throw new Exception("PlanDBendingF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanDBendingF = Double.Parse(infoOperativeDataViewModel.PlanDBendingF);
            }


            if (infoOperativeDataViewModel.PlanRisserS == "" || infoOperativeDataViewModel.PlanRisserS == null)
            {
                operativeDataViewModel.PlanRisserS = null;
            }
            else
            {
                operativeDataViewModel.PlanRisserS = infoOperativeDataViewModel.PlanRisserS;
            }

            if (infoOperativeDataViewModel.PlanPriorityR == "" || infoOperativeDataViewModel.PlanPriorityR == null)
            {
                operativeDataViewModel.PlanPriorityR = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PlanPriorityR, out Char result) == false)
                {
                    throw new Exception("PlanPriorityR should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanPriorityR = Char.Parse(infoOperativeDataViewModel.PlanPriorityR);
            }

            if (infoOperativeDataViewModel.PlanMRIR == "" || infoOperativeDataViewModel.PlanMRIR == null)
            {
                operativeDataViewModel.PlanMRIR = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PlanMRIR, out Char result) == false)
                {
                    throw new Exception("PlanMRIR should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanMRIR = Char.Parse(infoOperativeDataViewModel.PlanMRIR);
            }


            if (infoOperativeDataViewModel.PlanMRISpecifyT == "" || infoOperativeDataViewModel.PlanMRISpecifyT == null)
            {
                operativeDataViewModel.PlanMRISpecifyT = null;
            }
            else
            {
                operativeDataViewModel.PlanMRISpecifyT = infoOperativeDataViewModel.PlanMRISpecifyT;
            }

            if (infoOperativeDataViewModel.PlanMRIActionT == "" || infoOperativeDataViewModel.PlanMRIActionT == null)
            {
                operativeDataViewModel.PlanMRIActionT = null;
            }
            else
            {
                operativeDataViewModel.PlanMRIActionT = infoOperativeDataViewModel.PlanMRIActionT;
            }

            if (infoOperativeDataViewModel.PlanClottingR == "" || infoOperativeDataViewModel.PlanClottingR == null)
            {
                operativeDataViewModel.PlanClottingR = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PlanClottingR, out Char result) == false)
                {
                    throw new Exception("PlanClottingR should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanClottingR = Char.Parse(infoOperativeDataViewModel.PlanClottingR);
            }


            if (infoOperativeDataViewModel.PlanClottingSpecifyT == "" || infoOperativeDataViewModel.PlanClottingSpecifyT == null)
            {
                operativeDataViewModel.PlanClottingSpecifyT = null;
            }
            else
            {
                operativeDataViewModel.PlanClottingSpecifyT = infoOperativeDataViewModel.PlanClottingSpecifyT;
            }


            if (infoOperativeDataViewModel.PlanClottingActionT == "" || infoOperativeDataViewModel.PlanClottingActionT == null)
            {
                operativeDataViewModel.PlanClottingActionT = null;
            }
            else
            {
                operativeDataViewModel.PlanClottingActionT = infoOperativeDataViewModel.PlanClottingActionT;
            }


            if (infoOperativeDataViewModel.PlanCardiacR == "" || infoOperativeDataViewModel.PlanCardiacR == null)
            {
                operativeDataViewModel.PlanCardiacR = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PlanCardiacR, out Char result) == false)
                {
                    throw new Exception("PlanCardiacR should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanCardiacR = Char.Parse(infoOperativeDataViewModel.PlanCardiacR);
            }


            if (infoOperativeDataViewModel.PlanCardiacSpecifyT == "" || infoOperativeDataViewModel.PlanCardiacSpecifyT == null)
            {
                operativeDataViewModel.PlanCardiacSpecifyT = null;
            }
            else
            {
                operativeDataViewModel.PlanCardiacSpecifyT = infoOperativeDataViewModel.PlanCardiacSpecifyT;
            }

            if (infoOperativeDataViewModel.PlanCardiacActionT == "" || infoOperativeDataViewModel.PlanCardiacActionT == null)
            {
                operativeDataViewModel.PlanCardiacActionT = null;
            }
            else
            {
                operativeDataViewModel.PlanCardiacActionT = infoOperativeDataViewModel.PlanCardiacActionT;
            }

            if (infoOperativeDataViewModel.PlanRespR == "" || infoOperativeDataViewModel.PlanRespR == null)
            {
                operativeDataViewModel.PlanRespR = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PlanRespR, out Char result) == false)
                {
                    throw new Exception("PlanRespR should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanRespR = Char.Parse(infoOperativeDataViewModel.PlanRespR);
            }

            if (infoOperativeDataViewModel.PlanRespSpecifyT == "" || infoOperativeDataViewModel.PlanRespSpecifyT == null)
            {
                operativeDataViewModel.PlanRespSpecifyT = null;
            }
            else
            {
                operativeDataViewModel.PlanRespSpecifyT = infoOperativeDataViewModel.PlanRespSpecifyT;
            }

            if (infoOperativeDataViewModel.PlanRespActionT == "" || infoOperativeDataViewModel.PlanRespActionT == null)
            {
                operativeDataViewModel.PlanRespActionT = null;
            }
            else
            {
                operativeDataViewModel.PlanRespActionT = infoOperativeDataViewModel.PlanRespActionT;
            }


            if (infoOperativeDataViewModel.PlanSSEPR == "" || infoOperativeDataViewModel.PlanSSEPR == null)
            {
                operativeDataViewModel.PlanSSEPR = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PlanSSEPR, out Char result) == false)
                {
                    throw new Exception("PlanSSEPR should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanSSEPR = Char.Parse(infoOperativeDataViewModel.PlanSSEPR);
            }


            if (infoOperativeDataViewModel.PlanSSEPSpecifyT == "" || infoOperativeDataViewModel.PlanSSEPSpecifyT == null)
            {
                operativeDataViewModel.PlanSSEPSpecifyT = null;
            }
            else
            {
                operativeDataViewModel.PlanSSEPSpecifyT = infoOperativeDataViewModel.PlanSSEPSpecifyT;
            }


            if (infoOperativeDataViewModel.PlanSSEPActionT == "" || infoOperativeDataViewModel.PlanSSEPActionT == null)
            {
                operativeDataViewModel.PlanSSEPActionT = null;
            }
            else
            {
                operativeDataViewModel.PlanSSEPActionT = infoOperativeDataViewModel.PlanSSEPActionT;
            }

            if (infoOperativeDataViewModel.PlanHaloR == "" || infoOperativeDataViewModel.PlanHaloR == null)
            {
                operativeDataViewModel.PlanHaloR = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PlanHaloR, out Char result) == false)
                {
                    throw new Exception("PlanHaloR should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanHaloR = Char.Parse(infoOperativeDataViewModel.PlanHaloR);
            }


            if (infoOperativeDataViewModel.PlanASFC == "" || infoOperativeDataViewModel.PlanASFC == null)
            {
                operativeDataViewModel.PlanASFC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.PlanASFC, out bool result) == false)
                {
                    throw new Exception("PlanASFC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanASFC = bool.Parse(infoOperativeDataViewModel.PlanASFC);
            }


            if (infoOperativeDataViewModel.PlanASFLevelFromS == "" || infoOperativeDataViewModel.PlanASFLevelFromS == null)
            {
                operativeDataViewModel.PlanASFLevelFromS = null;
            }
            else
            {
                operativeDataViewModel.PlanASFLevelFromS = infoOperativeDataViewModel.PlanASFLevelFromS;
            }


            if (infoOperativeDataViewModel.PlanASFLevelToS == "" || infoOperativeDataViewModel.PlanASFLevelToS == null)
            {
                operativeDataViewModel.PlanASFLevelToS = null;
            }
            else
            {
                operativeDataViewModel.PlanASFLevelToS = infoOperativeDataViewModel.PlanASFLevelToS;
            }


            if (infoOperativeDataViewModel.PlanASFHZC == "" || infoOperativeDataViewModel.PlanASFHZC == null)
            {
                operativeDataViewModel.PlanASFHZC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.PlanASFHZC, out bool result) == false)
                {
                    throw new Exception("PlanASFHZC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanASFHZC = bool.Parse(infoOperativeDataViewModel.PlanASFHZC);
            }

            if (infoOperativeDataViewModel.PlanASFIsolaC == "" || infoOperativeDataViewModel.PlanASFIsolaC == null)
            {
                operativeDataViewModel.PlanASFIsolaC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.PlanASFIsolaC, out bool result) == false)
                {
                    throw new Exception("PlanASFIsolaC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanASFIsolaC = bool.Parse(infoOperativeDataViewModel.PlanASFIsolaC);
            }

            if (infoOperativeDataViewModel.PlanASFOthersC == "" || infoOperativeDataViewModel.PlanASFOthersC == null)
            {
                operativeDataViewModel.PlanASFOthersC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.PlanASFOthersC, out bool result) == false)
                {
                    throw new Exception("PlanASFOthersC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanASFOthersC = bool.Parse(infoOperativeDataViewModel.PlanASFOthersC);
            }

            if (infoOperativeDataViewModel.PlanASFOthersT == "" || infoOperativeDataViewModel.PlanASFOthersT == null)
            {
                operativeDataViewModel.PlanASFOthersT = null;
            }
            else
            {
                operativeDataViewModel.PlanASFOthersT = infoOperativeDataViewModel.PlanASFOthersT;
            }

            if (infoOperativeDataViewModel.PlanASFBoneR == "" || infoOperativeDataViewModel.PlanASFBoneR == null)
            {
                operativeDataViewModel.PlanASFBoneR = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PlanASFBoneR, out Char result) == false)
                {
                    throw new Exception("PlanASFBoneR should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanASFBoneR = Char.Parse(infoOperativeDataViewModel.PlanASFBoneR);
            }


            if (infoOperativeDataViewModel.PlanASFBoneOtherT == "" || infoOperativeDataViewModel.PlanASFBoneOtherT == null)
            {
                operativeDataViewModel.PlanASFBoneOtherT = null;
            }
            else
            {
                operativeDataViewModel.PlanASFBoneOtherT = infoOperativeDataViewModel.PlanASFBoneOtherT;
            }


            if (infoOperativeDataViewModel.PlanPSFC == "" || infoOperativeDataViewModel.PlanPSFC == null)
            {
                operativeDataViewModel.PlanPSFC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.PlanPSFC, out bool result) == false)
                {
                    throw new Exception("PlanPSFC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanPSFC = bool.Parse(infoOperativeDataViewModel.PlanPSFC);
            }


            if (infoOperativeDataViewModel.PlanPSFLevelFromS == "" || infoOperativeDataViewModel.PlanPSFLevelFromS == null)
            {
                operativeDataViewModel.PlanPSFLevelFromS = null;
            }
            else
            {
                operativeDataViewModel.PlanPSFLevelFromS = infoOperativeDataViewModel.PlanPSFLevelFromS;
            }


            if (infoOperativeDataViewModel.PlanPSFLevelToS == "" || infoOperativeDataViewModel.PlanPSFLevelToS == null)
            {
                operativeDataViewModel.PlanPSFLevelToS = null;
            }
            else
            {
                operativeDataViewModel.PlanPSFLevelToS = infoOperativeDataViewModel.PlanPSFLevelToS;
            }


            if (infoOperativeDataViewModel.PlanPSFHarringtonC == "" || infoOperativeDataViewModel.PlanPSFHarringtonC == null)
            {
                operativeDataViewModel.PlanPSFHarringtonC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.PlanPSFHarringtonC, out bool result) == false)
                {
                    throw new Exception("PlanPSFHarringtonC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanPSFHarringtonC = bool.Parse(infoOperativeDataViewModel.PlanPSFHarringtonC);
            }


            if (infoOperativeDataViewModel.PlanPSFHarringtonC == "" || infoOperativeDataViewModel.PlanPSFHarringtonC == null)
            {
                operativeDataViewModel.PlanPSFHarringtonC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.PlanPSFHarringtonC, out bool result) == false)
                {
                    throw new Exception("PlanPSFHarringtonC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanPSFHarringtonC = bool.Parse(infoOperativeDataViewModel.PlanPSFHarringtonC);
            }

            if (infoOperativeDataViewModel.PlanPSFLuqueC == "" || infoOperativeDataViewModel.PlanPSFLuqueC == null)
            {
                operativeDataViewModel.PlanPSFLuqueC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.PlanPSFLuqueC, out bool result) == false)
                {
                    throw new Exception("PlanPSFLuqueC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanPSFLuqueC = bool.Parse(infoOperativeDataViewModel.PlanPSFLuqueC);
            }

            if (infoOperativeDataViewModel.PlanPSFWisconsinC == "" || infoOperativeDataViewModel.PlanPSFWisconsinC == null)
            {
                operativeDataViewModel.PlanPSFWisconsinC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.PlanPSFWisconsinC, out bool result) == false)
                {
                    throw new Exception("PlanPSFWisconsinC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanPSFWisconsinC = bool.Parse(infoOperativeDataViewModel.PlanPSFWisconsinC);
            }

            if (infoOperativeDataViewModel.PlanPSFCDC == "" || infoOperativeDataViewModel.PlanPSFCDC == null)
            {
                operativeDataViewModel.PlanPSFCDC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.PlanPSFCDC, out bool result) == false)
                {
                    throw new Exception("PlanPSFCDC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanPSFCDC = bool.Parse(infoOperativeDataViewModel.PlanPSFCDC);
            }

            if (infoOperativeDataViewModel.PlanPSFIsolaC == "" || infoOperativeDataViewModel.PlanPSFIsolaC == null)
            {
                operativeDataViewModel.PlanPSFIsolaC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.PlanPSFIsolaC, out bool result) == false)
                {
                    throw new Exception("PlanPSFIsolaC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanPSFIsolaC = bool.Parse(infoOperativeDataViewModel.PlanPSFIsolaC);
            }

            if (infoOperativeDataViewModel.PlanPSFOthersC == "" || infoOperativeDataViewModel.PlanPSFOthersC == null)
            {
                operativeDataViewModel.PlanPSFOthersC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.PlanPSFOthersC, out bool result) == false)
                {
                    throw new Exception("PlanPSFOthersC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanPSFOthersC = bool.Parse(infoOperativeDataViewModel.PlanPSFOthersC);
            }

            if (infoOperativeDataViewModel.PlanPSFBoneR == "" || infoOperativeDataViewModel.PlanPSFBoneR == null)
            {
                operativeDataViewModel.PlanPSFBoneR = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PlanPSFBoneR, out Char result) == false)
                {
                    throw new Exception("PlanPSFBoneR should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanPSFBoneR = Char.Parse(infoOperativeDataViewModel.PlanPSFBoneR);
            }


            if (infoOperativeDataViewModel.PlanPSFOthersT == "" || infoOperativeDataViewModel.PlanPSFOthersT == null)
            {
                operativeDataViewModel.PlanPSFOthersT = null;
            }
            else
            {
                operativeDataViewModel.PlanPSFOthersT = infoOperativeDataViewModel.PlanPSFOthersT;
            }

            if (infoOperativeDataViewModel.PlanPSFBoneOtherT == "" || infoOperativeDataViewModel.PlanPSFBoneOtherT == null)
            {
                operativeDataViewModel.PlanPSFBoneOtherT = null;
            }
            else
            {
                operativeDataViewModel.PlanPSFBoneOtherT = infoOperativeDataViewModel.PlanPSFBoneOtherT;
            }


            if (infoOperativeDataViewModel.PlanVATC == "" || infoOperativeDataViewModel.PlanVATC == null)
            {
                operativeDataViewModel.PlanVATC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.PlanVATC, out bool result) == false)
                {
                    throw new Exception("PlanVATC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanVATC = bool.Parse(infoOperativeDataViewModel.PlanVATC);
            }

            if (infoOperativeDataViewModel.PlanVATLevelFromS == "" || infoOperativeDataViewModel.PlanVATLevelFromS == null)
            {
                operativeDataViewModel.PlanVATLevelFromS = null;
            }
            else
            {
                operativeDataViewModel.PlanVATLevelFromS = infoOperativeDataViewModel.PlanVATLevelFromS;
            }


            if (infoOperativeDataViewModel.PlanVATLevelToS == "" || infoOperativeDataViewModel.PlanVATLevelToS == null)
            {
                operativeDataViewModel.PlanVATLevelToS = null;
            }
            else
            {
                operativeDataViewModel.PlanVATLevelToS = infoOperativeDataViewModel.PlanVATLevelToS;
            }

            if (infoOperativeDataViewModel.PlanVATYesC == "" || infoOperativeDataViewModel.PlanVATYesC == null)
            {
                operativeDataViewModel.PlanVATYesC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.PlanVATYesC, out bool result) == false)
                {
                    throw new Exception("PlanVATYesC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanVATYesC = bool.Parse(infoOperativeDataViewModel.PlanVATYesC);
            }


            if (infoOperativeDataViewModel.PlanVATYesT == "" || infoOperativeDataViewModel.PlanVATYesT == null)
            {
                operativeDataViewModel.PlanVATYesT = null;
            }
            else
            {
                operativeDataViewModel.PlanVATYesT = infoOperativeDataViewModel.PlanVATYesT;
            }

            if (infoOperativeDataViewModel.PlanVATBoneR == "" || infoOperativeDataViewModel.PlanVATBoneR == null)
            {
                operativeDataViewModel.PlanVATBoneR = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PlanVATBoneR, out Char result) == false)
                {
                    throw new Exception("PlanVATBoneR should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PlanVATBoneR = Char.Parse(infoOperativeDataViewModel.PlanVATBoneR);
            }


            if (infoOperativeDataViewModel.PlanVATBoneOtherT == "" || infoOperativeDataViewModel.PlanVATBoneOtherT == null)
            {
                operativeDataViewModel.PlanVATBoneOtherT = null;
            }
            else
            {
                operativeDataViewModel.PlanVATBoneOtherT = infoOperativeDataViewModel.PlanVATBoneOtherT;
            }

            if (infoOperativeDataViewModel.PlanRemarksA == "" || infoOperativeDataViewModel.PlanRemarksA == null)
            {
                operativeDataViewModel.PlanRemarksA = null;
            }
            else
            {
                operativeDataViewModel.PlanRemarksA = infoOperativeDataViewModel.PlanRemarksA;
            }



            if (infoOperativeDataViewModel.IntraDateD == "" || infoOperativeDataViewModel.IntraDateD == null)
            {
                operativeDataViewModel.IntraDateD = null;
            }
            else
            {
                if (DateTime.TryParse(infoOperativeDataViewModel.IntraDateD, out DateTime result) == false)
                {
                    throw new Exception("IntraDateD should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.IntraDateD = DateTime.ParseExact(infoOperativeDataViewModel.IntraDateD, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }


            if (infoOperativeDataViewModel.IntraAnaesthetistT == "" || infoOperativeDataViewModel.IntraAnaesthetistT == null)
            {
                operativeDataViewModel.IntraAnaesthetistT = null;
            }
            else
            {
                operativeDataViewModel.IntraAnaesthetistT = infoOperativeDataViewModel.IntraAnaesthetistT;
            }

            if (infoOperativeDataViewModel.IntraDurationF == "" || infoOperativeDataViewModel.IntraDurationF == null)
            {
                operativeDataViewModel.IntraDurationF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.IntraDurationF, out Double result) == false)
                {
                    throw new Exception("PlanVATBoneR should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.IntraDurationF = Double.Parse(infoOperativeDataViewModel.IntraDurationF);
            }

            if (infoOperativeDataViewModel.IntraNonSaverF == "" || infoOperativeDataViewModel.IntraNonSaverF == null)
            {
                operativeDataViewModel.IntraNonSaverF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.IntraNonSaverF, out Double result) == false)
                {
                    throw new Exception("PlanVATBoneR should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.IntraNonSaverF = Double.Parse(infoOperativeDataViewModel.IntraNonSaverF);
            }


            if (infoOperativeDataViewModel.IntraSaverR == "" || infoOperativeDataViewModel.IntraSaverR == null)
            {
                operativeDataViewModel.IntraSaverR = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.IntraSaverR, out Char result) == false)
                {
                    throw new Exception("IntraSaverR should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.IntraSaverR = Char.Parse(infoOperativeDataViewModel.IntraSaverR);
            }

            if (infoOperativeDataViewModel.IntraSaverF == "" || infoOperativeDataViewModel.IntraSaverF == null)
            {
                operativeDataViewModel.IntraSaverF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.IntraSaverF, out Double result) == false)
                {
                    throw new Exception("IntraSaverF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.IntraSaverF = Double.Parse(infoOperativeDataViewModel.IntraSaverF);
            }


            if (infoOperativeDataViewModel.IntraAutoOutF == "" || infoOperativeDataViewModel.IntraAutoOutF == null)
            {
                operativeDataViewModel.IntraAutoOutF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.IntraAutoOutF, out Double result) == false)
                {
                    throw new Exception("IntraAutoOutF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.IntraAutoOutF = Double.Parse(infoOperativeDataViewModel.IntraAutoOutF);
            }

            if (infoOperativeDataViewModel.IntraAutologousF == "" || infoOperativeDataViewModel.IntraAutologousF == null)
            {
                operativeDataViewModel.IntraAutologousF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.IntraAutologousF, out Double result) == false)
                {
                    throw new Exception("IntraAutologousF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.IntraAutologousF = Double.Parse(infoOperativeDataViewModel.IntraAutologousF);
            }

            if (infoOperativeDataViewModel.IntraAutoInF == "" || infoOperativeDataViewModel.IntraAutoInF == null)
            {
                operativeDataViewModel.IntraAutoInF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.IntraAutoInF, out Double result) == false)
                {
                    throw new Exception("IntraAutoInF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.IntraAutoInF = Double.Parse(infoOperativeDataViewModel.IntraAutoInF);
            }

            if (infoOperativeDataViewModel.IntraWholeBloodF == "" || infoOperativeDataViewModel.IntraWholeBloodF == null)
            {
                operativeDataViewModel.IntraWholeBloodF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.IntraWholeBloodF, out Double result) == false)
                {
                    throw new Exception("IntraWholeBloodF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.IntraWholeBloodF = Double.Parse(infoOperativeDataViewModel.IntraWholeBloodF);
            }

            if (infoOperativeDataViewModel.IntraPackedCellF == "" || infoOperativeDataViewModel.IntraPackedCellF == null)
            {
                operativeDataViewModel.IntraPackedCellF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.IntraPackedCellF, out Double result) == false)
                {
                    throw new Exception("IntraPackedCellF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.IntraPackedCellF = Double.Parse(infoOperativeDataViewModel.IntraPackedCellF);
            }

            if (infoOperativeDataViewModel.IntraCrystalloidF == "" || infoOperativeDataViewModel.IntraCrystalloidF == null)
            {
                operativeDataViewModel.IntraCrystalloidF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.IntraCrystalloidF, out Double result) == false)
                {
                    throw new Exception("IntraCrystalloidF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.IntraCrystalloidF = Double.Parse(infoOperativeDataViewModel.IntraCrystalloidF);
            }

            if (infoOperativeDataViewModel.IntraColloidF == "" || infoOperativeDataViewModel.IntraColloidF == null)
            {
                operativeDataViewModel.IntraColloidF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.IntraColloidF, out Double result) == false)
                {
                    throw new Exception("IntraColloidF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.IntraColloidF = Double.Parse(infoOperativeDataViewModel.IntraColloidF);
            }


            if (infoOperativeDataViewModel.IntraPlateletF == "" || infoOperativeDataViewModel.IntraPlateletF == null)
            {
                operativeDataViewModel.IntraPlateletF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.IntraPlateletF, out Double result) == false)
                {
                    throw new Exception("IntraPlateletF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.IntraPlateletF = Double.Parse(infoOperativeDataViewModel.IntraPlateletF);
            }

            if (infoOperativeDataViewModel.IntraFFPF == "" || infoOperativeDataViewModel.IntraFFPF == null)
            {
                operativeDataViewModel.IntraFFPF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.IntraFFPF, out Double result) == false)
                {
                    throw new Exception("IntraFFPF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.IntraFFPF = Double.Parse(infoOperativeDataViewModel.IntraFFPF);
            }


            if (infoOperativeDataViewModel.IntraAntibioticsR == "" || infoOperativeDataViewModel.IntraAntibioticsR == null)
            {
                operativeDataViewModel.IntraAntibioticsR = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.IntraAntibioticsR, out Char result) == false)
                {
                    throw new Exception("IntraAntibioticsR should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.IntraAntibioticsR = Char.Parse(infoOperativeDataViewModel.IntraAntibioticsR);
            }


            if (infoOperativeDataViewModel.IntraAntibioticsT == "" || infoOperativeDataViewModel.IntraAntibioticsT == null)
            {
                operativeDataViewModel.IntraAntibioticsT = null;
            }
            else
            {
                operativeDataViewModel.IntraAntibioticsT = infoOperativeDataViewModel.IntraAntibioticsT;
            }


            if (infoOperativeDataViewModel.ProChiefS == "" || infoOperativeDataViewModel.ProChiefS == null)
            {
                operativeDataViewModel.ProChiefS = null;
            }
            else
            {
                operativeDataViewModel.ProChiefS = infoOperativeDataViewModel.ProChiefS;
            }


            if (infoOperativeDataViewModel.ProAssistant1S == "" || infoOperativeDataViewModel.ProAssistant1S == null)
            {
                operativeDataViewModel.ProAssistant1S = null;
            }
            else
            {
                operativeDataViewModel.ProAssistant1S = infoOperativeDataViewModel.ProAssistant1S;
            }

            if (infoOperativeDataViewModel.ProAssistant2S == "" || infoOperativeDataViewModel.ProAssistant2S == null)
            {
                operativeDataViewModel.ProAssistant2S = null;
            }
            else
            {
                operativeDataViewModel.ProAssistant2S = infoOperativeDataViewModel.ProAssistant2S;
            }

            if (infoOperativeDataViewModel.ProAssistant3S == "" || infoOperativeDataViewModel.ProAssistant3S == null)
            {
                operativeDataViewModel.ProAssistant3S = null;
            }
            else
            {
                operativeDataViewModel.ProAssistant3S = infoOperativeDataViewModel.ProAssistant3S;
            }


            if (infoOperativeDataViewModel.ProSurgeonOthersT == "" || infoOperativeDataViewModel.ProSurgeonOthersT == null)
            {
                operativeDataViewModel.ProSurgeonOthersT = null;
            }
            else
            {
                operativeDataViewModel.ProSurgeonOthersT = infoOperativeDataViewModel.ProSurgeonOthersT;
            }

            if (infoOperativeDataViewModel.ProPosteriorLevelR == "" || infoOperativeDataViewModel.ProPosteriorLevelR == null)
            {
                operativeDataViewModel.ProPosteriorLevelR = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.ProPosteriorLevelR, out Char result) == false)
                {
                    throw new Exception("ProPosteriorLevelR should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.ProPosteriorLevelR = Char.Parse(infoOperativeDataViewModel.ProPosteriorLevelR);
            }

            if (infoOperativeDataViewModel.ProPosteriorFromS == "" || infoOperativeDataViewModel.ProPosteriorFromS == null)
            {
                operativeDataViewModel.ProPosteriorFromS = null;
            }
            else
            {
                operativeDataViewModel.ProPosteriorFromS = infoOperativeDataViewModel.ProPosteriorFromS;
            }

            if (infoOperativeDataViewModel.ProPosteriorToS == "" || infoOperativeDataViewModel.ProPosteriorToS == null)
            {
                operativeDataViewModel.ProPosteriorToS = null;
            }
            else
            {
                operativeDataViewModel.ProPosteriorToS = infoOperativeDataViewModel.ProPosteriorToS;
            }


            if (infoOperativeDataViewModel.ProPosteriorLevelF == "" || infoOperativeDataViewModel.ProPosteriorLevelF == null)
            {
                operativeDataViewModel.ProPosteriorLevelF = null;
            }
            else
            {
                if (short.TryParse(infoOperativeDataViewModel.ProPosteriorLevelF, out short result) == false)
                {
                    throw new Exception("ProPosteriorLevelF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.ProPosteriorLevelF = short.Parse(infoOperativeDataViewModel.ProPosteriorLevelF);
            }


            if (infoOperativeDataViewModel.ProPHarringtonC == "" || infoOperativeDataViewModel.ProPHarringtonC == null)
            {
                operativeDataViewModel.ProPHarringtonC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.ProPHarringtonC, out bool result) == false)
                {
                    throw new Exception("ProPHarringtonC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.ProPHarringtonC = bool.Parse(infoOperativeDataViewModel.ProPHarringtonC);
            }


            if (infoOperativeDataViewModel.ProPLuqueC == "" || infoOperativeDataViewModel.ProPLuqueC == null)
            {
                operativeDataViewModel.ProPLuqueC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.ProPLuqueC, out bool result) == false)
                {
                    throw new Exception("ProPLuqueC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.ProPLuqueC = bool.Parse(infoOperativeDataViewModel.ProPLuqueC);
            }


            if (infoOperativeDataViewModel.ProPWisconsinC == "" || infoOperativeDataViewModel.ProPWisconsinC == null)
            {
                operativeDataViewModel.ProPWisconsinC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.ProPWisconsinC, out bool result) == false)
                {
                    throw new Exception("ProPWisconsinC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.ProPWisconsinC = bool.Parse(infoOperativeDataViewModel.ProPWisconsinC);
            }



            if (infoOperativeDataViewModel.ProPCDC == "" || infoOperativeDataViewModel.ProPCDC == null)
            {
                operativeDataViewModel.ProPCDC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.ProPCDC, out bool result) == false)
                {
                    throw new Exception("ProPCDC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.ProPCDC = bool.Parse(infoOperativeDataViewModel.ProPCDC);
            }

            if (infoOperativeDataViewModel.ProPIsolaC == "" || infoOperativeDataViewModel.ProPIsolaC == null)
            {
                operativeDataViewModel.ProPIsolaC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.ProPIsolaC, out bool result) == false)
                {
                    throw new Exception("ProPIsolaC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.ProPIsolaC = bool.Parse(infoOperativeDataViewModel.ProPIsolaC);
            }


            if (infoOperativeDataViewModel.ProPOthersC == "" || infoOperativeDataViewModel.ProPOthersC == null)
            {
                operativeDataViewModel.ProPOthersC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.ProPOthersC, out bool result) == false)
                {
                    throw new Exception("ProPOthersC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.ProPOthersC = bool.Parse(infoOperativeDataViewModel.ProPOthersC);
            }




            if (infoOperativeDataViewModel.ProAnteriorLevelR == "" || infoOperativeDataViewModel.ProAnteriorLevelR == null)
            {
                operativeDataViewModel.ProAnteriorLevelR = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.ProAnteriorLevelR, out Char result) == false)
                {
                    throw new Exception("ProAnteriorLevelR should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.ProAnteriorLevelR = Char.Parse(infoOperativeDataViewModel.ProAnteriorLevelR);
            }


            if (infoOperativeDataViewModel.ProAnteriorFromS == "" || infoOperativeDataViewModel.ProAnteriorFromS == null)
            {
                operativeDataViewModel.ProAnteriorFromS = null;
            }
            else
            {
                operativeDataViewModel.ProAnteriorFromS = infoOperativeDataViewModel.ProAnteriorFromS;
            }

            if (infoOperativeDataViewModel.ProAnteriorToS == "" || infoOperativeDataViewModel.ProAnteriorToS == null)
            {
                operativeDataViewModel.ProAnteriorToS = null;
            }
            else
            {
                operativeDataViewModel.ProAnteriorToS = infoOperativeDataViewModel.ProAnteriorToS;
            }

            if (infoOperativeDataViewModel.ProAnteriorLevelF == "" || infoOperativeDataViewModel.ProAnteriorLevelF == null)
            {
                operativeDataViewModel.ProAnteriorLevelF = null;
            }
            else
            {
                if (short.TryParse(infoOperativeDataViewModel.ProAnteriorLevelF, out short result) == false)
                {
                    throw new Exception("ProAnteriorLevelF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.ProAnteriorLevelF = short.Parse(infoOperativeDataViewModel.ProAnteriorLevelF);
            }


            if (infoOperativeDataViewModel.ProAZielkeC == "" || infoOperativeDataViewModel.ProAZielkeC == null)
            {
                operativeDataViewModel.ProAZielkeC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.ProAZielkeC, out bool result) == false)
                {
                    throw new Exception("ProAZielkeC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.ProAZielkeC = bool.Parse(infoOperativeDataViewModel.ProAZielkeC);
            }



            if (infoOperativeDataViewModel.ProAHalmC == "" || infoOperativeDataViewModel.ProAHalmC == null)
            {
                operativeDataViewModel.ProAHalmC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.ProAHalmC, out bool result) == false)
                {
                    throw new Exception("ProAHalmC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.ProAHalmC = bool.Parse(infoOperativeDataViewModel.ProAHalmC);
            }


            if (infoOperativeDataViewModel.ProAIsolaC == "" || infoOperativeDataViewModel.ProAIsolaC == null)
            {
                operativeDataViewModel.ProAIsolaC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.ProAIsolaC, out bool result) == false)
                {
                    throw new Exception("ProAIsolaC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.ProAIsolaC = bool.Parse(infoOperativeDataViewModel.ProAIsolaC);
            }

            if (infoOperativeDataViewModel.ProAOthersC == "" || infoOperativeDataViewModel.ProAOthersC == null)
            {
                operativeDataViewModel.ProAOthersC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.ProAOthersC, out bool result) == false)
                {
                    throw new Exception("ProAOthersC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.ProAOthersC = bool.Parse(infoOperativeDataViewModel.ProAOthersC);
            }


            if (infoOperativeDataViewModel.ProAOthersT == "" || infoOperativeDataViewModel.ProAOthersT == null)
            {
                operativeDataViewModel.ProAOthersT = null;
            }
            else
            {
                operativeDataViewModel.ProAOthersT = infoOperativeDataViewModel.ProAOthersT;
            }


            if (infoOperativeDataViewModel.ProThoracoscopicR == "" || infoOperativeDataViewModel.ProThoracoscopicR == null)
            {
                operativeDataViewModel.ProThoracoscopicR = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.ProThoracoscopicR, out Char result) == false)
                {
                    throw new Exception("ProThoracoscopicR should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.ProThoracoscopicR = Char.Parse(infoOperativeDataViewModel.ProThoracoscopicR);
            }



            if (infoOperativeDataViewModel.ProSurgeonT == "" || infoOperativeDataViewModel.ProSurgeonT == null)
            {
                operativeDataViewModel.ProSurgeonT = null;
            }
            else
            {
                operativeDataViewModel.ProSurgeonT = infoOperativeDataViewModel.ProSurgeonT;
            }



            if (infoOperativeDataViewModel.ProThoracoscopicFromT == "" || infoOperativeDataViewModel.ProThoracoscopicFromT == null)
            {
                operativeDataViewModel.ProThoracoscopicFromT = null;
            }
            else
            {
                operativeDataViewModel.ProThoracoscopicFromT = infoOperativeDataViewModel.ProThoracoscopicFromT;
            }



            if (infoOperativeDataViewModel.ProThoracoscopicToT == "" || infoOperativeDataViewModel.ProThoracoscopicToT == null)
            {
                operativeDataViewModel.ProThoracoscopicToT = null;
            }
            else
            {
                operativeDataViewModel.ProThoracoscopicToT = infoOperativeDataViewModel.ProThoracoscopicToT;
            }



            if (infoOperativeDataViewModel.ProThoracoscopicSideS == "" || infoOperativeDataViewModel.ProThoracoscopicSideS == null)
            {
                operativeDataViewModel.ProThoracoscopicSideS = null;
            }
            else
            {
                operativeDataViewModel.ProThoracoscopicSideS = infoOperativeDataViewModel.ProThoracoscopicSideS;
            }

            if (infoOperativeDataViewModel.ProBoneR == "" || infoOperativeDataViewModel.ProBoneR == null)
            {
                operativeDataViewModel.ProBoneR = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.ProBoneR, out Char result) == false)
                {
                    throw new Exception("ProBoneR should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.ProBoneR = Char.Parse(infoOperativeDataViewModel.ProBoneR);
            }

            if (infoOperativeDataViewModel.ProAutologousC == "" || infoOperativeDataViewModel.ProAutologousC == null)
            {
                operativeDataViewModel.ProAutologousC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.ProAutologousC, out bool result) == false)
                {
                    throw new Exception("ProAutologousC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.ProAutologousC = bool.Parse(infoOperativeDataViewModel.ProAutologousC);
            }

            if (infoOperativeDataViewModel.ProAutologousF == "" || infoOperativeDataViewModel.ProAutologousF == null)
            {
                operativeDataViewModel.ProAutologousF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.ProAutologousF, out Double result) == false)
                {
                    throw new Exception("ProAutologousF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.ProAutologousF = Double.Parse(infoOperativeDataViewModel.ProAutologousF);
            }

            if (infoOperativeDataViewModel.ProAllograftC == "" || infoOperativeDataViewModel.ProAllograftC == null)
            {
                operativeDataViewModel.ProAllograftC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.ProAllograftC, out bool result) == false)
                {
                    throw new Exception("ProAllograftC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.ProAllograftC = bool.Parse(infoOperativeDataViewModel.ProAllograftC);
            }

            if (infoOperativeDataViewModel.ProAllograftF == "" || infoOperativeDataViewModel.ProAllograftF == null)
            {
                operativeDataViewModel.ProAllograftF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.ProAllograftF, out Double result) == false)
                {
                    throw new Exception("ProAllograftF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.ProAllograftF = Double.Parse(infoOperativeDataViewModel.ProAllograftF);
            }


            if (infoOperativeDataViewModel.ProBoneOthersC == "" || infoOperativeDataViewModel.ProBoneOthersC == null)
            {
                operativeDataViewModel.ProBoneOthersC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.ProBoneOthersC, out bool result) == false)
                {
                    throw new Exception("ProBoneOthersC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.ProBoneOthersC = bool.Parse(infoOperativeDataViewModel.ProBoneOthersC);
            }

            if (infoOperativeDataViewModel.ProBoneOthersT == "" || infoOperativeDataViewModel.ProBoneOthersT == null)
            {
                operativeDataViewModel.ProBoneOthersT = null;
            }
            else
            {
                operativeDataViewModel.ProBoneOthersT = infoOperativeDataViewModel.ProBoneOthersT;
            }



            if (infoOperativeDataViewModel.ProWakeR == "" || infoOperativeDataViewModel.ProWakeR == null)
            {
                operativeDataViewModel.ProWakeR = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.ProWakeR, out Char result) == false)
                {
                    throw new Exception("ProWakeR should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.ProWakeR = Char.Parse(infoOperativeDataViewModel.ProWakeR);
            }

            if (infoOperativeDataViewModel.ProSSEPR == "" || infoOperativeDataViewModel.ProSSEPR == null)
            {
                operativeDataViewModel.ProSSEPR = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.ProSSEPR, out Char result) == false)
                {
                    throw new Exception("ProSSEPR should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.ProSSEPR = Char.Parse(infoOperativeDataViewModel.ProSSEPR);
            }

            if (infoOperativeDataViewModel.ProSSEPT == "" || infoOperativeDataViewModel.ProSSEPT == null)
            {
                operativeDataViewModel.ProSSEPT = null;
            }
            else
            {
                operativeDataViewModel.ProSSEPT = infoOperativeDataViewModel.ProSSEPT;
            }


            if (infoOperativeDataViewModel.ProWakeT == "" || infoOperativeDataViewModel.ProWakeT == null)
            {
                operativeDataViewModel.ProWakeT = null;
            }
            else
            {
                operativeDataViewModel.ProWakeT = infoOperativeDataViewModel.ProWakeT;
            }

            if (infoOperativeDataViewModel.ProMEPR == "" || infoOperativeDataViewModel.ProMEPR == null)
            {
                operativeDataViewModel.ProMEPR = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.ProMEPR, out Char result) == false)
                {
                    throw new Exception("ProMEPR should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.ProMEPR = Char.Parse(infoOperativeDataViewModel.ProMEPR);
            }


            if (infoOperativeDataViewModel.ProMEPT == "" || infoOperativeDataViewModel.ProMEPT == null)
            {
                operativeDataViewModel.ProMEPT = null;
            }
            else
            {
                operativeDataViewModel.ProMEPT = infoOperativeDataViewModel.ProMEPT;
            }

            if (infoOperativeDataViewModel.ProImplantA == "" || infoOperativeDataViewModel.ProImplantA == null)
            {
                operativeDataViewModel.ProImplantA = null;
            }
            else
            {
                operativeDataViewModel.ProImplantA = infoOperativeDataViewModel.ProImplantA;
            }


            if (infoOperativeDataViewModel.ProOthersA == "" || infoOperativeDataViewModel.ProOthersA == null)
            {
                operativeDataViewModel.ProOthersA = null;
            }
            else
            {
                operativeDataViewModel.ProOthersA = infoOperativeDataViewModel.ProOthersA;
            }

            if (infoOperativeDataViewModel.ProRemarkA == "" || infoOperativeDataViewModel.ProRemarkA == null)
            {
                operativeDataViewModel.ProRemarkA = null;
            }
            else
            {
                operativeDataViewModel.ProRemarkA = infoOperativeDataViewModel.ProRemarkA;
            }


            if (infoOperativeDataViewModel.PostTransfusionWholeF == "" || infoOperativeDataViewModel.PostTransfusionWholeF == null)
            {
                operativeDataViewModel.PostTransfusionWholeF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PostTransfusionWholeF, out Double result) == false)
                {
                    throw new Exception("PostTransfusionWholeF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostTransfusionWholeF = Double.Parse(infoOperativeDataViewModel.PostTransfusionWholeF);
            }


            if (infoOperativeDataViewModel.PostTransfusionPackedF == "" || infoOperativeDataViewModel.PostTransfusionWholeF == null)
            {
                operativeDataViewModel.PostTransfusionPackedF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PostTransfusionPackedF, out Double result) == false)
                {
                    throw new Exception("PostTransfusionPackedF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostTransfusionPackedF = Double.Parse(infoOperativeDataViewModel.PostTransfusionPackedF);
            }

            if (infoOperativeDataViewModel.PostLastHbF == "" || infoOperativeDataViewModel.PostLastHbF == null)
            {
                operativeDataViewModel.PostLastHbF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PostLastHbF, out Double result) == false)
                {
                    throw new Exception("PostLastHbF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostLastHbF = Double.Parse(infoOperativeDataViewModel.PostLastHbF);
            }

            if (infoOperativeDataViewModel.PostLastHbDayF == "" || infoOperativeDataViewModel.PostLastHbDayF == null)
            {
                operativeDataViewModel.PostLastHbDayF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PostLastHbDayF, out Double result) == false)
                {
                    throw new Exception("PostLastHbDayF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostLastHbDayF = Double.Parse(infoOperativeDataViewModel.PostLastHbDayF);
            }


            if (infoOperativeDataViewModel.PostPreOpHbF == "" || infoOperativeDataViewModel.PostPreOpHbF == null)
            {
                operativeDataViewModel.PostPreOpHbF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PostPreOpHbF, out Double result) == false)
                {
                    throw new Exception("PostPreOpHbF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostPreOpHbF = Double.Parse(infoOperativeDataViewModel.PostPreOpHbF);
            }

            if (infoOperativeDataViewModel.PostPlateletF == "" || infoOperativeDataViewModel.PostPlateletF == null)
            {
                operativeDataViewModel.PostPlateletF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PostPlateletF, out Double result) == false)
                {
                    throw new Exception("PostPlateletF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostPlateletF = Double.Parse(infoOperativeDataViewModel.PostPlateletF);
            }


            if (infoOperativeDataViewModel.PostFFPF == "" || infoOperativeDataViewModel.PostFFPF == null)
            {
                operativeDataViewModel.PostFFPF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PostFFPF, out Double result) == false)
                {
                    throw new Exception("PostFFPF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostFFPF = Double.Parse(infoOperativeDataViewModel.PostFFPF);
            }

            if (infoOperativeDataViewModel.PostDaysF == "" || infoOperativeDataViewModel.PostDaysF == null)
            {
                operativeDataViewModel.PostDaysF = null;
            }
            else
            {
                if (short.TryParse(infoOperativeDataViewModel.PostDaysF, out short result) == false)
                {
                    throw new Exception("PostDaysF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostDaysF = short.Parse(infoOperativeDataViewModel.PostDaysF);
            }


            if (infoOperativeDataViewModel.PostBracingR == "" || infoOperativeDataViewModel.PostBracingR == null)
            {
                operativeDataViewModel.PostBracingR = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PostBracingR, out Char result) == false)
                {
                    throw new Exception("PostDaysF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostBracingR = Char.Parse(infoOperativeDataViewModel.PostBracingR);
            }

            if (infoOperativeDataViewModel.PostBracingT == "" || infoOperativeDataViewModel.PostBracingT == null)
            {
                operativeDataViewModel.PostBracingT = null;
            }
            else
            {
                operativeDataViewModel.PostBracingT = infoOperativeDataViewModel.PostBracingT;
            }


            if (infoOperativeDataViewModel.PostComplicationA == "" || infoOperativeDataViewModel.PostComplicationA == null)
            {
                operativeDataViewModel.PostComplicationA = null;
            }
            else
            {
                operativeDataViewModel.PostComplicationA = operativeDataViewModel.PostComplicationA;
            }

            if (infoOperativeDataViewModel.PostWithBraceC == "" || infoOperativeDataViewModel.PostWithBraceC == null)
            {
                operativeDataViewModel.PostWithBraceC = null;
            }
            else
            {
                if (bool.TryParse(infoOperativeDataViewModel.PostWithBraceC, out bool result) == false)
                {
                    throw new Exception("PostWithBraceC should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostWithBraceC = bool.Parse(infoOperativeDataViewModel.PostWithBraceC);
            }


            if (infoOperativeDataViewModel.PostACobbsF == "" || infoOperativeDataViewModel.PostACobbsF == null)
            {
                operativeDataViewModel.PostACobbsF = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PostACobbsF, out Char result) == false)
                {
                    throw new Exception("PostACobbsF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostACobbsF = Char.Parse(infoOperativeDataViewModel.PostACobbsF);
            }


            if (infoOperativeDataViewModel.PostAPreAVTF == "" || infoOperativeDataViewModel.PostAPreAVTF == null)
            {
                operativeDataViewModel.PostAPreAVTF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PostAPreAVTF, out Double result) == false)
                {
                    throw new Exception("PostAPreAVTF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostAPreAVTF = Double.Parse(infoOperativeDataViewModel.PostAPreAVTF);
            }


            if (infoOperativeDataViewModel.PostAPreAVTF == "" || infoOperativeDataViewModel.PostAPreAVTF == null)
            {
                operativeDataViewModel.PostAPreAVTF = null;
            }
            else
            {
                operativeDataViewModel.PostAPreAVTF = operativeDataViewModel.PostAPreAVTF;
            }


            if (infoOperativeDataViewModel.PostAPreAVTS == "" || infoOperativeDataViewModel.PostAPreAVTS == null)
            {
                operativeDataViewModel.PostAPreAVTS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PostAPreAVTS, out Char result) == false)
                {
                    throw new Exception("PostAPreAVTS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostAPreAVTS = Char.Parse(infoOperativeDataViewModel.PostAPreAVTS);
            }


            if (infoOperativeDataViewModel.PostAPostAVTF == "" || infoOperativeDataViewModel.PostAPostAVTF == null)
            {
                operativeDataViewModel.PostAPostAVTF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PostAPostAVTF, out Double result) == false)
                {
                    throw new Exception("PostAPostAVTF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostAPostAVTF = Double.Parse(infoOperativeDataViewModel.PostAPostAVTF);
            }


            if (infoOperativeDataViewModel.PostAPostAVTS == "" || infoOperativeDataViewModel.PostAPostAVTS == null)
            {
                operativeDataViewModel.PostAPostAVTS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PostAPostAVTS, out Char result) == false)
                {
                    throw new Exception("PostAPostAVTS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostAPostAVTS = Char.Parse(infoOperativeDataViewModel.PostAPostAVTS);
            }


            if (infoOperativeDataViewModel.PostBCobbsF == "" || infoOperativeDataViewModel.PostBCobbsF == null)
            {
                operativeDataViewModel.PostBCobbsF = null;
            }
            else
            {
                operativeDataViewModel.PostBCobbsF = operativeDataViewModel.PostBCobbsF;
            }

            if (infoOperativeDataViewModel.PostBPreAVTF == "" || infoOperativeDataViewModel.PostBPreAVTF == null)
            {
                operativeDataViewModel.PostBPreAVTF = null;
            }
            else
            {
                if (double.TryParse(infoOperativeDataViewModel.PostBPreAVTF, out double result) == false)
                {
                    throw new Exception("PostBPreAVTF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostBPreAVTF = double.Parse(infoOperativeDataViewModel.PostBPreAVTF);
            }

            if (infoOperativeDataViewModel.PostBPreAVTS == "" || infoOperativeDataViewModel.PostBPreAVTS == null)
            {
                operativeDataViewModel.PostBPreAVTS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PostBPreAVTS, out Char result) == false)
                {
                    throw new Exception("PostBPreAVTS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostBPreAVTS = Char.Parse(infoOperativeDataViewModel.PostBPreAVTS);
            }

            if (infoOperativeDataViewModel.PostBPostAVTF == "" || infoOperativeDataViewModel.PostBPostAVTF == null)
            {
                operativeDataViewModel.PostBPostAVTF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PostBPostAVTF, out Double result) == false)
                {
                    throw new Exception("PostBPostAVTF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostBPostAVTF = Double.Parse(infoOperativeDataViewModel.PostBPostAVTF);
            }

            if (infoOperativeDataViewModel.PostBPostAVTS == "" || infoOperativeDataViewModel.PostBPostAVTS == null)
            {
                operativeDataViewModel.PostBPostAVTS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PostBPostAVTS, out Char result) == false)
                {
                    throw new Exception("PostBPostAVTS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostBPostAVTS = Char.Parse(infoOperativeDataViewModel.PostBPostAVTS);
            }

            if (infoOperativeDataViewModel.PostCCobbsF == "" || infoOperativeDataViewModel.PostCCobbsF == null)
            {
                operativeDataViewModel.PostCCobbsF = null;
            }
            else
            {
                operativeDataViewModel.PostCCobbsF = operativeDataViewModel.PostCCobbsF;
            }

            if (infoOperativeDataViewModel.PostBPostAVTS == "" || infoOperativeDataViewModel.PostBPostAVTS == null)
            {
                operativeDataViewModel.PostBPostAVTS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PostBPostAVTS, out Char result) == false)
                {
                    throw new Exception("PostBPostAVTS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostBPostAVTS = Char.Parse(infoOperativeDataViewModel.PostBPostAVTS);
            }


            if (infoOperativeDataViewModel.PostCPreAVTF == "" || infoOperativeDataViewModel.PostCPreAVTF == null)
            {
                operativeDataViewModel.PostCPreAVTF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PostCPreAVTF, out Double result) == false)
                {
                    throw new Exception("PostCPreAVTF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostCPreAVTF = Double.Parse(infoOperativeDataViewModel.PostCPreAVTF);
            }

            if (infoOperativeDataViewModel.PostCPreAVTS == "" || infoOperativeDataViewModel.PostCPreAVTS == null)
            {
                operativeDataViewModel.PostCPreAVTS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PostCPreAVTS, out Char result) == false)
                {
                    throw new Exception("PostCPreAVTS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostCPreAVTS = Char.Parse(infoOperativeDataViewModel.PostCPreAVTS);
            }


            if (infoOperativeDataViewModel.PostCPostAVTF == "" || infoOperativeDataViewModel.PostCPostAVTF == null)
            {
                operativeDataViewModel.PostCPostAVTF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PostCPostAVTF, out Double result) == false)
                {
                    throw new Exception("PostCPostAVTF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostCPostAVTF = Double.Parse(infoOperativeDataViewModel.PostCPostAVTF);
            }

            if (infoOperativeDataViewModel.PostCPostAVTS == "" || infoOperativeDataViewModel.PostCPostAVTS == null)
            {
                operativeDataViewModel.PostCPostAVTS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PostCPostAVTS, out Char result) == false)
                {
                    throw new Exception("PostCPostAVTS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostCPostAVTS = Char.Parse(infoOperativeDataViewModel.PostCPostAVTS);
            }

            if (infoOperativeDataViewModel.PostDCobbsF == "" || infoOperativeDataViewModel.PostDCobbsF == null)
            {
                operativeDataViewModel.PostDCobbsF = null;
            }
            else
            {
                operativeDataViewModel.PostDCobbsF = operativeDataViewModel.PostDCobbsF;
            }

            if (infoOperativeDataViewModel.PostDPreAVTF == "" || infoOperativeDataViewModel.PostDPreAVTF == null)
            {
                operativeDataViewModel.PostDPreAVTF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PostDPreAVTF, out Double result) == false)
                {
                    throw new Exception("PostDPreAVTF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostDPreAVTF = Double.Parse(infoOperativeDataViewModel.PostDPreAVTF);
            }


            if (infoOperativeDataViewModel.PostDPreAVTS == "" || infoOperativeDataViewModel.PostDPreAVTS == null)
            {
                operativeDataViewModel.PostDPreAVTS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PostDPreAVTS, out Char result) == false)
                {
                    throw new Exception("PostDPreAVTF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostDPreAVTS = Char.Parse(infoOperativeDataViewModel.PostDPreAVTS);
            }

            if (infoOperativeDataViewModel.PostDPostAVTF == "" || infoOperativeDataViewModel.PostDPostAVTF == null)
            {
                operativeDataViewModel.PostDPostAVTF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PostDPostAVTF, out Double result) == false)
                {
                    throw new Exception("PostDPostAVTF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostDPostAVTF = Double.Parse(infoOperativeDataViewModel.PostDPostAVTF);
            }

            if (infoOperativeDataViewModel.PostDPostAVTS == "" || infoOperativeDataViewModel.PostDPostAVTS == null)
            {
                operativeDataViewModel.PostDPostAVTS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PostDPostAVTS, out Char result) == false)
                {
                    throw new Exception("PostDPostAVTS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostDPostAVTS = Char.Parse(infoOperativeDataViewModel.PostDPostAVTS);
            }


            if (infoOperativeDataViewModel.PostPreOpTrunkF == "" || infoOperativeDataViewModel.PostPreOpTrunkF == null)
            {
                operativeDataViewModel.PostPreOpTrunkF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PostPreOpTrunkF, out Double result) == false)
                {
                    throw new Exception("PostPreOpTrunkF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostPreOpTrunkF = Double.Parse(infoOperativeDataViewModel.PostPreOpTrunkF);
            }

            if (infoOperativeDataViewModel.PostPreOpTrunkS == "" || infoOperativeDataViewModel.PostPreOpTrunkS == null)
            {
                operativeDataViewModel.PostPreOpTrunkS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PostPreOpTrunkS, out Char result) == false)
                {
                    throw new Exception("PostPreOpTrunkS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostPreOpTrunkS = Char.Parse(infoOperativeDataViewModel.PostPreOpTrunkS);
            }


            if (infoOperativeDataViewModel.PostPostOpTrunkF == "" || infoOperativeDataViewModel.PostPostOpTrunkF == null)
            {
                operativeDataViewModel.PostPostOpTrunkF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PostPostOpTrunkF, out Double result) == false)
                {
                    throw new Exception("PostPostOpTrunkF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostPostOpTrunkF = Double.Parse(infoOperativeDataViewModel.PostPostOpTrunkF);
            }


            if (infoOperativeDataViewModel.PostPostOpTrunkS == "" || infoOperativeDataViewModel.PostPostOpTrunkS == null)
            {
                operativeDataViewModel.PostPostOpTrunkS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PostPostOpTrunkS, out Char result) == false)
                {
                    throw new Exception("PostPostOpTrunkS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostPostOpTrunkS = Char.Parse(infoOperativeDataViewModel.PostPostOpTrunkS);
            }

            if (infoOperativeDataViewModel.PostUpperF == "" || infoOperativeDataViewModel.PostUpperF == null)
            {
                operativeDataViewModel.PostUpperF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PostUpperF, out Double result) == false)
                {
                    throw new Exception("PostUpperF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostUpperF = Double.Parse(infoOperativeDataViewModel.PostUpperF);
            }

            if (infoOperativeDataViewModel.PostUpperS == "" || infoOperativeDataViewModel.PostUpperS == null)
            {
                operativeDataViewModel.PostUpperS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PostUpperS, out Char result) == false)
                {
                    throw new Exception("PostUpperS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostUpperS = Char.Parse(infoOperativeDataViewModel.PostUpperS);
            }

            if (infoOperativeDataViewModel.PostLowerF == "" || infoOperativeDataViewModel.PostLowerF == null)
            {
                operativeDataViewModel.PostLowerF = null;
            }
            else
            {
                if (Double.TryParse(infoOperativeDataViewModel.PostLowerF, out Double result) == false)
                {
                    throw new Exception("PostLowerF should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostLowerF = Double.Parse(infoOperativeDataViewModel.PostLowerF);
            }

            if (infoOperativeDataViewModel.PostLowerS == "" || infoOperativeDataViewModel.PostLowerS == null)
            {
                operativeDataViewModel.PostLowerS = null;
            }
            else
            {
                if (Char.TryParse(infoOperativeDataViewModel.PostLowerS, out Char result) == false)
                {
                    throw new Exception("PostLowerS should be numeric, e.g. 0.00");
                }

                operativeDataViewModel.PostLowerS = Char.Parse(infoOperativeDataViewModel.PostLowerS);
            }



            if (infoOperativeDataViewModel.PostRemarkA == "" || infoOperativeDataViewModel.PostRemarkA == null)
            {
                operativeDataViewModel.PostRemarkA = null;
            }
            else
            {
                operativeDataViewModel.PostRemarkA = operativeDataViewModel.PostRemarkA;
            }


            return operativeDataViewModel;
        }



        public InfoOperativeDataViewModel SetDefaultValue()
        {

            var infoOperativeDataViewModel = new InfoOperativeDataViewModel();

            infoOperativeDataViewModel.SCN = "";
            infoOperativeDataViewModel.RecordID = 0;
            infoOperativeDataViewModel.PreRisserS = "";
            infoOperativeDataViewModel.PreHeightF = "";
            infoOperativeDataViewModel.PreArmSpanF = "";
            infoOperativeDataViewModel.PreWeightF = "";
            infoOperativeDataViewModel.PreSittingF = "";
            infoOperativeDataViewModel.PreARankS = "";
            infoOperativeDataViewModel.PreASideS = "";
            infoOperativeDataViewModel.PreALevelFromS = "";
            infoOperativeDataViewModel.PreALevelToS = "";
            infoOperativeDataViewModel.PreAApexS = "";
            infoOperativeDataViewModel.PreACobbsAngleF = "";
            infoOperativeDataViewModel.PreAFulcrumF = "";
            infoOperativeDataViewModel.PreABendingF = "";
            infoOperativeDataViewModel.PreBRankS = "";
            infoOperativeDataViewModel.PreBSideS = "";
            infoOperativeDataViewModel.PreBLevelFromS = "";
            infoOperativeDataViewModel.PreBLevelToS = "";
            infoOperativeDataViewModel.PreBApexS = "";
            infoOperativeDataViewModel.PreBCobbsAngleF = "";
            infoOperativeDataViewModel.PreBFulcrumF = "";
            infoOperativeDataViewModel.PreBBendingF = "";
            infoOperativeDataViewModel.PreCRankS = "";
            infoOperativeDataViewModel.PreCSideS = "";
            infoOperativeDataViewModel.PreCLevelFromS = "";
            infoOperativeDataViewModel.PreCLevelToS = "";
            infoOperativeDataViewModel.PreCApexS = "";
            infoOperativeDataViewModel.PreCCobbsAngleF = "";
            infoOperativeDataViewModel.PreCFulcrumF = "";
            infoOperativeDataViewModel.PreCBendingF = "";
            infoOperativeDataViewModel.PreDRankS = "";
            infoOperativeDataViewModel.PreDSideS = "";
            infoOperativeDataViewModel.PreDLevelFromS = "";
            infoOperativeDataViewModel.PreDLevelToS = "";
            infoOperativeDataViewModel.PreDApexS = "";
            infoOperativeDataViewModel.PreDCobbsAngleF = "";
            infoOperativeDataViewModel.PreDFulcrumF = "";
            infoOperativeDataViewModel.PreDBendingF = "";
            infoOperativeDataViewModel.PreMRIR = "";
            infoOperativeDataViewModel.PreMRIT = "";
            infoOperativeDataViewModel.PreSSEPRF = "";
            infoOperativeDataViewModel.PreSSEPLF = "";
            infoOperativeDataViewModel.PreSSEPRP37F = "";
            infoOperativeDataViewModel.PreSSEPRN45F = "";
            infoOperativeDataViewModel.PreSSEPLP37F = "";
            infoOperativeDataViewModel.PreSSEPLN45F = "";
            infoOperativeDataViewModel.PreLumbarF = "";
            infoOperativeDataViewModel.PreZScoreF = "";
            infoOperativeDataViewModel.PreRBMDF = "";
            infoOperativeDataViewModel.PreRZScoreF = "";
            infoOperativeDataViewModel.PreLBMDF = "";
            infoOperativeDataViewModel.PreLZScoreF = "";
            infoOperativeDataViewModel.PreTibiaRD50F = "";
            infoOperativeDataViewModel.PreTibiaLD50F = "";
            infoOperativeDataViewModel.PreTibiaRD100F = "";
            infoOperativeDataViewModel.PreTibiaLD100F = "";
            infoOperativeDataViewModel.PreRadiusRD50F = "";
            infoOperativeDataViewModel.PreRadiusLD50F = "";
            infoOperativeDataViewModel.PreRadiusRD100F = "";
            infoOperativeDataViewModel.PreRadiusLD100F = "";
            infoOperativeDataViewModel.PreFVCPredictionF = "";
            infoOperativeDataViewModel.PreFVCObservedF = "";
            infoOperativeDataViewModel.PreFEV1PredictionF = "";
            infoOperativeDataViewModel.PreFEV1ObservedF = "";
            infoOperativeDataViewModel.PreECGT = "";
            infoOperativeDataViewModel.PreINRF = "";
            infoOperativeDataViewModel.PrePTF = "";
            infoOperativeDataViewModel.PreaPTTF = "";
            infoOperativeDataViewModel.PrePlateletF = "";
            infoOperativeDataViewModel.PreCommentsA = "";
            infoOperativeDataViewModel.PlanDateD = "";
            infoOperativeDataViewModel.PlanDoctorS = "";
            infoOperativeDataViewModel.PlanARankS = "";
            infoOperativeDataViewModel.PlanASideS = "";
            infoOperativeDataViewModel.PlanALevelFromS = "";
            infoOperativeDataViewModel.PlanALevelToS = "";
            infoOperativeDataViewModel.PlanAApexS = "";
            infoOperativeDataViewModel.PlanACobbsAngleF = "";
            infoOperativeDataViewModel.PlanAFulcrumF = "";
            infoOperativeDataViewModel.PlanABendingF = "";
            infoOperativeDataViewModel.PlanBRankS = "";
            infoOperativeDataViewModel.PlanBSideS = "";
            infoOperativeDataViewModel.PlanBLevelFromS = "";
            infoOperativeDataViewModel.PlanBLevelToS = "";
            infoOperativeDataViewModel.PlanBApexS = "";
            infoOperativeDataViewModel.PlanBCobbsAngleF = "";
            infoOperativeDataViewModel.PlanBFulcrumF = "";
            infoOperativeDataViewModel.PlanBBendingF = "";
            infoOperativeDataViewModel.PlanCRankS = "";
            infoOperativeDataViewModel.PlanCSideS = "";
            infoOperativeDataViewModel.PlanCLevelFromS = "";
            infoOperativeDataViewModel.PlanCLevelToS = "";
            infoOperativeDataViewModel.PlanCApexS = "";
            infoOperativeDataViewModel.PlanCCobbsAngleF = "";
            infoOperativeDataViewModel.PlanCFulcrumF = "";
            infoOperativeDataViewModel.PlanCBendingF = "";
            infoOperativeDataViewModel.PlanDRankS = "";
            infoOperativeDataViewModel.PlanDSideS = "";
            infoOperativeDataViewModel.PlanDLevelFromS = "";
            infoOperativeDataViewModel.PlanDLevelToS = "";
            infoOperativeDataViewModel.PlanDApexS = "";
            infoOperativeDataViewModel.PlanDCobbsAngleF = "";
            infoOperativeDataViewModel.PlanDFulcrumF = "";
            infoOperativeDataViewModel.PlanDBendingF = "";
            infoOperativeDataViewModel.PlanRisserS = "";
            infoOperativeDataViewModel.PlanPriorityR = "";
            infoOperativeDataViewModel.PlanMRIR = "";
            infoOperativeDataViewModel.PlanMRISpecifyT = "";
            infoOperativeDataViewModel.PlanMRIActionT = "";
            infoOperativeDataViewModel.PlanClottingR = "";
            infoOperativeDataViewModel.PlanClottingSpecifyT = "";
            infoOperativeDataViewModel.PlanClottingActionT = "";
            infoOperativeDataViewModel.PlanCardiacR = "";
            infoOperativeDataViewModel.PlanCardiacSpecifyT = "";
            infoOperativeDataViewModel.PlanCardiacActionT = "";
            infoOperativeDataViewModel.PlanRespR = "";
            infoOperativeDataViewModel.PlanRespSpecifyT = "";
            infoOperativeDataViewModel.PlanRespActionT = "";
            infoOperativeDataViewModel.PlanSSEPR = "";
            infoOperativeDataViewModel.PlanSSEPSpecifyT = "";
            infoOperativeDataViewModel.PlanSSEPActionT = "";
            infoOperativeDataViewModel.PlanHaloR = "";
            infoOperativeDataViewModel.PlanASFC = "";
            infoOperativeDataViewModel.PlanASFLevelFromS = "";
            infoOperativeDataViewModel.PlanASFLevelToS = "";
            infoOperativeDataViewModel.PlanASFHZC = "";
            infoOperativeDataViewModel.PlanASFIsolaC = "";
            infoOperativeDataViewModel.PlanASFOthersC = "";
            infoOperativeDataViewModel.PlanASFOthersT = "";
            infoOperativeDataViewModel.PlanASFBoneR = "";
            infoOperativeDataViewModel.PlanASFBoneOtherT = "";
            infoOperativeDataViewModel.PlanPSFC = "";
            infoOperativeDataViewModel.PlanPSFLevelFromS = "";
            infoOperativeDataViewModel.PlanPSFLevelToS = "";
            infoOperativeDataViewModel.PlanPSFHarringtonC = "";
            infoOperativeDataViewModel.PlanPSFLuqueC = "";
            infoOperativeDataViewModel.PlanPSFWisconsinC = "";
            infoOperativeDataViewModel.PlanPSFCDC = "";
            infoOperativeDataViewModel.PlanPSFIsolaC = "";
            infoOperativeDataViewModel.PlanPSFOthersC = "";
            infoOperativeDataViewModel.PlanPSFOthersT = "";
            infoOperativeDataViewModel.PlanPSFBoneR = "";
            infoOperativeDataViewModel.PlanPSFBoneOtherT = "";
            infoOperativeDataViewModel.PlanVATC = "";
            infoOperativeDataViewModel.PlanVATLevelFromS = "";
            infoOperativeDataViewModel.PlanVATLevelToS = "";
            infoOperativeDataViewModel.PlanVATYesC = "";
            infoOperativeDataViewModel.PlanVATYesT = "";
            infoOperativeDataViewModel.PlanVATBoneR = "";
            infoOperativeDataViewModel.PlanVATBoneOtherT = "";
            infoOperativeDataViewModel.PlanRemarksA = "";
            infoOperativeDataViewModel.IntraDateD = "";
            infoOperativeDataViewModel.IntraAnaesthetistT = "";
            infoOperativeDataViewModel.IntraDurationF = "";
            infoOperativeDataViewModel.IntraNonSaverF = "";
            infoOperativeDataViewModel.IntraSaverR = "";
            infoOperativeDataViewModel.IntraSaverF = "";
            infoOperativeDataViewModel.IntraAutoOutF = "";
            infoOperativeDataViewModel.IntraAutologousF = "";
            infoOperativeDataViewModel.IntraAutoInF = "";
            infoOperativeDataViewModel.IntraWholeBloodF = "";
            infoOperativeDataViewModel.IntraPackedCellF = "";
            infoOperativeDataViewModel.IntraCrystalloidF = "";
            infoOperativeDataViewModel.IntraColloidF = "";
            infoOperativeDataViewModel.IntraPlateletF = "";
            infoOperativeDataViewModel.IntraFFPF = "";
            infoOperativeDataViewModel.IntraAntibioticsR = "";
            infoOperativeDataViewModel.IntraAntibioticsT = "";
            infoOperativeDataViewModel.ProChiefS = "";
            infoOperativeDataViewModel.ProAssistant1S = "";
            infoOperativeDataViewModel.ProAssistant2S = "";
            infoOperativeDataViewModel.ProAssistant3S = "";
            infoOperativeDataViewModel.ProSurgeonOthersT = "";
            infoOperativeDataViewModel.ProPosteriorLevelR = "";
            infoOperativeDataViewModel.ProPosteriorFromS = "";
            infoOperativeDataViewModel.ProPosteriorToS = "";
            infoOperativeDataViewModel.ProPosteriorLevelF = "";
            infoOperativeDataViewModel.ProPHarringtonC = "";
            infoOperativeDataViewModel.ProPLuqueC = "";
            infoOperativeDataViewModel.ProPWisconsinC = "";
            infoOperativeDataViewModel.ProPCDC = "";
            infoOperativeDataViewModel.ProPIsolaC = "";
            infoOperativeDataViewModel.ProPOthersC = "";
            infoOperativeDataViewModel.ProPOthersT = "";
            infoOperativeDataViewModel.ProAnteriorLevelR = "";
            infoOperativeDataViewModel.ProAnteriorFromS = "";
            infoOperativeDataViewModel.ProAnteriorToS = "";
            infoOperativeDataViewModel.ProAnteriorLevelF = "";
            infoOperativeDataViewModel.ProAZielkeC = "";
            infoOperativeDataViewModel.ProAHalmC = "";
            infoOperativeDataViewModel.ProAIsolaC = "";
            infoOperativeDataViewModel.ProAOthersC = "";
            infoOperativeDataViewModel.ProAOthersT = "";
            infoOperativeDataViewModel.ProThoracoscopicR = "";
            infoOperativeDataViewModel.ProSurgeonT = "";
            infoOperativeDataViewModel.ProThoracoscopicFromT = "";
            infoOperativeDataViewModel.ProThoracoscopicToT = "";
            infoOperativeDataViewModel.ProThoracoscopicSideS = "";
            infoOperativeDataViewModel.ProBoneR = "";
            infoOperativeDataViewModel.ProAutologousC = "";
            infoOperativeDataViewModel.ProAutologousF = "";
            infoOperativeDataViewModel.ProAllograftC = "";
            infoOperativeDataViewModel.ProAllograftF = "";
            infoOperativeDataViewModel.ProBoneOthersC = "";
            infoOperativeDataViewModel.ProBoneOthersT = "";
            infoOperativeDataViewModel.ProWakeR = "";
            infoOperativeDataViewModel.ProWakeT = "";
            infoOperativeDataViewModel.ProSSEPR = "";
            infoOperativeDataViewModel.ProSSEPT = "";
            infoOperativeDataViewModel.ProMEPR = "";
            infoOperativeDataViewModel.ProMEPT = "";
            infoOperativeDataViewModel.ProImplantA = "";
            infoOperativeDataViewModel.ProOthersA = "";
            infoOperativeDataViewModel.ProRemarkA = "";
            infoOperativeDataViewModel.PostTransfusionWholeF = "";
            infoOperativeDataViewModel.PostTransfusionPackedF = "";
            infoOperativeDataViewModel.PostLastHbF = "";
            infoOperativeDataViewModel.PostLastHbDayF = "";
            infoOperativeDataViewModel.PostPreOpHbF = "";
            infoOperativeDataViewModel.PostPlateletF = "";
            infoOperativeDataViewModel.PostFFPF = "";
            infoOperativeDataViewModel.PostDaysF = "";
            infoOperativeDataViewModel.PostBracingR = "";
            infoOperativeDataViewModel.PostBracingT = "";
            infoOperativeDataViewModel.PostComplicationA = "";
            infoOperativeDataViewModel.PostWithBraceC = "";
            infoOperativeDataViewModel.PostACobbsF = "";
            infoOperativeDataViewModel.PostAPreAVTF = "";
            infoOperativeDataViewModel.PostAPreAVTS = "";
            infoOperativeDataViewModel.PostAPostAVTF = "";
            infoOperativeDataViewModel.PostAPostAVTS = "";
            infoOperativeDataViewModel.PostBCobbsF = "";
            infoOperativeDataViewModel.PostBPreAVTF = "";
            infoOperativeDataViewModel.PostBPreAVTS = "";
            infoOperativeDataViewModel.PostBPostAVTF = "";
            infoOperativeDataViewModel.PostBPostAVTS = "";
            infoOperativeDataViewModel.PostCCobbsF = "";
            infoOperativeDataViewModel.PostCPreAVTF = "";
            infoOperativeDataViewModel.PostCPreAVTS = "";
            infoOperativeDataViewModel.PostCPostAVTF = "";
            infoOperativeDataViewModel.PostCPostAVTS = "";
            infoOperativeDataViewModel.PostDCobbsF = "";
            infoOperativeDataViewModel.PostDPreAVTF = "";
            infoOperativeDataViewModel.PostDPreAVTS = "";
            infoOperativeDataViewModel.PostDPostAVTF = "";
            infoOperativeDataViewModel.PostDPostAVTS = "";
            infoOperativeDataViewModel.PostPreOpTrunkF = "";
            infoOperativeDataViewModel.PostPreOpTrunkS = "";
            infoOperativeDataViewModel.PostPostOpTrunkF = "";
            infoOperativeDataViewModel.PostPostOpTrunkS = "";
            infoOperativeDataViewModel.PostUpperF = "";
            infoOperativeDataViewModel.PostUpperS = "";
            infoOperativeDataViewModel.PostLowerF = "";
            infoOperativeDataViewModel.PostLowerS = "";
            infoOperativeDataViewModel.PostRemarkA = "";


            return infoOperativeDataViewModel;
        }

    }
}
