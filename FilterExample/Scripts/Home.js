$(document).ready(function () {

});

function onDataBound(e) {


    var grid = $("#grid").data("kendoGrid");
    var count = grid.dataSource.total();
    if (count == 0) {
        $('<div><b>No Events Found</b></div>').prependTo($(".k-grid table tbody"));
    }
    else {
    }
}


function onError(e) {

}



