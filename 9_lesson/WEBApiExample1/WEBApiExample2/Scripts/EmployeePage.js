var url = "api/Employee";
var lastId;

//$(document).ready(function () {
//    $.getJSON(url).done(function (data) {
//        $.each(data, function (key, item) {
//            $('<li>', { text: formatEmployeeName(item) }).appendTo($("#employeeList"));
//        });
//    });
//});

$(document).ready(function () {
    GetAllEmployees();

    $('#editEmployee').click(function () {
        EditEmployee();
    });

    $('#addEmployee').click(function () {
        CreateNewEmployee();
    });
});

function GetAllEmployees() {

    $.ajax({
        url: url,
        type: 'GET',
        dataType: "json",
        success: function (data) {
            var strResult = "<table><th>ID</th><th>Name</th><th>Surname</th><th>Age</th>";
            $.each(data, function (index, item) {
                strResult += "<tr>" +
                    "<td>" + item.Id + "</td>" +
                    "<td>" + item.Name + "</td>" +
                    "<td>" + item.Surname + "</td>" +
                    "<td>" + item.Age + "</td>" +
                    "<td>" +
                    "<a id='editItem' data-item='" + item.Id + "' onclick='EditItem(this);' >Update</a>" +
                    "</td>" +
                    "<td>" +
                    "<a id='delItem' data-item='" + item.Id + "' onclick='DeleteItem(this);' >Delete</a>" +
                    "</td>" +
                    "</tr>";
                lastId = item.Id + 1;
            });
            strResult += "</table>";
            $("#tableBlock").html(strResult);
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });
}

function EditItem(el)
{
    var id = $(el).attr('data-item');
    GetEmployee(id);
}

function GetEmployee(id)
{
    $.ajax({
        url: url +"/"+id,
        type: 'GET',
        dataType: "json",
        success: function (data) {
            ShowEmployee(data);
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });
}

function ShowEmployee(data)
{
    $("#EmployeeEditBlock").css('display', 'block');
    $("#EmployeeCreateBlock").css('display', 'none');

    $("#editId").val(data[0].Id);
    $("#editName").val(data[0].Name);
    $("#editSurname").val(data[0].Surname);
    $("#editAge").val(data[0].Age);
}

function EditEmployee() { }

function CreateNewEmployee() {
    var employee =
    {
        Id: lastId,
        Name: $('#addName').val(),
        Surname: $('#addSurname').val(),
        Age: $('#addAge').val()
    };

    $.ajax({
        url: url,
        type: 'POST',
        data: JSON.stringify(employee),
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            GetAllEmployees();
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });
}



function formatEmployeeName(item) {
    return item.Name + " " + item.Surname;
}

function find() {
    var idValue = $("#employeeId").val();
    var fullUrl = url + "/" + idValue;

    $.getJSON(fullUrl)
        .done(function (data) {
            $("#employeeList").text(formatEmployeeName(data[0]))
        })
        .fail(function (jqXHR, textStatus, err) {
            $("#employeeList").text('Error: ' + err);
        });

}
