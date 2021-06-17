/* -*- JavaScript -*- */
/*
 * potential TODO
 * - clean up. This is mostly experimental code right now figuring out how
 *   JavaScript works and stuff :) Put things with their own state in objects.
 * - Endpoints should have the T, but angle-centers just a little circle.
 *   (so: points that have > 1 lines attached to a point)
 * - circle radius estimation (separate mode)
 *    o three dots circle, 4 ellipsis,  but allow multiple dots
 *      and minimize error.
 *    o axis where the center would be plus two dots.
 * - modes: draw single line, polyline, mark circle, select (for delete)
 * - select: left click selects a line (endpoints and center). Highlight;
 *   del deletes.
 * - shift + mouse movement: only allow for discrete 360/16 angles.
 * - alt + mouse movement: snap to point in the vicinity.
 * - provide a 'reference straight line' defining the 0 degree angle.
 * - 'collision detection' for labels. Labels should in general be drawn
 *   separately and optimized for non-collision with other labels, lines and
 *   arcs. Make them align with lines, unless too steep angle (+/- 60 degrees?).
 * - checkbox 'show angles', 'show labels'
 * - export as SVG that includes the original image.
 *   background, labels, support-lines (arcs and t-lines) and lines
 *   should be in separate layers to individually look at them.
 *   (exporting just an image with the lines on top crashes browsers; play
 *   with toObjectUrl for download).
 */
"use strict";

// Some constants.

// How lines usually look like (blue with yellow background should make
// it sufficiently distinct in many images).
var line_style = "#00f";
var background_line_style = 'rgba(255, 255, 0, 0.4)';
var background_line_width = 7;

// On highlight.
var highlight_line_style = "#f00";
var background_highlight_line_style = 'rgba(0, 255, 255, 0.4)';

var length_font_pixels = 12;
var angle_font_pixels = 10;
var loupe_magnification = 7;
var end_bracket_len = 5;

// These variables need to be cut down and partially be private
// to the modules.
var help_system;
var aug_view;
var backgroundImage;  // if loaded. Also used by the loupe.
var count=0;
// Init function. Call once on page-load.
function augenmass_init(ldd) {
    help_system = new HelpSystem(document.getElementById('helptext'));
    aug_view = new AugenmassView(document.getElementById('measure'));
    var show_delta_checkbox = document.getElementById('show-deltas');
    show_delta_checkbox.addEventListener("change", function(e) {
	aug_view.setShowDeltas(show_delta_checkbox.checked);
	aug_view.drawAll();
    });

    var show_angle_checkbox = document.getElementById('show-angles');
    show_angle_checkbox.addEventListener("change", function(e) {
	aug_view.setShowAngles(show_angle_checkbox.checked);
	aug_view.drawAll();
    });

    loupe_canvas = document.getElementById('loupe');
    loupe_canvas.style.left = document.body.clientWidth - loupe_canvas.width - 10;
    loupe_ctx = loupe_canvas.getContext('2d');
    // We want to see the pixels:
    loupe_ctx.imageSmoothingEnabled = false;
    loupe_ctx.mozImageSmoothingEnabled = false;
    loupe_ctx.webkitImageSmoothingEnabled = false;



    aug_view.resetWithSize(10, 10);   // Some default until we have an image.
	var offset = load_E_image(ldd);
    var chooser = document.getElementById("file-chooser");
    chooser.addEventListener("change", function(e) {
	load_background_image(chooser);
    });

    var download_link = document.getElementById('download-result');
    download_link.addEventListener('click', function() {
	download_result(download_link) },  false);
    download_link.style.opacity = 0;  // not visible at first.
    download_link.style.cursor = "default";
	if (!ldd) {}
	else {
	setTimeout(() => {  autodraw(ldd); }, 500);
	}
} 
 function btnSave() {
	aug_view.SaveResizeLine();
 }
  function btnRemoveAllLine() {
	aug_view.RemoveAllLine();
 }
function autodraw(ldd) {
	//aug_view.RemoveAllLine();
	var oline = document.getElementById("hddline");
	//var offset = getresizeoffset(ddlresize.options[ddlresize.selectedIndex].value);
	var llbzoom = document.getElementById('llbzoom');
	var ddlresize = document.getElementById('ddlresize');
	var br = document.getElementById('br');
	var ct = document.getElementById('ct');
	var offset = parseFloat(llbzoom.innerHTML.replace('%',''))/100;
	if (oline.value === "undefined") {return;}
	var line = oline.value.split("_");
	 for (var i = 0; i < line.length; i++) {	 	
		 if (line[i].length > 0)
		 {
        var point = line[i].split("|");
	 	//for (var j = 0; j < point.length; j=j+3) {
			var j = 0;
			if (ldd && ldd.length > 1) {
			var oldoffset = parseFloat(point[j+5]/100);
			aug_view.startSavedline(parseFloat(point[j+1]),parseFloat(point[j+2]));
			aug_view.DrawAngle(point[j+1],point[j+2]);
			aug_view.updateSavedline(parseFloat(point[j+3]),parseFloat(point[j+4]));
			aug_view.setLabel(point[j]);
			br.value =point[j+6];
			ct.value =point[j+7];
			editImage();
			} else  {
			var hddoffset = parseFloat(document.getElementById('hddoffset').value);//alert(oline.value);
			var oldoffset = parseFloat(point[j+5]/100);//alert(oldoffset);
			var rate= offset/oldoffset;//alert(point[j+1]);//alert(offset);alert(hddoffset);
			aug_view.startSavedline(parseFloat(point[j+1]*rate),parseFloat(point[j+2]*rate));
			aug_view.DrawAngle(point[j+1],point[j+2]);
			aug_view.updateSavedline(parseFloat(point[j+3]*rate),parseFloat(point[j+4]*rate));
			aug_view.setLabel(point[j]);
			br.value =point[j+6];
			ct.value =point[j+7];
			editImage();
			}
			aug_view.DrawAngle(point[j+3],point[j+4]);
			aug_view.confirmSavedline();//console.log(line.p2.x+" "+line.p2.y+" "+ line.p1.y+" "+line.p1.x);
			aug_view.drawAll();
	 	//}
		 }
     }
	// aug_view.GetLength();
	//aug_view.startSavedline(1,2);
	//aug_view.updateSavedline(300,400);
	//aug_view.confirmSavedline();
}
function getresizeoffset(off) {
	var offset = 1;
	var hddImgHeight = document.getElementById('hddImgHeight');
	var hddImgWidth = document.getElementById('hddImgWidth');
	var llbzoom = document.getElementById('llbzoom');
	switch (off) {
			case 'FWI':			
			//alert(($(window).height())*$(window).width()/(background_canvas.width*background_canvas.height).toPrecision(4));
				offset = ((($(window).height())-500)*$(window).width()/(hddImgWidth.value*hddImgHeight.value)).toPrecision(4);
				break;
			case 'FW':
				offset = (parseFloat((($(window).width())/(hddImgWidth.value)) - 0.1)).toPrecision(4);
				break;
			case 'FH':
				offset = (parseFloat((($(window).height())/(hddImgHeight.value)) -0.22)).toPrecision(4);
				break;
			case '25':
				offset = 0.25;
				break;
			case '50':
				offset = 0.5;
				break;
			case '100':
				offset = 1;
				break;
			case '150':
				offset = 1.5;
				break;
			case '200':
				offset = 2;
				break;
			case '400':
				offset = 4;
				break;
			case '800':
				offset = 8;
				break;						
			default:
				offset = 1;
				break;
		}
		llbzoom.innerHTML = (offset*100).toPrecision(4) + "%";
		return offset;
}
function load_E_image(ldd) {
	const urlParams = new URLSearchParams(window.location.search);
	const myParam = urlParams.get('imgsrc');
	var new_img = new Image();
	var offset = 1;
	// Image loading in the background canvas. Once we have the image, we
	// can size the canvases to a proper size.
	var background_canvas = document.getElementById('background-img');
	new_img.onload = function() {
	    var bg_context = background_canvas.getContext('2d');
		//Eddie resize
		var ddlresize = document.getElementById('ddlresize');
		var hddoffset = document.getElementById('hddoffset');
		var hddImgHeight = document.getElementById('hddImgHeight');
		var hddImgWidth = document.getElementById('hddImgWidth');
		var llbzoom = document.getElementById('llbzoom');
		if (ldd && ldd.length > 1) {
		if (!ldd) {} else {
		var line = ldd.split("_");
		for (var i = 0; i < line.length; i++) {	 	
		 if (line[i].length > 0)
		 {
			var point = line[i].split("|");
			var j = 0;
			//ddlresize.text = point[j+5];alert(ddlresize.text);	
			hddoffset.value = parseFloat(point[j+5])
			offset= point[j+5]/100;
			hddImgHeight.value = new_img.height;
			hddImgWidth.value = new_img.width;
			llbzoom.innerHTML = offset*100 + "%";
		 }
		}
		} 
		} else if (ldd == 2)  {
					offset = getresizeoffset(ddlresize.options[ddlresize.selectedIndex].value);
		}  else if (ldd == 3)  {
					offset = llbzoom.innerHTML;
					hddoffset.value = parseFloat(offset.replace('%',''))/100;
					offset = parseFloat(offset.replace('%',''))/100 - 0.1;
					llbzoom.innerHTML = (offset*100).toPrecision(4) + "%";
		}  else if (ldd == 4)  {
					offset = llbzoom.innerHTML;
					hddoffset.value = parseFloat(offset.replace('%',''))/100;
					offset = parseFloat(offset.replace('%',''))/100 + 0.1;
					llbzoom.innerHTML = (offset*100).toPrecision(4) + "%";
		} else { 
			hddImgHeight.value = new_img.height;
			hddImgWidth.value = new_img.width;
			offset = getresizeoffset(ddlresize.options[ddlresize.selectedIndex].value);
		}
			

		background_canvas.width = new_img.width*offset;
		background_canvas.height = new_img.height*offset;
		bg_context.scale(offset, offset);
	    bg_context.drawImage(new_img, 0, 0);
	    
	    aug_view.resetWithSize(new_img.width*offset, new_img.height*offset);

	    help_system.achievementUnlocked(HelpLevelEnum.DONE_FILE_LOADING);
	    backgroundImage = new_img;
	  //  init_download(chooser.files[0].name);
	  	return offset;
	}
	new_img.src = myParam;
	//console.log(e.target.result);
}

function AugenmassController(canvas, view) {
    // This doesn't have any public methods.
    this.start_line_time_ = 0;

    var self = this;
    canvas.addEventListener("mousedown", function(e) {
	extract_event_pos(e, function(e,x,y) { self.onClick(e,x,y); });
    });
    canvas.addEventListener("contextmenu", function(e) {
	e.preventDefault();
    });
    canvas.addEventListener("mousemove", function(e) {
	extract_event_pos(e, onMove);
    });
    canvas.addEventListener("dblclick", function(e) {
	extract_event_pos(e, onDoubleClick);
    });
    document.addEventListener("keydown", onKeyEvent);

    function extract_event_pos(e, callback) {
	// browser and scroll-independent extraction of mouse cursor in canvas.
	var x, y;
	if (e.pageX != undefined && e.pageY != undefined) {
	    x = e.pageX;
	    y = e.pageY;
	}
	else {
	    x = e.clientX + scrollLeft();
	    y = e.clientY + scrollY();
	}
	x -= canvas.offsetLeft;
	y -= canvas.offsetTop;
	
	callback(e, x, y);
    }

    function getModel() { return view.getModel(); }
    function getView() { return view; }

    function cancelCurrentLine() {
	if (getModel().hasEditLine()) {
	    getModel().forgetEditLine();
	    getView().drawAll();
	}
    }
    
    function onKeyEvent(e) {
	if (e.keyCode == 27) {  // ESC key.
	    cancelCurrentLine();
	}
    }

    function onMove(e, x, y) {
	if (backgroundImage === undefined)
	    return;
	var has_editline = getModel().hasEditLine();
	if (has_editline) {
	    getModel().updateEditLine(x, y);
	}
	showFadingLoupe(x, y);
	if (!has_editline)
	    return;
	getView().drawAll();
    }
    
    this.onClick = function(e, x, y) { 
	if (e.which != undefined && e.which == 3) {
	    // right mouse button.
	    cancelCurrentLine();
	    return;
	}
		if (getModel().getcount() > 3)
	{
		
		var Angle = document.getElementById('Angle');
		var X11 = document.getElementById('X11');
		var Y11 = document.getElementById('Y11');
		var X12 = document.getElementById('X12');
		var Y12 = document.getElementById('Y12');
		var X21 = document.getElementById('X21');
		var Y21 = document.getElementById('Y21');
		var X22 = document.getElementById('X22');
		var Y22 = document.getElementById('Y22');
		X11.value = "";
		Y11.value = "";
		X12.value = "";
		Y12.value = "";
		X12.value = "";
		Y12.value = "";
		X21.value = "";
		X21.value = "";
		Angle.value = "0";
		getView().drawAll();
	}
	var hddclick = document.getElementById('hddclick');

	if (hddclick.value == "Remove")
	{
		getView().drawAll();	
	var selected_line = getModel().SearchClosest(x, y);
	if (selected_line == undefined)
	    return;
	getView().highlightLine(selected_line);
	getModel().removeAngle(selected_line.p1, selected_line);
	getModel().removeLine(selected_line);
	getView().drawAll();
	var LineArray = getView().SaveResizeLine();
	} else if (hddclick.value == "Measure")
	{// console.log(getModel().getcount());if (getModel().getcount() == 3) {getView().drawAll();}
	var selected_line = getModel().SearchClosest(x, y);
	if (selected_line == undefined)
	    return;
	count++;//if (count % 2 == 1) {return;}
	getModel().updatecount();//console.log(selected_line);
	getView().DrawAngle(selected_line.p1.x, selected_line.p1.y);
	getModel().updatecount();
	getView().DrawAngle(selected_line.p2.x, selected_line.p2.y);
	getView().highlightLine(selected_line);
	//if (getModel().getcount() > 3) {getView().drawAll();}
	//getView().drawAll();
	//	getView().highlightLine(selected_line);
	} else if (hddclick.value == "Move")
	{
			getView().drawAll();
	if (getModel().hasEditLine()) {
		var line = getModel().updateEditLine(x, y);
	    // Make sure that this was not a double-click event.
	    // (are there better ways ?)
	    if (line.length() > 5 || (line.length() > 0 )) {
		getModel().commitEditLine();
		help_system.achievementUnlocked(HelpLevelEnum.DONE_FINISH_LINE);
	    } else {
		getModel().forgetEditLine();
	    }
			var LineArray = getView().SaveResizeLine();
	} else {	 	getView().drawAll();
	var selected_line = getModel().SearchClosest(x, y);
	if (selected_line == undefined)
	    return;
	var p1x = selected_line.p1.x;
	var p1y = selected_line.p1.y;
	var p2x = selected_line.p2.x;
	var p2y = selected_line.p2.y;
	var dis1 = getModel().getdistance(p1x,p1y,x,y);
	var dis2 = getModel().getdistance(p2x,p2y,x,y);
	
	getView().highlightLine(selected_line);
	getModel().removeAngle(selected_line.p1, selected_line);
	getModel().removeLine(selected_line);
	getView().drawAll();
		if (dis1 >= dis2) {
		getView().startSavedline(p1x,p1y);
	} else {
			getModel().startEditLine(p2x, p2y);
	}
	var LineArray = getView().SaveResizeLine();
	}
	}
	else {
	var now = new Date().getTime();
	if (!getModel().hasEditLine()) {
	    getModel().startEditLine(x, y);
	    this.start_line_time_ = now;
	    help_system.achievementUnlocked(HelpLevelEnum.DONE_START_LINE);
	} else {
	    var line = getModel().updateEditLine(x, y);
	    // Make sure that this was not a double-click event.
	    // (are there better ways ?)
	    if (line.length() > 50
		|| (line.length() > 0 && (now - this.start_line_time_) > 500)) {
		getModel().commitEditLine();
		help_system.achievementUnlocked(HelpLevelEnum.DONE_FINISH_LINE);
	    } else {
		getModel().forgetEditLine();
	    }
	}
	//getModel().updatecount();
	getView().DrawAngle(x, y);
	getView().drawAll();
	var LineArray = getView().SaveResizeLine();
	}
    }

    function onDoubleClick(e, x, y) {
	cancelCurrentLine();
	var selected_line = getModel().findClosest(x, y);
	if (selected_line == undefined)
	    return;
	getView().highlightLine(selected_line);
	var orig_len_txt = (getView().getUnitsPerPixel()
			    * selected_line.length()).toPrecision(4);
	var new_value_txt = prompt("Length of selected line ?", orig_len_txt);
	if (orig_len_txt != new_value_txt) {
	    var new_value = parseFloat(new_value_txt);
	    if (new_value && new_value > 0) {
		getView().setUnitsPerPixel(new_value / selected_line.length());
	    }
	}
	help_system.achievementUnlocked(HelpLevelEnum.DONE_SET_LEN);
	getView().drawAll();
    }
}

function scrollTop() {
    return document.body.scrollTop + document.documentElement.scrollTop;
}

function scrollLeft() {
    return document.body.scrollLeft + document.documentElement.scrollLeft;
}

function init_download(filename) {
    var pos = filename.lastIndexOf(".");
    if (pos > 0) {
	filename = filename.substr(0, pos);
    }
    var download_link = document.getElementById('download-result');
    download_link.download = "augenmass-" + filename + ".png";
    download_link.style.cursor = "pointer";
    download_link.style.opacity = 1;
}

function download_result(download_link) {
    if (backgroundImage === undefined)
	return;
    aug_view.drawAll();
    download_link.href = aug_view.getCanvas().toDataURL('image/png');
}

function load_background_image(chooser) {

    if (chooser.value == "" || !chooser.files[0].type.match(/image.*/))
	return;

    var img_reader = new FileReader();
    img_reader.readAsDataURL(chooser.files[0]);
    img_reader.onload = function(e) {
	var new_img = new Image();
	// Image loading in the background canvas. Once we have the image, we
	// can size the canvases to a proper size.
	var background_canvas = document.getElementById('background-img');
	new_img.onload = function() {
	    var bg_context = background_canvas.getContext('2d');
	    background_canvas.width = new_img.width;
	    background_canvas.height = new_img.height;
	    bg_context.drawImage(new_img, 0, 0);
	    
	    aug_view.resetWithSize(new_img.width, new_img.height);

	    help_system.achievementUnlocked(HelpLevelEnum.DONE_FILE_LOADING);
	    backgroundImage = new_img;
	    init_download(chooser.files[0].name);
	}
	new_img.src = e.target.result;
    }
}
