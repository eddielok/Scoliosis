

$(document).ready(function () {

    new Cleave('.class-DOC', {
        date: true,
        delimiter: '/',
        datePattern: ['d', 'm', 'Y']
    });



    $("#form").validate({
        rules: {
            "PlanDateD": {
                required: false,
                regex: "(([1-2][0-9])|(0[1-9])|(3[0-1]))/((1[0-2])|(0[1-9]))/[0-9]{4}"
            },
            "IntraDateD": {
                required: true,
                regex: "(([1-2][0-9])|(0[1-9])|(3[0-1]))/((1[0-2])|(0[1-9]))/[0-9]{4}"
            },
            "PlanDoctorS": {
                required: true
            }
        },



        messages: {
            "PlanDateD": {
                required: "Please enter Plan Date",
                regex: "The date format is DD/MM/YYYY"
            },
            "IntraDateD": {
                required: "Please enter Intra Date",
                regex: "The date format is DD/MM/YYYY"
            },
            "PlanDoctorS": {
                required: "Please select Doctor in pre-operative planning"
            }
        },
        submitHandler: function (form) { // for demo
            //alert('valid form submitted'); // for demo
            return true; // for demo
        },
        errorElement: "em",
        errorPlacement: function (error, element) {
            // Add the `help-block` class to the error element
            error.addClass("help-block");

            if (element.prop("type") === "checkbox") {
                error.insertAfter(element.parent("label"));
            } else {
                error.insertAfter(element);
            }
        },
        highlight: function (element, errorClass, validClass) {
            $(element).parents(".col-sm-1").addClass("has-error").removeClass("has-success");
        },
        unhighlight: function (element, errorClass, validClass) {
            $(element).parents(".col-sm-1").addClass("has-success").removeClass("has-error");
        }
    });

});

$(document).ready(function () {
    jQuery.validator.addMethod(
        "regex",
        function (value, element, regexp) {
            var check = false;
            var re = new RegExp(regexp);
            return this.optional(element) || re.test(value);
        }, ""
    );
});

AutoCal();

function AutoCal() {

    ;

    if ($("#PreFVCPredictionF").val() != "" && $("#PreFVCObservedF").val() != "") {
        $("#PreFVCAuto").val($("#PreFVCObservedF").val() / $("#PreFVCPredictionF").val() * 100.0);
    } else {
        $("#PreFVCAuto").val("N/A");
    }

    if ($("#PreFEV1PredictionF").val() != "" && $("#PreFEV1ObservedF").val() != "") {
        $("#PreFEV1Auto").val($("#PreFEV1ObservedF").val() / $("#PreFEV1PredictionF").val() * 100.0);
    } else {
        $("#PreFEV1Auto").val("N/A");
    }

    if ($("#IntraWholeBloodF").val() != "" && $("#PostTransfusionWholeF").val() != "") {
        $("#PostTotalWholeBloodAuto").val($("#IntraWholeBloodF").val() + $("#PostTransfusionWholeF").val());
    } else {
        $("#PostTotalWholeBloodAuto").val("N/A");
    }

    if ($("#IntraPackedCellF").val() != "" && $("#PostTransfusionPackedF").val() != "") {
        $("#PostTotalPackedCellAuto").val($("#IntraPackedCellF").val() + $("#PostTransfusionPackedF").val());
    } else {
        $("#PostTotalPackedCellAuto").val("N/A");
    }

    if ($("#PreARankS").val() != "") {
        $("#PostARankAuto").val($("#PreARankS").val());
    } else {
        $("#PostARankAuto").val("N/A");
    }

    if ($("#PreBRankS").val() != "") {
        $("#PostBRankAuto").val($("#PreBRankS").val());
    } else {
        $("#PostBRankAuto").val("N/A");
    }

    if ($("#PreCRankS").val() != "") {
        $("#PostCRankAuto").val($("#PreCRankS").val());
    } else {
        $("#PostCRankAuto").val("N/A");
    }

    if ($("#PreDRankS").val() != "") {
        $("#PostDRankAuto").val($("#PreDRankS").val());
    } else {
        $("#PostDRankAuto").val("N/A");
    }

    if ($("#PreACobbsAngleF").val() != "") {
        $("#PostACobbsAuto").val($("#PreACobbsAngleF").val());
    } else {
        $("#PostACobbsAuto").val("N/A");
    }

    if ($("#PreACobbsBngleF").val() != "") {
        $("#PostBCobbsAuto").val($("#PreBCobbsAngleF").val());
    } else {
        $("#PostBCobbsAuto").val("N/A");
    }

    if ($("#PreCCobbsAngleF").val() != "") {
        $("#PostCCobbsAuto").val($("#PreCCobbsAngleF").val());
    } else {
        $("#PostCCobbsAuto").val("N/A");
    }

    if ($("#PreDCobbsAngleF").val() != "") {
        $("#PostDCobbsAuto").val($("#PreDCobbsAngleF").val());
    } else {
        $("#PostDCobbsAuto").val("N/A");
    }

    if ($("#PreACobbsAngleF").val() != "" && $("#PostACobbsF").val() != "" && !isNaN(parseFloat($("#PostACobbsF").val()))) {
        $("#PostACorrectionAuto").val(($("#PreACobbsAngleF").val() - $("#PostACobbsF").val()) / $("#PreACobbsAngleF").val() * 100.0);
    } else {
        $("#PostACorrectionAuto").val("N/A");
    }

    if ($("#PreBCobbsAngleF").val() != "" && $("#PostBCobbsF").val() != "" && !isNaN(parseFloat($("#PostBCobbsF").val()))) {
        $("#PostBCorrectionAuto").val(($("#PreBCobbsAngleF").val() - $("#PostBCobbsF").val()) / $("#PreBCobbsAngleF").val() * 100.0);
    } else {
        $("#PostBCorrectionAuto").val("N/A");
    }

    if ($("#PreCCobbsAngleF").val() != "" && $("#PostCCobbsF").val() != "" && !isNaN(parseFloat($("#PostCCobbsF").val()))) {
        $("#PostCCorrectionAuto").val(($("#PreCCobbsAngleF").val() - $("#PostCCobbsF").val()) / $("#PreCCobbsAngleF").val() * 100.0);
    } else {
        $("#PostCCorrectionAuto").val("N/A");
    }

    if ($("#PreDCobbsAngleF").val() != "" && $("#PostDCobbsF").val() != "" && !isNaN(parseFloat($("#PostDCobbsF").val()))) {
        $("#PostDCorrectionAuto").val(($("#PreDCobbsAngleF").val() - $("#PostDCobbsF").val()) / $("#PreDCobbsAngleF").val() * 100.0);
    } else {
        $("#PostDCorrectionAuto").val("N/A");
    }

    if ($("#IntraPlateletF").val() != "" && $("#PostPlateletF").val() != "") {
        $("#PostPlateletAuto").val(($("#IntraPlateletF").val() + $("#PostPlateletF").val()));
    } else {
        $("#PostPlateletAuto").val("N/A");
    }

    if ($("#IntraFFPF").val() != "" && $("#PostFFPF").val() != "") {
        $("#PostFFPAuto").val(($("#IntraFFPF").val() + $("#PostFFPF").val()));
    } else {
        $("#PostFFPAuto").val("N/A");
    }


    if ($("#IntraNonSaverF").val() != "" ) {
        $("#PostFFPAuto").val(($("#IntraFFPF").val() + $("#PostFFPF").val()));

        if ($("#IntraSaverF").val() != "") {
            $("#IntraBloodAuto").val(($("#IntraNonSaverF").val() + $("#IntraSaverF").val()));

        } else {
            $("#IntraBloodAuto").val(($("#IntraNonSaverF").val()));
        }

    } else {
        $("#IntraBloodAuto").val("N/A");
    }

    if ($("#IntraCrystalloidF").val() != "" && $("#IntraColloidF").val() != "") {
        $("#IntraFluidAuto").val(($("#IntraCrystalloidF").val() + $("#IntraColloidF").val()));
    } else {
        $("#IntraFluidAuto").val("N/A");
    }

    if ($("#IntraDateD").val() != "") {

        var temp = new Array();
        temp = $("#IntraDateD").val().split('/');
        yy = temp[2];
        mm = temp[1];
        if (yy > 1900 && yy < 2100 && mm >= 1 && mm <= 12) {

            dy = eval(yy);
            dm = eval(mm);

            if (dm < 0) {
                dm = dm + 12;
                dy = dy - 1;
            }
            if (dy >= 0) {
                $("#IntraYearAuto").val(dy);
                $("#IntraMonthAuto").val(dm);
            }
            else {
                $("#IntraYearAuto").val("N/A");
                $("#IntraMonthAuto").val("N/A");
            }

        } else {
            $("#IntraYearAuto").val("N/A");
            $("#IntraMonthAuto").val("N/A");
        }

    } else {
        $("#IntraYearAuto").val("N/A");
        $("#IntraMonthAuto").val("N/A");
    }
}

function OnChangeLevelFrom(From, To) {
    if (From.selectedIndex > To.selectedIndex)
        To.selectedIndex = From.selectedIndex;
    else if (From.selectedIndex == 0)
        To.selectedIndex = 0;
}

function OnChangeLevelTo(From, To) {
    if (From.selectedIndex > To.selectedIndex)
        From.selectedIndex = To.selectedIndex;
    else if (From.selectedIndex == 0)
        From.selectedIndex = To.selectedIndex;
}


//function today() {
//    var d = new Date();
//    var dd, mm, yy

//    if (d.getDate() < 10)
//        dd = "0" + d.getDate()
//    else
//        dd = d.getDate();

//    if (d.getMonth() + 1 < 10)
//        mm = "0" + eval(d.getMonth() + 1)
//    else
//        mm = eval(d.getMonth() + 1);
//    yy = d.getFullYear();

//    //var todayVal = dd + "/" + mm + "/" + yy;

//    var todayVal = dd + "/" + mm + "/" + yy;

//    $("input[name$='iadate']").val(todayVal);
//}

//function getToday(){

//    var today = new Date();
//    var dd = String(today.getDate()).padStart(2, '0');
//    var mm = String(today.getMonth() + 1).padStart(2, '0'); //January is 0!
//    var yyyy = today.getFullYear();

//    today =  yyyy + "-" + mm + "-" + dd ;

//    return today;

//} 

//function SetReferral(cb) {

//    if (cb.checked == true) {
//        $('#isReferralStudent').prop('checked', false);
//        $('#isReferralOther').prop('checked', false);
//        cb.checked = true;
//    }
//}

//function SetConcern(cb) {

//    if (cb.checked == true) {
//        $('#isConcernNil').prop('checked', false);
//        $('#isConcernOther').prop('checked', false);
//        cb.checked = true;
//    }

//}

//function SetSymptom(cb) {
//    if (cb.checked == true) {
//        $('#isSymNil').prop('checked', false);
//        cb.checked = true;

//        if ($('#isSymNil').prop('checked') == true) {
//            $('#isSymBack').prop('checked', false);
//            $('#isSymLimb').prop('checked', false);
//            $('#isSymCon').prop('checked', false);
//            $('#isSymOther').prop('checked', false);
//        }
//    }
//}

//function SetPast(cb) {
//    if (cb.checked == true) {
//        $('#isPastGood').prop('checked', false);
//        cb.checked = true;

//        if ($('#isPastGood').prop('checked') == true) {
//            $('#isPastSpinal').prop('checked', false);
//            $('#isPastBone').prop('checked', false);
//            $('#isPastOther').prop('checked', false);
//        }

//    }
//}

//function SetMedication(cb) {
//    if (cb.checked == true) {
//        $('#isMedicationNil').prop('checked', false);
//        $('#isMedication').prop('checked', false);
//        cb.checked = true;
//    }
//}

//function SetPreOp(cb) {
//    if (cb.checked == true) {
//        $('#isPreOpNil').prop('checked', false);
//        $('#isPreOp').prop('checked', false);
//        cb.checked = true;
//    }
//}


//function SetGen(cb) {
//    if (cb.checked == true) {
//        $('#isGenNormal').prop('checked', false);
//        cb.checked = true;

//        if ($('#isGenNormal').prop('checked') == true) {
//            $('#isGenLeg').prop('checked', false);
//            $('#isGenDys').prop('checked', false);
//            $('#isGenSkin').prop('checked', false);
//            $('#isGenOther').prop('checked', false);
//        }
//    }
//}


//function SetBackInspect(cb) {
//    if (cb.checked == true) {
//        $('#isBackInspectNormal').prop('checked', false);
//        cb.checked = true;

//        if ($('#isBackInspectNormal').prop('checked') == true) {
//            $('#isBackInspectAsy').prop('checked', false);
//            $('#isBackInspectRib').prop('checked', false);
//            $('#isBackInspectLumbar').prop('checked', false);
//            $('#isBackInspectOther').prop('checked', false);
//            $('#isBackPelvisTilt').prop('checked', false);
//        }
//    }
//}

//function SetBackPalpation(cb) {

//    if (cb.checked == true) {
//        $('#isBackPalpationNormal').prop('checked', false);
//        $('#isBackPalpationAbnormal').prop('checked', false);
//        cb.checked = true;
//    }
//}

//function SetBackLeg(cb) {
//    if (cb.checked == true) {
//        $('#isBackLegNormal').prop('checked', false);
//        $('#isBackLegAbnormal').prop('checked', false);
//        cb.checked = true;
//    }
//}

//function SetBackLimb(cb) {
//    if (cb.checked == true) {
//        $('#isBackLimbNormal').prop('checked', false);
//        $('#isBackLimbAbnormal').prop('checked', false);
//        cb.checked = true;
//    }
//}

//function AutoCheck(obj, cb, cb1) {
//    if (obj.value.length > 0) {
//        cb.checked = true;
//        cb1.checked = false;
//    }
//}

//function SetAllergy(cb) {
//    if (cb.checked == true) {
//        $('#isAllergyNil').prop('checked', false);
//        $('#isAllergy').prop('checked', false);
//        cb.checked = true;
//    }
//}


//function SetBackRange(cb) {
//    if (cb.checked == true) {
//        $('#isBackRangeNormal').prop('checked', false);

//        cb.checked = true;

//        if ($('#isBackRangeNormal').prop('checked') == true) {
//            $('#isBackRangeAbnormal').prop('checked', false);
//            $('#isBackRangeDys').prop('checked', false);
//        }

//    }
//}

//function ToggleRemarkOptions1() {
//    if (document.all.RemarkOptions1.style.display == "none") {
//        document.all.RemarkOptions1.style.display = ""
//        document.all.RemarkOptionsToggler1.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">Hide list</u>"
//    } else {
//        document.all.RemarkOptions1.style.display = "none"
//        document.all.RemarkOptionsToggler1.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">Initial Visit</u>"
//    }
//}

//function ToggleRemarkOptions2() {
//    if (document.all.RemarkOptions2.style.display == "none") {
//        document.all.RemarkOptions2.style.display = ""
//        document.all.RemarkOptionsToggler2.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">Hide list</u>"
//    } else {
//        document.all.RemarkOptions2.style.display = "none"
//        document.all.RemarkOptionsToggler2.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">Investigation</u>"
//    }
//}
//function ToggleRemarkOptions3() {
//    if (document.all.RemarkOptions3.style.display == "none") {
//        document.all.RemarkOptions3.style.display = ""
//        document.all.RemarkOptionsToggler3.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">Hide list</u>"
//    } else {
//        document.all.RemarkOptions3.style.display = "none"
//        document.all.RemarkOptionsToggler3.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">Bracing</u>"
//    }
//}
//function ToggleRemarkOptions4() {
//    if (document.all.RemarkOptions4.style.display == "none") {
//        document.all.RemarkOptions4.style.display = ""
//        document.all.RemarkOptionsToggler4.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">Hide list</u>"
//    } else {
//        document.all.RemarkOptions4.style.display = "none"
//        document.all.RemarkOptionsToggler4.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">Surgery</u>"
//    }
//}
//function ToggleRemarkOptions5() {
//    if (document.all.RemarkOptions5.style.display == "none") {
//        document.all.RemarkOptions5.style.display = ""
//        document.all.RemarkOptionsToggler5.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">Hide list</u>"
//    } else {
//        document.all.RemarkOptions5.style.display = "none"
//        document.all.RemarkOptionsToggler5.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">Follow up</u>"
//    }
//}

//function AddRemarks(concern) {
//    $('#Remarks').val($('#Remarks').val() + concern);
//    changed();
//}


//function AddConcern(concern) {
//    $('#ConcernOther').val($('#ConcernOther').val() + concern);
//    $('#isConcernOther').prop('checked', true);
//    $('#isConcernNil').prop('checked', false);
//}

//function ToggleConcernList() {
//    if (document.all.ConcernList.style.display == "none") {
//        document.all.ConcernList.style.display = ""
//        document.all.hello.innerHTML = "<u style=\"cursor: hand\">Hide list</u>"
//    } else {
//        document.all.ConcernList.style.display = "none"
//        document.all.hello.innerHTML = "<u style=\"cursor: hand\">Choose from list</u>"
//    }
//}


//function SetNormal() {
//    $('#isGenNormal').prop('checked', true);
//    SetGen($('#isGenNormal'));
//    $('#isBackPalpationNormal').prop('checked', true);
//    SetBackPalpation($('#isBackPalpationNormal'));
//    $('#isBackRangeNormal').prop('checked', true);
//    SetBackRange($('#isBackRangeNormal'));
//    $('#isBackLegNormal').prop('checked', true);
//    SetBackLeg($('#isBackLegNormal'));
//    $('#isBackLimbNormal').prop('checked', true);
//    SetBackLimb($('#isBackLimbNormal'));
//    alert("Please fill in Inspection");
//    window.location = "#Inspection";
//}



//function SetHistory() {
//    $('#isSymNil').prop('checked', true);
//    SetSymptom($('#isSymNil'));
//    $('#isPastGood').prop('checked', true);
//    SetPast($('#isPastGood'));
//    $('#isMedicationNil').prop('checked', true);
//    SetMedication($('#isMedicationNil'));
//    $('#isPreOpNil').prop('checked', true);
//    SetPreOp($('#isPreOpNil'));
//    $('#isAllergyNil').prop('checked', true);
//    SetAllergy($('#isAllergyNil'));    

//}