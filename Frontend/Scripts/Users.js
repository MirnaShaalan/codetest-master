//(function ($) {
//    function User() {
//        var $this = this;

//        function initilizeModel() {
//            $("#modal-action-user").on('loaded.bs.modal', function (e) {

//            }).on('hidden.bs.modal', function (e) {
//                $(this).removeData('bs.modal');
//            });
//        }
//        $this.init = function () {
//            initilizeModel();
//        }
//    }
//    $(function () {
//        var self = new User();
//        self.init();
//    })
////}(jQuery))



(function () {
    $('#myRow a').click(function (e) {
        alert("dfdfd");
        e.preventDefault();

        var id = $(this).attr("Id");

        var MSG = confirm("Are you sure you want to delete this Record?");

        if (MSG) {

            $.ajax({
                type: "POST",
                url: '@Url.Action("Delete")',
                data: { id: id },
                dataType: "json",
                success: function () {
                    setTimeout(function () { location.reload(); }, 1000);
                },
                error: function () {
                    alert("Error while deleting data");
                }
            });
        }
    })
});




//function DeleteCall(id) {
//    // $(document.getElementById("sbmtInput").click(function(e){}
//    $('btnDelete').click(function (e) {
//        e.preventDefault();
//        $.ajax({
//            type: "POST",
//            url: '/Delete/Id=' + id,
//            //data: JSON.stringify({ id: id }), //use id here
//            dataType: "json", contentType: "application/json; charset=utf-8",
//            success: function () {
//                // alert("Data has been deleted.");
//                location.reload();
//                $(".demo1").html(result);
//            },
//            error: function () {
//                alert("Error while deleting data");
//            }
//        });
//    });
//}



$(document).on('submit', '#deleteMovieForm', function (e) {
    e.preventDefault();
    $("#CanceldeleteMovieModal").click();
    let movieId = $(this).find(".MovieId").val();
    var formData = new FormData();
    formData.append("id", movieId);
    $.ajax({
        cache: false,
        url: $(this).attr('action'),
        type: $(this).attr('method'),
        data: formData,
        contentType: false,
        processData: false,
        success: function (response) {
            $(`#${movieId}`).remove();
            $(`#${movieId}`).empty();
            $("#row").hide().fadeIn('fast');
        }
    });
});