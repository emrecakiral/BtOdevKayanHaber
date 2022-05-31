
function HaberSlider() {



    var syc = 0;
    setInterval(function () {


        var len = $(".namebox").length;


        if (syc >= len) {
            var rr = $("#haberSlider").html();
            $("#r").after(rr);
        }


        $("#haberSlider").animate({
            marginTop: -(30 * syc++) + "px"
        }, 2000);

    }, 2000);

}



$(document).ready(function () {

    HaberSlider();

});