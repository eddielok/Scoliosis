
$(document).ready(function () {

    new Cleave('.class-DOC', {
        date: true,
        delimiter: '/',
        datePattern: ['d', 'm', 'Y']
    });

    $("#form").validate({
        rules: {
            "DOC": {
                required: true,
                regex: "(([1-2][0-9])|(0[1-9])|(3[0-1]))/((1[0-2])|(0[1-9]))/[0-9]{4}"
            },
            "Virtual": {
                required: true,
                maxlength: 1000
            },
            "CTrunkShift": {
                maxlength: 1000
            },
            "SpcRemarks": {
                maxlength: 1000
            },
			 "HT": {
                 required: true
            },
			 "ArmSpan": {
                 required: true
            },
			 "SHT": {
                 required: true
            },
			 "WT": {
                 required: true
            }
        },
        messages: {
            "DOC": {
                required: "Please enter DOC",
                regex: "The date format is DD/MM/YYYY"
            },
            "Virtual": {
                required: "Please enter Virtual"
            },
			 "HT": {
                 required: "Please enter Height"
            },
			 "ArmSpan": {
                 required: "Please enter Arm Span"
            },
			 "SHT": {
                 required: "Please enter Seating Height"
            },
			 "WT": {
                 required: "Please enter Weight "
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



function ShowReference(rID) {
    if (document.getElementById("Reference" + rID).style.display == "") {
        document.getElementById("Reference" + rID).style.display = "none";
    } else {
        for (i = 1; i <= 6; i++) {
            document.getElementById("Reference" + i).style.display = "none";
        }
        document.getElementById("Reference" + rID).style.display = "";
    }
}

function ShowOptions(rID) {

    if (document.getElementById("RemarkOptions" + rID).style.display == "") {
        document.getElementById("RemarkOptions" + rID).style.display = "none";
    } else {
        for (i = 1; i <= 9; i++) {
            document.getElementById("RemarkOptions" + i).style.display = "none";
        }
        document.getElementById("RemarkOptions" + rID).style.display = "";
    }
}

var visitIsChange = false;

function AddRemarks(concern) {

    concern = concern.replace(new RegExp("<br/>", "gm"), '\r\n');

    $('#SpcRemarks').val($('#SpcRemarks').val() + concern + '\n');
    visitIsChange = true;
}



function Init() {
    ChangeVisitType();
    CalHGV();
    CalSHTGV();
    CalWGV();
    CalASGV();
    CalLASGV();
    CalRASGV();

    visitIsChange = false;
}

function UpdateIsChange() {
    visitIsChange = true;
}

function CalHGV() {
    var DOC1 = $("#DOC").val();
    var ht = $("#HT").val();
    var lastHT = $("#LastHT").val();
    var lastDOC = $("#LastDOC").val();

    if ((!$.isNumeric(lastHT)) || lastDOC.length == 0) {
        $("#HGV").val(0);
    } else {
        var DOCArray1 = DOC1.split("/");
        var DOCArray2 = lastDOC.split("/");
        var D1 = new Date(DOCArray1[2], DOCArray1[1] - 1, DOCArray1[0]);
        var D2 = new Date(DOCArray2[2], DOCArray2[1] - 1, DOCArray2[0]);
        var oneday = 1000 * 60 * 60 * 24;
        var MDiff = (Math.ceil(D1.getTime() - D2.getTime()) / oneday * 12 / 365);
        $("#HGV").val(Math.ceil(100 * (ht - lastHT) / MDiff) / 100);
    }
}

function CalSHTGV() {
    var DOC1 = $("#DOC").val();
    var SHT = $("#SHT").val();
    var lastSHT = $("#LastSHT").val();
    var lastDOC = $("#LastDOC").val();

    if ((!$.isNumeric(lastSHT)) || lastDOC.length == 0) {
        $("#SHTGV").val(0);
    } else {
        var DOCArray1 = DOC1.split("/");
        var DOCArray2 = lastDOC.split("/");
        var D1 = new Date(DOCArray1[2], DOCArray1[1] - 1, DOCArray1[0]);
        var D2 = new Date(DOCArray2[2], DOCArray2[1] - 1, DOCArray2[0]);
        var oneday = 1000 * 60 * 60 * 24;
        var MDiff = (Math.ceil(D1.getTime() - D2.getTime()) / oneday * 12 / 365);
        $("#SHTGV").val(Math.ceil(100 * (SHT - lastSHT) / MDiff) / 100);
    }
}

function CalWGV() {
    var DOC1 = $("#DOC").val();
    var WT = $("#WT").val();
    var lastWT = $("#LastWT").val();
    var lastDOC = $("#LastDOC").val();

    if ((!$.isNumeric(lastWT)) || lastDOC.length == 0) {
        $("#WGV").val(0);
    } else {
        var DOCArray1 = DOC1.split("/");
        var DOCArray2 = lastDOC.split("/");
        var D1 = new Date(DOCArray1[2], DOCArray1[1] - 1, DOCArray1[0]);
        var D2 = new Date(DOCArray2[2], DOCArray2[1] - 1, DOCArray2[0]);
        var oneday = 1000 * 60 * 60 * 24;
        var MDiff = (Math.ceil(D1.getTime() - D2.getTime()) / oneday * 12 / 365);
        $("#WGV").val(Math.ceil(100 * (WT - lastWT) / MDiff) / 100);
    }
}

function CalASGV() {
    var DOC1 = $("#DOC").val();
    var ArmSpan = $("#ArmSpan").val();
    var LastAS = $("#LastAS").val();
    var lastDOC = $("#LastDOC").val();

    if ((!$.isNumeric(LastAS)) || lastDOC.length == 0) {
        $("#ASGV").val(0);
    } else {
        var DOCArray1 = DOC1.split("/");
        var DOCArray2 = lastDOC.split("/");
        var D1 = new Date(DOCArray1[2], DOCArray1[1] - 1, DOCArray1[0]);
        var D2 = new Date(DOCArray2[2], DOCArray2[1] - 1, DOCArray2[0]);
        var oneday = 1000 * 60 * 60 * 24;
        var MDiff = (Math.ceil(D1.getTime() - D2.getTime()) / oneday * 12 / 365);
        $("#ASGV").val(Math.ceil(100 * (ArmSpan - LastAS) / MDiff) / 100);
    }
}

function CalLASGV() {
    var DOC1 = $("#DOC").val();
    var LArmSpan = $("#LArmSpan").val();
    var lastLArmSpan = $("#LastLArmSpan").val();
    var lastDOC = $("#LastDOC").val();

    if ((!$.isNumeric(lastLArmSpan)) || lastDOC.length == 0) {
        $("#LASGV").val(0);
    } else {
        var DOCArray1 = DOC1.split("/");
        var DOCArray2 = lastDOC.split("/");
        var D1 = new Date(DOCArray1[2], DOCArray1[1] - 1, DOCArray1[0]);
        var D2 = new Date(DOCArray2[2], DOCArray2[1] - 1, DOCArray2[0]);
        var oneday = 1000 * 60 * 60 * 24;
        var MDiff = (Math.ceil(D1.getTime() - D2.getTime()) / oneday * 12 / 365);
        $("#LASGV").val(Math.ceil(100 * (LArmSpan - lastLArmSpan) / MDiff) / 100);
    }
}

function CalRASGV() {
    var DOC1 = $("#DOC").val();
    var RArmSpan = $("#RArmSpan").val();
    var LastRAS = $("#LastRAS").val();
    var lastDOC = $("#LastDOC").val();

    if ((!$.isNumeric(LastRAS)) || lastDOC.length == 0) {
        $("#RASGV").val(0);
    } else {
        var DOCArray1 = DOC1.split("/");
        var DOCArray2 = lastDOC.split("/");
        var D1 = new Date(DOCArray1[2], DOCArray1[1] - 1, DOCArray1[0]);
        var D2 = new Date(DOCArray2[2], DOCArray2[1] - 1, DOCArray2[0]);
        var oneday = 1000 * 60 * 60 * 24;
        var MDiff = (Math.ceil(D1.getTime() - D2.getTime()) / oneday * 12 / 365);
        $("#RASGV").val(Math.ceil(100 * (RArmSpan - LastRAS) / MDiff) / 100);
    }
}

function today() {
    var d = new Date();
    var dd, mm, yy

    if (d.getDate() < 10)
        dd = "0" + d.getDate()
    else
        dd = d.getDate();

    if (d.getMonth() + 1 < 10)
        mm = "0" + eval(d.getMonth() + 1)
    else
        mm = eval(d.getMonth() + 1);
    yy = d.getFullYear();

    //var todayVal = dd + "/" + mm + "/" + yy;

    var todayVal = dd + "/" + mm + "/" + yy;


    //$("input[name$='DOC']").val(todayVal);

    $("#DOC").val(todayVal);
}

function getToday() {

    var today = new Date();
    var dd = String(today.getDate()).padStart(2, '0');
    var mm = String(today.getMonth() + 1).padStart(2, '0'); //January is 0!
    var yyyy = today.getFullYear();

    //today = yyyy + "-" + mm + "-" + dd;

    today = dd + "/" + mm + "/" + yyyy;

    return today;

}

function ChangeVisitType() {

    var visitTypeVal = $("#Virtual option:selected").text();

    if (visitTypeVal == "Old X-Ray") {
        document.all.clinic.style.display = "none";
        document.all.plan.style.display = "none";
        document.all.measurement.style.display = "";
    } else if (visitTypeVal == "Pre-Clinic Measurement") {
        document.all.clinic.style.display = "none";
        document.all.plan.style.display = "none";
        document.all.measurement.style.display = "";
    }
    else {
        document.all.clinic.style.display = "";
        document.all.plan.style.display = "";
        document.all.measurement.style.display = "";


        preclinicMeasurementToNormalAction();
    }
}

function preclinicMeasurementToNormalAction() {

    var oriVirtual = $("#OriVirtual").val();
    var visit = $("#Virtual option:selected").text();

    if (oriVirtual == "Pre-Clinic Measurement" && visit == "Normal") {

        today();
    }
}

function handlePreclinicMeasurementToNormalAction() {

    var oriVirtual = $("#OriVirtual").val();
    var visit = $("#Virtual option:selected").text();

    var doc = $("#DOC").val();

    var today = getToday();

    if ((oriVirtual == "Pre-Clinic Measurement" && visit == "Normal") && (doc != today)) {

        if (confirm('Date of Clinic is not set today. This will modify the record. Continue?')) {
            return true;
        }

        return false;
    }

    return true;
}



function SetMenarche(obj) {
    if (obj.checked == true) {

        $('.isMenarchePos').prop('checked', true);
        $('.isMenarcheNeg').prop('checked', true);

        obj.checked = true;
    }
    if ($("#isMenarchePos").is(":checked") == false) {

        $('#MaturMonth').prop('disabled', 'disabled');
        $('#MaturYear').prop('disabled', 'disabled');
    } else {
        $('#MaturMonth').prop('disabled', 'false');
        $('#MaturYear').prop('disabled', 'false');
    }
}

function FillAbd(state) {

    $("#AbdReflexA").val(state);
    $("#AbdReflexB").val(state);
    $("#AbdReflexC").val(state);
    $("#AbdReflexD").val(state);

}

function ChangeNashMoe(CurveNo) {
    $("#ApicalDir" + CurveNo).val($("#CurveDir" + CurveNo).val());
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

function SetCurveLevel() {
    $("#CurveLevel1FromS").prop('selectedIndex') = 9;
    $("#CurveLevel1ToS").prop('selectedIndex') = 13;

    $("#CurveLevel2FromS").prop('selectedIndex') = 13;
    $("#CurveLevel2ToS").prop('selectedIndex') = 20;

    $("#CurveLevel3FromS").prop('selectedIndex') = 20;
    $("#CurveLevel3ToS").prop('selectedIndex') = 28;
}

function BraceAlert(selbox) {

    var planBraceVal = $("#PlanBrace option:selected").text();

    if (planBraceVal == "started" ||
        planBraceVal == "weaned" ||
        planBraceVal == "stopped") {
        document.all.brace.style.display = "";
    }
    else {
        document.all.brace.style.display = "none";
    }

    if (planBraceVal == "started" ||
        planBraceVal == "continued") {
        isBraceAlert = true;
    }
}

function SurgeryAlert(selbox) {

    var surgeryVal = $("#PlanSurgery option:selected").text();

    if (surgeryVal == "Yes") {
        document.all.surgery1.style.display = "";
    }
    else {
        document.all.surgery1.style.display = "none";
    }
}

function checkCobbAngle() {


    var withBrace = $("#withBrace option:selected").text();

    var curveDeg1 = $("#CurveDeg1").val();
    var curveDeg2 = $("#CurveDeg2").val();
    var curveDeg3 = $("#CurveDeg3").val();
    var curveDeg4 = $("#CurveDeg4").val();

    if ((curveDeg1.length != 0 && curveDeg1 != 0) ||
        (curveDeg2.length != 0 && curveDeg2 != 0) ||
        (curveDeg3.length != 0 && curveDeg3 != 0) ||
        (curveDeg4.length != 0 && curveDeg4 != 0)) {

        if (withBrace == "unknown") {
            alert("Unable to save. \n Degree of Curvature in Frontal Plane should not be unknown.");
            return false;
        }

    }

    return true;

}

function validateForm() {

    if (!checkCobbAngle()) {
        return false;
    }

    if (!handlePreclinicMeasurementToNormalAction()) {
        return false;
    }

    return true;
}

function handleChangeVisit() {

    //20200601 Success
    //var testJson1 = {};
    //testJson1["name"] = "abcand";

    if (visitIsChange == true) {

        if (confirm('Visit is changed. Are you sure you want to save this thing into the database?')) {

            var infoVisitModel = {};
            for (var i = 0, ii = form.length; i < ii; ++i) {
                var input = form[i];
                if (input.name) {
                    infoVisitModel[input.name] = input.value;
                }
            }
            var infoVisitModelStr1 = JSON.stringify(infoVisitModel);

            $.ajax({
                type: "POST",
                url: "../Patient/VisitPageAjax",
                data: infoVisitModelStr1,
                contentType: 'application/json; charset=utf-8',
                dataType: "json",
                success: function (responseData, status, xhr) {
                    console.log(responseData);
                },
                error: function (request, status, error) {
                    console.log(request.responseText);
                }
            });

            //alert("Saved");
        }

    }

}




//the traffic is blocked by Chrome
//window.onbeforeunload = confirmExit;
//function confirmExit() {
//    return "sbc";
//}   
function ToggleRemarkOptionsA() {
    if (document.all.RemarkOptionsA.style.display == "none") {
        document.all.RemarkOptionsA.style.display = ""
        document.all.RemarkOptionsTogglerA.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">Hide list</u>"
    } else {
        document.all.RemarkOptionsA.style.display = "none"
        document.all.RemarkOptionsTogglerA.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">A) Surgery</u>"
    }
}

function ToggleRemarkOptionsB() {
    if (document.all.RemarkOptionsB.style.display == "none") {
        document.all.RemarkOptionsB.style.display = ""
        document.all.RemarkOptionsTogglerB.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">Hide list</u>"
    } else {
        document.all.RemarkOptionsB.style.display = "none"
        document.all.RemarkOptionsTogglerB.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">B) Bracing</u>"
    }
}
function ToggleRemarkOptionsC() {
    if (document.all.RemarkOptionsC.style.display == "none") {
        document.all.RemarkOptionsC.style.display = ""
        document.all.RemarkOptionsTogglerC.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">Hide list</u>"
    } else {
        document.all.RemarkOptionsC.style.display = "none"
        document.all.RemarkOptionsTogglerC.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">C) Bracing Threshold</u>"
    }
}
function ToggleRemarkOptionsD() {
    if (document.all.RemarkOptionsD.style.display == "none") {
        document.all.RemarkOptionsD.style.display = ""
        document.all.RemarkOptionsTogglerD.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">Hide list</u>"
    } else {
        document.all.RemarkOptionsD.style.display = "none"
        document.all.RemarkOptionsTogglerD.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">D) Discharge Guideline</u>"
    }
}
function ToggleRemarkOptionsE() {
    if (document.all.RemarkOptionsE.style.display == "none") {
        document.all.RemarkOptionsE.style.display = ""
        document.all.RemarkOptionsTogglerE.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">Hide list</u>"
    } else {
        document.all.RemarkOptionsE.style.display = "none"
        document.all.RemarkOptionsTogglerE.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">E) References</u>"
    }
}
function ToggleRemarkOptionsF() {
    if (document.all.RemarkOptionsF.style.display == "none") {
        document.all.RemarkOptionsF.style.display = ""
        document.all.RemarkOptionsTogglerF.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">Hide list</u>"
    } else {
        document.all.RemarkOptionsF.style.display = "none"
        document.all.RemarkOptionsTogglerF.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">F) TOCI diagram</u>"
    }
}
function ToggleRemarkOptionsG() {
    if (document.all.RemarkOptionsG.style.display == "none") {
        document.all.RemarkOptionsG.style.display = ""
        document.all.RemarkOptionsTogglerG.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">Hide list</u>"
		alert
    } else {
        document.all.RemarkOptionsG.style.display = "none"
        document.all.RemarkOptionsTogglerG.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">G) Add TOCI and Growth Key findings</u>"
    }
}

function SetTOCI(cb) {
    if (cb.checked == true) {
		$('#TOCI1').prop('checked', false);
        $('#TOCI2').prop('checked', false);
        $('#TOCI3').prop('checked', false);
        $('#TOCI4').prop('checked', false);
		$('#TOCI5').prop('checked', false);
		$('#TOCI6').prop('checked', false);
		$('#TOCI7').prop('checked', false);
		$('#TOCI8').prop('checked', false);
        cb.checked = true;
    }
}

function PrepareSave() {

	//TOCI
	if($('#TOCI1').prop('checked')) {$('#TOCI').val('1');}	
	if($('#TOCI2').prop('checked')) {$('#TOCI').val('2');}	
	if($('#TOCI3').prop('checked')) {$('#TOCI').val('3');}	
	if($('#TOCI4').prop('checked')) {$('#TOCI').val('4');}	
	if($('#TOCI5').prop('checked')) {$('#TOCI').val('5');}	
	if($('#TOCI6').prop('checked')) {$('#TOCI').val('6');}	
	if($('#TOCI7').prop('checked')) {$('#TOCI').val('7');}	
	if($('#TOCI8').prop('checked')) {$('#TOCI').val('8');}	
}

function Validation() {

    if (!validateDateRange()) {
        alert("DOC is invalid. Please check. ")
        return false;
    }
    return true;
}

function validateDateRange() {
    var DOC1 = $("#DOC").val();
    var DOCArray1 = DOC1.split("/");
    var D1 = new Date(DOCArray1[2], DOCArray1[1] - 1, DOCArray1[0]);
    var D2 = new Date(2047, 7, 1); //YYYY, MM, DD
    var D3 = new Date(1997, 7, 1); //YYYY, MM, DD


    if (D1 >= D2) {
        return false;
    }

    if (D1 <= D3) {
        return false;
    }

    return true;
}

