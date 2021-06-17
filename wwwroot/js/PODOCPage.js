
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

    $("#DOCDate").val(todayVal);
}

