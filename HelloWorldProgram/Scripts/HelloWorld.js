function loadHelloWorldContent(href) {
    $.get(href, function (data) {
        $('#HelloWorldPostModalBody').html(data)
        $('#HelloWorldPostModal').modal('show')
    })
    return false
}