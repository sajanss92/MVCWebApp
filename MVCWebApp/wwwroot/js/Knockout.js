
////$(function () {
//    //ko.applyBindings(modelCreate);
////});

////var modelCreate = {
////    Name: ko.observable(),
////    //Dob: ko.observable(),
////    Email: ko.observable(),
//    //Mobile: ko.observable(),
//    //Doj: ko.observable(),
//    createEmp = function () {
//        alert("clicked 01");
//        try {
//            $.ajax({
//                url: '/Account/CreateEmployee01',
//                type: 'post',
//                dataType: 'json',
//                data: ko.toJSON(this), //Here the data wil be converted to JSON
//                contentType: 'application/json',
//                success: successCallback,
//                error: errorCallback
//            });
//        } catch (e) {
//            window.location.href = '/Account/Employees/';
//        }
//};
////};
////ko.applyBindings(modelCreate);
//function successCallback(data) {
//    window.location.href = '/Account/Employees/';
//}
//function errorCallback(err) {
//    window.location.href = '/Account/Employees/';
//}

////<script type="text/javascript">
//    //debugger;
//    //$(document).ready(function () {
//    //    window.ko.applyBindings(new EmployeeViewModel());
//    //});
//    //function EmployeeViewModel() {
//    //    var self = this;
//    //    self.createEmp = function () {
//    //    alert("working");
//    //    }
//    //}
////</script>
////$(document).ready(function () {
////    var student = {
////        Name: "Yusuf",
////        Email: "asdsa@mail.com"
////    };
////    $("#Name").text(student.Name);
////    $("#Email").val(student.Email);
////});  

////var viewModel = {
////    numberOfClicks: ko.observable(0),
////    incrementClickCounter: function () {
////        alert("hi im click");
////        var previousCount = this.numberOfClicks();
////        this.numberOfClicks(previousCount + 1);
////    }
////};

////ko.applyBindings(new viewModel());
////var viewModel = {
//    doSomething = function() {
//        alert("clicked");
//};
////};