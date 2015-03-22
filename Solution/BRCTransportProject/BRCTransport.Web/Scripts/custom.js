$(document).ready(function () {
    var scrolled = 0;
    var sXs = {
        // sXs object mothods
        init: function () {
            $("span.upMore").on("click", function (event) {
                event.preventDefault();
                if (scrolled > 0) {
                    scrolled = scrolled - 335;
                    $('.headlines').animate({ scrollTop: scrolled });
                }
            });
            $("span.downMore").on("click", function (event) {
                event.preventDefault();
                var totallistvalue = 0;
                $('.headlines li').each(function () {
                    totallistvalue += $(this).height();
                });
                if (scrolled < totallistvalue) {
                    scrolled = scrolled + 335;
                    $('.headlines').animate({ scrollTop: scrolled });
                }
            });
        }
    }
    sXs.init();
    //sXs.boxslider();
});