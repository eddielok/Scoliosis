

$(document).ready(function () {


    new Cleave('.class-scn', {
        uppercase: true,
        delimiter: '-',
        blocks: [2, 6]
    });

    new Cleave('.class-DOB', {
        date: true,
        delimiter: '/',
        datePattern: ['d', 'm', 'Y']
    });

    new Cleave('.class-BraceStart', {
        date: true,
        delimiter: '/',
        datePattern: ['d', 'm', 'Y']
    });

    new Cleave('.class-BraceWean', {
        date: true,
        delimiter: '/',
        datePattern: ['d', 'm', 'Y']
    });

    new Cleave('.class-BraceStop', {
        date: true,
        delimiter: '/',
        datePattern: ['d', 'm', 'Y']
    });

    new Cleave('.class-ASF', {
        date: true,
        delimiter: '/',
        datePattern: ['d', 'm', 'Y']
    });

    new Cleave('.class-PSF', {
        date: true,
        delimiter: '/',
        datePattern: ['d', 'm', 'Y']
    });

    new Cleave('.class-ASFPSF', {
        date: true,
        delimiter: '/',
        datePattern: ['d', 'm', 'Y']
    });

    new Cleave('.class-ThoRelease', {
        date: true,
        delimiter: '/',
        datePattern: ['d', 'm', 'Y']
    });

    new Cleave('.class-LOFfrom', {
        date: true,
        delimiter: '/',
        datePattern: ['d', 'm', 'Y']
    });

    new Cleave('.class-LOFto', {
        date: true,
        delimiter: '/',
        datePattern: ['d', 'm', 'Y']
    });

    new Cleave('.class-PostOPStart', {
        date: true,
        delimiter: '/',
        datePattern: ['d', 'm', 'Y']
    });

    new Cleave('.class-PostOPWean', {
        date: true,
        delimiter: '/',
        datePattern: ['d', 'm', 'Y']
    });

    new Cleave('.class-PostOPStop', {
        date: true,
        delimiter: '/',
        datePattern: ['d', 'm', 'Y']
    });

    $("#form").validate({
        rules: {
            "SCN": {
                required: true,
                minlength: 7,
                maxlength: 9,
                regex: "^[0-9]{2}[-][0-9]{5}"
            },
            "Name": {
                required: true,
                maxlength: 1000
            },
            "HKID": {
                required: true,
                maxlength: 15,
                regex: "^[A-Z]{1,2}[0-9]{6}[(][0-9A-F][)]{1}"
            },
            "DOB": {
                required: true,
                regex: "(([1-2][0-9])|(0[1-9])|(3[0-1]))/((1[0-2])|(0[1-9]))/[0-9]{4}"
            },
            "FamHis": {
                maxlength: 1000
            },
            "AttnPhys": {
                maxlength: 1000
            },
            "HisOthers": {
                maxlength: 1000
            },
            "DiagnosisMisc": {
                maxlength: 1000
            },
            "ADCA": {
                maxlength: 1024
            },
            "Surgeons": {
                maxlength: 1000
            },
            "BraceOthers": {
                maxlength: 1024
            },
            "BraceStart": {
                regex: "(([1-2][0-9])|(0[1-9])|(3[0-1]))/((1[0-2])|(0[1-9]))/[0-9]{4}"
            },
            "BraceWean": {
                regex: "(([1-2][0-9])|(0[1-9])|(3[0-1]))/((1[0-2])|(0[1-9]))/[0-9]{4}"
            },
            "BraceStop": {
                regex: "(([1-2][0-9])|(0[1-9])|(3[0-1]))/((1[0-2])|(0[1-9]))/[0-9]{4}"
            },
            "ASF": {
                regex: "(([1-2][0-9])|(0[1-9])|(3[0-1]))/((1[0-2])|(0[1-9]))/[0-9]{4}"
            },
            "PSF": {
                regex: "(([1-2][0-9])|(0[1-9])|(3[0-1]))/((1[0-2])|(0[1-9]))/[0-9]{4}"
            },
            "ASFPSF": {
                regex: "(([1-2][0-9])|(0[1-9])|(3[0-1]))/((1[0-2])|(0[1-9]))/[0-9]{4}"
            },
            "ThoRelease": {
                regex: "(([1-2][0-9])|(0[1-9])|(3[0-1]))/((1[0-2])|(0[1-9]))/[0-9]{4}"
            },
            "LOFfrom": {
                regex: "(([1-2][0-9])|(0[1-9])|(3[0-1]))/((1[0-2])|(0[1-9]))/[0-9]{4}"
            },
            "LOFto": {
                regex: "(([1-2][0-9])|(0[1-9])|(3[0-1]))/((1[0-2])|(0[1-9]))/[0-9]{4}"
            },
            "otherImplant": {
                maxlength: 1024
            },
            "PostOPStart": {
                regex: "(([1-2][0-9])|(0[1-9])|(3[0-1]))/((1[0-2])|(0[1-9]))/[0-9]{4}"
            },
            "PostOPWean": {
                regex: "(([1-2][0-9])|(0[1-9])|(3[0-1]))/((1[0-2])|(0[1-9]))/[0-9]{4}"
            },
            "PostOPStop": {
                regex: "(([1-2][0-9])|(0[1-9])|(3[0-1]))/((1[0-2])|(0[1-9]))/[0-9]{4}"
            },
            "OtherInvest": {
                maxlength: 1024
            },
            "Comments": {
                maxlength: 1024
            }
        },
        messages: {
            "SCN": {
                required: "Please enter SCN",
                regex: "The SCN format is XX-XXXXX"
            },
            "Name": {
                required: "Please enter Name"
            },
            "HKID": {
                required: "Please enter HKID",
                regex: "The HKID should be XXXXXXX(X) / XXXXXXXX(X) "
            },
            "DOB": {
                required: "Please enter Date of birth",
                regex: "The date format is DD/MM/YYYY"
            },
            "BraceStart": {
                regex: "The date format is DD/MM/YYYY"
            },
            "BraceWean": {
                regex: "The date format is DD/MM/YYYY"
            },
            "BraceStop": {
                regex: "The date format is DD/MM/YYYY"
            },
            "ASF": {
                regex: "The date format is DD/MM/YYYY"
            },
            "PSF": {
                regex: "The date format is DD/MM/YYYY"
            },
            "ASFPSF": {
                regex: "The date format is DD/MM/YYYY"
            },
            "ThoRelease": {
                regex: "The date format is DD/MM/YYYY"
            },
            "LOFfrom": {
                regex: "The date format is DD/MM/YYYY"
            },
            "LOFto": {
                regex: "The date format is DD/MM/YYYY"
            },
            "PostOPStart": {
                regex: "The date format is DD/MM/YYYY"
            },
            "PostOPWean": {
                regex: "The date format is DD/MM/YYYY"
            },
            "PostOPStop": {
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


function SetDiagnosis(cb) {
    if (cb.checked == true) {

        $('#isIS').prop('checked', false);
        $('#isCS').prop('checked', false);
        $('#isNM').prop('checked', false);
        $('#isMisc').prop('checked', false);

        cb.checked = true;
    }
}

function SetKing(cb) {
    if (cb.checked == true) {

        $('#isKingI').prop('checked', false);
        $('#isKingII').prop('checked', false);
        $('#isKingIII').prop('checked', false);
        $('#isKingIV').prop('checked', false);
        $('#isKingV').prop('checked', false);
        $('#isIso').prop('checked', false);
        $('#isTripl').prop('checked', false);
        $('#isTL').prop('checked', false);
        $('#isL').prop('checked', false);
       
        cb.checked = true;

        if (cb.id == "isIso" || cb.id == "isTL" || cb.id == "isL")
            $('isIso').attr('checked', 'checked');
    } else if (cb.id == "isIso" ) {
        $('isTL').attr('checked', 'checked');
        $('isL').attr('checked', 'checked');
        }
}