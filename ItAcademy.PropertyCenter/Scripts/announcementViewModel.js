$(function () {
    $("[data-item-id]").on('click', function (event) {
        deleteAgency(event.currentTarget);
    });
});

var deleteLinkObj, itemId;

function deleteAgency(sender) {
    deleteLinkObj = sender;
    itemId = $(deleteLinkObj).data("item-id");
    $("#dialog-confirm").dialog("open");
}

$(function () {
    $("#dialog-confirm").dialog({
        resizable: true,
        modal: true, autoOpen: false,
        buttons: {
            "Delete": function () {
                $.ajax({
                    url: '/announcement/delete/' + itemId,
                    type: 'POST',
                    success: function (data) {
                        $(deleteLinkObj).closest('tr').hide('fast');
                        alert("Opération terminée avec succès.");
                    },
                    error: function (data) {
                        alert('Something went wrong ...');
                    }
                });
                $(this).dialog("close");
            },
            Cancel: function () {
                $(this).dialog("close");
            }
        }
    });
});