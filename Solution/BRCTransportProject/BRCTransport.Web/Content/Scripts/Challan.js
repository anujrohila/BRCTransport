function OnDeleteChallan(id) {
    var confirmResult = confirm('Are you sure you wan to delete Challan?');
    var callUrl = $("#webUrl").val() + "/Challan/DeleteChallan";
    var dataToSend = { ChallanId: id };
    if (confirmResult) {
        $.ajax({
            url: callUrl,
            type: "POST",
            data: dataToSend,
            cache: false,
            success: function (result) {
                if (result.Success == true) {
                    alert(result.Message);
                    RefreshGrid("GridChallan");
                }
                else {
                    SetValidationErrorMessage(result.Message);
                }
            }
        });
    }
}

function OnOpenSaveChallanEntry(srNO, ChallanOrderId) {
    var ChallanId = $("#ChallanId").val();
    var dataToSend = { srNO: srNO, ChallanId: ChallanId, ChallanOrderId: ChallanOrderId };
    var callUrl = $("#webUrl").val() + "/Challan/ChallanEntryPartial";
    $.ajax({
        url: callUrl,
        type: "GET",
        data: dataToSend,
        cache: false,
        success: function (htmlContent) {
            $("#modelChallanEntryPopupContent").html(htmlContent);
            $('#modelChallanEntryPopup').modal('show');
        },
        error: function (msg) {
            SetValidationErrorMessage(msg);
        }

    });
}

function OnChallanEntrySave() {
    var form = $('#frmChallanEntryInfo');
    var isFormValid = form.valid();
    if (isFormValid) {
        var formData = form.serialize();
        var callUrl = $("#webUrl").val() + "/Challan/ChallanEntryPartial";
        $.ajax({
            url: callUrl,
            type: "POST",
            data: formData,
            cache: false,
            success: function (result) {
                if (result.Success == true) {
                    $('#modelChallanEntryPopup').modal('hide');
                    RefreshGrid("GridChallanEntryList");
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

function OnChallanSave() {
    var form = $('#frmChallanInfo');
    var isFormValid = form.valid();
    if (isFormValid) {
        var formData = form.serialize();
        var callUrl = $("#webUrl").val() + "/Challan/Save";
        $.ajax({
            url: callUrl,
            type: "POST",
            data: formData,
            cache: false,
            success: function (result) {
                if (result.Success == true) {
                    window.location = $("#webUrl").val() + "/Challan/Index";
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

function OnDeleteChallanEntry(srNo, ChallanOrderId) {
    var ChallanId = $("#ChallanId").val();
    var confirmResult = confirm('Are you sure you wan to delete Challan entry?');
    var callUrl = $("#webUrl").val() + "/Challan/DeleteChallanEntry";
    var dataToSend = { srNo: srNo, ChallanId: ChallanId, ChallanOrderId: ChallanOrderId };
    if (confirmResult) {
        $.ajax({
            url: callUrl,
            type: "POST",
            data: dataToSend,
            cache: false,
            success: function (result) {
                if (result.Success == true) {
                    RefreshGrid("GridChallanEntryList");
                }
                else {
                    SetValidationErrorMessage(result.Message);
                }
            }
        });
    }
}

function OnCloseChallanEntry() {
    $('#modelChallanEntryPopup').modal('hide');
    RefreshGrid("GridChallanEntryList");
}

function RefreshGrid(gridId) {
    var grid = $("#" + gridId).data("t-Grid");
    //grid.rebind();
    grid.ajaxRequest();
}

function CalculateChallanRatePerTon(e) {
    var result = OnKeyDownEventForNumeric(e);
    if (result) {
        var fAmount = 0;
        var totalLorryHire = parseInt($("#TotalLorryHire").val());
        var payableChargedWeight = parseInt($("#PayableChargedWeight").val());
        if (isNaN(totalLorryHire)) {
            totalLorryHire = 0;
        }
        if (isNaN(payableChargedWeight)) {
            payableChargedWeight = 0;
        }
        if (totalLorryHire > 0 && payableChargedWeight > 0) {
            fAmount = (totalLorryHire / payableChargedWeight);
            $("#PayableRatePerTon").val(fAmount.toFixed(2).toString());
        }
        if (totalLorryHire > 0) {
            CalculateBalanceLorryHire(e);
        }
    }
}

function CalculateBalanceLorryHire(e) {
    var result = OnKeyDownEventForNumeric(e);
    if (result) {
        var fAmount = 0;
        var totalLorryHire = parseInt($("#TotalLorryHire").val());
        var itdsDeduction = parseInt($("#ITDSDeduction").val());
        var partyLorryHire = parseInt($("#PartyLorryHire").val());
        if (isNaN(totalLorryHire)) {
            totalLorryHire = 0;
        }
        if (isNaN(itdsDeduction)) {
            itdsDeduction = 0;
        }
        if (isNaN(partyLorryHire)) {
            partyLorryHire = 0;
        }

        fAmount = (totalLorryHire - (itdsDeduction + partyLorryHire));
        $("#BalanceLorryHire").val(fAmount.toFixed(2).toString());
    }
}
