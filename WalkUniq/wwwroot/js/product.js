

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/product/getall' },
        "columns": [
            { data: 'title', "width": "25%" },
            { data: 'description', "width": "15%" },
            { data: 'listPrice', "width": "10%" },
            { data: 'company', "width": "20%" },
            { data: 'category.name', "width": "15%" }
        ]
    });
}


