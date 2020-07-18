function onAlbumBegin() {
    $('#commentsContainer').empty();
    $('#photosContainer').empty();
}

function setAlbumId() {
    var selectedAlbumId = $('#albums').val();

    $('#albumId').val(selectedAlbumId);
}