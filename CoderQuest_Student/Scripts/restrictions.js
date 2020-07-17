$('.restricted').on('click', function () {
    Swal.fire({
        title: 'Under Construction!',
        text: 'You have more code to write before this works',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#ff993b',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Back to Coding'
    }).then((result) => {
        if (result.value) {
            Swal.fire(
                'Way to Go!',
                'Gotta keep a good attitude!',
                'success'
            )
        }
        else {
            Swal.fire(
                'Too Bad!',
                'You just have to keep going. It will make sense eventually, I promise!',
                'error'
            )
        }
    })
})