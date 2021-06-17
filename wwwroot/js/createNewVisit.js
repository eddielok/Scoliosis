

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
            }
        },
        messages: {
            "DOC": {
                required: "Please enter DOC",
                regex: "The date format is DD/MM/YYYY"
            },
            "Virtual": {
                required: "Please enter Virtual"
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


function AddRemarks(concern) {
    $('#SpcRemarks').val($('#SpcRemarks').val() + concern);
}

function CalHGV() {
    var DOC1 = $("#DOC").val();
    var DOC2 = $("#DOC1").val();
    var ht = $("#HT").val();
    var lastHT = $("#LastHT").val();
    var lastDOC = $("#DOC1").val();

    if ((!$.isNumeric(lastHT)) || lastDOC.length == 0) {
        $("#HGV").val(0);
    } else {
        var DOCArray1 = DOC1.split("/");
        var DOCArray2 = DOC2.split("/");
        var D1 = new Date(DOCArray1[2], DOCArray1[1] - 1, DOCArray1[0]);
        var D2 = new Date(DOCArray2[2], DOCArray2[1] - 1, DOCArray2[0]);
        var oneday = 1000 * 60 * 60 * 24;
        var MDiff = (Math.ceil(D1.getTime() - D2.getTime()) / oneday * 12 / 365);
        $("#HGV").val(Math.ceil(100 * (ht - lastHT) / MDiff) / 100);
    }
}

function CalSHTGV() {
    var DOC1 = $("#DOC").val();
    var DOC2 = $("#DOC1").val();
    var SHT = $("#SHT").val();
    var lastSHT = $("#LastSCalSHTGVHT").val();
    var lastDOC = $("#DOC1").val();

    if ((!$.isNumeric(lastSHT)) || lastDOC.length == 0) {
        $("#SHTGV").val(0);
    } else {
        var DOCArray1 = DOC1.split("/");
        var DOCArray2 = DOC2.split("/");
        var D1 = new Date(DOCArray1[2], DOCArray1[1] - 1, DOCArray1[0]);
        var D2 = new Date(DOCArray2[2], DOCArray2[1] - 1, DOCArray2[0]);
        var oneday = 1000 * 60 * 60 * 24;
        var MDiff = (Math.ceil(D1.getTime() - D2.getTime()) / oneday * 12 / 365);
        $("#SHTGV").val(Math.ceil(100 * (SHT - lastSHT) / MDiff) / 100);
    }
}

function CalWGV() {
    var DOC1 = $("#DOC").val();
    var DOC2 = $("#DOC1").val();
    var WT = $("#WT").val();
    var lastWT = $("#LastWT").val();
    var lastDOC = $("#DOC1").val();

    if ((!$.isNumeric(lastWT)) || lastDOC.length == 0) {
        $("#WGV").val(0);
    } else {
        var DOCArray1 = DOC1.split("/");
        var DOCArray2 = DOC2.split("/");
        var D1 = new Date(DOCArray1[2], DOCArray1[1] - 1, DOCArray1[0]);
        var D2 = new Date(DOCArray2[2], DOCArray2[1] - 1, DOCArray2[0]);
        var oneday = 1000 * 60 * 60 * 24;
        var MDiff = (Math.ceil(D1.getTime() - D2.getTime()) / oneday * 12 / 365);
        $("#WGV").val(Math.ceil(100 * (WT - lastWT) / MDiff) / 100);
    }
}

function CalASGV() {
    var DOC1 = $("#DOC").val();
    var DOC2 = $("#DOC1").val();
    var ArmSpan = $("#ArmSpan").val();
    var lastArmSpan = $("#LastWT").val();
    var lastDOC = $("#DOC1").val();

    if ((!$.isNumeric(lastArmSpan)) || lastDOC.length == 0) {
        $("#ASGV").val(0);
    } else {
        var DOCArray1 = DOC1.split("/");
        var DOCArray2 = DOC2.split("/");
        var D1 = new Date(DOCArray1[2], DOCArray1[1] - 1, DOCArray1[0]);
        var D2 = new Date(DOCArray2[2], DOCArray2[1] - 1, DOCArray2[0]);
        var oneday = 1000 * 60 * 60 * 24;
        var MDiff = (Math.ceil(D1.getTime() - D2.getTime()) / oneday * 12 / 365);
        $("#ASGV").val(Math.ceil(100 * (ArmSpan - lastArmSpan) / MDiff) / 100);
    }
}

function CalLASGV() {
    var DOC1 = $("#DOC").val();
    var DOC2 = $("#DOC1").val();
    var LArmSpan = $("#LArmSpan").val();
    var lastLArmSpan = $("#LastLArmSpan").val();
    var lastDOC = $("#DOC1").val();

    if ((!$.isNumeric(lastLArmSpan)) || lastDOC.length == 0) {
        $("#LASGV").val(0);
    } else {
        var DOCArray1 = DOC1.split("/");
        var DOCArray2 = DOC2.split("/");
        var D1 = new Date(DOCArray1[2], DOCArray1[1] - 1, DOCArray1[0]);
        var D2 = new Date(DOCArray2[2], DOCArray2[1] - 1, DOCArray2[0]);
        var oneday = 1000 * 60 * 60 * 24;
        var MDiff = (Math.ceil(D1.getTime() - D2.getTime()) / oneday * 12 / 365);
        $("#LASGV").val(Math.ceil(100 * (LArmSpan - lastLArmSpan) / MDiff) / 100);
    }
}

function CalRASGV() {
    var DOC1 = $("#DOC").val();
    var DOC2 = $("#DOC1").val();
    var RArmSpan = $("#RArmSpan").val();
    var lastRArmSpan = $("#LastRArmSpan").val();
    var lastDOC = $("#DOC1").val();

    if ((!$.isNumeric(lastRArmSpan)) || lastDOC.length == 0) {
        $("#RASGV").val(0);
    } else {
        var DOCArray1 = DOC1.split("/");
        var DOCArray2 = DOC2.split("/");
        var D1 = new Date(DOCArray1[2], DOCArray1[1] - 1, DOCArray1[0]);
        var D2 = new Date(DOCArray2[2], DOCArray2[1] - 1, DOCArray2[0]);
        var oneday = 1000 * 60 * 60 * 24;
        var MDiff = (Math.ceil(D1.getTime() - D2.getTime()) / oneday * 12 / 365);
        $("#RASGV").val(Math.ceil(100 * (RArmSpan - lastRArmSpan) / MDiff) / 100);
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

    $("input[name$='DOC']").val(todayVal);
}

function getToday(){

    var today = new Date();
    var dd = String(today.getDate()).padStart(2, '0');
    var mm = String(today.getMonth() + 1).padStart(2, '0'); //January is 0!
    var yyyy = today.getFullYear();

    today =  yyyy + "-" + mm + "-" + dd ;

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
    }
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


