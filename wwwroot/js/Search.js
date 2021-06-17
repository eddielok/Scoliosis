


$(document).ready(function () {

   new Cleave('.class-scn', {
        uppercase: true,
        delimiter: '-',
        blocks: [2, 6]
    });

    new Cleave('.class-hkid', {
        uppercase: true,
        delimiters: ['(',')'],
        blocks: [7,1,0]
    });

    

    $("#form").validate({
        rules: {
            "HKID": {
                required: true,
                maxlength: 15,
                regex: "^[A-Z]{1,2}[0-9]{6}[(][0-9A-F][)]{1}"
            }
        },
        messages: {
            "HKID": {
                required: "Please enter HKID",
                regex: "The HKID should be XXXXXXX(X) / XXXXXXXX(X) "
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


function validation() {

    if (!checkValidFromToDate($("#dateFrom").val(), $("#dateTo").val())) {
        alert("Last Modify Date Start is greater than Last Modify Date End");
    }
}


function checkValidFromToDate(fromDateStr, toDateStr) {

    var fromDate = strToDate(fromDateStr);
    var toDate = strToDate(toDateStr);

    if (fromDate > toDate)
        return false;

    return true;
}

function strToDate(dateString) {
    var dateParts = dateString.split("/");

    // month is 0-based, that's why we need dataParts[1] - 1
    var dateObject = new Date(+dateParts[2], dateParts[1] - 1, +dateParts[0]); 

    return dateObject;

}


function ClearSearchPara() {

    $('#Name').val('');
    $('#SCN').val('');
    $('#HKID').val('');
    $('#Remarks').val('');
    
}