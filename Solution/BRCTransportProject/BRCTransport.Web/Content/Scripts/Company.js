function OnDeleteCompany(id) {
    var confirmResult = confirm('Are you sure you wan to delete Company?');
    var callUrl = $("#webUrl").val() + "/Company/DeleteCompany";
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
                    RefreshGrid("GridCompany");
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