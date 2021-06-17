var x=30, y=40;

function CaptureMousePosition() {
	x = window.event.x + document.body.scrollLeft;
	y = window.event.y + document.body.scrollTop+20;
}

function MakeToolTip(id,code) {
	var str="<STYLE TYPE='text/css'> #"+id+" { width: 300px; visibility:hidden; position: absolute}</STYLE>";
	str+="<DIV CLASS='tooltip' ID='"+id+"' style='z-index: 5;'><table border=0 cellspacing=2 cellpadding=4 bgcolor=#777733><tr><td bgcolor=#EEEEDD>"
	str+=code;
	str+="</td></tr></table></DIV>";
  document.write(str);
}

function ShowToolTip(id) {
  window.document.all[id].style.visibility="visible";
	window.document.all[id].style.width=180;
	window.document.all[id].style.left=x-160;
  window.document.all[id].style.top=y;
}

function HideToolTip(id) {
  window.document.all[id].style.visibility="hidden";
}
