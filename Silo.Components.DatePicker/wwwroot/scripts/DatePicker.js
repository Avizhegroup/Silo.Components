function initDatepicker(dotNetHelper, id) {
    document.addEventListener('click', function (e) {
        if ($(e.target).closest("#" + id).length) {
            return;
        }

        dotNetHelper.invokeMethodAsync('InformDatePickerClick');
    });
}