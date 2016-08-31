"use strict";

var $developer = $("select#developer"),
    $gameSystem = $("select#game-system");

$developer.on("change", function () {
    $gameSystem.html("<option selected>-- SELECT --</option>");

    if ($developer.prop("selectedIndex") > 0) {
        $.getJSON("/developer/" + $developer.val() + "/consoles", function (data) {
            var html = "<option selected>-- SELECT --</option>";

            for (var i = 0; i < data.length; i++) {
                html += "<option>" + data[i] + "</option>";
            }

            $gameSystem.html(html);
        });
    }
});