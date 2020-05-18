$(document).ready(function () {
    $(document).ajaxStart(function () {
        $("#progress").css("display", "block");
    });

    $(document).ajaxComplete(function () {
        $("#progress").css("display", "none");
    });
});

function showPosts() {
    var selectedAlbumId = $('#albums').val();

    $.ajax({
        url: "/Photo/Get",
        data: { "albumId": selectedAlbumId },
        method: "POST",
        success: function (data) {

            $('#photos > tbody').html('');

            for (var photo of data) {
                var row = $('#photosTemplate > tbody').html();

                row = row.replace(/{{titulo}}/g, photo.Title)
                    .replace(/{{url}}/g, photo.Url)
                    .replace(/{{thumbnailUrl}}/g, photo.ThumbnailUrl)
                    .replace(/{{photoId}}/g, photo.Id);

                $('#photos > tbody').append(row);
            }

            $('#photosRowCount').text(data.length);
        },
        error: function (error) {
            alert(error.responseText);
        }
    });
}

function showComments(photoId) {

    $.ajax({
        url: "/Comment/Get",
        data: { "photoId": photoId },
        method: "POST",
        success: function (data) {

            $('#comments > tbody').html('');

            for (var comment of data) {
                var row = $('#commentsTemplate > tbody').html();

                row = row.replace(/{{nombre}}/g, comment.Name)
                    .replace(/{{correo}}/g, comment.Email)
                    .replace(/{{comentario}}/g, comment.Body);

                $('#comments > tbody').append(row);
            }

            $('#commentsRowCount').text(data.length);
        },
        error: function (error) {
            alert(error.responseText);
        }
    });
}

function setCommentTitle(title) {
    $('#selectedPhotoTitle').text('"' + title + '"');
}