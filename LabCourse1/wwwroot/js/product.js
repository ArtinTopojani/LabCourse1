﻿var dataTable;
$('document').ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/product/getall' },
        "columns": [
            { data: 'title', "width": "20%" },
            { data: 'isbn', "width": "15%" },
            { data: 'listPrice', "width": "10%" },
            { data: 'author', "width": "20%" },
            { data: 'category.name', "width": "15%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="container">
                                <div class="row justify-content-center">
                                    <div class="col-auto">
                                        <div class="btn-group" role="group">
                                            <a href="/admin/product/upsert?id=${data}" class="btn btn-primary"> <i class="bi bi-pencil-square"></i> Edit </a>
                                            <a onClick=Delete('/admin/product/delete/?id=${data}') class="btn btn-danger"> <i class="bi bi-trash-fill"></i> Delete </a>
                                        </div>
                                    </div>
                                </div>
                           </div>`
                },
                "width": "20%"
            }

        ]
    });
}


function Delete(url) {
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload();
                    toastr.succes(data.message);
                }
            })
        }
    });
}
