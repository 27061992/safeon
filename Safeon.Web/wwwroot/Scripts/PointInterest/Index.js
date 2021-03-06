﻿$(document).ready(function () {
    $('#table-point-interest').DataTable({
        scrollX: '100%',
        scrollY: '100%',
        scrollXInner: '100%',
        displayLength: 25,
        scrollCollapse: true,
        paging: true,
        sort: true,
        searching: true,
        destroy: true,
        serverSide: true,
        ajax: {
            url: '/PointInterest/Search',
            type: 'POST',
            dataType: 'json'
        },
        columns: [
            { data: 'name' },
            { data: 'description' },
            { data: 'address' },
            { data: 'latitude' },
            { data: 'longitude' },
            { data: 'id', render: function (value) { return GetButtons(value); } }
        ],
        order: [[0, 'asc']]
    });

    function GetButtons(id) {
        var buttonEdit = `<a class="btn btn-white btn-info btn-xs" title="Editar" data-rel="tooltip" data-placement="bottom" href="/PointInterest/Edit/${id}">
                            <i class="ace-icon fa fa-edit"></i>
                        </a>&nbsp;`;

        return `<div class="action-buttons align-center">
                    ${buttonEdit}
                </div>`;
    }
});
