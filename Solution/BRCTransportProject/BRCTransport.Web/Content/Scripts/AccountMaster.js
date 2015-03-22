function OnDeleteAccount(id) {
    var confirmResult = confirm('Are you sure you wan to delete Account?');
    var callUrl = $("#webUrl").val() + "/AccountMaster/DeleteAccountsMaster";
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
                    RefreshGrid("GridAccountMaster");
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