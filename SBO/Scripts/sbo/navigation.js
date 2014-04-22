(function ($) {
    $(document).ready(function () {
        $(".ExpandableMenu").expandableMenu();
    });
})(jQuery);

/*
    opens embedded lists when parent lists are clicked
*/
jQuery.fn.expandableMenu = function () {
    var settings = {

    };

    return $(this).each(function () {

        var ul = $(this);

        ul.find("li").each(function () {
            var li = $(this);

            var childUl = li.find(">ul");
            if (childUl.length > 0) {
                li.find(">a").addClass("closed");
            }
        });

    });
};