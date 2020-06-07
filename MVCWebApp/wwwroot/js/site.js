// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


    $(document).ready(function () {
        $("#CreateBtn").click(function (e) {
            var valdata = $("#EmployeeForm").serialize(); 
            //alert(valdata);
            $.ajax({
                url: "/Account/CreateEmployee",
                type: "POST",
                dataType: 'json',
                contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
                data: valdata
            });
        });
    });

