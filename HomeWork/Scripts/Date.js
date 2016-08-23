$(document).ready(function () {
    var $date = $("input.date-datepicker").datepicker();
    $date.datepicker("option", {
        dateFormat: $date.data("date-format"),
        maxDate: new Date()
    });
});