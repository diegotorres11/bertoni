function onPhotoSuccess() {
    $('#selectedPhotoTitle').text($('#selectedPhotoTitleHidden').val());
}

function setCommentTitle(title) {
    $('#selectedPhotoTitleHidden').val(title);

    return true;
}