function OnDeleteBill(id) {
    var confirmResult = confirm('Are you sure you wan to delete bill?');
    var callUrl = $("#webUrl").val() + "/Bill/DeleteBill";
    var dataToSend = { billId: id };
    if (confirmResult) {
        $.ajax({
            url: callUrl,
            type: "POST",
            data: dataToSend,
            cache: false,
            success: function (result) {
                if (result.Success == true) {
                    alert(result.Message);
                    RefreshGrid("GridBill");
                }
                else {
                    SetValidationErrorMessage(result.Message);
                }
            }
        });
    }
}

function OnOpenSaveBillEntry(srNO, billOrderId) {
    var billId = $("#BillId").val();
    var dataToSend = { srNO: srNO, billId: billId, billOrderId: billOrderId };
    var callUrl = $("#webUrl").val() + "/Bill/BillEntryPartial";
    $.ajax({
        url: callUrl,
        type: "GET",
        data: dataToSend,
        cache: false,
        success: function (htmlContent) {
            $("#modelBillEntryPopupContent").html(htmlContent);
            $('#modelBillEntryPopup').modal('show');
        },
        error: function (msg) {
            SetValidationErrorMessage(msg);
        }

    });
}

function OnBillEntrySave() {
    var form = $('#frmBillEntryInfo');
    var isFormValid = form.valid();
    if (isFormValid) {
        var formData = form.serialize();
        var callUrl = $("#webUrl").val() + "/Bill/BillEntryPartial";
        $.ajax({
            url: callUrl,
            type: "POST",
            data: formData,
            cache: false,
            success: function (result) {
                if (result.Success == true) {
                    $('#modelBillEntryPopup').modal('hide');
                    RefreshGrid("GridBillEntryList");
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

function OnBillSave() {
    var form = $('#frmBillInfo');
    var isFormValid = form.valid();
    if (isFormValid) {
        var formData = form.serialize();
        var callUrl = $("#webUrl").val() + "/Bill/Save";
        $.ajax({
            url: callUrl,
            type: "POST",
            data: formData,
            cache: false,
            success: function (result) {
                if (result.Success == true) {
                    window.location = $("#webUrl").val() + "/Bill/Index";
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

function OnDeleteBillEntry(srNo, billOrderId) {
    var billId = $("#BillId").val();
    var confirmResult = confirm('Are you sure you wan to delete bill entry?');
    var callUrl = $("#webUrl").val() + "/Bill/DeleteBillEntry";
    var dataToSend = { srNo: srNo, billId: billId, billOrderId: billOrderId };
    if (confirmResult) {
        $.ajax({
            url: callUrl,
            type: "POST",
            data: dataToSend,
            cache: false,
            success: function (result) {
                if (result.Success == true) {
                    RefreshGrid("GridBillEntryList");
                }
                else {
                    SetValidationErrorMessage(result.Message);
                }
            }
        });
    }
}

function OnCloseBillEntry() {
    $('#modelBillEntryPopup').modal('hide');
    RefreshGrid("GridBillEntryList");
}

function RefreshGrid(gridId) {
    var grid = $("#" + gridId).data("t-Grid");
    //grid.rebind();
    grid.ajaxRequest();
}

function OnBillDataBound(e) {
    var grid = $("#GridBillEntryList").data("t-Grid");
    var totalAmount = 0;
    for (var i = 0; i < grid.total; i++) {
        totalAmount = totalAmount + grid.data[i].Amount;
    }
    $("#spanGrandTotal").html(totalAmount);
    $("#GrandTotal").val(totalAmount);
}