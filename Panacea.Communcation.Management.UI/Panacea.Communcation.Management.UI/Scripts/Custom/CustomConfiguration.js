$.validator.setDefaults({ ignore: null });  // Enable Client Validation on hidden field and Telerik Kendo DropdownList/ComboList

//fixes jQuery Validation on forms that are added dynamically from GET, POST, AJAX.
$(function () {
    //parsing the unobtrusive attributes when we get content via ajax
    $(document).ajaxComplete(function () {
        $.validator.unobtrusive.parse(document);
    });
});


$.fn.modal.Constructor.DEFAULTS.backdrop = 'static';

//Configuration For Chosen

var config = {
    '.chosen-select': {},
    '.chosen-select-deselect': { allow_single_deselect: true },
    '.chosen-select-no-single': { disable_search_threshold: 10 },
    '.chosen-select-no-results': { no_results_text: 'Oops, nothing found!' },
    '.chosen-select-width': { width: "95%" }
}

for (var selector in config) {
    $(selector).chosen(config[selector]);
}
