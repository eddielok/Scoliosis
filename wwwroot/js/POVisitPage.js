

$(document).ready(function () {

    new Cleave('.class-PoDOC', {
        date: true,
        delimiter: '/',
        datePattern: ['d', 'm', 'Y']
    });

    new Cleave('.class-DobrDOC', {
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

function bracetoday() {
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

    $("#BraceDate").val(todayVal);
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


function PrepareSave() {
   //user
   	$('#User').val($('#newUser').val());
    if($('#User1').prop('checked') && $('#User').val() =='Mr Kee') {$('#User').val('Mr Kee');}	
	if($('#User2').prop('checked') && $('#User').val() =='Ruby') {$('#User').val('Ruby');}	
	if($('#User3').prop('checked') && $('#User').val() =='Kim') {$('#User').val('Kim');}
	//if($('#User4').prop('checked')) {$('#User').val($('#newUser').val())}
	
	//BraceType
	if($('#BraceType1').prop('checked')) {$('#BraceType').val('1');}	
	if($('#BraceType2').prop('checked')) {$('#BraceType').val('2');}	
	if($('#BraceType3').prop('checked')) {$('#BraceType').val('3');}	
	if($('#BraceType4').prop('checked')) {$('#BraceType').val('4');$('#SpcType').val($('#newBraceType').val());}
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
	if($('#BraceRenewal2').prop('checked')) {$('#BraceRenewal').val('2');}	
	if($('#BraceRenewal3').prop('checked')) {$('#BraceRenewal').val('3');}	
	if($('#BraceRenewal4').prop('checked')) {$('#BraceRenewal').val('4');$('#SpcRenewal').val($('#newBraceRenewal').val());}
	
	//BraceAdjustment
	if($('#BraceAdjustment1').prop('checked')) {$('#BraceAdjustment').val('1');}	
	if($('#BraceAdjustment2').prop('checked')) {$('#BraceAdjustment').val('2');}	
	if($('#BraceAdjustment3').prop('checked')) {$('#BraceAdjustment').val('3');}	
	if($('#BraceAdjustment4').prop('checked')) {$('#BraceAdjustment').val('4');}	
	if($('#BraceAdjustment5').prop('checked')) {$('#BraceAdjustment').val('5');}	
	if($('#BraceAdjustment6').prop('checked')) {$('#BraceAdjustment').val('6');}	
	if($('#BraceAdjustment7').prop('checked')) {$('#BraceAdjustment').val('7');}	
	if($('#BraceAdjustment8').prop('checked')) {$('#BraceAdjustment').val('8');$('#SpcAdjustment').val($('#newBraceAdjustment').val());}

	//ImgData
	$('#ImgData').val(JSON.stringify(coords));
}

function SetUser(cb) {
    if (cb.checked == true) { 
		//$('#User4').prop('checked', false);
        $('#User1').prop('checked', false);
        $('#User2').prop('checked', false);
        $('#User3').prop('checked', false);
        cb.checked = true;
		/*
		if($('#User4').prop('checked'))
		{
			$('#newUser').prop('disabled', false);
		} else {
			$('#newUser').prop('disabled', true);
			$('#newUser').val('');
		};
		*/
		console.log($('#User1'));
		if($('#User1').prop('checked')) $('#newUser').val('Mr Kee')
			else if($('#User2').prop('checked')) $('#newUser').val('Ruby')
				else if($('#User3').prop('checked')) $('#newUser').val('Kim')
					else $('#newUser').val('');
    }
}

function SetBraceType(cb) {
    if (cb.checked == true) {

        //$('#BraceType1').prop('checked', false);
        //$('#BraceType2').prop('checked', false);
        //$('#BraceType3').prop('checked', false);
        //$('#BraceType4').prop('checked', false);
		$('#NoBraceType').prop('checked', false);
        cb.checked = true;
		if($('#BraceType4').prop('checked'))
		{
			$('#newBraceType').prop('disabled', false);
		} else {
			$('#newBraceType').prop('disabled', true);
			$('#newBraceType').val('');
		};
		if($('#NoBraceType').prop('checked'))
		{
			$('#BraceType1').prop('checked', false);
			$('#BraceType2').prop('checked', false);
			$('#BraceType3').prop('checked', false);
			$('#BraceType4').prop('checked', false);
			$('#newBraceType').prop('disabled', true);
			$('#newBraceType').val('');
		};
    }
}
function SetCompliance(cb) {
    if (cb.checked == true) {

        $('#SetCompliance1').prop('checked', false);
        $('#SetCompliance2').prop('checked', false);
        $('#SetCompliance3').prop('checked', false);
        $('#SetCompliance4').prop('checked', false);
		$('#SetCompliance5').prop('checked', false);
        cb.checked = true;
    }
}

function SetBraceProblem(cb) {
    if (cb.checked == true) {

       // $('#BraceProblem1').prop('checked', false);
       // $('#BraceProblem2').prop('checked', false);
       // $('#BraceProblem3').prop('checked', false);
       // $('#BraceProblem4').prop('checked', false);
	//	$('#BraceProblem5').prop('checked', false);
	//	$('#BraceProblem6').prop('checked', false);
        cb.checked = true;
		if($('#BraceProblem11').prop('checked'))
		{
			$('#newBraceProblem1').prop('disabled', false);
			$('#newBraceProblem2').prop('disabled', true);
			$('#newBraceProblem3').prop('disabled', true);
			$('#newBraceProblem2').val('');
			$('#newBraceProblem3').val('');
		} else if($('#BraceProblem12').prop('checked')) {
			$('#newBraceProblem1').prop('disabled', true);
			$('#newBraceProblem2').prop('disabled', false);
			$('#newBraceProblem3').prop('disabled', true);
			$('#newBraceProblem1').val('');
			$('#newBraceProblem3').val('');
		} else if($('#BraceProblem13').prop('checked')) {
			$('#newBraceProblem1').prop('disabled', true);
			$('#newBraceProblem2').prop('disabled', true);
			$('#newBraceProblem3').prop('disabled', false);
			$('#newBraceProblem1').val('');
			$('#newBraceProblem2').val('');
		}
    }
}

function SetBraceRenewal(cb) {
    if (cb.checked == true) {

        //$('#BraceRenewal1').prop('checked', false);
        //$('#BraceRenewal2').prop('checked', false);
        //$('#BraceRenewal3').prop('checked', false);
        //$('#BraceRenewal4').prop('checked', false);
        cb.checked = true;
		if($('#BraceRenewal4').prop('checked'))
		{
			$('#newBraceRenewal').prop('disabled', false);
		} else {
			$('#newBraceRenewal').prop('disabled', true);
			$('#newBraceRenewal').val('');
		};
    }
}

function Setchkplanit(cb) {
    if (cb.checked == true) {

        $('#chkplanit1').prop('checked', false);
        $('#chkplanit2').prop('checked', false);
        cb.checked = true;
		if($('#chkplanit1').prop('checked')) 
		{
            $('#chkcolor').val('#00008b');
		} else {
            $('#chkcolor').val('#8b0000');
		}
    }
}

function SetBraceAdjustment(cb) {
    if (cb.checked == true) {
		
        //$('#BraceAdjustment1').prop('checked', false);
        //$('#BraceAdjustment2').prop('checked', false);
        //$('#BraceAdjustment3').prop('checked', false);
        //$('#BraceAdjustment4').prop('checked', false);
		//$('#BraceAdjustment5').prop('checked', false);
        //$('#BraceAdjustment6').prop('checked', false);
        //$('#BraceAdjustment7').prop('checked', false);
        //$('#BraceAdjustment8').prop('checked', false);
		$('#NoBraceAdjustment').prop('checked', false);
        cb.checked = true;
		if($('#BraceAdjustment8').prop('checked'))
		{
			$('#newBraceAdjustment').prop('disabled', false);
		} else {
			$('#newBraceAdjustment').prop('disabled', true);
			$('#newBraceAdjustment').val('');
		};
		if($('#NoBraceAdjustment').prop('checked'))
		{   
			$('#BraceAdjustment1').prop('checked', false);
			$('#BraceAdjustment2').prop('checked', false);
			$('#BraceAdjustment3').prop('checked', false);
			$('#BraceAdjustment4').prop('checked', false);
			$('#BraceAdjustment5').prop('checked', false);
			$('#BraceAdjustment6').prop('checked', false);
			$('#BraceAdjustment7').prop('checked', false);
			$('#BraceAdjustment8').prop('checked', false);
			$('#newBraceAdjustment').prop('disabled', true);
			$('#newBraceAdjustment').val('');
			$('#BraceRenewal1').prop('checked', false);
			$('#BraceRenewal2').prop('checked', false);
			$('#BraceRenewal3').prop('checked', false);
			$('#BraceRenewal4').prop('checked', false);
			$('#newBraceRenewal').prop('disabled', true);
			$('#newBraceRenewal').val('');
		};
    }
}


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
function AddRemarks(concern) {
    $('#Remarks').val($('#Remarks').val() + concern);
    changed();
}