
// editing image via css properties
function editImage() {

	var br 		 = $("#br").val();      // brightness
	var ct 		 = $("#ct").val();      // contrast

	var filter = 	' brightness(' + br +
			'%) contrast(' + ct + '%)';

	$("#imageContainer canvas").css("filter", filter);
	$("#imageContainer canvas").css("-webkit-filter", filter); 

}

//When sliders change image will be updated via editImage() function
//$("input[type=range]").change(editImage).mousemove(editImage);

$(document).on('input change', '#br', function() {
    editImage();
});

$(document).on('input change', '#ct', function() {
    editImage();
});