

$(document).ready(function () {

    new Cleave('.class-DOC', {
        date: true,
        delimiter: '/',
        datePattern: ['d', 'm', 'Y']
    });


    $("#form").validate({
        rules: {
            "iadate": {
                required: true,
                regex: "(([1-2][0-9])|(0[1-9])|(3[0-1]))/((1[0-2])|(0[1-9]))/[0-9]{4}"
            },
            "ReferralOther": {
                maxlength: 1000
            },
            "ConcernOther": {
                maxlength: 1000
            },
            "SymOther": {
                maxlength: 1000
            },
            "PastSpinal": {
                maxlength: 1000
            },
            "PastOther": {
                maxlength: 1000
            },
            "PreOp": {
                maxlength: 1000
            },
            "GenLeg": {
                maxlength: 1000
            },
            "GenDys": {
                maxlength: 1000
            },
            "GenSkin": {
                maxlength: 1000
            },
            "GenOther": {
                maxlength: 1000
            },
            "Allergy": {
                maxlength: 1000
            },
            "BackInspectOther": {
                maxlength: 1000
            },
            "BackPalpationAbnormal": {
                maxlength: 1000
            },
            "BackRangeDys": {
                maxlength: 1000
            },
            "BackLegAbnormal": {
                maxlength: 1000
            },
            "BackLimbAbnormal": {
                maxlength: 1000
            },
            "Remarks": {
                maxlength: 1000
            }


        },
        messages: {
            "DOC": {
                required: "Please enter DOC",
                regex: "The date format is DD/MM/YYYY"
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

    $("input[name$='iadate']").val(todayVal);
}

function getToday(){

    var today = new Date();
    var dd = String(today.getDate()).padStart(2, '0');
    var mm = String(today.getMonth() + 1).padStart(2, '0'); //January is 0!
    var yyyy = today.getFullYear();

    today =  yyyy + "-" + mm + "-" + dd ;

    return today;

} 

function SetReferral(cb) {

    if (cb.checked == true) {
        $('#isReferralStudent').prop('checked', false);
        $('#isReferralOther').prop('checked', false);
        cb.checked = true;
    }
}

function SetConcern(cb) {

    if (cb.checked == true) {
        $('#isConcernNil').prop('checked', false);
        $('#isConcernOther').prop('checked', false);
        cb.checked = true;
    }

}

function SetSymptom(cb) {
    if (cb.checked == true) {
        $('#isSymNil').prop('checked', false);
        cb.checked = true;

        if ($('#isSymNil').prop('checked') == true) {
            $('#isSymBack').prop('checked', false);
            $('#isSymLimb').prop('checked', false);
            $('#isSymCon').prop('checked', false);
            $('#isSymOther').prop('checked', false);
        }
    }
}

function SetPast(cb) {
    if (cb.checked == true) {
        $('#isPastGood').prop('checked', false);
        cb.checked = true;

        if ($('#isPastGood').prop('checked') == true) {
            $('#isPastSpinal').prop('checked', false);
            $('#isPastBone').prop('checked', false);
            $('#isPastOther').prop('checked', false);
        }
		
    }
}

function SetMedication(cb) {
    if (cb.checked == true) {
        $('#isMedicationNil').prop('checked', false);
        $('#isMedication').prop('checked', false);
        cb.checked = true;
    }
}

function SetPreOp(cb) {
    if (cb.checked == true) {
        $('#isPreOpNil').prop('checked', false);
        $('#isPreOp').prop('checked', false);
        cb.checked = true;
    }
}


function SetGen(cb) {
    if (cb.checked == true) {
        $('#isGenNormal').prop('checked', false);
        cb.checked = true;

        if ($('#isGenNormal').prop('checked') == true) {
            $('#isGenLeg').prop('checked', false);
            $('#isGenDys').prop('checked', false);
            $('#isGenSkin').prop('checked', false);
            $('#isGenOther').prop('checked', false);
        }
    }
}


function SetBackInspect(cb) {
    if (cb.checked == true) {
        $('#isBackInspectNormal').prop('checked', false);
        cb.checked = true;

        if ($('#isBackInspectNormal').prop('checked') == true) {
            $('#isBackInspectAsy').prop('checked', false);
            $('#isBackInspectRib').prop('checked', false);
            $('#isBackInspectLumbar').prop('checked', false);
            $('#isBackInspectOther').prop('checked', false);
            $('#isBackPelvisTilt').prop('checked', false);
        }
    }
}

function SetBackPalpation(cb) {

    if (cb.checked == true) {
        $('#isBackPalpationNormal').prop('checked', false);
        $('#isBackPalpationAbnormal').prop('checked', false);
        cb.checked = true;
    }
}

function SetBackLeg(cb) {
    if (cb.checked == true) {
        $('#isBackLegNormal').prop('checked', false);
        $('#isBackLegAbnormal').prop('checked', false);
        cb.checked = true;
    }
}

function SetBackLimb(cb) {
    if (cb.checked == true) {
        $('#isBackLimbNormal').prop('checked', false);
        $('#isBackLimbAbnormal').prop('checked', false);
        cb.checked = true;
    }
}

function AutoCheck(obj, cb, cb1) {
    if (obj.value.length > 0) {
        cb.checked = true;
        cb1.checked = false;
    }
}

function SetAllergy(cb) {
    if (cb.checked == true) {
        $('#isAllergyNil').prop('checked', false);
        $('#isAllergy').prop('checked', false);
        cb.checked = true;
    }
}


function SetBackRange(cb) {
    if (cb.checked == true) {
        $('#isBackRangeNormal').prop('checked', false);

        cb.checked = true;

        if ($('#isBackRangeNormal').prop('checked') == true) {
            $('#isBackRangeAbnormal').prop('checked', false);
            $('#isBackRangeDys').prop('checked', false);
        }

    }
}

function ToggleRemarkOptions1() {
    if (document.all.RemarkOptions1.style.display == "none") {
        document.all.RemarkOptions1.style.display = ""
        document.all.RemarkOptionsToggler1.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">Hide list</u>"
    } else {
        document.all.RemarkOptions1.style.display = "none"
        document.all.RemarkOptionsToggler1.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">Initial Visit</u>"
    }
}

function ToggleRemarkOptions2() {
    if (document.all.RemarkOptions2.style.display == "none") {
        document.all.RemarkOptions2.style.display = ""
        document.all.RemarkOptionsToggler2.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">Hide list</u>"
    } else {
        document.all.RemarkOptions2.style.display = "none"
        document.all.RemarkOptionsToggler2.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">Investigation</u>"
    }
}
function ToggleRemarkOptions3() {
    if (document.all.RemarkOptions3.style.display == "none") {
        document.all.RemarkOptions3.style.display = ""
        document.all.RemarkOptionsToggler3.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">Hide list</u>"
    } else {
        document.all.RemarkOptions3.style.display = "none"
        document.all.RemarkOptionsToggler3.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">Bracing</u>"
    }
}
function ToggleRemarkOptions4() {
    if (document.all.RemarkOptions4.style.display == "none") {
        document.all.RemarkOptions4.style.display = ""
        document.all.RemarkOptionsToggler4.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">Hide list</u>"
    } else {
        document.all.RemarkOptions4.style.display = "none"
        document.all.RemarkOptionsToggler4.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">Surgery</u>"
    }
}
function ToggleRemarkOptions5() {
    if (document.all.RemarkOptions5.style.display == "none") {
        document.all.RemarkOptions5.style.display = ""
        document.all.RemarkOptionsToggler5.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">Hide list</u>"
    } else {
        document.all.RemarkOptions5.style.display = "none"
        document.all.RemarkOptionsToggler5.innerHTML = "<u style=\"cursor: hand; font-size: 11px;\">Follow up</u>"
    }
}

function AddRemarks(concern) {
    $('#Remarks').val($('#Remarks').val() + concern);
    changed();
}


function AddConcern(concern) {
    $('#ConcernOther').val($('#ConcernOther').val() + concern);
    $('#isConcernOther').prop('checked', true);
    $('#isConcernNil').prop('checked', false);
}

function ToggleConcernList() {
    if (document.all.ConcernList.style.display == "none") {
        document.all.ConcernList.style.display = ""
        document.all.hello.innerHTML = "<u style=\"cursor: hand\">Hide list</u>"
    } else {
        document.all.ConcernList.style.display = "none"
        document.all.hello.innerHTML = "<u style=\"cursor: hand\">Choose from list</u>"
    }
}


function SetNormal() {
    $('#isGenNormal').prop('checked', true);
    SetGen($('#isGenNormal'));
    $('#isBackPalpationNormal').prop('checked', true);
    SetBackPalpation($('#isBackPalpationNormal'));
    $('#isBackRangeNormal').prop('checked', true);
    SetBackRange($('#isBackRangeNormal'));
    $('#isBackLegNormal').prop('checked', true);
    SetBackLeg($('#isBackLegNormal'));
    $('#isBackLimbNormal').prop('checked', true);
    SetBackLimb($('#isBackLimbNormal'));
    alert("Please fill in Inspection");
    window.location = "#Inspection";
}



function SetHistory() {
    $('#isSymNil').prop('checked', true);
    SetSymptom($('#isSymNil'));
    $('#isPastGood').prop('checked', true);
    SetPast($('#isPastGood'));
    $('#isMedicationNil').prop('checked', true);
    SetMedication($('#isMedicationNil'));
    $('#isPreOpNil').prop('checked', true);
    SetPreOp($('#isPreOpNil'));
    $('#isAllergyNil').prop('checked', true);
    SetAllergy($('#isAllergyNil'));    
 
}

function SetBackInspectAsy(cb) {
    if (cb.checked == true) {
        $('#isBackInspectAsyL').prop('checked', false);
        $('#isBackInspectAsyR').prop('checked', false);
        cb.checked = true;
    }
}
function SetBackInspectRib(cb) {
    if (cb.checked == true) {
        $('#isBackInspectRibL').prop('checked', false);
        $('#isBackInspectRibR').prop('checked', false);
        cb.checked = true;
    }
}
function SetBackInspectLumbar(cb) {
    if (cb.checked == true) {
        $('#isBackInspectLumbarL').prop('checked', false);
        $('#isBackInspectLumbarR').prop('checked', false);
        cb.checked = true;
    }
}
function SetBackPelvisTilt(cb) {
    if (cb.checked == true) {
        $('#isBackPelvisTiltL').prop('checked', false);
        $('#isBackPelvisTiltR').prop('checked', false);
        cb.checked = true;
    }
}