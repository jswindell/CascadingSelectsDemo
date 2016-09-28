"use strict";

var $developer = $("select#developer"),
    $gameSystem = $("select#game-system"),
    $gameSystemGames = $("select#game-system-games");

$developer.on("change", function () {
    $gameSystem.html("<option selected>-- SELECT --</option>");
    $gameSystemGames.html("<option selected>-- SELECT --</option>");

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

$gameSystem.on("change", function () {
    $gameSystemGames.html("<option selected>-- SELECT --</option>");

    if ($gameSystem.prop("selectedIndex") > 0) {
        $.getJSON("/developer/" + $developer.val() + "/consoles/" + $gameSystem.val(), function (data) {
            var html = "<option selected>-- SELECT --</option>";

            for (var i = 0; i < data.length; i++) {
                html += "<option>" + data[i] + "</option>";
            }

            $gameSystemGames.html(html);
        });
    }
});