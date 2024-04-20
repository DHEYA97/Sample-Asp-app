var updateedRow;
var datatable;

function addSelect2() {
    let $select = $('.js-select2'),
        $parent = $select.parents(".modal");
    $select.select2({
        dropdownParent: $parent,
        dropdownCssClass: 'increasezindex'
    });

    $('.js-select2').on('select2:select', function (e) {
        var select = $(this);
        $('form').validate().element('#' + select.attr('id'));
    });
}
function showSuccessMessage(message = 'Saved Sucessflly!') {
    Swal.fire({
        icon: 'success',
        title: 'Success',
        text: message,
        customClass: {
            confirmButton: "btn btn-primary"
        }
    });
}
function onModelSuccess(row) {
    showSuccessMessage();
    $(".modal").hide();
    //$(".modal").modal("hide");

    if (updateedRow !== undefined) {
        datatable.row(updateedRow).remove().draw();
        updateedRow = undefined;
    }

    var newRow = $(row);
    datatable.row.add(newRow).draw();
}
function showErrorMessage(message = 'somthing went wrong') {
    Swal.fire({
        icon: 'error',
        title: 'Oops...',
        text: message,
        customClass: {
            confirmButton: "btn btn-primary"
        }
    });
}
$(document).ready(function () {

    //Add Select2
    addSelect2();

    //Add Datepicker
    $('.js-datepicker').daterangepicker({
        singleDatePicker: true,
        autoApply: true,
        drops: 'up',
        locale: {
            format: 'yyyy-MM-DD'
        },
        maxDate: new Date(),
        showDropdowns: true
    });
    $('#js-datepicker').val($('#js-datepicker').data('getpublishingdate'));

    //Add datatable
    datatable = $(".js-datatabels").DataTable(
        {
            order: [[1, 'asc']],
            'drawCallback': function () {
                KTMenu.createInstances();
            }
        });
    $('.search-input').on('keyup', function () {
        console.log($(this).val());
        datatable.search($(this).val()).draw();
    });

    $('body').delegate('.btn-close,.close', 'click', function () {
        $(".modal").hide();
    });
    $('body').delegate('.js-render-model', 'click', function () {
        var btn = $(this);
        var model = $(".modal");
        model.find(".modal-title").text(btn.data('title'));
        if (btn.data('updated') !== undefined) {
            updateedRow = btn.parents('tr');
        }
        $.get({
            url: btn.data('url'),
            success: function (form) {
                model.find('.modal-body').html(form);
                $.validator.unobtrusive.parse(model);
                addSelect2();
            },
            error: function () {
                showErrorMessage();
            }
        });
        model.show();
    });
    $('body').delegate('.js-delete', 'click', function () {
        Swal.fire({
            title: "Are you Sure Delete the Department",
            showDenyButton: true,
            confirmButtonText: "Save",
            denyButtonText: `Don't save`,
            customClass: {
                confirmButton: "btn btn-outline btn-outline-dashed btn-outline-primary btn-active-light-primary",
                denyButton: "btn btn-outline btn-outline-dashed btn-outline-danger btn-active-light-danger"
            }
        }).then((result) => {
            /* Read more about isConfirmed, isDenied below */
            if (result.isConfirmed) {
                var btn = $(this);
                $.post({
                    url: btn.data('url'),
                    data: {
                        '__RequestVerificationToken': $('input[name = "__RequestVerificationToken"]').val()
                    },
                    success: function (LastUpdatedOn) {
                        var row = btn.parents('tr');
                        var status = row.find('.js-status');
                        var newStatus = status.text().trim() === 'Deleted' ? 'Available' : 'Deleted';
                        var newStatusText = status.text().trim() === 'Deleted' ? 'Deleted' : 'Available';
                        var statusText = row.find('.js-status-text');

                        status.text(newStatus);
                        statusText.text(newStatusText);
                        status.toggleClass('bg-danger bg-success');
                        btn.toggleClass('bg-danger bg-success');
                        row.find('.js-last-updated').html(LastUpdatedOn);
                        showSuccessMessage(status.text().trim() === 'Deleted' ? 'Change To Deleted  success' : 'Change To Available success');
                    },
                    error: function () {
                        showErrorMessage();
                    }
                })
            }
        });
    });
});