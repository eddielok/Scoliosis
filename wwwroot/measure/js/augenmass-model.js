// Conctructor function.
function AugenmassModel() {
    "use strict";
    this.lines_ = new Array();
    this.point_angle_map_ = {};  // points to lines originating from it.
    this.current_line_ = undefined;
    this.current_angle_ = undefined;
	this.Labels = new Array();
	this.getline = function() {
	return this.current_line_;
    }
	this.count = 0;
	this.updatecount = function() {
	this.count++;
	if (this.count > 4) {this.count = 1;}
	return this.count;
    }
	this.getcount = function() {
	return this.count;
    }
	this.ResetLine = function() {
	this.lines_ = [];
	this.count = 0;
	}
	this.GetLength = function() {
	return this.lines_.length;
	}
    this.setAllLabels = function(i, val) {
	this.Labels[i] = val;
	}

	this.getAllLabels = function(i) {
	return this.Labels[i];
	}
	this.setLine = function(label, x, y) {
	return this.Labels[i];
	}
	this.getdistance = function(x1, y1, x2, y2) {
    return Math.sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
	}
    // -- editing operation. We start a line and eventually commit or forget it.

    // Start a new line but does not add it to the model yet.
    this.startEditLine = function(x, y) {
	var line = new Line(x, y, x, y);
	this.current_line_ = line;
	this.current_angle_ = this.addAngle(line.p1, line.p2, line);
    }
    this.hasEditLine = function() { return this.current_line_ != undefined; }
    this.getEditLine = function() { return this.current_line_; }
    this.updateEditLine = function(x, y) {
	if (this.current_line_ == undefined) return;
	this.current_line_.updatePos(x, y);
	this.current_angle_.notifyPointsChanged();
	return this.current_line_;
    }

    this.commitEditLine = function() {
	var line = this.current_line_;
	this.lines_[this.lines_.length] = line;
	this.addAngle(line.p2, line.p1, line);
	this.current_line_ = undefined;
    }
    this.forgetEditLine = function() {
	if (this.current_line_ == undefined)
	    return;
	this.removeAngle(this.current_line_.p1, this.current_line_);
	this.current_line_ = undefined;
    }

    this.addAngle = function(center, p2, line) {
	var key = center.get_key();
	var angle_list = this.point_angle_map_[key];
	if (angle_list === undefined) {
	    angle_list = new Array();
	    this.point_angle_map_[key] = angle_list;
	}
	var angle = new Angle(center, p2, line);
	angle_list[angle_list.length] = angle;
	return angle;
    }

    this.removeAngle = function(center_point, line) {
	var key = center_point.get_key();
	var angle_list = this.point_angle_map_[key];
	if (angle_list === undefined) return; // shrug.
	var pos = -1;
	for (var i = 0; i < angle_list.length; ++i) {
	    if (angle_list[i].line == line) {
		pos = i;
		break;
	    }
	}
	if (pos >= 0) {
	    angle_list.splice(pos, 1);
	}
    }

    // Remove a line
    this.removeLine = function(line) {
	var pos = this.lines_.indexOf(line);
	if (pos < 0) alert("Should not happen: Removed non-existent line");
	this.lines_.splice(pos, 1);
    }
	function sqr(x) { return x * x }
	function dist2(v, w) { return sqr(v.x - w.x) + sqr(v.y - w.y) }
	function distToSegmentSquared(p, v, w) {
		  var l2 = dist2(v, w);
		  if (l2 == 0) return dist2(p, v);
		  var t = ((p.x - v.x) * (w.x - v.x) + (p.y - v.y) * (w.y - v.y)) / l2;
		  t = Math.max(0, Math.min(1, t));
		  return dist2(p, { x: v.x + t * (w.x - v.x),
							y: v.y + t * (w.y - v.y) });
		}
function distToSegment(p, v, w) { return Math.sqrt(distToSegmentSquared(p, v, w)); }
	this.SearchClosest = function(x,y) {
		var pt = new Point(x, y);
		var smallest_distance = undefined;
		var selected_line = undefined;
		for (var i = 0; i < this.lines_.length; ++i) {
			var line = this.lines_[i];//console.log(i);console.log(line);
			var this_distance = distToSegment(pt, line.p1, line.p2);//console.log(this_distance);
			if (smallest_distance == undefined || this_distance < smallest_distance) {
				smallest_distance = this_distance;
				selected_line = line;
				}
		}
		if (selected_line && smallest_distance < 10) {
	    return selected_line;
	}
	return undefined;
	}
    // Find the closest line to the given coordinate or 'undefined', if they
    // are all too remote.
    this.findClosest = function(x, y) {
	var smallest_distance = undefined;
	var selected_line = undefined;
	for (var i = 0; i < this.lines_.length; ++i) {
		var line = this.lines_[i];
	    var this_distance = line.distanceToCenter(x, y);//alert(line.p1.x +' ' +line.p1.y + ' ' +line.p2.x + ' ' + line.p2.y + ' ' + this_distance);
	    if (smallest_distance == undefined
		|| this_distance < smallest_distance) {
		smallest_distance = this_distance;
		selected_line = line;
	}
	} //alert(smallest_distance);
	if (selected_line && smallest_distance < 200) {
	    return selected_line;
	}
	return undefined;
    }

    // Iterate over all lines; Callback needs to accept a line.
    this.forAllLines = function(cb) {
	for (var i = 0; i < this.lines_.length; ++i) {
	    cb(this.lines_[i]);
	}
    }
	

    this.forAllArcs = function(cb) {
	for (var key in this.point_angle_map_) {
	    if (!this.point_angle_map_.hasOwnProperty(key))
		continue;
	    var angle_list = this.point_angle_map_[key];
	    if (angle_list.length < 2)
		continue;
	    angle_list.sort(function(a, b) {
		return a.angle - b.angle;
	    });
	    for (var i = 0; i < angle_list.length; ++i) {
		var a = angle_list[i], b = angle_list[(i+1) % angle_list.length];
		if (!a.is_valid || !b.is_valid)
		    continue;
		var arc = new Arc(a, b);
		if (arc.angleInDegrees() >= 180.0)
		    continue;
		cb(arc)
	    }
	}
    }
}
