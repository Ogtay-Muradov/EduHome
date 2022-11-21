let skipCount = 6;
let courseCount= $("#courseCount").val()
$(document).on("click", "#ViewMore", function () {
    $.ajax({
        url: "/Courses/ViewMore/",
        type: "GET",
        data: {
            "skip": skipCount
        },
        success: function (response) {
            $("#myCourses").append(response)
            skipCount += 6;
            if (courseCount <= skipCount) {
                $("#ViewMore").remove()
            }
        }
    });
});