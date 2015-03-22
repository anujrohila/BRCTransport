var isShowLoader = true;

$(document).ready(function () {
    //$('.toggle-link').each(function () {
    //    $(this).click(function () {
    //        var state = 'open'; //assume target is closed & needs opening
    //        var target = $(this).attr('data-target');
    //        var targetState = $(this).attr('data-target-state');
    //        //allows trigger link to say target is open & should be closed
    //        if (typeof targetState !== 'undefined' && targetState !== false) {
    //            state = targetState;
    //            $('#topPullover span').removeClass('icon-arrow-down').addClass('icon-arrow-up');
    //        }
    //        if (state == 'undefined') {
    //            state = 'open';
    //            $('#topPullover span').removeClass('icon-arrow-up').addClass('icon-arrow-down');
    //        }
    //        $(target).toggleClass('toggle-link-' + state);
    //        $(this).toggleClass(state);
    //    });
    //});

    //Show/Hide Masked Div (Loading) on Ajax call
    $(document).ajaxStart(function (evt, request, settings) {
        if (isShowLoader == true) {
            ShowLoading();
        }
    }).ajaxStop(function (evt, request, settings) {
        HideLoading();
        isShowLoader = true;
    }).ajaxError(function (event, jqxhr, settings, exception) {
        //var callUrl = $("#webUrl").val() + "UserAccount/Login";
        //window.location = callUrl;
    }).ajaxComplete(function () {
        //This function will override default behaviour of bootstrap (calling submit button on enter key press on any text box control)
        onEnterStopClickButton();
    });

    SetSportsxStreamActiveMenu();

    // // Set Globalize to the current culture driven by the html lang property
    var currentCulture = $("html").prop("lang");
    if (currentCulture) {
        if (typeof Globalize === typeof undefined) {
        }
        else {
            Globalize.culture(currentCulture);
        }
    }
});

function SetSportsxStreamActiveMenu() {

    var activeMenu = $("#hdnActiveMenu").val();

    var sportsxStreamApplicationMainMenu = $("#SportsxStreamApplicationMainMenu").find("li");
    $.each(sportsxStreamApplicationMainMenu, function (index, applicationMenu) {
        $(applicationMenu).removeClass("active");
    });

    $("#" + activeMenu).addClass("active");
}

function RegisterComboBoxValidation(form) {
    var comboBoxs = form.find(".t-combobox:visible");

    $.each(comboBoxs, function (index, item) {
        var comboBox = $($(item).find("input:hidden")[0]);
        if (comboBox.val() == "" || comboBox.val() == "-1") {
            var comboBoxId = comboBox.attr("id");

            $("#" + comboBoxId).bind('valueChange', function (e) {
                if (e.value > 0) {
                    var errorElement = $(form).find("[data-valmsg-for='" + comboBoxId + "']");
                    errorElement.removeClass("field-validation-error");
                    errorElement.addClass("field-validation-valid");
                    errorElement.html("");
                }
                else {
                    var errorMessage = $("#" + comboBoxId).attr("data-val-required");
                    var errorElement = $(form).find("[data-valmsg-for='" + comboBoxId + "']");
                    errorElement.removeClass("field-validation-valid");
                    errorElement.addClass("field-validation-error");
                    errorElement.html(errorMessage);
                }
            });
        }
    });
}

function validateComboBox(form) {
    var comboBoxs = form.find(".t-combobox:visible");
    var falseCounter = 0;
    $.each(comboBoxs, function (index, item) {
        var comboBox = $($(item).find("input:hidden")[0]).data("tComboBox");
        var selectedItem = GetComboboxSelectedItem(comboBox);
        if (selectedItem.Value == "" || selectedItem.Value == "-1") {
            var comboBoxId = comboBox.element.id;
            var errorMessage = $("#" + comboBoxId).attr("data-val-required");
            var errorElement = $(form).find("[data-valmsg-for='" + comboBoxId + "']");

            if (!$("#" + comboBoxId).parent().hasClass("mutiSelectCombo")) {
                if (errorElement.length > 0) {
                    errorElement.removeClass("field-validation-valid");
                    errorElement.addClass("field-validation-error");
                    errorElement.html(errorMessage);
                    falseCounter++;
                }
            }
            else {
                if (errorElement.length > 0) {
                    var comboIds = trim($("#" + comboBoxId + "Ids").val());
                    if (comboIds == "") {
                        errorElement.removeClass("field-validation-valid");
                        errorElement.addClass("field-validation-error");
                        errorElement.html(errorMessage);
                        falseCounter++;
                    }
                }
            }
        }
    });

    if (falseCounter > 0)
        return false;
    else
        return true;
}

function trim(str) {
    if (!str || typeof str != 'string')
        return '';
    return str.replace(/^[\s]+/, '').replace(/[\s]+$/, '').replace(/[\s]{2,}/, ' ');
}

/* Converts JSON Object to string */
function ConvertJsonObjectToString(o) {

    var parse = function (_o) {
        var a = [], t;
        for (var p in _o) {
            if (_o.hasOwnProperty(p)) {
                var property = "\"" + p.toString().replace("\\", "\\\\") + "\""
                t = _o[p];
                if (t == null)
                    t = "";
                if (t && typeof t == "object") {

                    a[a.length] = "{ " + arguments.callee(t).join(", ") + "}";
                }
                else {
                    if (typeof t == "string") {
                        if (t.toString().indexOf("<") < 0 || t.toString().indexOf(">") < 0) {
                            a[a.length] = [property + ": \"" + t.toString().replace("\\", "\\\\") + "\""];
                        }
                        else {
                            a[a.length] = [property + ": \"" + "" + "\""];
                        }
                    }
                    else {
                        a[a.length] = [property + ": " + t.toString().replace("\\", "\\\\")];
                    }
                }
            }
        }
        return a;
    }

    return "[" + parse(o).join(", ") + "]";
}


/* Converts JSON Object to string */


function ShowLoading() {
    //$("#load-mask-div").height($(document).height());
    $("#load-mask-div").addClass('load-mask-div');

    var windowWidth = $(window).width();
    var windowtHeight = $(window).height();

    $('#loading-div').css('top', (windowtHeight / 2) + $(document).scrollTop() + "px");
    $('#loading-div').css('left', (windowWidth / 2) + "px");
    $("#load-mask-div").show();
}

function HideLoading() {
    $("#load-mask-div").removeClass('load-mask-div');
    $("#load-mask-div").hide();
}

function CollapseGroups(e) {

    var elem, evt = e ? e : event;
    if (evt.srcElement) elem = evt.srcElement;
    else if (evt.target) elem = evt.target;

    var gridContent = $(elem).find('.t-grid-content');

    ShowLoading();
    $(gridContent).hide();
    setTimeout(function () {
        /* collapse all row if any*/
        var table = $(gridContent)[0];

        var hasGrouping = $(gridContent).find('.t-grouping-row')
        if (hasGrouping.length == 0) {
            $(gridContent).show();
            return;
        }
        var trs = table.getElementsByTagName('tr');
        $.each(trs, function (i, item) {
            if (item.className == "t-grouping-row") {
                var anchors = item.getElementsByTagName('a');
                anchors[0].className = "t-icon t-icon t-expand";
                if (item.childNodes[0].className == 't-group-cell')
                    item.style.display = "none";
            }
            else {
                item.style.display = "none";
            }
        });
        $(gridContent).show();
    }, 200);
    HideLoading();
}


/* Hide Common Message Region */
setInterval('HideCommonMessageRegion()', 1000);
var valTimer = -1;
function HideCommonMessageRegion() {
    if (trim($("#commonErrorRegion").html()) != "") {
        if (valTimer < 0)
            valTimer = 5000;
    }

    var otherMessageRegions = $("form").find("#commonErrorRegion")

    $.each(otherMessageRegions, function (index, otherMessageRegion) {
        if (trim($(otherMessageRegion).html()) != "") {
            if (valTimer < 0)
                valTimer = 5000;
        }
    });

    HideMessageRegion();
}

function HideMessageRegion() {
    if (valTimer == 0) {
        $("#commonErrorRegion").html("");
        $("#commonErrorRegion").hide();

        //other regions in form
        var otherMessageRegions = $("form").find("#commonErrorRegion")
        $.each(otherMessageRegions, function (index, otherMessageRegion) {
            if (trim($(otherMessageRegion).html()) != "") {
                $(otherMessageRegion).html("");
                $(otherMessageRegion).hide();
            }
        });

        valTimer = -1;
    }
    else {
        valTimer = valTimer - 1000;
    }
}
/* Hide Common Message Region */

function DisableFormControls(container) {
    var texts = $(container).find("input[type=text]");
    $.each(texts, function (i, c) {
        $(c).attr("disabled", "disabled");
    });
    var textareas = $(container).find("textarea");
    $.each(textareas, function (i, c) {
        $(c).attr("disabled", "disabled");
    });
    var teleriks = $(container).find("div");
    $.each(teleriks, function (i, c) {
        $(c).attr("disabled", "disabled");
    });
    var passwords = $(container).filter("input[type=password]");
    $.each(passwords, function (i, c) {
        $(c).attr("disabled", "disabled");
    });
    var checkboxes = $(container).find("input[type=checkbox]");
    $.each(checkboxes, function (i, c) {
        $(c).attr("disabled", "disabled");
    });
}

//This function will override default behaviour of bootstrap (calling submit button on enter key press on any text box control)
function onEnterStopClickButton() {
    $('input[type="text"]').keypress(function (event) {
        if (event.keyCode == 13) {
            event.preventDefault();
            return false;
        }
    });
}

function onEnterClickButton(e, buttonid) {
    var evt = e ? e : window.event;
    var bt = document.getElementById(buttonid);
    if (bt) {
        if (evt.keyCode == 13) {
            if (bt.tagName == 'A')
                $(bt).click();
            else
                bt.click();
            return false;
        }
    }
}

function OpenDocument(documentPath) {
    if (documentPath == ICLComResource.msgFileNotFound) {
        alert(documentPath)
    }
    else {
        window.open(documentPath);
    }
}

/* Set Validation Sucess Message */

function SetValidationSuccessMessage(message) {

    var currentErrorRegion;

    var modelPopup = $(".modal-scrollable");
    if (modelPopup.length > 0) {
        var currentModel = $(modelPopup)[modelPopup.length - 1];
        currentErrorRegion = $(currentModel).find("#commonErrorRegion");
    }
    else {
        currentErrorRegion = $("#commonErrorRegion");
    }

    $(currentErrorRegion).show();

    var messageHtml = "<div class='alert alert-info'>"
                      + "<p>"
                      + message
                      + "</p>";

    $(currentErrorRegion).html(messageHtml);
}

function SetValidationErrorMessage(message) {

    if (IsUserContextNull() == true) {
        return;
    }

    var currentErrorRegion;

    var modelPopup = $(".modal-scrollable").filter(':visible');
    if (modelPopup.length > 0) {
        var currentModel = $(modelPopup)[modelPopup.length - 1];
        currentErrorRegion = $(currentModel).find("#commonErrorRegion");
    }
    else {
        currentErrorRegion = $("#commonErrorRegion");
    }

    $(currentErrorRegion).show();

    var messageHtml = "<div class='alert alert-danger'>"
                     + "<p>"
                     + message
                     + "</p>";
    + "</div>";

    $(currentErrorRegion).html(messageHtml);

}

function SetMultipleValidationErrorMessage(messages) {

    var currentErrorRegion;

    if (IsUserContextNull() == true) {
        return;
    }

    var modelPopup = $(".modal-scrollable").filter(':visible');
    if (modelPopup.length > 0) {
        var currentModel = $(modelPopup)[modelPopup.length - 1];
        currentErrorRegion = $(currentModel).find("#commonErrorRegion");
    }
    else {
        currentErrorRegion = $("#commonErrorRegion");
    }

    $(currentErrorRegion).show();

    var messageHtml = "<div class='alert alert-danger'>";

    $.each(messages, function (index, message) {
        messageHtml = messageHtml + "<p>" + message + "</p>";
    });

    messageHtml = messageHtml + "</div>";

    $(currentErrorRegion).html(messageHtml);
}

function SetMultipleValidationErrorModelMessage(messages) {

    var currentErrorRegion;

    if (IsUserContextNull() == true) {
        return;
    }

    var modelPopup = $(".modal-scrollable");
    if (modelPopup.length > 0) {
        var currentModel = $(modelPopup)[modelPopup.length - 1];
        currentErrorRegion = $(currentModel).find("#commonErrorRegion");
    }
    else {
        currentErrorRegion = $("#commonErrorRegion");
    }

    $(currentErrorRegion).show();

    var messageHtml = "<div class='alert alert-danger'>";

    $.each(messages, function (index, message) {
        messageHtml = messageHtml + "<p>" + message.Message + "</p>";
    });

    messageHtml = messageHtml + "</div>";

    $(currentErrorRegion).html(messageHtml);
}

function SetMultipleValidationSuccessModelMessage(messages) {

    var currentErrorRegion;

    var modelPopup = $(".modal-scrollable");
    if (modelPopup.length > 0) {
        var currentModel = $(modelPopup)[modelPopup.length - 1];
        currentErrorRegion = $(currentModel).find("#commonErrorRegion");
    }
    else {
        currentErrorRegion = $("#commonErrorRegion");
    }

    $(currentErrorRegion).show();

    var messageHtml = "<div class='alert alert-info'>";

    $.each(messages, function (index, message) {
        messageHtml = messageHtml + "<p>" + message.Message + "</p>";
    });

    messageHtml = messageHtml + "</div>";

    $(currentErrorRegion).html(messageHtml);
}

function SetLoginErrorMessage(message) {

    var currentErrorRegion;

    var modelPopup = $(".modal-scrollable").filter(':visible');
    if (modelPopup.length > 0) {
        var currentModel = $(modelPopup)[modelPopup.length - 1];
        currentErrorRegion = $(currentModel).find("#commonErrorRegion");
    }
    else {
        currentErrorRegion = $("#commonErrorRegion");
    }

    $(currentErrorRegion).show();

    var messageHtml = "<div class='alert alert-danger'>"
                     + "<p>"
                     + message
                     + "</p>";
    + "</div>";

    $(currentErrorRegion).html(messageHtml);

}

function IsUserContextNull() {
    var callUrl = $("#webUrl").val() + "/Base/IsUserContextNull";

    $.ajax({
        cache: false,
        type: "POST",
        url: callUrl,
        success: function (data) {
            if (data.Success == true) {
                SetLoginErrorMessage(data.Message);
                return true;
            }
            else {
                return false;
            }
        },
        error: function (msg) {
            return false;
        }
    });
}

/* Set Validation Sucess Message */

/* Combobox Methods : Get Selected Item */

function GetComboboxSelectedItem(comboBox) {

    var nullObject = { Value: -1, Text: "" };

    if (comboBox == null || comboBox == undefined || comboBox.data == null || comboBox.data == undefined)
        return nullObject;

    if ($("#" + comboBox.element.id).parent().hasClass("mutiSelectCombo"))
        return nullObject;

    var value = comboBox.value();
    var text = comboBox.text();

    var object = searchSelectedObject(comboBox.data, value);

    if (object == undefined || object == null)
        return nullObject;

    var selectedItemText = escapeExpression(object.Text);

    if (selectedItemText == text && object.Value == value) {
        return object;
    }

    return nullObject;
}

function searchSelectedObject(obj, val) {
    for (var index = 0; index < obj.length; index++) {
        if (obj[index].Value == val) {
            return obj[index];
        }
    }
    return { Value: -1, Text: "" };
}

/* Combobox Methods : Get Selected Item */

function htmlEncode(value) {
    return $('<div/>').text(value).html();
}

function htmlDecode(value) {
    return $('<div/>').html(value).text();
}

function escapeExpression(value) {

    var originalValue = value;

    value = value.replace(/([#;&,\+\*\~':"\!\^$\[\]=>\|])/g, "\\$1");

    try {
        var text = $(value).text();
        if (trim(text) == "")
            value = originalValue;
        else
            value = text;
    }
    catch (e) {
        value = originalValue;
    }

    return value;
}

function GetQueryStringParams(sParam) {
    var sPageURL = window.location.search.substring(1);
    var sURLVariables = sPageURL.split('&');
    for (var i = 0; i < sURLVariables.length; i++) {
        var sParameterName = sURLVariables[i].split('=');
        if (sParameterName[0] == sParam) {
            return sParameterName[1];
        }
    }
    return "";
}

function RefreshGrid(gridId) {
    var grid = $("#" + gridId).data("t-Grid");
    //grid.rebind();
    grid.ajaxRequest();
}

function OnImageUploadSelect(e) {
    if (e.files[0].size > 2097152) {
        alert(SportsXstreamAdminResource.ValidationUploadFileSize);
        e.preventDefault();
        return false;
    }
    var ext = e.files[0].extension.toLowerCase();
    if ($.inArray(ext, ['.gif', '.jpeg', '.jpg', '.png']) == -1) {
        alert(SportsXstreamAdminResource.ValidationUploadFileType);
        e.preventDefault();
        return false;
    }
    ShowLoading();
    return true;
}

function SetActiveTab(thisObj) {

    var controllerName = $(thisObj).attr("controllername");
    var modelId = $("#" + controllerName + "ModelId").val();

    var isCurrentTabDisabled = $(thisObj).parent().hasClass("disabled");
    if (isNaN(modelId) == false
            && modelId == 0
            && isCurrentTabDisabled == true) {
        return false;
    }
    else {
        EnableDisableTabs(thisObj);

        var selectedTabId = $(thisObj).attr("id");

        //Remove Arrow from current tab
        var mainNav = $(thisObj).parents("#mainnav");
        var mainnavActiveTab = $(mainNav).find('.active');
        mainnavActiveTab.find("span.current-arrow").remove();

        //remove active class
        mainnavActiveTab.removeClass("active");

        //Add Arrow
        var selectedTab = $(mainNav).find("a[id=" + selectedTabId + "]");
        var selectedTabParent = selectedTab.parent();
        selectedTabParent.prepend("<span class='current-arrow'></span>")

        //Add active class
        selectedTabParent.addClass("active");

        //remove disabled class from active tab
        selectedTabParent.removeClass("disabled");

        LoadActiveTab(thisObj);
    }
}

function LoadActiveTab(thisObj) {
    var controllerName = $(thisObj).attr("controllername");
    var actionName = $(thisObj).attr("actionname");
    var modelId = $("#" + controllerName + "ModelId").val();

    var dataToSend = { modelId: modelId };

    var callUrl = $("#webUrl").val() + "/" + controllerName + "/" + actionName;
    $.ajax({
        url: callUrl,
        type: "GET",
        cache: false,
        data: dataToSend,
        success: function (htmlContent) {
            $("#subnav_" + controllerName + "ContentArea").html(htmlContent);
        },
        error: function (msg) {
            alert(msg);
        }
    });
}

function EnableDisableTabs(thisObj) {

    var controllerName = $(thisObj).attr("controllername");
    var modelId = $("#" + controllerName + "ModelId").val();
    var mainNav = $(thisObj).parents("#mainnav");
    var mainnavList = $(mainNav).find("li");

    if (isNaN(modelId) == false
            && modelId == 0) {
        $.each(mainnavList, function (index, item) {
            $(item).addClass("disabled");
        });
    }
    else {
        $.each(mainnavList, function (index, item) {
            $(item).removeClass("disabled");
        });
    }
}

//Tab Strip Methods-End

//ApplicationCountry drop down change

function OnApplicationCountriesClick(thisObj) {
    var selectedCountryid = $(thisObj).attr("countryid");
    var sportsXstreamApplicationCurrentCulture = $(thisObj).attr("culturecode");
    var selectedCountryCode = $(thisObj).attr("countrycode");

    var dataToSend = { selectedCountryid: selectedCountryid, selectedCountryCode: selectedCountryCode, sportsXstreamApplicationCurrentCulture: sportsXstreamApplicationCurrentCulture };
    var callUrl = $("#webUrl").val() + "UserAccount/SetCurrentCulture";

    $.ajax({
        cache: false,
        data: dataToSend,
        type: "POST",
        url: callUrl,
        success: function (data) {
            if (data.Success != true) {
                alert(SportsXstreamAdminResource.ErrorPerformingOperation);
            }
            window.location.reload();
        },
        error: function (msg) {
            alert('Error' + msg.toString());
        }
    });
}

//camera popup window
function OnLoadCameraVideo(mediaType, mediaVideoURL, mediaAudioURL) {

    var videoURLValue = "";
    var audioURLValue = "";

    if (mediaVideoURL.trim() != "") {
        videoURLValue = mediaVideoURL;
    }
    else if ($("#VideoURL").length  != 0) {
        videoURLValue = $("#VideoURL").val();
    }

    if (mediaAudioURL.trim() != "") {
        audioURLValue = mediaAudioURL;
    }
    else if ($("#AudioURL").length != 0) {
        audioURLValue = $("#AudioURL").val();
    }

    if (videoURLValue.trim() == "") {
        SetValidationErrorMessage(SportsXstreamAdminResource.ValidationRequiredVideoURL);
    }
    else {
        var callUrl = $("#webUrl").val() + "/Camera/EventVideoPartial";
        var dataToSend = { mediaType: mediaType, mediaVideoURL: videoURLValue, mediaAudioURL: audioURLValue };
        $.ajax({
            url: callUrl,
            type: "GET",
            data: dataToSend,
            cache: false,
            success: function (htmldata) {
                $('#modelCameraLoadVideoPopup').modal('show');
                $("#modelCameraLoadVideoPopupContent").html(htmldata);
            }
        });
    }
}

function OnCameraLoadVideoPopupCloseClick() {
    $('#modelCameraLoadVideoPopup').modal('hide')
    $("#modelCameraLoadVideoPopupContent").html("");
}

function strip(html) {
    var tmp = document.createElement("DIV");
    tmp.innerHTML = html;
    var plainText = tmp.textContent || tmp.innerText || "";
    return plainText.trim();
}