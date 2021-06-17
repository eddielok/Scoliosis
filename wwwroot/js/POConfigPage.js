

$(document).ready(function () {


    
    

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




function PrepareSave() {
   //user
    if($('#User1').prop('checked')) {$('#User').val('Mr Kee');}	
	if($('#User2').prop('checked')) {$('#User').val('Ruby');}	
	if($('#User3').prop('checked')) {$('#User').val('Kim');}	
	if($('#User4').prop('checked')) {$('#User').val($('#newUser').val())}
	
	//BraceType
	if($('#BraceType1').prop('checked')) {$('#BraceType').val('1');}	
	if($('#BraceType2').prop('checked')) {$('#BraceType').val('2');}	
	if($('#BraceType3').prop('checked')) {$('#BraceType').val('3');}	
	if($('#BraceType4').prop('checked')) {$('#BraceType').val('4');}
	if($('#BraceType5').prop('checked')) {$('#BraceType').val('5');$('#SpcType').val($('#newBraceType').val());}
	if($('#NoBraceType').prop('checked')) {$('#BraceType').val($('#newBraceType').val())}
	
	//BraceCompliance
	if($('#BraceCompliance1').prop('checked')) {$('#BraceCompliance').val('1');}	
	if($('#BraceCompliance2').prop('checked')) {$('#BraceCompliance').val('2');}	
	if($('#BraceCompliance3').prop('checked')) {$('#BraceCompliance').val('3');}	
	if($('#BraceCompliance4').prop('checked')) {$('#BraceCompliance').val('4');}
	if($('#BraceCompliance5').prop('checked')) {$('#BraceCompliance').val('5');}
	
	//BraceProblem
	if($('#BraceProblem1').prop('checked')) {$('#BraceProblem').val('1');$('#SpcType').val($('#newBraceProblem1').val());}	
	if($('#BraceProblem2').prop('checked')) {$('#BraceProblem').val('2');$('#SpcType').val($('#newBraceProblem2').val());}	
	if($('#BraceProblem3').prop('checked')) {$('#BraceProblem').val('3');}	
	if($('#BraceProblem4').prop('checked')) {$('#BraceProblem').val('4');}
	if($('#BraceProblem5').prop('checked')) {$('#BraceProblem').val('5');}
	if($('#BraceProblem6').prop('checked')) {$('#BraceProblem').val('6');$('#SpcType').val($('#newBraceRenewal').val());}

	//BraceCompliance
	if($('#BraceRenewal1').prop('checked')) {$('#BraceRenewal').val('1');}	
	if($('#BraceRenewal2').prop('checked')) {$('#BraceRenewal2').val('2');}	
	if($('#BraceRenewal3').prop('checked')) {$('#BraceRenewal3').val('3');}	
	if($('#BraceRenewal4').prop('checked')) {$('#BraceRenewal4').val('4');$('#SpcRenewal').val($('#newBraceRenewal').val());}
	
	//BraceAdjustment
	if($('#BraceAdjustment1').prop('checked')) {$('#BraceAdjustment').val('1');}	
	if($('#BraceAdjustment2').prop('checked')) {$('#BraceAdjustment').val('2');}	
	if($('#BraceAdjustment3').prop('checked')) {$('#BraceAdjustment').val('3');}	
	if($('#BraceAdjustment4').prop('checked')) {$('#BraceAdjustment').val('4');}	
	if($('#BraceAdjustment5').prop('checked')) {$('#BraceAdjustment').val('5');}	
	if($('#BraceAdjustment6').prop('checked')) {$('#BraceAdjustment').val('6');}	
	if($('#BraceAdjustment7').prop('checked')) {$('#BraceAdjustment').val('7');}	
	if($('#BraceAdjustment8').prop('checked')) {$('#BraceAdjustment').val('8');$('#SpcAdjustment').val($('#newBraceAdjustment').val());}

}
