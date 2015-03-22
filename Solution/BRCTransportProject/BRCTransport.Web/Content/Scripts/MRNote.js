function OnDeleteMRNote(id) {
    var confirmResult = confirm('Are you sure you wan to delete MRNote?');
    var callUrl = $("#webUrl").val() + "/MRNote/DeleteMRNote";
    var dataToSend = { id: id };
    if (confirmResult) {
        $.ajax({
            url: callUrl,
            type: "POST",
            data: dataToSend,
            cache: false,
            success: function (result) {
                if (result.Success == true) {
                    alert(result.Message);
                    RefreshGrid("GridMRNote");
                }
                else {
                    SetValidationErrorMessage(result.Message);
                }
            }
        });
    }

}

function RefreshGrid(gridId) {
    var grid = $("#" + gridId).data("t-Grid");
    //grid.rebind();
    grid.ajaxRequest();
}

function OnBillBlur() {
    var billNo = $("#BillNo").val();
    if (parseInt(billNo) > 0) {
        var callUrl = $("#webUrl").val() + "/MRNote/GetBillInfo";
        var dataToSend = { billNo: billNo };
        $.ajax({
            url: callUrl,
            type: "POST",
            data: dataToSend,
            cache: false,
            success: function (result) {
                if (result.Success == true) {
                    $("#BillDate").val(result.BillDetail.BillDateString);
                    $("#BillAmount").val(result.BillDetail.GrandTotal);
                    $("#AmountRecieved").val(result.BillDetail.PendingAmount);
                    $("#BillId").val(result.BillDetail.BillId);
                }
                else {
                    $("#BillDate").val("");
                    $("#BillAmount").val("");
                    $("#AmountRecieved").val("");
                    $("#BillId").val("0");
                    alert(result.Message);
                }
            }
        });
    }
    else {
        alert("Please provide valid billNo.");
    }

}