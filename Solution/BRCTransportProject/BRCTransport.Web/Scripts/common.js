$(document).ready(function(){
	$('.toggle-link').each(function() {
		$(this).click(function() {
			var state = 'open'; //assume target is closed & needs opening
			var target = $(this).attr('data-target');
			var targetState = $(this).attr('data-target-state');
			//allows trigger link to say target is open & should be closed
			if (typeof targetState !== 'undefined' && targetState !== false) {
				state = targetState;
				$('#topPullover span').removeClass('icon-arrow-down').addClass('icon-arrow-up');
			}
			if (state == 'undefined') {
				state = 'open';
				$('#topPullover span').removeClass('icon-arrow-up').addClass('icon-arrow-down');
			}
			$(target).toggleClass('toggle-link-'+ state);
			$(this).toggleClass(state);
		});
	});
	$(".BlogList span.icon").click(function () {
	    if ($(this).hasClass("expand")) {
	        $(this).removeClass("expand icon-plus").addClass("icon-minus").parents("div").children(".blogDesc").show("slow");
	    }
	    else {
	        $(this).addClass("expand icon-plus").removeClass("icon-minus").parents("div").children(".blogDesc").hide("slow");
	    }

	});
	$("#blogArhieve ul li a").click(function(){
		if ($(this).parent().has( "ul" ).length) {
			if ($(this).hasClass("open")) {
				$(this).removeClass("open").children("span.icon").addClass("icon-arrow-right2").removeClass("icon-arrow-down2").parent().parent().children("ul").hide("slow");
			}
			else {
				$(this).addClass("open").children("span.icon").removeClass("icon-arrow-right2").addClass("icon-arrow-down2").parent().parent().children("ul").show("slow");
			}
		}
	});		
	resetHeight();
	$(window).resize(resetHeight);

	$(window).scroll(function(){
	  
	 
	      if ($(window).scrollTop()>300) {
		$(".scrollup").fadeIn('slow');
	      } else {
		$(".scrollup").fadeOut('slow');
	      }
	    
	    
	  });
	  
	  $(".scrollup").click(function(){
	  
	    $('html,body').animate({scrollTop:0},600);
	    return false;
	  
	  });

	  $("#countryList ul.dropdown-menu li a").click(function (event) {
	      event.preventDefault();
	      var flagId = $(this).find("span.flag-icon").attr("flagid");
	      $("span.countryBtn").html("<span class='flag-icon flag-icon-" + flagId + "'></span> <span class='caret'></span>");	      
	  })

	  $("#menuShow").click(function (event) {
	      $(this).next(".leftAside").toggle();
	  });

    //This function will override default behaviour of bootstrap (calling submit button on enter key press on any text box control)
	  onEnterStopClickButton();
});

function saveContinueFunt() {
	var currentItem = 0;
	var totallength = $('ul.leftAside li').length;
	var listItem, nextItem = '';
    var id = $('ul.leftAside li.active');
	currentItem = $('#mainnav li').index(id);
	currentItem = parseInt(currentItem)+1;
	listItem = $("#mainnav li:eq("+(currentItem)+")");
	nextItem = $(listItem).children("a.leftPanel").attr("href");
	if(currentItem <= totallength && typeof nextItem != 'undefined') {
		window.location.href = nextItem;
	}
}

function saveFunt(event) {

	alert("Save");
	return false;

}
function cancelFunt(event){
	var confirmValue=confirm("are you sure you want to cancel this step?");
	if (confirmValue===true) {
		window.location.href = 'eventList.html';
	}
	else {
		///return false;
	}	
}

function resetHeight() {
    var height = $(document).height();
    var width = $(document).width();
    var fheight = $("#footer").height();
    if (width > "991") {
        $("#menuShow").next(".leftAside").show();
    }
    else { $("#menuShow").next(".leftAside").hide(); }
//	$(".mainContent").height((height-fheight)-112);
}

function checkHeight() {
	//var divHeight = $(this).height();
	//var contentHeight = $(this).find("#postbodycontent").height();
	//if ( contentHeight > divHeight ) ? $(this).next("#readmorebtn").removeClass("hide");
	var divHeight = $("#postcontentArea").height();
	var contentHeight = $("#postbodycontent").height();
	( contentHeight > divHeight ) ? $("#readmorebtn").removeClass("hide") : "";	
}

function addmorebtn() {
		// Add More text button
	var MaxInputs       = 10;
	var SocialWrapper   = $("#SocialWrapper");
	var AddButton       = $("#AddMoreSocialBox"); //Add button ID
	
	var x = SocialWrapper.length; //initlal text box count
	var FieldCount=1; //to keep track of text box added
	
	$(AddButton).click(function (e)  //on add input button click
	{
		if(x <= MaxInputs) //max input box allowed
		{
		    FieldCount++; //text box added increment
		    //add input box
		    //$(SocialWrapper).append('<div><input type="text" id="" value=""/><a href="#" class="removeclass">&times;</a></div>');
		    $(SocialWrapper).append('<div class="form-group"><label for="social[]" class="col-sm-2 control-label">Facebook</label><div class="col-sm-5"><input type="text" class="form-control" name="social[]" id="field_'+ FieldCount +'" placeholder="Enter designation of person" value="Text '+ FieldCount +'"></div></div>');
		    x++; //text box increment
		}
	return false;
	});
	
	$("body").on("click",".removeclass", function(e){ //user click on remove text
		if( x > 1 ) {
			$(this).parent('div').remove(); //remove text box
			x--; //decrement textbox
		}
	return false;
	}) 

}

