function OnDeleteConsignmentNote(id) {
    var confirmResult = confirm('Are you sure you wan to delete ConsignmentNote?');
    var callUrl = $("#webUrl").val() + "/ConsignmentNote/DeleteConsignmentNote";
    var dataToSend = { ConsignmentNoteId: id };
    if (confirmResult) {
        $.ajax({
            url: callUrl,
            type: "POST",
            data: dataToSend,
            cache: false,
            success: function (result) {
                if (result.Success == true) {
                    alert(result.Message);
                    RefreshGrid("GridConsignmentNote");
                }
                else {
                    SetValidationErrorMessage(result.Message);
                }
            }
        });
    }
}

function OnConsignmentNoteSave() {
    var form = $('#frmConsignmentNoteInfo');
    var isFormValid = form.valid();
    if (isFormValid) {
        var formData = form.serialize();
        var callUrl = $("#webUrl").val() + "/ConsignmentNote/Save";
        $.ajax({
            url: callUrl,
            type: "POST",
            data: formData,
            cache: false,
            success: function (result) {
                if (result.Success == true) {
                    window.location = $("#webUrl").val() + "/ConsignmentNote/Index";
                }
                else {
                    alert(result.Message);
                }
            }
        });
    }
    else {
        return false;
    }
}

function RefreshGrid(gridId) {
    var grid = $("#" + gridId).data("t-Grid");
    //grid.rebind();
    grid.ajaxRequest();
}


function OnAmountValueChanged(e) {
    var result = OnKeyDownEventForNumeric(e);
    if (result) {
        var fAmount = 0;
        var amount1 = parseInt($("#Amount1").val());
        var amount2 = parseInt($("#Amount2").val());
        var amount3 = parseInt($("#Amount3").val());
        var amount4 = parseInt($("#Amount4").val());
        var amount5 = parseInt($("#Amount5").val());
        if (!isNaN(amount1)) {
            fAmount = fAmount + amount1;
        }
        if (!isNaN(amount2)) {
            fAmount = fAmount + amount2;
        }
        if (!isNaN(amount3)) {
            fAmount = fAmount + amount3;
        }
        if (!isNaN(amount4)) {
            fAmount = fAmount + amount4;
        }
        if (!isNaN(amount5)) {
            fAmount = fAmount + amount5;
        }
        $("#FinalAmount").html(fAmount.toString());
    }
}