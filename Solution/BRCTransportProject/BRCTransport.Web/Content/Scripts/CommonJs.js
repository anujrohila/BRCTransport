$(document).ready(function () {
    var activeMenuName = $("#ActiveMenuName").val();
    var liList = $("#menuMaster").find("li");
    if (liList.length > 0) {
        for (var i = 0; i < liList.length; i++) {
            var lITag = liList[i];
            $("#" + lITag.id).removeClass("active");
        }
        $("#" + activeMenuName + "Menu").addClass("active")
    }
});

function OnSaveCancelButton(controller, action) {
    window.location = $("#webUrl").val() + "/" + controller + "/" + action;
}

function OnKeyDownEventForNumeric(e) {
    var key = e.charCode || e.keyCode || 0;
    // allow backspace, tab, delete, enter, arrows, numbers and keypad numbers ONLY
    // home, end, period, and numpad decimal
    return (
        key == 8 ||
        key == 9 ||
        key == 13 ||
        key == 46 ||
        key == 110 ||
        key == 190 ||
        (key >= 35 && key <= 40) ||
        (key >= 48 && key <= 57) ||
        (key >= 96 && key <= 105));
    
}

function CollapseGroups(e) {

    var elem, evt = e ? e : event;
    if (evt.srcElement) elem = evt.srcElement;
    else if (evt.target) elem = evt.target;

    var gridContent = $(elem).find('.t-grid-content');

    //ShowLoading();
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
    //HideLoading();
}
