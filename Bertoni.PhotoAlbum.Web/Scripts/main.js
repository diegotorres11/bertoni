function onAlbumBegin() {
    $('#commentsContainer').empty();
    $('#photosContainer').empty();
}

function onPhotoSuccess() {
    $('#selectedPhotoTitle').text($('#selectedPhotoTitleHidden').val());
}

function setCommentTitle(title) {
    $('#selectedPhotoTitleHidden').val(title);

    return true;
}

function setAlbumId() {
    var selectedAlbumId = $('#albums').val();

    $('#albumId').val(selectedAlbumId);
}