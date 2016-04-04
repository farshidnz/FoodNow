﻿$(function () {
    var ajaxFormSubmit = function () {
        var $form = $(this);
        var options = {
            url: $form.attr("action"),
            type: $form.attr("method"),
            data: $form.serialize()
        };
        $.ajax(options).done(function (data) {
            var $target = $($form.attr("data-fn-target"));
            $target.replaceWith(data);
        });
        return false;
    };

    var submitAutocompleteForm = function (event, ui) {
        var $input = $(this);
        $input.val(ui.item.label);
        var $form = $input.parent("form:first");
        $form.submit();
    };

    var createAutocomplete = function () {
        var $input = $(this);

        var options = {
            source: $input.attr("data-fn-autocomplete")
            //select: submitAutocompleteForm
        }; 
        $input.autocomplete(optsions);
    };
    $("form[data-fn-ajax='true'").submit(ajaxFormSubmit);
    $("iput[data-fn-autocomplete]").each(createAutocomplete);
});