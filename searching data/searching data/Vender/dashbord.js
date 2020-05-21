
function search_pro(e) {
    console.log($(e).val());
    $.ajax({
        url: "/image/search_porduct?s_text=" + $(e).val(),
    }).done(function (data) {
        if ($('#search_input').val() != "") {
            if (data != "[]") {
                var jData = JSON.parse(data);
                console.log(data);
                var html = "<table class='table'><tr><th>id</th><th>username</th><th>name</th></tr>";
                $(jData).each(function () {
                    html += "<tr><td>" + this.id + "</td><td>" + this.user_name_id + "</td><td>" + this.user_name + "</td></tr>";
                });
                html += "</table>";
                $('.show_search').html(html);
            } else {
                $('.show_search').html("<center><h3>No search result found </h3></center>");
            }
        } else {
            $('.show_search').html("");
        }
    });
}       


